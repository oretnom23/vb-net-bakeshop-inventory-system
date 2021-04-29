Public Class frmListStockout
    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        'SEARCHING
        query = " SELECT TRANSNUM AS [Transaction#],P.PROCODE as [ProductCode], PRONAME AS [Product], CATEGORY AS [Category],DATEOUT AS  [TransactionDate],OUTQTY AS [Quantity],(OUTTOTPRICE & 'PHP') AS [Price] " &
        " FROM tblStockOut as O, tblProductInfo AS P  " &
        " WHERE P.PROCODE=O.PROCODE  AND ( TRANSNUM & ' ' & PRONAME & ' ' & PRODESC & ' ' & CATEGORY & ' ' & OUTTOTPRICE & 'PHP ' & OUTQTY) LIKE '%" & TXTSEARCH.Text & "%'"
        retrieve(query, DTGLIST)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        query = "SELECT TRANSNUM AS [Transaction#],P.PROCODE as [ProductCode], PRONAME AS [Product], CATEGORY AS [Category],DATEOUT AS  [TransactionDate],OUTQTY AS [Quantity],(OUTTOTPRICE & 'PHP') AS [Price]  FROM tblStockOut as O, tblProductInfo AS P  WHERE P.PROCODE=O.PROCODE "
        retrieve(query, DTGLIST)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        With frmStockOut
            .Show()
            .Focus()
            Me.Close()
        End With
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            updateQuery = "UPDATE tblProductInfo AS P, tblStockOut AS S SET PROQTY = PROQTY + OUTQTY  WHERE P.PROCODE=S.PROCODE AND TRANSNUM = " & DTGLIST.CurrentRow.Cells(1).Value
            cudfunctionNOmsg(updateQuery)

            query = "DELETE * FROM tblStockOut WHERE TRANSNUM = " & DTGLIST.CurrentRow.Cells(1).Value
            cudfunctionNOmsg(query)

            MsgBox("Transaction has been deleted.")
            Call btnRefresh_Click(sender, e)
        Catch ex As Exception
            MsgBox("Please select a corresponding records.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmListStockout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call btnRefresh_Click(sender, e)
    End Sub
    Private Sub DTPFROM_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPTO.ValueChanged, DTPFROM.ValueChanged
        'SEARCHING USING DATE
        Dim dfrom As Date = DTPFROM.Text
        Dim dto As Date = DTPTO.Text


        query = " SELECT TRANSNUM AS [Transaction#],P.PROCODE as [ProductCode], PRONAME AS [Product], CATEGORY AS [Category],DATEOUT AS  [TransactionDate],OUTQTY AS [Quantity],(OUTTOTPRICE & 'PHP') AS [Price] " &
         " FROM tblStockOut as O, tblProductInfo AS P  " &
         " WHERE P.PROCODE=O.PROCODE AND  DATEVALUE(DATEOUT) BETWEEN #" & dfrom & "# AND #" & dto & "#"
        retrieve(query, DTGLIST)
    End Sub

End Class
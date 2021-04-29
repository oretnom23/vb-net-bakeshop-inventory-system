Public Class frmListStockin
    Private Sub frmListStockin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "SELECT TRANSNUM AS [Transaction#], P.PROCODE as [ProductCode],PRONAME AS [Product],(' Price: ' & PROPRICE & 'PHP '  & ' ' & PRODESC & '[' & CATEGORY & ']') AS [Description],DATERECEIVED AS [TransactionDate],RECEIVEDQTY AS [Quantity], RECEIVEDTOTPRICE AS [TotalPrice]  FROM tblStockIn as S, tblProductInfo AS P WHERE S.PROCODE=P.PROCODE"
        retrieve(query, DTGLIST)

        frmMaxMinSize(Me, 821, 545)
    End Sub
    Private Sub TXTSEARCH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTSEARCH.TextChanged
        If TXTSEARCH.Text = "" Then
            query = "SELECT TRANSNUM AS [Transaction#], P.PROCODE as [ProductCode], PRONAME  AS [Product],(PRODESC & ' [' & CATEGORY & ']') AS [Description],PROPRICE as [Price],DATERECEIVED AS [TransactionDate],RECEIVEDQTY AS [Quantity], RECEIVEDTOTPRICE AS [TotalPrice]  FROM tblStockIn as S, tblProductInfo AS P  WHERE S.PROCODE=P.PROCODE AND " &
            " (TRANSNUM  & ' '  & P.PROCODE  & ' '  &  PRONAME & ' '  & PRODESC & ' '  & CATEGORY  & ' ' & PROPRICE & ' '  & RECEIVEDQTY & ' '  &  RECEIVEDTOTPRICE) LIKE '%" & TXTSEARCH.Text & "%'"
            retrieve(query, DTGLIST)
        Else
            Dim dfrom As Date = DTPFROM.Text
            Dim dto As Date = DTPTO.Text

            query = "SELECT TRANSNUM AS [Transaction#], P.PROCODE as [ProductCode], PRONAME  AS [Product],(PRODESC & ' [' & CATEGORY & ']') AS [Description],PROPRICE as [Price],DATERECEIVED AS [TransactionDate],RECEIVEDQTY AS [Quantity], RECEIVEDTOTPRICE AS [TotalPrice]  FROM tblStockIn as S, tblProductInfo AS P  WHERE S.PROCODE=P.PROCODE AND " &
          "  DATEVALUE(DATERECEIVED) BETWEEN #" & dfrom & "# AND #" & dto & "# AND (TRANSNUM & ' '  & P.PROCODE   & ' '  & PRONAME & ' '  & PRODESC & ' '  & CATEGORY  & ' ' & PROPRICE & ' '  & RECEIVEDQTY & ' '  &  RECEIVEDTOTPRICE) LIKE '%" & TXTSEARCH.Text & "%'"
            retrieve(query, DTGLIST)
        End If

    End Sub

    Private Sub DTPFROM_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPTO.ValueChanged, DTPFROM.ValueChanged
        Dim dfrom As Date = DTPFROM.Text
        Dim dto As Date = DTPTO.Text

        query = "SELECT TRANSNUM AS [Transaction#], P.PROCODE as [ProductCode], PRONAME  AS [Product],(PRODESC & ' [' & CATEGORY & ']') AS [Description],PROPRICE as [Price],DATERECEIVED AS [TransactionDate],RECEIVEDQTY AS [Quantity], RECEIVEDTOTPRICE AS [TotalPrice]  FROM tblStockIn as S, tblProductInfo AS P  WHERE S.PROCODE=P.PROCODE AND " &
      "  DATEVALUE(DATERECEIVED) BETWEEN #" & dfrom & "# AND #" & dto & "# AND (TRANSNUM  & ' '  & P.PROCODE  & ' '  & PRONAME & ' '  & PRODESC & ' '  & CATEGORY  & ' '  &  PROPRICE & ' '  & RECEIVEDQTY  & ' '  &  RECEIVEDTOTPRICE) LIKE '%" & TXTSEARCH.Text & "%'"
        retrieve(query, DTGLIST)
    End Sub

    'Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
    '    Try
    '        'EDIT A SPECIFIC TRANSACTION
    '        query = "SELECT TRANSNUM, PRONAME ,( PRODESC & ' [' & CATEGORY & ']'), RECEIVEDQTY, DATEVALUE(DATERECEIVED), RECEIVEDTOTPRICE, PROPRICE FROM tblStockIn AS S, tblProductInfo AS P  WHERE S.PROCODE=P.PROCODE AND TRANSNUM = " & DTGLIST.CurrentRow.Cells(1).Value
    '        retrieveSingleResult(query)
    '        'CHECKING IF THE DATA IS EXIST
    '        If dt.Rows.Count > 0 Then
    '            'RESULT:
    '            'PASSING THE DATA TO ITS CURRESPONDING FIELDS
    '            With FRMTRANSEDIT
    '                .StartPosition = FormStartPosition.CenterScreen
    '                .Show()
    '                .Focus()
    '                .MaximizeBox = False
    '                .TXTTRANSNUM.Text = dt.Rows(0).Item(0)
    '                .TXTPRODUCT.Text = dt.Rows(0).Item(1)
    '                .TXTDESC.Text = dt.Rows(0).Item(2)
    '                .TXTQTY.Text = dt.Rows(0).Item(3)
    '                .DateTimePicker1.Text = dt.Rows(0).Item(4)
    '                .LBLPRICE.Text = dt.Rows(0).Item(5)
    '                .LBLPPRICE.Text = dt.Rows(0).Item(6)
    '                .txtPrice.Text = dt.Rows(0).Item(6)
    '                .LBLPPRICE.Visible = False
    '                .Text = "STOCK-IN"
    '            End With


    '        Else
    '            'REFRESHING AND CLEARING 
    '            Call BTNNEW_Click(sender, e)

    '        End If
    '    Catch ex As Exception
    '        MsgBox("Please select a corresponding records.", MsgBoxStyle.Exclamation)
    '    End Try


    'End Sub
    'Private Sub EDITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITToolStripMenuItem.Click
    '    'With FRMTRANSEDIT
    '    '    .Show()
    '    '    .Focus()
    '    '    .Text = DTGLIST.CurrentRow.Cells(0).Value
    '    'End With
    'End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            updateQuery = "UPDATE tblProductInfo AS P, tblStockIn AS S SET PROQTY = PROQTY - RECEIVEDQTY  WHERE P.PROCODE=S.PROCODE AND TRANSNUM = " & DTGLIST.CurrentRow.Cells(1).Value
            cudfunctionNOmsg(updateQuery)

            query = "DELETE * FROM tblStockIn WHERE TRANSNUM = " & DTGLIST.CurrentRow.Cells(1).Value
            cudfunctionNOmsg(query)

            'Call BTNADD_Click(sender, e)
            MsgBox("Transaction has been deleted.")

            Call frmListStockin_Load(sender, e)
        Catch ex As Exception
            MsgBox("Please select a corresponding records.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call frmListStockin_Load(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        With frmStockIn
            .Show()
            .Focus()
            Me.Close()
        End With
    End Sub
End Class
Public Class frmPopupStockin
    Private Sub tsSelect_Click(sender As Object, e As EventArgs) Handles tsSelect.Click
        Try
            With frmStockIn
                .txtPROCODE.Text = dtgList.CurrentRow.Cells(1).Value
                Me.Close()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        query = "SELECT PROCODE as [ProductCode], (PRONAME & ' ' & PRODESC) AS [Product],CATEGORY AS [Category], (PROPRICE & 'PHP') AS [Price],PROQTY AS [Quantity] FROM  tblProductInfo  WHERE (PROCODE & ' ' & PRONAME) LIKE '%" & txtSearch.Text & "%'"
        retrieve(query, dtgList)
    End Sub

    Private Sub frmPopupStockin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "SELECT PROCODE as [ProductCode], (PRONAME & ' ' & PRODESC) AS [Product],CATEGORY AS [Category], (PROPRICE & 'PHP') AS [Price],PROQTY AS [Quantity] FROM  tblProductInfo"
        retrieve(query, dtgList)
    End Sub

    Private Sub tsClose_Click(sender As Object, e As EventArgs) Handles tsClose.Click
        Me.Close()
    End Sub
End Class
Public Class frmPopupStockout
    Private Sub tsSelect_Click(sender As Object, e As EventArgs) Handles tsSelect.Click
        Try
            With frmStockOut
                .txtPROCODE.Text = dtgList.CurrentRow.Cells(1).Value
                Me.Close()
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmPopupStockout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        query = "SELECT PROCODE as [ProductCode], (PRONAME & ' ' & PRODESC) AS [Product],CATEGORY AS [Category], (PROPRICE & 'PHP') AS [Price],PROQTY AS [Quantity] FROM  tblProductInfo"
        retrieve(query, dtgList)
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        query = "SELECT PROCODE as [ProductCode], (PRONAME & ' ' & PRODESC) AS [Product],CATEGORY AS [Category], (PROPRICE & 'PHP') AS [Price],PROQTY AS [Quantity] FROM  tblProductInfo WHERE (PROCODE & ' ' & PRONAME) LIKE '%" & txtSearch.Text & "%'"
        retrieve(query, dtgList)
    End Sub
End Class
Public Class frmListProducts
    Private Sub frmListProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMaxMinSize(Me, 905, 520)
        query = "SELECT PROCODE as [ProductCode], (PRONAME & ' ' & PRODESC) AS [Product],CATEGORY AS [Category], (PROPRICE & 'PHP') AS [Price],PROQTY AS [Quantity] FROM  tblProductInfo"
        retrieve(query, DTGLIST)
        'DTGLIST.Columns(0).Visible = False
        '   DTGLIST.SelectionMode = False
        MaximizeBox = False
    End Sub

    Private Sub TXTSEARCH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTSEARCH.TextChanged


        'Dim match As DataGridViewCell() = (From row As DataGridViewRow In Me.DTGLIST.Rows From cell As DataGridViewCell In row.Cells Select cell Where CStr(cell.FormattedValue).Contains(Me.TXTSEARCH.Text)).ToArray()
        DTGLIST.Columns.Clear()

        Dim conditionF As String
        conditionF = "(PROCODE & ' ' & PRONAME & ' ' & PRODESC  & ' ' & CATEGORY & ' ' & PROPRICE)"

        query = "SELECT PROCODE as [ProductCode], (PRONAME & ' ' & PRODESC) AS [Product],CATEGORY AS [Category], (PROPRICE & 'PHP') AS [Price],PROQTY  AS [Quantity] FROM  tblProductInfo WHERE  " & conditionF & "  LIKE '%" & TXTSEARCH.Text & "%'"
        retrieve(query, DTGLIST)
        ' DTGLIST.Columns(0).Visible = False
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        With frmProducts
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Try
            'query = "DELETE * FROM tblPriceUpdate WHERE PROCODE = " & DTGLIST.CurrentRow.Cells(1).Value
            'cudfunctionNOmsg(query)

            query = "DELETE * FROM tblStockIn WHERE PROCODE = '" & DTGLIST.CurrentRow.Cells(1).Value & "'"
            cudfunctionNOmsg(query)

            query = "DELETE * FROM tblStockOut WHERE PROCODE = '" & DTGLIST.CurrentRow.Cells(1).Value & "'"
            cudfunctionNOmsg(query)

            'query = "DELETE * FROM tblReturnedPro WHERE PROCODE = '" & DTGLIST.CurrentRow.Cells(1).Value & "'"
            'cudfunctionNOmsg(query)

            msgfalse = "Failed to delete"
            msgtrue = "Product has been deleted."
            query = "DELETE * FROM tblProductInfo WHERE PROCODE = '" & DTGLIST.CurrentRow.Cells(1).Value & "'"
            cudfunction(query)


            Call btnRefresh_Click(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message & "//Please select a corresponding records.", MsgBoxStyle.Exclamation)
        End Try


    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            With frmEditProduct
                .txtPROCODE.Text = DTGLIST.CurrentRow.Cells(1).Value
                .Show()
                .Focus()
            End With
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " //Please select a corresponding records.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        query = "SELECT PROCODE as [ProductCode], (PRONAME & ' ' & PRODESC) AS [Product],CATEGORY AS [Category], (PROPRICE & 'PHP') AS [Price],PROQTY AS [Quantity] FROM  tblProductInfo"
        retrieve(query, DTGLIST)
    End Sub
End Class
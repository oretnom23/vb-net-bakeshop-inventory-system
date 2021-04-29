Public Class frmEditProduct
    Private Sub txtPROCODE_TextChanged(sender As Object, e As EventArgs) Handles txtPROCODE.TextChanged
        Try

            'MsgBox(DTGLIST.CurrentRow.Cells(1).Value)


            query = "SELECT PRONAME,PRODESC,CATEGORY, PROPRICE FROM tblProductInfo  WHERE PROCODE='" & txtPROCODE.Text & "'"
            retrieveSingleResult(query)

            If dt.Rows.Count > 0 Then

                For Each r As DataRow In dt.Rows
                    TXTPRONAME.Text = r.Item(0)
                    TXTDESC.Text = r.Item(1)
                    cboCateg.Text = r.Item(2)
                    TXTPRICE.Text = r.Item(3)
                Next
            End If


        Catch ex As Exception
            MsgBox(ex.Message & " //Please select a corresponding records.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        With frmListProducts
            .Show()
            .Focus()
            Me.Close()
        End With
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        Try
            msgfalse = "Error to update Bread."
            msgtrue = "Bread Has Been Updated."

            query = "UPDATE  tblProductInfo  SET PRONAME='" & TXTPRONAME.Text &
                        "' ,PRODESC='" & TXTDESC.Text &
                        "',CATEGORY='" & cboCateg.Text &
                        "',PROPRICE=" & TXTPRICE.Text & "  WHERE PROCODE='" & txtPROCODE.Text & "'"
            cudfunction(query)
        Catch ex As Exception

        End Try
    End Sub
End Class
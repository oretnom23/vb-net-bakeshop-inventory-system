Public Class frmProducts
    Dim maxrow As Integer
    Dim tblfields As String
    Dim proid As Integer
    Private Sub clearNew()
        clear(Me)
        cboCateg.Text = "Select"
        txtAutoNumber(2, txtPROCODE)
        frmMaxMinSize(Me, 608, 480)
    End Sub
    Private Sub BTNSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSAVE.Click


        If TXTPRONAME.Text = "" Or TXTDESC.Text = "" Or cboCateg.Text = "Select" Or TXTPRICE.Text = "" Then
            MsgBox("Empty fields are required inorder to save!", MsgBoxStyle.Exclamation, "Required")

        Else


            query = "SELECT * FROM tblProductInfo WHERE PROCODE='" & txtPROCODE.Text & "'"
            retrieveSingleResult(query)


            If dt.Rows.Count > 0 Then

                msgfalse = "Error to update Bread."
                msgtrue = "Bread Has Been Updated."

                query = "UPDATE  tblProductInfo  SET PRONAME='" & TXTPRONAME.Text &
                            "' ,PRODESC='" & TXTDESC.Text &
                            "',CATEGORY='" & cboCateg.Text &
                            "',PROPRICE=" & TXTPRICE.Text & "  WHERE PROCODE='" & txtPROCODE.Text & "'"
                cudfunction(query)

            Else

                msgtrue = "New Bread Has Been Saved."
                msgfalse = "Error to save Product."

                tblfields = "PROCODE,PRONAME,PRODESC,CATEGORY,PROPRICE,PROQTY"
                query = "INSERT INTO tblProductInfo (" & tblfields & ")" _
                & " VALUES ( '" & txtPROCODE.Text & "', '" & TXTPRONAME.Text & "','" & TXTDESC.Text & "','" & cboCateg.Text & "','" & TXTPRICE.Text & "',0)"
                cudfunction(query)

                updateAutoNumber(2)
            End If

            clearNew()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        clearNew()

    End Sub


    Private Sub FRMITEM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearNew()

    End Sub

    Private Sub TXTPRICE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTPRICE.KeyPress
        Try

            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then e.Handled = False '
                ElseIf TXTPRICE.Text.Contains(".") Then
                    MessageBox.Show("Only one decimal point allowed")
                Else
                    e.Handled = False
                End If
            End If

        Catch ex As Exception
            logs(ex.Message & " at TXTPRICE_KeyUp")
            MsgBox(ex.Message & " at TXTPRICE_KeyUp")
        End Try
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
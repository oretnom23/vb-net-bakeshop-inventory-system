Public Class frmStockIn
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ShowForm(Me, frmPopupStockin)
        With frmPopupStockin
            .ShowDialog()
        End With
    End Sub

    Private Sub BTNCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCLOSE.Click
        Me.Close()
    End Sub

    Private Sub BTNNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNEW.Click
        clear(GroupBox1)
        clear(GroupBox3)
        CBOUNIT.Text = ""
        LBLMSG.Text = ""
        LBLUNIT.Text = ""
        LBLMSG.BackColor = Color.Transparent
        ' autonum
        txtAutoNumber(1, LBLTRANSNUM)


        frmMaxMinSize(Me, 831, 537)

        txtAutoComplete("SELECT PROCODE FROM tblProductInfo", txtPROCODE)

    End Sub

    Private Sub BTNADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNADD.Click
        If TXTDESC.Text <> "" And TXTQTY.Text <> "" Then

            'STOCK IN PROCESS
            fields = "TRANSNUM,PROCODE,DATERECEIVED,RECEIVEDQTY,RECEIVEDUNIT,RECEIVEDTOTPRICE"
            fvalue = LBLTRANSNUM.Text & "','" & txtPROCODE.Text & " ','" & DTPTRANSDATE.Value & "','" & TXTQTY.Text & "','" & CBOUNIT.Text & "','" & TXTTOT.Text

            query = "INSERT INTO tblStockIn (" & fields & ") VALUES ('" & fvalue & "')"
            cudfunctionNOmsg(query)
            ''END
            'ADDING THE QTY OF THE STOCK
            updateQuery = "UPDATE tblProductInfo SET PROQTY = PROQTY + '" & TXTQTY.Text & "'  WHERE PROCODE = '" & txtPROCODE.Text & "'"
            cudfunctionNOmsg(updateQuery)
            'END

            'SUCCESS MSH
            LBLMSG.Text = "The " & TXTPRODUCT.Text & " has been added into the inventory."
            LBLMSG.BackColor = Color.Aquamarine
            LBLMSG.ForeColor = Color.Black


            'update autonumber
            updateAutoNumber(1)

            Call BTNNEW_Click(sender, e)



        Else
            LBLMSG.Text = "Fill up the correct product in the empty fields inorder to save."
            LBLMSG.BackColor = Color.Red
            LBLMSG.ForeColor = Color.White
            Beep()
        End If
    End Sub
    Private Sub TXTQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTQTY.KeyPress
        Try

            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then
                        e.Handled = False '

                    End If

                ElseIf TXTQTY.Text.Contains(".") Then
                    MessageBox.Show("Only one decimal point allowed")
                Else
                    e.Handled = False
                End If
            End If

        Catch ex As Exception
            logs(ex.Message & " at TXTQTY_KeyPress")
            MsgBox(ex.Message & " at TXTQTY_KeyPress")
        End Try
    End Sub

    Private Sub TXTQTY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTQTY.TextChanged
        Try
            If TXTQTY.Text = "" Then
                TXTTOT.Text = 0
            Else
                TXTTOT.Text = Double.Parse(TXTPRICE.Text) * Double.Parse(TXTQTY.Text)
            End If
        Catch ex As Exception

        End Try



    End Sub
    Private Sub txtPROCODE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPROCODE.TextChanged
        Try
            query = "SELECT * FROM tblProductInfo WHERE PROCODE ='" & txtPROCODE.Text & "'"
            retrieveSingleResult(query)

            If dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    TXTPRODUCT.Text = .Item("PRONAME")
                    TXTDESC.Text = .Item("PRODESC") & " [" & .Item("CATEGORY") & "]"
                    TXTPRICE.Text = .Item("PROPRICE")
                End With
            Else
                TXTPRODUCT.Clear()
                TXTDESC.Clear()
                TXTPRICE.Clear()
                TXTQTY.Clear()
                TXTTOT.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmStockIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call BTNNEW_Click(sender, e)
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        With frmListStockin
            .Show()
            .Focus()
            Me.Close()
        End With
    End Sub
End Class
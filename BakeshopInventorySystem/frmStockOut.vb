Public Class frmStockOut
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With frmPopupStockout
            .ShowDialog()
        End With
    End Sub

    Private Sub txtPROCODE_TextChanged(sender As Object, e As EventArgs) Handles txtPROCODE.TextChanged
        Try
            query = "SELECT * FROM tblProductInfo WHERE PROCODE ='" & txtPROCODE.Text & "'"
            retrieveSingleResult(query)

            If dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    TXTPRODUCT.Text = .Item("PRONAME")
                    TXTDESC.Text = .Item("PRODESC") & " [" & .Item("CATEGORY") & "]"
                    TXTPRICE.Text = .Item("PROPRICE")
                    TXTAVAILQTY.Text = .Item("PROQTY")
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

    Private Sub BTNNEW_Click(sender As Object, e As EventArgs) Handles BTNNEW.Click
        Try

            clear(GroupBox1)
            clear(GroupBox2)
            LBLMSG.Text = ""
            LBLMSG.BackColor = Color.Transparent

            frmMaxMinSize(Me, 831, 551)

            query = "SELECT  PROCODE  FROM   tblProductInfo"
            txtAutoComplete(query, txtPROCODE)


            'query = "SELECT TRANSNUM AS [Transaction#],P.PROCODE as [ProductCode], PRONAME AS [Product], CATEGORY AS [Category],DATEOUT AS  [TransactionDate],OUTQTY AS [Quantity],(OUTTOTPRICE & 'PHP') AS [Price]  FROM tblStockOut as O, tblProductInfo AS P  WHERE P.PROCODE=O.PROCODE "
            'retrieve(query, DTGLIST)

            ' autonum
            txtAutoNumber(1, LBLTRANSNUM)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        Try

            If TXTDESC.Text <> "" And TXTQTY.Text <> "" Then


                Dim Rqty As Double = Double.Parse(TXTAVAILQTY.Text)
                Dim qty As Double = Double.Parse(TXTQTY.Text)


                If Rqty < qty Then
                    'not valid
                    LBLMSG.Text = "Not valid. The entered quantity is greater than the available quantity!"
                    LBLMSG.BackColor = Color.Red
                    LBLMSG.ForeColor = Color.White
                    Beep()
                Else
                    'ADD TO THE STOCKOUT TABLE
                    fields = "TRANSNUM,PROCODE,DATEOUT,OUTQTY,OUTUNIT,OUTTOTPRICE"
                    fvalue = LBLTRANSNUM.Text & "','" & txtPROCODE.Text & "','" & DTPTRANSDATE.Value & "','" & TXTQTY.Text & "','" & LBLUNIT.Text & "','" & TXTTOT.Text

                    query = "INSERT INTO tblStockOut (" & fields & ") VALUES ('" & fvalue & "')"
                    cudfunctionNOmsg(query)
                    'END
                    'MINUS THE QTY OF THE PRODUCT
                    updateQuery = "UPDATE tblProductInfo SET PROQTY = PROQTY - " & TXTQTY.Text & "  WHERE PROCODE = '" & txtPROCODE.Text & "'"
                    cudfunctionNOmsg(updateQuery)
                    'END

                    'SUCCESS MSG
                    LBLMSG.Text = "The " & TXTPRODUCT.Text & " has been deducted into the inventory."
                    LBLMSG.BackColor = Color.Aquamarine
                    LBLMSG.ForeColor = Color.Black

                    'update autonumber
                    updateAutoNumber(1)

                    Call BTNNEW_Click(sender, e)



                End If
            Else
                LBLMSG.Text = "Fill up the correct product in the empty fields inorder to save."
                LBLMSG.BackColor = Color.Red
                LBLMSG.ForeColor = Color.White
                Beep()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXTQTY_TextChanged(sender As Object, e As EventArgs) Handles TXTQTY.TextChanged
        Try

            If TXTQTY.Text = "" Then
                TXTTOT.Text = 0
                TXTREMAINQTY.Text = TXTAVAILQTY.Text
            Else
                TXTREMAINQTY.Text = Double.Parse(TXTAVAILQTY.Text) - Double.Parse(TXTQTY.Text)
                TXTTOT.Text = Double.Parse(TXTPRICE.Text) * Double.Parse(TXTQTY.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXTQTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTQTY.KeyPress
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

    Private Sub frmStockOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call BTNNEW_Click(sender, e)
    End Sub

    Private Sub BTNCLOSE_Click(sender As Object, e As EventArgs) Handles BTNCLOSE.Click
        Me.Close()

    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        With frmListStockout
            .Show()
            .Focus()
            Me.Close()
        End With
    End Sub
End Class
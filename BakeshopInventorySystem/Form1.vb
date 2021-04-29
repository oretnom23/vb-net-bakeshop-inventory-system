Public Class Form1
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        'Try
        '    If LoginToolStripMenuItem.Text = "Login" Then

        '        With LoginForm1
        '            .Show() '
        '            .Focus()

        '        End With
        '    Else
        '        LoginToolStripMenuItem.Text = "Login"
        '    End If
        'Catch ex As Exception

        'End Try
        Me.Close()

    End Sub

    Private Sub AddNewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewProductToolStripMenuItem.Click
        With frmProducts
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ListOfProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfProductsToolStripMenuItem.Click
        With frmListProducts
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        With frmStockIn
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ReceiveProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveProductsToolStripMenuItem.Click
        With frmListStockin
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub SoldProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoldProductToolStripMenuItem.Click
        With frmStockOut
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ListOfSoldProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfSoldProductsToolStripMenuItem.Click
        With frmListStockout
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click
        With frmUser
            .Show()
            .Focus()
        End With
    End Sub
    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        With frmReport
            .Show()
            .Show()
        End With
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub visibleMenu()
        ProductToolStripMenuItem.Enabled = False
        TransactionToolStripMenuItem.Enabled = False
        ManageUsersToolStripMenuItem.Enabled = False
        ReportsToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmProducts.Close()
        frmStockIn.Close()
        frmStockOut.Close()
        frmReport.Close()
        frmEditProduct.Close()
        frmListStockin.Close()
        frmListProducts.Close()
        frmListStockout.Close()
        frmUser.Close()
        frmPrintPreview.Close()
        With LoginForm1
            .Show()
            .Focus()
            .UsernameTextBox.Clear()
            .PasswordTextBox.Clear()
            .UsernameTextBox.Focus()
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class

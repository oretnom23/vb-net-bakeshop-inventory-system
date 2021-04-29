Public Class frmUser

    Private Sub FRMUSER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmMaxMinSize(Me, 638, 591)

        query = "SELECT USERID , U_NAME AS [Name],U_UNAME AS [Username],U_TYPE AS [Role] FROM tblUser"
        retrieve(query, dtglist)
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtname.Text <> "" And txtusername.Text <> "" And txtpass.Text <> "" And cbotype.Text <> "" Then
            If LBLUSERID.Text = "USERID" Then
                msgtrue = "New user has been saved."
                msgfalse = "User not saved."
                query = "INSERT INTO tblUser ( U_NAME,U_UNAME,U_PASS,U_TYPE) VALUES ('" & txtname.Text & "','" & txtusername.Text _
            & "','" & txtpass.Text & "','" & cbotype.Text & "')"
                cudfunction(query)
            Else
                msgtrue = "User has been updated."
                msgfalse = "User is not updated."
                query = "UPDATE tblUser SET U_NAME='" & txtname.Text & "',U_UNAME='" & txtusername.Text _
            & "',U_PASS='" & txtpass.Text & "',U_TYPE='" & cbotype.Text & "' WHERE USERID=" & LBLUSERID.Text
                cudfunction(query)
            End If

            Call btnnew_Click(sender, e)

            query = "SELECT USERID , U_NAME AS [Name],U_UNAME AS [Username], U_TYPE AS [Role] FROM tblUser"
            retrieve(query, dtglist)
        Else
            MsgBox("Fields are required!", MsgBoxStyle.Exclamation)
        End If



    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        query = "SELECT USERID , U_NAME AS [Name],U_UNAME AS [Username] ,U_TYPE AS [Role] FROM tblUser WHERE (USERID & ' ' & U_NAME  & ' ' &  U_UNAME  & ' ' &  U_TYPE) LIKE '%" & txtsearch.Text & "%'"
        retrieve(query, dtglist)
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        clear(Panel2)
        cbotype.Text = ""
        LBLUSERID.Text = "USERID"

        query = "SELECT USERID , U_NAME AS [Name],U_UNAME AS [Username], U_TYPE AS [Role] FROM tblUser"
        retrieve(query, dtglist)
    End Sub

    Private Sub dtglist_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglist.CellClick
        Try
            LBLUSERID.Text = dtglist.CurrentRow.Cells(1).Value
            query = "SELECT * FROM tblUser WHERE USERID=" & LBLUSERID.Text
            retrieveSingleResult(query)
            With dt.Rows(0)
                If dt.Rows.Count > 0 Then
                    txtname.Text = .Item(1)
                    txtusername.Text = .Item(2)
                    txtpass.Text = .Item(3)
                    cbotype.Text = .Item(4)
                End If
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        msgtrue = "User has been deleted."
        msgfalse = "User is not deleted."
        query = "DELETE * FROM tblUser WHERE USERID = " & dtglist.CurrentRow.Cells(1).Value
        cudfunction(query)

        Call btnnew_Click(sender, e)
    End Sub
End Class
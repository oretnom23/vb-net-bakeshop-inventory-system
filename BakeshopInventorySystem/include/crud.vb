Module crud
    Public Sub cudfunction(ByVal query As String)
        con.Open()
        Try
            With cmd
                .Connection = con
                .CommandText = query
            End With
            result = cmd.ExecuteNonQuery()

            If result = True Then
                MsgBox(msgtrue)
            Else
                MsgBox(msgfalse, MsgBoxStyle.Critical)
            End If


        Catch ex As Exception
            logs(ex.Message & " at cudfunction sub Procedure")
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    Public Sub retrieveSingleResult(ByVal query As String)

        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = query
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)
           
            'da.Fill(ds, "tblProductInfo")
         
        Catch ex As Exception
            logs(ex.Message & " at retrieveSingleResult sub Procedure")
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub 

    Public Sub retrieve(ByVal query As String, ByVal dtg As DataGridView)

        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = query
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)

            dtg.Columns.Clear()
            dtg.Columns.Add("count", "#")


            dtg.DataSource = dt
            Dim MAXROW As Integer = dt.Rows.Count - 1

            For i = 0 To MAXROW
                dtg.Rows(i).Cells(0).Value = i
            Next
            With dtg
                .Columns(0).Width = 18
                '   .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.Columns(1).Visible = False
                .Font = New Font("arial", 8, FontStyle.Bold)
                .SelectionMode = False
            End With


        Catch ex As Exception
            logs(ex.Message & " at retrieve sub Procedure")
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
    Public Sub cudfunctionNOmsg(ByVal query As String)
        con.Open()
        Try
            With cmd
                .Connection = con
                .CommandText = query
            End With
            result = cmd.ExecuteNonQuery()
 
        Catch ex As Exception
            logs(ex.Message & " at cudfunction sub Procedure")
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
End Module

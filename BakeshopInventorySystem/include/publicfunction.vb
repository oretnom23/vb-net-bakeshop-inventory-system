Imports System.IO
Module publicfunction
    Public Sub clear(ByVal container As Object)
        Try
            For Each txt As Control In container.Controls
                If TypeOf txt Is TextBox Or TypeOf txt Is RichTextBox Then
                    txt.Text = ""
                End If
            Next
        Catch ex As Exception
            logs(ex.Message & " at clear sub Procedure")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub logs(ByVal errormsg As Object)
        Try
            'DECLARE A STRING VARIABLE TO HOLD THE PATH AND THE NAME OF THE TEXT FILE 
            Dim path_file As String = String.Format(Application.StartupPath & "\errorlogs\Logs.log", DateTime.Today.ToString("dd-MMM-yyyy"))
            'DECLARE A BOOLEAN VARIABLE TO DETERMINE WHETHER THE SPECIFIED FILE EXIST.
            Dim exist_file As Boolean = File.Exists(path_file)
            'CALL STREAMWRITER AND USE IT TO CREATE A TXT FILE.
            Using stream_writer As New StreamWriter(path_file, True)
                If Not exist_file Then 'CHECK THE TXT FILE IF IT DOES'NT EXIST.
                    'RESULT
                    'WRITE THE TEXT IN THE FIRST LINE.
                    stream_writer.WriteLine("Log starts")
                End If
                'WRITE THE ERROR MESSAGE.
                stream_writer.WriteLine("The Error Occured at " & DateTime.Now & " :: " & errormsg)
            End Using

        Catch ex As Exception
            MsgBox(ex.Message & "at logs sub")
        End Try

    End Sub

    Public Sub CBOFILL(ByVal query As String, ByVal combo As ComboBox, ByVal member As String, ByVal id As String)
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = query
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd

            ds = New DataSet
            da.Fill(ds)

            With combo
                .DataSource = ds.Tables(0)
                .DisplayMember = member
                .ValueMember = id
                '.SelectedValue = True
            End With

        Catch ex As Exception
            logs(ex.Message & " at CBOFILL sub Procedure")
            MsgBox(ex.Message & " at CBOFILL sub Procedure")
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
 
    Public Sub txtAutoComplete(ByVal query As String, ByVal txt As Object)
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

            txt.AutoCompleteMode = AutoCompleteMode.Suggest
            txt.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt.AutoCompleteCustomSource.clear()
            Dim r As DataRow

            For Each r In dt.Rows
                txt.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next r

        Catch ex As Exception
            logs(ex.Message & " at txtAutoComplete sub Procedure")
            MsgBox(ex.Message & " at txtAutoComplete sub Procedure")
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
    Public Sub checkData(ByVal Checkquery As String, ByVal insertQuery As String, ByVal updateQuery As String)
        Try
            con.Open()

            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = Checkquery
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cudfunctionNOmsg(updateQuery)
            Else
                cudfunctionNOmsg(insertQuery)
            End If

        Catch ex As Exception
            logs(ex.Message & " at checkData sub Procedure")
            MsgBox(ex.Message & " at checkData sub Procedure")
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
    Public Sub checkTransaction(ByVal Checkquery As String, ByVal insertQuery As String, ByVal updateQuery As String)
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = Checkquery
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cudfunctionNOmsg(updateQuery)
            Else
                cudfunctionNOmsg(insertQuery)
            End If

        Catch ex As Exception
            logs(ex.Message & " at checkData sub Procedure")
            MsgBox(ex.Message & " at checkData sub Procedure")
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
    Public Function FindMyText(ByVal text As String, ByVal start As Integer, ByVal richTextBox As RichTextBox) As Integer
        ' Initialize the return value to false by default.
        Dim returnValue As Integer = -1

        ' Ensure that a search string has been specified and a valid start point.
        If text.Length > 0 And start >= 0 Then
            ' Obtain the location of the search string in richTextBox1.
            Dim indexToText As Integer = richTextBox.Find(text, start, _
                RichTextBoxFinds.MatchCase)
            ' Determine whether the text was found in richTextBox1.
            If indexToText >= 0 Then
                MsgBox(indexToText)
            End If
        End If

        Return returnValue
    End Function
    Public Sub txtAutoNumber(ByVal autoid As Integer, ByVal txt As Object)
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = "SELECT (STARTNUM & INCNUM) FROM tblAutoNumber WHERE ID=" & autoid
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                txt.text = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            logs(ex.Message & " at txtAutoNumber sub Procedure")
            MsgBox(ex.Message & " at txtAutoNumber sub Procedure")
        Finally
            con.Close()
            da.Dispose()
        End Try

    End Sub
    Public Sub updateAutoNumber(ByVal autoid As Integer)

        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = "UPDATE tblAutoNumber SET  INCNUM=INCNUM + 1 WHERE ID=" & autoid
                .ExecuteNonQuery()
            End With


        Catch ex As Exception
            logs(ex.Message & " at txtAutoNumber sub Procedure")
            MsgBox(ex.Message & " at txtAutoNumber sub Procedure")
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub frmMaxMinSize(ByVal frm As Form, ByVal w As Integer, ByVal h As Integer)
        frm.MaximumSize = New Size(w, h)
        frm.MinimumSize = New Size(w, h)
    End Sub
    Public Sub ShowForm(ByVal mainForm As Form, ByVal OpenForm As Form)
        Try
            'mainForm.SendToBack()
            OpenForm.Show()
            OpenForm.Focus()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub LoginUser(ByVal userid As Object, ByVal pass As Object)
        Try
            con.Open()

            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM tblUser WHERE U_UNAME ='" & userid.Text & "' AND U_PASS = '" & pass.Text & "'"
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                If dt.Rows(0).Item("U_TYPE") = "Administrator" Then

                    MsgBox("You login as administrator!!")

                    ShowForm(LoginForm1, Form1)


                    LoginForm1.Hide()
                ElseIf dt.Rows(0).Item("U_TYPE") = "Staff" Then

                    MsgBox("You login as Staff!!")

                    With Form1
                        '.ManageUsersToolStripMenuItem.Visible = False

                    End With

                    ShowForm(LoginForm1, Form1)


                    LoginForm1.Hide()
                End If 

            Else
                MsgBox("Account does not exists.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

#Region "Report"
    Public Sub reports(ByVal sql As String, ByVal rptname As String, ByVal crystalRpt As Object)
        Try
            con.Open()

            Dim reportname As String
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            ds = New DataSet
            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd
            da.Fill(ds)
            reportname = rptname
            Dim reportdoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim strReportPath As String
            strReportPath = Application.StartupPath & "\reports\" & reportname & ".rpt"
            With reportdoc
                .Load(strReportPath)
                .SetDataSource(ds.Tables(0))
            End With
            With crystalRpt
                ' .ShowRefreshButton = False
                .ShowCloseButton = False
                .ShowGroupTreeButton = False

                .ReportSource = reportdoc
            End With
        Catch ex As Exception
            MsgBox(ex.Message & "No Crystal Reports have been Installed")
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
#End Region


#Region "EDIT TRANSACTIONS"
    Public Sub TRANSACTIONPROCESS(ByVal ACTIONTABLE As String, ByVal TBL As String, ByVal TRANSNUM As Integer, ByVal QTY As Double)
        Try
            Select Case ACTIONTABLE
                Case "ADD_QTY_PRODUCT"
                    updateQuery = "UPDATE tblProductInfo AS P," & TBL & " AS S SET PROQTY = PROQTY + " & QTY & " WHERE P.PROCODE = S.PROCODE AND TRANSNUM =" & TRANSNUM
                    cudfunctionNOmsg(updateQuery)

                Case "DEDUCT_QTY_PRODUCT"
                    updateQuery = "UPDATE tblProductInfo AS P," & TBL & " AS S SET PROQTY = PROQTY- " & QTY & " WHERE P.PROCODE = S.PROCODE AND TRANSNUM =" & TRANSNUM
                    cudfunctionNOmsg(updateQuery)

                Case "DEDUCT_QTY_STOCKOUT"
                    updateQuery = "UPDATE  " & TBL & "  SET OUTQTY = OUTQTY - " & QTY & " WHERE  TRANSNUM =" & TRANSNUM
                    cudfunctionNOmsg(updateQuery)

                Case "ADD_QTY_STOCKOUT"
                    updateQuery = "UPDATE  " & TBL & "  SET OUTQTY = OUTQTY + " & QTY & " WHERE  TRANSNUM =" & TRANSNUM
                    cudfunctionNOmsg(updateQuery)

                Case "ADD_QTY_RETURN"
                    updateQuery = "UPDATE tblProductInfo AS P," & TBL & " AS S SET PROQTY = PROQTY + " & QTY & " WHERE P.PROCODE = S.PROCODE AND RETURNEDPROID =" & TRANSNUM
                    cudfunctionNOmsg(updateQuery)

                Case "DEDUCT_QTY_RETURN"
                    updateQuery = "UPDATE tblProductInfo AS P," & TBL & " AS S SET PROQTY = PROQTY - " & QTY & " WHERE P.PROCODE = S.PROCODE AND RETURNEDPROID =" & TRANSNUM
                    cudfunctionNOmsg(updateQuery)

            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
#End Region
End Module

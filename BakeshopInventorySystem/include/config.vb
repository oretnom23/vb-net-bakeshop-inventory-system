Module config
    Public databasename As String = "\dbBakeshop.accdb"
    Private Function configdb() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" _
                                     & Application.StartupPath & "\dbBakeshop.accdb; " & My.Settings.PASSWORD)
    End Function
    Public con As OleDb.OleDbConnection = configdb()
End Module

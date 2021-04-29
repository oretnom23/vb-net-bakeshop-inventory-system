Module publicvariable
    ' Public PASSWORDS As String = "JET OLEDB:Database Password = JANOBE"
    Public query As String
    Public da As New OleDb.OleDbDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet
    Public cmd As New OleDb.OleDbCommand
    Public result As Boolean
    Public msgfalse As String = "false"
    Public msgtrue As String = "True"
    Public fields As String = ""
    Public fvalue As String = ""
    Public checkQuery As String = ""
    Public insertQuery As String = ""
    Public updateQuery As String = ""
End Module

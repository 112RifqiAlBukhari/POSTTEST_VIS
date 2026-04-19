Imports MySqlConnector

Module ConnectionModule
    ' Sesuaikan Database dengan nama db_restostok
    Public ReadOnly ConnectionString As String =
    "Server=localhost;Port=3306;Database=db_restostok;UserID=root;Password=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function
End Module
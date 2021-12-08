Imports MySql.Data.MySqlClient

Public Module SQLModule
    Public BP_CON(4) As MySqlConnection
    Public BP_STR(4) As String

    Dim sql_db As String
    Dim sql_addr As String
    Dim sql_port As Integer
    Dim sql_id As String
    Dim sql_pw As String

    Public Function DB_INITIATE(db As String, addr As String,
                                port As Integer, id As String, pw As String)
        Try
            sql_db = db
            sql_addr = addr
            sql_port = port
            sql_id = id
            sql_pw = pw
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function DB_OPEN(ByVal INDEX As Integer) As Boolean

        Try
            BP_STR(0) = "database=" + sql_db _
                      + ";server=" + sql_addr _
                      + ";port=" + sql_port.ToString _
                      + ";user id=" + sql_id _
                      + ";password=" + sql_pw _
                      + ";CharSet=utf8;Connect Timeout=5000;" 'Timeout은 네트워크 환경에 맞게
            BP_CON(INDEX) = New MySqlConnection(BP_STR(0))
            BP_CON(INDEX).Open()
            DB_OPEN = True
        Catch ex As Exception
            DB_OPEN = False
        End Try
    End Function

    Public Function DB_CLOSE(ByVal INDEX As Integer) As Boolean
        Try
            BP_CON(INDEX).Close()
            DB_CLOSE = True
        Catch ex As Exception
            DB_CLOSE = False
        End Try
    End Function

    Public Function GL_DB_READER(ByVal IM_ISQL As String, ByVal INDEX As Integer) As MySqlDataReader
        If IsNothing(BP_CON(INDEX)) Then DB_OPEN(INDEX)
        If BP_CON(INDEX).State <> ConnectionState.Open Then
            If DB_OPEN(INDEX) = False Then
                Throw New System.Exception("DB 연결 실패")
            End If
        End If

        Dim SCMD = New MySqlCommand(IM_ISQL, BP_CON(INDEX))
        Dim RS = SCMD.ExecuteReader
        Return RS
    End Function
End Module

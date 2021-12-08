Imports System.Security.Cryptography
Imports System.Text

Module DataModule


    '유닉스 개행문자를 윈도우(DOS) 개행문자로 변환하는 함수
    Public Function newlineConverter(input As String)
        Return input.Replace(vbCrLf, vbLf).Replace(vbCr, vbLf).Replace(vbLf, vbCrLf)
    End Function
    Public Function GenerateSHA256String(ByVal inputString) As String
        Dim sha256 As SHA256 = SHA256.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next

        Return stringBuilder.ToString()
    End Function

End Module

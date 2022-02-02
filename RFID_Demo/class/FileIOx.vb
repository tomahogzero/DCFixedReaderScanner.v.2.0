Imports System.IO
Imports webAPI.Models

Public Class FileIO

    Public Shared Sub WriteToFile(strToWrite As String)
        Dim stream As IO.StreamWriter = Nothing
        Try
            Dim fileName As String = "Log-" & Format(Now.Date, "yyyyMMdd")
            stream = New IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Log\" + fileName + ".txt", True)

            stream.WriteLineAsync(strToWrite)
            stream.Flush()
            stream.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub WriteLogToFile(strToWrite As String)
        Dim stream As IO.StreamWriter = Nothing
        Try
            Dim fileName As String = "Log-" & Format(Now.Date, "yyyyMMdd")
            stream = New IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Log\" + fileName + ".txt", True)

            stream.WriteLineAsync(Format(Now, "dd-MM-yyyy HH:mm:ss") & " " & strToWrite)
            stream.Flush()
            stream.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub WriteProgressLogToFile(fileName As String, strToWrite As String)
        Dim stream As IO.StreamWriter = Nothing
        Try
            'Dim fileName As String = "Log-" & Format(Now.Date, "yyyyMMdd")
            stream = New IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Log\" + fileName + ".txt", False)

            stream.WriteLineAsync(Format(Now, "dd-MM-yyyy HH:mm:ss") & " " & strToWrite)
            stream.Flush()
            stream.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub WriteTagLogToFile(fileName As String, strToWrite As String)
        Dim stream As IO.StreamWriter = Nothing
        Try
            'Dim fileName As String = "Log-" & Format(Now.Date, "yyyyMMdd")
            stream = New IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Log\" + fileName + ".txt", False)

            stream.WriteLineAsync(Format(Now, "dd-MM-yyyy HH:mm:ss") & " " & strToWrite)
            stream.Flush()
            stream.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Function getProxyCredentials() As modelProxyCredentials
        Dim rec As Integer = 0

        Dim md As New modelProxyCredentials
        md.enable = True
        md.username = ""
        md.password = ""
        md.domain = ""


        Try
            Dim filename As String = AppDomain.CurrentDomain.BaseDirectory & "Proxy.Credentials.Config.txt"

            Dim SR As StreamReader

            SR = New StreamReader(filename, System.Text.Encoding.GetEncoding("TIS-620"))
            Dim i As Long = 0
            Dim line As String = ""

            Dim data As String()

            line = SR.ReadLine
            Do While (line IsNot Nothing)
                If line IsNot Nothing Then
                    data = line.Split(":")

                    Select Case data(0).ToString.ToLower.Trim()
                        Case "username"
                            md.username = data(1).ToString.Trim()
                            'WriteLogToFile("uid : " & md.username)
                        Case "password"
                            md.password = data(1).ToString.Trim()
                            'WriteLogToFile("pwd : " & md.password)
                        Case "domain"
                            md.domain = data(1).ToString.Trim()
                            'WriteLogToFile("domain : " & md.domain)
                    End Select
                End If
                line = SR.ReadLine
            Loop

            SR.Close()
            Return md
        Catch ex As Exception
            WriteLogToFile(" Load Proxy File : " & ex.Message)
        End Try
        Return md
    End Function
End Class

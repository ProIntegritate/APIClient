Imports System

Module Program

    Sub Main(sArgs() As String)
        Dim sIndata As String = ""
        Try
            sIndata = System.Text.Encoding.Default.GetString(Convert.FromBase64String(sArgs(0))) ' Decode passed Base64 parameter, fail if: 1. No argument, 2 Base64 decode fails.
        Catch ex As Exception
            ' Fail silently here if Base64 decode fails
        End Try

        If sIndata.Trim <> "" Then
            Console.WriteLine("Passed indata was:" & sIndata)
        End If

        Dim d As DateTime = DateTime.UtcNow
        Console.Write("Response written at time: ")
        Console.WriteLine(d.ToString("o") & " (UTC)")

        Environment.Exit(0)
    End Sub

End Module

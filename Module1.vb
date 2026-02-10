Imports System.IO
Module Module1
    Sub Main()
        Dim path As String = "nilai.txt"

        ' Cek file 
        If File.Exists(path) Then
            BacaFileNilai(path)
        Else
            Console.WriteLine("File nilai.txt tidak ditemukan!")
        End If

        Console.ReadLine()
    End Sub

    ' ===== PROCEDURE =====
    Sub BacaFileNilai(ByVal path As String)
        Dim lines() As String = File.ReadAllLines(path)

        Console.WriteLine("DAFTAR NILAI MAHASISWA")
        Console.WriteLine("=====================")

        ' ===== PERULANGAN =====
        For Each line As String In lines
            Dim data() As String = line.Split(",")

            Dim nama As String = data(0)
            Dim nilai As Integer = Convert.ToInt32(data(1))
            Dim status As String

            ' ===== PERCABANGAN =====
            If nilai >= 70 Then
                status = "LULUS"
            Else
                status = "TIDAK LULUS"
            End If

            Console.WriteLine("Nama   : " & nama)
            Console.WriteLine("Nilai  : " & nilai)
            Console.WriteLine("Status : " & status)
            Console.WriteLine("---------------------")
        Next
    End Sub

End Module

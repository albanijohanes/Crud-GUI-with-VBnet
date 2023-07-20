Imports MySql.Data.MySqlClient
Module koneksi
    Public conn As New MySqlConnection
    Public query As String
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public cmd As MySqlCommand

    Sub konek()
        Try
            conn.Close()
            conn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};Database=db_mahasiswa;Server=localhost;uid=root"
            MessageBox.Show("Koneksi berhasil.")
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
End Module

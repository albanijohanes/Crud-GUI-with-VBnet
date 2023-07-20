Imports MySql.Data.MySqlClient
Public Class Form1
    Sub tampildata()
        DS = New DataSet
        query = "select * from tb_mahasiswa"
        DA = New MySqlDataAdapter(query, conn)
        DA.Fill(DS)

        DataGridView1.DataSource = DS.Tables(0)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
        tampildata()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        cmd = New MySqlCommand
        cmd.Connection = conn
        query = "insert into tb_mahasiswa values ('" & txtNimMahasiswa.Text & "','" & txtNamaMahasiswa.Text & "','" & txtJk.Text & "')"
        cmd.CommandText = query
        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil ditambahkan", vbInformation, "Pemberitahuan")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        cmd = New MySqlCommand
        cmd.Connection = conn
        query = "update tb_mahasiswa set nama='" & txtNamaMahasiswa.Text & "', jk='" & txtJk.Text & "', where nim='" & txtNimMahasiswa.Text & "'"
        cmd.CommandText = query
        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil di update", vbInformation, "Pemberitahuan")

        tampildata()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        txtNimMahasiswa.Text = DataGridView1.Item(0, i).Value
        txtNamaMahasiswa.Text = DataGridView1.Item(1, i).Value
        txtJk.Text = DataGridView1.Item(2, i).Value
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah anda yakin ingin menghapus?", vbYesNo) = vbYes Then
            cmd = New MySqlCommand
            cmd.Connection = conn
            query = "Delete from tb_mahasiswa where nis='" & txtNimMahasiswa.Text & "'"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus", vbInformation, "pemberitahuan")

            tampildata()
        End If
    End Sub
End Class

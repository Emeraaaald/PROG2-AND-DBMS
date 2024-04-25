Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;passowrd=;database=emeraldpic")

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

        Dim command As New MySqlCommand("INSERT INTO `pictbl`(`name`, `course`, `pic`) VALUES (@name,@course,@pic)", connection)

        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@course", MySqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("@pic", MySqlDbType.VarChar).Value = ms.ToArray()

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Image Inserted")

        Else
            MessageBox.Show("Image Not Inserted")
        End If
        connection.Close()
    End Sub

    Private Sub Insert_Image_Into_MySQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

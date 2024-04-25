Imports MySql.Data.MySqlClient

Public Class Form2
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=quizdb")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New MySqlCommand("INSERT INTO `login`(`Email`, `Password`) VALUES (@email,@pw)", connection)

        'Add Parameters to the command

        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = TextBox2.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Inserted")

            Dim newform As New Form1()
            newform.Show()
            Me.Hide()

        Else
            MessageBox.Show("ERROR")
        End If

        connection.Close()

        Dim newform As New Form2()
        newform.Show()
        Me.Hide()

    End Sub
End Class
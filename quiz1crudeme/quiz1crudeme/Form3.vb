Imports MySql.Data.MySqlClient
Public Class Form3
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=quizdb")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New MySqlCommand("INSERT INTO `quiztbl`(`FIRSTNAME`, `LASTNAME`, `AGE`) VALUES (@fn,@ln,@age)", connection)

        'Add Parameters to the command
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("age", MySqlDbType.VarChar).Value = TextBox3.Text


        connection.Open()

        If command.ExecuteNonQuery = 1 Then

            MessageBox.Show("Your form has been sent")

        Else
            MessageBox.Show("Try Again")
        End If

        connection.Close()

        Form4.Show()
        Me.Hide()
    End Sub
End Class
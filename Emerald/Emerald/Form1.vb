Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=emeraldvb")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New MySqlCommand("INSERT INTO 'emeraldvb'('Full Name', 'Address', 'Birthdate') VALUES (@fln,@adds,@brd)", connection)

        ' add parameters to the command
        command.Parameters.Add("@fln", MySqlDbType.Var).Value = TextBox1.Text
        command.Parameters.Add("@adds", MySqlDbType.VarBinary).Value = TextBox2.Text
        command.Parameters.Add("@brd", MySqlDbType.Date).Value = DateTimePicker1.Value

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Data Inserted")

        Else
            MessageBox.Show("ERROR")

        End If

        connection.Close()

    End Sub

End Class

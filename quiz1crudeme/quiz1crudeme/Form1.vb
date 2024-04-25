Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=quizdb")
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.UseSystemPasswordChar = True Then

            'show password
            TextBox2.UseSystemPasswordChar = False
        Else
            'hide password
            TextBox2.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New MySqlCommand("SELECT `Email`, `Password` FROM `login` WHERE `Email` = @email AND `Password` = @password", connection)

        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBox2.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then
            MessageBox.Show("invalid Username or Password")

        Else
            MessageBox.Show("logged In")

            Dim newform As New Form3()
            newform.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newform As New Form2()
        newform.Show()
        Me.Hide()
    End Sub
End Class

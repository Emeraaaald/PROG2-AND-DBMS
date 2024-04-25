Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=emeraldemployee")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New MySqlCommand("INSERT INTO `employee`(`Last Name`, `Full Name, `Middle Name`, `Contact Number`, `Address`, `Age`, `Sex`, `SSS number`, `PhilHealth number`, `Pag-IBIG number`, `TIN number`, `Previous Occupation`) VALUES (@ln,@fn,@mn,@cn,@add,@age,@sex,@sss,@ph,@pi,@tin,@po)", Connection)

        'Add Parameters to the command
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("mn", MySqlDbType.VarChar).Value = TextBox3.Text
        command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = TextBox4.Text
        command.Parameters.Add("@add", MySqlDbType.VarChar).Value = TextBox5.Text
        command.Parameters.Add("@age", MySqlDbType.VarChar).Value = TextBox6.Text
        command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = TextBox7.Text
        command.Parameters.Add("@sss", MySqlDbType.VarChar).Value = TextBox8.Text
        command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = TextBox9.Text
        command.Parameters.Add("@pi", MySqlDbType.VarChar).Value = TextBox10.Text
        command.Parameters.Add("tin", MySqlDbType.VarChar).Value = TextBox11.Text
        command.Parameters.Add("@po", MySqlDbType.VarChar).Value = TextBox12.Text


        Connection.Open()

        If command.ExecuteNonQuery = 1 Then

            MessageBox.Show("Your form has been sent")

        Else
            MessageBox.Show("Try Again")
        End If

        Connection.Close()

        Form2.Show()
        Me.Hide()
    End Sub
End Class

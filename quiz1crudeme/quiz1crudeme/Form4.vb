Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM quizdb.quiztbl", connection)

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New MySqlCommand(query, Connection)

        Connection.Open()

        command.ExecuteNonQuery()

        Connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim updateQuery As String = "Update quiztbl Set FIRSTNAME = '" & TextBox2.Text & "' ,LASTNAME = '" & TextBox3.Text & "',AGE = " & TextBox4.Text & " WHERE ID =" & TextBox1.Text & ""
        ExecuteQuery(updateQuery)
        MessageBox.Show("Data Updated")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim deleteQuery As String = "delete from quiztbl where ID = " & TextBox1.Text
        ExecuteQuery(deleteQuery)
        MessageBox.Show("User Deleted")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
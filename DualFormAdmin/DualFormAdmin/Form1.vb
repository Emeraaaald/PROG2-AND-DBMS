Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=dualform;")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM dualform.user", connection)

        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Public Sub ExecuteQuery(query As String)
        Dim command As New MySqlCommand(query, connection)
        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim updateQuery As String = "Update user Set Message = '" & TextBox1.Text & "' WHERE ID =" & TextBox2.Text & ""
        ExecuteQuery(updateQuery)
        MessageBox.Show("MESSAGE SENT")

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newform As New Form1()
        newform.Show()
        Me.Hide()
    End Sub



End Class

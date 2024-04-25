Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oform As New Form1
        oform.ShowDialog()
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oform As New Form3
        oform.ShowDialog()
        Me.Hide()
        Me.Close()
    End Sub
End Class
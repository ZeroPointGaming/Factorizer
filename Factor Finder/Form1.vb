Public Class Form1
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim factoringnumber As Integer
        factoringnumber = Val(TextBox1.Text)
        Dim factors As Integer = 1

        For factors = 1 To factoringnumber
            If factoringnumber Mod factors = 0 Then
                ListBox1.Items.Add(factors)
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()

    End Sub
End Class

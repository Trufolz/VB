Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            While (ListBox1.Items.Contains(TextBox1.Text))
                ListBox1.Items.Remove(TextBox1.Text)
            End While
        Else
            If (TextBox1.Text <> String.Empty) Then
                ListBox1.Items.Add(TextBox1.Text)
            End If
        End If
    End Sub
End Class

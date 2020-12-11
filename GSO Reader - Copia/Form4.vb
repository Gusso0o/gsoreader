Public Class Form4
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then

            Form3.RichTextBox1.Font = New Font(Form3.RichTextBox1.Font, FontStyle.Bold)

        ElseIf CheckBox2.Checked Then
            Form3.RichTextBox1.Font = New Font(Form3.RichTextBox1.Font, FontStyle.Italic)
        ElseIf CheckBox3.Checked Then
            Form3.RichTextBox1.Font = New Font(Form3.RichTextBox1.Font, FontStyle.Underline)
        Else
            Form3.RichTextBox1.Font = New Font(Form3.RichTextBox1.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked Then

            Form3.RichTextBox1.Font = New Font(Form3.RichTextBox1.Font, FontStyle.Bold)

        ElseIf CheckBox2.Checked Then
            Form3.RichTextBox1.Font = New Font(Form3.RichTextBox1.Font, FontStyle.Italic)
        ElseIf CheckBox3.Checked Then
            Form3.RichTextBox1.Font = New Font(Form3.RichTextBox1.Font, FontStyle.Underline)
        Else
            Form3.RichTextBox1.Font = New Font(Form3.RichTextBox1.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Whopps! Questa funzione non è supportata dalla tua versione. Controlla aggiornamenti sul sito GitHub https://github.com/Gusso0o/gsoreader")


    End Sub
End Class
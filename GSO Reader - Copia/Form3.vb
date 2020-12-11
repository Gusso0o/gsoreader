Public Class Form3
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            Dim salva As New System.IO.StreamWriter(SaveFileDialog1.FileName)
            salva.Write(RichTextBox1)
            salva.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim apri As New System.IO.StreamReader(OpenFileDialog1.FileName)
        RichTextBox1.Text = apri.ReadToEnd
        apri.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    Private Sub DimensioneCarattereToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DimensioneCarattereToolStripMenuItem.Click
        Form4.show()
    End Sub

    Private Sub CorsivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorsivoToolStripMenuItem.Click

    End Sub

    Private Sub CancellaTuttoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancellaTuttoToolStripMenuItem.Click
        RichTextBox1.ResetText()
    End Sub
End Class
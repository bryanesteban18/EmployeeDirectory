Public Class Form1

    Private Sub AddRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRecordToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Form3.Show()
    End Sub
End Class

Public Class Form1
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles progressBar.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Width += 3
        If ProgressBar.Width >= 920 Then
            Timer1.Stop()
        End If
    End Sub
End Class

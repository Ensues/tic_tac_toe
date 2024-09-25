Public Class FormSplashScreen
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles PanelProgressBar.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PanelProgressBar.Width += 3
        If PanelProgressBar.Width >= 920 Then
            Timer1.Stop()
            Dim frmCRUD As New FormMainMenu
            frmCRUD.Show()
            Me.Hide()
        End If
    End Sub
End Class
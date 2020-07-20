Public Class frm_splash
    Private Sub tmr_splash_Tick(sender As Object, e As EventArgs) Handles tmr_splash.Tick
        frm_login.Show()
        tmr_splash.Stop()
    End Sub

    Private Sub frm_splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmr_splash.Start()
    End Sub
End Class

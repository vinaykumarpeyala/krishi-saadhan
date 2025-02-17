

Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(15)

        If ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            Me.Hide() ' Hide splash screen
            LoginForm.Show() ' Open Login Form
        End If
    End Sub
End Class

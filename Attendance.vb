Public Class Attendance
    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Date.Now.ToString("dd-MMMM-yyyy hh:mm:ss")
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class
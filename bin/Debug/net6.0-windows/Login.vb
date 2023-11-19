Public Class Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUsername.Text = "manager" And TxtPassword.Text = "password" Then
            DashboardManager.Show()
            Me.Close()

        ElseIf TxtUsername.Text = "admin" And TxtPassword.Text = "password" Then
            DashboardAdmin.Show()
            Me.Close()

        ElseIf TxtUsername.Text = "trainer" And TxtPassword.Text = "password" Then
            DashboardTrainer.Show()
            Me.Close()

        ElseIf TxtUsername.Text = "encoder" And TxtPassword.Text = "password" Then
            DashboardEncoder.Show()
            Me.Close()

        ElseIf TxtUsername.Text = "cashier" And TxtPassword.Text = "password" Then
            DashboardCashier.Show()
            Me.Close()

        Else
            MessageBox.Show("Incorrect Username or Password")
        End If
    End Sub
End Class
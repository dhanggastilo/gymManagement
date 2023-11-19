<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        LblGuiyabGymManagement = New Label()
        Panel3 = New Panel()
        Label1 = New Label()
        TxtInputName = New TextBox()
        lblDateTime = New Label()
        BtnTimeOut = New Button()
        BtnTimeIn = New Button()
        Timer1 = New Timer(components)
        BtnLogin = New Button()
        PicBoxLogin = New PictureBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PicBoxLogin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Info
        Panel1.Controls.Add(LblGuiyabGymManagement)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(956, 81)
        Panel1.TabIndex = 7
        ' 
        ' LblGuiyabGymManagement
        ' 
        LblGuiyabGymManagement.AutoSize = True
        LblGuiyabGymManagement.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        LblGuiyabGymManagement.Location = New Point(171, 9)
        LblGuiyabGymManagement.Name = "LblGuiyabGymManagement"
        LblGuiyabGymManagement.Size = New Size(598, 62)
        LblGuiyabGymManagement.TabIndex = 2
        LblGuiyabGymManagement.Text = "Guiyab Gym Management"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(TxtInputName)
        Panel3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Panel3.Location = New Point(210, 119)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(523, 56)
        Panel3.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(5, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 28)
        Label1.TabIndex = 1
        Label1.Text = "Enter Name:"
        ' 
        ' TxtInputName
        ' 
        TxtInputName.BackColor = SystemColors.MenuBar
        TxtInputName.Location = New Point(140, 11)
        TxtInputName.Name = "TxtInputName"
        TxtInputName.Size = New Size(371, 34)
        TxtInputName.TabIndex = 0
        ' 
        ' lblDateTime
        ' 
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Digital-7", 36F, FontStyle.Regular, GraphicsUnit.Point)
        lblDateTime.Location = New Point(137, 208)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(655, 62)
        lblDateTime.TabIndex = 13
        lblDateTime.Text = "Date-Month-Year  00:00:00"
        lblDateTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnTimeOut
        ' 
        BtnTimeOut.BackColor = Color.Red
        BtnTimeOut.FlatAppearance.BorderColor = Color.Black
        BtnTimeOut.FlatAppearance.MouseDownBackColor = Color.Gray
        BtnTimeOut.FlatStyle = FlatStyle.Flat
        BtnTimeOut.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnTimeOut.ForeColor = SystemColors.ControlLightLight
        BtnTimeOut.Location = New Point(480, 315)
        BtnTimeOut.Name = "BtnTimeOut"
        BtnTimeOut.Size = New Size(253, 116)
        BtnTimeOut.TabIndex = 12
        BtnTimeOut.Text = "Time Out"
        BtnTimeOut.UseVisualStyleBackColor = False
        ' 
        ' BtnTimeIn
        ' 
        BtnTimeIn.BackColor = Color.Green
        BtnTimeIn.FlatAppearance.BorderColor = Color.Black
        BtnTimeIn.FlatAppearance.MouseDownBackColor = Color.Gray
        BtnTimeIn.FlatStyle = FlatStyle.Flat
        BtnTimeIn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnTimeIn.ForeColor = SystemColors.ControlLightLight
        BtnTimeIn.Location = New Point(210, 315)
        BtnTimeIn.Name = "BtnTimeIn"
        BtnTimeIn.Size = New Size(253, 116)
        BtnTimeIn.TabIndex = 11
        BtnTimeIn.Text = "Time In"
        BtnTimeIn.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = SystemColors.Info
        BtnLogin.FlatAppearance.BorderColor = Color.Black
        BtnLogin.FlatAppearance.MouseDownBackColor = Color.Gray
        BtnLogin.FlatStyle = FlatStyle.Flat
        BtnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnLogin.ForeColor = SystemColors.ControlText
        BtnLogin.Location = New Point(786, 528)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(113, 47)
        BtnLogin.TabIndex = 14
        BtnLogin.Text = "Login"
        BtnLogin.TextAlign = ContentAlignment.MiddleLeft
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' PicBoxLogin
        ' 
        PicBoxLogin.BackColor = SystemColors.Info
        PicBoxLogin.BackgroundImage = My.Resources.Resources.log_in
        PicBoxLogin.BackgroundImageLayout = ImageLayout.Zoom
        PicBoxLogin.Location = New Point(859, 534)
        PicBoxLogin.Name = "PicBoxLogin"
        PicBoxLogin.Size = New Size(35, 35)
        PicBoxLogin.TabIndex = 15
        PicBoxLogin.TabStop = False
        ' 
        ' Attendance
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(955, 622)
        Controls.Add(PicBoxLogin)
        Controls.Add(BtnLogin)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(lblDateTime)
        Controls.Add(BtnTimeOut)
        Controls.Add(BtnTimeIn)
        FormBorderStyle = FormBorderStyle.None
        Name = "Attendance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Attendance"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PicBoxLogin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblGuiyabGymManagement As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtInputName As TextBox
    Friend WithEvents lblDateTime As Label
    Friend WithEvents BtnTimeOut As Button
    Friend WithEvents BtnTimeIn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnLogin As Button
    Friend WithEvents PicBoxLogin As PictureBox
End Class

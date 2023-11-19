<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardCashier
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
        Panel1 = New Panel()
        BtnLogout = New Button()
        BtnSalesRecords = New Button()
        BtnMonitoring = New Button()
        BtnMembershipRegistration = New Button()
        BtnPOS = New Button()
        LblPosition = New Label()
        LblFirstNameLastName = New Label()
        PicBoxProfileLogo = New PictureBox()
        TabControl = New TabControl()
        PointOfSale = New TabPage()
        MembershipRegistration = New TabPage()
        AccountMonitoring = New TabPage()
        ComboBox2 = New ComboBox()
        Panel4 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        LvAccountMonitoring = New ListView()
        SalesRecords = New TabPage()
        ComboBox3 = New ComboBox()
        Panel5 = New Panel()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        LvSales = New ListView()
        Panel1.SuspendLayout()
        CType(PicBoxProfileLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl.SuspendLayout()
        AccountMonitoring.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SalesRecords.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Info
        Panel1.Controls.Add(BtnLogout)
        Panel1.Controls.Add(BtnSalesRecords)
        Panel1.Controls.Add(BtnMonitoring)
        Panel1.Controls.Add(BtnMembershipRegistration)
        Panel1.Controls.Add(BtnPOS)
        Panel1.Controls.Add(LblPosition)
        Panel1.Controls.Add(LblFirstNameLastName)
        Panel1.Controls.Add(PicBoxProfileLogo)
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 626)
        Panel1.TabIndex = 1
        ' 
        ' BtnLogout
        ' 
        BtnLogout.BackColor = SystemColors.Info
        BtnLogout.FlatAppearance.BorderSize = 0
        BtnLogout.FlatStyle = FlatStyle.Flat
        BtnLogout.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        BtnLogout.Location = New Point(0, 584)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(73, 39)
        BtnLogout.TabIndex = 8
        BtnLogout.Text = "Logout"
        BtnLogout.UseVisualStyleBackColor = False
        ' 
        ' BtnSalesRecords
        ' 
        BtnSalesRecords.BackColor = SystemColors.Info
        BtnSalesRecords.FlatAppearance.BorderSize = 0
        BtnSalesRecords.FlatStyle = FlatStyle.Flat
        BtnSalesRecords.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSalesRecords.Location = New Point(0, 384)
        BtnSalesRecords.Name = "BtnSalesRecords"
        BtnSalesRecords.Size = New Size(247, 39)
        BtnSalesRecords.TabIndex = 6
        BtnSalesRecords.Text = "Sales Records"
        BtnSalesRecords.UseVisualStyleBackColor = False
        ' 
        ' BtnMonitoring
        ' 
        BtnMonitoring.BackColor = SystemColors.Info
        BtnMonitoring.FlatAppearance.BorderSize = 0
        BtnMonitoring.FlatStyle = FlatStyle.Flat
        BtnMonitoring.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMonitoring.Location = New Point(0, 339)
        BtnMonitoring.Name = "BtnMonitoring"
        BtnMonitoring.Size = New Size(247, 39)
        BtnMonitoring.TabIndex = 5
        BtnMonitoring.Text = "Account Monitoring"
        BtnMonitoring.UseVisualStyleBackColor = False
        ' 
        ' BtnMembershipRegistration
        ' 
        BtnMembershipRegistration.BackColor = SystemColors.Info
        BtnMembershipRegistration.FlatAppearance.BorderSize = 0
        BtnMembershipRegistration.FlatStyle = FlatStyle.Flat
        BtnMembershipRegistration.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMembershipRegistration.Location = New Point(2, 294)
        BtnMembershipRegistration.Name = "BtnMembershipRegistration"
        BtnMembershipRegistration.Size = New Size(247, 39)
        BtnMembershipRegistration.TabIndex = 4
        BtnMembershipRegistration.Text = "Membership Registration"
        BtnMembershipRegistration.UseVisualStyleBackColor = False
        ' 
        ' BtnPOS
        ' 
        BtnPOS.BackColor = SystemColors.Info
        BtnPOS.FlatAppearance.BorderSize = 0
        BtnPOS.FlatStyle = FlatStyle.Flat
        BtnPOS.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnPOS.Location = New Point(0, 249)
        BtnPOS.Name = "BtnPOS"
        BtnPOS.Size = New Size(247, 39)
        BtnPOS.TabIndex = 3
        BtnPOS.Text = "Point of Sale"
        BtnPOS.UseVisualStyleBackColor = False
        ' 
        ' LblPosition
        ' 
        LblPosition.AutoSize = True
        LblPosition.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        LblPosition.Location = New Point(94, 192)
        LblPosition.Name = "LblPosition"
        LblPosition.Size = New Size(61, 20)
        LblPosition.TabIndex = 2
        LblPosition.Text = "Position"
        ' 
        ' LblFirstNameLastName
        ' 
        LblFirstNameLastName.AutoSize = True
        LblFirstNameLastName.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        LblFirstNameLastName.Location = New Point(42, 169)
        LblFirstNameLastName.Name = "LblFirstNameLastName"
        LblFirstNameLastName.Size = New Size(169, 23)
        LblFirstNameLastName.TabIndex = 1
        LblFirstNameLastName.Text = "FirstName LastName"
        ' 
        ' PicBoxProfileLogo
        ' 
        PicBoxProfileLogo.BackgroundImage = My.Resources.Resources.profile
        PicBoxProfileLogo.BackgroundImageLayout = ImageLayout.Zoom
        PicBoxProfileLogo.Location = New Point(54, 28)
        PicBoxProfileLogo.Name = "PicBoxProfileLogo"
        PicBoxProfileLogo.Size = New Size(143, 128)
        PicBoxProfileLogo.TabIndex = 0
        PicBoxProfileLogo.TabStop = False
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(PointOfSale)
        TabControl.Controls.Add(MembershipRegistration)
        TabControl.Controls.Add(AccountMonitoring)
        TabControl.Controls.Add(SalesRecords)
        TabControl.Location = New Point(254, 12)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(697, 598)
        TabControl.TabIndex = 2
        ' 
        ' PointOfSale
        ' 
        PointOfSale.Location = New Point(4, 29)
        PointOfSale.Name = "PointOfSale"
        PointOfSale.Padding = New Padding(3)
        PointOfSale.Size = New Size(689, 565)
        PointOfSale.TabIndex = 4
        PointOfSale.Text = "POS"
        PointOfSale.UseVisualStyleBackColor = True
        ' 
        ' MembershipRegistration
        ' 
        MembershipRegistration.Location = New Point(4, 29)
        MembershipRegistration.Name = "MembershipRegistration"
        MembershipRegistration.Padding = New Padding(3)
        MembershipRegistration.Size = New Size(689, 565)
        MembershipRegistration.TabIndex = 5
        MembershipRegistration.Text = "Registration"
        MembershipRegistration.UseVisualStyleBackColor = True
        ' 
        ' AccountMonitoring
        ' 
        AccountMonitoring.Controls.Add(ComboBox2)
        AccountMonitoring.Controls.Add(Panel4)
        AccountMonitoring.Controls.Add(LvAccountMonitoring)
        AccountMonitoring.Location = New Point(4, 29)
        AccountMonitoring.Name = "AccountMonitoring"
        AccountMonitoring.Padding = New Padding(3)
        AccountMonitoring.Size = New Size(689, 565)
        AccountMonitoring.TabIndex = 2
        AccountMonitoring.Text = "Monitoring"
        AccountMonitoring.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Active", "Inactive"})
        ComboBox2.Location = New Point(595, 21)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(82, 28)
        ComboBox2.TabIndex = 27
        ComboBox2.Text = "Sort by:"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Control
        Panel4.Controls.Add(PictureBox1)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(TextBox1)
        Panel4.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Panel4.Location = New Point(11, 17)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(391, 42)
        Panel4.TabIndex = 26
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.search
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(3, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(29, 29)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(33, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 17)
        Label2.TabIndex = 1
        Label2.Text = "Search Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.MenuBar
        TextBox1.Location = New Point(124, 10)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(261, 25)
        TextBox1.TabIndex = 0
        ' 
        ' LvAccountMonitoring
        ' 
        LvAccountMonitoring.Location = New Point(11, 65)
        LvAccountMonitoring.Name = "LvAccountMonitoring"
        LvAccountMonitoring.Size = New Size(666, 483)
        LvAccountMonitoring.TabIndex = 25
        LvAccountMonitoring.UseCompatibleStateImageBehavior = False
        LvAccountMonitoring.View = View.Details
        ' 
        ' SalesRecords
        ' 
        SalesRecords.Controls.Add(ComboBox3)
        SalesRecords.Controls.Add(Panel5)
        SalesRecords.Controls.Add(LvSales)
        SalesRecords.Location = New Point(4, 29)
        SalesRecords.Name = "SalesRecords"
        SalesRecords.Padding = New Padding(3)
        SalesRecords.Size = New Size(689, 565)
        SalesRecords.TabIndex = 3
        SalesRecords.Text = "Sales"
        SalesRecords.UseVisualStyleBackColor = True
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Date", "Transaction Number", "Level of Membership", "Total Amount"})
        ComboBox3.Location = New Point(595, 21)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(82, 28)
        ComboBox3.TabIndex = 27
        ComboBox3.Text = "Sort by:"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.Control
        Panel5.Controls.Add(PictureBox2)
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(TextBox2)
        Panel5.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Panel5.Location = New Point(11, 17)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(391, 42)
        Panel5.TabIndex = 26
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.search
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(3, 7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(29, 29)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(33, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 17)
        Label3.TabIndex = 1
        Label3.Text = "Search Transaction"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.MenuBar
        TextBox2.Location = New Point(157, 10)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(228, 25)
        TextBox2.TabIndex = 0
        ' 
        ' LvSales
        ' 
        LvSales.Location = New Point(11, 65)
        LvSales.Name = "LvSales"
        LvSales.Size = New Size(666, 483)
        LvSales.TabIndex = 25
        LvSales.UseCompatibleStateImageBehavior = False
        LvSales.View = View.Details
        ' 
        ' DashboardCashier
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(955, 622)
        Controls.Add(TabControl)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "DashboardCashier"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DashboardCashier"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PicBoxProfileLogo, ComponentModel.ISupportInitialize).EndInit()
        TabControl.ResumeLayout(False)
        AccountMonitoring.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        SalesRecords.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnInventoryRecords As Button
    Friend WithEvents BtnSalesRecords As Button
    Friend WithEvents BtnMonitoring As Button
    Friend WithEvents BtnMembershipRegistration As Button
    Friend WithEvents BtnPOS As Button
    Friend WithEvents LblPosition As Label
    Friend WithEvents LblFirstNameLastName As Label
    Friend WithEvents PicBoxProfileLogo As PictureBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents CurrentlyTimeIn As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnViewActiveMember As Button
    Friend WithEvents LblTotalMemberNumber As Label
    Friend WithEvents LblActiveMemberNumber As Label
    Friend WithEvents LblTotalMember As Label
    Friend WithEvents LblActiveMember As Label
    Friend WithEvents AttendanceRecords As TabPage
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PbSearch As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtInputName As TextBox
    Friend WithEvents LvAttendance As ListView
    Friend WithEvents AccountMonitoring As TabPage
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LvTrainers As ListView
    Friend WithEvents SalesRecords As TabPage
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LvSales As ListView
    Friend WithEvents InventoryRecords As TabPage
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LvInventory As ListView
    Friend WithEvents PointOfSale As TabPage
    Friend WithEvents MembershipRegistration As TabPage
    Friend WithEvents LvAccountMonitoring As ListView
End Class

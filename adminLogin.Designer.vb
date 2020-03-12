<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminLogin))
        Me.txtBox_User = New Guna.UI.WinForms.GunaTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtBox_pass = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.button_login = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBox_User
        '
        Me.txtBox_User.BackColor = System.Drawing.Color.Transparent
        Me.txtBox_User.BaseColor = System.Drawing.Color.Snow
        Me.txtBox_User.BorderColor = System.Drawing.Color.Transparent
        Me.txtBox_User.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBox_User.FocusedBaseColor = System.Drawing.Color.Snow
        Me.txtBox_User.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtBox_User.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtBox_User.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_User.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtBox_User.Location = New System.Drawing.Point(516, 226)
        Me.txtBox_User.Name = "txtBox_User"
        Me.txtBox_User.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBox_User.Size = New System.Drawing.Size(316, 66)
        Me.txtBox_User.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Interval = 30000
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Arial Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(444, 110)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(457, 56)
        Me.GunaLabel3.TabIndex = 10
        Me.GunaLabel3.Text = "WELCOME TO SAAP"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(478, 166)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(389, 24)
        Me.GunaLabel4.TabIndex = 11
        Me.GunaLabel4.Text = "Specific Archive for Academic Papers"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Snow
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(532, 230)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(103, 21)
        Me.GunaLabel1.TabIndex = 12
        Me.GunaLabel1.Text = "USERNAME"
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.GunaPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.GunaPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GunaPanel1.Location = New System.Drawing.Point(511, 226)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(7, 66)
        Me.GunaPanel1.TabIndex = 13
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.GunaPanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.GunaPanel2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GunaPanel2.Location = New System.Drawing.Point(511, 298)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(7, 66)
        Me.GunaPanel2.TabIndex = 16
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Snow
        Me.GunaLabel2.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(532, 302)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(105, 21)
        Me.GunaLabel2.TabIndex = 15
        Me.GunaLabel2.Text = "PASSWORD"
        '
        'txtBox_pass
        '
        Me.txtBox_pass.BackColor = System.Drawing.Color.Transparent
        Me.txtBox_pass.BaseColor = System.Drawing.Color.Snow
        Me.txtBox_pass.BorderColor = System.Drawing.Color.Transparent
        Me.txtBox_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBox_pass.FocusedBaseColor = System.Drawing.Color.Snow
        Me.txtBox_pass.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtBox_pass.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtBox_pass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtBox_pass.Location = New System.Drawing.Point(516, 298)
        Me.txtBox_pass.Name = "txtBox_pass"
        Me.txtBox_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBox_pass.Size = New System.Drawing.Size(316, 66)
        Me.txtBox_pass.TabIndex = 14
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.Uploading_Document.My.Resources.Resources.LOGIN_1
        Me.GunaPictureBox1.Location = New System.Drawing.Point(-22, -20)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(436, 578)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 17
        Me.GunaPictureBox1.TabStop = False
        '
        'button_login
        '
        Me.button_login.AnimationHoverSpeed = 0.07!
        Me.button_login.AnimationSpeed = 0.03!
        Me.button_login.BackColor = System.Drawing.Color.Transparent
        Me.button_login.BaseColor = System.Drawing.Color.Snow
        Me.button_login.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.button_login.BorderSize = 2
        Me.button_login.CausesValidation = False
        Me.button_login.CheckedBaseColor = System.Drawing.Color.Gray
        Me.button_login.CheckedBorderColor = System.Drawing.Color.Black
        Me.button_login.CheckedForeColor = System.Drawing.Color.White
        Me.button_login.CheckedImage = CType(resources.GetObject("button_login.CheckedImage"), System.Drawing.Image)
        Me.button_login.CheckedLineColor = System.Drawing.Color.DimGray
        Me.button_login.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_login.FocusedColor = System.Drawing.Color.Empty
        Me.button_login.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_login.ForeColor = System.Drawing.Color.Gray
        Me.button_login.Image = Nothing
        Me.button_login.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.button_login.ImageSize = New System.Drawing.Size(20, 20)
        Me.button_login.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.button_login.Location = New System.Drawing.Point(722, 386)
        Me.button_login.Name = "button_login"
        Me.button_login.OnHoverBaseColor = System.Drawing.Color.White
        Me.button_login.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.button_login.OnHoverForeColor = System.Drawing.Color.DimGray
        Me.button_login.OnHoverImage = Nothing
        Me.button_login.OnHoverLineColor = System.Drawing.Color.Snow
        Me.button_login.OnPressedColor = System.Drawing.Color.Snow
        Me.button_login.Size = New System.Drawing.Size(110, 42)
        Me.button_login.TabIndex = 7
        Me.button_login.Text = "LOGIN"
        Me.button_login.TextOffsetX = 5
        Me.button_login.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'adminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1018, 547)
        Me.ControlBox = False
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.txtBox_pass)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.button_login)
        Me.Controls.Add(Me.txtBox_User)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "z"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBox_User As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents button_login As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtBox_pass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
End Class

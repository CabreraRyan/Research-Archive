<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainMenu))
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.button_student = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.button_admin = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'button_student
        '
        Me.button_student.AnimationHoverSpeed = 0.07!
        Me.button_student.AnimationSpeed = 0.03!
        Me.button_student.BackColor = System.Drawing.Color.Transparent
        Me.button_student.BaseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.button_student.BorderColor = System.Drawing.Color.White
        Me.button_student.BorderSize = 2
        Me.button_student.CheckedBaseColor = System.Drawing.Color.Gray
        Me.button_student.CheckedBorderColor = System.Drawing.Color.Black
        Me.button_student.CheckedForeColor = System.Drawing.Color.White
        Me.button_student.CheckedImage = CType(resources.GetObject("button_student.CheckedImage"), System.Drawing.Image)
        Me.button_student.CheckedLineColor = System.Drawing.Color.DimGray
        Me.button_student.DialogResult = System.Windows.Forms.DialogResult.None
        Me.button_student.FocusedColor = System.Drawing.Color.Empty
        Me.button_student.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_student.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.button_student.Image = Global.Uploading_Document.My.Resources.Resources.read_symbol_of_a_student_reading_pngrepo_com
        Me.button_student.ImageSize = New System.Drawing.Size(135, 135)
        Me.button_student.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.button_student.Location = New System.Drawing.Point(100, 289)
        Me.button_student.Name = "button_student"
        Me.button_student.OnHoverBaseColor = System.Drawing.Color.SandyBrown
        Me.button_student.OnHoverBorderColor = System.Drawing.Color.Black
        Me.button_student.OnHoverForeColor = System.Drawing.Color.White
        Me.button_student.OnHoverImage = Nothing
        Me.button_student.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.button_student.OnPressedColor = System.Drawing.Color.Black
        Me.button_student.Size = New System.Drawing.Size(232, 221)
        Me.button_student.TabIndex = 11
        Me.button_student.Text = "STUDENT"
        Me.button_student.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.Enabled = False
        Me.GunaPictureBox1.Image = Global.Uploading_Document.My.Resources.Resources.ACSCILOGO_VECTOR1
        Me.GunaPictureBox1.Location = New System.Drawing.Point(303, 46)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(404, 287)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 13
        Me.GunaPictureBox1.TabStop = False
        Me.GunaPictureBox1.UseTransfarantBackground = True
        '
        'button_admin
        '
        Me.button_admin.AnimationHoverSpeed = 0.07!
        Me.button_admin.AnimationSpeed = 0.03!
        Me.button_admin.BackColor = System.Drawing.Color.Transparent
        Me.button_admin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.button_admin.BorderColor = System.Drawing.Color.White
        Me.button_admin.BorderSize = 2
        Me.button_admin.CheckedBaseColor = System.Drawing.Color.Gray
        Me.button_admin.CheckedBorderColor = System.Drawing.Color.Black
        Me.button_admin.CheckedForeColor = System.Drawing.Color.White
        Me.button_admin.CheckedImage = CType(resources.GetObject("button_admin.CheckedImage"), System.Drawing.Image)
        Me.button_admin.CheckedLineColor = System.Drawing.Color.DimGray
        Me.button_admin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.button_admin.FocusedColor = System.Drawing.Color.Empty
        Me.button_admin.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.button_admin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.button_admin.Image = Global.Uploading_Document.My.Resources.Resources.admin
        Me.button_admin.ImageSize = New System.Drawing.Size(170, 170)
        Me.button_admin.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.button_admin.Location = New System.Drawing.Point(696, 289)
        Me.button_admin.Name = "button_admin"
        Me.button_admin.OnHoverBaseColor = System.Drawing.Color.SandyBrown
        Me.button_admin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.button_admin.OnHoverForeColor = System.Drawing.Color.White
        Me.button_admin.OnHoverImage = Nothing
        Me.button_admin.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.button_admin.OnPressedColor = System.Drawing.Color.Black
        Me.button_admin.Size = New System.Drawing.Size(232, 221)
        Me.button_admin.TabIndex = 10
        Me.button_admin.Text = "ADMIN"
        Me.button_admin.TextImageOffsetY = -20
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaGradientPanel1.ForeColor = System.Drawing.Color.Transparent
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, 96)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(1042, 174)
        Me.GunaGradientPanel1.TabIndex = 12
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(654, 64)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(342, 47)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "ACADEMIC PAPERS"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(24, 63)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(325, 47)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "SPECIFIC ARCHIVE"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GunaButton1.BorderSize = 2
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(768, 23)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 15
        Me.GunaButton1.Size = New System.Drawing.Size(160, 42)
        Me.GunaButton1.TabIndex = 14
        Me.GunaButton1.Text = "EXIT"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.button_admin)
        Me.Controls.Add(Me.button_student)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainMenu"
        Me.Text = "Specific Archive for Research Paper"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents button_admin As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents button_student As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminEditForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminEditForm))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbox_author = New System.Windows.Forms.TextBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.rchtxtbox_abstract = New System.Windows.Forms.RichTextBox()
        Me.txtbox_id = New System.Windows.Forms.TextBox()
        Me.txtbox_sy = New System.Windows.Forms.TextBox()
        Me.chkbox_quanti = New System.Windows.Forms.CheckBox()
        Me.txtbox_kw = New System.Windows.Forms.TextBox()
        Me.chkbox_quali = New System.Windows.Forms.CheckBox()
        Me.lbl_keyword = New System.Windows.Forms.Label()
        Me.chkbox_math = New System.Windows.Forms.CheckBox()
        Me.lbl_SY = New System.Windows.Forms.Label()
        Me.chkbox_eng = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkbox_tech = New System.Windows.Forms.CheckBox()
        Me.txtbox_title = New System.Windows.Forms.TextBox()
        Me.chkbox_sci = New System.Windows.Forms.CheckBox()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(609, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(399, 540)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GunaButton3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtbox_author)
        Me.GroupBox1.Controls.Add(Me.GunaButton1)
        Me.GroupBox1.Controls.Add(Me.rchtxtbox_abstract)
        Me.GroupBox1.Controls.Add(Me.txtbox_id)
        Me.GroupBox1.Controls.Add(Me.txtbox_sy)
        Me.GroupBox1.Controls.Add(Me.chkbox_quanti)
        Me.GroupBox1.Controls.Add(Me.txtbox_kw)
        Me.GroupBox1.Controls.Add(Me.chkbox_quali)
        Me.GroupBox1.Controls.Add(Me.lbl_keyword)
        Me.GroupBox1.Controls.Add(Me.chkbox_math)
        Me.GroupBox1.Controls.Add(Me.lbl_SY)
        Me.GroupBox1.Controls.Add(Me.chkbox_eng)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chkbox_tech)
        Me.GroupBox1.Controls.Add(Me.txtbox_title)
        Me.GroupBox1.Controls.Add(Me.chkbox_sci)
        Me.GroupBox1.Controls.Add(Me.lbl_Title)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(219, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 513)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EDIT DOCUMENTS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "ID"
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GunaButton3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GunaButton3.BorderSize = 1
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton3.Location = New System.Drawing.Point(225, 408)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Radius = 15
        Me.GunaButton3.Size = New System.Drawing.Size(123, 43)
        Me.GunaButton3.TabIndex = 42
        Me.GunaButton3.Text = "Delete Data"
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Author"
        '
        'txtbox_author
        '
        Me.txtbox_author.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_author.Location = New System.Drawing.Point(95, 86)
        Me.txtbox_author.Name = "txtbox_author"
        Me.txtbox_author.Size = New System.Drawing.Size(253, 26)
        Me.txtbox_author.TabIndex = 29
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GunaButton1.BorderSize = 1
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(95, 408)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 15
        Me.GunaButton1.Size = New System.Drawing.Size(123, 43)
        Me.GunaButton1.TabIndex = 41
        Me.GunaButton1.Text = "Edit Data"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rchtxtbox_abstract
        '
        Me.rchtxtbox_abstract.Location = New System.Drawing.Point(95, 182)
        Me.rchtxtbox_abstract.Name = "rchtxtbox_abstract"
        Me.rchtxtbox_abstract.Size = New System.Drawing.Size(253, 174)
        Me.rchtxtbox_abstract.TabIndex = 25
        Me.rchtxtbox_abstract.Text = ""
        '
        'txtbox_id
        '
        Me.txtbox_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_id.Location = New System.Drawing.Point(95, 54)
        Me.txtbox_id.Name = "txtbox_id"
        Me.txtbox_id.ReadOnly = True
        Me.txtbox_id.Size = New System.Drawing.Size(253, 26)
        Me.txtbox_id.TabIndex = 4
        '
        'txtbox_sy
        '
        Me.txtbox_sy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_sy.Location = New System.Drawing.Point(95, 118)
        Me.txtbox_sy.Name = "txtbox_sy"
        Me.txtbox_sy.Size = New System.Drawing.Size(253, 26)
        Me.txtbox_sy.TabIndex = 5
        '
        'chkbox_quanti
        '
        Me.chkbox_quanti.AutoSize = True
        Me.chkbox_quanti.Location = New System.Drawing.Point(272, 385)
        Me.chkbox_quanti.Name = "chkbox_quanti"
        Me.chkbox_quanti.Size = New System.Drawing.Size(83, 17)
        Me.chkbox_quanti.TabIndex = 21
        Me.chkbox_quanti.Text = "Quantitative"
        Me.chkbox_quanti.UseVisualStyleBackColor = True
        '
        'txtbox_kw
        '
        Me.txtbox_kw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_kw.Location = New System.Drawing.Point(95, 150)
        Me.txtbox_kw.Name = "txtbox_kw"
        Me.txtbox_kw.Size = New System.Drawing.Size(253, 26)
        Me.txtbox_kw.TabIndex = 6
        '
        'chkbox_quali
        '
        Me.chkbox_quali.AutoSize = True
        Me.chkbox_quali.Location = New System.Drawing.Point(272, 365)
        Me.chkbox_quali.Name = "chkbox_quali"
        Me.chkbox_quali.Size = New System.Drawing.Size(76, 17)
        Me.chkbox_quali.TabIndex = 20
        Me.chkbox_quali.Text = "Qualitative"
        Me.chkbox_quali.UseVisualStyleBackColor = True
        '
        'lbl_keyword
        '
        Me.lbl_keyword.AutoSize = True
        Me.lbl_keyword.Location = New System.Drawing.Point(31, 158)
        Me.lbl_keyword.Name = "lbl_keyword"
        Me.lbl_keyword.Size = New System.Drawing.Size(58, 13)
        Me.lbl_keyword.TabIndex = 8
        Me.lbl_keyword.Text = "Keyword/s"
        '
        'chkbox_math
        '
        Me.chkbox_math.AutoSize = True
        Me.chkbox_math.Location = New System.Drawing.Point(184, 385)
        Me.chkbox_math.Name = "chkbox_math"
        Me.chkbox_math.Size = New System.Drawing.Size(86, 17)
        Me.chkbox_math.TabIndex = 19
        Me.chkbox_math.Text = "Mathematics"
        Me.chkbox_math.UseVisualStyleBackColor = True
        '
        'lbl_SY
        '
        Me.lbl_SY.AutoSize = True
        Me.lbl_SY.Location = New System.Drawing.Point(25, 126)
        Me.lbl_SY.Name = "lbl_SY"
        Me.lbl_SY.Size = New System.Drawing.Size(68, 13)
        Me.lbl_SY.TabIndex = 9
        Me.lbl_SY.Text = "School Year:"
        '
        'chkbox_eng
        '
        Me.chkbox_eng.AutoSize = True
        Me.chkbox_eng.Location = New System.Drawing.Point(184, 365)
        Me.chkbox_eng.Name = "chkbox_eng"
        Me.chkbox_eng.Size = New System.Drawing.Size(82, 17)
        Me.chkbox_eng.TabIndex = 18
        Me.chkbox_eng.Text = "Engineering"
        Me.chkbox_eng.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ABSTRACT"
        '
        'chkbox_tech
        '
        Me.chkbox_tech.AutoSize = True
        Me.chkbox_tech.Location = New System.Drawing.Point(95, 385)
        Me.chkbox_tech.Name = "chkbox_tech"
        Me.chkbox_tech.Size = New System.Drawing.Size(82, 17)
        Me.chkbox_tech.TabIndex = 17
        Me.chkbox_tech.Text = "Technology"
        Me.chkbox_tech.UseVisualStyleBackColor = True
        '
        'txtbox_title
        '
        Me.txtbox_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_title.Location = New System.Drawing.Point(95, 22)
        Me.txtbox_title.Name = "txtbox_title"
        Me.txtbox_title.Size = New System.Drawing.Size(253, 26)
        Me.txtbox_title.TabIndex = 11
        '
        'chkbox_sci
        '
        Me.chkbox_sci.AutoSize = True
        Me.chkbox_sci.Location = New System.Drawing.Point(95, 363)
        Me.chkbox_sci.Name = "chkbox_sci"
        Me.chkbox_sci.Size = New System.Drawing.Size(65, 17)
        Me.chkbox_sci.TabIndex = 16
        Me.chkbox_sci.Text = "Science"
        Me.chkbox_sci.UseVisualStyleBackColor = True
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Location = New System.Drawing.Point(62, 30)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(27, 13)
        Me.lbl_Title.TabIndex = 12
        Me.lbl_Title.Text = "Title"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Category"
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel6)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel5)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel4)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaGradientPanel1.ForeColor = System.Drawing.Color.Transparent
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradientPanel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(214, 553)
        Me.GunaGradientPanel1.TabIndex = 28
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(18, 458)
        Me.GunaLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(89, 25)
        Me.GunaLabel6.TabIndex = 5
        Me.GunaLabel6.Text = "LOGOUT"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(18, 433)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(126, 25)
        Me.GunaLabel5.TabIndex = 4
        Me.GunaLabel5.Text = "MAIN MENU"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(18, 407)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(59, 25)
        Me.GunaLabel4.TabIndex = 3
        Me.GunaLabel4.Text = "HELP"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(18, 87)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(192, 13)
        Me.GunaLabel3.TabIndex = 2
        Me.GunaLabel3.Text = "Specific Archive for Academic Papers"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(654, 64)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
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
        Me.GunaLabel1.Location = New System.Drawing.Point(13, 39)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(112, 47)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "SAAP"
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'adminEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 537)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminEditForm"
        Me.Text = "SAAP"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbox_author As System.Windows.Forms.TextBox
    Friend WithEvents rchtxtbox_abstract As System.Windows.Forms.RichTextBox
    Friend WithEvents txtbox_sy As System.Windows.Forms.TextBox
    Friend WithEvents chkbox_quanti As System.Windows.Forms.CheckBox
    Friend WithEvents txtbox_kw As System.Windows.Forms.TextBox
    Friend WithEvents chkbox_quali As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_keyword As System.Windows.Forms.Label
    Friend WithEvents chkbox_math As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_SY As System.Windows.Forms.Label
    Friend WithEvents chkbox_eng As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkbox_tech As System.Windows.Forms.CheckBox
    Friend WithEvents txtbox_title As System.Windows.Forms.TextBox
    Friend WithEvents chkbox_sci As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbox_id As System.Windows.Forms.TextBox
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
End Class

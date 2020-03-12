<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminUploadForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminUploadForm))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.chkbox_sci = New System.Windows.Forms.CheckBox()
        Me.chkbox_tech = New System.Windows.Forms.CheckBox()
        Me.chkbox_eng = New System.Windows.Forms.CheckBox()
        Me.chkbox_math = New System.Windows.Forms.CheckBox()
        Me.chkbox_quali = New System.Windows.Forms.CheckBox()
        Me.txtbox_kw = New System.Windows.Forms.TextBox()
        Me.chkbox_quanti = New System.Windows.Forms.CheckBox()
        Me.txtbox_sy = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.rchtxtbox_abstract = New System.Windows.Forms.RichTextBox()
        Me.txtBox_Author = New System.Windows.Forms.TextBox()
        Me.txtbox_title = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
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
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, -3)
        Me.GunaGradientPanel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(214, 568)
        Me.GunaGradientPanel1.TabIndex = 27
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
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lbl_Title.Location = New System.Drawing.Point(322, 43)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(38, 20)
        Me.lbl_Title.TabIndex = 12
        Me.lbl_Title.Text = "Title"
        '
        'chkbox_sci
        '
        Me.chkbox_sci.AutoSize = True
        Me.chkbox_sci.Location = New System.Drawing.Point(370, 384)
        Me.chkbox_sci.Name = "chkbox_sci"
        Me.chkbox_sci.Size = New System.Drawing.Size(65, 17)
        Me.chkbox_sci.TabIndex = 16
        Me.chkbox_sci.Text = "Science"
        Me.chkbox_sci.UseVisualStyleBackColor = True
        '
        'chkbox_tech
        '
        Me.chkbox_tech.AutoSize = True
        Me.chkbox_tech.Location = New System.Drawing.Point(370, 406)
        Me.chkbox_tech.Name = "chkbox_tech"
        Me.chkbox_tech.Size = New System.Drawing.Size(82, 17)
        Me.chkbox_tech.TabIndex = 17
        Me.chkbox_tech.Text = "Technology"
        Me.chkbox_tech.UseVisualStyleBackColor = True
        '
        'chkbox_eng
        '
        Me.chkbox_eng.AutoSize = True
        Me.chkbox_eng.Location = New System.Drawing.Point(459, 386)
        Me.chkbox_eng.Name = "chkbox_eng"
        Me.chkbox_eng.Size = New System.Drawing.Size(82, 17)
        Me.chkbox_eng.TabIndex = 18
        Me.chkbox_eng.Text = "Engineering"
        Me.chkbox_eng.UseVisualStyleBackColor = True
        '
        'chkbox_math
        '
        Me.chkbox_math.AutoSize = True
        Me.chkbox_math.Location = New System.Drawing.Point(459, 406)
        Me.chkbox_math.Name = "chkbox_math"
        Me.chkbox_math.Size = New System.Drawing.Size(86, 17)
        Me.chkbox_math.TabIndex = 19
        Me.chkbox_math.Text = "Mathematics"
        Me.chkbox_math.UseVisualStyleBackColor = True
        '
        'chkbox_quali
        '
        Me.chkbox_quali.AutoSize = True
        Me.chkbox_quali.Location = New System.Drawing.Point(547, 386)
        Me.chkbox_quali.Name = "chkbox_quali"
        Me.chkbox_quali.Size = New System.Drawing.Size(76, 17)
        Me.chkbox_quali.TabIndex = 20
        Me.chkbox_quali.Text = "Qualitative"
        Me.chkbox_quali.UseVisualStyleBackColor = True
        '
        'txtbox_kw
        '
        Me.txtbox_kw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_kw.Location = New System.Drawing.Point(370, 171)
        Me.txtbox_kw.Name = "txtbox_kw"
        Me.txtbox_kw.Size = New System.Drawing.Size(253, 26)
        Me.txtbox_kw.TabIndex = 6
        '
        'chkbox_quanti
        '
        Me.chkbox_quanti.AutoSize = True
        Me.chkbox_quanti.Location = New System.Drawing.Point(547, 406)
        Me.chkbox_quanti.Name = "chkbox_quanti"
        Me.chkbox_quanti.Size = New System.Drawing.Size(83, 17)
        Me.chkbox_quanti.TabIndex = 21
        Me.chkbox_quanti.Text = "Quantitative"
        Me.chkbox_quanti.UseVisualStyleBackColor = True
        '
        'txtbox_sy
        '
        Me.txtbox_sy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_sy.Location = New System.Drawing.Point(370, 139)
        Me.txtbox_sy.Name = "txtbox_sy"
        Me.txtbox_sy.Size = New System.Drawing.Size(253, 26)
        Me.txtbox_sy.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(370, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(253, 26)
        Me.TextBox1.TabIndex = 4
        '
        'rchtxtbox_abstract
        '
        Me.rchtxtbox_abstract.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rchtxtbox_abstract.ForeColor = System.Drawing.SystemColors.WindowText
        Me.rchtxtbox_abstract.Location = New System.Drawing.Point(370, 203)
        Me.rchtxtbox_abstract.Name = "rchtxtbox_abstract"
        Me.rchtxtbox_abstract.Size = New System.Drawing.Size(253, 174)
        Me.rchtxtbox_abstract.TabIndex = 25
        Me.rchtxtbox_abstract.Text = ""
        '
        'txtBox_Author
        '
        Me.txtBox_Author.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_Author.Location = New System.Drawing.Point(370, 107)
        Me.txtBox_Author.Name = "txtBox_Author"
        Me.txtBox_Author.Size = New System.Drawing.Size(253, 26)
        Me.txtBox_Author.TabIndex = 29
        '
        'txtbox_title
        '
        Me.txtbox_title.BaseColor = System.Drawing.Color.White
        Me.txtbox_title.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtbox_title.BorderSize = 1
        Me.txtbox_title.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_title.FocusedBaseColor = System.Drawing.Color.White
        Me.txtbox_title.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_title.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtbox_title.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbox_title.Location = New System.Drawing.Point(370, 43)
        Me.txtbox_title.Name = "txtbox_title"
        Me.txtbox_title.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox_title.Size = New System.Drawing.Size(253, 26)
        Me.txtbox_title.TabIndex = 31
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GunaButton2.BorderSize = 1
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(289, 75)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(75, 26)
        Me.GunaButton2.TabIndex = 32
        Me.GunaButton2.Text = "Select Doc"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(311, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Author"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(279, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "School Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(283, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Keyword/s"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(299, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Abstract"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(292, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Category"
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
        Me.GunaButton1.Location = New System.Drawing.Point(370, 426)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 15
        Me.GunaButton1.Size = New System.Drawing.Size(123, 43)
        Me.GunaButton1.TabIndex = 38
        Me.GunaButton1.Text = "Upload To Database"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GunaButton3.Location = New System.Drawing.Point(500, 426)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Radius = 15
        Me.GunaButton3.Size = New System.Drawing.Size(123, 43)
        Me.GunaButton3.TabIndex = 39
        Me.GunaButton3.Text = "Update Documents"
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GunaButton4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GunaButton4.BorderSize = 1
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaButton4.Image = Nothing
        Me.GunaButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton4.Location = New System.Drawing.Point(370, 475)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Radius = 15
        Me.GunaButton4.Size = New System.Drawing.Size(253, 43)
        Me.GunaButton4.TabIndex = 40
        Me.GunaButton4.Text = "Open Archive Folder"
        Me.GunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'adminUploadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.GunaButton4)
        Me.Controls.Add(Me.GunaButton3)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkbox_quanti)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbox_kw)
        Me.Controls.Add(Me.txtbox_sy)
        Me.Controls.Add(Me.chkbox_quali)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.chkbox_math)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.chkbox_eng)
        Me.Controls.Add(Me.txtbox_title)
        Me.Controls.Add(Me.chkbox_tech)
        Me.Controls.Add(Me.txtBox_Author)
        Me.Controls.Add(Me.rchtxtbox_abstract)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.chkbox_sci)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminUploadForm"
        Me.Text = "Upload Document"
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents chkbox_sci As System.Windows.Forms.CheckBox
    Friend WithEvents chkbox_tech As System.Windows.Forms.CheckBox
    Friend WithEvents chkbox_eng As System.Windows.Forms.CheckBox
    Friend WithEvents chkbox_math As System.Windows.Forms.CheckBox
    Friend WithEvents chkbox_quali As System.Windows.Forms.CheckBox
    Friend WithEvents txtbox_kw As System.Windows.Forms.TextBox
    Friend WithEvents chkbox_quanti As System.Windows.Forms.CheckBox
    Friend WithEvents txtbox_sy As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents rchtxtbox_abstract As System.Windows.Forms.RichTextBox
    Friend WithEvents txtBox_Author As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_title As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl

End Class

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
        Me.btn_selectDoc = New System.Windows.Forms.Button()
        Me.btn_UploadData = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtbox_sy = New System.Windows.Forms.TextBox()
        Me.txtbox_kw = New System.Windows.Forms.TextBox()
        Me.lbl_keyword = New System.Windows.Forms.Label()
        Me.lbl_SY = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbox_title = New System.Windows.Forms.TextBox()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkbox_sci = New System.Windows.Forms.CheckBox()
        Me.chkbox_tech = New System.Windows.Forms.CheckBox()
        Me.chkbox_eng = New System.Windows.Forms.CheckBox()
        Me.chkbox_math = New System.Windows.Forms.CheckBox()
        Me.chkbox_quali = New System.Windows.Forms.CheckBox()
        Me.chkbox_quanti = New System.Windows.Forms.CheckBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.rchtxtbox_abstract = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBox_Author = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_selectDoc
        '
        Me.btn_selectDoc.Location = New System.Drawing.Point(14, 54)
        Me.btn_selectDoc.Name = "btn_selectDoc"
        Me.btn_selectDoc.Size = New System.Drawing.Size(75, 26)
        Me.btn_selectDoc.TabIndex = 0
        Me.btn_selectDoc.Text = "Select Doc"
        Me.btn_selectDoc.UseVisualStyleBackColor = True
        '
        'btn_UploadData
        '
        Me.btn_UploadData.Location = New System.Drawing.Point(95, 408)
        Me.btn_UploadData.Name = "btn_UploadData"
        Me.btn_UploadData.Size = New System.Drawing.Size(120, 36)
        Me.btn_UploadData.TabIndex = 1
        Me.btn_UploadData.Text = "Upload To Database"
        Me.btn_UploadData.UseVisualStyleBackColor = True
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
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(95, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(253, 26)
        Me.TextBox1.TabIndex = 4
        '
        'txtbox_sy
        '
        Me.txtbox_sy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_sy.Location = New System.Drawing.Point(95, 118)
        Me.txtbox_sy.Name = "txtbox_sy"
        Me.txtbox_sy.Size = New System.Drawing.Size(253, 26)
        Me.txtbox_sy.TabIndex = 5
        '
        'txtbox_kw
        '
        Me.txtbox_kw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_kw.Location = New System.Drawing.Point(95, 150)
        Me.txtbox_kw.Name = "txtbox_kw"
        Me.txtbox_kw.Size = New System.Drawing.Size(253, 26)
        Me.txtbox_kw.TabIndex = 6
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
        'lbl_SY
        '
        Me.lbl_SY.AutoSize = True
        Me.lbl_SY.Location = New System.Drawing.Point(25, 126)
        Me.lbl_SY.Name = "lbl_SY"
        Me.lbl_SY.Size = New System.Drawing.Size(68, 13)
        Me.lbl_SY.TabIndex = 9
        Me.lbl_SY.Text = "School Year:"
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
        'txtbox_title
        '
        Me.txtbox_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_title.Location = New System.Drawing.Point(95, 22)
        Me.txtbox_title.Name = "txtbox_title"
        Me.txtbox_title.Size = New System.Drawing.Size(253, 26)
        Me.txtbox_title.TabIndex = 11
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
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(519, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "HELP"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(600, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "Main Menu"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(681, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 24
        Me.Button7.Text = "Logout"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(232, 408)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 36)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Update Documents"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'rchtxtbox_abstract
        '
        Me.rchtxtbox_abstract.Location = New System.Drawing.Point(95, 182)
        Me.rchtxtbox_abstract.Name = "rchtxtbox_abstract"
        Me.rchtxtbox_abstract.Size = New System.Drawing.Size(253, 174)
        Me.rchtxtbox_abstract.TabIndex = 25
        Me.rchtxtbox_abstract.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBox_Author)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.rchtxtbox_abstract)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btn_selectDoc)
        Me.GroupBox1.Controls.Add(Me.btn_UploadData)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
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
        Me.GroupBox1.Location = New System.Drawing.Point(211, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 497)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "UPLOAD DOCUMENTS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Author"
        '
        'txtBox_Author
        '
        Me.txtBox_Author.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_Author.Location = New System.Drawing.Point(95, 86)
        Me.txtBox_Author.Name = "txtBox_Author"
        Me.txtBox_Author.Size = New System.Drawing.Size(253, 26)
        Me.txtBox_Author.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(95, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(253, 34)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Open Current Archive Directory"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'adminUploadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "adminUploadForm"
        Me.Text = "Upload Document"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_selectDoc As System.Windows.Forms.Button
    Friend WithEvents btn_UploadData As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_sy As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_kw As System.Windows.Forms.TextBox
    Friend WithEvents lbl_keyword As System.Windows.Forms.Label
    Friend WithEvents lbl_SY As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbox_title As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkbox_sci As System.Windows.Forms.CheckBox
    Friend WithEvents chkbox_tech As System.Windows.Forms.CheckBox
    Friend WithEvents chkbox_eng As System.Windows.Forms.CheckBox
    Friend WithEvents chkbox_math As System.Windows.Forms.CheckBox
    Friend WithEvents chkbox_quali As System.Windows.Forms.CheckBox
    Friend WithEvents chkbox_quanti As System.Windows.Forms.CheckBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents rchtxtbox_abstract As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBox_Author As System.Windows.Forms.TextBox

End Class

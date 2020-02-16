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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbox_author = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rchtxtbox_abstract = New System.Windows.Forms.RichTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_EditData = New System.Windows.Forms.Button()
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
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(385, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(387, 497)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtbox_author)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.rchtxtbox_abstract)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btn_EditData)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 497)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EDIT DOCUMENTS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "ID"
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
        'txtbox_author
        '
        Me.txtbox_author.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_author.Location = New System.Drawing.Point(95, 86)
        Me.txtbox_author.Name = "txtbox_author"
        Me.txtbox_author.Size = New System.Drawing.Size(253, 26)
        Me.txtbox_author.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(95, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(253, 34)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Update Archive Database"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rchtxtbox_abstract
        '
        Me.rchtxtbox_abstract.Location = New System.Drawing.Point(95, 182)
        Me.rchtxtbox_abstract.Name = "rchtxtbox_abstract"
        Me.rchtxtbox_abstract.Size = New System.Drawing.Size(253, 174)
        Me.rchtxtbox_abstract.TabIndex = 25
        Me.rchtxtbox_abstract.Text = ""
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(232, 408)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 36)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Delete Data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_EditData
        '
        Me.btn_EditData.Location = New System.Drawing.Point(95, 408)
        Me.btn_EditData.Name = "btn_EditData"
        Me.btn_EditData.Size = New System.Drawing.Size(120, 36)
        Me.btn_EditData.TabIndex = 1
        Me.btn_EditData.Text = "Edit Data"
        Me.btn_EditData.UseVisualStyleBackColor = True
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
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(697, 12)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 30
        Me.Button7.Text = "Logout"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(616, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 29
        Me.Button6.Text = "Main Menu"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(535, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "HELP"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'adminEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "adminEditForm"
        Me.Text = "adminEditForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbox_author As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rchtxtbox_abstract As System.Windows.Forms.RichTextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_EditData As System.Windows.Forms.Button
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
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbox_id As System.Windows.Forms.TextBox
End Class

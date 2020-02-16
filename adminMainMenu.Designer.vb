<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminMainMenuForm
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
        Me.btn_uploadDoc = New System.Windows.Forms.Button()
        Me.btn_editSavedDoc = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.main_menu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_uploadDoc
        '
        Me.btn_uploadDoc.Location = New System.Drawing.Point(136, 159)
        Me.btn_uploadDoc.Name = "btn_uploadDoc"
        Me.btn_uploadDoc.Size = New System.Drawing.Size(217, 232)
        Me.btn_uploadDoc.TabIndex = 0
        Me.btn_uploadDoc.Text = "UPLOAD DOCUMENT"
        Me.btn_uploadDoc.UseVisualStyleBackColor = True
        '
        'btn_editSavedDoc
        '
        Me.btn_editSavedDoc.Location = New System.Drawing.Point(359, 159)
        Me.btn_editSavedDoc.Name = "btn_editSavedDoc"
        Me.btn_editSavedDoc.Size = New System.Drawing.Size(217, 232)
        Me.btn_editSavedDoc.TabIndex = 1
        Me.btn_editSavedDoc.Text = "EDIT/DELETE SAVED DOCUMENTS"
        Me.btn_editSavedDoc.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(556, 36)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(158, 40)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "LOGOUT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'main_menu
        '
        Me.main_menu.AutoSize = True
        Me.main_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_menu.Location = New System.Drawing.Point(15, 35)
        Me.main_menu.Name = "main_menu"
        Me.main_menu.Size = New System.Drawing.Size(382, 31)
        Me.main_menu.TabIndex = 4
        Me.main_menu.Text = "ADMINISTRATOR CONTROL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MAIN MENU"
        '
        'adminMainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.main_menu)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btn_editSavedDoc)
        Me.Controls.Add(Me.btn_uploadDoc)
        Me.Name = "adminMainMenuForm"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_uploadDoc As System.Windows.Forms.Button
    Friend WithEvents btn_editSavedDoc As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents main_menu As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

Public Class mainMenu

    Private Sub mainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        If (Not System.IO.Directory.Exists("C:\Archive")) Then
            System.IO.Directory.CreateDirectory("C:\Archive")
        End If
    End Sub

    Private Sub GunaAdvenceTileButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_student.Click
        studentForm.Show()
        Me.Close()
    End Sub

    Private Sub button_admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_admin.Click
        adminLogin.Show()
    End Sub

    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
        Me.Close()
    End Sub
End Class
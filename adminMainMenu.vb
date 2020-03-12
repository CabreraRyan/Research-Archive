Public Class adminMainMenuForm

    Private Sub GunaTileButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaTileButton3.Click
        adminUploadForm.Show()
        Me.Close()
    End Sub

    Private Sub GunaTileButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaTileButton1.Click
        adminEditForm.Show()
        Me.Close()
    End Sub

    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub adminMainMenuForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Me.CenterToScreen()
    End Sub
End Class
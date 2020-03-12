Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class adminLogin

    Dim MySqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Reader As MySqlDataReader
    Public tryLog As Integer
    Public canLog As Boolean = True
    Public Selected = 0

    Private Sub adminLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mainMenu.Close()
        Me.CenterToScreen()
        Me.Text = ""
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Shared Function GetHash(ByVal theInput As String) As String

        Using hasher As MD5 = MD5.Create() ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function

    Private Sub button_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_login.Click
        If canLog = True Then
            Timer1.Stop()
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString = "server=localhost;userid=root;password=Research123123;database=research_archive"
            Dim Reader As MySqlDataReader

            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "select * from research_archive.login where user='" & txtBox_User.Text & "' and pass='" & GetHash(txtBox_pass.Text) & "' "
                Command = New MySqlCommand(Query, MySqlConn)
                Reader = Command.ExecuteReader
                Dim count As Integer

                count = 0
                While Reader.Read
                    count = count + 1

                End While

                If count = 1 Then
                    adminMainMenuForm.Show()
                    Me.Close()
                ElseIf count > 1 Then
                    MessageBox.Show("Username and password are Duplicate")
                Else
                    MessageBox.Show("Username and password are incorrect")
                    tryLog = tryLog + 1
                    If tryLog >= 5 Then
                        MessageBox.Show("You entered to much wrong credentials, please wait 30 seconds to login again")
                        canLog = False
                        Timer1.Start()
                    End If
                End If

                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try
        End If

        If canLog = False Then
            MsgBox("You still can't login, please wait a couple of seconds")
        End If

    End Sub

    Private Sub txtBox_User_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBox_User.GotFocus
        GunaPanel1.BackColor = Color.FromArgb(255, 90, 135)
    End Sub

    Private Sub txtBox_pass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        GunaPanel1.BackColor = Color.FromArgb(255, 90, 135)
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        canLog = True
        tryLog = 0
    End Sub

    Private Sub txtBox_pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

End Class
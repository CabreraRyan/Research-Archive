Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Linq

Public Class adminEditForm

    

    Private Sub adminEditForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_table()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub load_table()
        Dim MySQLConnection As New MySqlConnection
        Dim cstring As String = "Server=localhost;Database=research_archive;uid=root;Pwd=Research123123"
        MySQLConnection.ConnectionString = cstring
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            Dim query As String
            MySQLConnection.Open()
            query = "select id, filename, title, author, abstract, School_Year, keywords, category_Science, category_Engineering, category_Mathematics, category_Technology, category_Quantitative, category_Qualitative  from research_archive.document"
            Dim command As New MySqlCommand(query, MySQLConnection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            'SDA.Update(dbDataSet)
            MySQLConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySQLConnection.Dispose()
        End Try
    End Sub

    
    Private Sub btn_UploadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Function categoryCheckbox(ByVal category As CheckBox)
        Dim dataVar As Integer
        If category.Checked = True Then
            dataVar = 1
        Else
            dataVar = 0
        End If
        Return dataVar
    End Function

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            Dim id As String = row.Cells("id").Value.ToString
            Dim title As String = row.Cells("title").Value.ToString
            Dim author As String = row.Cells("Author").Value.ToString
            Dim sy As String = row.Cells("School_Year").Value.ToString
            Dim abs As String = row.Cells("abstract").Value.ToString
            Dim fname As String = row.Cells("filename").Value.ToString
            Dim kw As String = row.Cells("keywords").Value.ToString
            Dim sci As Integer = row.Cells("category_Science").Value
            Dim tech As Integer = row.Cells("category_Technology").Value
            Dim eng As Integer = row.Cells("category_Engineering").Value
            Dim math As Integer = row.Cells("category_Mathematics").Value
            Dim quan As Integer = row.Cells("category_Quantitative").Value
            Dim qual As Integer = row.Cells("category_Qualitative").Value
            txtbox_title.Text = title
            txtbox_id.Text = id
            txtbox_kw.Text = kw
            txtbox_sy.Text = sy
            txtbox_author.Text = author
            rchtxtbox_abstract.Text = abs

            ''Check
            categoryCheck(chkbox_eng, eng)
            categoryCheck(chkbox_math, math)
            categoryCheck(chkbox_sci, sci)
            categoryCheck(chkbox_tech, tech)
            categoryCheck(chkbox_quali, qual)
            categoryCheck(chkbox_quanti, quan)

        End If
    End Sub

    Public Sub categoryCheck(ByVal chk As CheckBox, ByVal state As Integer)
        If state = -1 Then
            chk.Checked = True
            chk.CheckState = CheckState.Checked
        Else
            chk.Checked = False
            chk.CheckState = CheckState.Unchecked
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim del As DialogResult = MessageBox.Show("Are you sure you want to delete this research?", "Confirm Deletion", MessageBoxButtons.YesNoCancel)

        If del = DialogResult.Yes Then
            ''Connect to Database
            Dim MySQLConnection As New MySqlConnection
            Dim cstring As String = "Server=localhost;Database=research_archive;uid=root;Pwd=Research123123"

            ''Convert Sy to Numeric
            Dim SY_num As Integer
            If IsNumeric(txtbox_sy.Text) Then
                SY_num = CInt(txtbox_sy.Text)
            End If

            Dim id As Integer = CInt(txtbox_id.Text)

            Dim Command As New MySqlCommand()
            Command.Connection = MySQLConnection
            Command.CommandText = "DELETE FROM research_archive.document WHERE `id` = @id"
            'Command.CommandText = "UPDATE research_archive.document SET (title, School_Year, Keywords, category_Engineering, category_Engineering)"
            Command.Parameters.Clear()
            Command.Parameters.AddWithValue("@id", id)
            If MySQLConnection.State = ConnectionState.Closed Then
                MySQLConnection.ConnectionString = cstring
                MySQLConnection.Open()
                Command.Connection = MySQLConnection
            End If
            Command.ExecuteNonQuery()
            MsgBox("Data Deleted")
            MySQLConnection.Close()
            load_table()
        End If
    End Sub

    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
        ''Connect to Database
        Dim MySQLConnection As New MySqlConnection
        Dim cstring As String = "Server=localhost;Database=research_archive;uid=root;Pwd=Research123123"

        ''Convert Sy to Numeric
        Dim SY_num As Integer
        If IsNumeric(txtbox_sy.Text) Then
            SY_num = CInt(txtbox_sy.Text)
        End If

        Dim id As Integer = CInt(txtbox_id.Text)

        Dim Command As New MySqlCommand()
        Command.Connection = MySQLConnection
        Command.CommandText = "UPDATE research_archive.document SET " _
                            & "`title`= @Title, " _
                            & "`School_Year` = @School_Year, " _
                            & "`Keywords` = @keywords, " _
                            & "`Author` = @author, " _
                            & "`category_Science` = @sci, " _
                            & "`category_Engineering` = @eng, " _
                            & "`category_Technology` = @tech, " _
                            & "`category_Mathematics` = @math, " _
                            & "`category_Quantitative` = @quan, " _
                            & "`category_Qualitative` = @qual, " _
                            & "`Abstract` = @abs " _
                            & "WHERE `id` = @id"
        Command.Parameters.Clear()
        Command.Parameters.AddWithValue("@id", id)
        Command.Parameters.AddWithValue("@Title", txtbox_title.Text)
        Command.Parameters.AddWithValue("@Author", txtbox_author.Text)
        Command.Parameters.AddWithValue("@School_Year", SY_num)
        Command.Parameters.AddWithValue("@keywords", txtbox_kw.Text)
        Command.Parameters.AddWithValue("@sci", categoryCheckbox(chkbox_sci))
        Command.Parameters.AddWithValue("@eng", categoryCheckbox(chkbox_eng))
        Command.Parameters.AddWithValue("@tech", categoryCheckbox(chkbox_tech))
        Command.Parameters.AddWithValue("@math", categoryCheckbox(chkbox_math))
        Command.Parameters.AddWithValue("@quan", categoryCheckbox(chkbox_quanti))
        Command.Parameters.AddWithValue("@qual", categoryCheckbox(chkbox_quali))
        Command.Parameters.AddWithValue("@abs", rchtxtbox_abstract.Text)
        If MySQLConnection.State = ConnectionState.Closed Then
            MySQLConnection.ConnectionString = cstring
            MySQLConnection.Open()
            Command.Connection = MySQLConnection
        End If
        Command.ExecuteNonQuery()
        MsgBox("Data Save")
        MySQLConnection.Close()
        load_table()
    End Sub

    Private Sub GunaButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton3.Click
        Dim del As DialogResult = MessageBox.Show("Are you sure you want to delete this research?", "Confirm Deletion", MessageBoxButtons.YesNoCancel)

        If del = DialogResult.Yes Then
            ''Connect to Database
            Dim MySQLConnection As New MySqlConnection
            Dim cstring As String = "Server=localhost;Database=research_archive;uid=root;Pwd=Research123123"

            ''Convert Sy to Numeric
            Dim SY_num As Integer
            If IsNumeric(txtbox_sy.Text) Then
                SY_num = CInt(txtbox_sy.Text)
            End If

            Dim id As Integer = CInt(txtbox_id.Text)

            Dim Command As New MySqlCommand()
            Command.Connection = MySQLConnection
            Command.CommandText = "DELETE FROM research_archive.document WHERE `id` = @id"
            'Command.CommandText = "UPDATE research_archive.document SET (title, School_Year, Keywords, category_Engineering, category_Engineering)"
            Command.Parameters.Clear()
            Command.Parameters.AddWithValue("@id", id)
            If MySQLConnection.State = ConnectionState.Closed Then
                MySQLConnection.ConnectionString = cstring
                MySQLConnection.Open()
                Command.Connection = MySQLConnection
            End If
            Command.ExecuteNonQuery()
            MsgBox("Data Deleted")
            MySQLConnection.Close()
            load_table()
        End If
    End Sub


    Private Sub GunaLabel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel5.Click
        adminMainMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub GunaLabel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel6.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub GunaLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel4.Click
        MessageBox.Show("Instructions: " & vbCrLf & "To edit researches in the SAAP (Specific Archive for Academic Papers)" & vbCrLf & "Procedures: " & vbCrLf & "1.)Click the information of the document which is any of these three row : filename, title, or author. " & vbCrLf & "2.)Once the information is clicked the research informations will be shown. " & vbCrLf & "3.)The shown research informations can be edited and the document can also be removed from the Archive.", "GUIDE")
    End Sub

    Private Sub GunaLabel4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel4.MouseHover
        GunaLabel4.ForeColor = Color.DarkGray
    End Sub

    Private Sub GunaLabel5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel5.MouseHover
        GunaLabel5.ForeColor = Color.DarkGray
    End Sub

    Private Sub GunaLabel6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel6.MouseHover
        GunaLabel6.ForeColor = Color.DarkGray
    End Sub

    Private Sub GunaLabel4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel4.MouseLeave
        GunaLabel4.ForeColor = Color.White
    End Sub

    Private Sub GunaLabel5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel5.MouseLeave
        GunaLabel5.ForeColor = Color.White
    End Sub

    Private Sub GunaLabel6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel6.MouseLeave
        GunaLabel6.ForeColor = Color.White
    End Sub
End Class
Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Linq

Public Class adminEditForm

    Dim dbDataSet As New DataTable

    Private Sub adminEditForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_table()
    End Sub

    Private Sub load_table()
        Dim MySQLConnection As New MySqlConnection
        Dim cstring As String = "Server=localhost;Database=research_archive;uid=root;Pwd=Research123123"
        MySQLConnection.ConnectionString = cstring
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            Dim query As String
            MySQLConnection.Open()
            query = "select id, filename, title, abstract, School_Year, keywords, category_Science, category_Engineering, category_Mathematics, category_Technology, category_Quantitative, category_Qualitative  from research_archive.document"
            Dim command As New MySqlCommand(query, MySQLConnection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            MySQLConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySQLConnection.Dispose()
        End Try
    End Sub

    
    Private Sub btn_UploadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EditData.Click
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
                            & "`category_Science` = @sci, " _
                            & "`category_Engineering` = @eng, " _
                            & "`category_Technology` = @tech, " _
                            & "`category_Mathematics` = @math, " _
                            & "`category_Quantitative` = @quan, " _
                            & "`category_Qualitative` = @qual, " _
                            & "`Abstract` = @abs " _
                            & "WHERE `id` = @id"
        'Command.CommandText = "UPDATE research_archive.document SET (title, School_Year, Keywords, category_Engineering, category_Engineering)"
        Command.Parameters.Clear()
        Command.Parameters.AddWithValue("@id", id)
        Command.Parameters.AddWithValue("@Title", txtbox_title.Text)
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

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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
        Me.DataGridView1.DataSource = dbDataSet
        Me.DataGridView1.Update()
        Me.DataGridView1.Refresh()
        If MySQLConnection.State = ConnectionState.Closed Then
            MySQLConnection.ConnectionString = cstring
            MySQLConnection.Open()
            Command.Connection = MySQLConnection
        End If
        Command.ExecuteNonQuery()
        MsgBox("Data Deleted")
        MySQLConnection.Close()
    End Sub
End Class
Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO
Imports System.Linq


Public Class studentForm

    Dim dbDataSet As New DataTable
    Public prev As Boolean

    Private Sub adminEditForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_table()
        Label4.ForeColor = Color.Green
        RichTextBox1.SelectionProtected = True
        Me.CenterToScreen()
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
            query = "select filename, title as 'Research Title', abstract, keywords, category_Science, category_Engineering, category_Mathematics, category_Technology, category_Quantitative, category_Qualitative  from research_archive.document"
            Dim command As New MySqlCommand(query, MySQLConnection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            Me.DataGridView1.Columns("abstract").Visible = False
            Me.DataGridView1.Columns("filename").Visible = False
            Me.DataGridView1.Columns("keywords").Visible = False
            Me.DataGridView1.Columns("category_Science").Visible = False
            Me.DataGridView1.Columns("category_Engineering").Visible = False
            Me.DataGridView1.Columns("category_Technology").Visible = False
            Me.DataGridView1.Columns("category_Mathematics").Visible = False
            Me.DataGridView1.Columns("category_Quantitative").Visible = False
            Me.DataGridView1.Columns("category_Qualitative").Visible = False
            Me.DataGridView1.Columns("Research Title").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.DataGridView1.Columns("Research TItle").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            MySQLConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySQLConnection.Dispose()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            Dim abs As String = row.Cells("abstract").Value.ToString
            Dim fname As String = row.Cells("filename").Value.ToString
            Dim kw As String = row.Cells("keywords").Value.ToString
            Label4.ForeColor = Color.OrangeRed
            Label4.Text = "STATUS: CALCULATING, PLEASE WAIT"
            Cursor = Cursors.WaitCursor
            Application.DoEvents()
            Dim results As List(Of Integer) = WordDocx.checker(fname)
            Dim ress As New List(Of String)
            For Each res In results
                ress.Add(res.ToString())
            Next
            RichTextBox1.Text = abs
            RichTextBox1.AppendText("keywords: " + kw)
            RichTextBox2.AppendText("sentence match: " + ress(0))
            RichTextBox2.AppendText("percentage: " + ress(1) + "%")
            Label4.Text = "STATUS: DONE"
            Label4.ForeColor = Color.Green
            Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub adminEditForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really wanna close the Application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub RichTextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.GotFocus
        RichTextBox1.SelectionLength = 0
    End Sub

    Private Sub RichTextBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseDoubleClick
        RichTextBox1.SelectionLength = 0
    End Sub

    Private Sub RichTextBox1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.SelectionChanged
        RichTextBox1.SelectionLength = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim DV As New DataView(dbDataSet)
        Dim stringFilter As String = String.Empty

        If CheckBox1.Checked Then
            stringFilter += " [category_Science]=1 "
        End If
        If CheckBox2.Checked Then
            If stringFilter.Length > 0 Then
                stringFilter += " AND"
            End If
            stringFilter += " [category_Engineering]=1"
        End If
        If CheckBox3.Checked Then
            If stringFilter.Length > 0 Then
                stringFilter += " AND"
            End If
            stringFilter += " [category_Technology]=1"
        End If
        If CheckBox4.Checked Then
            If stringFilter.Length > 0 Then
                stringFilter += " AND"
            End If
            stringFilter += " [category_Mathematics]=1"
        End If
        If CheckBox5.Checked Then
            If stringFilter.Length > 0 Then
                stringFilter += " AND"
            End If
            stringFilter += " [category_Quantitative]=1"
        End If
        If CheckBox6.Checked Then
            If stringFilter.Length > 0 Then
                stringFilter += " AND"
            End If
            stringFilter += " [category_Qualitative]=1"
        End If

        DV.RowFilter = (stringFilter) + " AND " + String.Format("keywords Like '%{0}%'", TextBox1.Text)
        DataGridView1.DataSource = DV
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    End Sub
End Class
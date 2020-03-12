Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO
Imports System.Linq

Public Class studentForm

    Dim currentlySelectedRow As Integer = -1

    Dim dbDataSet As New DataTable
    Public prev As Boolean
    Public fname As String

    Private Sub adminEditForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_table()
        Label4.ForeColor = Color.Green
        RichTextBox1.SelectionProtected = True
        Me.CenterToScreen()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Function TryGetCellContent() As String
        If DataGridView1.Rows.Count = 0 Then Return "N/A"
        If currentlySelectedRow > -1 Then
            Dim cellContent As String
            cellContent = DataGridView1.Rows(currentlySelectedRow) _
            .Cells("abstract").Value.ToString()
            fname = DataGridView1.Rows(currentlySelectedRow).Cells("filename").Value.ToString
            Return cellContent
        End If
        Return "N/A"
    End Function

    Private Sub DataGridView1_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        currentlySelectedRow = e.RowIndex
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

    Private Sub adminEditForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button.Click
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

        If stringFilter = "" Then
            DV.RowFilter = String.Format("keywords Like '%{0}%'", TextBox1.Text)
        Else
            DV.RowFilter = (stringFilter) + " AND " + String.Format("keywords Like '%{0}%'", TextBox1.Text)
        End If
        DataGridView1.DataSource = DV
    End Sub

    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
        If fname = "" Then
            MessageBox.Show("No Research Paper Is Selected")
        Else
            Cursor = Cursors.WaitCursor
            Dim results As List(Of Integer) = WordDocx.checker(fname)
            MessageBox.Show("sentence match: " + results(0).ToString + " percentage match: " + results(1).ToString)
            Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub GunaButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton2.Click
        RichTextBox1.Text = TryGetCellContent()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub GunaLabel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel6.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub GunaLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel4.Click
        MessageBox.Show("Instructions:" & vbCrLf & "The Student Page contains keyword filter to be able to search for specific researches and also the" & vbCrLf & "researches are sort by their categories. It also shows research’s abstracts." & vbCrLf & "Procedures: " & vbCrLf & "•Type the keyword of the research and it will be sorted accordingly" & vbCrLf & "•Check categories and the researches will be sorted according to the checked category" & vbCrLf & "•Click the row of the research then click the Preview and the Abstract of the research will be shown" & vbCrLf & "•Click Compare Sentence Match as the selected research is previewed the percentage and exact similar sentence count will be shown. (The result is based on the database of the upload researches) ", "GUIDE")
    End Sub

    Private Sub GunaLabel4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel4.MouseHover
        GunaLabel4.ForeColor = Color.DarkGray
    End Sub

    Private Sub GunaLabel4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel4.MouseLeave
        GunaLabel4.ForeColor = Color.White
    End Sub

    Private Sub GunaLabel6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel6.MouseHover
        GunaLabel6.ForeColor = Color.DarkGray
    End Sub

    Private Sub GunaLabel6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel6.MouseLeave
        GunaLabel6.ForeColor = Color.White
    End Sub
End Class
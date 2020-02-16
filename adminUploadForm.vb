Imports System.IO
Imports System.Drawing
Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class adminUploadForm

    Dim folderPath As String = "C:\Archive"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_selectDoc.Click
        OpenFileDialog1.Filter = "Microsoft Word Document (.docx) | *.docx"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1 IsNot Nothing Then
            TextBox1.Text = OpenFileDialog1.FileName.ToString()
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_UploadData.Click
        ''Extract file name
        Dim FullFileName() As String = OpenFileDialog1.FileName.Split("\")
        Dim fname As String = FullFileName.Last.ToString()

        ''Dim fileContent As Byte()
        Dim FileData As Byte() = File.ReadAllBytes(OpenFileDialog1.FileName)

        ''Convert Sy to Numeric
        Dim SY_num As Integer
        If IsNumeric(txtbox_sy.Text) Then
            SY_num = CInt(txtbox_sy.Text)
        End If

        ''Connect to Database
        Dim MySQLConnection As New MySqlConnection
        Dim cstring As String = "Server=localhost;Database=research_archive;uid=root;Pwd=Research123123"

        Dim SqlQuery As String = "SELECT COUNT(*) From login WHERE username = @username AND password = @password; "

        Dim Command As New MySqlCommand(SqlQuery, MySQLConnection)

        

        'Insert File in the database
        Command.CommandText = "SET GLOBAL max_allowed_packet=1024*1024*1024;"
        If MySQLConnection.State = ConnectionState.Closed Then
            MySQLConnection.ConnectionString = cstring
            MySQLConnection.Open()
            Command.Connection = MySQLConnection
        End If
        Command.ExecuteNonQuery()

        ''Check if there's already existing item on database
        Dim dr As MySqlDataReader
        Dim names As New List(Of String)
        Dim id As Integer = 0
        Command.CommandText = "select * from document"
        dr = Command.ExecuteReader
        While dr.Read()
            names.Add(dr(3))
            id += 1
        End While
        dr.Close()

        Dim commandAvailable = True
        For Each name As String In names
            If name = txtbox_title.Text Then
                commandAvailable = False
            End If
        Next

        If commandAvailable = True Then
            Command.CommandText = "insert into document (id, Filename, File, Title, Author," _
                                 & "School_Year, Keywords, category_Science, category_Engineering, category_Technology," _
                                 & "category_Mathematics, category_Quantitative, category_Qualitative, Abstract) values" _
                                 & "(@id, @FileName, @File, @Title, @Author, @School_Year, @keywords, @sci, @eng, @tech, @math, @quan, @qual, @abst)"
            Command.Parameters.Clear()
            Command.Parameters.AddWithValue("@id", id)
            Command.Parameters.AddWithValue("@FileName", fname)
            Command.Parameters.AddWithValue("@File", FileData)
            Command.Parameters.AddWithValue("@Title", txtbox_title.Text)
            Command.Parameters.AddWithValue("@Author", txtBox_Author.Text)
            Command.Parameters.AddWithValue("@School_Year", SY_num)
            Command.Parameters.AddWithValue("@keywords", txtbox_kw.Text)
            Command.Parameters.AddWithValue("@sci", categoryCheckbox(chkbox_sci))
            Command.Parameters.AddWithValue("@eng", categoryCheckbox(chkbox_eng))
            Command.Parameters.AddWithValue("@tech", categoryCheckbox(chkbox_tech))
            Command.Parameters.AddWithValue("@math", categoryCheckbox(chkbox_math))
            Command.Parameters.AddWithValue("@quan", categoryCheckbox(chkbox_quanti))
            Command.Parameters.AddWithValue("@qual", categoryCheckbox(chkbox_quali))
            Command.Parameters.AddWithValue("@abst", rchtxtbox_abstract.Text)
            If MySQLConnection.State = ConnectionState.Closed Then
                MySQLConnection.ConnectionString = cstring
                MySQLConnection.Open()
                Command.Connection = MySQLConnection
            End If
            Command.ExecuteNonQuery()
        Else
            MsgBox("Research Already Putted in The DataBase or contains the same title with other research")
        End If

        MsgBox("Research Succesfully Added To Database!")

    End Sub


    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ''Select Data
        ''Connect to Database
        Dim MySQLConnection As New MySqlConnection
        Dim cstring As String = "Server=localhost;Database=research_archive;uid=root;Pwd=Research123123"

        Dim SqlQuery As String = "SELECT COUNT(*) From login WHERE username = @username AND password = @password; "
        Dim Command As New MySqlCommand(SqlQuery, MySQLConnection)

        Dim dr As MySqlDataReader

        If MySQLConnection.State = ConnectionState.Closed Then
            MySQLConnection.ConnectionString = cstring
            MySQLConnection.Open()
            Command.Connection = MySQLConnection
        End If

        Command.CommandText = "select * from document_table"
        dr = Command.ExecuteReader

        ''Looping through database and retrieving everything
        Dim files As New List(Of Byte())
        Dim names As New List(Of String)
        While dr.Read()
            Dim fileBytes() As Byte = CType(dr(1), Byte())
            files.Add(fileBytes)
            names.Add(dr(1))
        End While

        ''Checking if folder has things
        ' Make a reference to a directory.
        Dim di As New DirectoryInfo(folderPath)
        ' Get a reference to each file in that directory.
        Dim fiArr As FileInfo() = di.GetFiles()
        ' Display the names of the files.
        Dim fri As FileInfo

        For Each fri In fiArr
            My.Computer.FileSystem.DeleteFile(folderPath + "\" + fri.Name)
        Next

        Dim nameCount As Integer = -1
        For Each docFile() As Byte In files
            nameCount += 1
            Dim filepath As String = folderPath + "\" + names(nameCount)
            File.WriteAllBytes(filepath, docFile)
        Next

        MsgBox("Research Succesfully Retrieved From Database!")

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

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start(folderPath)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class

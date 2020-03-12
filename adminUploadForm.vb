Imports System.IO
Imports System.Drawing
Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class adminUploadForm

    Dim folderPath As String = "C:\Archive"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.Filter = "Microsoft Word Document (.docx) | *.docx"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1 IsNot Nothing Then
            TextBox1.Text = OpenFileDialog1.FileName.ToString()
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim canUpload As Boolean = True

        ''Check to see if there is empty strings
        If txtbox_title.Text = "" Then
            MsgBox("Title can't leave out as empty")
            canUpload = False
        End If

        If TextBox1.Text = "" Then
            MsgBox("Please select a file")
            canUpload = False
        End If

        If txtBox_Author.Text = "" Then
            MsgBox("Author can't leave out as empty")
            canUpload = False
        End If

        If rchtxtbox_abstract.Text = "" Then
            MsgBox("Abstract can't leave out as empty")
            canUpload = False
        End If

        ''Extract file name
        Dim FullFileName() As String = OpenFileDialog1.FileName.Split("\")
        Dim fname As String = FullFileName.Last.ToString()

        ''Dim fileContent As Byte()
        Dim FileData As Byte() = File.ReadAllBytes(OpenFileDialog1.FileName)

        ''Convert Sy to Numeric
        Dim SY_num As Integer
        If IsNumeric(txtbox_sy.Text) Then
            SY_num = CInt(txtbox_sy.Text)
        Else
            MsgBox("School Year must be Numeric Only")
            canUpload = False
        End If


        If canUpload = True Then
            ''Connect to Database
            Dim MySQLConnection As New MySqlConnection
            Dim cstring As String = "Server=localhost;Database=research_archive;uid=root;Pwd=Research123123"
            Dim SqlQuery As String = "SELECT * FROM research_archive"

            Dim Command As New MySqlCommand(SqlQuery, MySQLConnection)

            'Insert File in the database
            Command.CommandText = "SET GLOBAL max_allowed_packet=1024*1024*1024;"
            If MySQLConnection.State = ConnectionState.Closed Then
                MySQLConnection.ConnectionString = cstring
                MySQLConnection.Open()
                Command.Connection = MySQLConnection
            End If
            Command.ExecuteNonQuery()
            MySQLConnection.Dispose()

            ''Check if there's already existing item on database
            MySQLConnection.Open()
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
            txtbox_title.Text = ""
            TextBox1.Text = ""
            txtBox_Author.Text = ""
            txtbox_sy.Text = ""
            txtbox_kw.Text = ""
            rchtxtbox_abstract.Text = ""
            chkbox_eng.Checked = False
            chkbox_math.Checked = False
            chkbox_quali.Checked = False
            chkbox_quanti.Checked = False
            chkbox_sci.Checked = False
            chkbox_tech.Checked = False
        End If

    End Sub


    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

        Command.CommandText = "select * from document"
        dr = Command.ExecuteReader

        ''Looping through database and retrieving everything
        Dim files As New List(Of Byte())
        Dim names As New List(Of String)
        While dr.Read()
            Dim fileBytes() As Byte = CType(dr(2), Byte())
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

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GunaButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton2.Click
        OpenFileDialog1.Filter = "Microsoft Word Document (.docx) | *.docx"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1 IsNot Nothing Then
            TextBox1.Text = OpenFileDialog1.FileName.ToString()
        End If
    End Sub

    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
        Dim canUpload As Boolean = True

        Dim FullFileName() As String
        Dim fname As String
        Dim FileData As Byte()

        ''Check to see if there is empty strings
        If txtbox_title.Text = "" Then
            MsgBox("Title can't leave out as empty")
            canUpload = False
        End If

        If TextBox1.Text = "" Then
            MsgBox("Please select a file")
            canUpload = False
        End If

        If txtBox_Author.Text = "" Then
            MsgBox("Author can't leave out as empty")
            canUpload = False
        End If

        If rchtxtbox_abstract.Text = "" Then
            MsgBox("Abstract can't leave out as empty")
            canUpload = False
        End If

        ''Extract file name
        If OpenFileDialog1.FileName = "" Then
            MessageBox.Show("Please upload document file")
        Else
            FullFileName = OpenFileDialog1.FileName.Split("\")
            fname = FullFileName.Last.ToString()
            ''Dim fileContent As Byte()
            FileData = File.ReadAllBytes(OpenFileDialog1.FileName)
        End If
        

        ''Convert Sy to Numeric
        Dim SY_num As Integer
        If IsNumeric(txtbox_sy.Text) Then
            SY_num = CInt(txtbox_sy.Text)
        Else
            MsgBox("School Year must be Numeric Only")
            canUpload = False
        End If


        If canUpload = True Then
            ''Connect to Database
            Dim MySQLConnection As New MySqlConnection
            Dim cstring As String = "Server=localhost;Database=research_archive;uid=root;Pwd=Research123123"
            Dim SqlQuery As String = "SELECT * FROM research_archive"

            Dim Command As New MySqlCommand(SqlQuery, MySQLConnection)

            'Insert File in the database
            Command.CommandText = "SET GLOBAL max_allowed_packet=1024*1024*1024;"
            If MySQLConnection.State = ConnectionState.Closed Then
                MySQLConnection.ConnectionString = cstring
                MySQLConnection.Open()
                Command.Connection = MySQLConnection
            End If
            Command.ExecuteNonQuery()
            MySQLConnection.Dispose()

            ''Check if there's already existing item on database
            MySQLConnection.Open()
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
            txtbox_title.Text = ""
            TextBox1.Text = ""
            txtBox_Author.Text = ""
            txtbox_sy.Text = ""
            txtbox_kw.Text = ""
            rchtxtbox_abstract.Text = ""
            chkbox_eng.Checked = False
            chkbox_math.Checked = False
            chkbox_quali.Checked = False
            chkbox_quanti.Checked = False
            chkbox_sci.Checked = False
            chkbox_tech.Checked = False
        End If
    End Sub

    Private Sub GunaButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton3.Click
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

        Command.CommandText = "select * from document"
        dr = Command.ExecuteReader

        ''Looping through database and retrieving everything
        Dim files As New List(Of Byte())
        Dim names As New List(Of String)
        While dr.Read()
            Dim fileBytes() As Byte = CType(dr(2), Byte())
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

    Private Sub GunaButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton4.Click
        Process.Start(folderPath)
    End Sub

    Private Sub GunaLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel4.Click
        MessageBox.Show("Instructions : To upload research to the SAAP (Specific Archive for Academic Papers)" & vbCrLf & "Provide these informations of researches that is needed to update/add the research to the archive : " & vbCrLf & "1.) Type the Title of the Research" & vbCrLf & "2.) Type the Author/s (author 1)(author 2)(author 3) etc. " & vbCrLf & "format: ( Last Name, First Name _Middle Initial)" & vbCrLf & "example: (Rodriguez, Mark T.) (Tan, John P.) " & vbCrLf & "3.) Type the keyword from the Abstract of the Research.(KEYWORD)" & vbCrLf & "4.) Open the research file and copy the Abstract of the Research and paste the information to " & vbCrLf & "the data designated place. (ABSTRACT) " & vbCrLf & "5. ) Check the box/es where the Research is categorized." & vbCrLf & "6.) Then click Upload To Database the research to be stored in the archive. " & vbCrLf & "" & vbCrLf & "To retrieve documents to the SAAP:" & vbCrLf & "1.)Click Update Documents to retrieve documents from the Archive." & vbCrLf & "2.)Then click the Open Archive Folder to go to the location and view the documents ." & vbCrLf & "" & vbCrLf & "Warnings: " & vbCrLf & "1.)The database won’t be uploaded if the document is open." & vbCrLf & "2.)The datas won’t be uploaded if the needed informations were not provided. If the needed information does not exist type N/A.", "GUIDE")
        'MessageBox.Show("Instruction", ">Insert your Title on the textbox" & vbCrLf & ">After that, select a document in a docx format" & vbCrLf & ">Type Author in (Last Name, First Name M.I)(author 2)(author 3) format" & vbCrLf & ">Insert Starting School Year eg. 2019" & vbCrLf & ">COPY the Keywords from your file and PASTE it on the textbox named Keyword" & vbCrLf & ">Open your research files and COPY the abstract from the research paper then PASTE it on text box named Abstract" & vbCrLf & ">Click and choose from what category they belong to" & vbCrLf & "Click upload to database then,
        '               >Click Update Documents // or else plagiarism checker won't work")
    End Sub

    Private Sub GunaLabel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel5.Click
        adminMainMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub GunaLabel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel6.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub GunaLabel4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel4.MouseHover
        GunaLabel4.ForeColor = Color.DarkGray
    End Sub

    Private Sub GunaLabel4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel4.MouseLeave
        GunaLabel4.ForeColor = Color.White
    End Sub

    Private Sub GunaLabel5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel5.MouseHover
        GunaLabel5.ForeColor = Color.DarkGray
    End Sub

    Private Sub GunaLabel5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel5.MouseLeave
        GunaLabel5.ForeColor = Color.White
    End Sub

    Private Sub GunaLabel6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel6.MouseHover
        GunaLabel6.ForeColor = Color.DarkGray
    End Sub

    Private Sub GunaLabel6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLabel6.MouseLeave
        GunaLabel6.ForeColor = Color.White
    End Sub
End Class

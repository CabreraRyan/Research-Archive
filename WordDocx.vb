Imports Microsoft.Office.Interop.Word
Imports System.IO
Imports System.Linq

Module WordDocx

    Public Function getDocText(ByVal filepath As String) As String
        If File.Exists(filepath) AndAlso Path.GetExtension(filepath).ToUpper.Equals(".DOCX") Then
            Dim app As Application = New Application
            Dim doc As Document = app.Documents.Open(filepath)
            Dim doctxt As String = doc.Content.Text
            app.Quit()
            Return doctxt
        Else
            Return Nothing
        End If
    End Function

    ''Function that returns the matched sentences
    Public Function sentencesMatch(ByVal document_list As List(Of String()), ByVal main_doc As List(Of String)) As Integer

        'Linq(Method)
        Dim sentenceQuery = From sentence In main_doc
                        From doc In document_list
                        Where doc.Any(Function(x) sentence.Equals(x))
                        Select sentence

        Return sentenceQuery.Count
    End Function

    ''Function that gives a percentage of matched sentences
    Public Function percentMatch(ByVal sentence_match As Integer, ByVal total_sentences As List(Of String)) As Integer
        Return (sentence_match / total_sentences.Count) * 100
    End Function

    Public Function checker(ByVal fname As String) As List(Of Integer)
        ''Plagiarism Checker
        ''Main Document
        Dim docfilepath As String = "C:\Archive\" + fname
        Dim doctext As String = getDocText(docfilepath)
        ' Make a reference to a directory.
        Dim di As New DirectoryInfo("C:\Archive")
        ' Get a reference to each file in that directory.
        Dim fiArr As FileInfo() = di.GetFiles()
        ' Display the names of the files.
        Dim fri As FileInfo

        Dim documents As New List(Of String)
        Dim documents_text As New List(Of String)

        For Each fri In fiArr
            If fri.FullName = docfilepath Then
                Continue For
            End If
            If fri.FullName.Contains("~$") Then
                Continue For
            End If
            documents.Add(fri.FullName)
        Next

        For Each doc In documents
            documents_text.Add(getDocText(doc))
        Next

        Dim main_string = From doc In doctext.Split(New Char() {"."c})
                          Where doc.ToList.RemoveAll(Function(str) String.IsNullOrWhiteSpace(str))
                          Select doc


        Dim sentences As New List(Of String())
        Dim sentencez() As String = Nothing

        For Each sentence As String In documents_text
            If sentence IsNot Nothing Then
                sentencez = sentence.Split(New Char() {"."c})
                sentences.Add(sentencez)
            End If
        Next

        'LINQ ALTERNATIVE
        'Dim mainDoc = From docs In documents_text
        'w = docs.Split(New Char() {"."c})
        'Where(w.ToList.RemoveAll(Function(str) String.IsNullOrWhiteSpace(str)))
        '             Select w.ToArray


        ''Convert Array to List
        Dim list_1 As List(Of String) = main_string.ToList
        Dim list_docs As List(Of String()) = sentences.ToList

        Dim matchingSentences As Integer = sentencesMatch(list_docs, list_1)
        Dim percentageMatchingSentences As Integer = percentMatch(matchingSentences, list_1)
        Dim ret As New List(Of Integer)
        ret.Add(matchingSentences)
        ret.Add(percentageMatchingSentences)

        Return ret
    End Function

End Module

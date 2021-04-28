Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.IO
Imports System.Linq
Imports System.Web
Imports Lucene.Net.Analysis.Standard
Imports Lucene.Net.Documents
Imports Lucene.Net.Index
Imports Lucene.Net.QueryParsers
Imports Lucene.Net.Search
Imports Lucene.Net.Store
Imports Version = Lucene.Net.Util.Version

Namespace MvcLuceneSampleApp.Search
    Module LuceneSearch
        Private _luceneDir As String = Path.Combine("c:\lucene_index")
        Private _directoryTemp As FSDirectory

        Sub TestLuceneSearch()
            ''Lucene Search Initialization to create folder and index for search
            'LuceneSearch.Initialize()

            Dim resultMovies() As Movie
            resultMovies = LuceneSearch.SearchMovieResults("J")

            If resultMovies.Length = 0 Then
                Console.WriteLine("NO RESULTS")
            Else
                For i = 0 To resultMovies.Length - 1
                    resultMovies(i).Print()
                Next
            End If
        End Sub

        Public Function SearchMovieResults(ByVal input As String)
            'Create a List of Movie objects to store the Results of the Search
            Dim search_res As List(Of Movie) = New List(Of Movie)()

            'Call Search with a String and store Results to a List
            search_res = LuceneSearch.Search(input)

            'If there was no Search Results return an empty Array
            If search_res.Count.Equals(0) Then
                Dim emptyArray(-1) As Movie
                Return emptyArray
            Else
                'Put ID Results to an Array
                Dim ID_args(search_res.Count - 1) As String
                For i As Integer = 0 To search_res.Count - 1
                    ID_args(i) = search_res(i).Id
                Next

                'Initialize Query String for the first resulted Movie
                Dim string0 As String = "select * from Movies where id=@0"

                'Append Query String for every next id in ID_args Array
                Dim sb As New System.Text.StringBuilder()
                sb.Append(string0)
                For j As Integer = 1 To ID_args.Length - 1
                    sb.Append(" ").Append("or id=@").Append(j.ToString)
                Next

                'Print qstring for Debug
                Console.WriteLine("Query String Made:")
                Dim qstring As String = sb.ToString
                Console.WriteLine(qstring)

                'Run Query
                Dim con As New Connection
                Dim results As New DataTable
                con.RunQuery(qstring, ID_args, results)

                'Get Resulted Movies Fields and store them in an Movie Array
                Dim resultMovies(search_res.Count - 1) As Movie  'search_res.Count : number of hits results (-1 size of the Array)

                For i = 0 To resultMovies.Length - 1
                    resultMovies(i) = New Movie
                    resultMovies(i).Id = results.Rows(i)("id").ToString
                    resultMovies(i).Title = results.Rows(i)("title").ToString
                    resultMovies(i).Year = results.Rows(i)("year").ToString
                    resultMovies(i).Description = results.Rows(i)("description").ToString
                    resultMovies(i).Rating = results.Rows(i)("rating").ToString
                    resultMovies(i).Url = results.Rows(i)("image_url").ToString
                Next

                Return resultMovies
            End If
        End Function

        Sub CreateIndexDirectory()
            If (Not System.IO.Directory.Exists(_luceneDir)) Then
                System.IO.Directory.CreateDirectory(_luceneDir)
            End If
        End Sub

        Sub Initialize()
            LuceneSearch.CreateIndexDirectory()
            LuceneSearch.AddUpdateLuceneIndex(MovieMod.GetAllMovies)
        End Sub

        Private ReadOnly Property _directory As FSDirectory
            Get
                If _directoryTemp Is Nothing Then _directoryTemp = FSDirectory.Open(New DirectoryInfo(_luceneDir))
                If IndexWriter.IsLocked(_directoryTemp) Then IndexWriter.Unlock(_directoryTemp)
                Dim lockFilePath = Path.Combine(_luceneDir, "write.lock")
                If File.Exists(lockFilePath) Then File.Delete(lockFilePath)
                Return _directoryTemp
            End Get
        End Property

        Private Sub _addToLuceneIndex(ByVal sampleData As Movie, ByVal writer As IndexWriter)
            Dim searchQuery = New TermQuery(New Term("Id", sampleData.Id.ToString()))
            writer.DeleteDocuments(searchQuery)
            Dim doc = New Document()
            doc.Add(New Field("Id", sampleData.Id.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED))
            doc.Add(New Field("Title", sampleData.Title, Field.Store.YES, Field.Index.ANALYZED))
            doc.Add(New Field("Description", sampleData.Description, Field.Store.YES, Field.Index.ANALYZED))
            writer.AddDocument(doc)
        End Sub

        Sub AddUpdateLuceneIndex(ByVal sampleDatas As IEnumerable(Of Movie))
            Dim analyzer = New StandardAnalyzer(Version.LUCENE_30)

            Using writer = New IndexWriter(_directory, analyzer, IndexWriter.MaxFieldLength.UNLIMITED)

                For Each Movie In sampleDatas
                    _addToLuceneIndex(Movie, writer)
                Next

                analyzer.Close()
                writer.Dispose()
            End Using
        End Sub

        Sub AddUpdateLuceneIndex(ByVal sampleData As Movie)
            AddUpdateLuceneIndex(New List(Of Movie) From {
                sampleData
            })
        End Sub

        Sub ClearLuceneIndexRecord(ByVal record_id As Integer)
            Dim analyzer = New StandardAnalyzer(Version.LUCENE_30)

            Using writer = New IndexWriter(_directory, analyzer, IndexWriter.MaxFieldLength.UNLIMITED)
                Dim searchQuery = New TermQuery(New Term("Id", record_id.ToString()))
                writer.DeleteDocuments(searchQuery)
                analyzer.Close()
                writer.Dispose()
            End Using
        End Sub

        Function ClearLuceneIndex() As Boolean
            Try
                Dim analyzer = New StandardAnalyzer(Version.LUCENE_30)

                Using writer = New IndexWriter(_directory, analyzer, True, IndexWriter.MaxFieldLength.UNLIMITED)
                    writer.DeleteAll()
                    analyzer.Close()
                    writer.Dispose()
                End Using

            Catch __unusedException1__ As Exception
                Return False
            End Try

            Return True
        End Function

        Sub Optimize()
            Dim analyzer = New StandardAnalyzer(Version.LUCENE_30)

            Using writer = New IndexWriter(_directory, analyzer, IndexWriter.MaxFieldLength.UNLIMITED)
                analyzer.Close()
                writer.Optimize()
                writer.Dispose()
            End Using
        End Sub

        Private Function _mapLuceneDocumentToData(ByVal doc As Document) As Movie
            Return New Movie With {
                .Id = Convert.ToInt32(doc.[Get]("Id")),
                .Title = doc.[Get]("Title"),
                .Description = doc.[Get]("Description")
            }
        End Function

        Private Function _mapLuceneToDataList(ByVal hits As IEnumerable(Of Document)) As IEnumerable(Of Movie)
            Return hits.[Select](AddressOf _mapLuceneDocumentToData).ToList()
        End Function

        Private Function _mapLuceneToDataList(ByVal hits As IEnumerable(Of ScoreDoc), ByVal searcher As IndexSearcher) As IEnumerable(Of Movie)
            Return hits.[Select](Function(hit) _mapLuceneDocumentToData(searcher.Doc(hit.Doc))).ToList()
        End Function

        Private Function parseQuery(ByVal searchQuery As String, ByVal parser As QueryParser) As Query
            Dim query As Query

            Try
                query = parser.Parse(searchQuery.Trim())
            Catch __unusedParseException1__ As ParseException
                query = parser.Parse(QueryParser.Escape(searchQuery.Trim()))
            End Try

            Return query
        End Function

        Private Function fparseQuery(ByVal searchQuery As String) As FuzzyQuery
            Dim query = New FuzzyQuery(New Term("Content", searchQuery), 0.5F)
            Return query
        End Function

        Private Function _search(ByVal searchQuery As String, ByVal Optional searchField As String = "") As IEnumerable(Of Movie)
            If String.IsNullOrEmpty(searchQuery.Replace("*", "").Replace("?", "")) Then Return New List(Of Movie)()

            Using searcher = New IndexSearcher(_directory, False)
                Dim hits_limit = 10
                Dim analyzer = New StandardAnalyzer(Version.LUCENE_30)

                If Not String.IsNullOrEmpty(searchField) Then
                    Dim parser = New QueryParser(Version.LUCENE_30, searchField, analyzer)
                    Dim query = parseQuery(searchQuery, parser)
                    Dim hits = searcher.Search(query, hits_limit).ScoreDocs
                    Dim results = _mapLuceneToDataList(hits, searcher)
                    analyzer.Close()
                    searcher.Dispose()
                    Return results
                Else
                    Dim parser = New MultiFieldQueryParser(Version.LUCENE_30, {"Id", "Title", "Description"}, analyzer)
                    Dim query = parseQuery(searchQuery, parser)
                    Dim hits = searcher.Search(query, Nothing, hits_limit, Sort.RELEVANCE).ScoreDocs
                    Dim results = _mapLuceneToDataList(hits, searcher)
                    analyzer.Close()
                    searcher.Dispose()
                    Return results
                End If
            End Using
        End Function

        Function Search(ByVal input As String, ByVal Optional fieldName As String = "") As IEnumerable(Of Movie)
            If String.IsNullOrEmpty(input) Then Return New List(Of Movie)()
            Dim terms = input.Trim().Replace("-", " ").Split(" "c).Where(Function(x) Not String.IsNullOrEmpty(x)).[Select](Function(x) x.Trim() & "*")
            input = String.Join(" ", terms)
            Return _search(input, fieldName)
        End Function

        Function SearchDefault(ByVal input As String, ByVal Optional fieldName As String = "") As IEnumerable(Of Movie)
            Return If(String.IsNullOrEmpty(input), New List(Of Movie)(), _search(input, fieldName))
        End Function

        Function GetAllIndexRecords() As IEnumerable(Of Movie)
            If Not System.IO.Directory.EnumerateFiles(_luceneDir).Any() Then Return New List(Of Movie)()
            Dim searcher = New IndexSearcher(_directory, False)
            Dim reader = IndexReader.Open(_directory, False)
            Dim docs = New List(Of Document)()
            Dim term = reader.TermDocs()

            While term.[Next]()
                docs.Add(searcher.Doc(term.Doc))
            End While

            reader.Dispose()
            searcher.Dispose()
            Return _mapLuceneToDataList(docs)
        End Function
    End Module
End Namespace

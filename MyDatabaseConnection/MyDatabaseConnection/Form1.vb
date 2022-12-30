Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml


Public Class Form1
    Private Sub btnSQLServer_Click(sender As Object, e As EventArgs) Handles btnSQLServer.Click
        Dim Counts As Integer = 0
        Dim builder As New SqlConnectionStringBuilder
        builder.DataSource = "ENTDEQ0044"
        builder.InitialCatalog = "DEQfactsDEV"
        builder.IntegratedSecurity = True
        Dim myconnection = New SqlConnection(builder.ConnectionString)
        myconnection.Open()
        Dim mycommand = New SqlCommand("SELECT * FROM [DEQfactsDEV].[dbo].[rt_StatisticalBaseCode]", myconnection)
        Dim myreader = mycommand.ExecuteReader
        While myreader.Read And Counts < 5
            MessageBox.Show(myreader.GetString(0) & "|" & myreader.GetString(1) & "|" & myreader.GetString(2) & "|" & Counts)
            Counts += 1
        End While
    End Sub

    Private Sub btnFlatFile_Click(sender As Object, e As EventArgs) Handles btnFlatFile.Click
        Dim Counts As Integer = 0
        Dim myStreamReader = New StreamReader("C:\Users\CBA463\source\repos\MyDatabaseConnection\FactsDataDownload.txt")
        Dim myStreamReaderInput = myStreamReader.ReadToEnd()
        While myStreamReaderInput <> Nothing And Counts < 5
            MessageBox.Show(myStreamReaderInput & " | " & Counts)
            myStreamReaderInput = myStreamReader.ReadLine()
            Counts += 1
        End While
        myStreamReader.Close()
    End Sub

    Private Sub xmlButton_Click(sender As Object, e As EventArgs) Handles xmlButton.Click
        Dim Counts As Integer = 0
        Dim myStreamReader = New StreamReader("C:\Users\CBA463\source\repos\MyDatabaseConnection\FactsDataDownload2.xml")
        Dim mySetting = New XmlReaderSettings
        Dim myReader = XmlReader.Create(myStreamReader, mySetting)
        While myReader.Read And Counts < 5
            MessageBox.Show(myReader.Name & " | " & myReader.Value & " | " & Counts)
            Counts += 1
        End While
    End Sub
End Class


Imports System.Data.OleDb
Public Class frmBook

    Dim con As New OleDbConnection

    Private Sub LoadDataGrid()


        ' Load_data_into_Listbox()
        ' LDILst2()

        ' This sets datagrid1 to the table and shows it for Logging Fixed Contacts
        ' Dim mcall = lblCall.Text
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        ' Dim strFilePrefix = "County Hunters- Common"
        'Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\County Hunter - K8EMS.accdb"
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile
        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString

        con.Open()

        da = New OleDbDataAdapter("SELECT [Book Name],Tracking FROM [Book List] ", con)


        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView

        con.Close()



    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        ' MainMenu.Show()
        Me.Close()

    End Sub

    Private Sub btnViewMenu_Click(sender As Object, e As EventArgs) Handles btnViewMenu.Click
        ViewEditMenu.Show()
        Me.Close()

    End Sub

    Private Sub frmBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid()


    End Sub

End Class


Imports System.Data.OleDb

Public Class frmMARAC
    Public Property StringPass As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click


        'MainMenu.Show()
        Me.Close()

    End Sub

    Dim con As New OleDbConnection
    Private Sub frmMARAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LoadDataGridOfficers()
        LoadDataGridDirectors()


    End Sub


    Private Sub LoadDataGridDirectors()


        ' This sets datagridDirectors to the table and shows it for Logging Fixed Contacts
        ' Dim mcall = lblCall.Text
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        ' Dim strFilePrefix = "County Hunters- Common"
        'Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\NetControl.accdb"
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile
        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString

        con.Open()

        da = New OleDbDataAdapter("SELECT * FROM  Directors", con)


        da.Fill(dt)
        DataGridViewDirectors.DataSource = dt.DefaultView


        con.Close()




    End Sub

    Private Sub LoadDataGridOfficers()

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
        Dim databaseFile As String = "C:\RRLogger Data\NetControl.accdb"
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile
        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString

        con.Open()

        da = New OleDbDataAdapter("SELECT * FROM  Officers", con)


        da.Fill(dt)
        DataGridViewOfficers.DataSource = dt.DefaultView

        con.Close()



    End Sub

    Private Sub btnViewEdit_Click(sender As Object, e As EventArgs) Handles btnViewEdit.Click

        ViewEditMenu.Show()
        Me.Close()

    End Sub


End Class
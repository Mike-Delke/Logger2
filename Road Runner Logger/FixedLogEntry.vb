
Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms.AxHost

Public Class FixedLogEntry
    Public Property StringPass As String
    Private _commonData As clsCommonData = clsCommonData.GetInstance("CommonData")


    'Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnExit.Click


    '    This pass's the call back to the main menu lblCall
    '    Dim obj As New MainMenu
    '    obj.StringPass = lblCall.Text
    '    obj.Show()
    '    Hide()

    'End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Clock timer.............................................................................................
        Dim currenttime As DateTime = DateTime.UtcNow
        lblTime.Text = DateTime.UtcNow.ToString("HH:mm:ss")

    End Sub

    Private Sub TimerClock_Tick(sender As Object, e As EventArgs) Handles TimerClock.Tick
        'Clock timer.............................................................................................
        Dim Now As DateTime = DateTime.Now.ToUniversalTime()
        txtTime.Text = Now.ToString("HH") & Now.ToString("mm")

    End Sub

    Dim con As New OleDbConnection
    Private Sub FixedLogEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'THIS IS THE DATE IN TOP CENTER RIGHT CORNER
        Dim currentDate As DateTime = DateTime.UtcNow
        txtDate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy")

        'Set's the users call
        lblCall.Text = StringPass

        'This sets the datagrid to alternating colors
        dataGridView.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue
        dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        'btnPost.Visible = False
        btnPost.Visible = True
        'gbxMobile.Visible = False
        txtTime.Visible = False
        ' lblFormat.Visible = False
        lblTime2.Visible = False
        LblDate2.Visible = False
        ' lblDFormat.Visible = False
        txtDate.Visible = False


        'SETS THE COMBO BOX TO FIRST VALUE IN LIST...................................................
        cmbMode.Text = (cmbMode.Items(0)).ToString
        cmbBand.Text = (cmbBand.Items(0)).ToString

        ' HomeCounty()

        WebBrowser1.Navigate("http://ch.w6rk.com/")

        GetState()
        GetHState()

    End Sub

    Private Sub datagridshow()

        ' This sets datagrid1 to the table and shows it for Logging Fixed Contacts
        ' Dim mcall = lblCall.Text
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "County Hunter - "
        Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\NetControl.accdb"
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString
        dataGridView.DataSource = dt.DefaultView
        con.Open()

        da = New OleDbDataAdapter("SELECT * FROM Log  ORDER BY ID DESC", con)

        da.Fill(dt)



        con.Close()

    End Sub

    Public Sub MobileLogShow()

        'This sub sets the datagrid to show the (Temp - QSO) table to show so the calls can be edited before posting to the Master QSO table

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "NetControl "
        Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\NetControl.accdb"                                                  '& strFilePrefix & strFileSuffix
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString

        con.Open()

        da = New OleDbDataAdapter("SELECT * FROM TempLog", con)

        da.Fill(dt)

        dataGridView.DataSource = dt.DefaultView

        con.Close()
    End Sub

    Private Sub cmbMyOperation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMyOperation.SelectedIndexChanged

        'Sets the screen to the type of logging doing with appropriate datagrid
        'Set starting text for contacts operation
        If cmbMyOperation.Text = "Home" And chkRunningClock.Checked = True Then
            cmbContactOperation.Text = "Mobile"
            datagridshow()
            ' btnPost.Visible = False
            btnPost.Visible = True
            ' Button1.Visible = False
            lblTime.Visible = True
            txtTime.Visible = False
            'lblFormat.Visible = False
            'lblTime2.Visible = False
            LblDate2.Visible = True
            ' lblDFormat.Visible = False
            txtDate.Visible = True
            btnSpot.Visible = True
            chkRunningClock.Visible = True
            txtTime.Visible = True
            lblTime2.Visible = True
        Else
            If cmbMyOperation.Text = "Home" And chkRunningClock.Checked = False Then
                cmbContactOperation.Text = "Mobile"
                datagridshow()
                btnPost.Visible = False
                ' btnPost.Visible = True
                'Button1.Visible = False
                lblTime.Visible = False
                txtTime.Visible = True
                'lblFormat.Visible = True
                lblTime2.Visible = True
                LblDate2.Visible = True
                ' lblDFormat.Visible = True
                txtDate.Visible = True
                btnSpot.Visible = False
                chkRunningClock.Visible = True
                txtTime.Visible = True
                lblTime2.Visible = True
            Else
                If cmbMyOperation.Text = "Mobile" Then
                    cmbContactOperation.Text = "Home"
                    MobileLogShow()
                    'Button1.Visible = False
                    ' btnLogIt.Visible = False
                    btnPost.Visible = True
                    lblTime.Visible = False
                    txtTime.Visible = True
                    'lblFormat.Visible = True
                    lblTime2.Visible = True
                    LblDate2.Visible = True
                    'lblDFormat.Visible = True
                    txtDate.Visible = True
                    btnSpot.Visible = False
                    chkRunningClock.Visible = True
                    txtTime.Visible = True
                    lblTime2.Visible = True
                Else
                    If cmbMyOperation.Text = "Portable" Then
                        cmbContactOperation.Text = "Mobile"
                        datagridshow()
                        btnPost.Visible = True
                        ' btnLogIt.Visible = True
                        ' Button1.Visible = False
                        lblTime.Visible = True
                        txtTime.Visible = False
                        'lblFormat.Visible = False
                        lblTime2.Visible = False
                        LblDate2.Visible = True
                        'lblDFormat.Visible = False
                        txtDate.Visible = False
                        btnSpot.Visible = True
                        txtTime.Visible = True
                        lblTime2.Visible = True
                        txtDate.Visible = True
                    End If
                End If
            End If
        End If


        ' Sets the Group Box for Mobile Logging to show when Mobile is choosen

        'If cmbMyOperation.Text = "M" Then
        '    gbxMobile.Visible = True
        'Else
        '    gbxMobile.Visible = False


        'End If

    End Sub

    Private Sub txtTime_Click(sender As Object, e As EventArgs) Handles txtTime.Click

        'Sets the screen to an entry box for the time for entering a mobile run
        txtTime.Focus()

    End Sub

    Public Sub GetState()        'This gets theState list to show in combobox MyState

        cmbMyState.Items.Clear()

        Dim stateList As DataTable = _commonData.GetStateList
        For Each row As DataRow In stateList.Rows
            Dim state As String = CStr(row("State ID"))
            ' Add state to DropDown
            cmbMyState.Items.Add(state)
        Next


        ''Dim mcall = lblCall.Text
        'Dim ds As New DataSet
        'Dim dt As New DataTable
        'ds.Tables.Add(dt)
        'Dim da As New OleDbDataAdapter

        ''------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        'Dim strFilePrefix = "County Hunters - Common"
        'Dim strFileSuffix = ".accdb"
        'Dim databaseFile As String = "C:\RRLogger Data\" & strFilePrefix & strFileSuffix
        'Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        ''--------------------------------------------------------------------------------------------------------------
        'con.ConnectionString = conString

        'con.Open()

        'da = New OleDbDataAdapter("SELECT [State ID] FROM States", con)

        'da.Fill(dt)

        'con.Close()


        ''CLEar combobox
        'cmbMyState.Items.Clear()

        ''FILL COMBOBOX
        'For Each R As DataRow In dt.Rows
        '    cmbMyState.Items.Add(R("State ID"))

        'Next

        ''DISPLAY FIRST RECORD

        ''cmbMState.Text = CType(dt.Rows(0).Item(0), String)


    End Sub

    Public Sub GetHState()

        cmbContactState.Items.Clear()

        Dim stateList As DataTable = _commonData.GetStateList
        For Each row As DataRow In stateList.Rows
            Dim state As String = CStr(row("State ID"))
            ' Add state to DropDown
            cmbContactState.Items.Add(state)
        Next


        'Gets the State's to show in comboBox his state

        '' Dim mcall = lblCall.Text
        'Dim ds As New DataSet
        'Dim dt As New DataTable
        'ds.Tables.Add(dt)
        'Dim da As New OleDbDataAdapter

        ''------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        'Dim strFilePrefix = "County Hunters - Common"
        'Dim strFileSuffix = ".accdb"
        'Dim databaseFile As String = "C:\RRLogger Data\" & strFilePrefix & strFileSuffix
        'Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        ''--------------------------------------------------------------------------------------------------------------
        'con.ConnectionString = conString

        'con.Open()

        'da = New OleDbDataAdapter("SELECT [State ID] FROM States", con)                    '

        'da.Fill(dt)

        'con.Close()


        ''CLEar combobox
        'cmbContactState.Items.Clear()

        ''FILL COMBOBOX
        'For Each R As DataRow In dt.Rows
        '    cmbContactState.Items.Add(R("State ID"))

        'Next

        ''DISPLAY FIRST RECORD
        'cmbContactState.Text = CType(dt.Rows(0).Item(0), String)


    End Sub

    Private Sub GetMCounty()       ' Gets the list of counties to put into combobox MyCounty

        'cmbMyCounty.Items.Clear()

        'Dim countyList As DataTable = _commonData.GetCountyList("county")
        'For Each row As DataRow In countyList.Rows
        '    Dim county As String = CStr(row("countyId"))
        '    Dim countyId As Integer = CInt(row("countyId"))
        '    ' Add county to DropDown
        '    cmbMyCounty.Items.Add(county)
        'Next

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "NetControl"
        Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\" & strFilePrefix & strFileSuffix
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString
        cmbMyCounty.Items.Clear()
        con.Open()

        da = New OleDbDataAdapter("SELECT County FROM County WHERE State = '" & cmbMyState.Text & "'", con)


        da.Fill(dt)

        con.Close()

        cmbMyCounty.Items.Clear()

        For Each R As DataRow In dt.Rows
            cmbMyCounty.Items.Add(R("County"))
        Next

        'DISPLAY FIRST RECORD

        'cmbMCounty.Text = CType(dt.Rows(0).Item(0), String)

    End Sub

    Private Sub GetHCounty()


        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "NetControl"
        Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\" & strFilePrefix & strFileSuffix
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString
        cmbContactCounty.Items.Clear()
        con.Open()

        da = New OleDbDataAdapter("SELECT County FROM County WHERE State = '" & cmbContactState.Text & "'", con)


        da.Fill(dt)

        con.Close()

        cmbContactCounty.Items.Clear()

        For Each R As DataRow In dt.Rows
            cmbContactCounty.Items.Add(R("County"))
        Next

        'DISPLAY FIRST RECORD

        cmbContactCounty.Text = CType(dt.Rows(0).Item(0), String)

    End Sub

    Private Sub GetMCLCounty()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "NetControl"
        Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\" & strFilePrefix & strFileSuffix
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString
        con.Open()

        da = New OleDbDataAdapter("SELECT clCounty FROM CountyLine WHERE clState = '" & cmbMyState.Text & "' And CountyLine = '" & cmbMyCounty.Text & "'", con)


        da.Fill(dt)

        con.Close()

        cmbMyCountyLine.Items.Clear()

        For Each R As DataRow In dt.Rows
            cmbMyCountyLine.Items.Add(R("clCounty"))
        Next


    End Sub

    Private Sub GetContactCountyLine()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "NetControl"
        Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\" & strFilePrefix & strFileSuffix
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString
        con.Open()

        da = New OleDbDataAdapter("SELECT clCounty FROM CountyLine WHERE clState =  '" & cmbContactState.Text & "' And CountyLine = '" & cmbContactCounty.Text & "'", con)


        da.Fill(dt)

        con.Close()

        cmbContactCountyLine.Items.Clear()

        For Each R As DataRow In dt.Rows
            cmbContactCountyLine.Items.Add(R("clCounty"))
        Next


    End Sub

    Private Sub PostTemp()

        Dim myConnection As OleDbConnection = New OleDbConnection

        Dim databaseFile As String = "C:\RRLogger Data\NetControl.accdb"
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile
        myConnection.ConnectionString = conString
        myConnection.Open()
        Dim str As String

        str = "Insert into TempLog ([LDate],[LTime],[HCall],[State],[County],[CountyLine],[Freq],[Band],[Mode],[MyCall],[HRST],[MRST],[Hoper],[Moper],[MState],[MCounty],[MCountyLine])
                 Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        cmd.Parameters.Add(New OleDbParameter("Date", CType(txtDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Time", CType(txtTime.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCall", CType(txtcontactCall.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HState", CType(cmbContactState.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCounty", CType(cmbContactCounty.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCLine", CType(cmbContactCountyLine.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Freq", CType(cmbFrequency.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Band", CType(cmbBand.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Mode", CType(cmbMode.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MyCall", lblCall.Text))
        cmd.Parameters.Add(New OleDbParameter("HRST", CType(txtHisrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MRST", CType(txtMyrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HOper", CType(cmbContactOperation.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Moper", CType(cmbMyOperation.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MState", CType(cmbMyState.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MCounty", CType(cmbMyCounty.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MCLine", CType(cmbMyCountyLine.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            txtTime.Clear()
            txtcontactCall.Clear()
            txtHisrst.Clear()
            txtMyrst.Clear()


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        MobileLogShow()

    End Sub

    Private Sub cmbMState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMyState.SelectedIndexChanged

        GetMCounty()



    End Sub

    Private Sub cmbHState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbContactState.SelectedIndexChanged

        GetHCounty()

    End Sub

    Private Sub cmbMCounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMyCounty.SelectedIndexChanged

        GetMCLCounty()

    End Sub

    Private Sub cmbHCounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbContactCounty.SelectedIndexChanged

        GetContactCountyLine()

    End Sub

    Private Sub dataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView.CellContentClick

        Dim form As New EditFrm
        form.txtID.Text = dataGridView.CurrentRow.Cells(0).Value.ToString()
        form.txtDate.Text = dataGridView.CurrentRow.Cells(1).Value.ToString()
        form.txtTime.Text = dataGridView.CurrentRow.Cells(2).Value.ToString()
        form.txtHcall.Text = dataGridView.CurrentRow.Cells(3).Value.ToString()
        form.txtHstate.Text = dataGridView.CurrentRow.Cells(4).Value.ToString()
        form.txtHcounty.Text = dataGridView.CurrentRow.Cells(5).Value.ToString()
        form.txtHcntyLine.Text = dataGridView.CurrentRow.Cells(6).Value.ToString()
        form.txtFreq.Text = dataGridView.CurrentRow.Cells(7).Value.ToString()
        form.txtMode.Text = dataGridView.CurrentRow.Cells(8).Value.ToString()
        form.txtMycall.Text = dataGridView.CurrentRow.Cells(9).Value.ToString()
        form.txtHrst.Text = dataGridView.CurrentRow.Cells(10).Value.ToString()
        form.txtMrst.Text = dataGridView.CurrentRow.Cells(11).Value.ToString()
        form.txtMstate.Text = dataGridView.CurrentRow.Cells(12).Value.ToString()
        form.txtMcounty.Text = dataGridView.CurrentRow.Cells(13).Value.ToString()
        form.txtMcntyLine.Text = dataGridView.CurrentRow.Cells(14).Value.ToString()

        form.ShowDialog()

        MobileLogShow()
    End Sub

    'Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    '    Dim a As String
    '    Dim b As String
    '    Dim split = txtcontactCall.Text.Split("/"c)
    '    If (split.Count = 2) Then
    '        a = split(0).ToString
    '        b = split(1).ToString

    '        txtcontactCall.Text = a
    '        PostTemp()

    '        txtcontactCall.Text = b
    '        PostTemp()

    '        txtcontactCall.Text = ""
    '        txtHisrst.Text = ""
    '        txtMyrst.Text = ""

    '    ElseIf (split.Count = 0) Then

    '        PostTemp()

    '    End If
    '    PostTemp()

    'End Sub

    'Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    '    Dim index As Integer
    '    index = dataGridView.CurrentCell.RowIndex
    '    dataGridView.Rows.RemoveAt(index)


    'End Sub

    Private Sub PostLog()

        Dim myConnection As OleDbConnection = New OleDbConnection

        Dim databaseFile As String = "C:\RRLogger Data\NetControl.accdb"
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile
        myConnection.ConnectionString = conString
        myConnection.Open()
        Dim str As String

        str = "Insert into Log ([LDate],[LTime],[HCall],[State],[County],[CountyLine],[Freq],[Band],[Mode],[MyCall],[HRST],[MRST],[Hoper],[Moper],[MState],[MCounty],[MCntyLine])
                 Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        cmd.Parameters.Add(New OleDbParameter("Date", CType(txtDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Time", CType(txtTime.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCall", CType(txtcontactCall.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HState", CType(cmbContactState.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCounty", CType(cmbContactCounty.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCLine", CType(cmbContactCountyLine.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Freq", cmbFrequency.Text))
        cmd.Parameters.Add(New OleDbParameter("Band", CType(cmbBand.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Mode", CType(cmbMode.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MyCall", lblCall.Text))
        cmd.Parameters.Add(New OleDbParameter("HRST", CType(txtHisrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MRST", CType(txtMyrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HOper", CType(cmbContactOperation.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Moper", CType(cmbMyOperation.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MState", CType(cmbMyState.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MCounty", CType(cmbMyCounty.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MCLine", CType(cmbMyCountyLine.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            txtTime.Clear()
            txtcontactCall.Clear()
            txtHisrst.Clear()
            txtMyrst.Clear()


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        datagridshow()
        myConnection.Close()
    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs)


        Dim a As String
        Dim b As String
        Dim split = txtcontactCall.Text.Split("/"c)
        If (split.Count = 2) Then
            a = split(0).ToString
            b = split(1).ToString

            txtcontactCall.Text = a
            PostLog()

            txtcontactCall.Text = b
            PostLog()

            txtcontactCall.Text = ""
            txtHisrst.Text = ""
            txtMyrst.Text = ""

        ElseIf (split.Count = 0) Then

            PostLog()

        End If


    End Sub

    Private Sub MobilePost()

        Dim myConnection As OleDbConnection = New OleDbConnection

        Dim databaseFile As String = "C:\RRLogger Data\NetControl.accdb"
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile
        myConnection.ConnectionString = conString
        myConnection.Open()
        Dim str As String

        str = "Insert INTO Log ([LDate],[LTime],[HCall],[State],[County],[CountyLine],[Freq],[Band],[Mode],[MYCall],[HRST],[MRST],[Hoper],[Moper],[MState],[MCounty],[MCntyLine])
                SELECT [LDate],[LTime],[HCall],[State],[County],[CountyLine],[Freq],[Band],[Mode],[MyCall],[HRST],[MRST],[Hoper],[Moper],[MState],[MCounty],[MCountyLine]
                FROM TempLog "


        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        myConnection.Close()

        ClearTempTbl()

        MobileLogShow()

    End Sub

    'Private Sub btnMobilePost_Click(sender As Object, e As EventArgs) Handles btnMobilePost.Click



    '    'THIS IS WHERE YOU EXECUTE THE MOBILE POST TO LOG SUB
    '    MobilePost()

    'End Sub

    Private Sub ClearTempTbl()

        Dim myConnection As OleDbConnection = New OleDbConnection

        Dim databaseFile As String = "C:\RRLogger Data\NetControl.accdb"
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile
        myConnection.ConnectionString = conString
        myConnection.Open()
        Dim str As String

        str = " DELETE * FROM Templog"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        myConnection.Close()

    End Sub

    Private Sub txtDate_Click(sender As Object, e As EventArgs) Handles txtDate.Click

        DateTimePicker1.Visible = True

    End Sub

    Private Sub txtTime_LostFocus(sender As Object, e As EventArgs) Handles txtTime.LostFocus

        Dim a As Double
        a = CDbl(txtTime.Text)
        txtTime.Text = a.ToString("##:##")

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        txtDate.Text = DateTimePicker1.Value.ToShortDateString()

        DateTimePicker1.Visible = False

    End Sub

    'Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    '    If cmbMOperation.Text = "F" And CheckBox1.Checked = True Then
    '        cmbHOperation.Text = "M"
    '        datagridshow()
    '        btnMobilePost.Visible = False
    '        lblTime.Visible = True
    '        txtTime.Visible = False
    '        lblFormat.Visible = False
    '        lblTime2.Visible = False
    '        LblDate2.Visible = False
    '        lblDFormat.Visible = False
    '        txtDate.Visible = False
    '        btnLogIt.Visible = False
    '        btnSpot.Visible = True
    '    Else
    '        If cmbMOperation.Text = "F" And CheckBox1.Checked = False Then
    '            cmbHOperation.Text = "M"
    '            datagridshow()
    '            btnMobilePost.Visible = False
    '            lblTime.Visible = False
    '            txtTime.Visible = True
    '            lblFormat.Visible = True
    '            lblTime2.Visible = True
    '            LblDate2.Visible = True
    '            lblDFormat.Visible = True
    '            txtDate.Visible = True
    '            btnLogIt.Visible = True
    '            btnSpot.Visible = False

    '        End If
    '    End If
    'End Sub

    'Private Sub PostRunLog()

    '    Dim myConnection As OleDbConnection = New OleDbConnection

    '    Dim databaseFile As String = "C:\RRLogger Data\NetControl.accdb"
    '    Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile
    '    myConnection.ConnectionString = conString
    '    myConnection.Open()
    '    Dim str As String

    '    str = "Insert into Log ([LDate],[LTime],[HCall],[State],[County],[CountyLine],[Freq],[Band],[Mode],[MyCall],[HRST],[MRST],[Hoper],[Moper],[MState],[MCounty],[MCntyLine])
    '             Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"

    '    Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

    '    cmd.Parameters.Add(New OleDbParameter("Date", CType(lblDate.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("Time", CType(lblTime.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("HCall", CType(txtCall.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("HState", CType(cmbHState.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("HCounty", CType(cmbxHCounty.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("HCLine", CType(cmbxCLine.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("Freq", CType(cmbxFrequency.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("Band", CType(cmbxBand.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("Mode", CType(cmbxMode.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("MyCall", CType(lblCall.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("HRST", CType(txtHrst.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("MRST", CType(txtMrst.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("HOper", CType(cmbHOperation.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("Moper", CType(cmbMOperation.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("MState", CType(cmbMState.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("MCounty", CType(cmbMCounty.Text, String)))
    '    cmd.Parameters.Add(New OleDbParameter("MCLine", CType(cmbxMCLine.Text, String)))

    '    Try
    '        cmd.ExecuteNonQuery()
    '        cmd.Dispose()
    '        myConnection.Close()
    '        txtTime.Clear()
    '        'txtCall.Clear()


    '    Catch ex As Exception

    '        MsgBox(ex.Message)

    '    End Try

    '    datagridshow()



    'End Sub

    'Private Sub btnLogit_Click(sender As Object, e As EventArgs) Handles btnLogIt.Click


    '    Dim a As String
    '    Dim b As String
    '    Dim split = txtCall.Text.Split("/"c)
    '    If (split.Count = 2) Then
    '        a = split(0).ToString
    '        b = split(1).ToString

    '        txtCall.Text = a
    '        PostLog()

    '        txtCall.Text = b
    '        PostLog()

    '        ' txtCall.Text = ""
    '        ' txtHrst.Text = ""
    '        ' txtMrst.Text = ""

    '    ElseIf (split.Count = 0) Then

    '        PostLog()

    '    End If
    '    'PostLog()
    'End Sub

    Private Sub txtTime_GotFocus(sender As Object, e As EventArgs) Handles txtTime.GotFocus

        DateTimePicker1.Visible = True

    End Sub

    'Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles txtDate.Click

    'End Sub

    'Private Sub btnEdit_Click(sender As Object, e As EventArgs)

    '    'EditFrm.Show()
    '    'Hide()

    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    '    Dim a As String
    '    Dim b As String
    '    Dim split = txtCall.Text.Split("/"c)
    '    If (split.Count = 2) Then
    '        a = split(0).ToString
    '        b = split(1).ToString

    '        txtCall.Text = a
    '        PostRunLog()

    '        txtCall.Text = b
    '        PostRunLog()

    '        ' txtCall.Text = ""
    '        ' txtHrst.Text = ""
    '        ' txtMrst.Text = ""

    '    ElseIf (split.Count = 0) Then

    '        PostRunLog()

    '    End If
    '    ' PostLog()

    'End Sub

    Public Sub HomeCounty()

        'Dim mcall = lblCall.Text
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "County Hunters - Common"
        Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\" & strFilePrefix & strFileSuffix
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString

        con.Open()

        da = New OleDbDataAdapter("SELECT [Home County] FROM [County Hunters] Where Current Call = lblCall.text", con)
        'ds.ToString()
        cmbMyCounty.Text = ds.ToString()

        con.Close()


    End Sub

    Private Sub btnSpot_Click(sender As Object, e As EventArgs) Handles btnSpot.Click

        '''NEXT STATEMENT IS THE POSTING
        'Dim commentStr As String
        'If cmbxMCLine.Text = "" Then
        '    commentStr = cmbxHCounty.Text & "+" & cmbHState.Text
        'Else
        '    commentStr = cmbxHCounty.Text & "+" & cmbHState.Text & "+" & cmbxCLine.Text & "," & cmbHCLineState.Text
        'End If

        ''WebBrowser1.Document.GetElementById("Add Call").InvokeMember("click")
        'Dim request As WebRequest = WebRequest.Create("http://ch.w6rk.com/add.php?add=1")
        '' Set the Method property of the request to POST.  
        'request.Method = "POST"
        '' Create POST data and convert it to a byte array.  
        'Dim postData As String = "redirect=&user=&code=&call=" & lblCall.Text & "&fq=" &
        '    cmbxFrequency.Text & "&DXcall=" & txtCall.Text & "&comments=" & commentStr & "&submit=Add+spot"

        'Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        '' Set the ContentType property of the WebRequest.  
        'request.ContentType = "application/x-www-form-urlencoded"
        '' Set the ContentLength property of the WebRequest.  
        'request.ContentLength = byteArray.Length
        '' Get the request stream.  
        'Dim dataStream As Stream = request.GetRequestStream()
        '' Write the data to the request stream.  
        'dataStream.Write(byteArray, 0, byteArray.Length)
        '' Close the Stream object.  
        'dataStream.Close()
        '' Get the response.  
        'Dim response As WebResponse = request.GetResponse()
        '' Display the status.  
        'Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        '' Get the stream containing content returned by the server.  
        'dataStream = response.GetResponseStream()
        '' Open the stream using a StreamReader for easy access.  
        'Dim reader As New StreamReader(dataStream)
        '' Read the content.  
        'Dim responseFromServer As String = reader.ReadToEnd()
        '' Display the content.  
        'Console.WriteLine(responseFromServer)
        '' Clean up the streams.  
        'reader.Close()
        'dataStream.Close()
        'response.Close()
        ' Spotit()
    End Sub
    ' Public Sub Spotit()

    '    ''NEXT STATEMENT IS THE POSTING
    '    Dim commentStr As String
    '    If cmbMyCountyLine.Text = "" Then
    '        commentStr = cmbContactCounty.Text & "," & cmbContactState.Text & "+" & TextBox1.Text
    '    Else
    '        commentStr = cmbContactCounty.Text & "," & cmbContactState.Text & "/" & cmbContactCountyLine.Text & "," & cmbLineState.Text & "+" & TextBox1.Text
    '    End If

    '    'WebBrowser1.Document.GetElementById("Add Call").InvokeMember("click")
    '    Dim request As WebRequest = WebRequest.Create("http://ch.w6rk.com/add.php?add=1")
    '    ' Set the Method property of the request to POST.  
    '    request.Method = "POST"
    '    ' Create POST data and convert it to a byte array.  
    '    Dim postData As String = "redirect=&user=&code=&call=" & lblCall.Text & "&fq=" &
    '        cmbFrequency.Text & "&DXcall=" & txtCall.Text & "&comments=" & commentStr & "&submit=Add+spot"

    '    Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
    '    ' Set the ContentType property of the WebRequest.  
    '    request.ContentType = "application/x-www-form-urlencoded"
    '    ' Set the ContentLength property of the WebRequest.  
    '    request.ContentLength = byteArray.Length
    '    ' Get the request stream.  
    '    Dim dataStream As Stream = request.GetRequestStream()
    '    ' Write the data to the request stream.  
    '    dataStream.Write(byteArray, 0, byteArray.Length)
    '    ' Close the Stream object.  
    '    dataStream.Close()
    '    ' Get the response.  
    '    Dim response As WebResponse = request.GetResponse()
    '    ' Display the status.  
    '    Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
    '    ' Get the stream containing content returned by the server.  
    '    dataStream = response.GetResponseStream()
    '    ' Open the stream using a StreamReader for easy access.  
    '    Dim reader As New StreamReader(dataStream)
    '    ' Read the content.  
    '    Dim responseFromServer As String = reader.ReadToEnd()
    '    ' Display the content.  
    '    Console.WriteLine(responseFromServer)
    '    ' Clean up the streams.  
    '    reader.Close()
    '    dataStream.Close()
    '    response.Close()
    'End Sub

    'Private Sub btnLogIt_Click(sender As Object, e As EventArgs) Handles btnPost.Click

    '    Dim a As String
    '    Dim b As String
    '    Dim split = txtcontactCall.Text.Split("/"c)
    '    If (split.Count = 2) Then
    '        a = split(0).ToString
    '        b = split(1).ToString

    '        txtcontactCall.Text = a
    '        PostRunLog()

    '        txtcontactCall.Text = b
    '        PostRunLog()

    '        ' txtCall.Text = ""
    '        ' txtHrst.Text = ""
    '        ' txtMrst.Text = ""

    '    ElseIf (split.Count = 0) Then

    '        PostRunLog()

    '    End If
    'End Sub

    Private Sub dataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView.CellContentClick

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click


        ' This pass's the call back to the main menu lblCall
        ' Dim obj As New MainMenu
        ' obj.StringPass = lblCall.Text
        ' obj.Show()

        'MainMenu.Show()
        Me.Close()

    End Sub

    Private Sub btnPost_Click_1(sender As Object, e As EventArgs) Handles btnPost.Click

        PostLog()

    End Sub

    Private Sub GroupBoxMyParameters_Enter(sender As Object, e As EventArgs) Handles GroupBoxMyParameters.Enter

    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        ButtonClear.Visible = True
        ButtonEditNext.Visible = True
        ButtonEditPrevious.Visible = True
        ButtonSaveEdit.Visible = True
    End Sub
End Class
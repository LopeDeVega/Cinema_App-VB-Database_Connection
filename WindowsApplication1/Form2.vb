
Public Class Form2

    Dim Query As String




    Private Sub btnSelectQuery_Click(sender As Object, e As EventArgs) Handles btnSelectQuery.Click

        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String
        Dim Count As Integer

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"

        dbSource = "Data Source=|DATADIRECTORY|films2000.mdb"
        'dbSource = "Data Source= C:\Users\antonio.m1\Desktop\films2000.mdb"

        con.ConnectionString = dbProvider & dbSource

        con.Open()

        sql = "SELECT * FROM tblFilms"
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "Table") 'Fill the dataset, ds, with the SELECT
        Count = ds.Tables("Table").Rows.Count
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()



    End Sub






    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click


        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String
        Dim Count As Integer

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"

        dbSource = "Data Source=|DATADIRECTORY|films2000.mdb"


        con.ConnectionString = dbProvider & dbSource

        'Try and catch used to dont break the program in case, the query is not well built
        Try
            con.Open()

            sql = txtSQL.Text  'take text from text box
            da = New OleDb.OleDbDataAdapter(sql, con)

            da.Fill(ds, "Table") 'Fill the dataset, ds, with the statement
            Count = ds.Tables("Table").Rows.Count
            DataGridView1.DataSource = ds.Tables(0)


        Catch ex As Exception
            MsgBox("SQL no valid")

        End Try

        con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnBuiltQuery_Click(sender As Object, e As EventArgs) Handles btnBuiltQuery.Click

        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim Count As Integer


        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"

        dbSource = "Data Source=|DATADIRECTORY|films2000.mdb"


        con.ConnectionString = dbProvider & dbSource

        con.Open()

        txtSQL.Text = ""

        'When the query is not build correctly pop the message.

        If cboField.Text = "" Or cboOperator.Text = "" Then
            MsgBox("You must select a field or operator to search from")
            Exit Sub
        End If

        'Set up start of query string
        Query = "Select * from tblFilms Where "


        If cboField.Text = "FilmYear" Then
            Query = Query & cboField.Text & " " & cboOperator.Text
            'Not quotes for this line because FilmYear is number.
            Query = Query & txtValue.Text

        ElseIf cboField.Text = "Length" Then
            Query = Query & cboField.Text & " " & cboOperator.Text
            Query = Query & "'" & txtValue.Text & "'"

        ElseIf cboField.Text = "Title" Then
            Query = Query & cboField.Text & " " & cboOperator.Text
            Query = Query & "'" & txtValue.Text & "'"

        ElseIf cboField.Text = "Subject" Then
            Query = Query & cboField.Text & " " & cboOperator.Text
            Query = Query & "'" & txtValue.Text & "'"

        ElseIf cboField.Text = "ActorSurname" Then
            Query = Query & cboField.Text & " " & cboOperator.Text
            Query = Query & "'" & txtValue.Text & "'"

        ElseIf cboField.Text = "ActorForename" Then
            Query = Query & cboField.Text & " " & cboOperator.Text
            Query = Query & "'" & txtValue.Text & "'"

        ElseIf cboField.Text = "ActressSurname" Then
            Query = Query & cboField.Text & " " & cboOperator.Text
            Query = Query & "'" & txtValue.Text & "'"

        ElseIf cboField.Text = "ActressForename" Then
            Query = Query & cboField.Text & " " & cboOperator.Text
            Query = Query & "'" & txtValue.Text & "'"

        ElseIf cboField.Text = "DirectorSurname" Then
            Query = Query & cboField.Text & " " & cboOperator.Text
            Query = Query & "'" & txtValue.Text & "'"

        ElseIf cboField.Text = "DirectorForename" Then
            Query = Query & cboField.Text & " " & cboOperator.Text
            Query = Query & "'" & txtValue.Text & "'"

        ElseIf cboField.Text = "Popularity" Then
            Query = Query & cboField.Text & " " & cboOperator.Text
            Query = Query & "'" & txtValue.Text & "'"

        ElseIf cboField.Text = "Awards" Then
            Query = Query & cboField.Text & " " & cboOperator.Text
            Query = Query & "'" & txtValue.Text & "'"


        Else
            'currency or numerical value
            Query = Query & cboField.Text & " " & cboOperator.Text
            Query = Query & " " & Val(txtValue.Text)
        End If

        MsgBox(Query)

        da = New OleDb.OleDbDataAdapter(Query, con)
        da.Fill(ds, "Table") 'Fill the dataset, ds, with the statement
        Count = ds.Tables("Table").Rows.Count
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This is set here to run that when the form is open. 
        cboOperator.Items.Add("=")
        cboOperator.Items.Add("<>")
        cboOperator.Items.Add("<")
        cboOperator.Items.Add(">")
        cboOperator.Items.Add("<=")
        cboOperator.Items.Add(">=")

        cboField.Items.Add("FilmYear")
        cboField.Items.Add("Length")
        cboField.Items.Add("Title")
        cboField.Items.Add("Subject")
        cboField.Items.Add("ActorSurname")
        cboField.Items.Add("ActorForename")
        cboField.Items.Add("ActressSurname")
        cboField.Items.Add("ActressForename")
        cboField.Items.Add("DirectorSurname")
        cboField.Items.Add("DirectorForename")
        cboField.Items.Add("Popularity")
        cboField.Items.Add("Awards")

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click

        Me.Hide()
        Form3.Show()

    End Sub


    Private Sub btnFilms_Click(sender As Object, e As EventArgs) Handles btnFilms.Click

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        'CLose the application.
        End

    End Sub
End Class

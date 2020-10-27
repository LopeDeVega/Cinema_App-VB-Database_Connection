Public Class Form1

    'Global varialbes. 

    'used to store rows in the dataSet 
    Dim inc As Integer
    Dim MaxRows As Integer

    'Variable con will hold the connection Object. 
    'Aslo  creating a new object which is used to connect to an Access dababase
    Dim con As New OleDb.OleDbConnection

    'Provider  and Data Source used to specify where is the database. 
    Dim dbProvider As String
    Dim dbSource As String

    Dim Sql As String

    'Create a dataset.
    Dim ds As New DataSet

    'it hold a reference to the data adapter. 
    Dim da As OleDb.OleDbDataAdapter
   


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Create a new data adapter object
        da = New OleDb.OleDbDataAdapter(Sql, con)

        'Technology to connect VB with a data base
        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"

        'Where is the code.
        dbSource = "Data Source=|DATADIRECTORY|films2000.mdb"

        con.ConnectionString = dbProvider & dbSource

        'It open the database
        con.Open()

        da = New OleDb.OleDbDataAdapter(Sql, con)

        Sql = "SELECT * FROM tblFilms"
        da = New OleDb.OleDbDataAdapter(Sql, con)

        'Used ti fill with the records selected from the table. 
        da.Fill(ds, "films2000")

        con.Close()


        MaxRows = ds.Tables("films2000").Rows.Count
        inc = -1


    End Sub


    Private Sub NavigateRecords()

        'Using try and Catch the program won't break when there is a null field. 
        Try
            txtID.Text = ds.Tables("films2000").Rows(inc).Item("ID")

        Catch ex As Exception
            txtID.Text = ""
            txtID.Clear()
        End Try


        Try
            txtFilmYear.Text = ds.Tables("films2000").Rows(inc).Item("FilmYear")

        Catch ex As Exception
            txtFilmYear.Text = ""
            txtFilmYear.Clear()
        End Try

        Try

            txtLength.Text = ds.Tables("films2000").Rows(inc).Item("Length")

        Catch ex As Exception

            txtLength.Text = ""
            txtLength.Clear()

        End Try

        Try
            txtTitle.Text = ds.Tables("films2000").Rows(inc).Item("Title")

        Catch ex As Exception
            txtTitle.Text = ""
            txtTitle.Clear()
        End Try


        Try
            txtSubject.Text = ds.Tables("films2000").Rows(inc).Item("Subject")

        Catch ex As Exception
            txtSubject.Text = ""
            txtSubject.Clear()

        End Try

        Try
            txtActorSurname.Text = ds.Tables("films2000").Rows(inc).Item("ActorSurname")

        Catch ex As Exception
            txtActorSurname.Text = ""
            txtActorSurname.Clear()

        End Try

        Try
            txtActorForename.Text = ds.Tables("films2000").Rows(inc).Item("ActorForename")

        Catch ex As Exception
            txtActorForename.Text = ""
            txtActorForename.Clear()

        End Try


        Try
            txtActressSurname.Text = ds.Tables("films2000").Rows(inc).Item("ActressSurname")

        Catch ex As Exception
            txtActressSurname.Text = ""
            txtActressSurname.Clear()

        End Try

        Try
            txtActressForename.Text = ds.Tables("films2000").Rows(inc).Item("ActressForename")

        Catch ex As Exception
            txtActressForename.Text = ""
            txtActressForename.Clear()

        End Try

        Try
            txtDirectorSurname.Text = ds.Tables("films2000").Rows(inc).Item("DirectorSurname")

        Catch ex As Exception

            txtDirectorSurname.Text = ""
            txtDirectorSurname.Clear()

        End Try


        Try

            txtDirectorForename.Text = ds.Tables("films2000").Rows(inc).Item("DirectorForename")

        Catch ex As Exception
            txtDirectorForename.Text = ""
            txtDirectorForename.Clear()

        End Try

        Try

            txtPopularity.Text = ds.Tables("films2000").Rows(inc).Item("Popularity")

        Catch ex As Exception
            txtPopularity.Text = ""
            txtPopularity.Clear()

        End Try


        Try

            txtAwards.Text = ds.Tables("films2000").Rows(inc).Item("Awards")

        Catch ex As Exception
            txtAwards.Text = ""
            txtAwards.Clear()

        End Try





    End Sub








    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim cb As New OleDb.OleDbCommandBuilder(da)
        'Declaring i variable 
        Dim i As String = ""

        'if Used to dont break the program when the table is updating.

        If txtID.Text Like i Then


        Else
            ds.Tables("films2000").Rows(inc).Item("ID") = txtID.Text
            ds.Tables("films2000").Rows(inc).Item("FilmYear") = txtFilmYear.Text
            ds.Tables("films2000").Rows(inc).Item("Length") = txtLength.Text
            ds.Tables("films2000").Rows(inc).Item("Title") = txtTitle.Text
            ds.Tables("films2000").Rows(inc).Item("Subject") = txtSubject.Text
            ds.Tables("films2000").Rows(inc).Item("ActorSurname") = txtActorSurname.Text
            ds.Tables("films2000").Rows(inc).Item("ActorForename") = txtActorForename.Text
            ds.Tables("films2000").Rows(inc).Item("ActressSurname") = txtActressSurname.Text
            ds.Tables("films2000").Rows(inc).Item("ActressForename") = txtActressForename.Text
            ds.Tables("films2000").Rows(inc).Item("DirectorSurname") = txtDirectorSurname.Text
            ds.Tables("films2000").Rows(inc).Item("DirectorForename") = txtDirectorForename.Text
            ds.Tables("films2000").Rows(inc).Item("Popularity") = txtPopularity.Text
            ds.Tables("films2000").Rows(inc).Item("Awards") = txtAwards.Text

            da.Update(ds, "films2000")

            MsgBox("Data updated")
        End If

    End Sub


    Private Sub btnPreviousRecord_Click(sender As Object, e As EventArgs) Handles btnPreviousRecord.Click

        'Used to navigate through the records and set a message box if there is not previous record entered.
        If inc > 0 Then
            inc = inc - 1
            NavigateRecords()
        ElseIf inc = -1 Then
            MsgBox("No Records Yet")
        ElseIf inc = 0 Then
            MsgBox("First Record")
        End If



    End Sub


    Private Sub btnFirstRecord_Click(sender As Object, e As EventArgs) Handles btnFirstRecord.Click

        '
        If inc <> 0 Then
            inc = 0
            NavigateRecords()
        End If


    End Sub


    Private Sub btnNextRecord_Click(sender As Object, e As EventArgs) Handles btnNextRecord.Click


        If inc <> MaxRows - 1 Then
            inc = inc + 1
            NavigateRecords()
        Else
            MsgBox("No More Rows")
        End If


    End Sub

    Private Sub btnLastRecord_Click(sender As Object, e As EventArgs) Handles btnLastRecord.Click


        If inc <> MaxRows - 1 Then
            inc = MaxRows - 1
            NavigateRecords()

        End If

    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click

        'Anble or Unable buttons

        btnCommit.Enabled = True
        btnAddNew.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        'Clean the fields from data to add the new record
        txtID.Clear()
        txtFilmYear.Clear()
        txtLength.Clear()
        txtTitle.Clear()
        txtSubject.Clear()
        txtActorSurname.Clear()
        txtActorForename.Clear()
        txtActressSurname.Clear()
        txtActressForename.Clear()
        txtDirectorSurname.Clear()
        txtDirectorForename.Clear()
        txtPopularity.Clear()
        txtAwards.Clear()

    End Sub




   

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click



        'The first line if tell me if there is a valid record to add.
        If inc <> -1 Then
            Dim cb As New OleDb.OleDbCommandBuilder(da)

            'to create a new row in database to add the new data
            Dim dsNewRow As DataRow


            dsNewRow = ds.Tables("films2000").NewRow()

            'txtTitle is the unique field is required when you enter a new data in the database.
            'This if is used for that purpose. 
            Dim i As String = ""

            If txtFilmYear.Text Like i Then

                MsgBox("Film Title is required ")
                txtFilmYear.Clear()

            Else

                dsNewRow.Item("FilmYear") = txtFilmYear.Text
                dsNewRow.Item("Length") = txtLength.Text
                dsNewRow.Item("Title") = txtTitle.Text
                dsNewRow.Item("Subject") = txtSubject.Text
                dsNewRow.Item("ActorSurname") = txtActorSurname.Text
                dsNewRow.Item("ActorForename") = txtActorForename.Text
                dsNewRow.Item("ActressSurname") = txtActressSurname.Text
                dsNewRow.Item("ActressForename") = txtActressForename.Text
                dsNewRow.Item("DirectorSurname") = txtDirectorSurname.Text
                dsNewRow.Item("DirectorForename") = txtDirectorForename.Text
                dsNewRow.Item("Popularity") = txtPopularity.Text
                dsNewRow.Item("Awards") = txtAwards.Text

                ds.Tables("films2000").Rows.Add(dsNewRow)
                da.Update(ds, "films2000")
                MsgBox("New Record added to the Database")

            End If


            btnCommit.Enabled = False
            btnAddNew.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True


        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim i As String = ""

        ' When there is not any data entered to delete a msgbox will be displayed 
        If txtID.Text Like i Then
            MsgBox("Not record to delete entered yet")

            'Display a question do you want to delete it? Answer No - Cancel operation

        ElseIf MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Operation Cancelled")
            Exit Sub

            'Answer yes delete it. 
        Else
            Dim cb As New OleDb.OleDbCommandBuilder(da)

            ds.Tables("films2000").Rows(inc).Delete()
            MaxRows = MaxRows - 1
            inc = 0
            da.Update(ds, "films2000")
            NavigateRecords()


        End If





    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click

        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub txtFilmYear_TextChanged(sender As Object, e As EventArgs) Handles txtFilmYear.TextChanged

        'Avoid letter from FilmYear
        Dim i As String = "[a-z]"

        If txtFilmYear.Text Like i Then

            MsgBox("No Number Allowed, Only Letters")
            txtFilmYear.Clear()

        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        
        btnCommit.Enabled = False
        btnAddNew.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        inc = 0
        NavigateRecords()



    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        'Close the program
        Me.Close()


    End Sub

 
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click

        'Hide that form and open the specific form
        Me.Hide()
        Form3.Show()


    End Sub
End Class

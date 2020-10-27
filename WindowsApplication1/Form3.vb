Public Class Form3



    Private Sub btnQuery_Click(sender As Object, e As EventArgs)

        'Display the text box when click on it.
        txtMoveForm.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        txtClose.Show()


    End Sub


    Private Sub btnQueries_Click(sender As Object, e As EventArgs) Handles btnQueries.Click


        'Hide the form and open the specific form.
        Me.Hide()
        Form2.Show()

        'Hide the text box the user close the form.
        txtMoveForm.Hide()
        txtClose.Hide()
        txtAdd.Hide()
        txtBackward.Hide()
        txtCancel.Hide()
        txtCommit.Hide()
        txtDelete.Hide()
        txtForward.Hide()
        txtUpdate.Hide()
        txtHelp.Hide()

        txtBuildQuery.Hide()
        txtCloseApp.Hide()
        txtField.Hide()
        txtFilmsScreen.Hide()
        txtHelp2.Hide()
        txtPickField.Hide()
        txtPickOperator.Hide()
        txtSelectQuery.Hide()
        txtRunQuery.Hide()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        End


    End Sub

    Private Sub btnQuery_Click_1(sender As Object, e As EventArgs) Handles btnQuery.Click

        txtMoveForm.Show()



    End Sub

    Private Sub btnAddNew_Click_1(sender As Object, e As EventArgs) Handles btnAddNew.Click

        txtAdd.Show()

    End Sub

    Private Sub btnCommit_Click_1(sender As Object, e As EventArgs) Handles btnCommit.Click

        txtCommit.Show()

    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click

        txtUpdate.Show()

    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click

        txtDelete.Show()


    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click

        txtCancel.Show()

    End Sub

    Private Sub btnPreviousRecord_Click_1(sender As Object, e As EventArgs) Handles btnPreviousRecord.Click

        txtBackward.Show()

    End Sub

    Private Sub btnFirstRecord_Click_1(sender As Object, e As EventArgs) Handles btnFirstRecord.Click

        txtBackward.Show()

    End Sub

    Private Sub btnLastRecord_Click_1(sender As Object, e As EventArgs) Handles btnLastRecord.Click


        txtForward.Show()

    End Sub

    Private Sub btnNextRecord_Click_1(sender As Object, e As EventArgs) Handles btnNextRecord.Click

        txtForward.Show()

    End Sub

    Private Sub txtFilm_Click(sender As Object, e As EventArgs) Handles btnFilm.Click

        'Hide the form and open the specific form.
        Me.Hide()
        Form1.Show()

        'Hide the text box the user close the form.
        txtMoveForm.Hide()
        txtClose.Hide()
        txtAdd.Hide()
        txtBackward.Hide()
        txtCancel.Hide()
        txtCommit.Hide()
        txtDelete.Hide()
        txtForward.Hide()
        txtUpdate.Hide()
        txtHelp.Hide()

        txtBuildQuery.Hide()
        txtCloseApp.Hide()
        txtField.Hide()
        txtFilmsScreen.Hide()
        txtHelp2.Hide()
        txtPickField.Hide()
        txtPickOperator.Hide()
        txtSelectQuery.Hide()
        txtRunQuery.Hide()





    End Sub

    
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        txtHelp.Show()


    End Sub


    Private Sub btnSelectQuery_Click(sender As Object, e As EventArgs) Handles btnSelectQuery.Click

        txtSelectQuery.Show()

    End Sub

    Private Sub btnBuiltQuery_Click(sender As Object, e As EventArgs) Handles btnBuiltQuery.Click

        txtBuildQuery.Show()


    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click

        txtRunQuery.Show()


    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click

        txtHelp2.Show()


    End Sub

    Private Sub btnFilms_Click(sender As Object, e As EventArgs) Handles btnFilms.Click

        txtFilmsScreen.Show()


    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        txtCloseApp.Show()

    End Sub

    Private Sub cboField_Click(sender As Object, e As EventArgs) Handles cboField.Click

        txtPickField.Show()


    End Sub


    Private Sub txtValue_Click(sender As Object, e As EventArgs) Handles txtValue.Click

        txtField.Show()

    End Sub

   
    Private Sub cboOperator_Click(sender As Object, e As EventArgs) Handles cboOperator.Click

        txtPickOperator.Show()


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
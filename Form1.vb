Public Class Form1
    Private Sub btnShownumber_Click(sender As Object, e As EventArgs) Handles btnShownumber.Click

        Dim Number As String

        Number = txtEnterNumber.Text

        If (IsNumeric(txtEnterNumber.Text)) Then
            MsgBox("Number")
        Else
            MsgBox("Enter Number")
        End If

    End Sub
End Class

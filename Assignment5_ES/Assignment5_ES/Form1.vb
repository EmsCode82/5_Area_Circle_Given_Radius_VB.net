Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'Declare Variables
        Dim decRadiusIn As Decimal
        Dim decAreaCircle As Decimal
        Dim decPi As Decimal
        decPi = 3.14

        'Get Inputs
        decRadiusIn = txtRadiusIn.Text

        'Do Calculations
        decAreaCircle = decPi * (decRadiusIn * decRadiusIn)

        'Display Outputs
        lblAreaCircle.Text = "The area of a circle with a radius of " & decRadiusIn & " inches is " & decAreaCircle & " square inches"

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear Input and Output
        txtRadiusIn.Clear()
        lblAreaCircle.ResetText()
        txtRadiusIn.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close Program
        Close()

    End Sub
End Class

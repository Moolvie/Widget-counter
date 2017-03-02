Public Class WidgetCounter


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' set the weight of one widget as a constant
        Const WIDGET_WEIGHT As Double = 9.2

        ' Declare variables
        Dim EmptyPalletWeight As Double = 0
        Dim LoadedPalletWeight As Double = 0
        Dim NumberOfWidgets As Integer = 0

        ' Load the variable with text from the form
        Try
            EmptyPalletWeight = Convert.ToDouble(txtEmptyPalletWt.Text)
            LoadedPalletWeight = Convert.ToDouble(txtLoadedPalletWt.Text)


            ' calculate the number of widgets

            NumberOfWidgets = Convert.ToInt32((LoadedPalletWeight - EmptyPalletWeight) / WIDGET_WEIGHT)

            ' display the result
            lblNumberOfWidgets.Text = Convert.ToString(NumberOfWidgets)
        Catch
            lblStatus.BackColor = Color.Red
            lblStatus.Text = "You must enter numeric values"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the form
        txtEmptyPalletWt.Clear()
        txtLoadedPalletWt.Clear()

        lblNumberOfWidgets.Text = String.Empty
        lblStatus.Text = String.Empty
        txtEmptyPalletWt.Focus()

    End Sub
End Class

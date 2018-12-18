'Sam Nokes
'Tip Calculator
'12/17/2018


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'declaring variables
        Dim billAmount As Decimal
        Dim tipAmount As Decimal
        Dim tipTotal As Decimal
        Dim totalWithTip As Decimal

        'converting user input to string
        Double.TryParse(billAmountTextBox.Text, billAmount)
        Double.TryParse(tipTextBox.Text, tipAmount)

        'calculating tip and total bill amounts
        tipTotal = Format(((tipAmount / 100) * billAmount), "0.00")
        totalWithTip = Format((billAmount + tipTotal), "0.00")

        'displaying tip and total bill amounts
        tipAmountLabel.Text = tipTotal
        totalAmountLabel.Text = totalWithTip
    End Sub
End Class

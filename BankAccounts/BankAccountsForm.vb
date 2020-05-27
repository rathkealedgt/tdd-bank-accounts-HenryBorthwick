Public Class BankAccountsForm

    'Class Varible Declarations
    Private Accounts(4) As BankAccount
    Private NumAccounts As Integer

    'Class Methods/Getters/Setters
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.NumAccounts = 0
    End Sub


    'Helper Methods
    Public Function SetTestForTesting(AccountHolder As String, AccountNumber As String, AccountBalence As String, AccountIntrestRate As String, AccountCountryOfOrigin As String)

        'Arrange
        txtAccountHolder.Text = AccountHolder
        txtAccountNumber.Text = AccountNumber
        txtAccountBalence.Text = AccountBalence
        txtAccountInterestRate.Text = AccountIntrestRate
        txtAccountCountryOfOrigin.Text = AccountCountryOfOrigin


    End Function

    Private Sub btnApplyInterest_Click(sender As Object, e As EventArgs) Handles btnApplyInterest.Click
        SetTestForTesting("One", "Two", "Three", "Four", "Five")

    End Sub

    Public Function GetAccounts() As BankAccount()

        Return Me.Accounts

    End Function
End Class
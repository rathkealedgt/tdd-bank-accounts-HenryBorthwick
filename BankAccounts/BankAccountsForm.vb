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
    Public Function SetSringForTesting(AccountHolder As String, AccountNumber As String, AccountBalence As String, AccountIntrestRate As String, AccountCountryOfOrigin As String)

        'Arrange
        txtAccountHolder.Text = AccountHolder
        txtAccountNumber.Text = AccountNumber
        txtAccountBalence.Text = AccountBalence
        txtAccountInterestRate.Text = AccountIntrestRate
        txtAccountCountryOfOrigin.Text = AccountCountryOfOrigin

        Return Nothing
    End Function

    Private Sub btnApplyInterest_Click(sender As Object, e As EventArgs) Handles btnApplyInterest.Click
        SetSringForTesting("One", "Two", "Three", "Four", "Five")

    End Sub

    Public Function GetAccounts() As BankAccount()

        Return Me.Accounts

    End Function

    Public Function CreateAccount()


        'Gaurd Clause
        If txtAccountHolder.Text = "" Then Throw New Exception("AccountHolderRequiredException")
        If txtAccountNumber.Text = "" Then Throw New Exception("AccountNumberRequiredException")
        If txtAccountBalence.Text = "" Then Throw New Exception("AccountBalenceRequiredException")
        If txtAccountInterestRate.Text = "" Then Throw New Exception("AccountIntrestRateRequiredException")
        If txtAccountCountryOfOrigin.Text = "" Then Throw New Exception("AccountCountryOfOriginRequiredException")

        Dim AccountHolder As String = txtAccountHolder.Text
        Dim AccountNumber As String = txtAccountNumber.Text
        Dim AccountBalence As Double = CDbl(txtAccountBalence.Text)
        Dim AccountIntrestRate As Double = CDbl(txtAccountInterestRate.Text)
        Dim AccountCountryOfOrigin As String = txtAccountCountryOfOrigin.Text

        Dim NewAccount As New BankAccount(AccountHolder, AccountNumber, AccountBalence, AccountIntrestRate, AccountCountryOfOrigin)
        Me.Accounts(Me.NumAccounts) = NewAccount


        Return Nothing

    End Function


End Class
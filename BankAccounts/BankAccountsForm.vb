Imports System.Text

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

    'Buttons
    Private Sub AdAcnt_Click(sender As Object, e As EventArgs) Handles AdAcnt.Click
        Dim Feedback As String = "Account Added"
        Dim Title As String = "Success"

        Try
            Me.CreateAccount()

        Catch Ex As Exception
            Title = Ex.Message()

            If Ex.Message = "AccountHolderRequiredException" Then
                Feedback = "Please Enter an account holder name"
                txtAccountHolder.Focus()

            ElseIf Ex.Message = "AccountNumberRequiredException" Then
                Feedback = "Please enter an account number"
                txtAccountNumber.Focus()

            ElseIf Ex.Message = "AccountBalenceRequiredException" Then
                Feedback = "Please enter an account Balence"
                txtAccountBalence.Focus()

            ElseIf Ex.Message = "AccountIntrestRateRequiredException" Then
                Feedback = "Please enter an interest Rate"
                txtAccountInterestRate.Focus()

            ElseIf Ex.Message = "AccountCountryOfOriginRequiredException" Then
                Feedback = "Please enter an country of origin"
                txtAccountCountryOfOrigin.Focus()

            ElseIf Ex.Message = "MaximumAccountsReachedException" Then
                Feedback = "Maximum number of accounts reached"

            Else
                Title = "An Error Occured"
                Feedback = Ex.Message

            End If
        End Try

        MsgBox(Feedback, vbOKOnly, Title)
        txtAccountHolder.Clear()
        txtAccountNumber.Clear()
        txtAccountBalence.Clear()
        txtAccountInterestRate.Clear()
        txtAccountCountryOfOrigin.Clear()

    End Sub

    Private Sub btnApplyInterest_Click(sender As Object, e As EventArgs) Handles btnApplyInterest.Click
        For Each BAF As BankAccount In Me.Accounts
            If BAF Is Nothing Then Exit For

            BAF.ApplyIntrest()

        Next

    End Sub

    Private Sub PrintAllAccounts_Click(sender As Object, e As EventArgs) Handles PrintAllAccounts.Click

        Dim AllAccounts As New StringBuilder()

        For Each BAF As BankAccount In Me.Accounts
            If BAF Is Nothing Then Exit For

            AllAccounts.Append(BAF.ToString())
            AllAccounts.Append(vbCrLf)

            txtListAccounts.Text = AllAccounts.ToString()

        Next
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
        If Me.NumAccounts > 4 Then Throw New Exception("MaximumAccountsReachedException")


        Dim AccountHolder As String = txtAccountHolder.Text
        Dim AccountNumber As String = txtAccountNumber.Text
        Dim AccountBalence As Double = CDbl(txtAccountBalence.Text)
        Dim AccountIntrestRate As Double = CDbl(txtAccountInterestRate.Text)
        Dim AccountCountryOfOrigin As String = txtAccountCountryOfOrigin.Text

        'Create Account Add to Array
        Dim NewAccount As New BankAccount(AccountHolder, AccountNumber, AccountBalence, AccountIntrestRate, AccountCountryOfOrigin)
        Me.Accounts(Me.NumAccounts) = NewAccount
        Me.NumAccounts += 1

        Return Nothing

    End Function


End Class
''' <summary>
''' Represents a bank account 
''' </summary>
''' <Author> Henry J Borthwick </Author>
''' <Date> 14/05/20 </Date>
Public Class BankAccount

    'Attributes
    Private AccountHolder As String
    Private AccountNumber As String
    Private AccountBalence As Double
    Private AccountIntrestRate As Double
    Private AccountCounteryOfOrigin As String

    'Constructors
    Public Sub New(AccountHolder As String, AccountNumber As String, AccountBalence As Double, AccountIntrestRate As Double, AccountCountryOfOrigin As String)

        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.AccountBalence = AccountBalence
        Me.AccountIntrestRate = AccountIntrestRate
        Me.AccountCounteryOfOrigin = AccountCountryOfOrigin

    End Sub

    Public Sub New(AccountHolder As String, AccountNumber As String, AccountBalence As Double, AccountIntrestRate As Double)

        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.AccountBalence = AccountBalence
        Me.AccountIntrestRate = AccountIntrestRate

    End Sub

    Public Sub New(AccountHolder As String, AccountNumber As String, AccountBalence As Double)

        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.AccountBalence = AccountBalence

    End Sub

    'When a get-er is called upon it will return the value of that a particular private varible and will need to be assigned to a varible.
    'Get-ers
    Public Function GetAccountHolder() As String
        Return Me.AccountHolder

    End Function

    Public Function GetAccountNumber() As String
        Return Me.AccountNumber

    End Function

    Public Function GetAccountBalence() As Double
        Return Me.AccountBalence

    End Function

    Public Function GetAccountIntrestRate() As Double
        Return Me.AccountIntrestRate

    End Function

    Public Function GetAccountCountryOfOrigin() As String
        Return Me.AccountCounteryOfOrigin

    End Function

    'Set-ers and Set Like Methods
    Public Function SetIntrestRate(NewRate As Double)
        Me.AccountIntrestRate = NewRate

        Return Nothing
    End Function

    'Deposit Money To Balence/ Set New Balence
    Public Function Deposit(Amount As Double)

        Dim OldBalence As Double = GetAccountBalence()
        Me.AccountBalence = Amount + OldBalence

        Return Nothing
    End Function
End Class

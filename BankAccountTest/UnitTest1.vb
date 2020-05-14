Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestConstructors()
        'Follow UML Diagram


        '' This represents what the Constructor would do, initilize the varibles and then the Geters would put them in the private values.
        ''Like House Keeping
        'Arrange
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountIntrestrate As Double = 3.0
        Dim AccountBalence As Double = 901336.28
        Dim AccountCountryOrigin As String = "Switzerland"

        '' Testing the Code, acutally putting the varibles into the Bankaccount Class Varible
        'Act
        Dim Account1 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, AccountIntrestrate, AccountBalence, AccountCountryOrigin)
        Dim Account2 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, AccountIntrestrate, AccountBalence)
        Dim Account3 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, AccountIntrestrate)

        '' True of false answer to tell us if test works
        'Assert
        Assert.IsNotNull(Account1)
        Assert.IsNotNull(Account2)
        Assert.IsNotNull(Account3)

    End Sub

    <TestMethod()> Public Sub TestGetAccountHolder()
        'Follow UML Diagram

        'Arrange
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountIntrestrate As Double = 3.0
        Dim AccountBalence As Double = 901336.28
        Dim AccountCountryOrigin As String = "Switzerland"
        Dim Account1 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, AccountIntrestrate, AccountBalence, AccountCountryOrigin)

        'Act
        Dim AccountHold As String = Account1.GetAccountHolder()

        'Assert
        Assert.AreEqual(AccountHold, "Mrs Ivana Wayout")


    End Sub

    <TestMethod()> Public Sub TestGetAccountNumber()

        'Arrange
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountIntrestrate As Double = 3.0
        Dim AccountBalence As Double = 901336.28
        Dim AccountCountryOrigin As String = "Switzerland"
        Dim Account1 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, AccountIntrestrate, AccountBalence, AccountCountryOrigin)

        'Act
        Dim AccountNumb As String = Account1.GetAccountNumber()

        'Assert
        Assert.AreEqual(AccountNumb, "CH93 0076 2001 6734 8790 2")

    End Sub

    <TestMethod()> Public Sub TestGetAccountBalence()

        'Arrange
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountIntrestrate As Double = 3.0
        Dim AccountBalence As Double = 901336.28
        Dim AccountCountryOrigin As String = "Switzerland"
        Dim Account1 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, AccountBalence, AccountIntrestrate, AccountCountryOrigin)

        'ACt
        Dim AccountBal As Double = Account1.GetAccountBalence()

        'Assert
        Assert.AreEqual(AccountBal, 901336.28)


    End Sub

    <TestMethod()> Public Sub TestGetAccountIntrestRate()

        'Arrange
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountIntrestrate As Double = 3.0
        Dim AccountBalence As Double = 901336.28
        Dim AccountCountryOrigin As String = "Switzerland"
        Dim Account1 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, AccountBalence, AccountIntrestrate, AccountCountryOrigin)

        'Act
        Dim AccountIntrestRat As Double = Account1.GetAccountIntrestRate()


        'Assert
        Assert.AreEqual(AccountIntrestRat, 3.0)


    End Sub

    <TestMethod()> Public Sub TestGetAccountCountryOfOrigin()

        'Arrange
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountIntrestrate As Double = 3.0
        Dim AccountBalence As Double = 901336.28
        Dim AccountCountryOrigin As String = "Switzerland"
        Dim Account1 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, AccountIntrestrate, AccountBalence, AccountCountryOrigin)

        'Act
        Dim AccountCountryOfOrig As String = Account1.GetAccountCountryOfOrigin()

        'Assert
        Assert.AreEqual(AccountCountryOfOrig, "Switzerland")
    End Sub

    'Function to Allow the assiging of varibles to varible for testing
    Private Function NewAccount() As BankAccounts.BankAccount
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountIntrestrate As Double = 3.0
        Dim AccountBalence As Double = 901336.28
        Dim AccountCountryOrigin As String = "Switzerland"

        Return New BankAccounts.BankAccount(AccountHolder, AccountNumber, AccountBalence, AccountIntrestrate, AccountCountryOrigin)

    End Function

    <TestMethod()> Public Sub TestSetIntrestRate()
        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        'Act
        Account1.SetIntrestRate(8.0)

        'Assert
        Assert.AreEqual(8.0, Account1.GetAccountIntrestRate())
    End Sub

    <TestMethod()> Public Sub TestDeposit()

        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        'Act
        Account1.Deposit(98663.72)

        'Assert
        Assert.AreEqual(1000000, Account1.GetAccountBalence)

    End Sub

End Class


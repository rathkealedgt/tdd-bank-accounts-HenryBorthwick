Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports BankAccounts

<TestClass()> Public Class UnitTest2

    <TestMethod()> Public Sub TestCreateAccount()
        'Arrange
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountBalence As String = "901336.28"
        Dim AccountIntrestrate As String = "3.0"
        Dim AccountCountryOrigin As String = "Switzerland"

        Dim BAF As New BankAccountsForm()
        BAF.SetSringForTesting(AccountHolder, AccountNumber, AccountBalence, AccountIntrestrate, AccountCountryOrigin)


        'Act
        BAF.CreateAccount()
        Dim TempAccount() As BankAccount = BAF.GetAccounts()

        'Arrest
        Assert.AreEqual(AccountHolder, TempAccount(0).GetAccountHolder())
        Assert.AreEqual(AccountNumber, TempAccount(0).GetAccountNumber())
        Assert.AreEqual(3.0, TempAccount(0).GetAccountIntrestRate())
        Assert.AreEqual(901336.28, TempAccount(0).GetAccountBalence())
        Assert.AreEqual(AccountCountryOrigin, TempAccount(0).GetAccountCountryOfOrigin())
    End Sub

    <TestMethod()> Public Sub TestEmptyAccountHolder()

        'Arrange
        Dim AccountHolder As String = ""
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountIntrestrate As String = "3.0"
        Dim AccountBalence As String = "901336.28"
        Dim AccountCountryOrigin As String = "Switzerland"

        Dim BAF As New BankAccountsForm()
        BAF.SetSringForTesting(AccountHolder, AccountNumber, AccountIntrestrate, AccountBalence, AccountCountryOrigin)

        'Act
        Try
            BAF.CreateAccount()
            Assert.Fail()

        Catch ex As Exception

            'Assert
            Assert.AreEqual("AccountHolderRequiredException", ex.Message)

        End Try

    End Sub


    <TestMethod()> Public Sub TestEmptyAccountNumber()

        'Arrange
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = ""
        Dim AccountIntrestrate As String = "3.0"
        Dim AccountBalence As String = "901336.28"
        Dim AccountCountryOrigin As String = "Switzerland"

        Dim BAF As New BankAccountsForm()
        BAF.SetSringForTesting(AccountHolder, AccountNumber, AccountBalence, AccountIntrestrate, AccountCountryOrigin)

        'Act
        Try
            BAF.CreateAccount()
            Assert.Fail() ' Test Fails if executed

        Catch ex As Exception

            'Assert
            Assert.AreEqual("AccountNumberRequiredException", ex.Message)

        End Try

    End Sub

    <TestMethod()> Public Sub TestEmptyAccountInterestRate()

        'Arrange
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountIntrestrate As String = ""
        Dim AccountBalence As String = "901336.28"
        Dim AccountCountryOrigin As String = "Switzerland"

        Dim BAF As New BankAccountsForm()
        BAF.SetSringForTesting(AccountHolder, AccountNumber, AccountBalence, AccountIntrestrate, AccountCountryOrigin)

        'Act
        Try
            BAF.CreateAccount()
            Assert.Fail()

        Catch ex As Exception

            'Assert
            Assert.AreEqual("AccountIntrestRateRequiredException", ex.Message)

        End Try

    End Sub


    <TestMethod()> Public Sub TestEmptyAccountBalence()

        'Arrange
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountIntrestrate As String = "3.0"
        Dim AccountBalence As String = ""
        Dim AccountCountryOrigin As String = "Switzerland"

        Dim BAF As New BankAccountsForm()
        BAF.SetSringForTesting(AccountHolder, AccountNumber, AccountBalence, AccountIntrestrate, AccountCountryOrigin)

        'Act
        Try
            BAF.CreateAccount()
            Assert.Fail()

        Catch ex As Exception

            'Assert
            Assert.AreEqual("AccountBalenceRequiredException", ex.Message)

        End Try

    End Sub

    <TestMethod()> Public Sub TestEmptyCountryOfOrigin()

        'Arrange
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountIntrestrate As String = "3.0"
        Dim AccountBalence As String = "901336.28"
        Dim AccountCountryOrigin As String = ""

        Dim BAF As New BankAccountsForm()
        BAF.SetSringForTesting(AccountHolder, AccountNumber, AccountBalence, AccountIntrestrate, AccountCountryOrigin)

        'Act
        Try
            BAF.CreateAccount()
            Assert.Fail()

        Catch ex As Exception

            'Assert
            Assert.AreEqual("AccountCountryOfOriginRequiredException", ex.Message)

        End Try

    End Sub

    <TestMethod()> Public Sub TestAddFiveNewAccounts()

        'Arrange
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountBalence As String = "901336.28"
        Dim AccountIntrestrate As String = "3.0"
        Dim AccountCountryOrigin As String = "Switzerland"

        Dim BAF As New BankAccountsForm()

        'Act
        Try
            For Counter As Integer = 0 To 4
                BAF.SetSringForTesting(Counter & "_" & AccountHolder, AccountNumber, AccountBalence, AccountIntrestrate, AccountCountryOrigin)
                BAF.CreateAccount()

            Next Counter

        Catch ex As Exception
            Assert.Fail()

        End Try


        'Assert
        Dim TempAccounts() As BankAccount = BAF.GetAccounts()

        For Each BAFF In TempAccounts

            If BAF Is Nothing Then Assert.Fail()
        Next

    End Sub


    <TestMethod()> Public Sub TestCannotAddSixAccounts()

        'Arrange
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountBalence As String = "901336.28"
        Dim AccountIntrestrate As String = "3.0"
        Dim AccountCountryOrigin As String = "Switzerland"

        Dim BAF As New BankAccountsForm()

        'Act
        Try
            For Counter As Integer = 0 To 5
                BAF.SetSringForTesting(Counter & "_" & AccountHolder, AccountNumber, AccountBalence, AccountIntrestrate, AccountCountryOrigin)
                BAF.CreateAccount()

            Next Counter

            'Assert
            Assert.Fail()

        Catch ex As Exception

            'Assert
            Assert.AreEqual("MaximumAccountsReachedException", ex.Message())

        End Try

    End Sub
End Class
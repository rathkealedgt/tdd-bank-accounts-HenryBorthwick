Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports BankAccounts

<TestClass()> Public Class UnitTest2

    <TestMethod()> Public Sub TestCreateAccount()
        'Arrange
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountIntrestrate As String = "3.0"
        Dim AccountBalence As String = "901336.28"
        Dim AccountCountryOrigin As String = "Switzerland"

        Dim BAF As New BankAccountsForm()
        BAF.SetSringForTesting(AccountHolder, AccountNumber, AccountIntrestrate, AccountBalence, AccountCountryOrigin)


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

End Class
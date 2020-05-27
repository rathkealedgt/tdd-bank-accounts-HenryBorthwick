Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest2

    <TestMethod()> Public Sub TestCreateAccount()
        'Arrange
        Dim AccountHolder As String = "Mrs Ivana Wayout"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim AccountIntrestrate As String = "3.0"
        Dim AccountBalence As String = "901336.28"
        Dim AccountCountryOrigin As String = "Switzerland"


        'Act
        Dim BAF As New BankAccountsForm()
        Dim TempAccount() As BankAccount = BAF.GetAccounts

        'Arrest
        Assert.AreEqual(AccountHolder, TempAccount(0).GetAccountHolder())

    End Sub

End Class
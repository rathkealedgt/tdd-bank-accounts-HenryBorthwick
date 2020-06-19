<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankAccountsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtAccountBalence = New System.Windows.Forms.TextBox()
        Me.txtAccountInterestRate = New System.Windows.Forms.TextBox()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.txtAccountCountryOfOrigin = New System.Windows.Forms.TextBox()
        Me.txtAccountHolder = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtListAccounts = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnApplyInterest = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.AdAcnt = New System.Windows.Forms.Button()
        Me.PrintAllAccounts = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAccountBalence
        '
        Me.txtAccountBalence.Location = New System.Drawing.Point(31, 281)
        Me.txtAccountBalence.Name = "txtAccountBalence"
        Me.txtAccountBalence.Size = New System.Drawing.Size(222, 31)
        Me.txtAccountBalence.TabIndex = 1
        '
        'txtAccountInterestRate
        '
        Me.txtAccountInterestRate.Location = New System.Drawing.Point(31, 380)
        Me.txtAccountInterestRate.Name = "txtAccountInterestRate"
        Me.txtAccountInterestRate.Size = New System.Drawing.Size(222, 31)
        Me.txtAccountInterestRate.TabIndex = 2
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(31, 182)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(216, 31)
        Me.txtAccountNumber.TabIndex = 3
        '
        'txtAccountCountryOfOrigin
        '
        Me.txtAccountCountryOfOrigin.Location = New System.Drawing.Point(31, 479)
        Me.txtAccountCountryOfOrigin.Name = "txtAccountCountryOfOrigin"
        Me.txtAccountCountryOfOrigin.Size = New System.Drawing.Size(216, 31)
        Me.txtAccountCountryOfOrigin.TabIndex = 4
        '
        'txtAccountHolder
        '
        Me.txtAccountHolder.Location = New System.Drawing.Point(31, 91)
        Me.txtAccountHolder.Name = "txtAccountHolder"
        Me.txtAccountHolder.Size = New System.Drawing.Size(216, 31)
        Me.txtAccountHolder.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Account Holder Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Account Interest Rate:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 451)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Account Country Of Origin:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Account Balence:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Account Number:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(779, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Deposit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(985, 76)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 50)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Withdraw"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(779, 132)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(406, 31)
        Me.TextBox1.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(352, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Accounts:"
        '
        'txtListAccounts
        '
        Me.txtListAccounts.Location = New System.Drawing.Point(357, 91)
        Me.txtListAccounts.Multiline = True
        Me.txtListAccounts.Name = "txtListAccounts"
        Me.txtListAccounts.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtListAccounts.Size = New System.Drawing.Size(400, 572)
        Me.txtListAccounts.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 632)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 60)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Clear Information"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnApplyInterest
        '
        Me.btnApplyInterest.Location = New System.Drawing.Point(779, 212)
        Me.btnApplyInterest.Name = "btnApplyInterest"
        Me.btnApplyInterest.Size = New System.Drawing.Size(169, 66)
        Me.btnApplyInterest.TabIndex = 18
        Me.btnApplyInterest.Text = "Apply Interest"
        Me.btnApplyInterest.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(357, 669)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(400, 41)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Clear Displayed Accounts"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'AdAcnt
        '
        Me.AdAcnt.Location = New System.Drawing.Point(12, 549)
        Me.AdAcnt.Name = "AdAcnt"
        Me.AdAcnt.Size = New System.Drawing.Size(150, 60)
        Me.AdAcnt.TabIndex = 20
        Me.AdAcnt.Text = "Add Account"
        Me.AdAcnt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AdAcnt.UseVisualStyleBackColor = True
        '
        'PrintAllAccounts
        '
        Me.PrintAllAccounts.Location = New System.Drawing.Point(985, 212)
        Me.PrintAllAccounts.Name = "PrintAllAccounts"
        Me.PrintAllAccounts.Size = New System.Drawing.Size(200, 66)
        Me.PrintAllAccounts.TabIndex = 21
        Me.PrintAllAccounts.Text = "Print All Accounts"
        Me.PrintAllAccounts.UseVisualStyleBackColor = True
        '
        'BankAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1530, 772)
        Me.Controls.Add(Me.PrintAllAccounts)
        Me.Controls.Add(Me.AdAcnt)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnApplyInterest)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtListAccounts)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAccountHolder)
        Me.Controls.Add(Me.txtAccountCountryOfOrigin)
        Me.Controls.Add(Me.txtAccountNumber)
        Me.Controls.Add(Me.txtAccountInterestRate)
        Me.Controls.Add(Me.txtAccountBalence)
        Me.Name = "BankAccountsForm"
        Me.Text = "BankAccountsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAccountBalence As Windows.Forms.TextBox
    Friend WithEvents txtAccountInterestRate As Windows.Forms.TextBox
    Friend WithEvents txtAccountNumber As Windows.Forms.TextBox
    Friend WithEvents txtAccountCountryOfOrigin As Windows.Forms.TextBox
    Friend WithEvents txtAccountHolder As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents txtListAccounts As Windows.Forms.TextBox
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents btnApplyInterest As Windows.Forms.Button
    Friend WithEvents Button5 As Windows.Forms.Button
    Friend WithEvents AdAcnt As Windows.Forms.Button
    Friend WithEvents PrintAllAccounts As Windows.Forms.Button
End Class

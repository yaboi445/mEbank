<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.txt_account_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_pay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_pay_des = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.lst_pay_account = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lst_spend_account = New System.Windows.Forms.ComboBox()
        Me.btn_pay_enterbtn_pay_enter = New System.Windows.Forms.Button()
        Me.btn_spend_enter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_account_name
        '
        Me.txt_account_name.Location = New System.Drawing.Point(239, 392)
        Me.txt_account_name.Name = "txt_account_name"
        Me.txt_account_name.Size = New System.Drawing.Size(274, 26)
        Me.txt_account_name.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(95, 392)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Account Name"
        '
        'btn_create
        '
        Me.btn_create.Location = New System.Drawing.Point(552, 392)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(86, 31)
        Me.btn_create.TabIndex = 5
        Me.btn_create.Text = "Create "
        Me.btn_create.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(12, 12)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(86, 31)
        Me.btn_logout.TabIndex = 7
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(306, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Create Account"
        '
        'txt_pay
        '
        Me.txt_pay.Location = New System.Drawing.Point(122, 98)
        Me.txt_pay.Name = "txt_pay"
        Me.txt_pay.Size = New System.Drawing.Size(238, 26)
        Me.txt_pay.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(197, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 22)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Payment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(45, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 22)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Amount"
        '
        'txt_pay_des
        '
        Me.txt_pay_des.Location = New System.Drawing.Point(122, 203)
        Me.txt_pay_des.Name = "txt_pay_des"
        Me.txt_pay_des.Size = New System.Drawing.Size(238, 26)
        Me.txt_pay_des.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(16, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(419, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 22)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Description"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(525, 207)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(238, 26)
        Me.TextBox1.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(448, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 22)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(600, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 22)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Spending"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(525, 98)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(238, 26)
        Me.TextBox2.TabIndex = 14
        '
        'btn_help
        '
        Me.btn_help.Location = New System.Drawing.Point(702, 392)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(86, 31)
        Me.btn_help.TabIndex = 19
        Me.btn_help.Text = "Help"
        Me.btn_help.UseVisualStyleBackColor = True
        '
        'lst_pay_account
        '
        Me.lst_pay_account.FormattingEnabled = True
        Me.lst_pay_account.Location = New System.Drawing.Point(122, 148)
        Me.lst_pay_account.Name = "lst_pay_account"
        Me.lst_pay_account.Size = New System.Drawing.Size(238, 28)
        Me.lst_pay_account.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(41, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 22)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Account"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(444, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 22)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Account"
        '
        'lst_spend_account
        '
        Me.lst_spend_account.FormattingEnabled = True
        Me.lst_spend_account.Location = New System.Drawing.Point(525, 149)
        Me.lst_spend_account.Name = "lst_spend_account"
        Me.lst_spend_account.Size = New System.Drawing.Size(238, 28)
        Me.lst_spend_account.TabIndex = 22
        '
        'btn_pay_enterbtn_pay_enter
        '
        Me.btn_pay_enterbtn_pay_enter.Location = New System.Drawing.Point(191, 247)
        Me.btn_pay_enterbtn_pay_enter.Name = "btn_pay_enterbtn_pay_enter"
        Me.btn_pay_enterbtn_pay_enter.Size = New System.Drawing.Size(86, 31)
        Me.btn_pay_enterbtn_pay_enter.TabIndex = 24
        Me.btn_pay_enterbtn_pay_enter.Text = "Enter"
        Me.btn_pay_enterbtn_pay_enter.UseVisualStyleBackColor = True
        '
        'btn_spend_enter
        '
        Me.btn_spend_enter.Location = New System.Drawing.Point(600, 247)
        Me.btn_spend_enter.Name = "btn_spend_enter"
        Me.btn_spend_enter.Size = New System.Drawing.Size(86, 31)
        Me.btn_spend_enter.TabIndex = 25
        Me.btn_spend_enter.Text = "Enter"
        Me.btn_spend_enter.UseVisualStyleBackColor = True
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_spend_enter)
        Me.Controls.Add(Me.btn_pay_enterbtn_pay_enter)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lst_spend_account)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lst_pay_account)
        Me.Controls.Add(Me.btn_help)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_pay_des)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_pay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_account_name)
        Me.Name = "frm_main"
        Me.Text = "frm_create_account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_account_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_create As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_pay As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_pay_des As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btn_help As Button
    Friend WithEvents lst_pay_account As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lst_spend_account As ComboBox
    Friend WithEvents btn_pay_enterbtn_pay_enter As Button
    Friend WithEvents btn_spend_enter As Button
End Class

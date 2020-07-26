<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lst_
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
        Me.btn_pay_search = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_spend_search = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lst_results = New System.Windows.Forms.ListBox()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.date_pay = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btn_hi_lo = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_pay_search
        '
        Me.btn_pay_search.Location = New System.Drawing.Point(165, 173)
        Me.btn_pay_search.Name = "btn_pay_search"
        Me.btn_pay_search.Size = New System.Drawing.Size(86, 31)
        Me.btn_pay_search.TabIndex = 32
        Me.btn_pay_search.Text = "Search"
        Me.btn_pay_search.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(20, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 22)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(171, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 22)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Payment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(358, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 32)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Query"
        '
        'btn_spend_search
        '
        Me.btn_spend_search.Location = New System.Drawing.Point(596, 176)
        Me.btn_spend_search.Name = "btn_spend_search"
        Me.btn_spend_search.Size = New System.Drawing.Size(86, 31)
        Me.btn_spend_search.TabIndex = 40
        Me.btn_spend_search.Text = "Search"
        Me.btn_spend_search.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(448, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 22)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(596, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 22)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Spending"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(341, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 22)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Query Results"
        '
        'lst_results
        '
        Me.lst_results.FormattingEnabled = True
        Me.lst_results.ItemHeight = 20
        Me.lst_results.Location = New System.Drawing.Point(96, 246)
        Me.lst_results.Name = "lst_results"
        Me.lst_results.Size = New System.Drawing.Size(571, 204)
        Me.lst_results.TabIndex = 42
        '
        'btn_help
        '
        Me.btn_help.Location = New System.Drawing.Point(693, 421)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(86, 31)
        Me.btn_help.TabIndex = 43
        Me.btn_help.Text = "Help"
        Me.btn_help.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(12, 14)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(86, 31)
        Me.btn_back.TabIndex = 44
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(693, 385)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(86, 31)
        Me.btn_exit.TabIndex = 45
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'date_pay
        '
        Me.date_pay.Location = New System.Drawing.Point(96, 139)
        Me.date_pay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.date_pay.Name = "date_pay"
        Me.date_pay.Size = New System.Drawing.Size(238, 26)
        Me.date_pay.TabIndex = 46
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(526, 142)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(238, 26)
        Me.DateTimePicker1.TabIndex = 47
        '
        'btn_hi_lo
        '
        Me.btn_hi_lo.Location = New System.Drawing.Point(4, 257)
        Me.btn_hi_lo.Name = "btn_hi_lo"
        Me.btn_hi_lo.Size = New System.Drawing.Size(86, 31)
        Me.btn_hi_lo.TabIndex = 48
        Me.btn_hi_lo.Text = "Hi-Lo"
        Me.btn_hi_lo.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(4, 419)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(86, 31)
        Me.btn_clear.TabIndex = 49
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'lst_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(801, 474)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_hi_lo)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.date_pay)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_help)
        Me.Controls.Add(Me.lst_results)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_spend_search)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_pay_search)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "lst_"
        Me.Text = "frm_query"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_pay_search As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_spend_search As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lst_results As ListBox
    Friend WithEvents btn_help As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents date_pay As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btn_hi_lo As Button
    Friend WithEvents btn_clear As Button
End Class

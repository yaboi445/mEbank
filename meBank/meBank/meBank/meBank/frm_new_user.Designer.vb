<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_new_user
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_new_user))
        Me.btn_create_user = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_new_username = New System.Windows.Forms.TextBox()
        Me.txt_new_pword = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_create_user
        '
        Me.btn_create_user.Location = New System.Drawing.Point(98, 199)
        Me.btn_create_user.Name = "btn_create_user"
        Me.btn_create_user.Size = New System.Drawing.Size(86, 31)
        Me.btn_create_user.TabIndex = 33
        Me.btn_create_user.Text = "Create"
        Me.btn_create_user.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(67, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 22)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(70, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 22)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Password"
        '
        'txt_new_username
        '
        Me.txt_new_username.Location = New System.Drawing.Point(177, 98)
        Me.txt_new_username.Name = "txt_new_username"
        Me.txt_new_username.Size = New System.Drawing.Size(198, 26)
        Me.txt_new_username.TabIndex = 36
        '
        'txt_new_pword
        '
        Me.txt_new_pword.Location = New System.Drawing.Point(177, 141)
        Me.txt_new_pword.Name = "txt_new_pword"
        Me.txt_new_pword.Size = New System.Drawing.Size(198, 26)
        Me.txt_new_pword.TabIndex = 37
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(267, 199)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(86, 31)
        Me.btn_clear.TabIndex = 38
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(12, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(86, 31)
        Me.btn_back.TabIndex = 39
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_help
        '
        Me.btn_help.Location = New System.Drawing.Point(428, 287)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(86, 31)
        Me.btn_help.TabIndex = 40
        Me.btn_help.Text = "Help"
        Me.btn_help.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(362, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'frm_new_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(526, 330)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_help)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.txt_new_pword)
        Me.Controls.Add(Me.txt_new_username)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_create_user)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frm_new_user"
        Me.Text = " New User"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_create_user As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_new_username As TextBox
    Friend WithEvents txt_new_pword As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_help As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

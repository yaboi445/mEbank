Public Class frm_login
    Dim user As String
    Dim users() As String = IO.File.ReadAllLines(Application.StartupPath + "\users.txt") 'reads teh contents of the user names and passwords text file into array
    Private Sub btn_create_account_Click(sender As Object, e As EventArgs) Handles btn_create_account.Click 'opens the create new user page
        frm_new_user.Show()
        Me.Close()
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'checks whether the usernames and passwords file is null, if not dont show the button to create new user
        btn_create_account.Hide()
        Dim count As New System.IO.FileInfo(Application.StartupPath + "\users.txt")
        If count.Length = 0 Then 'checks the size of the text file
            btn_create_account.Show() 'opens the create account page
        End If
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim split
        For Each user In users
            split = user.Split("|") 'splits into username and password
            If txt_uname.Text = split(0) And txt_password.Text = split(1) Then  'checks the username and password with existing username and password
                frm_main.Show()
                Me.Close()
            Else
                MsgBox("Incorrect Username or Password") 'feedback on screen about validity of the data entered into the fields
                txt_password.Clear()
                txt_uname.Clear()
            End If
        Next
    End Sub

    Private Sub btn_help_login_Click(sender As Object, e As EventArgs) Handles btn_help_login.Click
        Process.Start(Application.StartupPath + "\Login.pdf") 'shows help manual for user if they wish to see it
    End Sub
End Class
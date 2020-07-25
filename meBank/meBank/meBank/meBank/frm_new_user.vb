Public Class frm_new_user
    'Dim lines As String() = IO.File.ReadAllLines(Application.StartupPath + "/users.txt")  
    'Dim line As String
    Private Sub btn_create_user_Click(sender As Object, e As EventArgs) Handles btn_create_user.Click
        Dim uname As String = txt_new_username.Text
        Dim pword As String = txt_new_pword.Text
        Dim write_file As System.IO.StreamWriter
        If uname <> "" And pword <> "" Then 'checks that the username and password fields are not null
            'For Each line In lines
            '    If uname = line Then '
            '        MsgBox("This username is already taken")
            '        txt_new_username.Clear()
            '        txt_new_pword.Clear()
            '    End If
            'Next
            If uname.Contains("|") Or pword.Contains("|") Then 'checks if the username or password contain invalid symbols
                MsgBox("Your username or password contains invalid characters") 'provides onscreen feedback telling the user that the data entered was not valid
            Else
                write_file = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath + "/users.txt", True) 'opens the users text file in order to write to it
                write_file.WriteLine(uname + "|" + pword) 'writes the users desired username and password to the file
                write_file.Close()
                MsgBox("Well done. You have successfully created an account") 'providing feedback on the success of the creation of the account
                txt_new_pword.Clear() 'clearing the fields to make it look professional
                txt_new_username.Clear()
                frm_login.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btn_help_Click(sender As Object, e As EventArgs) Handles btn_help.Click
        Process.Start(Application.StartupPath + "\Create Account.pdf") 'shows the help manual for this page
    End Sub
End Class
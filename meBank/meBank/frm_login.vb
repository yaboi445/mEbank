Public Class frm_login
    Dim user As String
    Dim users() As String = IO.File.ReadAllLines(Application.StartupPath + "\users.txt")
    Private Sub btn_create_account_Click(sender As Object, e As EventArgs) Handles btn_create_account.Click
        frm_new_user.Show()
        Me.Hide()
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_create_account.Hide()
        Dim count As New System.IO.FileInfo(Application.StartupPath + "\users.txt")
        If count.Length = 0 Then
            btn_create_account.Show() 'not working.... need to find another way to check that the text file is empty
        End If
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim split

        For Each user In users

            split = user.Split("|")
            If txt_uname.Text = split(0) And txt_password.Text = split(1) Then
                frm_main.Show()
                Me.Hide()
            Else
                MsgBox("Incorrect Username or Password")
            End If
        Next
    End Sub
End Class
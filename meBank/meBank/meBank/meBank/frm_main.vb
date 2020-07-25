Public Class frm_main
    Function check_amount() 'checks whether the value that is entered into the  pay amount field is valid
        Dim amount As String = txt_pay.Text
        Dim x As Boolean = True
        If amount = "" Then 'checks if null
            Return True
        End If
        For i = 1 To amount.Length() 'for each character in the value, run loop
            If Char.IsNumber(amount.Chars(i - 1)) Then  'since the array of characters starts at 0 but i starts at 1, the index must be i -1
                x = True
            Else
                x = False
            End If
        Next
        If x = True Then 'checks to make sure that it passed all of the test above 
            If CInt(amount) > 0 Then 'if passes above tests, checks if the amount is greater than zero(it should be)
                Return True
                Exit Function
            Else
                Return False
                Exit Function
            End If
        End If

    End Function
    Function check_spend_amount() 'checks whether the value that is entered into the  pay amount field is valid
        Dim amount As String = txt_spend_amount.Text
        Dim x As Boolean = True
        If amount = "" Then 'checks if null
            Return True
        End If
        For i = 1 To amount.Length() 'for each character in the value, run loop
            If Char.IsNumber(amount.Chars(i - 1)) Then  'since the array of characters starts at 0 but i starts at 1, the index must be i -1
                x = True
            Else
                x = False
            End If
        Next
        If x = True Then 'checks to make sure that it passed all of the test above 
            If CInt(amount) > 0 Then 'if passes above tests, checks if the amount is greater than zero(it should be)
                Return True
                Exit Function
            Else
                Return False
                Exit Function
            End If
        End If
    End Function

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        frm_login.Show() 'opens the login page
        Me.Close()
    End Sub
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Dim account_name As String = txt_account_name.Text()
        Dim check_account As String() = IO.File.ReadAllLines(Application.StartupPath + "\account_names.txt") 'opens and reads the account names text file into a array
        Dim i As String 'a temporary variable used to index each account name in the names text file
        Dim x As Boolean = True
        For Each i In check_account 'checks each of the lines in the text file to check whether an account with that name exists
            If account_name = i Then
                x = False 'if finds account with same name it changes x to false
            End If
        Next
        If x = False Then 'checks if x is false meaning that is is the second part of the above for statement
            MsgBox("This account name is already in use")
            txt_account_name.Clear()
        Else
            IO.File.Create(Application.StartupPath + "\accounts\acc_" + account_name + ".txt").Dispose() 'create text file for the newly created account
            Dim write_file As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath + "\account_names.txt", True) 'opens the account names text file to write to it
            write_file.WriteLine(account_name) 'writes the new account name to the account names account 
            write_file.Close()
            MsgBox("Your account has been created successfully") 'on screen feedback of success to the user
            add_accounts_list() 'runs the function to update the accounts list on screen
            Dim add_line As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath + "\accounts\acc_" + account_name + ".txt", True) 'opens the new account to write to it
            add_line.WriteLine("|" + "|" + "|" + "0") 'this line is added to avoid runtime errors when they try to add money to the account or search the account
            add_line.Close()
            txt_account_name.Clear()
        End If
    End Sub
    Function add_accounts_list() 'updates the accounts list on screen for the user
        lst_pay_account.Items.Clear() 'clears the lists
        lst_spend_account.Items.Clear()
        lst_bal_acc.Items.Clear()
        Dim check_account As String() = IO.File.ReadAllLines(Application.StartupPath + "\account_names.txt") 'reads the contents of the accounts names text file into an array
        Dim i As String
        For Each i In check_account 'for each name in the list of account names, adds the name to the on screen lists
            lst_pay_account.Items.Add(i)
            lst_spend_account.Items.Add(i)
            lst_bal_acc.Items.Add(i)
        Next
    End Function
    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        add_accounts_list() 'runs function to populate the on screen list
    End Sub

    Private Sub btn_pay_enter_Click(sender As Object, e As EventArgs) Handles btn_pay_enter.Click 'adding a payment
        Dim des As String = txt_pay_des.Text()


        If des <> "" And check_amount() = True And lst_pay_account.SelectedIndex > -1 Then 'checks that there is an account selected and that the description of the pay is not null and that the function is true
            Dim amount As Single = txt_pay.Text()
            Dim account As String = lst_pay_account.SelectedItem
            Dim x As String = "|" 'stores as a string to save time in coding input for the text file
            Dim store_date As Date = Today 'takes the current date
            Dim read_amount As String = IO.File.ReadLines(Application.StartupPath + "\accounts\acc_" + account + ".txt").Last() 'reads the last line of the selected accounts textfile
            Dim tmp = read_amount.Split(x) 'splits last line up by the symbol "|"
            Dim total As Single = tmp(3) 'locates the previous total stored in the file 
            total = total + amount 'adds the new payment to the old total to make the new total
            Dim update_account As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath + "\accounts\acc_" + account + ".txt", True) 'opens the selected account to write to it
            update_account.WriteLine(store_date + x + des + x + CStr(amount) + x + CStr(total)) 'writes new line to the accounts text file
            MsgBox("You have added $" + CStr(amount) + " to the account " + account + " bringing the total to " + CStr(total)) 'supplies on screen feedback to the user about the transaction
            update_account.Close()
            txt_pay.Clear()
            txt_pay_des.Clear()
            lst_pay_account.ResetText()

        Else
            MsgBox("What you have entered is invalid") 'states that what is entered is invalid
        End If

    End Sub

    Private Sub btn_spend_enter_Click(sender As Object, e As EventArgs) Handles btn_spend_enter.Click 'handles the removal of money from an account
        Dim des As String = txt_spend_des.Text()
        Dim amount As Single = txt_spend_amount.Text()

        If des <> "" And check_spend_amount() = True And lst_spend_account.SelectedIndex > -1 Then 'checks that there is an account selected and that the description of the pay is not null and that the function is true
            Dim account As String = lst_spend_account.SelectedItem
            Dim x As String = "|" 'to save time
            Dim store_date As Date = Today 'takes the current date
            Dim read_amount As String = IO.File.ReadLines(Application.StartupPath + "\accounts\acc_" + account + ".txt").Last() 'reads the last line of the selected accounts textfile
            Dim tmp = read_amount.Split(x) 'splits this last line by the symbol "|"
            Dim total As Single = tmp(3) 'locates the total from the last line
            total = total - amount 'subtracts the amount from the old total to create the new total
            Dim update_account As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath + "\accounts\acc_" + account + ".txt", True) 'opens the selected account to write to it 
            update_account.WriteLine(store_date + x + des + x + "-" + CStr(amount) + x + CStr(total)) 'writes a new line of information regarding the transaction to the file
            MsgBox("You have spent $" + CStr(amount) + " from the account " + account + " bringing the total to " + CStr(total)) 'on screen feedack for the user surrounding the transaction
            update_account.Close()
            txt_spend_amount.Clear()
            txt_spend_des.Clear()
            lst_spend_account.ResetText()
        Else
            MsgBox("What you have entered is invalid") 'feedback that something that was entered was invalid
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End 'ends the progragm
    End Sub

    Private Sub btn_query_Click(sender As Object, e As EventArgs) Handles btn_query.Click
        lst_.Show() 'had some screw up here with the name of the form... it was too late to change it so this is just opening the query form
        Me.Close()
    End Sub

    Private Sub lst_bal_acc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_bal_acc.SelectedIndexChanged 'reads the balance for any of the accounts
        Dim balance_acc As String = IO.File.ReadAllLines(Application.StartupPath + "\accounts\acc_" + CStr(lst_bal_acc.SelectedItem) + ".txt").Last() 'opens the last line of the selected account
        Dim tmp = balance_acc.Split("|") 'splits the line up at the symbol "|"
        lbl_balance.Text = "$" + tmp(3) 'shows the balance as the located total and a dollar sign
    End Sub

    Private Sub btn_help_Click(sender As Object, e As EventArgs) Handles btn_help.Click
        Process.Start(Application.StartupPath + "\Main.pdf") 'opens the help menu for the page
    End Sub
End Class
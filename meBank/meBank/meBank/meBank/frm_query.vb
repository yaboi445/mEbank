Public Class lst_
    Dim list_accounts() As String
    Dim query_output As String()
    Public Structure record 'the reciord that is used to sort the pay from high to low
        Dim rec_date As String 'defining each element in the record
        Dim rec_acc As String
        Dim rec_des As String
        Dim rec_amount As String
        Dim rec_total As String

    End Structure
    Dim query_results(-1) As record 'creating array of records
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click 'ends program 
        End
    End Sub

    Private Sub btn_pay_search_Click(sender As Object, e As EventArgs) Handles btn_pay_search.Click
        Dim query_date As String = date_pay.Value.Date.ToString("dd/MM/yyyy") 'stores the date as just the day, month and year from the calender
        Dim account_names As String() = IO.File.ReadAllLines(Application.StartupPath + "\account_names.txt") 'reads all lines of accounts names file and adds them to an array
        Dim account_name As String
        For Each account_name In account_names 'for every name in the array of account names
            Dim check As String() = IO.File.ReadAllLines(Application.StartupPath + "\accounts\acc_" + account_name + ".txt") 'opens the account file associated to the account name 
            Dim line As String
            For Each line In check 'for every line in that account file
                Dim tmp = line.Split("|") 'split that line up by the symbol "|"
                If tmp(0) = query_date Then 'if the date in that line matches the selected date
                    Dim count As Integer = UBound(query_results) + 1 'these lines increase the array of records by 1 index
                    ReDim Preserve query_results(count)

                    lst_results.Items.Add(tmp(0) & vbTab & CStr(account_name) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3)) 'adds line from account file to list box
                    query_results(count).rec_date = tmp(0) 'adds each part of that account file line an index of the array of records
                    query_results(count).rec_acc = account_name
                    query_results(count).rec_des = tmp(1)
                    query_results(count).rec_amount = tmp(2)
                    query_results(count).rec_total = tmp(3)
                End If
            Next
        Next
    End Sub

    Private Sub lst__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_results.Items.Add("Date" & vbTab & vbTab & "Account" & vbTab & "Reason" & vbTab & "Amount" & vbTab & "Total") 'adds the headings for the list box
    End Sub

    Private Sub btn_hi_lo_Click(sender As Object, e As EventArgs) Handles btn_hi_lo.Click 'sorts the array of records by amount paid high to low
        lst_results.Items.Clear() 'clears the list box
        Dim first As Integer = 0
        Dim max_pos As Integer = 0
        Dim temp As record 'a temporary record hold the intermediate value as the indexes are being arranged
        While first <= UBound(query_results) 'while first is less than the size of query results
            For i = first To UBound(query_results) 'for each item in query results
                If CInt(query_results(i).rec_amount) > CInt(query_results(max_pos).rec_amount) Then
                    max_pos = i
                End If
            Next
            temp = query_results(max_pos)
            query_results(max_pos) = query_results(first)
            query_results(first) = temp
            first += 1
            max_pos = first
        End While
        lst_results.Items.Add("Date" & vbTab & vbTab & "Account" & vbTab & "Reason" & vbTab & "Amount" & vbTab & "Total") 'write headings for the list box
        For i = 0 To UBound(query_results)
            lst_results.Items.Add(query_results(i).rec_date & vbTab & query_results(i).rec_acc & vbTab & query_results(i).rec_des & vbTab & query_results(i).rec_amount & vbTab & query_results(i).rec_total)
        Next
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_main.Show()
        Me.Close()
    End Sub

    Private Sub btn_spend_search_Click(sender As Object, e As EventArgs) Handles btn_spend_search.Click
        Dim query_date As String = date_pay.Value.Date.ToString("dd/MM/yyyy") 'stores the date from the calender as a day, month, year
        Dim account_names As String() = IO.File.ReadAllLines(Application.StartupPath + "\account_names.txt") 'reads each line of the accounts names text file into an array 
        Dim account_name As String
        For Each account_name In account_names 'for each account name in the array
            Dim check As String() = IO.File.ReadAllLines(Application.StartupPath + "\accounts\acc_" + account_name + ".txt") 'read the contents of the text file associated with that name into an array 
            Dim line As String
            For Each line In check 'for each line in that array 
                Dim tmp = line.Split("|") 'split the line by the symbol "|"
                If tmp(0) = query_date And tmp(2).Contains("-") Then 'checks if the date for that line is the same as the selected date and the amount has a negative in it 
                    Dim count As Integer = UBound(query_results) + 1 'increase the array of records by one index
                    ReDim Preserve query_results(count)
                    lst_results.Items.Add(tmp(0) & vbTab & CStr(account_name) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3)) 'adds the line from that file to the list box
                    query_results(count).rec_date = tmp(0) 'adds each part of that line to the array of records
                    query_results(count).rec_acc = account_name
                    query_results(count).rec_des = tmp(1)
                    query_results(count).rec_amount = tmp(2)
                    query_results(count).rec_total = tmp(3)
                End If
            Next
        Next
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        lst_results.Items.Clear() 'clears the list box
    End Sub

End Class
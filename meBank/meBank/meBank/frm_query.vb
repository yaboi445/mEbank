Public Class lst_
    Dim list_accounts() As String
    Dim query_output As String()
    Public Structure record
        Dim rec_date As String
        Dim rec_acc As String
        Dim rec_des As String
        Dim rec_amount As String
        Dim rec_total As String

    End Structure
    Dim query_results(0) As record
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
    Function check_pay_amount()
        Dim amount As String = txt_pay_amount.Text
        Dim des As String = txt_pay_des.Text

        If amount = "" Then
            Return True
        End If
        For i = 0 To amount.Length()
            If Char.IsWhiteSpace(amount.Chars(i)) = False Or Char.IsLetter(amount.Chars(i)) = False Then
                If des <> "" And des <> "|" Then
                    Return True
                    Exit Function
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Next
        Return False
    End Function
    'Function find_pay(query_date) As String
    '    Dim account_names As String() = IO.File.ReadAllLines(Application.StartupPath + "\account_names.txt")
    '    Dim account_name As String

    '    Dim count As Integer = 0
    '    For Each account_name In account_names
    '        Dim check As String() = IO.File.ReadAllLines(Application.StartupPath + "\accounts\acc_" + account_name + ".txt")
    '        Dim line As String
    '        For Each line In check
    '            count += 1

    '            If line.Contains(query_date) = True Then

    '                ReDim Preserve list_accounts(UBound(list_accounts) + 1)
    '                list_accounts(UBound(list_accounts)) = account_name
    '            End If
    '        Next
    '    Next
    'End Function
    Private Sub btn_pay_search_Click(sender As Object, e As EventArgs) Handles btn_pay_search.Click
        Dim query_date As String = date_pay.Value.Date.ToString("dd/MM/yyyy")
        If check_pay_amount() = True Then
            'Dim pay As String = txt_pay_amount.Text()
            Dim account_names As String() = IO.File.ReadAllLines(Application.StartupPath + "\account_names.txt")
            Dim account_name As String
            For Each account_name In account_names
                Dim check As String() = IO.File.ReadAllLines(Application.StartupPath + "\accounts\acc_" + account_name + ".txt")
                Dim line As String
                For Each line In check
                    Dim tmp = line.Split("|")
                    If tmp(0) = query_date Then
                        Dim count As Integer = UBound(query_results) + 1
                        ReDim Preserve query_results(count)

                        lst_results.Items.Add(tmp(0) & vbTab & CStr(account_name) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3))
                        query_results(count).rec_date = tmp(0)
                        query_results(count).rec_acc = account_name
                        query_results(count).rec_des = tmp(1)
                        query_results(count).rec_amount = tmp(2)
                        query_results(count).rec_total = tmp(3)
                    End If
                Next
            Next
        End If




        '    For Each i In list_accounts
        '        Dim pay_search As String() = IO.File.ReadLines(Application.StartupPath + "\accounts\acc_" + i + ".txt")
        '        Dim line As String
        '        For Each line In pay_search
        '            If line.Contains(query_date) And line.Contains(pay) Then
        '                query_output(UBound(query_output) + 1) = line
        '                Dim tmp = line.Split()
        '                lst_results.Items.Add(tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3))
        '            End If
        '        Next
        '    Next

    End Sub

    Private Sub lst__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_results.Items.Add("Date" & vbTab & vbTab & "Account" & vbTab & "Reason" & vbTab & "Amount" & vbTab & "Total")

    End Sub

    Private Sub btn_hi_lo_Click(sender As Object, e As EventArgs) Handles btn_hi_lo.Click
        lst_results.Items.Clear()
        Dim first As Integer = 0
        Dim max_pos As Integer = 0
        Dim temp As record
        While first <= UBound(query_results)
            For i = first To UBound(query_results)
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

        For i = 0 To UBound(query_results)

            lst_results.Items.Add(query_results(i).rec_date & vbTab & query_results(i).rec_acc & vbTab & query_results(i).rec_des & vbTab & query_results(i).rec_amount & vbTab & query_results(i).rec_total)
        Next

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_main.Show()
        Me.Close()
    End Sub

    Private Sub btn_spend_search_Click(sender As Object, e As EventArgs) Handles btn_spend_search.Click

        Dim query_date As String = date_pay.Value.Date.ToString("dd/MM/yyyy")
        If check_pay_amount() = True Then
            'Dim pay As String = txt_pay_amount.Text()
            Dim account_names As String() = IO.File.ReadAllLines(Application.StartupPath + "\account_names.txt")
            Dim account_name As String
            For Each account_name In account_names
                Dim check As String() = IO.File.ReadAllLines(Application.StartupPath + "\accounts\acc_" + account_name + ".txt")
                Dim line As String
                For Each line In check
                    Dim tmp = line.Split("|")
                    If tmp(0) = query_date And tmp(2).Contains("-") Then
                        Dim count As Integer = UBound(query_results) + 1
                        ReDim Preserve query_results(count)

                        lst_results.Items.Add(tmp(0) & vbTab & CStr(account_name) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3))
                        query_results(count).rec_date = tmp(0)
                        query_results(count).rec_acc = account_name
                        query_results(count).rec_des = tmp(1)
                        query_results(count).rec_amount = tmp(2)
                        query_results(count).rec_total = tmp(3)
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        lst_results.Items.Clear()
    End Sub
End Class
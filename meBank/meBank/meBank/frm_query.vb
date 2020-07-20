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
            Dim pay As String = txt_pay_amount.Text()
            Dim account_names As String() = IO.File.ReadAllLines(Application.StartupPath + "\account_names.txt")
            Dim account_name As String
            For Each account_name In account_names
                Dim check As String() = IO.File.ReadAllLines(Application.StartupPath + "\accounts\acc_" + account_name + ".txt")
                Dim line As String
                For Each line In check
                    Dim tmp = line.Split("|")
                    If tmp(0) = query_date And tmp(2) = pay Then
                        Dim count As Integer = UBound(query_results) + 1
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
        Dim arr(lst_results.Items.Count - 1) As String


    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_main.Show()
        Me.Close()
    End Sub
End Class
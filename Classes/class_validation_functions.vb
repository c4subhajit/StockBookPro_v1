Imports System.Data
Imports System.Data.SqlClient

Public Class class_validation_functions
    Dim dr As SqlDataReader
    Dim con_cls As New class_connect_string

    Public a, c As String
    Public b, e As Control
    Public d As Date
    Public charecter As Char
    Public ascii As Integer
    Public decimal_count, digit_after_decimal, digit_before_decimal As Integer
    Private acctype As String
    Public err_code As Integer

    ' USER ID AND USER ID EXISTS VALIDATION
    Public Sub userid_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0

            If Not Len(a) < 50 Then
                err_code = 1
                MsgBox("User ID limitation is less than 50 charecters", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            con_cls.connect()
            If Not a = "" Then
                Try
                    con_cls.cmd.CommandText = "SELECT * FROM USERACCOUNTS WHERE userid='" & a & "'"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        MsgBox("User ID already exists.", MsgBoxStyle.OkOnly, "Validation error")
                        b.Clear()
                        b.Focus()
                        dr.Close()
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Validation User ID exception info")
                End Try
                con_cls.cn.Close()
                dr.Close()
            End If
        End If
    End Sub

    'PASSWORD VALIDATION
    Public Sub pass_validate(ByVal a, ByVal c, ByRef b)
        If (Not a = "") And (Not c = "") Then
            err_code = 0
            If (Not Len(a) < 20) And (Not Len(c) < 20) Then
                err_code = 1
                MsgBox("Password limitation is less than 20 charecters", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If Not a = c Then
                err_code = 1
                MsgBox("Password and confirm password doesnot match", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    'DOMAIN VALIDATION
    Public Sub domain_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0

            If Not Len(a) < 20 Then
                err_code = 1
                MsgBox("Domain name length limitation is less than 20 charecters", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            con_cls.connect()
            If Not a = "" Then
                Try
                    con_cls.cmd.CommandText = "SELECT * FROM USERACCOUNTS WHERE domain='" & a & "'"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        MsgBox("Domain name already exists.", MsgBoxStyle.OkOnly, "Validation error")
                        b.Clear()
                        b.Focus()
                        dr.Close()
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Validation Domain Name exception info")
                End Try
                con_cls.cn.Close()
                dr.Close()
            End If
        End If
    End Sub

    'NEW CRITICAL INPUT VALIDATION
    Public Sub criticalInput_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0

            If Not Len(a) < 50 Then
                err_code = 1
                MsgBox("Domain name length limitation is less than 50 charecters", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            con_cls.connect()
            If Not a = "" Then
                Try
                    con_cls.cmd.CommandText = "SELECT * FROM CRITICALINPUT WHERE criticalInput='" & a & "'"
                    dr = con_cls.cmd.ExecuteReader
                    If dr.HasRows Then
                        MsgBox("Critical input already exists.", MsgBoxStyle.OkOnly, "Validation error")
                        b.Clear()
                        b.Focus()
                        dr.Close()
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Validation Critical Input Name exception info")
                End Try
                con_cls.cn.Close()
                dr.Close()
            End If
        End If
    End Sub

    'CRITICAL INPUT UNIT VALIDATION
    Public Sub ciUnit_validate(ByVal a, ByRef b)
        If (Not a = "") And (Not c = "") Then
            err_code = 0
            If (Not Len(a) < 20) And (Not Len(c) < 20) Then
                err_code = 1
                MsgBox("Unit limitation is less than 20 charecters", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    'QUANTITY VALIDATION
    Public Sub quantity_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            decimal_count = 0
            digit_after_decimal = 0
            For i = 1 To Len(a)
                charecter = GetChar(a, i)
                ascii = Asc(charecter)
                If Not ((ascii >= 48 And ascii <= 57) Or ascii = 46) Then
                    err_code = 1
                    MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed", MsgBoxStyle.OkOnly, "Validation error")
                    b.Focus()
                    Exit Sub
                End If
                If ascii = 46 Then
                    decimal_count += 1
                End If
                If decimal_count > 0 Then
                    digit_after_decimal += 1
                End If
            Next
            If decimal_count > 1 Then
                err_code = 1
                MsgBox("Only one decimal point expected", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If digit_after_decimal > 5 Then
                err_code = 1
                MsgBox("Only four digits allowed after decimal point", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
            If Not Len(a) <= 18 Then
                err_code = 1
                MsgBox("Field value limitation within 18 charecters including decimal point", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    'STOCK DETAILS VALIDATION
    Public Sub stockDetails_validate(ByVal a, ByRef b)
        If Not a = "" Then
            err_code = 0
            If Not Len(a) <= 250 Then
                err_code = 1
                MsgBox("Stock details limitation within 250 charecters", MsgBoxStyle.OkOnly, "Validation error")
                b.Focus()
                Exit Sub
            End If
        End If
    End Sub

    'STOCK DETAILS DATE VALIDATION
    Public Sub stockDetailsDate_validate(ByVal a, ByVal c, ByRef b)
        If Not a = "" Then
            err_code = 0
            Try
                con_cls.connect()
                con_cls.cmd.CommandText = "SELECT MAX(date) FROM STOCKBOOK WHERE ci='" & c & "'"
                dr = con_cls.cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    If Not dr.IsDBNull(0) Then
                        If CDate(a) < CDate(dr.Item(0)) Then
                            err_code = 1
                            MsgBox("New stock details date cannot be earlier to the last stock details date " & dr.Item(0), MsgBoxStyle.OkOnly, "Validation error")
                            b.Focus()
                            dr.Close()
                            con_cls.disconnect()
                            Exit Sub
                        End If
                    End If
                    dr.Close()
                End If
                con_cls.disconnect()
                If CDate(a).Date > System.DateTime.Today Then
                    MsgBox("New stock details date cannot be a future date ", MsgBoxStyle.OkOnly, "Validation error")
                    err_code = 1
                    b.Focus()
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Validation stockbook details date, exception info")
            End Try
        End If
    End Sub

End Class

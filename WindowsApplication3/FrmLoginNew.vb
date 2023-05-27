Imports IBM.Data.DB2
Public Class FrmLoginNew
    Dim LoginConn As Common.DbConnection
    Private Sub FrmLoginNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BtnSubmit.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim LoginNo As Integer
        Dim LoginUsername As String
        Dim LoginPassword As String
        Dim LoginEmpID As Integer
        Dim StrLogin As String
        Dim CmdLogin As DB2Command


        Try
            LoginConn = New DB2Connection("server=localhost;database=PETSHOP;" + "uid=db2admin;password=db2admin;")
            LoginConn.Open()

            LoginNo = NewLoginNo()
            LoginUsername = Me.TxtUsername.Text
            LoginPassword = Me.TxtPassword.Text
            LoginEmpID = Me.TxtEmpID.Text

            StrLogin = "insert into logininfo values('" & LoginNo & "', '" & LoginUsername & "', '" & LoginPassword & "', '" & LoginEmpID & "')"
            CmdLogin = New DB2Command(StrLogin, LoginConn)
            CmdLogin.ExecuteNonQuery()

            MessageBox.Show("Login info added", "New Login Info")

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function NewLoginNo()

        Dim StrNewLoginNo As String
        Dim CmdNewLoginNo As DB2Command
        Dim RdrNewLoginNo As DB2DataReader
        Dim NewLoginID As Integer

        Try
            StrNewLoginNo = "select * from logininfo order by loginno desc fetch first row only"
            CmdNewLoginNo = New DB2Command(StrNewLoginNo, LoginConn)
            RdrNewLoginNo = CmdNewLoginNo.ExecuteReader
            RdrNewLoginNo.Read()

            If RdrNewLoginNo.HasRows Then
                NewLoginID = RdrNewLoginNo.GetValue(0) + 1
            Else
                NewLoginID = 1
            End If

            Return NewLoginID
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

    Private Sub TxtUsername_Click(sender As Object, e As EventArgs) Handles TxtUsername.Click
        Me.TxtUsername.Clear()
        Me.TxtUsername.Focus()

    End Sub

    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged
        Call EnableSubmit()
    End Sub

    Private Sub EnableSubmit()
        If (Me.TxtUsername.Text <> "") And (Me.TxtPassword.Text <> "") Then
            Me.BtnSubmit.Enabled = True
        Else
            Me.BtnSubmit.Enabled = False
        End If
    End Sub

    Private Sub TxtPassword_Click(sender As Object, e As EventArgs) Handles TxtPassword.Click
        Me.TxtPassword.Clear()
        Me.TxtPassword.Focus()
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        Call EnableSubmit()
    End Sub

    Private Sub TxtEmpID_Click(sender As Object, e As EventArgs) Handles TxtEmpID.Click
        Me.TxtEmpID.Clear()
        Me.TxtEmpID.Focus()
    End Sub

    Private Sub TxtEmpID_TextChanged(sender As Object, e As EventArgs) Handles TxtEmpID.TextChanged

    End Sub
End Class
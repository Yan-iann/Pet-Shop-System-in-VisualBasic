Imports IBM.Data.DB2
Public Class LoginInfo
    Private LoginConn As Common.DbConnection
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim StrUsername As String
        Dim StrPassword As String
        Dim StrLogin As String
        Dim CmdLogin As DB2Command
        Dim RdrLogin As DB2DataReader

        Dim EmpID As Integer
        Dim StrEmp As String
        Dim CmdEmp As DB2Command
        Dim RdrEmp As DB2DataReader

        Dim EmpPos As String

        StrUsername = Me.TxtUsername.Text
        StrPassword = Me.TxtPassword.Text

        StrLogin = "select * from logininfo where username = '" & StrUsername & "' and password = '" & StrPassword & "' "
        CmdLogin = New DB2Command(StrLogin, LoginConn)
        RdrLogin = CmdLogin.ExecuteReader

        RdrLogin.Read()
        If RdrLogin.HasRows Then
            EmpID = RdrLogin.GetValue(3)
            StrEmp = "select * from employee where empid = '" & EmpID & "' "
            CmdEmp = New DB2Command(StrEmp, LoginConn)
            RdrEmp = CmdEmp.ExecuteReader
            RdrEmp.Read()

            EmpPos = RdrEmp.GetValue(3)
            If EmpPos = "Management" Then
                FrmMenuManagement.Show()
            ElseIf EmpPos = "Clerk" Then
                FrmMenuClerk.Show()
            ElseIf EmpPos = "Cashier" Then
                FrmMenuCashier.Show()
            ElseIf EmpPos = "Veterinarian" Then
                FrmMenuVet.Show()
            End If
            Me.Close()
        Else
            MessageBox.Show("Username and/or password are invalid...", "Login")
            Me.TxtUsername.Clear()
            Me.TxtPassword.Clear()
            Me.TxtUsername.Focus()
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LoginInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoginConn = New DB2Connection("server=localhost;database=petshop;" + "uid=db2admin;password=db2admin;")
            LoginConn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TxtUsername_Click(sender As Object, e As EventArgs) Handles TxtUsername.Click
        If (Me.TxtUsername.Text = "Username") Then
            Me.TxtUsername.Clear()
            Me.TxtUsername.Focus()
        End If
    End Sub

    Private Sub TxtPassword_Click(sender As Object, e As EventArgs) Handles TxtPassword.Click
        If (Me.TxtPassword.Text = "Password") Then
            Me.TxtPassword.Clear()
            Me.TxtPassword.Focus()
        End If
    End Sub

    Private Sub TxtUsername_LostFocus(sender As Object, e As EventArgs) Handles TxtUsername.LostFocus
        If (Me.TxtUsername.Text = "") Then
            Me.TxtUsername.Text = "Username"
        End If
    End Sub

    Private Sub TxtPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtPassword.LostFocus
        If (Me.TxtPassword.Text = "") Then
            Me.TxtPassword.Text = "Password"
        End If
    End Sub


End Class

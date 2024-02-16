Public Class Form1
    Private Sub btnLOGIN_Click(sender As Object, e As EventArgs) Handles btnLOGIN.Click
        Dim stUsername As String = txtUSERNAME.Text
        Dim stPassword As String = txtPASSWORD.Text

        If ValidateLogin(stUsername, stPassword) Then
            MsgBox(stUsername & ", you have logged in successfully")
            YourProfile.Show()
        Else
            MsgBox("Incorrect Username or Password")
            MsgBox("Usernames and passwords are case sensitive!")
        End If
    End Sub

    Private Function ValidateLogin(username As String, password As String) As Boolean
        Select Case username.ToLower() ' Convert username to lowercase for case-insensitive comparison
            Case "adam"
                Return password = "passwd1"
            Case "joan"
                Return password = "passwd2"
            Case "james"
                Return password = "passwd3"
            Case "brian"
                Return password = "passwd4"
            Case "karen"
                Return password = "passwd5"
            Case "eric"
                Return password = "passwd6"
            Case "irene"
                Return password = "passwd7"
            Case "mary"
                Return password = "passwd8"
            Case "charles"
                Return password = "passwd9"
            Case "steve"
                Return password = "passwd10"
            Case "william"
                Return password = "passwd11"
            Case "borne"
                Return password = "passwd12"
            Case "hermes"
                Return password = "passwd13"
            Case Else
                Return False
        End Select
    End Function

    Private Sub btnCLOSE_Click(sender As Object, e As EventArgs) Handles btnCLOSE.Click
        Me.Close()
    End Sub
End Class

Public Class Base64String

    Private Sub ButtonToBase64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonToBase64.Click
        Try
            Me.TextBoxToBase64.Text = Convert.ToBase64String(System.Text.UnicodeEncoding.ASCII.GetBytes(Me.TextBoxPlain.Text.Trim))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonFromBase64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFromBase64.Click
        Try
            Me.TextBoxFromBase64.Text = System.Text.UnicodeEncoding.ASCII.GetString(Convert.FromBase64String(Me.TextBoxToBase64.Text.Trim))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxPlain_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPlain.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                Me.ButtonToBase64_Click(Me, e)
                Me.TextBoxToBase64.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxToBase64_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxToBase64.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                Me.ButtonFromBase64_Click(Me, e)
                Me.TextBoxFromBase64.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxFromBase64_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxFromBase64.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                Me.TextBoxPlain.Text = Nothing
                Me.TextBoxPlain.Text = Me.TextBoxFromBase64.Text
                Me.TextBoxPlain.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxPlain_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxPlain.GotFocus
        Try
            Me.TextBoxPlain.SelectionStart = Me.TextBoxPlain.TextLength
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxToBase64_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxToBase64.GotFocus
        Try
            Me.TextBoxToBase64.SelectionStart = Me.TextBoxToBase64.TextLength
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxFromBase64_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxFromBase64.GotFocus
        Try
            Me.TextBoxFromBase64.SelectionStart = Me.TextBoxFromBase64.TextLength
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        Try
            Me.TextBoxPlain.Clear()
            Me.TextBoxToBase64.Clear()
            Me.TextBoxFromBase64.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

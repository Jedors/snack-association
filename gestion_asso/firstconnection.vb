Imports System.ComponentModel
Imports System.IO
Public Class firstconnection
    Private Sub firstconnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Me.Text = SPLASH.theConfig._FirstConnection
        Me.LB_NAME.Text = SPLASH.theConfig._NameOfOrganisation + " :"
        Me.LB_LANG.Text = SPLASH.theConfig._LanguageToUse + " :"
        Me.LB_PASSWORD.Text = SPLASH.theConfig._Password + " :"
        Me.BT_CONFIRM.Text = SPLASH.theConfig._Confirm

        'List all xml file from the language folder
        If Directory.Exists(SPLASH.LANG_DIR) Then
            Try
                Dim xmlFiles = Directory.EnumerateFiles(SPLASH.LANG_DIR, "*.xml")

                For Each currentFile As String In xmlFiles
                    Me.CB_LANG.Items.Add(currentFile)
                Next
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
            End Try
        Else
            MsgBox("Unexisting lang path", MsgBoxStyle.OkOnly, "Error")
        End If

    End Sub

    Private Sub LB_NAME_Click(sender As Object, e As EventArgs) Handles LB_NAME.Click
        Me.TXT_NAME.Focus()
    End Sub

    Private Sub LB_LANG_Click(sender As Object, e As EventArgs) Handles LB_LANG.Click
        Me.CB_LANG.Focus()
    End Sub

    Private Sub LB_PASSWORD_Click(sender As Object, e As EventArgs) Handles LB_PASSWORD.Click
        Me.TXT_PASSWORD.Focus()
    End Sub

    Private Sub firstconnection_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not Confirm() Then
            e.Cancel = True
        End If
    End Sub

    Private Sub BT_CONFIRM_Click(sender As Object, e As EventArgs) Handles BT_CONFIRM.Click
        If Confirm() Then
            Me.Close()
        End If
    End Sub

    Private Function Confirm() As Boolean
        If Me.LB_NAME.Text <> "" And Me.LB_PASSWORD.Text <> "" And File.Exists(Me.CB_LANG.SelectedItem.ToString) Then
            SPLASH.theConfig.OrganisationName = Me.TXT_NAME.Text
            SPLASH.theConfig.LangFile = Me.CB_LANG.SelectedItem.ToString()

            If Me.LB_PASSWORD.Text.Length > 7 Then
                SPLASH.theConfig.PasswordHash = Me.TXT_PASSWORD.Text
                Return True
            Else
                MsgBox("Password must contain between 8 and 16 characters.")
                Return False
            End If
        Else
            MsgBox("Please don't leave any blank space")
            Return False
        End If
    End Function

    Private Sub firstconnection_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            SPLASH.theConfig.SaveConfig()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
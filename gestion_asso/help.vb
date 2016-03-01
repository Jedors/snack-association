Imports System.ComponentModel

Public Class help
    Private Sub help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = SPLASH.theConfig._Help + " - " + SPLASH.theConfig.OrganisationName
        Me.BT_CLOSE.Text = SPLASH.theConfig._Close
        Me.LB_TEXT_1.Text = SPLASH.theConfig._Help1 + vbCrLf + SPLASH.theConfig._Help2 + vbCrLf + vbCrLf +
            "GNU GPL - Maël Belval"
    End Sub

    Private Sub BT_CLOSE_Click(sender As Object, e As EventArgs) Handles BT_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub help_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        home.Show()
    End Sub
End Class
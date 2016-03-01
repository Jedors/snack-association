Imports System.ComponentModel

Public Class home
    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BT_ADMIN.Text = SPLASH.theConfig._Administration
        Me.BT_CLOSE.Text = SPLASH.theConfig._Close
        Me.BT_HELP.Text = SPLASH.theConfig._Help
        Me.BT_SHOP.Text = SPLASH.theConfig._Shop
        Me.BT_INSTANT.Text = SPLASH.theConfig._Pancakes
        Me.Text = SPLASH.theConfig.OrganisationName + " - " + SPLASH.theConfig._Home

        Dim Statut As String = "Guest"
        Dim FirstName As String
        Dim Balance As Double

        If Not SPLASH.isAdmin Then
            Me.BT_ADMIN.Visible = False
            Me.BT_INSTANT.Visible = False
        End If

        If SPLASH.idUser > 0 Then
            Statut = SPLASH.theDatabase.getStatusUser(SPLASH.idUser)
        Else
            Statut = "SuperUser"
        End If

        If SPLASH.idUser < 0 Then
            FirstName = SPLASH.theConfig.OrganisationName
            Balance = 1000000000000
        Else
            FirstName = SPLASH.theDatabase.getFirstName(SPLASH.idUser)
            Balance = SPLASH.theDatabase.getBalance(SPLASH.idUser)
        End If

        Me.LB_TEXT.Text = FirstName + " - " + Statut + vbCrLf + SPLASH.theConfig._Balance + " : " +
            Math.Round(Balance, 2).ToString() + "€"
    End Sub

    Private Sub BT_CLOSE_Click(sender As Object, e As EventArgs) Handles BT_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub BT_ADMIN_Click(sender As Object, e As EventArgs) Handles BT_ADMIN.Click
        administration.Show()
        Me.Hide()
    End Sub

    Private Sub BT_HELP_Click(sender As Object, e As EventArgs) Handles BT_HELP.Click
        help.Show()
        Me.Hide()
    End Sub

    Private Sub BT_SHOP_Click(sender As Object, e As EventArgs) Handles BT_SHOP.Click
        If SPLASH.isAdmin Then
            shop.Show()
        Else
            payment.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub home_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SPLASH.isAdmin = False
        SPLASH.idUser = -1
        SPLASH.Show()
    End Sub

    Private Sub BT_INSTANT_Click(sender As Object, e As EventArgs) Handles BT_INSTANT.Click
        payment.Show()
        payment.idUser = -2
        Me.Hide()
    End Sub
End Class
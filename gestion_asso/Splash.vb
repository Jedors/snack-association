Imports System.Data.SQLite
Imports System.Data
Imports System.IO
Imports System.Xml.Serialization
Public Class SPLASH
    Private Const ConfigurationFile As String = "config.ini"
    Public Const LANG_DIR As String = "language"

    Public theDatabase As New database
    Public theConfig As New configfile
    Public idUser As Integer = -1
    Public isAdmin As Boolean = False

    Private Sub SPLASH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not File.Exists(ConfigurationFile) Then
            firstconnection.Show()
        End If

        Me.Text = theConfig.OrganisationName + " - " + theConfig.Version
        Me.LB_NICKNAME.Text = theConfig._Nickname
        Me.LB_PASSWORD.Text = theConfig._Password
        Me.BT_CONFIRM.Text = theConfig._Confirm

        'TODO Insert weekly save of money_input
    End Sub

    Private Sub SPLASH_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        If Not theDatabase.dbQuit() Then
            MsgBox("Error while closing connection to the database.")
        End If

        If Not theConfig.SaveConfig() Then
            MsgBox("Error while saving the configuration.")
        End If

    End Sub

    Private Sub BT_CONFIRM_Click(sender As Object, e As EventArgs) Handles BT_CONFIRM.Click
        If theDatabase.GetNbAdmin() = 0 Then
            If Me.TXT_NICKNAME.Text = theConfig.OrganisationName Then
                If theConfig.hashCompare(theConfig.PasswordHash, Me.TXT_PASSWORD.Text,
                                         theConfig.OrganisationName) Then
                    MsgBox("Please think of adding real admin, the default account isn't the most secure")
                    isAdmin = True
                    idUser = -2
                    Me.TXT_NICKNAME.Text = ""
                    Me.TXT_PASSWORD.Text = ""
                    Me.Hide()
                    home.Show()
                Else
                    MsgBox("Wrong password")
                End If
            Else
                MsgBox("If you're from the staff, are you sure to know the name of your association ?")
            End If

        Else
            Dim passwordHash As String = theConfig.hashGen(Me.TXT_PASSWORD.Text, Me.TXT_NICKNAME.Text)
            Dim newId As Integer = theDatabase.GetUserId(Me.TXT_NICKNAME.Text, passwordHash)
            If newId >= 0 Then
                idUser = newId
                isAdmin = theDatabase.isAdminUser(idUser)
                Me.Hide()
                home.Show()
            Else
                MsgBox("Error in the password or the nickname")
            End If
        End If
    End Sub
End Class

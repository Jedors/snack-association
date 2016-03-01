Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Xml.Serialization

Public Class configfile

#Region "Constants"
    Const CONFIG_FILE As String = "config.ini"
    Const NB_LINE As Integer = 3

    Const KEY_ORGANISATION_NAME As String = "OrganisationName"
    Const KEY_LANG_FILE As String = "LangFile"
    Const KEY_VERSION As String = "Version"
    Const KEY_PASSWORD As String = "Password"
#End Region

#Region "Settings"
    Private _OrganisationName As String = "Asso"
    Private _LangFile As String = "language\en_US.xml"
    Private _Version As String = "1.0.1"
    'Default Password is OrganisationName encrypted (with password empty)
    Private _PasswordHash As String = "wCB4Zmh+gWfy2zT86WyHLg=="
#End Region

    Private _Language As lang


    'ID asso to be used ONLY if "SELECT COUNT(id) FROM member;" return nothing

    'Get setting from file, then load language if path not empty & file.exist
    Public Sub New()
        If Not LoadConfigFromFile() Then
            MsgBox("Error on loading config file")
        End If

        'Load the language
        LoadLanguage()
    End Sub

    ''' <summary>
    ''' Load the language
    ''' </summary>
    Private Sub LoadLanguage()
        If _LangFile <> Nothing And File.Exists(_LangFile) Then
            Dim FluxDeFichier As Stream = File.OpenRead(_LangFile)
            Dim Deserialiseur As New XmlSerializer(GetType(lang))
            _Language = CType(Deserialiseur.Deserialize(FluxDeFichier), lang)
            FluxDeFichier.Close()
        Else
            MsgBox("Unexisting " + _LangFile + ". Using default language.")
        End If
    End Sub

#Region "MD5 Encryption with salt"

    ''' <summary>
    ''' Encrypt with MD5 method a password with salt
    ''' </summary>
    ''' <param name="sourceText">string to be encrypted</param>
    ''' <param name="salt">his salt</param>
    ''' <returns>Encrypted string</returns>
    Public Function hashGen(ByVal sourceText As String, ByVal salt As String) As String
        ' retrieve byte array based on source text, then
        ' compute hash and convert to string
        Return Convert.ToBase64String(New MD5CryptoServiceProvider().
                                      ComputeHash(New UnicodeEncoding().GetBytes(sourceText + salt)))
    End Function

    ''' <summary>
    ''' Compare unencrypted string with encrypted one to check if equal
    ''' </summary>
    ''' <param name="firstHash">Encrypted string</param>
    ''' <param name="compareText">Unencrypted string</param>
    ''' <param name="salt">salt used to get the first string</param>
    ''' <returns>True if equal</returns>
    Public Function hashCompare(ByVal firstHash As String, ByVal compareText As String,
                                ByVal salt As String) As Boolean

        ' generate hash for compareText
        Dim compareHash = hashGen(compareText, salt)

        ' if lengths are different, fail
        If firstHash.Length <> compareHash.Length Then
            Return False
        Else
            ' otherwise, compare value of each character
            Dim intCount As Integer = 0
            For intCount = 0 To firstHash.Length - 1
                ' fail if different
                If firstHash(intCount) <> compareHash(intCount) Then
                    Return False
                End If
            Next

            Return True
        End If
    End Function

#End Region

#Region "Ini function"
    ''' <summary>
    ''' Save the config into file
    ''' </summary>
    ''' <returns>State of the function (true if worked)</returns>
    Public Function SaveConfig() As Boolean
        Try
            File.WriteAllLines(CONFIG_FILE, MakeFileStructure(_OrganisationName, _LangFile, _Version,
                                                              _PasswordHash))
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'To change on adding New configuration line
    ''' <summary>
    ''' Make a structure of the ini file to be saved
    ''' </summary>
    ''' <param name="AssoName">Name of the association which use the app</param>
    ''' <param name="LangPath">Path of the language file which is used</param>
    ''' <param name="VersionApp">Version of the application</param>
    ''' <param name="RootPassword">Encrypted password of the default account</param>
    ''' <returns>String Array feed with each config line</returns>
    Private Function MakeFileStructure(ByVal AssoName As String, ByVal LangPath As String,
                               ByVal VersionApp As String, ByVal RootPassword As String) As String()
        Dim IniFile(NB_LINE) As String

        IniFile(0) = KEY_ORGANISATION_NAME + ":" + AssoName
        IniFile(1) = KEY_LANG_FILE + ":" + LangPath
        IniFile(2) = KEY_VERSION + ":" + VersionApp
        IniFile(3) = KEY_PASSWORD + ":" + RootPassword

        Return IniFile
    End Function

    ''' <summary>
    ''' Get special setting from file with key
    ''' </summary>
    ''' <param name="Key">Key of the setting to get</param>
    ''' <returns>Setting if found</returns>
    Private Function GetSettingFromKey(ByVal Key As String) As String

        For Each Ligne As String In File.ReadAllLines(CONFIG_FILE)
            If Ligne.Split(":")(0) = Key Then
                Return Ligne.Split(":")(1)
            End If
        Next

        Return ""
    End Function

    ''' <summary>
    ''' Load the configuration from Ini File
    ''' </summary>
    ''' <returns>State on the function (true if worked)</returns>
    Private Function LoadConfigFromFile() As Boolean
        If File.Exists(CONFIG_FILE) Then
            Dim Organisation As String = GetSettingFromKey(KEY_ORGANISATION_NAME)
            Dim LanguageToUse As String = GetSettingFromKey(KEY_LANG_FILE)
            Dim CurrentVersion As String = GetSettingFromKey(KEY_VERSION)
            Dim EncryptedPassword As String = GetSettingFromKey(KEY_PASSWORD)

            If Organisation <> "" Then
                _OrganisationName = Organisation
            End If
            If File.Exists(LanguageToUse) Then
                _LangFile = LanguageToUse
            End If
            If CurrentVersion <> "" Then
                _Version = CurrentVersion
            End If
            If EncryptedPassword <> "" Then
                _PasswordHash = EncryptedPassword
            Else
                _PasswordHash = hashGen("", OrganisationName)
            End If

        Else
            MsgBox("The file " & CONFIG_FILE & " haven't been found. Using default config file")
            Return False
        End If

        Return True

    End Function
#End Region

#Region "Property Language"
    Public ReadOnly Property _Title As String
        Get
            Return _Language.Title
        End Get
    End Property
    Public ReadOnly Property _Options As String
        Get
            Return _Language.Options
        End Get
    End Property
    Public ReadOnly Property _Administration As String
        Get
            Return _Language.Administration
        End Get
    End Property
    Public ReadOnly Property _Back As String
        Get
            Return _Language.Back
        End Get
    End Property
    Public ReadOnly Property _Help As String
        Get
            Return _Language.Help
        End Get
    End Property
    Public ReadOnly Property _Close As String
        Get
            Return _Language.Close
        End Get
    End Property
    Public ReadOnly Property _Snack As String
        Get
            Return _Language.Snack
        End Get
    End Property
    Public ReadOnly Property _Order As String
        Get
            Return _Language.Order
        End Get
    End Property
    Public ReadOnly Property _Name As String
        Get
            Return _Language.Name
        End Get
    End Property
    Public ReadOnly Property _User As String
        Get
            Return _Language.User
        End Get
    End Property
    Public ReadOnly Property _Admin As String
        Get
            Return _Language.Admin
        End Get
    End Property
    Public ReadOnly Property _FirstName As String
        Get
            Return _Language.FirstName
        End Get
    End Property
    Public ReadOnly Property _Balance As String
        Get
            Return _Language.Balance
        End Get
    End Property
    Public ReadOnly Property _Points As String
        Get
            Return _Language.Points
        End Get
    End Property
    Public ReadOnly Property _ID As String
        Get
            Return _Language.ID
        End Get
    End Property
    Public ReadOnly Property _Nickname As String
        Get
            Return _Language.Nickname
        End Get
    End Property
    Public ReadOnly Property _Password As String
        Get
            Return _Language.Password
        End Get
    End Property
    Public ReadOnly Property _Hash As String
        Get
            Return _Language.Hash
        End Get
    End Property
    Public ReadOnly Property _AllowNeg As String
        Get
            Return _Language.AllowNeg
        End Get
    End Property
    Public ReadOnly Property _PhoneNumber As String
        Get
            Return _Language.PhoneNumber
        End Get
    End Property
    Public ReadOnly Property _Email As String
        Get
            Return _Language.Email
        End Get
    End Property
    Public ReadOnly Property _Status As String
        Get
            Return _Language.Status
        End Get
    End Property
    Public ReadOnly Property _Blacklist As String
        Get
            Return _Language.Blacklist
        End Get
    End Property
    Public ReadOnly Property _Reason As String
        Get
            Return _Language.Reason
        End Get
    End Property
    Public ReadOnly Property _TypeProduct As String
        Get
            Return _Language.TypeProduct
        End Get
    End Property
    Public ReadOnly Property _Drinks As String
        Get
            Return _Language.Drinks
        End Get
    End Property
    Public ReadOnly Property _Foods As String
        Get
            Return _Language.Foods
        End Get
    End Property
    Public ReadOnly Property _Payment As String
        Get
            Return _Language.Payment
        End Get
    End Property
    Public ReadOnly Property _PayBalance As String
        Get
            Return _Language.PayBalance
        End Get
    End Property
    Public ReadOnly Property _PayPoints As String
        Get
            Return _Language.PayPoints
        End Get
    End Property
    Public ReadOnly Property _PayCash As String
        Get
            Return _Language.PayCash
        End Get
    End Property
    Public ReadOnly Property _Fridge As String
        Get
            Return _Language.Fridge
        End Get
    End Property
    Public ReadOnly Property _Units As String
        Get
            Return _Language.Units
        End Get
    End Property
    Public ReadOnly Property _Product As String
        Get
            Return _Language.Product
        End Get
    End Property
    Public ReadOnly Property _Newsletter As String
        Get
            Return _Language.Newsletter
        End Get
    End Property
    Public ReadOnly Property _ToShop As String
        Get
            Return _Language.ToShop
        End Get
    End Property
    Public ReadOnly Property _Shopped As String
        Get
            Return _Language.Shopped
        End Get
    End Property
    Public ReadOnly Property _Pancakes As String
        Get
            Return _Language.Pancakes
        End Get
    End Property
    Public ReadOnly Property _FirstConnection As String
        Get
            Return _Language.FirstConnection
        End Get
    End Property
    Public ReadOnly Property _PasswordAgain As String
        Get
            Return _Language.PasswordAgain
        End Get
    End Property
    Public ReadOnly Property _PasswordCondition As String
        Get
            Return _Language.PasswordCondition
        End Get
    End Property
    Public ReadOnly Property _NameOfOrganisation As String
        Get
            Return _Language.NameOfOrganisation
        End Get
    End Property
    Public ReadOnly Property _LanguageToUse As String
        Get
            Return _Language.LanguageToUse
        End Get
    End Property
    Public ReadOnly Property _Confirm As String
        Get
            Return _Language.Confirm
        End Get
    End Property
    Public ReadOnly Property _Shop As String
        Get
            Return _Language.Shop
        End Get
    End Property
    Public ReadOnly Property _Setting As String
        Get
            Return _Language.Setting
        End Get
    End Property
    Public ReadOnly Property _Home As String
        Get
            Return _Language.Home
        End Get
    End Property
    Public ReadOnly Property _Help1 As String
        Get
            Return _Language.Help1
        End Get
    End Property
    Public ReadOnly Property _Help2 As String
        Get
            Return _Language.Help2
        End Get
    End Property
    Public ReadOnly Property _Purchase As String
        Get
            Return _Language.Purchase
        End Get
    End Property

    Public ReadOnly Property _Price As String
        Get
            Return _Language.Price
        End Get
    End Property

    Public ReadOnly Property _Credit As String
        Get
            Return _Language.Credit
        End Get
    End Property

    Public ReadOnly Property _Debit As String
        Get
            Return _Language.Debit
        End Get
    End Property

    Public ReadOnly Property _Label As String
        Get
            Return _Language.Label
        End Get
    End Property

    Public ReadOnly Property _PriceBuy As String
        Get
            Return _Language.PriceBuy
        End Get
    End Property

    Public ReadOnly Property _PriceSell As String
        Get
            Return _Language.PriceSell
        End Get
    End Property

    Public ReadOnly Property _PricePoint As String
        Get
            Return _Language.PricePoint
        End Get
    End Property

    Public ReadOnly Property _ValuePoint As String
        Get
            Return _Language.ValuePoint
        End Get
    End Property

    Public ReadOnly Property _Stock As String
        Get
            Return _Language.Stock
        End Get
    End Property

    Public ReadOnly Property _Money As String
        Get
            Return _Language.Money
        End Get
    End Property

    Public ReadOnly Property _InsertTransaction As String
        Get
            Return _Language.InsertTransaction
        End Get
    End Property

    Public ReadOnly Property _RecordSum As String
        Get
            Return _Language.RecordSum
        End Get
    End Property
#End Region

#Region "Property Config"
    Public Property OrganisationName As String
        Get
            Return _OrganisationName
        End Get
        Set(value As String)
            _OrganisationName = value
        End Set
    End Property

    Public Property LangFile As String
        Get
            Return _LangFile
        End Get
        Set(value As String)
            If File.Exists(value) Then
                _LangFile = value
                LoadLanguage()
            End If
        End Set
    End Property

    Public ReadOnly Property Version As String
        Get
            Return _Version
        End Get
    End Property

    Public Property PasswordHash As String
        Get
            Return _PasswordHash
        End Get
        Set(value As String)
            _PasswordHash = hashGen(value, OrganisationName)
        End Set
    End Property
#End Region
End Class

<Serializable()>
Public Class lang
    Public Title As String = "Title"

#Region "Common buttons"
    Public Options As String = "Options"
    Public Administration As String = "Administration"
    Public Help As String = "Help"
    Public Close As String = "Close"
    Public Back As String = "Back"
#End Region

    Public Snack As String = "Snack"
    Public Order As String = "Order"

#Region "Account"
    Public Name As String = "Name"
    Public User As String = "User"
    Public Admin As String = "Administrator"
    Public FirstName As String = "First Name"
    Public Balance As String = "Balance"
    Public Points As String = "Point(s)"
    Public ID As String = "ID"
    Public Nickname As String = "Nickname"
    Public Password As String = "Password"
    Public Hash As String = "Hash"
    Public AllowNeg As String = "Allow the negative"
    Public PhoneNumber As String = "Phone number"
    Public Email As String = "Email adress"

    Public Status As String = "Status"
    Public Blacklist As String = "Blacklist"
    Public Reason As String = "Reason"
#End Region

    Public TypeProduct As String = "Type of product"
    Public Drinks As String = "Drinks"
    Public Foods As String = "Food"

    Public Payment As String = "Payment"

    Public PayBalance As String = "Pay with balance"
    Public PayPoints As String = "Pay with points"
    Public PayCash As String = "Pay with cash"

    Public Fridge As String = "Fridge"

    Public Units As String = "Units"
    Public Product As String = "Product"

    Public Newsletter As String = "Newsletter"
    Public ToShop As String = "To Shop"
    Public Shopped As String = "Shopped"

    Public Pancakes As String = "Pancakes"


    Public FirstConnection As String = "First Connection"
    Public PasswordAgain As String = "Write again your password"
    Public PasswordCondition As String = "Password must have between 8 and 16 characters"

    Public NameOfOrganisation As String = "Name of the organisation"
    Public LanguageToUse As String = "Language"
    Public Confirm As String = "Confirm"

    Public Setting As String = "Setting"
    Public Shop As String = "Shop"
    Public Home As String = "Home"

    Public Help1 As String = ""
    Public Help2 As String = ""

    Public Purchase As String = "Purchase"
    Public Price As String = "Price"

    Public Credit As String = "Credit"
    Public Debit As String = "Debit"
    Public Label As String = "Label"

    Public PriceBuy As String = "Price buyed"
    Public PriceSell As String = "Price selled"
    Public PricePoint As String = "Price in point"
    Public ValuePoint As String = "Point earned"
    Public Stock As String = "Stock"
    Public Money As String = "Money"
    Public InsertTransaction As String = "Record transaction"
    Public RecordSum As String = "Record current sum"

    'If adding new language var,
    'Think of adding a property in region language in configfile
    'Add the var in each xml file
End Class
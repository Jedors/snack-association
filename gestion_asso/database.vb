Imports System.Data.SQLite
Imports System.IO
Public Class database
    Const dbFolder As String = "data"
    Const dbName As String = "data.db"
    Const dbPath As String = dbFolder + "\" + dbName

    'All the table of the database
    Const table_member As String = "CREATE TABLE member(id INTEGER PRIMARY KEY," +
        " nickname TEXT UNIQUE NOT NULL, name TEXT NOT NULL, firstname TEXT NOT NULL," +
        " email TEXT UNIQUE NOT NULL, phonenumber TEXT, password TEXT, balance REAL DEFAULT 0," +
        " points INTEGER DEFAULT 0, allowneg INTEGER CHECK (allowneg=0 OR allowneg=1) DEFAULT 0);"
    Const table_staff As String = "CREATE TABLE staff(id INTEGER UNIQUE NOT NULL," +
        " status TEXT NOT NULL, FOREIGN KEY (id) REFERENCES member (id));"
    Const table_product As String = "CREATE TABLE product(id_product INTEGER PRIMARY KEY," +
        " label TEXT UNIQUE NOT NULL, price_sell REAL NOT NULL," +
        " price_buy REAL NOT NULL CHECK (price_buy<price_sell), price_point INTEGER NOT NULL," +
        " value_point INTEGER NOT NULL CHECK (price_point>value_point*5), stock INTEGER DEFAULT 0," +
        " id_type INTEGER NOT NULL, fridge INTEGER NOT NULL CHECK (fridge=0 OR fridge=1)," +
        " id_unit INTEGER NOT NULL, FOREIGN KEY (id_type) REFERENCES type(id_type)," +
        " FOREIGN KEY (id_unit) REFERENCES unit(id_unit));"
    Const table_buy As String = "CREATE TABLE buy(id_product INTEGER NOT NULL, id INTEGER NOT NULL," +
        " time TEXT NOT NULL, FOREIGN KEY (id_product) REFERENCES product(id_product)," +
        " FOREIGN KEY (id) REFERENCES member(id), PRIMARY KEY(id_product, id, time));"
    Const table_money_input As String = "CREATE TABLE money_input(money REAL NOT NULL);"
    Const table_total_money As String = "CREATE TABLE total_money(money REAL NOT NULL," +
        " date TEXT NOT NULL UNIQUE, PRIMARY KEY (date));"
    Const table_blacklist As String = "CREATE TABLE blacklist(id INTEGER UNIQUE NOT NULL," +
        " reason TEXT NOT NULL, start TEXT NOT NULL, end TEXT," +
        " FOREIGN KEY (id) REFERENCES member(id), PRIMARY KEY (id, reason));"
    Const table_unit As String = "CREATE TABLE unit(id_unit INTEGER PRIMARY KEY," +
        " unit_name TEXT UNIQUE NOT NULL);"
    Const table_type As String = "CREATE TABLE type(id_type INTEGER PRIMARY KEY," +
        " type_name TEXT UNIQUE NOT NULL);"

    'Tables schemas to create database, fuck off the verifications
    Public dbSchema() As String = {table_member, table_staff, table_product,
        table_buy, table_money_input, table_total_money, table_blacklist, table_unit, table_type}


    'The connection to the database
    'Also the only reason of why this object exist
    Public dbConnection As SQLiteConnection

    Public Sub New()

        Try
            If Not Directory.Exists(dbFolder) Then
                Directory.CreateDirectory(dbFolder)
            End If

            If Not dbConnect() Then
                MsgBox("Unable to connect to database")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Create the table of the database
    ''' </summary>
    Private Sub createDatabaseSchema()
        Dim command As New SQLiteCommand

        Try
            For Each createRequest As String In dbSchema
                command = dbConnection.CreateCommand
                command.CommandText = createRequest
                command.ExecuteNonQuery()
            Next
            command = dbConnection.CreateCommand
            command.CommandText = "INSERT INTO type(type_name) VALUES ('Drink');"
            command.ExecuteNonQuery()

            command = dbConnection.CreateCommand
            command.CommandText = "INSERT INTO type(type_name) VALUES ('Food');"
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message + "example of speech")
        End Try
    End Sub


    ''' <summary>
    ''' Execute query with result (Like a SELECT)
    ''' </summary>
    ''' <param name="request">Request to be executed</param>
    ''' <returns>Result of the query in SQLiteDataReader</returns>
    Public Function doQuery(ByVal request As String) As SQLiteDataReader
        Dim result As SQLiteDataReader
        Dim myCommand As SQLiteCommand

        Try
            myCommand = dbConnection.CreateCommand
            myCommand.CommandText = request
            result = myCommand.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
            result = Nothing
        End Try


        Return result
    End Function


    ''' <summary>
    ''' Execute sql command with no result (Like UPDATE, INSERT INTO, CREATE, ...)
    ''' </summary>
    ''' <param name="request">The request to execute</param>
    ''' <returns>If it worked true</returns>
    Public Function doNonQuery(ByVal request As String) As Boolean
        Dim command As SQLiteCommand

        Try
            command = dbConnection.CreateCommand
            command.CommandText = request
            command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Connect to the database
    ''' </summary>
    ''' <returns>If worked true</returns>
    Private Function dbConnect() As Boolean
        Dim connexion As String = "Data Source=" + dbPath + "; Integrated Security=true"
        Dim SQLConn As New SQLiteConnection
        Dim rc, exist As Boolean


        If File.Exists(dbPath) Then
            exist = True
        Else
            exist = False
        End If
        Try
            SQLConn.ConnectionString = connexion
            SQLConn.Open()
            rc = True
        Catch ex As Exception
            MsgBox(ex.Message + "What am I doing ?")
            rc = False
        End Try

        dbConnection = SQLConn

        If Not exist Then
            createDatabaseSchema()
        End If

        Return rc
    End Function

    ''' <summary>
    ''' Close the connection with the database
    ''' </summary>
    ''' <returns>If it worked true</returns>
    Public Function dbQuit() As Boolean
        Dim rc As Integer

        Try
            dbConnection.Close()
            rc = True
        Catch ex As Exception
            MsgBox(ex.Message + "totaly useless here")
            rc = False
        End Try

        Return rc
    End Function


    Public Function GetNbType() As Integer
        Dim value As Integer = 0
        Dim countRequest As String = "SELECT COUNT(id_type) FROM type;"

        Dim myCommand As SQLiteCommand

        Try
            myCommand = dbConnection.CreateCommand
            myCommand.CommandText = countRequest
            value = CInt(myCommand.ExecuteScalar())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return value
    End Function

    Public Function GetNbProduct() As Integer
        Dim value As Integer = 0
        Dim countRequest As String = "SELECT COUNT(label) FROM product;"

        Dim myCommand As SQLiteCommand

        Try
            myCommand = dbConnection.CreateCommand
            myCommand.CommandText = countRequest
            value = CInt(myCommand.ExecuteScalar())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return value
    End Function

    Public Function GetNbMember() As Integer
        Dim value As Integer = 0
        Dim countRequest As String = "SELECT COUNT(id) FROM member;"

        Dim myCommand As SQLiteCommand

        Try
            myCommand = dbConnection.CreateCommand
            myCommand.CommandText = countRequest
            value = CInt(myCommand.ExecuteScalar())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return value
    End Function

    Public Function GetNbAdmin() As Integer
        Dim value As Integer = 0
        Dim countRequest As String = "SELECT COUNT(id) FROM staff;"

        Dim myCommand As SQLiteCommand

        Try
            myCommand = dbConnection.CreateCommand
            myCommand.CommandText = countRequest
            value = CInt(myCommand.ExecuteScalar())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return value
    End Function

    Public Function GetUserId(ByVal pseudo As String, ByVal encryptedPassword As String) As Integer
        Dim result As SQLiteDataReader = doQuery("SELECT id, nickname, password FROM member WHERE" +
                                                 " nickname = '" + pseudo + "' AND password" +
                                                 " = '" + encryptedPassword + "';")

        If result.HasRows() Then
            Dim i As Integer = 0
            Dim id As Integer = -1
            For Each record As Object In result
                id = result.GetInt32(result.GetOrdinal("id"))
                i += 1
            Next

            If i = 1 Then
                Return id
            Else
                MsgBox("Error: Many result for the same account, please make a report, or check yourself" +
                       " your database. Number of result : " + i.ToString())
                Return -i
            End If
        Else
            Return -1
        End If
    End Function

    Public Function isAdminUser(ByRef idUser As Integer) As Boolean
        Dim result As SQLiteDataReader = doQuery("SELECT * FROM staff WHERE id = '" + idUser.ToString() + "';")

        If result.HasRows() Then
            Dim i As Integer = 0
            For Each record As Object In result
                i += 1
            Next

            If i = 1 Then
                Return True
            Else
                MsgBox("Error: Many result for the same account, please make a report, or check yourself" +
                       " your database. Number of result : " + i.ToString())
                Return False
            End If
        Else
            Return False
        End If

        Return False
    End Function

    Public Function getStatusUser(ByRef idAdmin As Integer) As String
        Dim result As SQLiteDataReader = doQuery("SELECT status FROM staff WHERE id = " +
                                                 idAdmin.ToString() + ";")

        Dim status As String = "Pascal"
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                status = result.GetString(result.GetOrdinal("status"))
                i += 1
            Next

            If i = 1 Then
                Return status
            Else
                Return "Jews"
            End If
        Else
            Return "Guest"
        End If
    End Function

    Public Function getFirstName(ByRef idUser As Integer) As String
        Dim result As SQLiteDataReader = doQuery("SELECT firstname FROM member WHERE id = " +
                                                 idUser.ToString() + ";")

        Dim firstname As String = "Pascal"
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                firstname = result.GetString(result.GetOrdinal("firstname"))
                i += 1
            Next

            If i = 1 Then
                Return firstname
            Else
                Return "Error: Many name"
            End If
        Else
            Return "Name not found"
        End If
    End Function

    Public Function getName(ByRef idUser As Integer) As String
        Dim result As SQLiteDataReader = doQuery("SELECT name FROM member WHERE id = " +
                                                 idUser.ToString() + ";")

        Dim name As String = "Pascal"
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                Dim nameId As Integer = result.GetOrdinal("name")
                name = result.GetString(nameId)

                i += 1
            Next


            If i = 1 Then
                Return name
            Else
                Return "Error: Many name"
            End If
        Else
            Return "Name not found"
        End If
    End Function

    Public Function getBalance(ByRef idUser As Integer) As Decimal
        Dim result As SQLiteDataReader = doQuery("SELECT balance FROM member WHERE id = " +
                                                 idUser.ToString() + ";")

        Dim balance As Decimal = -20.42
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                balance = result.GetDecimal(result.GetOrdinal("balance"))
                i += 1
            Next

            If i = 1 Then
                Return balance
            Else
                Return -20.42
            End If
        Else
            Return -99999
        End If
    End Function

    Public Function getPoints(ByRef idUser As Integer) As Integer
        Dim result As SQLiteDataReader = doQuery("SELECT points FROM member WHERE id = " +
                                                 idUser.ToString() + ";")

        Dim points As Integer = -99
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                points = result.GetInt32(result.GetOrdinal("points"))
                i += 1
            Next

            If i = 1 Then
                Return points
            Else
                Return -99
            End If
        Else
            Return -99999
        End If
    End Function

    Public Function getStock(ByRef idProduct As Integer) As Integer
        Dim result As SQLiteDataReader = doQuery("SELECT stock FROM product WHERE id_product = " +
                                                 idProduct.ToString() + ";")

        Dim stock As Integer = -99
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                stock = result.GetInt32(result.GetOrdinal("stock"))
                i += 1
            Next

            If i = 1 Then
                Return stock
            Else
                Return -99
            End If
        Else
            Return -99999
        End If
    End Function

    Public Function getAllowNeg(ByRef idUser As Integer) As Integer
        Dim result As SQLiteDataReader = doQuery("SELECT allowneg FROM member WHERE id = " +
                                                 idUser.ToString() + ";")

        Dim allowed As Integer = -1
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                allowed = result.GetInt32(result.GetOrdinal("allowneg"))
                i += 1
            Next

            If i = 1 Then
                Return allowed
            Else
                Return -1
            End If
        Else
            Return -99999
        End If
    End Function


    Public Function getFridge(ByRef idProduct As Integer) As Integer
        Dim result As SQLiteDataReader = doQuery("SELECT fridge FROM product WHERE id_product = " +
                                                 idProduct.ToString() + ";")

        Dim allowed As Integer = -1
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                allowed = result.GetInt32(result.GetOrdinal("fridge"))
                i += 1
            Next

            If i = 1 Then
                Return allowed
            Else
                Return -1
            End If
        Else
            Return -99999
        End If
    End Function

    Public Function getSum() As Decimal
        Dim result As SQLiteDataReader = doQuery("SELECT SUM(money) FROM money_input;")

        Dim sum As Decimal = -1000
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                sum = result.GetDecimal(result.GetOrdinal("SUM(money)"))
                i += 1
            Next

            If i = 1 Then
                Return sum
            Else
                Return -1000
            End If
        Else
            Return -99999
        End If
    End Function


    Public Function doSum() As Boolean
        Dim rc As Boolean = True

        Dim sum As Decimal = getSum()

        doNonQuery("INSERT INTO total_money(money, date) VALUES (" + sum.ToString.Replace(",", ".") +
                   ", '" + Today.ToString() + "');")

        Return rc
    End Function

    Public Function getIdFromQuery(ByVal request As String) As Integer
        Dim rc = -1

        Dim myCommand As SQLiteCommand

        Try
            myCommand = dbConnection.CreateCommand
            myCommand.CommandText = request
            rc = CInt(myCommand.ExecuteScalar())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return rc
    End Function

    Public Function getIdProdFromQuery(ByVal request As String) As Integer
        Dim rc = -1

        Dim myCommand As SQLiteCommand

        Try
            myCommand = dbConnection.CreateCommand
            myCommand.CommandText = request
            rc = CInt(myCommand.ExecuteScalar())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return rc
    End Function

    Public Sub insertTransaction(ByVal value As Decimal)
        If value <> 0 Then
            doQuery("INSERT INTO money_input(money) VALUES (" + value.ToString().Replace(",", ".") + ");")
        End If

    End Sub

    Public Function getListAdmin() As Integer()
        Dim nbAdmin As Integer = GetNbAdmin()
        Dim rc(nbAdmin) As Integer
        Dim i As Integer = 0

        Dim result As SQLiteDataReader = doQuery("SELECT id FROM staff;")
        Dim index As Integer = result.GetOrdinal("id")

        While result.Read()
            rc(i) = result.GetInt32(0)

            i += 1
        End While

        Return rc
    End Function

    Public Function getListNicknameAdmin() As String()
        Dim nbAdmin As Integer = GetNbAdmin()
        If nbAdmin > 0 Then
            Dim rc(nbAdmin - 1) As String
            Dim i As Integer = 0

            Dim result As SQLiteDataReader = doQuery("SELECT nickname FROM staff, member WHERE member.id = staff.id;")
            Dim index As Integer = result.GetOrdinal("nickname")

            While result.Read()
                rc(i) = result.GetString(0)

                i += 1
            End While

            Return rc
        Else
            Return Nothing
        End If

    End Function

    Public Function getListNickname() As String()
        Dim nbUser As Integer = GetNbMember()
        If nbUser > 0 Then
            Dim rc(nbUser - 1) As String
            Dim i As Integer = 0

            Dim result As SQLiteDataReader = doQuery("SELECT nickname FROM member;")
            Dim index As Integer = result.GetOrdinal("nickname")

            While result.Read()
                rc(i) = result.GetString(0)

                i += 1
            End While

            Return rc
        Else
            Return Nothing
        End If

    End Function

    Public Function getListType() As String()
        Dim nbType As Integer = GetNbType()

        Dim rc(nbType - 1) As String
        Dim i As Integer = 0

        Dim result As SQLiteDataReader = doQuery("SELECT type_name FROM type;")
        Dim index As Integer = result.GetOrdinal("type_name")

        While result.Read()
            rc(i) = result.GetString(0)

            i += 1
        End While

        Return rc
    End Function

    Public Function getListProduct() As String()
        Dim nbProduct As Integer = GetNbProduct()

        Dim rc(nbProduct - 1) As String
        Dim i As Integer = 0

        Dim result As SQLiteDataReader = doQuery("SELECT label FROM product;")
        Dim index As Integer = result.GetOrdinal("label")

        While result.Read()
            rc(i) = result.GetString(0)

            i += 1
        End While

        Return rc
    End Function


    Public Function getIdFromString(ByVal text As String) As Integer
        Dim idUser As Integer = -1

        If IsNumeric(text) Then
            idUser = CInt(text)
        Else
            If SPLASH.theDatabase.doQuery("SELECT id FROM member WHERE nickname = '" + text + "';").HasRows() Then
                idUser = SPLASH.theDatabase.getIdFromQuery("SELECT id FROM member WHERE nickname = '" +
                                          text + "';")
            ElseIf SPLASH.theDatabase.doQuery("SELECT id FROM member WHERE email = '" + text + "';").HasRows() Then
                idUser = SPLASH.theDatabase.getIdFromQuery("SELECT id FROM member WHERE email = '" + text + "';")
            Else
                MsgBox("Unexisting user")
            End If
        End If

        Return idUser
    End Function

    Public Function getIdProdFromString(ByVal text As String) As Integer
        Dim idProduct As Integer = -1

        If IsNumeric(text) Then
            idProduct = CInt(text)
        Else
            If SPLASH.theDatabase.doQuery("SELECT id_product FROM product WHERE label = '" + text + "';").HasRows() Then
                idProduct = SPLASH.theDatabase.getIdProdFromQuery("SELECT id_product FROM product WHERE label = '" +
                                          text + "';")
            Else
                MsgBox("Unexisting product")
            End If
        End If

        Return idProduct
    End Function

    Public Function getNickname(ByRef idUser As Integer) As String
        Dim result As SQLiteDataReader = doQuery("SELECT nickname FROM member WHERE id = " +
                                                 idUser.ToString() + ";")

        Dim nickname As String = "Pascal"
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                nickname = result.GetString(result.GetOrdinal("nickname"))
                i += 1
            Next

            If i = 1 Then
                Return nickname
            Else
                Return "Error: Many name"
            End If
        Else
            Return "Name not found"
        End If
    End Function

    Public Function getLabel(ByRef idProduct As Integer) As String
        Dim result As SQLiteDataReader = doQuery("SELECT label FROM product WHERE id_product = " +
                                                 idProduct.ToString() + ";")

        Dim label As String = "Caca"
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                label = result.GetString(result.GetOrdinal("label"))
                i += 1
            Next

            If i = 1 Then
                Return label
            Else
                Return "Error: Many label"
            End If
        Else
            Return "Label not found"
        End If
    End Function

    Public Function getPriceBuy(ByRef idProduct As Integer) As Decimal
        Dim result As SQLiteDataReader = doQuery("SELECT price_buy FROM product WHERE id_product = " +
                                                 idProduct.ToString() + ";")

        Dim price As Decimal = -1
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                price = result.GetDecimal(result.GetOrdinal("price_buy"))
                i += 1
            Next

            If i = 1 Then
                Return price
            Else
                Return "Error: Many price"
            End If
        Else
            Return "Price not found"
        End If
    End Function

    Public Function getPriceSell(ByRef idProduct As Integer) As Decimal
        Dim result As SQLiteDataReader = doQuery("SELECT price_sell FROM product WHERE id_product = " +
                                                 idProduct.ToString() + ";")

        Dim price As Decimal = -1
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                price = result.GetDecimal(result.GetOrdinal("price_sell"))
                i += 1
            Next

            If i = 1 Then
                Return price
            Else
                Return "Error: Many price"
            End If
        Else
            Return "Price not found"
        End If
    End Function

    Public Function getPricePoint(ByRef idProduct As Integer) As Integer
        Dim result As SQLiteDataReader = doQuery("SELECT price_point FROM product WHERE id_product = " +
                                                 idProduct.ToString() + ";")

        Dim price As Integer = -1
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                price = result.GetInt32(result.GetOrdinal("price_point"))
                i += 1
            Next

            If i = 1 Then
                Return price
            Else
                Return "Error: Many price"
            End If
        Else
            Return "Price not found"
        End If
    End Function

    Public Function getValuePoint(ByRef idProduct As Integer) As Integer
        Dim result As SQLiteDataReader = doQuery("SELECT value_point FROM product WHERE id_product = " +
                                                 idProduct.ToString() + ";")

        Dim price As Integer = -1
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                price = result.GetInt32(result.GetOrdinal("value_point"))
                i += 1
            Next

            If i = 1 Then
                Return price
            Else
                Return "Error: Many price"
            End If
        Else
            Return "Price not found"
        End If
    End Function

    Public Function getPhoneNumber(ByRef idUser As Integer) As String
        Dim result As SQLiteDataReader = doQuery("SELECT phonenumber FROM member WHERE id = " +
                                                 idUser.ToString() + ";")

        Dim phonenumber As String = "Pascal"
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                phonenumber = result.GetString(result.GetOrdinal("phonenumber"))
                i += 1
            Next

            If i = 1 Then
                Return phonenumber
            Else
                Return "Error: Many name"
            End If
        Else
            Return "Name not found"
        End If
    End Function

    Public Function isAvailablePhonenumber(ByVal phonenumber As String) As Boolean
        Dim result As SQLiteDataReader = doQuery("SELECT id FROM member WHERE phonenumber = '" + phonenumber + "';")

        If result.HasRows() Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function isAvailableLabel(ByVal label As String) As Boolean
        Dim result As SQLiteDataReader = doQuery("SELECT id_product FROM product WHERE label = '" + label + "';")

        If result.HasRows() Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function isAvailableNickname(ByVal nickname As String) As Boolean
        Dim result As SQLiteDataReader = doQuery("SELECT id FROM member WHERE nickname = '" + nickname + "';")

        If result.HasRows() Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function isAvailableEmail(ByVal email As String) As Boolean
        Dim result As SQLiteDataReader = doQuery("SELECT id FROM member WHERE email = '" + email + "';")

        If result.HasRows() Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function getEmail(ByRef idUser As Integer) As String
        Dim result As SQLiteDataReader = doQuery("SELECT email FROM member WHERE id = " +
                                                 idUser.ToString() + ";")

        Dim email As String = "Pascal"
        Dim i As Integer = 0

        If result.HasRows() Then
            For Each record In result
                email = result.GetString(result.GetOrdinal("email"))
                i += 1
            Next

            If i = 1 Then
                Return email
            Else
                Return "Error: Many name"
            End If
        Else
            Return "Name not found"
        End If
    End Function

    Public Function isAdmin(ByVal nickname As String) As Boolean
        Dim idAdmin = getIdFromQuery("SELECT id FROM member WHERE nickname = '" + nickname + "';")
        Dim rc As Boolean = False
        Dim myCommand As SQLiteCommand

        Try
            myCommand = dbConnection.CreateCommand
            myCommand.CommandText = "SELECT id FROM staff WHERE id = " + idAdmin.ToString() + ";"
            Dim value As Integer = myCommand.ExecuteScalar()
            If value > 0 Then
                rc = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If rc Then
            Return True
        Else
            Return False
        End If
    End Function
End Class

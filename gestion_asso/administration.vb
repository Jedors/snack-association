Imports System.ComponentModel

Public Class administration
    Private Sub administration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = SPLASH.theConfig.OrganisationName + " - " + SPLASH.theConfig._Administration
        Me.TP_MEMBER.Text = SPLASH.theConfig._User
        Me.LB_NICKNAME.Text = SPLASH.theConfig._Nickname
        Me.LB_NAME.Text = SPLASH.theConfig._Name
        Me.LB_FIRSTNAME.Text = SPLASH.theConfig._FirstName
        Me.LB_PASSWORD.Text = SPLASH.theConfig._Password
        Me.LB_PASSAGAIN.Text = SPLASH.theConfig._PasswordAgain
        Me.LB_PHONENUMBER.Text = SPLASH.theConfig._PhoneNumber
        Me.LB_EMAIL.Text = SPLASH.theConfig._Email
        Me.LB_BALANCE.Text = SPLASH.theConfig._Balance
        Me.LB_POINTS.Text = SPLASH.theConfig._Points
        Me.CBX_ALLOWNEG.Text = SPLASH.theConfig._AllowNeg
        Me.BT_MEM_CONFIRM.Text = SPLASH.theConfig._Confirm
        Me.TP_ADMIN.Text = SPLASH.theConfig._Admin
        Me.LB_STATUS.Text = SPLASH.theConfig._Status
        Me.BT_ADM_CONFIRM.Text = SPLASH.theConfig._Confirm
        Me.TP_CREDIT.Text = SPLASH.theConfig._Credit + "/" + SPLASH.theConfig._Debit
        Me.RB_CREDIT.Text = SPLASH.theConfig._Credit
        Me.RB_DEBIT.Text = SPLASH.theConfig._Debit
        Me.TP_PRODUCT.Text = SPLASH.theConfig._Product
        Me.LB_LABEL.Text = SPLASH.theConfig._Label
        Me.LB_PRICEBUY.Text = SPLASH.theConfig._PriceBuy
        Me.LB_PRICESELL.Text = SPLASH.theConfig._PriceSell
        Me.LB_PRICEPOINT.Text = SPLASH.theConfig._PricePoint
        Me.LB_VALUEPOINT.Text = SPLASH.theConfig._ValuePoint
        Me.LB_STOCK.Text = SPLASH.theConfig._Stock
        Me.CBX_FRIDGE.Text = SPLASH.theConfig._Fridge
        Me.BT_PROD_CONFIRM.Text = SPLASH.theConfig._Confirm
        Me.TP_STOCK.Text = SPLASH.theConfig._Stock
        Me.TP_MONEY.Text = SPLASH.theConfig._Money
        Me.BT_ADD_TRANSAC.Text = SPLASH.theConfig._InsertTransaction
        Me.BT_DO_SUM.Text = SPLASH.theConfig._RecordSum
        Me.BT_CONFIRM.Text = SPLASH.theConfig._Confirm

        Me.CB_REMOVE_ADMIN.Items.Clear()
        If SPLASH.theDatabase.GetNbAdmin() > 0 Then
            For Each nickname As String In SPLASH.theDatabase.getListNicknameAdmin()
                Me.CB_REMOVE_ADMIN.Items.Add(nickname)
            Next
        End If

        Me.CB_SELECT_USER.Items.Clear()
        If SPLASH.theDatabase.GetNbMember() > 0 Then
            For Each nickname As String In SPLASH.theDatabase.getListNickname()
                Me.CB_SELECT_USER.Items.Add(nickname)
            Next
        End If

        Me.CB_TYPE.Items.Clear()
        If SPLASH.theDatabase.GetNbType() > 0 Then
            For Each type As String In SPLASH.theDatabase.getListType()
                Me.CB_TYPE.Items.Add(type)
            Next
        End If

        Me.CB_PRODUCT_MOD.Items.Clear()
        If SPLASH.theDatabase.GetNbProduct() > 0 Then
            For Each product As String In SPLASH.theDatabase.getListProduct()
                Me.CB_PRODUCT_MOD.Items.Add(product)
            Next
        End If
    End Sub

    Private Sub BT_ADD_TRANSAC_Click(sender As Object, e As EventArgs) Handles BT_ADD_TRANSAC.Click
        Dim valeur As Decimal = 0

        If IsNumeric(Me.TXT_MONEY.Text.Replace(",", "").Replace(".", "").Replace("-", "")) Then
            valeur = CDec(Me.TXT_MONEY.Text)
        Else
            MsgBox("Error: invalid value")
        End If



        If valeur <> 0 Then
            Try
                SPLASH.theDatabase.doNonQuery("INSERT INTO money_input(money) VALUES (" +
                                              valeur.ToString().Replace(",", ".") + ");")
                MsgBox("Recorded transaction !")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Can't use null value")
        End If

        Me.TXT_MONEY.Text = ""

    End Sub

    Private Sub BT_DO_SUM_Click(sender As Object, e As EventArgs) Handles BT_DO_SUM.Click
        If SPLASH.theDatabase.doSum() Then
            MsgBox("The total have been correctly recorded")
        Else
            MsgBox("Error: Unable to store the total")
        End If
    End Sub

    Private Sub BT_CONFIRM_Click(sender As Object, e As EventArgs) Handles BT_CONFIRM.Click
        Dim valeur As Decimal = 0
        If IsNumeric(Me.TXT_VALUE.Text.Replace(",", ".")) Then
            valeur = CDec(Me.TXT_VALUE.Text.Replace(",", "."))
        Else
            MsgBox("Error: invalid value")
        End If

        Dim idUser As Integer = -1

        If IsNumeric(Me.TXT_CRED_ID.Text) Then
            idUser = CInt(Me.TXT_CRED_ID.Text)
        Else
            If SPLASH.theDatabase.doQuery("SELECT id FROM member WHERE nickname = '" +
                                          Me.TXT_CRED_ID.Text + "';").HasRows() Then
                idUser = SPLASH.theDatabase.getIdFromQuery("SELECT id FROM member WHERE nickname = '" +
                                          Me.TXT_CRED_ID.Text + "';")
            ElseIf SPLASH.theDatabase.doQuery("SELECT id FROM member WHERE email = '" +
                                          Me.TXT_CRED_ID.Text + "';").HasRows() Then
                idUser = SPLASH.theDatabase.getIdFromQuery("SELECT id FROM member WHERE email = '" +
                                          Me.TXT_CRED_ID.Text + "';")
            Else
                MsgBox("Unexisting user")
            End If
        End If

        If idUser <> -1 Then
            Dim balance As Decimal = SPLASH.theDatabase.getBalance(idUser)

            If Me.RB_CREDIT.Checked Then
                SPLASH.theDatabase.doNonQuery("UPDATE member SET balance = " +
                                              (balance + valeur).ToString().Replace(",", ".") +
                                              " WHERE id = " + idUser.ToString() + ";")
                SPLASH.theDatabase.insertTransaction(valeur)

                MsgBox("Account corretly credited")
            ElseIf Me.RB_DEBIT.Checked Then
                SPLASH.theDatabase.doNonQuery("UPDATE member SET balance = " +
                                              (balance - valeur).ToString().Replace(",", ".") +
                                              " WHERE id = " + idUser.ToString() + ";")
                SPLASH.theDatabase.insertTransaction(-valeur)

                MsgBox("Account corretly debited")
            Else
                MsgBox("Error: No radio button checked")
            End If
        Else
            MsgBox("Invalid user")
        End If

    End Sub

    Private Sub CB_ADMIN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ADMIN.SelectedIndexChanged
        If Me.CB_ADMIN.GetItemText(Me.CB_ADMIN.SelectedItem) = "Ajouter" Then
            Me.LB_ADM_TEXT.Visible = True
            Me.CB_REMOVE_ADMIN.Visible = False
            Me.TXT_ID.Visible = True
            Me.LB_STATUS.Visible = True
            Me.TXT_STATUS.Visible = True
            Me.BT_ADM_CONFIRM.Visible = True
        ElseIf Me.CB_ADMIN.GetItemText(Me.CB_ADMIN.SelectedItem) = "Supprimer" Then
            Me.LB_ADM_TEXT.Visible = False
            Me.CB_REMOVE_ADMIN.Visible = True
            Me.TXT_ID.Visible = False
            Me.LB_STATUS.Visible = False
            Me.TXT_STATUS.Visible = False
            Me.BT_ADM_CONFIRM.Visible = True
        Else
            Me.LB_ADM_TEXT.Visible = False
            Me.CB_REMOVE_ADMIN.Visible = False
            Me.TXT_ID.Visible = False
            Me.LB_STATUS.Visible = False
            Me.TXT_STATUS.Visible = False
            Me.BT_ADM_CONFIRM.Visible = False
        End If
    End Sub

    Private Sub BT_ADM_CONFIRM_Click(sender As Object, e As EventArgs) Handles BT_ADM_CONFIRM.Click
        If Me.CB_ADMIN.GetItemText(Me.CB_ADMIN.SelectedItem) = "Ajouter" Then
            Dim idUser As Integer = SPLASH.theDatabase.getIdFromString(Me.TXT_ID.Text)
            If Not SPLASH.theDatabase.isAdmin(Me.TXT_ID.Text) Then
                If Not SPLASH.theDatabase.doNonQuery("INSERT INTO staff(id, status) VALUES (" +
                                                                 idUser.ToString() + ", '" + Me.TXT_STATUS.Text + "');") Then
                    MsgBox("Error: adding user to admin tab")
                Else
                    MsgBox(Me.TXT_ID.Text + " have correctly been promoted as " + Me.TXT_STATUS.Text)
                    Me.TXT_ID.Text = ""
                    Me.TXT_STATUS.Text = ""

                    Me.CB_REMOVE_ADMIN.Items.Clear()
                    If SPLASH.theDatabase.GetNbAdmin() > 0 Then
                        For Each nickname As String In SPLASH.theDatabase.getListNicknameAdmin()
                            Me.CB_REMOVE_ADMIN.Items.Add(nickname)
                        Next
                    End If

                End If
            Else
                MsgBox("This user is already admin")
            End If
        ElseIf Me.CB_ADMIN.GetItemText(Me.CB_ADMIN.SelectedItem) = "Supprimer" Then
            If SPLASH.theDatabase.isAdmin(Me.CB_REMOVE_ADMIN.GetItemText(Me.CB_REMOVE_ADMIN.SelectedItem)) Then

                Dim idAdmin As Integer = SPLASH.theDatabase.getIdFromQuery("SELECT id FROM member WHERE" +
                                                                           " nickname = '" +
                                                                           Me.CB_REMOVE_ADMIN.GetItemText(Me.CB_REMOVE_ADMIN.SelectedItem) + "';")

                If Not SPLASH.theDatabase.doNonQuery("DELETE FROM staff WHERE id = " + idAdmin.ToString() + ";") Then
                    MsgBox("Error while removing the admin")
                Else
                    MsgBox(Me.CB_REMOVE_ADMIN.GetItemText(Me.CB_REMOVE_ADMIN.SelectedItem) + " isn't admin anymore")

                    Me.CB_REMOVE_ADMIN.Items.Clear()
                    If SPLASH.theDatabase.GetNbAdmin() > 0 Then
                        For Each nickname As String In SPLASH.theDatabase.getListNicknameAdmin()
                            Me.CB_REMOVE_ADMIN.Items.Add(nickname)
                        Next
                    End If

                End If
            Else
                MsgBox("Error: Non admin user")
            End If
        Else
            MsgBox("Da fuck bruh ?")
        End If
    End Sub

    Private Sub BT_MEM_CONFIRM_Click(sender As Object, e As EventArgs) Handles BT_MEM_CONFIRM.Click
        If Me.CB_MEMBER.GetItemText(Me.CB_MEMBER.SelectedItem) = "Supprimer" Then
            Dim idUser As Integer = SPLASH.theDatabase.getIdFromString(Me.TXT_REMOVE_USER.Text)
            Dim nickname As String = SPLASH.theDatabase.getNickname(idUser)
            If idUser <> -1 Then
                If Not SPLASH.theDatabase.doNonQuery("DELETE FROM member WHERE id = " + idUser.ToString() + ";") Then
                    MsgBox("Error: Unable to remove user from database")
                Else
                    MsgBox(nickname + " have correctly been removed")
                    Me.TXT_REMOVE_USER.Text = ""

                    Me.CB_SELECT_USER.Items.Clear()
                    If SPLASH.theDatabase.GetNbMember() > 0 Then
                        For Each nicknameUser As String In SPLASH.theDatabase.getListNickname()
                            Me.CB_SELECT_USER.Items.Add(nicknameUser)
                        Next
                    End If


                End If
                If SPLASH.theDatabase.isAdmin(nickname) Then
                    SPLASH.theDatabase.doNonQuery("DELETE FROM staff WHERE id = " + idUser.ToString() + ";")
                End If
            Else
                MsgBox("Unexisting user")
            End If
        ElseIf Me.CB_MEMBER.GetItemText(Me.CB_MEMBER.SelectedItem) = "Ajouter" Then
            Dim canPerform As Boolean = True

            If Me.TXT_NICKNAME.Text <> "" Then
                If Not SPLASH.theDatabase.isAvailableNickname(Me.TXT_NICKNAME.Text) Then
                    canPerform = False
                    MsgBox("This nickname already exist")
                End If
            Else
                canPerform = False
                MsgBox("Please fill nickname field")
            End If

            If Me.TXT_NAME.Text = "" Then
                canPerform = False
                MsgBox("Name can't be empty")
            End If

            If Me.TXT_FIRSTNAME.Text = "" Then
                canPerform = False
                MsgBox("First name can't be empty")
            End If

            If Me.TXT_PASSAGAIN.Text <> Me.TXT_PASSWORD.Text Then
                canPerform = False
                MsgBox("Passwords doesn't match")
            End If

            If IsNumeric(Me.TXT_PHONENUMBER.Text) Or Me.TXT_PHONENUMBER.Text = "" Then
                If Me.TXT_PHONENUMBER.Text <> "" And Not SPLASH.theDatabase.isAvailablePhonenumber(Me.TXT_PHONENUMBER.Text) Then
                    canPerform = False
                    MsgBox("This phonenumber already exist")
                End If
            Else
                canPerform = False
                MsgBox("This phonenumber isn't a number")
            End If

            If Me.TXT_EMAIL.Text <> "" Then
                If Not SPLASH.theDatabase.isAvailableEmail(Me.TXT_EMAIL.Text) Then
                    canPerform = False
                    MsgBox("This email already exist into the database")
                End If
            Else
                canPerform = False
                MsgBox("Email field must be filled")
            End If

            Me.TXT_BALANCE.Text = Me.TXT_BALANCE.Text.Replace(",", ".")
            If Not IsNumeric(Me.TXT_BALANCE.Text.Replace(".", "")) Then
                canPerform = False
                MsgBox("Balance entered isn't a number")
            End If


            If Me.TXT_BALANCE.Text = "" Then
                Me.TXT_BALANCE.Text = "0"
            End If

            If Me.TXT_POINTS.Text = "" Then
                Me.TXT_POINTS.Text = "0"
            End If

            If Not IsNumeric(Me.TXT_POINTS.Text) Then
                canPerform = False
                MsgBox("Points entered aren't number")
            End If


            If canPerform Then
                Dim allowed As Integer = 0
                If Me.CBX_ALLOWNEG.Checked = True Then
                    allowed = 1
                End If

                'On m'a dis que les commentaires c'est cool. Voilà
                Dim request As String = "INSERT INTO member(nickname, name, firstname, email," +
                    " phonenumber, password, balance, points, allowneg) VALUES ('" + Me.TXT_NICKNAME.Text +
                    "', '" + Me.TXT_NAME.Text + "', '" + Me.TXT_FIRSTNAME.Text + "', '" + Me.TXT_EMAIL.Text + "', '" +
                    Me.TXT_PHONENUMBER.Text + "', '" + SPLASH.theConfig.hashGen(Me.TXT_PASSWORD.Text,
                                                                              Me.TXT_NICKNAME.Text) + "', " +
                                                                              Me.TXT_BALANCE.Text + ", " +
                                                                              Me.TXT_POINTS.Text + ", " +
                                                                              allowed.ToString() + ");"

                If Not SPLASH.theDatabase.doNonQuery(request) Then
                    MsgBox("Error: Unable to create user")
                Else
                    Dim value As Decimal = Me.TXT_BALANCE.Text.Replace(".", ",")
                    If value > 0 Then
                        SPLASH.theDatabase.insertTransaction(value)
                    End If

                    MsgBox("User correctly recorded !")

                    Me.CB_SELECT_USER.Items.Clear()
                    If SPLASH.theDatabase.GetNbMember() > 0 Then
                        For Each nickname As String In SPLASH.theDatabase.getListNickname()
                            Me.CB_SELECT_USER.Items.Add(nickname)
                        Next
                    End If
                End If
            Else
                MsgBox("User not created")
            End If
        ElseIf Me.CB_MEMBER.GetItemText(Me.CB_MEMBER.SelectedItem) = "Modifier" Then
            Dim canPerform As Boolean = True

            If Me.TXT_NAME.Text = "" Then
                canPerform = False
                MsgBox("Name can't be empty")
            End If

            If Me.TXT_FIRSTNAME.Text = "" Then
                canPerform = False
                MsgBox("First name can't be empty")
            End If

            If Me.TXT_PASSAGAIN.Text <> Me.TXT_PASSWORD.Text Then
                canPerform = False
                MsgBox("Passwords doesn't match")
            End If

            If IsNumeric(Me.TXT_PHONENUMBER.Text) Or Me.TXT_PHONENUMBER.Text = "" Then
                Dim idUser = SPLASH.theDatabase.getIdFromString(Me.CB_SELECT_USER.GetItemText(Me.CB_SELECT_USER.SelectedItem))
                If Me.TXT_PHONENUMBER.Text <> "" And Not SPLASH.theDatabase.isAvailablePhonenumber(Me.TXT_PHONENUMBER.Text) And
                    Me.TXT_PHONENUMBER.Text <> SPLASH.theDatabase.getPhoneNumber(idUser) Then
                    canPerform = False
                    MsgBox("This phonenumber already exist")
                End If
            Else
                canPerform = False
                MsgBox("This phonenumber isn't a number")
            End If

            Me.TXT_BALANCE.Text = Me.TXT_BALANCE.Text.Replace(",", ".")
            If Me.TXT_BALANCE.Text = "" Then
                Me.TXT_BALANCE.Text = "0"
            End If

            If Not IsNumeric(Me.TXT_BALANCE.Text.Replace(".", "")) Then
                canPerform = False
                MsgBox("Balance entered isn't a number")
            End If

            If Me.TXT_POINTS.Text = "" Then
                Me.TXT_POINTS.Text = "0"
            End If

            If Not IsNumeric(Me.TXT_POINTS.Text) Then
                canPerform = False
                MsgBox("Points entered aren't number")
            End If

            If canPerform Then
                Dim allowed As Integer = 0
                If Me.CBX_ALLOWNEG.Checked = True Then
                    allowed = 1
                End If

                Dim request As String = "UPDATE member SET name = '" & Me.TXT_NAME.Text & "', firstname = '" &
                                                     Me.TXT_FIRSTNAME.Text & "', "

                If Me.TXT_PASSWORD.Text <> "" Then
                    request = request & "password = '" & SPLASH.theConfig.hashGen(Me.TXT_PASSWORD.Text, Me.TXT_NICKNAME.Text) &
                        "', "
                End If

                request = request & "phonenumber = '" & Me.TXT_PHONENUMBER.Text & "', balance = " &
                    Me.TXT_BALANCE.Text.Replace(",", ".") & ", points = " & Me.TXT_POINTS.Text &
                    ", allowneg = " & allowed & " WHERE nickname = '" & Me.TXT_NICKNAME.Text & "';"

                If Not SPLASH.theDatabase.doNonQuery(request) Then
                    MsgBox("Unable to update user")
                End If

            Else
                MsgBox("User not updated")
            End If

        Else
            MsgBox("You just brained the game bruh")
        End If
    End Sub

    Private Sub CB_MEMBER_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_MEMBER.SelectedIndexChanged
        If Me.CB_MEMBER.GetItemText(Me.CB_MEMBER.SelectedItem) = "Supprimer" Then
            Me.CB_SELECT_USER.Visible = False
            Me.LB_REMOVE_USER.Visible = True
            Me.LB_NICKNAME.Visible = False
            Me.LB_FIRSTNAME.Visible = False
            Me.LB_NAME.Visible = False
            Me.LB_PASSWORD.Visible = False
            Me.LB_PASSAGAIN.Visible = False
            Me.LB_PHONENUMBER.Visible = False
            Me.LB_EMAIL.Visible = False
            Me.LB_BALANCE.Visible = False
            Me.LB_POINTS.Visible = False
            Me.CBX_ALLOWNEG.Visible = False
            Me.BT_MEM_CONFIRM.Visible = True
            Me.TXT_REMOVE_USER.Visible = True
            Me.TXT_NICKNAME.Visible = False
            Me.TXT_NICKNAME.ReadOnly = False
            Me.TXT_FIRSTNAME.Visible = False
            Me.TXT_NAME.Visible = False
            Me.TXT_PASSWORD.Visible = False
            Me.TXT_PASSAGAIN.Visible = False
            Me.TXT_PHONENUMBER.Visible = False
            Me.TXT_EMAIL.Visible = False
            Me.TXT_BALANCE.Visible = False
            Me.TXT_POINTS.Visible = False
            Me.TXT_EMAIL.ReadOnly = False
        ElseIf Me.CB_MEMBER.GetItemText(Me.CB_MEMBER.SelectedItem) = "Ajouter" Then
            Me.CB_SELECT_USER.Visible = False
            Me.LB_REMOVE_USER.Visible = False
            Me.LB_NICKNAME.Visible = True
            Me.LB_FIRSTNAME.Visible = True
            Me.LB_NAME.Visible = True
            Me.LB_PASSWORD.Visible = True
            Me.LB_PASSAGAIN.Visible = True
            Me.LB_PHONENUMBER.Visible = True
            Me.LB_EMAIL.Visible = True
            Me.LB_BALANCE.Visible = True
            Me.LB_POINTS.Visible = True
            Me.CBX_ALLOWNEG.Visible = True
            Me.BT_MEM_CONFIRM.Visible = True
            Me.TXT_REMOVE_USER.Visible = False
            Me.TXT_NICKNAME.Visible = True
            Me.TXT_NICKNAME.ReadOnly = False
            Me.TXT_FIRSTNAME.Visible = True
            Me.TXT_NAME.Visible = True
            Me.TXT_PASSWORD.Visible = True
            Me.TXT_PASSAGAIN.Visible = True
            Me.TXT_PHONENUMBER.Visible = True
            Me.TXT_EMAIL.Visible = True
            Me.TXT_BALANCE.Visible = True
            Me.TXT_POINTS.Visible = True
            Me.TXT_EMAIL.ReadOnly = False
        ElseIf Me.CB_MEMBER.GetItemText(Me.CB_MEMBER.SelectedItem) = "Modifier" Then
            Me.CB_SELECT_USER.Visible = True
            Me.LB_REMOVE_USER.Visible = False
            Me.LB_NICKNAME.Visible = True
            Me.LB_FIRSTNAME.Visible = True
            Me.LB_NAME.Visible = True
            Me.LB_PASSWORD.Visible = True
            Me.LB_PASSAGAIN.Visible = True
            Me.LB_PHONENUMBER.Visible = True
            Me.LB_EMAIL.Visible = True
            Me.LB_BALANCE.Visible = True
            Me.LB_POINTS.Visible = True
            Me.CBX_ALLOWNEG.Visible = True
            Me.BT_MEM_CONFIRM.Visible = True
            Me.TXT_REMOVE_USER.Visible = False
            Me.TXT_NICKNAME.Visible = True
            Me.TXT_NICKNAME.ReadOnly = True
            Me.TXT_FIRSTNAME.Visible = True
            Me.TXT_NAME.Visible = True
            Me.TXT_PASSWORD.Visible = True
            Me.TXT_PASSAGAIN.Visible = True
            Me.TXT_PHONENUMBER.Visible = True
            Me.TXT_EMAIL.Visible = True
            Me.TXT_BALANCE.Visible = True
            Me.TXT_POINTS.Visible = True
            Me.TXT_EMAIL.ReadOnly = True
        Else
            MsgBox("Bruh bruh bruh...")
        End If
    End Sub

    Private Sub administration_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        home.Show()
    End Sub

    Private Sub CB_SELECT_USER_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_SELECT_USER.SelectedIndexChanged
        Dim idUser = SPLASH.theDatabase.getIdFromString(Me.CB_SELECT_USER.GetItemText(Me.CB_SELECT_USER.SelectedItem))

        If idUser <> -1 Then
            Me.TXT_NICKNAME.Text = SPLASH.theDatabase.getNickname(idUser)
            Me.TXT_NAME.Text = SPLASH.theDatabase.getName(idUser)
            Me.TXT_FIRSTNAME.Text = SPLASH.theDatabase.getFirstName(idUser)
            Me.TXT_PHONENUMBER.Text = SPLASH.theDatabase.getPhoneNumber(idUser)
            Me.TXT_BALANCE.Text = SPLASH.theDatabase.getBalance(idUser).ToString()
            Me.TXT_POINTS.Text = SPLASH.theDatabase.getPoints(idUser).ToString()
            Me.TXT_PASSWORD.Text = ""
            Me.TXT_PASSAGAIN.Text = ""
            Me.TXT_EMAIL.Text = SPLASH.theDatabase.getEmail(idUser)
            Dim allowed As Integer = SPLASH.theDatabase.getAllowNeg(idUser)
            If allowed = 1 Then
                Me.CBX_ALLOWNEG.Checked = True
            Else
                Me.CBX_ALLOWNEG.Checked = False
            End If

        End If
    End Sub

    Private Sub CB_PRODUCT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PRODUCT.SelectedIndexChanged
        If Me.CB_PRODUCT.GetItemText(Me.CB_PRODUCT.SelectedItem) = "Ajouter" Then
            Me.LB_REMOVE_PRODUCT.Visible = False
            Me.LB_LABEL.Visible = True
            Me.LB_PRICESELL.Visible = True
            Me.LB_PRICEBUY.Visible = True
            Me.LB_PRICEPOINT.Visible = True
            Me.LB_VALUEPOINT.Visible = True
            Me.LB_STOCK.Visible = True
            Me.CBX_FRIDGE.Visible = True
            Me.CB_TYPE.Visible = True
            Me.TXT_REMOVE_PRODUCT.Visible = False
            Me.TXT_LABEL.Visible = True
            Me.TXT_PRICEBUY.Visible = True
            Me.TXT_PRICESELL.Visible = True
            Me.TXT_PRICEPOINT.Visible = True
            Me.TXT_VALUEPOINT.Visible = True
            Me.TXT_STOCK.Visible = True
            Me.BT_PROD_CONFIRM.Visible = True
            Me.TXT_LABEL.ReadOnly = False
            Me.CB_PRODUCT_MOD.Visible = False
        ElseIf Me.CB_PRODUCT.GetItemText(Me.CB_PRODUCT.SelectedItem) = "Modifier" Then
            Me.LB_REMOVE_PRODUCT.Visible = False
            Me.LB_LABEL.Visible = True
            Me.LB_PRICESELL.Visible = True
            Me.LB_PRICEBUY.Visible = True
            Me.LB_PRICEPOINT.Visible = True
            Me.LB_VALUEPOINT.Visible = True
            Me.LB_STOCK.Visible = True
            Me.CBX_FRIDGE.Visible = True
            Me.CB_TYPE.Visible = True
            Me.TXT_REMOVE_PRODUCT.Visible = False
            Me.TXT_LABEL.Visible = True
            Me.TXT_PRICEBUY.Visible = True
            Me.TXT_PRICESELL.Visible = True
            Me.TXT_PRICEPOINT.Visible = True
            Me.TXT_VALUEPOINT.Visible = True
            Me.TXT_STOCK.Visible = True
            Me.BT_PROD_CONFIRM.Visible = True
            Me.TXT_LABEL.ReadOnly = False
            Me.CB_PRODUCT_MOD.Visible = True
        ElseIf Me.CB_PRODUCT.GetItemText(Me.CB_PRODUCT.SelectedItem) = "Supprimer" Then
            Me.LB_REMOVE_PRODUCT.Visible = True
            Me.LB_LABEL.Visible = False
            Me.LB_PRICESELL.Visible = False
            Me.LB_PRICEBUY.Visible = False
            Me.LB_PRICEPOINT.Visible = False
            Me.LB_VALUEPOINT.Visible = False
            Me.LB_STOCK.Visible = False
            Me.CBX_FRIDGE.Visible = False
            Me.CB_TYPE.Visible = False
            Me.TXT_REMOVE_PRODUCT.Visible = True
            Me.TXT_LABEL.Visible = False
            Me.TXT_PRICEBUY.Visible = False
            Me.TXT_PRICESELL.Visible = False
            Me.TXT_PRICEPOINT.Visible = False
            Me.TXT_VALUEPOINT.Visible = False
            Me.TXT_STOCK.Visible = False
            Me.BT_PROD_CONFIRM.Visible = True
            Me.TXT_LABEL.ReadOnly = True
            Me.CB_PRODUCT_MOD.Visible = False
        Else
            MsgBox("How did you have done this ?")
        End If
    End Sub

    Private Sub BT_PROD_CONFIRM_Click(sender As Object, e As EventArgs) Handles BT_PROD_CONFIRM.Click
        If Me.CB_PRODUCT.GetItemText(Me.CB_PRODUCT.SelectedItem) = "Ajouter" Then
            Dim canPerform As Boolean = True

            If Me.TXT_LABEL.Text <> "" Then
                If Not SPLASH.theDatabase.isAvailableLabel(Me.TXT_LABEL.Text) Then
                    canPerform = False
                    MsgBox("This label is already used")
                End If
            Else
                canPerform = False
                MsgBox("Label field must be filled")
            End If

            If Me.TXT_PRICEBUY.Text <> "" Then
                If Not IsNumeric(Me.TXT_PRICEBUY.Text.Replace(",", "").Replace(".", "")) Then
                    canPerform = False
                    MsgBox("The price buy must be a numeric value")
                End If
            Else
                    canPerform = False
                MsgBox("The price buy must be filled")
            End If

            If Me.TXT_PRICESELL.Text <> "" Then
                If Not IsNumeric(Me.TXT_PRICESELL.Text.Replace(",", "").Replace(".", "")) Then
                    canPerform = False
                    MsgBox("The price sell must be a numeric value")
                End If
            Else
                canPerform = False
                MsgBox("The price sell must be filled")
            End If

            If Me.TXT_PRICEPOINT.Text <> "" Then
                If Not IsNumeric(Me.TXT_PRICEPOINT.Text) Then
                    canPerform = False
                    MsgBox("The price point must be a numeric value integer")
                End If
            Else
                canPerform = False
                MsgBox("The price point must be filled")
            End If

            If Me.TXT_VALUEPOINT.Text <> "" Then
                If Not IsNumeric(Me.TXT_VALUEPOINT.Text) Then
                    canPerform = False
                    MsgBox("The value point must be a numeric value integer")
                End If
            Else
                canPerform = False
                MsgBox("The value point must be filled")
            End If

            If Me.TXT_STOCK.Text <> "" Then
                If Not IsNumeric(Me.TXT_STOCK.Text) Then
                    canPerform = False
                    MsgBox("The stock must be integer")
                End If
            Else
                Me.TXT_STOCK.Text = "0"
            End If


            If Not Me.CB_TYPE.GetItemText(Me.CB_TYPE.SelectedItem) <> "" Then
                canPerform = False
                MsgBox("The type doesn't have been filled")
            End If

            If canPerform Then
                Dim pricepoint As Integer = CInt(Me.TXT_PRICEPOINT.Text)
                Dim valuepoint As Integer = CInt(Me.TXT_VALUEPOINT.Text)

                If Not (pricepoint > (valuepoint * 5)) Then canPerform = False
            End If


            If canPerform Then
                Dim fridged As Integer = 0
                If Me.CBX_FRIDGE.Checked = True Then
                    fridged = 1
                End If
                Dim request As String = "SELECT id_type FROM type WHERE type_name = '" +
                    Me.CB_TYPE.GetItemText(Me.CB_TYPE.SelectedItem) + "';"
                Dim id_type As Integer = SPLASH.theDatabase.getIdFromQuery(request)



                request = "INSERT INTO product(label, price_sell, price_buy, price_point," &
                    " value_point, stock, id_type, fridge, id_unit) VALUES ('" & Me.TXT_LABEL.Text &
                    "', " & Me.TXT_PRICESELL.Text.ToString.Replace(",", ".") & ", " &
                    Me.TXT_PRICEBUY.Text.ToString.Replace(",", ".") & ", " & Me.TXT_PRICEPOINT.Text.ToString() &
                    ", " & Me.TXT_VALUEPOINT.Text.ToString() & ", " & Me.TXT_STOCK.Text & ", " & id_type &
                    ", " & fridged & ", 0);"

                If Not SPLASH.theDatabase.doNonQuery(request) Then
                    MsgBox("Error: Unable to create product")
                Else
                    MsgBox("Product correctly recorded !")

                    Me.CB_PRODUCT_MOD.Items.Clear()
                    If SPLASH.theDatabase.GetNbProduct() > 0 Then
                        For Each product As String In SPLASH.theDatabase.getListProduct()
                            Me.CB_PRODUCT_MOD.Items.Add(product)
                        Next
                    End If
                End If
            End If

        ElseIf Me.CB_PRODUCT.GetItemText(Me.CB_PRODUCT.SelectedItem) = "Supprimer" Then
            Dim idProduct As Integer = SPLASH.theDatabase.getIdProdFromString(Me.TXT_REMOVE_PRODUCT.Text)
            Dim label As String = SPLASH.theDatabase.getLabel(idProduct)
            If idProduct <> -1 Then
                If Not SPLASH.theDatabase.doNonQuery("DELETE FROM product WHERE id_product = " + idProduct.ToString() + ";") Then
                    MsgBox("Error: Unable to remove product from database")
                Else
                    MsgBox(label + " have correctly been removed")
                    Me.TXT_REMOVE_PRODUCT.Text = ""

                    Me.CB_PRODUCT_MOD.Items.Clear()
                    If SPLASH.theDatabase.GetNbProduct() > 0 Then
                        For Each product As String In SPLASH.theDatabase.getListProduct()
                            Me.CB_PRODUCT_MOD.Items.Add(product)
                        Next
                    End If
                End If
            Else
                MsgBox("Unexisting product")
            End If
        ElseIf Me.CB_PRODUCT.GetItemText(Me.CB_PRODUCT.SelectedItem) = "Modifier" Then

            Dim canPerform As Boolean = True

            If Me.TXT_PRICEBUY.Text <> "" Then
                If Not IsNumeric(Me.TXT_PRICEBUY.Text.Replace(",", "").Replace(".", "")) Then
                    canPerform = False
                    MsgBox("The price buy must be a numeric value")
                End If
            Else
                canPerform = False
                MsgBox("The price buy must be filled")
            End If

            If Me.TXT_PRICESELL.Text <> "" Then
                If Not IsNumeric(Me.TXT_PRICESELL.Text.Replace(",", "").Replace(".", "")) Then
                    canPerform = False
                    MsgBox("The price sell must be a numeric value")
                End If
            Else
                canPerform = False
                MsgBox("The price sell must be filled")
            End If

            If Me.TXT_PRICEPOINT.Text <> "" Then
                If Not IsNumeric(Me.TXT_PRICEPOINT.Text) Then
                    canPerform = False
                    MsgBox("The price point must be a numeric value integer")
                End If
            Else
                canPerform = False
                MsgBox("The price point must be filled")
            End If

            If Me.TXT_VALUEPOINT.Text <> "" Then
                If Not IsNumeric(Me.TXT_VALUEPOINT.Text) Then
                    canPerform = False
                    MsgBox("The value point must be a numeric value integer")
                End If
            Else
                canPerform = False
                MsgBox("The value point must be filled")
            End If

            If Me.TXT_STOCK.Text <> "" Then
                If Not IsNumeric(Me.TXT_STOCK.Text) Then
                    canPerform = False
                    MsgBox("The stock must be integer")
                End If
            Else
                Me.TXT_STOCK.Text = "0"
            End If


            If Not Me.CB_TYPE.GetItemText(Me.CB_TYPE.SelectedItem) <> "" Then
                canPerform = False
                MsgBox("The type doesn't have been filled")
            End If

            If canPerform Then
                Dim pricepoint As Integer = CInt(Me.TXT_PRICEPOINT.Text)
                Dim valuepoint As Integer = CInt(Me.TXT_VALUEPOINT.Text)

                If Not (pricepoint > (valuepoint * 5)) Then canPerform = False
            End If



            If canPerform Then

                Dim fridged As Integer = 0
                If Me.CBX_FRIDGE.Checked = True Then
                    fridged = 1
                End If
                Dim request As String = "SELECT id_type FROM type WHERE type_name = '" +
                    Me.CB_TYPE.GetItemText(Me.CB_TYPE.SelectedItem) + "';"
                Dim id_type As Integer = SPLASH.theDatabase.getIdFromQuery(request)


                request = "UPDATE product SET price_sell = " & Me.TXT_PRICESELL.Text.ToString().Replace(",", ".") &
                    ", price_buy = " & Me.TXT_PRICEBUY.Text.ToString().Replace(",", ".") & ", price_point = " &
                    Me.TXT_PRICEPOINT.Text.ToString() & ", value_point = " & Me.TXT_VALUEPOINT.Text.ToString() &
                    ", stock = " & Me.TXT_STOCK.Text.ToString() & ", id_type = " & id_type.ToString() &
                    ", fridge = " & fridged & " WHERE label = '" & Me.TXT_LABEL.Text & "';"

                If Not SPLASH.theDatabase.doNonQuery(request) Then
                    MsgBox("Unable to update product")
                Else
                    MsgBox("Product correctly have been updated")
                End If

            Else
                MsgBox("Product not updated")
            End If

        Else
            MsgBox("Error 404: Brain not found")
        End If
    End Sub

    Private Sub CB_PRODUCT_MOD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PRODUCT_MOD.SelectedIndexChanged
        Dim idProduct = SPLASH.theDatabase.getIdProdFromString(Me.CB_PRODUCT_MOD.GetItemText(Me.CB_PRODUCT_MOD.SelectedItem))

        If idProduct <> -1 Then
            Me.TXT_LABEL.Text = SPLASH.theDatabase.getLabel(idProduct)
            Me.TXT_PRICEBUY.Text = SPLASH.theDatabase.getPriceBuy(idProduct).ToString()
            Me.TXT_PRICESELL.Text = SPLASH.theDatabase.getPriceSell(idProduct).ToString()
            Me.TXT_PRICEPOINT.Text = SPLASH.theDatabase.getPricePoint(idProduct).ToString()
            Me.TXT_VALUEPOINT.Text = SPLASH.theDatabase.getValuePoint(idProduct).ToString()
            Me.TXT_STOCK.Text = SPLASH.theDatabase.getStock(idProduct).ToString()
            Dim fridged As Integer = SPLASH.theDatabase.getFridge(idProduct)
            If fridged = 1 Then
                Me.CBX_FRIDGE.Checked = True
            Else
                Me.CBX_FRIDGE.Checked = False
            End If

        End If
    End Sub
End Class
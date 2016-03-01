Imports System.ComponentModel
Imports System.Data.SQLite

Public Class payment

    Public idUser As Integer = -1
    Private isUsableDGVdrinks As Boolean = False
    Private isUsableDGVfood As Boolean = False
    Private isUsableDGVshopCart As Boolean = False


    Private DataSourceShopCart As DataSet

    Private Sub DGV_DRINK_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_DRINK.SelectionChanged
        If isUsableDGVdrinks Then
            Dim columnIndex As Integer = -1
            Dim rowIndex As Integer = -1

            For Each column As DataGridViewColumn In Me.DGV_DRINK.Columns
                If column.Name = "id_product" Then
                    columnIndex = column.Index
                End If
            Next

            If Me.DGV_DRINK.SelectedCells.Count = 1 Then
                For Each cell As DataGridViewCell In Me.DGV_DRINK.SelectedCells
                    rowIndex = cell.RowIndex
                Next
            End If

            If columnIndex <> -1 And rowIndex <> -1 Then
                Dim id_item As Integer = Me.DGV_DRINK.Rows(rowIndex).Cells(columnIndex).Value
                addItemShoppingCart(id_item)
                Me.DGV_SHOPPING_CART.ClearSelection()
                isUsableDGVshopCart = True
            End If
        End If
    End Sub

    Private Sub addItemShoppingCart(ByVal idItem As Integer)
        Dim da As New SQLiteDataAdapter("SELECT id_product, label, price_sell, price_point," +
                                        " value_point FROM product WHERE id_product = " + idItem.ToString() + ";",
                                        SPLASH.theDatabase.dbConnection)

        Try
            da.Fill(DataSourceShopCart)
            DGV_SHOPPING_CART.DataSource = DataSourceShopCart.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        shoppingCartChanged()
    End Sub


    Private Sub payment_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If idUser <> -2 Then
            If SPLASH.isAdmin Then
                shop.idChoosed = -1
                shop.Show()
            Else
                home.Show()
            End If
        Else
            home.Show()
        End If

    End Sub

    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = SPLASH.theConfig.OrganisationName + " - " + SPLASH.theConfig._Payment

        Me.LB_PRICE.Text = ""

        Me.LB_DRINK.Text = SPLASH.theConfig._Drinks
        Me.LB_FOOD.Text = SPLASH.theConfig._Foods

        Me.RB_BALANCE.Text = SPLASH.theConfig._PayBalance
        Me.RB_POINT.Text = SPLASH.theConfig._PayPoints
        Me.RB_CASH.Text = SPLASH.theConfig._PayCash

        Me.BT_PURCHASE.Text = SPLASH.theConfig._Purchase




        Me.DGV_DRINK.DataSource = Nothing
        Me.DGV_DRINK.Rows.Clear()

        Dim ds As New DataSet
        Dim da As New SQLiteDataAdapter("SELECT id_product, label, price_sell, price_point," +
                                        " value_point FROM product, type WHERE stock > 0 AND" +
                                        " product.id_type=type.id_type AND type_name = 'Drink';",
                                        SPLASH.theDatabase.dbConnection)

        Try
            da.Fill(ds)
            DGV_DRINK.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.DGV_DRINK.ClearSelection()
        isUsableDGVdrinks = True



        Me.DGV_FOOD.DataSource = Nothing
        Me.DGV_FOOD.Rows.Clear()

        ds = New DataSet
        da = New SQLiteDataAdapter("SELECT id_product, label, price_sell, price_point," +
                                        " value_point FROM product, type WHERE stock > 0 AND" +
                                        " product.id_type=type.id_type AND type_name = 'Food';",
                                        SPLASH.theDatabase.dbConnection)

        Try
            da.Fill(ds)
            DGV_FOOD.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.DGV_FOOD.ClearSelection()
        isUsableDGVfood = True


        Me.DGV_SHOPPING_CART.DataSource = Nothing
        Me.DGV_SHOPPING_CART.Rows.Clear()

        DataSourceShopCart = New DataSet
        da = New SQLiteDataAdapter("SELECT id_product, label, price_sell, price_point," +
                                        " value_point FROM product WHERE id_type=-1;",
                                        SPLASH.theDatabase.dbConnection)

        Try
            da.Fill(DataSourceShopCart)
            DGV_SHOPPING_CART.DataSource = DataSourceShopCart.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.DGV_SHOPPING_CART.ClearSelection()

        Me.TIM_LOAD.Start()
    End Sub

    Private Sub TIM_LOAD_Tick(sender As Object, e As EventArgs) Handles TIM_LOAD.Tick
        Me.TIM_LOAD.Stop()
        If SPLASH.isAdmin Then
            If (shop.idChoosed > 0) Then
                Dim Name As String = SPLASH.theDatabase.getName(shop.idChoosed)
                Dim FirstName As String = SPLASH.theDatabase.getFirstName(shop.idChoosed)
                Dim Points As Integer = SPLASH.theDatabase.getPoints(shop.idChoosed)
                Dim Balance As Decimal = SPLASH.theDatabase.getBalance(shop.idChoosed)


                Me.LB_TEXT.Text = Name + " " + FirstName + " :  " + Points.ToString() + " " +
                    SPLASH.theConfig._Points + vbCrLf + SPLASH.theConfig._Balance + " : " + Balance.ToString() +
                    "€"
            ElseIf (idUser = -2) Then
                Me.LB_TEXT.Text = SPLASH.theConfig.OrganisationName
                Me.RB_CASH.Checked = True
                Me.RB_BALANCE.Visible = False
                Me.RB_CASH.Visible = False
                Me.RB_POINT.Visible = False
            Else
                Me.LB_TEXT.Text = "What da fuck bruh ?"
            End If
        Else
            If SPLASH.idUser > 0 Then
                Dim Name As String = SPLASH.theDatabase.getName(SPLASH.idUser)
                Dim FirstName As String = SPLASH.theDatabase.getFirstName(SPLASH.idUser)
                Dim Points As Integer = SPLASH.theDatabase.getPoints(SPLASH.idUser)
                Dim Balance As Decimal = SPLASH.theDatabase.getBalance(SPLASH.idUser)


                Me.LB_TEXT.Text = Name + " " + FirstName + " :  " + Points.ToString() + " " +
                    SPLASH.theConfig._Points + vbCrLf + SPLASH.theConfig._Balance + " : " + Balance.ToString() +
                    "€"
            End If
        End If



    End Sub

    Private Sub DGV_FOOD_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_FOOD.SelectionChanged
        If isUsableDGVfood Then
            Dim columnIndex As Integer = -1
            Dim rowIndex As Integer = -1

            For Each column As DataGridViewColumn In Me.DGV_FOOD.Columns
                If column.Name = "id_product" Then
                    columnIndex = column.Index
                End If
            Next

            If Me.DGV_FOOD.SelectedCells.Count = 1 Then
                For Each cell As DataGridViewCell In Me.DGV_FOOD.SelectedCells
                    rowIndex = cell.RowIndex
                Next
            End If

            If columnIndex <> -1 And rowIndex <> -1 Then
                Dim id_item As Integer = Me.DGV_FOOD.Rows(rowIndex).Cells(columnIndex).Value
                addItemShoppingCart(id_item)
                Me.DGV_SHOPPING_CART.ClearSelection()
                isUsableDGVshopCart = True
            End If
        End If
    End Sub

    Private Sub DGV_SHOPPING_CART_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_SHOPPING_CART.SelectionChanged
        If isUsableDGVshopCart Then
            Dim rowIndex As Integer = -1

            If Me.DGV_SHOPPING_CART.SelectedCells.Count = 1 Then
                For Each cell As DataGridViewCell In Me.DGV_SHOPPING_CART.SelectedCells
                    rowIndex = cell.RowIndex
                Next
            End If
            isUsableDGVshopCart = False

            Try
                Me.DGV_SHOPPING_CART.Rows.Remove(Me.DGV_SHOPPING_CART.Rows(rowIndex))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            shoppingCartChanged()
        End If
    End Sub

    Private Sub DGV_SHOPPING_CART_Click(sender As Object, e As EventArgs) Handles DGV_SHOPPING_CART.Click
        isUsableDGVshopCart = True
    End Sub


    Private Sub shoppingCartChanged()
        Dim point As Integer = 0
        Dim money As Decimal = 0

        Dim indexPrice, indexPoint As Integer

        For Each column As DataGridViewColumn In Me.DGV_SHOPPING_CART.Columns
            If column.Name = "price_sell" Then
                indexPrice = column.Index
            ElseIf column.Name = "price_point" Then
                indexPoint = column.Index
            End If
        Next

        For Each row As DataGridViewRow In Me.DGV_SHOPPING_CART.Rows
            point += Me.DGV_SHOPPING_CART.Rows(row.Index).Cells(indexPoint).Value
            money += Me.DGV_SHOPPING_CART.Rows(row.Index).Cells(indexPrice).Value
        Next

        Me.LB_PRICE.Text = SPLASH.theConfig._Price + " : " + money.ToString() + vbCrLf +
            SPLASH.theConfig._Points + " : " + point.ToString()
    End Sub


    Private Function pay(Optional ByVal isUser As Boolean = True) As Boolean

        Dim rc As Boolean = True

        Dim idUser As Integer = -1

        If isUser Then
            If SPLASH.isAdmin Then
                idUser = shop.idChoosed
            Else
                idUser = SPLASH.idUser
            End If
        End If

        Dim sumPrice As Decimal = 0
        Dim sumPoint As Decimal = 0
        Dim sumPointEarn As Decimal = 0

        Dim indexPrice, indexProduct, indexPoint, indexPointEarn As Integer

        For Each column As DataGridViewColumn In Me.DGV_SHOPPING_CART.Columns
            If column.Name = "price_sell" Then
                indexPrice = column.Index
            ElseIf column.Name = "id_product" Then
                indexProduct = column.Index
            ElseIf column.Name = "price_point" Then
                indexPoint = column.Index
            ElseIf column.Name = "value_point" Then
                indexPointEarn = column.Index
            End If
        Next

        Dim idProduct As Integer

        For Each row As DataGridViewRow In Me.DGV_SHOPPING_CART.Rows
            sumPrice += Me.DGV_SHOPPING_CART.Rows(row.Index).Cells(indexPrice).Value
            sumPoint += Me.DGV_SHOPPING_CART.Rows(row.Index).Cells(indexPoint).Value
            sumPointEarn += Me.DGV_SHOPPING_CART.Rows(row.Index).Cells(indexPointEarn).Value
        Next

        If isUser Then
            If Me.RB_BALANCE.Checked Then
                Dim currentBalance As Decimal = SPLASH.theDatabase.getBalance(idUser)

                If currentBalance >= sumPrice Then
                    If Not SPLASH.theDatabase.doNonQuery("UPDATE member SET balance = " +
                                                         (currentBalance - sumPrice).ToString().Replace(",", ".") +
                                                         " WHERE id = " + idUser.ToString() + ";") Then
                        MsgBox("Error: taking money from member")
                        rc = False
                    End If
                Else
                    Dim isAllowNeg As Integer = SPLASH.theDatabase.getAllowNeg(idUser)

                    If isAllowNeg > 0 Then

                        If currentBalance - sumPrice > -10 Then

                            If Not SPLASH.theDatabase.doNonQuery("UPDATE member SET balance = " +
                                                         (currentBalance - sumPrice).ToString().Replace(",", ".") +
                                                         " WHERE id = " + idUser.ToString() + ";") Then
                                MsgBox("Error: taking money from member")
                                rc = False
                            End If

                        Else
                            MsgBox("Error: Too much negative")
                            rc = False
                        End If

                    Else
                        MsgBox("Error: Not enough money")
                        rc = False
                    End If

                End If
            ElseIf Me.RB_POINT.Checked
                Dim currentPoints As Integer = SPLASH.theDatabase.getPoints(idUser)

                If currentPoints >= sumPoint Then
                    If Not SPLASH.theDatabase.doNonQuery("UPDATE member SET points = " +
                                                         (currentPoints - sumPoint).ToString() +
                                                         " WHERE id = " + idUser.ToString() + ";") Then
                        MsgBox("Error: taking point from member")
                        rc = False
                    End If
                Else
                    rc = False
                    MsgBox("Not enough points")
                End If
            End If

            Dim currentPoint As Integer = SPLASH.theDatabase.getPoints(idUser)
            If Me.RB_BALANCE.Checked Then
                If Not SPLASH.theDatabase.doNonQuery("UPDATE member SET points = " + (currentPoint +
                                                                 sumPointEarn).ToString() + " WHERE id = " +
                                                                 idUser.ToString() + ";") Then
                    MsgBox("Error: adding point to account")
                    rc = False
                End If
            End If


        Else

            If isUser Then
                Dim currentPoint As Integer = SPLASH.theDatabase.getPoints(idUser)

                If Not SPLASH.theDatabase.doNonQuery("UPDATE member SET points = " + (currentPoint +
                                                     sumPointEarn).ToString() + " WHERE id = " +
                                                     idUser.ToString() + ";") Then
                    MsgBox("Error: adding point to account")
                    rc = False
                End If
            End If


        End If


        If rc Then
            If Not SPLASH.theDatabase.doNonQuery("INSERT INTO money_input(money) VALUES (" +
                                                 sumPrice.ToString().Replace(",", ".") + ");") Then
                MsgBox("Error: Unable to save the transaction into the database - May have error into database")
                rc = False
            End If

            For Each row As DataGridViewRow In Me.DGV_SHOPPING_CART.Rows
                idProduct = Me.DGV_SHOPPING_CART.Rows(row.Index).Cells(indexProduct).Value
                Dim newStock As Integer = SPLASH.theDatabase.getStock(idProduct) - 1
                If Not SPLASH.theDatabase.doNonQuery("UPDATE product SET stock = " + newStock.ToString() +
                                                     " WHERE id_product = " + idProduct.ToString() +
                                                     ";") Then
                    MsgBox("Error while removing product from the database")
                    rc = False
                End If
            Next

        End If




        Return rc

    End Function


    Private Sub BT_PURCHASE_Click(sender As Object, e As EventArgs) Handles BT_PURCHASE.Click

        Dim payed As Boolean = False

        If Me.DGV_SHOPPING_CART.Rows.Count > 0 Then

            If (idUser = -2) Then
                payed = pay(False)
            ElseIf (shop.idChoosed > 0) Then
                If Me.RB_BALANCE.Checked Or Me.RB_CASH.Checked Or Me.RB_POINT.Checked Then
                    payed = pay()
                Else
                    MsgBox("Error: No radio button checked!")
                End If
            ElseIf (SPLASH.idUser > 0) Then
                If Me.RB_BALANCE.Checked Or Me.RB_CASH.Checked Or Me.RB_POINT.Checked Then
                    payed = pay()
                Else
                    MsgBox("Error: No radio button checked!")
                End If
            Else
                MsgBox("Error: invalid id user")
            End If
        Else
            MsgBox("Empty shopping cart")
        End If


        If payed Then
            Me.Close()
        End If
    End Sub
End Class
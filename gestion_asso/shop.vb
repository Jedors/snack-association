Imports System.ComponentModel
Imports System.Data.SQLite
Public Class shop
    Const cmdSelect As String = "SELECT id, nickname, name, firstname, balance, points FROM member;"
    Private isUsableDGV As Boolean = False

    Public idChoosed As Integer = -1


    Private Sub shop_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        home.Show()
    End Sub

    Private Sub shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = SPLASH.theConfig._Shop + " - " + SPLASH.theConfig.OrganisationName
        Me.BT_CLOSE.Text = SPLASH.theConfig._Close

        Me.DGV.DataSource = Nothing
        Me.DGV.Rows.Clear()

        Dim ds As New DataSet
        Dim da As New SQLiteDataAdapter(cmdSelect, SPLASH.theDatabase.dbConnection)

        Try
            da.Fill(ds)
            DGV.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.DGV.ClearSelection()
        isUsableDGV = True
    End Sub

    Private Sub BT_CLOSE_Click(sender As Object, e As EventArgs) Handles BT_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs) Handles DGV.SelectionChanged
        If isUsableDGV Then
            Dim columnIndex As Integer = -1
            Dim rowIndex As Integer = -1

            For Each column As DataGridViewColumn In Me.DGV.Columns
                If column.Name = "id" Then
                    columnIndex = column.Index
                End If
            Next

            If Me.DGV.SelectedCells.Count = 1 Then
                For Each cell As DataGridViewCell In Me.DGV.SelectedCells
                    rowIndex = cell.RowIndex
                Next
            End If

            If columnIndex <> -1 And rowIndex <> -1 Then

                idChoosed = Me.DGV.Rows(rowIndex).Cells(columnIndex).Value
                payment.Show()
                Me.Hide()
            End If
        End If

    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payment
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LB_DRINK = New System.Windows.Forms.Label()
        Me.DGV_DRINK = New System.Windows.Forms.DataGridView()
        Me.LB_FOOD = New System.Windows.Forms.Label()
        Me.DGV_FOOD = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RB_CASH = New System.Windows.Forms.RadioButton()
        Me.RB_POINT = New System.Windows.Forms.RadioButton()
        Me.RB_BALANCE = New System.Windows.Forms.RadioButton()
        Me.DGV_SHOPPING_CART = New System.Windows.Forms.DataGridView()
        Me.LB_TEXT = New System.Windows.Forms.Label()
        Me.BT_PURCHASE = New System.Windows.Forms.Button()
        Me.TIM_LOAD = New System.Windows.Forms.Timer(Me.components)
        Me.LB_PRICE = New System.Windows.Forms.Label()
        CType(Me.DGV_DRINK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_FOOD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_SHOPPING_CART, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LB_DRINK
        '
        Me.LB_DRINK.AutoSize = True
        Me.LB_DRINK.Location = New System.Drawing.Point(13, 13)
        Me.LB_DRINK.Name = "LB_DRINK"
        Me.LB_DRINK.Size = New System.Drawing.Size(60, 13)
        Me.LB_DRINK.TabIndex = 0
        Me.LB_DRINK.Text = "LB_DRINK"
        '
        'DGV_DRINK
        '
        Me.DGV_DRINK.AllowUserToAddRows = False
        Me.DGV_DRINK.AllowUserToDeleteRows = False
        Me.DGV_DRINK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DRINK.Location = New System.Drawing.Point(13, 30)
        Me.DGV_DRINK.MultiSelect = False
        Me.DGV_DRINK.Name = "DGV_DRINK"
        Me.DGV_DRINK.ReadOnly = True
        Me.DGV_DRINK.RowHeadersVisible = False
        Me.DGV_DRINK.Size = New System.Drawing.Size(255, 113)
        Me.DGV_DRINK.TabIndex = 1
        '
        'LB_FOOD
        '
        Me.LB_FOOD.AutoSize = True
        Me.LB_FOOD.Location = New System.Drawing.Point(12, 157)
        Me.LB_FOOD.Name = "LB_FOOD"
        Me.LB_FOOD.Size = New System.Drawing.Size(56, 13)
        Me.LB_FOOD.TabIndex = 2
        Me.LB_FOOD.Text = "LB_FOOD"
        '
        'DGV_FOOD
        '
        Me.DGV_FOOD.AllowUserToAddRows = False
        Me.DGV_FOOD.AllowUserToDeleteRows = False
        Me.DGV_FOOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_FOOD.Location = New System.Drawing.Point(13, 173)
        Me.DGV_FOOD.MultiSelect = False
        Me.DGV_FOOD.Name = "DGV_FOOD"
        Me.DGV_FOOD.ReadOnly = True
        Me.DGV_FOOD.RowHeadersVisible = False
        Me.DGV_FOOD.Size = New System.Drawing.Size(255, 123)
        Me.DGV_FOOD.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LB_PRICE)
        Me.GroupBox1.Controls.Add(Me.RB_CASH)
        Me.GroupBox1.Controls.Add(Me.RB_POINT)
        Me.GroupBox1.Controls.Add(Me.RB_BALANCE)
        Me.GroupBox1.Controls.Add(Me.DGV_SHOPPING_CART)
        Me.GroupBox1.Controls.Add(Me.LB_TEXT)
        Me.GroupBox1.Location = New System.Drawing.Point(274, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 249)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'RB_CASH
        '
        Me.RB_CASH.AutoSize = True
        Me.RB_CASH.Location = New System.Drawing.Point(203, 135)
        Me.RB_CASH.Name = "RB_CASH"
        Me.RB_CASH.Size = New System.Drawing.Size(75, 17)
        Me.RB_CASH.TabIndex = 5
        Me.RB_CASH.Text = "RB_CASH"
        Me.RB_CASH.UseVisualStyleBackColor = True
        '
        'RB_POINT
        '
        Me.RB_POINT.AutoSize = True
        Me.RB_POINT.Location = New System.Drawing.Point(203, 112)
        Me.RB_POINT.Name = "RB_POINT"
        Me.RB_POINT.Size = New System.Drawing.Size(79, 17)
        Me.RB_POINT.TabIndex = 4
        Me.RB_POINT.Text = "RB_POINT"
        Me.RB_POINT.UseVisualStyleBackColor = True
        '
        'RB_BALANCE
        '
        Me.RB_BALANCE.AutoSize = True
        Me.RB_BALANCE.Checked = True
        Me.RB_BALANCE.Location = New System.Drawing.Point(203, 89)
        Me.RB_BALANCE.Name = "RB_BALANCE"
        Me.RB_BALANCE.Size = New System.Drawing.Size(95, 17)
        Me.RB_BALANCE.TabIndex = 2
        Me.RB_BALANCE.TabStop = True
        Me.RB_BALANCE.Text = "RB_BALANCE"
        Me.RB_BALANCE.UseVisualStyleBackColor = True
        '
        'DGV_SHOPPING_CART
        '
        Me.DGV_SHOPPING_CART.AllowUserToAddRows = False
        Me.DGV_SHOPPING_CART.AllowUserToDeleteRows = False
        Me.DGV_SHOPPING_CART.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_SHOPPING_CART.Location = New System.Drawing.Point(6, 81)
        Me.DGV_SHOPPING_CART.MultiSelect = False
        Me.DGV_SHOPPING_CART.Name = "DGV_SHOPPING_CART"
        Me.DGV_SHOPPING_CART.ReadOnly = True
        Me.DGV_SHOPPING_CART.RowHeadersVisible = False
        Me.DGV_SHOPPING_CART.Size = New System.Drawing.Size(191, 158)
        Me.DGV_SHOPPING_CART.TabIndex = 1
        '
        'LB_TEXT
        '
        Me.LB_TEXT.AutoSize = True
        Me.LB_TEXT.Location = New System.Drawing.Point(7, 20)
        Me.LB_TEXT.Name = "LB_TEXT"
        Me.LB_TEXT.Size = New System.Drawing.Size(54, 13)
        Me.LB_TEXT.TabIndex = 0
        Me.LB_TEXT.Text = "LB_TEXT"
        '
        'BT_PURCHASE
        '
        Me.BT_PURCHASE.Location = New System.Drawing.Point(531, 273)
        Me.BT_PURCHASE.Name = "BT_PURCHASE"
        Me.BT_PURCHASE.Size = New System.Drawing.Size(98, 23)
        Me.BT_PURCHASE.TabIndex = 5
        Me.BT_PURCHASE.Text = "BT_PURCHASE"
        Me.BT_PURCHASE.UseVisualStyleBackColor = True
        '
        'TIM_LOAD
        '
        '
        'LB_PRICE
        '
        Me.LB_PRICE.AutoSize = True
        Me.LB_PRICE.Location = New System.Drawing.Point(204, 159)
        Me.LB_PRICE.Name = "LB_PRICE"
        Me.LB_PRICE.Size = New System.Drawing.Size(58, 13)
        Me.LB_PRICE.TabIndex = 6
        Me.LB_PRICE.Text = "LB_PRICE"
        '
        'payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 308)
        Me.Controls.Add(Me.BT_PURCHASE)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV_FOOD)
        Me.Controls.Add(Me.LB_FOOD)
        Me.Controls.Add(Me.DGV_DRINK)
        Me.Controls.Add(Me.LB_DRINK)
        Me.Name = "payment"
        Me.Text = "payment"
        CType(Me.DGV_DRINK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_FOOD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_SHOPPING_CART, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LB_DRINK As Label
    Friend WithEvents DGV_DRINK As DataGridView
    Friend WithEvents LB_FOOD As Label
    Friend WithEvents DGV_FOOD As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RB_CASH As RadioButton
    Friend WithEvents RB_POINT As RadioButton
    Friend WithEvents RB_BALANCE As RadioButton
    Friend WithEvents DGV_SHOPPING_CART As DataGridView
    Friend WithEvents LB_TEXT As Label
    Friend WithEvents BT_PURCHASE As Button
    Friend WithEvents TIM_LOAD As Timer
    Friend WithEvents LB_PRICE As Label
End Class

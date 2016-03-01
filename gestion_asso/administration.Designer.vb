<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administration
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TP_MEMBER = New System.Windows.Forms.TabPage()
        Me.CB_SELECT_USER = New System.Windows.Forms.ComboBox()
        Me.TXT_REMOVE_USER = New System.Windows.Forms.TextBox()
        Me.LB_REMOVE_USER = New System.Windows.Forms.Label()
        Me.BT_MEM_CONFIRM = New System.Windows.Forms.Button()
        Me.CBX_ALLOWNEG = New System.Windows.Forms.CheckBox()
        Me.TXT_POINTS = New System.Windows.Forms.TextBox()
        Me.LB_POINTS = New System.Windows.Forms.Label()
        Me.TXT_BALANCE = New System.Windows.Forms.TextBox()
        Me.LB_BALANCE = New System.Windows.Forms.Label()
        Me.TXT_EMAIL = New System.Windows.Forms.TextBox()
        Me.LB_EMAIL = New System.Windows.Forms.Label()
        Me.TXT_PHONENUMBER = New System.Windows.Forms.TextBox()
        Me.LB_PHONENUMBER = New System.Windows.Forms.Label()
        Me.LB_PASSAGAIN = New System.Windows.Forms.Label()
        Me.TXT_PASSAGAIN = New System.Windows.Forms.TextBox()
        Me.TXT_PASSWORD = New System.Windows.Forms.TextBox()
        Me.LB_PASSWORD = New System.Windows.Forms.Label()
        Me.LB_NAME = New System.Windows.Forms.Label()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.TXT_FIRSTNAME = New System.Windows.Forms.TextBox()
        Me.LB_FIRSTNAME = New System.Windows.Forms.Label()
        Me.TXT_NICKNAME = New System.Windows.Forms.TextBox()
        Me.LB_NICKNAME = New System.Windows.Forms.Label()
        Me.CB_MEMBER = New System.Windows.Forms.ComboBox()
        Me.TP_ADMIN = New System.Windows.Forms.TabPage()
        Me.CB_REMOVE_ADMIN = New System.Windows.Forms.ComboBox()
        Me.TXT_STATUS = New System.Windows.Forms.TextBox()
        Me.LB_STATUS = New System.Windows.Forms.Label()
        Me.TXT_ID = New System.Windows.Forms.TextBox()
        Me.LB_ADM_TEXT = New System.Windows.Forms.Label()
        Me.BT_ADM_CONFIRM = New System.Windows.Forms.Button()
        Me.CB_ADMIN = New System.Windows.Forms.ComboBox()
        Me.TP_CREDIT = New System.Windows.Forms.TabPage()
        Me.BT_CONFIRM = New System.Windows.Forms.Button()
        Me.LB_VALUE = New System.Windows.Forms.Label()
        Me.TXT_VALUE = New System.Windows.Forms.TextBox()
        Me.TXT_CRED_ID = New System.Windows.Forms.TextBox()
        Me.LB_TEXT = New System.Windows.Forms.Label()
        Me.RB_DEBIT = New System.Windows.Forms.RadioButton()
        Me.RB_CREDIT = New System.Windows.Forms.RadioButton()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TP_PRODUCT = New System.Windows.Forms.TabPage()
        Me.TXT_REMOVE_PRODUCT = New System.Windows.Forms.TextBox()
        Me.LB_REMOVE_PRODUCT = New System.Windows.Forms.Label()
        Me.BT_PROD_CONFIRM = New System.Windows.Forms.Button()
        Me.CBX_FRIDGE = New System.Windows.Forms.CheckBox()
        Me.CB_TYPE = New System.Windows.Forms.ComboBox()
        Me.TXT_STOCK = New System.Windows.Forms.TextBox()
        Me.LB_STOCK = New System.Windows.Forms.Label()
        Me.TXT_VALUEPOINT = New System.Windows.Forms.TextBox()
        Me.LB_VALUEPOINT = New System.Windows.Forms.Label()
        Me.TXT_PRICEPOINT = New System.Windows.Forms.TextBox()
        Me.LB_PRICEPOINT = New System.Windows.Forms.Label()
        Me.TXT_PRICESELL = New System.Windows.Forms.TextBox()
        Me.LB_PRICESELL = New System.Windows.Forms.Label()
        Me.TXT_PRICEBUY = New System.Windows.Forms.TextBox()
        Me.LB_PRICEBUY = New System.Windows.Forms.Label()
        Me.TXT_LABEL = New System.Windows.Forms.TextBox()
        Me.LB_LABEL = New System.Windows.Forms.Label()
        Me.CB_PRODUCT = New System.Windows.Forms.ComboBox()
        Me.TP_STOCK = New System.Windows.Forms.TabPage()
        Me.TP_MONEY = New System.Windows.Forms.TabPage()
        Me.BT_DO_SUM = New System.Windows.Forms.Button()
        Me.BT_ADD_TRANSAC = New System.Windows.Forms.Button()
        Me.TXT_MONEY = New System.Windows.Forms.TextBox()
        Me.CB_PRODUCT_MOD = New System.Windows.Forms.ComboBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TP_MEMBER.SuspendLayout()
        Me.TP_ADMIN.SuspendLayout()
        Me.TP_CREDIT.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TP_PRODUCT.SuspendLayout()
        Me.TP_MONEY.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl2)
        Me.SplitContainer1.Size = New System.Drawing.Size(729, 496)
        Me.SplitContainer1.SplitterDistance = 362
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TP_MEMBER)
        Me.TabControl1.Controls.Add(Me.TP_ADMIN)
        Me.TabControl1.Controls.Add(Me.TP_CREDIT)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(356, 490)
        Me.TabControl1.TabIndex = 0
        '
        'TP_MEMBER
        '
        Me.TP_MEMBER.Controls.Add(Me.CB_SELECT_USER)
        Me.TP_MEMBER.Controls.Add(Me.TXT_REMOVE_USER)
        Me.TP_MEMBER.Controls.Add(Me.LB_REMOVE_USER)
        Me.TP_MEMBER.Controls.Add(Me.BT_MEM_CONFIRM)
        Me.TP_MEMBER.Controls.Add(Me.CBX_ALLOWNEG)
        Me.TP_MEMBER.Controls.Add(Me.TXT_POINTS)
        Me.TP_MEMBER.Controls.Add(Me.LB_POINTS)
        Me.TP_MEMBER.Controls.Add(Me.TXT_BALANCE)
        Me.TP_MEMBER.Controls.Add(Me.LB_BALANCE)
        Me.TP_MEMBER.Controls.Add(Me.TXT_EMAIL)
        Me.TP_MEMBER.Controls.Add(Me.LB_EMAIL)
        Me.TP_MEMBER.Controls.Add(Me.TXT_PHONENUMBER)
        Me.TP_MEMBER.Controls.Add(Me.LB_PHONENUMBER)
        Me.TP_MEMBER.Controls.Add(Me.LB_PASSAGAIN)
        Me.TP_MEMBER.Controls.Add(Me.TXT_PASSAGAIN)
        Me.TP_MEMBER.Controls.Add(Me.TXT_PASSWORD)
        Me.TP_MEMBER.Controls.Add(Me.LB_PASSWORD)
        Me.TP_MEMBER.Controls.Add(Me.LB_NAME)
        Me.TP_MEMBER.Controls.Add(Me.TXT_NAME)
        Me.TP_MEMBER.Controls.Add(Me.TXT_FIRSTNAME)
        Me.TP_MEMBER.Controls.Add(Me.LB_FIRSTNAME)
        Me.TP_MEMBER.Controls.Add(Me.TXT_NICKNAME)
        Me.TP_MEMBER.Controls.Add(Me.LB_NICKNAME)
        Me.TP_MEMBER.Controls.Add(Me.CB_MEMBER)
        Me.TP_MEMBER.Location = New System.Drawing.Point(4, 22)
        Me.TP_MEMBER.Name = "TP_MEMBER"
        Me.TP_MEMBER.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_MEMBER.Size = New System.Drawing.Size(348, 464)
        Me.TP_MEMBER.TabIndex = 0
        Me.TP_MEMBER.Text = "TP_MEMBER"
        Me.TP_MEMBER.UseVisualStyleBackColor = True
        '
        'CB_SELECT_USER
        '
        Me.CB_SELECT_USER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SELECT_USER.FormattingEnabled = True
        Me.CB_SELECT_USER.Location = New System.Drawing.Point(199, 7)
        Me.CB_SELECT_USER.Name = "CB_SELECT_USER"
        Me.CB_SELECT_USER.Size = New System.Drawing.Size(141, 21)
        Me.CB_SELECT_USER.TabIndex = 26
        Me.CB_SELECT_USER.Visible = False
        '
        'TXT_REMOVE_USER
        '
        Me.TXT_REMOVE_USER.Location = New System.Drawing.Point(180, 82)
        Me.TXT_REMOVE_USER.Name = "TXT_REMOVE_USER"
        Me.TXT_REMOVE_USER.Size = New System.Drawing.Size(162, 20)
        Me.TXT_REMOVE_USER.TabIndex = 25
        Me.TXT_REMOVE_USER.Visible = False
        '
        'LB_REMOVE_USER
        '
        Me.LB_REMOVE_USER.AutoSize = True
        Me.LB_REMOVE_USER.Location = New System.Drawing.Point(7, 82)
        Me.LB_REMOVE_USER.Name = "LB_REMOVE_USER"
        Me.LB_REMOVE_USER.Size = New System.Drawing.Size(137, 13)
        Me.LB_REMOVE_USER.TabIndex = 24
        Me.LB_REMOVE_USER.Text = "Entrez email, id ou pseudo :"
        Me.LB_REMOVE_USER.Visible = False
        '
        'BT_MEM_CONFIRM
        '
        Me.BT_MEM_CONFIRM.Location = New System.Drawing.Point(156, 315)
        Me.BT_MEM_CONFIRM.Name = "BT_MEM_CONFIRM"
        Me.BT_MEM_CONFIRM.Size = New System.Drawing.Size(113, 23)
        Me.BT_MEM_CONFIRM.TabIndex = 23
        Me.BT_MEM_CONFIRM.Text = "BT_MEM_CONFIRM"
        Me.BT_MEM_CONFIRM.UseVisualStyleBackColor = True
        Me.BT_MEM_CONFIRM.Visible = False
        '
        'CBX_ALLOWNEG
        '
        Me.CBX_ALLOWNEG.AutoSize = True
        Me.CBX_ALLOWNEG.Location = New System.Drawing.Point(6, 292)
        Me.CBX_ALLOWNEG.Name = "CBX_ALLOWNEG"
        Me.CBX_ALLOWNEG.Size = New System.Drawing.Size(114, 17)
        Me.CBX_ALLOWNEG.TabIndex = 19
        Me.CBX_ALLOWNEG.Text = "CBX_ALLOWNEG"
        Me.CBX_ALLOWNEG.UseVisualStyleBackColor = True
        Me.CBX_ALLOWNEG.Visible = False
        '
        'TXT_POINTS
        '
        Me.TXT_POINTS.Location = New System.Drawing.Point(180, 260)
        Me.TXT_POINTS.Name = "TXT_POINTS"
        Me.TXT_POINTS.Size = New System.Drawing.Size(160, 20)
        Me.TXT_POINTS.TabIndex = 18
        Me.TXT_POINTS.Visible = False
        '
        'LB_POINTS
        '
        Me.LB_POINTS.AutoSize = True
        Me.LB_POINTS.Location = New System.Drawing.Point(6, 260)
        Me.LB_POINTS.Name = "LB_POINTS"
        Me.LB_POINTS.Size = New System.Drawing.Size(66, 13)
        Me.LB_POINTS.TabIndex = 17
        Me.LB_POINTS.Text = "LB_POINTS"
        Me.LB_POINTS.Visible = False
        '
        'TXT_BALANCE
        '
        Me.TXT_BALANCE.Location = New System.Drawing.Point(180, 233)
        Me.TXT_BALANCE.Name = "TXT_BALANCE"
        Me.TXT_BALANCE.Size = New System.Drawing.Size(160, 20)
        Me.TXT_BALANCE.TabIndex = 16
        Me.TXT_BALANCE.Visible = False
        '
        'LB_BALANCE
        '
        Me.LB_BALANCE.AutoSize = True
        Me.LB_BALANCE.Location = New System.Drawing.Point(6, 233)
        Me.LB_BALANCE.Name = "LB_BALANCE"
        Me.LB_BALANCE.Size = New System.Drawing.Size(75, 13)
        Me.LB_BALANCE.TabIndex = 15
        Me.LB_BALANCE.Text = "LB_BALANCE"
        Me.LB_BALANCE.Visible = False
        '
        'TXT_EMAIL
        '
        Me.TXT_EMAIL.Location = New System.Drawing.Point(180, 206)
        Me.TXT_EMAIL.Name = "TXT_EMAIL"
        Me.TXT_EMAIL.Size = New System.Drawing.Size(160, 20)
        Me.TXT_EMAIL.TabIndex = 14
        Me.TXT_EMAIL.Visible = False
        '
        'LB_EMAIL
        '
        Me.LB_EMAIL.AutoSize = True
        Me.LB_EMAIL.Location = New System.Drawing.Point(6, 206)
        Me.LB_EMAIL.Name = "LB_EMAIL"
        Me.LB_EMAIL.Size = New System.Drawing.Size(58, 13)
        Me.LB_EMAIL.TabIndex = 13
        Me.LB_EMAIL.Text = "LB_EMAIL"
        Me.LB_EMAIL.Visible = False
        '
        'TXT_PHONENUMBER
        '
        Me.TXT_PHONENUMBER.Location = New System.Drawing.Point(180, 179)
        Me.TXT_PHONENUMBER.Name = "TXT_PHONENUMBER"
        Me.TXT_PHONENUMBER.Size = New System.Drawing.Size(160, 20)
        Me.TXT_PHONENUMBER.TabIndex = 12
        Me.TXT_PHONENUMBER.Visible = False
        '
        'LB_PHONENUMBER
        '
        Me.LB_PHONENUMBER.AutoSize = True
        Me.LB_PHONENUMBER.Location = New System.Drawing.Point(6, 179)
        Me.LB_PHONENUMBER.Name = "LB_PHONENUMBER"
        Me.LB_PHONENUMBER.Size = New System.Drawing.Size(111, 13)
        Me.LB_PHONENUMBER.TabIndex = 11
        Me.LB_PHONENUMBER.Text = "LB_PHONENUMBER"
        Me.LB_PHONENUMBER.Visible = False
        '
        'LB_PASSAGAIN
        '
        Me.LB_PASSAGAIN.AutoSize = True
        Me.LB_PASSAGAIN.Location = New System.Drawing.Point(6, 152)
        Me.LB_PASSAGAIN.Name = "LB_PASSAGAIN"
        Me.LB_PASSAGAIN.Size = New System.Drawing.Size(87, 13)
        Me.LB_PASSAGAIN.TabIndex = 10
        Me.LB_PASSAGAIN.Text = "LB_PASSAGAIN"
        Me.LB_PASSAGAIN.Visible = False
        '
        'TXT_PASSAGAIN
        '
        Me.TXT_PASSAGAIN.Location = New System.Drawing.Point(180, 152)
        Me.TXT_PASSAGAIN.Name = "TXT_PASSAGAIN"
        Me.TXT_PASSAGAIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_PASSAGAIN.Size = New System.Drawing.Size(160, 20)
        Me.TXT_PASSAGAIN.TabIndex = 9
        Me.TXT_PASSAGAIN.Visible = False
        '
        'TXT_PASSWORD
        '
        Me.TXT_PASSWORD.Location = New System.Drawing.Point(180, 125)
        Me.TXT_PASSWORD.Name = "TXT_PASSWORD"
        Me.TXT_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_PASSWORD.Size = New System.Drawing.Size(160, 20)
        Me.TXT_PASSWORD.TabIndex = 8
        Me.TXT_PASSWORD.Visible = False
        '
        'LB_PASSWORD
        '
        Me.LB_PASSWORD.AutoSize = True
        Me.LB_PASSWORD.Location = New System.Drawing.Point(7, 125)
        Me.LB_PASSWORD.Name = "LB_PASSWORD"
        Me.LB_PASSWORD.Size = New System.Drawing.Size(89, 13)
        Me.LB_PASSWORD.TabIndex = 7
        Me.LB_PASSWORD.Text = "LB_PASSWORD"
        Me.LB_PASSWORD.Visible = False
        '
        'LB_NAME
        '
        Me.LB_NAME.AutoSize = True
        Me.LB_NAME.Location = New System.Drawing.Point(7, 98)
        Me.LB_NAME.Name = "LB_NAME"
        Me.LB_NAME.Size = New System.Drawing.Size(57, 13)
        Me.LB_NAME.TabIndex = 6
        Me.LB_NAME.Text = "LB_NAME"
        Me.LB_NAME.Visible = False
        '
        'TXT_NAME
        '
        Me.TXT_NAME.Location = New System.Drawing.Point(180, 98)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(160, 20)
        Me.TXT_NAME.TabIndex = 5
        Me.TXT_NAME.Visible = False
        '
        'TXT_FIRSTNAME
        '
        Me.TXT_FIRSTNAME.Location = New System.Drawing.Point(180, 71)
        Me.TXT_FIRSTNAME.Name = "TXT_FIRSTNAME"
        Me.TXT_FIRSTNAME.Size = New System.Drawing.Size(161, 20)
        Me.TXT_FIRSTNAME.TabIndex = 4
        Me.TXT_FIRSTNAME.Visible = False
        '
        'LB_FIRSTNAME
        '
        Me.LB_FIRSTNAME.AutoSize = True
        Me.LB_FIRSTNAME.Location = New System.Drawing.Point(6, 71)
        Me.LB_FIRSTNAME.Name = "LB_FIRSTNAME"
        Me.LB_FIRSTNAME.Size = New System.Drawing.Size(88, 13)
        Me.LB_FIRSTNAME.TabIndex = 3
        Me.LB_FIRSTNAME.Text = "LB_FIRSTNAME"
        Me.LB_FIRSTNAME.Visible = False
        '
        'TXT_NICKNAME
        '
        Me.TXT_NICKNAME.Location = New System.Drawing.Point(180, 44)
        Me.TXT_NICKNAME.Name = "TXT_NICKNAME"
        Me.TXT_NICKNAME.Size = New System.Drawing.Size(162, 20)
        Me.TXT_NICKNAME.TabIndex = 2
        Me.TXT_NICKNAME.Visible = False
        '
        'LB_NICKNAME
        '
        Me.LB_NICKNAME.AutoSize = True
        Me.LB_NICKNAME.Location = New System.Drawing.Point(6, 44)
        Me.LB_NICKNAME.Name = "LB_NICKNAME"
        Me.LB_NICKNAME.Size = New System.Drawing.Size(82, 13)
        Me.LB_NICKNAME.TabIndex = 1
        Me.LB_NICKNAME.Text = "LB_NICKNAME"
        Me.LB_NICKNAME.Visible = False
        '
        'CB_MEMBER
        '
        Me.CB_MEMBER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MEMBER.FormattingEnabled = True
        Me.CB_MEMBER.Items.AddRange(New Object() {"Ajouter", "Supprimer", "Modifier"})
        Me.CB_MEMBER.Location = New System.Drawing.Point(7, 7)
        Me.CB_MEMBER.Name = "CB_MEMBER"
        Me.CB_MEMBER.Size = New System.Drawing.Size(185, 21)
        Me.CB_MEMBER.TabIndex = 0
        '
        'TP_ADMIN
        '
        Me.TP_ADMIN.Controls.Add(Me.CB_REMOVE_ADMIN)
        Me.TP_ADMIN.Controls.Add(Me.TXT_STATUS)
        Me.TP_ADMIN.Controls.Add(Me.LB_STATUS)
        Me.TP_ADMIN.Controls.Add(Me.TXT_ID)
        Me.TP_ADMIN.Controls.Add(Me.LB_ADM_TEXT)
        Me.TP_ADMIN.Controls.Add(Me.BT_ADM_CONFIRM)
        Me.TP_ADMIN.Controls.Add(Me.CB_ADMIN)
        Me.TP_ADMIN.Location = New System.Drawing.Point(4, 22)
        Me.TP_ADMIN.Name = "TP_ADMIN"
        Me.TP_ADMIN.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_ADMIN.Size = New System.Drawing.Size(348, 464)
        Me.TP_ADMIN.TabIndex = 1
        Me.TP_ADMIN.Text = "TP_ADMIN"
        Me.TP_ADMIN.UseVisualStyleBackColor = True
        '
        'CB_REMOVE_ADMIN
        '
        Me.CB_REMOVE_ADMIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_REMOVE_ADMIN.FormattingEnabled = True
        Me.CB_REMOVE_ADMIN.Location = New System.Drawing.Point(86, 49)
        Me.CB_REMOVE_ADMIN.Name = "CB_REMOVE_ADMIN"
        Me.CB_REMOVE_ADMIN.Size = New System.Drawing.Size(153, 21)
        Me.CB_REMOVE_ADMIN.TabIndex = 7
        Me.CB_REMOVE_ADMIN.Visible = False
        '
        'TXT_STATUS
        '
        Me.TXT_STATUS.Location = New System.Drawing.Point(181, 108)
        Me.TXT_STATUS.Name = "TXT_STATUS"
        Me.TXT_STATUS.Size = New System.Drawing.Size(161, 20)
        Me.TXT_STATUS.TabIndex = 6
        Me.TXT_STATUS.Visible = False
        '
        'LB_STATUS
        '
        Me.LB_STATUS.AutoSize = True
        Me.LB_STATUS.Location = New System.Drawing.Point(7, 108)
        Me.LB_STATUS.Name = "LB_STATUS"
        Me.LB_STATUS.Size = New System.Drawing.Size(69, 13)
        Me.LB_STATUS.TabIndex = 5
        Me.LB_STATUS.Text = "LB_STATUS"
        Me.LB_STATUS.Visible = False
        '
        'TXT_ID
        '
        Me.TXT_ID.Location = New System.Drawing.Point(181, 49)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(161, 20)
        Me.TXT_ID.TabIndex = 3
        Me.TXT_ID.Visible = False
        '
        'LB_ADM_TEXT
        '
        Me.LB_ADM_TEXT.AutoSize = True
        Me.LB_ADM_TEXT.Location = New System.Drawing.Point(7, 49)
        Me.LB_ADM_TEXT.Name = "LB_ADM_TEXT"
        Me.LB_ADM_TEXT.Size = New System.Drawing.Size(137, 13)
        Me.LB_ADM_TEXT.TabIndex = 2
        Me.LB_ADM_TEXT.Text = "Entrez email, id ou pseudo :"
        Me.LB_ADM_TEXT.Visible = False
        '
        'BT_ADM_CONFIRM
        '
        Me.BT_ADM_CONFIRM.Location = New System.Drawing.Point(86, 198)
        Me.BT_ADM_CONFIRM.Name = "BT_ADM_CONFIRM"
        Me.BT_ADM_CONFIRM.Size = New System.Drawing.Size(153, 23)
        Me.BT_ADM_CONFIRM.TabIndex = 1
        Me.BT_ADM_CONFIRM.Text = "BT_ADM_CONFIRM"
        Me.BT_ADM_CONFIRM.UseVisualStyleBackColor = True
        Me.BT_ADM_CONFIRM.Visible = False
        '
        'CB_ADMIN
        '
        Me.CB_ADMIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ADMIN.FormattingEnabled = True
        Me.CB_ADMIN.Items.AddRange(New Object() {"Ajouter", "Supprimer"})
        Me.CB_ADMIN.Location = New System.Drawing.Point(7, 7)
        Me.CB_ADMIN.Name = "CB_ADMIN"
        Me.CB_ADMIN.Size = New System.Drawing.Size(175, 21)
        Me.CB_ADMIN.TabIndex = 0
        '
        'TP_CREDIT
        '
        Me.TP_CREDIT.Controls.Add(Me.BT_CONFIRM)
        Me.TP_CREDIT.Controls.Add(Me.LB_VALUE)
        Me.TP_CREDIT.Controls.Add(Me.TXT_VALUE)
        Me.TP_CREDIT.Controls.Add(Me.TXT_CRED_ID)
        Me.TP_CREDIT.Controls.Add(Me.LB_TEXT)
        Me.TP_CREDIT.Controls.Add(Me.RB_DEBIT)
        Me.TP_CREDIT.Controls.Add(Me.RB_CREDIT)
        Me.TP_CREDIT.Location = New System.Drawing.Point(4, 22)
        Me.TP_CREDIT.Name = "TP_CREDIT"
        Me.TP_CREDIT.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_CREDIT.Size = New System.Drawing.Size(348, 464)
        Me.TP_CREDIT.TabIndex = 2
        Me.TP_CREDIT.Text = "TP_CREDIT"
        Me.TP_CREDIT.UseVisualStyleBackColor = True
        '
        'BT_CONFIRM
        '
        Me.BT_CONFIRM.Location = New System.Drawing.Point(97, 160)
        Me.BT_CONFIRM.Name = "BT_CONFIRM"
        Me.BT_CONFIRM.Size = New System.Drawing.Size(120, 23)
        Me.BT_CONFIRM.TabIndex = 6
        Me.BT_CONFIRM.Text = "BT_CONFIRM"
        Me.BT_CONFIRM.UseVisualStyleBackColor = True
        '
        'LB_VALUE
        '
        Me.LB_VALUE.AutoSize = True
        Me.LB_VALUE.Location = New System.Drawing.Point(7, 77)
        Me.LB_VALUE.Name = "LB_VALUE"
        Me.LB_VALUE.Size = New System.Drawing.Size(46, 13)
        Me.LB_VALUE.TabIndex = 5
        Me.LB_VALUE.Text = "Valeur : "
        '
        'TXT_VALUE
        '
        Me.TXT_VALUE.Location = New System.Drawing.Point(172, 77)
        Me.TXT_VALUE.Name = "TXT_VALUE"
        Me.TXT_VALUE.Size = New System.Drawing.Size(170, 20)
        Me.TXT_VALUE.TabIndex = 4
        '
        'TXT_CRED_ID
        '
        Me.TXT_CRED_ID.Location = New System.Drawing.Point(172, 50)
        Me.TXT_CRED_ID.Name = "TXT_CRED_ID"
        Me.TXT_CRED_ID.Size = New System.Drawing.Size(170, 20)
        Me.TXT_CRED_ID.TabIndex = 3
        '
        'LB_TEXT
        '
        Me.LB_TEXT.AutoSize = True
        Me.LB_TEXT.Location = New System.Drawing.Point(7, 50)
        Me.LB_TEXT.Name = "LB_TEXT"
        Me.LB_TEXT.Size = New System.Drawing.Size(137, 13)
        Me.LB_TEXT.TabIndex = 2
        Me.LB_TEXT.Text = "Entrez email, id ou pseudo :"
        '
        'RB_DEBIT
        '
        Me.RB_DEBIT.AutoSize = True
        Me.RB_DEBIT.Location = New System.Drawing.Point(172, 7)
        Me.RB_DEBIT.Name = "RB_DEBIT"
        Me.RB_DEBIT.Size = New System.Drawing.Size(78, 17)
        Me.RB_DEBIT.TabIndex = 1
        Me.RB_DEBIT.Text = "RB_DEBIT"
        Me.RB_DEBIT.UseVisualStyleBackColor = True
        '
        'RB_CREDIT
        '
        Me.RB_CREDIT.AutoSize = True
        Me.RB_CREDIT.Checked = True
        Me.RB_CREDIT.Location = New System.Drawing.Point(25, 7)
        Me.RB_CREDIT.Name = "RB_CREDIT"
        Me.RB_CREDIT.Size = New System.Drawing.Size(86, 17)
        Me.RB_CREDIT.TabIndex = 0
        Me.RB_CREDIT.TabStop = True
        Me.RB_CREDIT.Text = "RB_CREDIT"
        Me.RB_CREDIT.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TP_PRODUCT)
        Me.TabControl2.Controls.Add(Me.TP_STOCK)
        Me.TabControl2.Controls.Add(Me.TP_MONEY)
        Me.TabControl2.Location = New System.Drawing.Point(4, 4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(356, 489)
        Me.TabControl2.TabIndex = 0
        '
        'TP_PRODUCT
        '
        Me.TP_PRODUCT.Controls.Add(Me.CB_PRODUCT_MOD)
        Me.TP_PRODUCT.Controls.Add(Me.TXT_REMOVE_PRODUCT)
        Me.TP_PRODUCT.Controls.Add(Me.LB_REMOVE_PRODUCT)
        Me.TP_PRODUCT.Controls.Add(Me.BT_PROD_CONFIRM)
        Me.TP_PRODUCT.Controls.Add(Me.CBX_FRIDGE)
        Me.TP_PRODUCT.Controls.Add(Me.CB_TYPE)
        Me.TP_PRODUCT.Controls.Add(Me.TXT_STOCK)
        Me.TP_PRODUCT.Controls.Add(Me.LB_STOCK)
        Me.TP_PRODUCT.Controls.Add(Me.TXT_VALUEPOINT)
        Me.TP_PRODUCT.Controls.Add(Me.LB_VALUEPOINT)
        Me.TP_PRODUCT.Controls.Add(Me.TXT_PRICEPOINT)
        Me.TP_PRODUCT.Controls.Add(Me.LB_PRICEPOINT)
        Me.TP_PRODUCT.Controls.Add(Me.TXT_PRICESELL)
        Me.TP_PRODUCT.Controls.Add(Me.LB_PRICESELL)
        Me.TP_PRODUCT.Controls.Add(Me.TXT_PRICEBUY)
        Me.TP_PRODUCT.Controls.Add(Me.LB_PRICEBUY)
        Me.TP_PRODUCT.Controls.Add(Me.TXT_LABEL)
        Me.TP_PRODUCT.Controls.Add(Me.LB_LABEL)
        Me.TP_PRODUCT.Controls.Add(Me.CB_PRODUCT)
        Me.TP_PRODUCT.Location = New System.Drawing.Point(4, 22)
        Me.TP_PRODUCT.Name = "TP_PRODUCT"
        Me.TP_PRODUCT.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_PRODUCT.Size = New System.Drawing.Size(348, 463)
        Me.TP_PRODUCT.TabIndex = 0
        Me.TP_PRODUCT.Text = "TP_PRODUCT"
        Me.TP_PRODUCT.UseVisualStyleBackColor = True
        '
        'TXT_REMOVE_PRODUCT
        '
        Me.TXT_REMOVE_PRODUCT.Location = New System.Drawing.Point(170, 81)
        Me.TXT_REMOVE_PRODUCT.Name = "TXT_REMOVE_PRODUCT"
        Me.TXT_REMOVE_PRODUCT.Size = New System.Drawing.Size(172, 20)
        Me.TXT_REMOVE_PRODUCT.TabIndex = 17
        Me.TXT_REMOVE_PRODUCT.Visible = False
        '
        'LB_REMOVE_PRODUCT
        '
        Me.LB_REMOVE_PRODUCT.AutoSize = True
        Me.LB_REMOVE_PRODUCT.Location = New System.Drawing.Point(6, 81)
        Me.LB_REMOVE_PRODUCT.Name = "LB_REMOVE_PRODUCT"
        Me.LB_REMOVE_PRODUCT.Size = New System.Drawing.Size(88, 13)
        Me.LB_REMOVE_PRODUCT.TabIndex = 16
        Me.LB_REMOVE_PRODUCT.Text = "Entrez id ou label"
        Me.LB_REMOVE_PRODUCT.Visible = False
        '
        'BT_PROD_CONFIRM
        '
        Me.BT_PROD_CONFIRM.Location = New System.Drawing.Point(112, 314)
        Me.BT_PROD_CONFIRM.Name = "BT_PROD_CONFIRM"
        Me.BT_PROD_CONFIRM.Size = New System.Drawing.Size(123, 23)
        Me.BT_PROD_CONFIRM.TabIndex = 15
        Me.BT_PROD_CONFIRM.Text = "BT_PROD_CONFIRM"
        Me.BT_PROD_CONFIRM.UseVisualStyleBackColor = True
        Me.BT_PROD_CONFIRM.Visible = False
        '
        'CBX_FRIDGE
        '
        Me.CBX_FRIDGE.AutoSize = True
        Me.CBX_FRIDGE.Location = New System.Drawing.Point(170, 205)
        Me.CBX_FRIDGE.Name = "CBX_FRIDGE"
        Me.CBX_FRIDGE.Size = New System.Drawing.Size(93, 17)
        Me.CBX_FRIDGE.TabIndex = 14
        Me.CBX_FRIDGE.Text = "CBX_FRIDGE"
        Me.CBX_FRIDGE.UseVisualStyleBackColor = True
        Me.CBX_FRIDGE.Visible = False
        '
        'CB_TYPE
        '
        Me.CB_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_TYPE.FormattingEnabled = True
        Me.CB_TYPE.Location = New System.Drawing.Point(9, 205)
        Me.CB_TYPE.Name = "CB_TYPE"
        Me.CB_TYPE.Size = New System.Drawing.Size(147, 21)
        Me.CB_TYPE.TabIndex = 13
        Me.CB_TYPE.Visible = False
        '
        'TXT_STOCK
        '
        Me.TXT_STOCK.Location = New System.Drawing.Point(170, 178)
        Me.TXT_STOCK.Name = "TXT_STOCK"
        Me.TXT_STOCK.Size = New System.Drawing.Size(172, 20)
        Me.TXT_STOCK.TabIndex = 12
        Me.TXT_STOCK.Visible = False
        '
        'LB_STOCK
        '
        Me.LB_STOCK.AutoSize = True
        Me.LB_STOCK.Location = New System.Drawing.Point(6, 178)
        Me.LB_STOCK.Name = "LB_STOCK"
        Me.LB_STOCK.Size = New System.Drawing.Size(62, 13)
        Me.LB_STOCK.TabIndex = 11
        Me.LB_STOCK.Text = "LB_STOCK"
        Me.LB_STOCK.Visible = False
        '
        'TXT_VALUEPOINT
        '
        Me.TXT_VALUEPOINT.Location = New System.Drawing.Point(170, 151)
        Me.TXT_VALUEPOINT.Name = "TXT_VALUEPOINT"
        Me.TXT_VALUEPOINT.Size = New System.Drawing.Size(172, 20)
        Me.TXT_VALUEPOINT.TabIndex = 10
        Me.TXT_VALUEPOINT.Visible = False
        '
        'LB_VALUEPOINT
        '
        Me.LB_VALUEPOINT.AutoSize = True
        Me.LB_VALUEPOINT.Location = New System.Drawing.Point(6, 151)
        Me.LB_VALUEPOINT.Name = "LB_VALUEPOINT"
        Me.LB_VALUEPOINT.Size = New System.Drawing.Size(94, 13)
        Me.LB_VALUEPOINT.TabIndex = 9
        Me.LB_VALUEPOINT.Text = "LB_VALUEPOINT"
        Me.LB_VALUEPOINT.Visible = False
        '
        'TXT_PRICEPOINT
        '
        Me.TXT_PRICEPOINT.Location = New System.Drawing.Point(170, 124)
        Me.TXT_PRICEPOINT.Name = "TXT_PRICEPOINT"
        Me.TXT_PRICEPOINT.Size = New System.Drawing.Size(172, 20)
        Me.TXT_PRICEPOINT.TabIndex = 8
        Me.TXT_PRICEPOINT.Visible = False
        '
        'LB_PRICEPOINT
        '
        Me.LB_PRICEPOINT.AutoSize = True
        Me.LB_PRICEPOINT.Location = New System.Drawing.Point(6, 124)
        Me.LB_PRICEPOINT.Name = "LB_PRICEPOINT"
        Me.LB_PRICEPOINT.Size = New System.Drawing.Size(91, 13)
        Me.LB_PRICEPOINT.TabIndex = 7
        Me.LB_PRICEPOINT.Text = "LB_PRICEPOINT"
        Me.LB_PRICEPOINT.Visible = False
        '
        'TXT_PRICESELL
        '
        Me.TXT_PRICESELL.Location = New System.Drawing.Point(170, 97)
        Me.TXT_PRICESELL.Name = "TXT_PRICESELL"
        Me.TXT_PRICESELL.Size = New System.Drawing.Size(172, 20)
        Me.TXT_PRICESELL.TabIndex = 6
        Me.TXT_PRICESELL.Visible = False
        '
        'LB_PRICESELL
        '
        Me.LB_PRICESELL.AutoSize = True
        Me.LB_PRICESELL.Location = New System.Drawing.Point(6, 97)
        Me.LB_PRICESELL.Name = "LB_PRICESELL"
        Me.LB_PRICESELL.Size = New System.Drawing.Size(84, 13)
        Me.LB_PRICESELL.TabIndex = 5
        Me.LB_PRICESELL.Text = "LB_PRICESELL"
        Me.LB_PRICESELL.Visible = False
        '
        'TXT_PRICEBUY
        '
        Me.TXT_PRICEBUY.Location = New System.Drawing.Point(170, 70)
        Me.TXT_PRICEBUY.Name = "TXT_PRICEBUY"
        Me.TXT_PRICEBUY.Size = New System.Drawing.Size(172, 20)
        Me.TXT_PRICEBUY.TabIndex = 4
        Me.TXT_PRICEBUY.Visible = False
        '
        'LB_PRICEBUY
        '
        Me.LB_PRICEBUY.AutoSize = True
        Me.LB_PRICEBUY.Location = New System.Drawing.Point(6, 70)
        Me.LB_PRICEBUY.Name = "LB_PRICEBUY"
        Me.LB_PRICEBUY.Size = New System.Drawing.Size(80, 13)
        Me.LB_PRICEBUY.TabIndex = 3
        Me.LB_PRICEBUY.Text = "LB_PRICEBUY"
        Me.LB_PRICEBUY.Visible = False
        '
        'TXT_LABEL
        '
        Me.TXT_LABEL.Location = New System.Drawing.Point(170, 43)
        Me.TXT_LABEL.Name = "TXT_LABEL"
        Me.TXT_LABEL.Size = New System.Drawing.Size(172, 20)
        Me.TXT_LABEL.TabIndex = 2
        Me.TXT_LABEL.Visible = False
        '
        'LB_LABEL
        '
        Me.LB_LABEL.AutoSize = True
        Me.LB_LABEL.Location = New System.Drawing.Point(6, 43)
        Me.LB_LABEL.Name = "LB_LABEL"
        Me.LB_LABEL.Size = New System.Drawing.Size(59, 13)
        Me.LB_LABEL.TabIndex = 1
        Me.LB_LABEL.Text = "LB_LABEL"
        Me.LB_LABEL.Visible = False
        '
        'CB_PRODUCT
        '
        Me.CB_PRODUCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_PRODUCT.FormattingEnabled = True
        Me.CB_PRODUCT.Items.AddRange(New Object() {"Ajouter", "Modifier", "Supprimer"})
        Me.CB_PRODUCT.Location = New System.Drawing.Point(7, 7)
        Me.CB_PRODUCT.Name = "CB_PRODUCT"
        Me.CB_PRODUCT.Size = New System.Drawing.Size(187, 21)
        Me.CB_PRODUCT.TabIndex = 0
        '
        'TP_STOCK
        '
        Me.TP_STOCK.Location = New System.Drawing.Point(4, 22)
        Me.TP_STOCK.Name = "TP_STOCK"
        Me.TP_STOCK.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_STOCK.Size = New System.Drawing.Size(348, 463)
        Me.TP_STOCK.TabIndex = 1
        Me.TP_STOCK.Text = "TP_STOCK"
        Me.TP_STOCK.UseVisualStyleBackColor = True
        '
        'TP_MONEY
        '
        Me.TP_MONEY.Controls.Add(Me.BT_DO_SUM)
        Me.TP_MONEY.Controls.Add(Me.BT_ADD_TRANSAC)
        Me.TP_MONEY.Controls.Add(Me.TXT_MONEY)
        Me.TP_MONEY.Location = New System.Drawing.Point(4, 22)
        Me.TP_MONEY.Name = "TP_MONEY"
        Me.TP_MONEY.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_MONEY.Size = New System.Drawing.Size(348, 463)
        Me.TP_MONEY.TabIndex = 2
        Me.TP_MONEY.Text = "TP_MONEY"
        Me.TP_MONEY.UseVisualStyleBackColor = True
        '
        'BT_DO_SUM
        '
        Me.BT_DO_SUM.Location = New System.Drawing.Point(7, 167)
        Me.BT_DO_SUM.Name = "BT_DO_SUM"
        Me.BT_DO_SUM.Size = New System.Drawing.Size(335, 23)
        Me.BT_DO_SUM.TabIndex = 2
        Me.BT_DO_SUM.Text = "BT_DO_SUM"
        Me.BT_DO_SUM.UseVisualStyleBackColor = True
        '
        'BT_ADD_TRANSAC
        '
        Me.BT_ADD_TRANSAC.Location = New System.Drawing.Point(163, 41)
        Me.BT_ADD_TRANSAC.Name = "BT_ADD_TRANSAC"
        Me.BT_ADD_TRANSAC.Size = New System.Drawing.Size(179, 23)
        Me.BT_ADD_TRANSAC.TabIndex = 1
        Me.BT_ADD_TRANSAC.Text = "BT_ADD_TRANSAC"
        Me.BT_ADD_TRANSAC.UseVisualStyleBackColor = True
        '
        'TXT_MONEY
        '
        Me.TXT_MONEY.Location = New System.Drawing.Point(7, 42)
        Me.TXT_MONEY.Name = "TXT_MONEY"
        Me.TXT_MONEY.Size = New System.Drawing.Size(149, 20)
        Me.TXT_MONEY.TabIndex = 0
        '
        'CB_PRODUCT_MOD
        '
        Me.CB_PRODUCT_MOD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_PRODUCT_MOD.FormattingEnabled = True
        Me.CB_PRODUCT_MOD.Location = New System.Drawing.Point(201, 7)
        Me.CB_PRODUCT_MOD.Name = "CB_PRODUCT_MOD"
        Me.CB_PRODUCT_MOD.Size = New System.Drawing.Size(141, 21)
        Me.CB_PRODUCT_MOD.TabIndex = 18
        Me.CB_PRODUCT_MOD.Visible = False
        '
        'administration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 496)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "administration"
        Me.Text = "administration"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TP_MEMBER.ResumeLayout(False)
        Me.TP_MEMBER.PerformLayout()
        Me.TP_ADMIN.ResumeLayout(False)
        Me.TP_ADMIN.PerformLayout()
        Me.TP_CREDIT.ResumeLayout(False)
        Me.TP_CREDIT.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TP_PRODUCT.ResumeLayout(False)
        Me.TP_PRODUCT.PerformLayout()
        Me.TP_MONEY.ResumeLayout(False)
        Me.TP_MONEY.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TP_MEMBER As TabPage
    Friend WithEvents TP_ADMIN As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TP_PRODUCT As TabPage
    Friend WithEvents TP_STOCK As TabPage
    Friend WithEvents TP_CREDIT As TabPage
    Friend WithEvents TP_MONEY As TabPage
    Friend WithEvents CB_MEMBER As ComboBox
    Friend WithEvents CB_ADMIN As ComboBox
    Friend WithEvents BT_CONFIRM As Button
    Friend WithEvents LB_VALUE As Label
    Friend WithEvents TXT_VALUE As TextBox
    Friend WithEvents TXT_CRED_ID As TextBox
    Friend WithEvents LB_TEXT As Label
    Friend WithEvents RB_DEBIT As RadioButton
    Friend WithEvents RB_CREDIT As RadioButton
    Friend WithEvents CB_PRODUCT As ComboBox
    Friend WithEvents LB_PASSAGAIN As Label
    Friend WithEvents TXT_PASSAGAIN As TextBox
    Friend WithEvents TXT_PASSWORD As TextBox
    Friend WithEvents LB_PASSWORD As Label
    Friend WithEvents LB_NAME As Label
    Friend WithEvents TXT_NAME As TextBox
    Friend WithEvents TXT_FIRSTNAME As TextBox
    Friend WithEvents LB_FIRSTNAME As Label
    Friend WithEvents TXT_NICKNAME As TextBox
    Friend WithEvents LB_NICKNAME As Label
    Friend WithEvents TXT_EMAIL As TextBox
    Friend WithEvents LB_EMAIL As Label
    Friend WithEvents TXT_PHONENUMBER As TextBox
    Friend WithEvents LB_PHONENUMBER As Label
    Friend WithEvents TXT_BALANCE As TextBox
    Friend WithEvents LB_BALANCE As Label
    Friend WithEvents TXT_POINTS As TextBox
    Friend WithEvents LB_POINTS As Label
    Friend WithEvents CBX_ALLOWNEG As CheckBox
    Friend WithEvents BT_MEM_CONFIRM As Button
    Friend WithEvents CB_REMOVE_ADMIN As ComboBox
    Friend WithEvents TXT_STATUS As TextBox
    Friend WithEvents LB_STATUS As Label
    Friend WithEvents TXT_ID As TextBox
    Friend WithEvents LB_ADM_TEXT As Label
    Friend WithEvents BT_ADM_CONFIRM As Button
    Friend WithEvents TXT_LABEL As TextBox
    Friend WithEvents LB_LABEL As Label
    Friend WithEvents BT_ADD_TRANSAC As Button
    Friend WithEvents TXT_MONEY As TextBox
    Friend WithEvents BT_DO_SUM As Button
    Friend WithEvents TXT_PRICESELL As TextBox
    Friend WithEvents LB_PRICESELL As Label
    Friend WithEvents TXT_PRICEBUY As TextBox
    Friend WithEvents LB_PRICEBUY As Label
    Friend WithEvents TXT_VALUEPOINT As TextBox
    Friend WithEvents LB_VALUEPOINT As Label
    Friend WithEvents TXT_PRICEPOINT As TextBox
    Friend WithEvents LB_PRICEPOINT As Label
    Friend WithEvents TXT_STOCK As TextBox
    Friend WithEvents LB_STOCK As Label
    Friend WithEvents CB_TYPE As ComboBox
    Friend WithEvents CBX_FRIDGE As CheckBox
    Friend WithEvents BT_PROD_CONFIRM As Button
    Friend WithEvents TXT_REMOVE_USER As TextBox
    Friend WithEvents LB_REMOVE_USER As Label
    Friend WithEvents CB_SELECT_USER As ComboBox
    Friend WithEvents TXT_REMOVE_PRODUCT As TextBox
    Friend WithEvents LB_REMOVE_PRODUCT As Label
    Friend WithEvents CB_PRODUCT_MOD As ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class firstconnection
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.LB_NAME = New System.Windows.Forms.Label()
        Me.LB_LANG = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_PASSWORD = New System.Windows.Forms.TextBox()
        Me.CB_LANG = New System.Windows.Forms.ComboBox()
        Me.LB_PASSWORD = New System.Windows.Forms.Label()
        Me.BT_CONFIRM = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_NAME
        '
        Me.TXT_NAME.Location = New System.Drawing.Point(6, 19)
        Me.TXT_NAME.MaxLength = 32
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(131, 20)
        Me.TXT_NAME.TabIndex = 0
        '
        'LB_NAME
        '
        Me.LB_NAME.AutoSize = True
        Me.LB_NAME.Location = New System.Drawing.Point(12, 38)
        Me.LB_NAME.Name = "LB_NAME"
        Me.LB_NAME.Size = New System.Drawing.Size(57, 13)
        Me.LB_NAME.TabIndex = 1
        Me.LB_NAME.Text = "LB_NAME"
        '
        'LB_LANG
        '
        Me.LB_LANG.AutoSize = True
        Me.LB_LANG.Location = New System.Drawing.Point(12, 60)
        Me.LB_LANG.Name = "LB_LANG"
        Me.LB_LANG.Size = New System.Drawing.Size(55, 13)
        Me.LB_LANG.TabIndex = 2
        Me.LB_LANG.Text = "LB_LANG"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_PASSWORD)
        Me.GroupBox1.Controls.Add(Me.CB_LANG)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME)
        Me.GroupBox1.Location = New System.Drawing.Point(162, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'TXT_PASSWORD
        '
        Me.TXT_PASSWORD.Location = New System.Drawing.Point(7, 73)
        Me.TXT_PASSWORD.MaxLength = 16
        Me.TXT_PASSWORD.Name = "TXT_PASSWORD"
        Me.TXT_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_PASSWORD.Size = New System.Drawing.Size(130, 20)
        Me.TXT_PASSWORD.TabIndex = 2
        '
        'CB_LANG
        '
        Me.CB_LANG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_LANG.FormattingEnabled = True
        Me.CB_LANG.Location = New System.Drawing.Point(6, 45)
        Me.CB_LANG.Name = "CB_LANG"
        Me.CB_LANG.Size = New System.Drawing.Size(131, 21)
        Me.CB_LANG.TabIndex = 1
        '
        'LB_PASSWORD
        '
        Me.LB_PASSWORD.AutoSize = True
        Me.LB_PASSWORD.Location = New System.Drawing.Point(12, 85)
        Me.LB_PASSWORD.Name = "LB_PASSWORD"
        Me.LB_PASSWORD.Size = New System.Drawing.Size(89, 13)
        Me.LB_PASSWORD.TabIndex = 5
        Me.LB_PASSWORD.Text = "LB_PASSWORD"
        '
        'BT_CONFIRM
        '
        Me.BT_CONFIRM.Location = New System.Drawing.Point(107, 117)
        Me.BT_CONFIRM.Name = "BT_CONFIRM"
        Me.BT_CONFIRM.Size = New System.Drawing.Size(104, 23)
        Me.BT_CONFIRM.TabIndex = 6
        Me.BT_CONFIRM.Text = "BT_CONFIRM"
        Me.BT_CONFIRM.UseVisualStyleBackColor = True
        '
        'firstconnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 152)
        Me.Controls.Add(Me.BT_CONFIRM)
        Me.Controls.Add(Me.LB_PASSWORD)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LB_LANG)
        Me.Controls.Add(Me.LB_NAME)
        Me.Name = "firstconnection"
        Me.Text = "firstconnection"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_NAME As TextBox
    Friend WithEvents LB_NAME As Label
    Friend WithEvents LB_LANG As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CB_LANG As ComboBox
    Friend WithEvents TXT_PASSWORD As TextBox
    Friend WithEvents LB_PASSWORD As Label
    Friend WithEvents BT_CONFIRM As Button
End Class

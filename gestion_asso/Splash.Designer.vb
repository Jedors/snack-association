<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SPLASH
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
        Me.LB_NICKNAME = New System.Windows.Forms.Label()
        Me.LB_PASSWORD = New System.Windows.Forms.Label()
        Me.TXT_NICKNAME = New System.Windows.Forms.TextBox()
        Me.TXT_PASSWORD = New System.Windows.Forms.TextBox()
        Me.BT_CONFIRM = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LB_NICKNAME
        '
        Me.LB_NICKNAME.AutoSize = True
        Me.LB_NICKNAME.Location = New System.Drawing.Point(12, 15)
        Me.LB_NICKNAME.Name = "LB_NICKNAME"
        Me.LB_NICKNAME.Size = New System.Drawing.Size(82, 13)
        Me.LB_NICKNAME.TabIndex = 0
        Me.LB_NICKNAME.Text = "LB_NICKNAME"
        '
        'LB_PASSWORD
        '
        Me.LB_PASSWORD.AutoSize = True
        Me.LB_PASSWORD.Location = New System.Drawing.Point(12, 41)
        Me.LB_PASSWORD.Name = "LB_PASSWORD"
        Me.LB_PASSWORD.Size = New System.Drawing.Size(89, 13)
        Me.LB_PASSWORD.TabIndex = 1
        Me.LB_PASSWORD.Text = "LB_PASSWORD"
        '
        'TXT_NICKNAME
        '
        Me.TXT_NICKNAME.Location = New System.Drawing.Point(162, 12)
        Me.TXT_NICKNAME.MaxLength = 32
        Me.TXT_NICKNAME.Name = "TXT_NICKNAME"
        Me.TXT_NICKNAME.Size = New System.Drawing.Size(131, 20)
        Me.TXT_NICKNAME.TabIndex = 2
        '
        'TXT_PASSWORD
        '
        Me.TXT_PASSWORD.Location = New System.Drawing.Point(162, 38)
        Me.TXT_PASSWORD.MaxLength = 16
        Me.TXT_PASSWORD.Name = "TXT_PASSWORD"
        Me.TXT_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_PASSWORD.Size = New System.Drawing.Size(131, 20)
        Me.TXT_PASSWORD.TabIndex = 3
        '
        'BT_CONFIRM
        '
        Me.BT_CONFIRM.Location = New System.Drawing.Point(92, 64)
        Me.BT_CONFIRM.Name = "BT_CONFIRM"
        Me.BT_CONFIRM.Size = New System.Drawing.Size(114, 23)
        Me.BT_CONFIRM.TabIndex = 4
        Me.BT_CONFIRM.Text = "BT_CONFIRM"
        Me.BT_CONFIRM.UseVisualStyleBackColor = True
        '
        'SPLASH
        '
        Me.AcceptButton = Me.BT_CONFIRM
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 95)
        Me.Controls.Add(Me.BT_CONFIRM)
        Me.Controls.Add(Me.TXT_PASSWORD)
        Me.Controls.Add(Me.TXT_NICKNAME)
        Me.Controls.Add(Me.LB_PASSWORD)
        Me.Controls.Add(Me.LB_NICKNAME)
        Me.Name = "SPLASH"
        Me.Text = "Splash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LB_NICKNAME As Label
    Friend WithEvents LB_PASSWORD As Label
    Friend WithEvents TXT_NICKNAME As TextBox
    Friend WithEvents TXT_PASSWORD As TextBox
    Friend WithEvents BT_CONFIRM As Button
End Class

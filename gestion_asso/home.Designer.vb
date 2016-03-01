<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Me.BT_CLOSE = New System.Windows.Forms.Button()
        Me.BT_ADMIN = New System.Windows.Forms.Button()
        Me.BT_HELP = New System.Windows.Forms.Button()
        Me.BT_SHOP = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LB_TEXT = New System.Windows.Forms.Label()
        Me.BT_INSTANT = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BT_CLOSE
        '
        Me.BT_CLOSE.Location = New System.Drawing.Point(310, 201)
        Me.BT_CLOSE.Name = "BT_CLOSE"
        Me.BT_CLOSE.Size = New System.Drawing.Size(85, 23)
        Me.BT_CLOSE.TabIndex = 0
        Me.BT_CLOSE.Text = "BT_CLOSE"
        Me.BT_CLOSE.UseVisualStyleBackColor = True
        '
        'BT_ADMIN
        '
        Me.BT_ADMIN.Location = New System.Drawing.Point(23, 25)
        Me.BT_ADMIN.Name = "BT_ADMIN"
        Me.BT_ADMIN.Size = New System.Drawing.Size(108, 23)
        Me.BT_ADMIN.TabIndex = 1
        Me.BT_ADMIN.Text = "BT_ADMIN"
        Me.BT_ADMIN.UseVisualStyleBackColor = True
        '
        'BT_HELP
        '
        Me.BT_HELP.Location = New System.Drawing.Point(23, 55)
        Me.BT_HELP.Name = "BT_HELP"
        Me.BT_HELP.Size = New System.Drawing.Size(75, 23)
        Me.BT_HELP.TabIndex = 2
        Me.BT_HELP.Text = "BT_HELP"
        Me.BT_HELP.UseVisualStyleBackColor = True
        '
        'BT_SHOP
        '
        Me.BT_SHOP.Location = New System.Drawing.Point(23, 85)
        Me.BT_SHOP.Name = "BT_SHOP"
        Me.BT_SHOP.Size = New System.Drawing.Size(93, 23)
        Me.BT_SHOP.TabIndex = 3
        Me.BT_SHOP.Text = "BT_SHOP"
        Me.BT_SHOP.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LB_TEXT)
        Me.GroupBox1.Location = New System.Drawing.Point(195, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 183)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'LB_TEXT
        '
        Me.LB_TEXT.AutoSize = True
        Me.LB_TEXT.Location = New System.Drawing.Point(7, 20)
        Me.LB_TEXT.Name = "LB_TEXT"
        Me.LB_TEXT.Size = New System.Drawing.Size(39, 13)
        Me.LB_TEXT.TabIndex = 0
        Me.LB_TEXT.Text = "Label1"
        '
        'BT_INSTANT
        '
        Me.BT_INSTANT.Location = New System.Drawing.Point(23, 114)
        Me.BT_INSTANT.Name = "BT_INSTANT"
        Me.BT_INSTANT.Size = New System.Drawing.Size(108, 23)
        Me.BT_INSTANT.TabIndex = 6
        Me.BT_INSTANT.Text = "BT_INSTANT"
        Me.BT_INSTANT.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 236)
        Me.Controls.Add(Me.BT_INSTANT)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BT_SHOP)
        Me.Controls.Add(Me.BT_HELP)
        Me.Controls.Add(Me.BT_ADMIN)
        Me.Controls.Add(Me.BT_CLOSE)
        Me.Name = "home"
        Me.Text = "home"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BT_CLOSE As Button
    Friend WithEvents BT_ADMIN As Button
    Friend WithEvents BT_HELP As Button
    Friend WithEvents BT_SHOP As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LB_TEXT As Label
    Friend WithEvents BT_INSTANT As Button
End Class

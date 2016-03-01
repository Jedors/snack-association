<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class help
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
        Me.LB_TEXT_1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BT_CLOSE
        '
        Me.BT_CLOSE.Location = New System.Drawing.Point(530, 247)
        Me.BT_CLOSE.Name = "BT_CLOSE"
        Me.BT_CLOSE.Size = New System.Drawing.Size(87, 23)
        Me.BT_CLOSE.TabIndex = 0
        Me.BT_CLOSE.Text = "BT_CLOSE"
        Me.BT_CLOSE.UseVisualStyleBackColor = True
        '
        'LB_TEXT_1
        '
        Me.LB_TEXT_1.AutoSize = True
        Me.LB_TEXT_1.Location = New System.Drawing.Point(13, 13)
        Me.LB_TEXT_1.Name = "LB_TEXT_1"
        Me.LB_TEXT_1.Size = New System.Drawing.Size(66, 13)
        Me.LB_TEXT_1.TabIndex = 1
        Me.LB_TEXT_1.Text = "LB_TEXT_1"
        Me.LB_TEXT_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 282)
        Me.Controls.Add(Me.LB_TEXT_1)
        Me.Controls.Add(Me.BT_CLOSE)
        Me.Name = "help"
        Me.Text = "help"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_CLOSE As Button
    Friend WithEvents LB_TEXT_1 As Label
End Class

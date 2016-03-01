<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shop
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
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BT_CLOSE = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV.Location = New System.Drawing.Point(13, 13)
        Me.DGV.MultiSelect = False
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGV.Size = New System.Drawing.Size(598, 304)
        Me.DGV.TabIndex = 0
        '
        'BT_CLOSE
        '
        Me.BT_CLOSE.Location = New System.Drawing.Point(504, 328)
        Me.BT_CLOSE.Name = "BT_CLOSE"
        Me.BT_CLOSE.Size = New System.Drawing.Size(107, 23)
        Me.BT_CLOSE.TabIndex = 1
        Me.BT_CLOSE.Text = "BT_CLOSE"
        Me.BT_CLOSE.UseVisualStyleBackColor = True
        '
        'shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 363)
        Me.Controls.Add(Me.BT_CLOSE)
        Me.Controls.Add(Me.DGV)
        Me.Name = "shop"
        Me.Text = "shop"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents BT_CLOSE As Button
End Class

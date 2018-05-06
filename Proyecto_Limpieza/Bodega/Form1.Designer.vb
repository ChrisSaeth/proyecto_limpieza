<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuPrincipalBodega = New System.Windows.Forms.Label()
        Me.Alta = New System.Windows.Forms.Button()
        Me.Baja = New System.Windows.Forms.Button()
        Me.Cambio = New System.Windows.Forms.Button()
        Me.Consulta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MenuPrincipalBodega
        '
        Me.MenuPrincipalBodega.AutoSize = True
        Me.MenuPrincipalBodega.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuPrincipalBodega.Location = New System.Drawing.Point(142, 9)
        Me.MenuPrincipalBodega.Name = "MenuPrincipalBodega"
        Me.MenuPrincipalBodega.Size = New System.Drawing.Size(472, 48)
        Me.MenuPrincipalBodega.TabIndex = 0
        Me.MenuPrincipalBodega.Text = "Menú Principal Bodega"
        '
        'Alta
        '
        Me.Alta.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alta.Location = New System.Drawing.Point(263, 104)
        Me.Alta.Name = "Alta"
        Me.Alta.Size = New System.Drawing.Size(240, 80)
        Me.Alta.TabIndex = 1
        Me.Alta.Text = "Alta"
        Me.Alta.UseVisualStyleBackColor = True
        '
        'Baja
        '
        Me.Baja.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Baja.Location = New System.Drawing.Point(263, 205)
        Me.Baja.Name = "Baja"
        Me.Baja.Size = New System.Drawing.Size(240, 80)
        Me.Baja.TabIndex = 2
        Me.Baja.Text = "Baja"
        Me.Baja.UseVisualStyleBackColor = True
        '
        'Cambio
        '
        Me.Cambio.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cambio.Location = New System.Drawing.Point(263, 308)
        Me.Cambio.Name = "Cambio"
        Me.Cambio.Size = New System.Drawing.Size(240, 80)
        Me.Cambio.TabIndex = 3
        Me.Cambio.Text = "Cambio "
        Me.Cambio.UseVisualStyleBackColor = True
        '
        'Consulta
        '
        Me.Consulta.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consulta.Location = New System.Drawing.Point(263, 414)
        Me.Consulta.Name = "Consulta"
        Me.Consulta.Size = New System.Drawing.Size(240, 80)
        Me.Consulta.TabIndex = 4
        Me.Consulta.Text = "Consulta"
        Me.Consulta.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(767, 539)
        Me.Controls.Add(Me.Consulta)
        Me.Controls.Add(Me.Cambio)
        Me.Controls.Add(Me.Baja)
        Me.Controls.Add(Me.Alta)
        Me.Controls.Add(Me.MenuPrincipalBodega)
        Me.Font = New System.Drawing.Font("Modern No. 20", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Bodega"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuPrincipalBodega As System.Windows.Forms.Label
    Friend WithEvents Alta As System.Windows.Forms.Button
    Friend WithEvents Baja As System.Windows.Forms.Button
    Friend WithEvents Cambio As System.Windows.Forms.Button
    Friend WithEvents Consulta As System.Windows.Forms.Button

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.B_Generar_Usuario = New System.Windows.Forms.Button()
        Me.TB_Respuesta = New System.Windows.Forms.TextBox()
        Me.B_Generar_Sucursal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'B_Generar_Usuario
        '
        Me.B_Generar_Usuario.Location = New System.Drawing.Point(65, 79)
        Me.B_Generar_Usuario.Name = "B_Generar_Usuario"
        Me.B_Generar_Usuario.Size = New System.Drawing.Size(169, 64)
        Me.B_Generar_Usuario.TabIndex = 0
        Me.B_Generar_Usuario.Text = "Generar usuario de prueba"
        Me.B_Generar_Usuario.UseVisualStyleBackColor = True
        '
        'TB_Respuesta
        '
        Me.TB_Respuesta.Location = New System.Drawing.Point(54, 230)
        Me.TB_Respuesta.Multiline = True
        Me.TB_Respuesta.Name = "TB_Respuesta"
        Me.TB_Respuesta.Size = New System.Drawing.Size(539, 165)
        Me.TB_Respuesta.TabIndex = 1
        '
        'B_Generar_Sucursal
        '
        Me.B_Generar_Sucursal.Location = New System.Drawing.Point(279, 79)
        Me.B_Generar_Sucursal.Name = "B_Generar_Sucursal"
        Me.B_Generar_Sucursal.Size = New System.Drawing.Size(169, 64)
        Me.B_Generar_Sucursal.TabIndex = 2
        Me.B_Generar_Sucursal.Text = "Generar sucursal"
        Me.B_Generar_Sucursal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.B_Generar_Sucursal)
        Me.Controls.Add(Me.TB_Respuesta)
        Me.Controls.Add(Me.B_Generar_Usuario)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_Generar_Usuario As Button
    Friend WithEvents TB_Respuesta As TextBox
    Friend WithEvents B_Generar_Sucursal As Button
End Class

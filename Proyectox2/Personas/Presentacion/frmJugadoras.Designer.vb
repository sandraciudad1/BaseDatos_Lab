<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJugadoras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LstJugadoras = New System.Windows.Forms.ListBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAbrirBD = New System.Windows.Forms.Button()
        Me.BtnAnadir = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.txtPuntos = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LstJugadoras
        '
        Me.LstJugadoras.FormattingEnabled = True
        Me.LstJugadoras.ItemHeight = 16
        Me.LstJugadoras.Location = New System.Drawing.Point(69, 51)
        Me.LstJugadoras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LstJugadoras.Name = "LstJugadoras"
        Me.LstJugadoras.Size = New System.Drawing.Size(204, 212)
        Me.LstJugadoras.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(373, 94)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(189, 22)
        Me.txtID.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(374, 126)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.MaxLength = 45
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(188, 22)
        Me.txtNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'btnAbrirBD
        '
        Me.btnAbrirBD.Location = New System.Drawing.Point(84, 290)
        Me.btnAbrirBD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbrirBD.Name = "btnAbrirBD"
        Me.btnAbrirBD.Size = New System.Drawing.Size(166, 59)
        Me.btnAbrirBD.TabIndex = 5
        Me.btnAbrirBD.Text = "Ver Jugadoras"
        Me.btnAbrirBD.UseVisualStyleBackColor = True
        '
        'BtnAnadir
        '
        Me.BtnAnadir.Enabled = False
        Me.BtnAnadir.Location = New System.Drawing.Point(347, 267)
        Me.BtnAnadir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAnadir.Name = "BtnAnadir"
        Me.BtnAnadir.Size = New System.Drawing.Size(98, 41)
        Me.BtnAnadir.TabIndex = 6
        Me.BtnAnadir.Text = "Añadir"
        Me.BtnAnadir.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Enabled = False
        Me.BtnActualizar.Location = New System.Drawing.Point(465, 269)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(97, 39)
        Me.BtnActualizar.TabIndex = 7
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Location = New System.Drawing.Point(347, 323)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(97, 43)
        Me.BtnEliminar.TabIndex = 8
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(465, 323)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(96, 42)
        Me.BtnLimpiar.TabIndex = 9
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'txtPuntos
        '
        Me.txtPuntos.Location = New System.Drawing.Point(374, 162)
        Me.txtPuntos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPuntos.Name = "txtPuntos"
        Me.txtPuntos.Size = New System.Drawing.Size(188, 22)
        Me.txtPuntos.TabIndex = 11
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(373, 197)
        Me.txtPais.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPais.MaxLength = 3
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(189, 22)
        Me.txtPais.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(315, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Puntos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(332, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "País"
        '
        'frmJugadoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 390)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.txtPuntos)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnAnadir)
        Me.Controls.Add(Me.btnAbrirBD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LstJugadoras)
        Me.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJugadoras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jugadoras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstJugadoras As ListBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAbrirBD As Button
    Friend WithEvents BtnAnadir As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents txtPuntos As TextBox
    Friend WithEvents txtPais As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class

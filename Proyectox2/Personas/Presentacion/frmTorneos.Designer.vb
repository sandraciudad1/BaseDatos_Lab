<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTorneos
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnAnadir = New System.Windows.Forms.Button()
        Me.btnAbrirBD = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.LstTorneos = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "País"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Ciudad"
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(395, 182)
        Me.txtPais.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPais.MaxLength = 3
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(153, 22)
        Me.txtPais.TabIndex = 28
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(396, 147)
        Me.txtCiudad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(153, 22)
        Me.txtCiudad.TabIndex = 27
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(452, 315)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(96, 42)
        Me.BtnLimpiar.TabIndex = 25
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Location = New System.Drawing.Point(334, 315)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(97, 43)
        Me.BtnEliminar.TabIndex = 24
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Enabled = False
        Me.BtnActualizar.Location = New System.Drawing.Point(452, 261)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(97, 39)
        Me.BtnActualizar.TabIndex = 23
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnAnadir
        '
        Me.BtnAnadir.Enabled = False
        Me.BtnAnadir.Location = New System.Drawing.Point(334, 259)
        Me.BtnAnadir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAnadir.Name = "BtnAnadir"
        Me.BtnAnadir.Size = New System.Drawing.Size(98, 41)
        Me.BtnAnadir.TabIndex = 22
        Me.BtnAnadir.Text = "Añadir"
        Me.BtnAnadir.UseVisualStyleBackColor = True
        '
        'btnAbrirBD
        '
        Me.btnAbrirBD.Location = New System.Drawing.Point(81, 279)
        Me.btnAbrirBD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbrirBD.Name = "btnAbrirBD"
        Me.btnAbrirBD.Size = New System.Drawing.Size(166, 59)
        Me.btnAbrirBD.TabIndex = 21
        Me.btnAbrirBD.Text = "Ver Torneos"
        Me.btnAbrirBD.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(331, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ID"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(396, 111)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.MaxLength = 45
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(153, 22)
        Me.txtNombre.TabIndex = 18
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(395, 79)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(154, 22)
        Me.txtID.TabIndex = 17
        '
        'LstTorneos
        '
        Me.LstTorneos.FormattingEnabled = True
        Me.LstTorneos.ItemHeight = 16
        Me.LstTorneos.Location = New System.Drawing.Point(63, 32)
        Me.LstTorneos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LstTorneos.Name = "LstTorneos"
        Me.LstTorneos.Size = New System.Drawing.Size(204, 212)
        Me.LstTorneos.TabIndex = 16
        '
        'frmTorneos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 390)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnAnadir)
        Me.Controls.Add(Me.btnAbrirBD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LstTorneos)
        Me.Name = "frmTorneos"
        Me.Text = "frmTorneos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPais As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAnadir As Button
    Friend WithEvents btnAbrirBD As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents LstTorneos As ListBox
End Class

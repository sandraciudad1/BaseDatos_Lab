<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnJugadoras = New System.Windows.Forms.Button()
        Me.btnPaises = New System.Windows.Forms.Button()
        Me.btnTorneos = New System.Windows.Forms.Button()
        Me.btnEdicion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConectar
        '
        Me.btnConectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btnConectar.Location = New System.Drawing.Point(149, 44)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(131, 54)
        Me.btnConectar.TabIndex = 0
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(317, 66)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(60, 17)
        Me.LblEstado.TabIndex = 2
        Me.LblEstado.Text = "Estado: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!)
        Me.Label2.Location = New System.Drawing.Point(8, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(784, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "---------------- GESTIONAR INFORMACIÓN ------------------------------------------" &
    "------------------------------"
        '
        'btnJugadoras
        '
        Me.btnJugadoras.Enabled = False
        Me.btnJugadoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.btnJugadoras.Location = New System.Drawing.Point(114, 211)
        Me.btnJugadoras.Name = "btnJugadoras"
        Me.btnJugadoras.Size = New System.Drawing.Size(139, 50)
        Me.btnJugadoras.TabIndex = 4
        Me.btnJugadoras.Text = "Jugadoras"
        Me.btnJugadoras.UseVisualStyleBackColor = True
        '
        'btnPaises
        '
        Me.btnPaises.Enabled = False
        Me.btnPaises.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.btnPaises.Location = New System.Drawing.Point(319, 211)
        Me.btnPaises.Name = "btnPaises"
        Me.btnPaises.Size = New System.Drawing.Size(139, 50)
        Me.btnPaises.TabIndex = 5
        Me.btnPaises.Text = "Paises"
        Me.btnPaises.UseVisualStyleBackColor = True
        '
        'btnTorneos
        '
        Me.btnTorneos.Enabled = False
        Me.btnTorneos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.btnTorneos.Location = New System.Drawing.Point(515, 211)
        Me.btnTorneos.Name = "btnTorneos"
        Me.btnTorneos.Size = New System.Drawing.Size(139, 50)
        Me.btnTorneos.TabIndex = 6
        Me.btnTorneos.Text = "Torneos"
        Me.btnTorneos.UseVisualStyleBackColor = True
        '
        'btnEdicion
        '
        Me.btnEdicion.Enabled = False
        Me.btnEdicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.btnEdicion.Location = New System.Drawing.Point(114, 364)
        Me.btnEdicion.Name = "btnEdicion"
        Me.btnEdicion.Size = New System.Drawing.Size(212, 50)
        Me.btnEdicion.TabIndex = 7
        Me.btnEdicion.Text = "Crear Edición"
        Me.btnEdicion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!)
        Me.Label1.Location = New System.Drawing.Point(8, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(781, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "---------------- OTRO -----------------------------------------------------------" &
    "-------------------------------------------"
        '
        'btnInformes
        '
        Me.btnInformes.Enabled = False
        Me.btnInformes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.btnInformes.Location = New System.Drawing.Point(418, 364)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(212, 50)
        Me.btnInformes.TabIndex = 9
        Me.btnInformes.Text = "Generar informes"
        Me.btnInformes.UseVisualStyleBackColor = True
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnInformes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEdicion)
        Me.Controls.Add(Me.btnTorneos)
        Me.Controls.Add(Me.btnPaises)
        Me.Controls.Add(Me.btnJugadoras)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.btnConectar)
        Me.Name = "frmInicio"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConectar As Button
    Friend WithEvents LblEstado As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnJugadoras As Button
    Friend WithEvents btnPaises As Button
    Friend WithEvents btnTorneos As Button
    Friend WithEvents btnEdicion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInformes As Button
End Class

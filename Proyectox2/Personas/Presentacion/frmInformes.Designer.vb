<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformes
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGanadoras = New System.Windows.Forms.Button()
        Me.btnCuadroPartidos = New System.Windows.Forms.Button()
        Me.LstEdiciones = New System.Windows.Forms.ListBox()
        Me.lblGanadora = New System.Windows.Forms.Label()
        Me.txtGanadora = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTorneo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRonda = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!)
        Me.Label2.Location = New System.Drawing.Point(37, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "- Para cada torneo... "
        '
        'btnGanadoras
        '
        Me.btnGanadoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnGanadoras.Location = New System.Drawing.Point(55, 87)
        Me.btnGanadoras.Name = "btnGanadoras"
        Me.btnGanadoras.Size = New System.Drawing.Size(204, 63)
        Me.btnGanadoras.TabIndex = 5
        Me.btnGanadoras.Text = "Lista de Ganadoras"
        Me.btnGanadoras.UseVisualStyleBackColor = True
        '
        'btnCuadroPartidos
        '
        Me.btnCuadroPartidos.Enabled = False
        Me.btnCuadroPartidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnCuadroPartidos.Location = New System.Drawing.Point(300, 269)
        Me.btnCuadroPartidos.Name = "btnCuadroPartidos"
        Me.btnCuadroPartidos.Size = New System.Drawing.Size(149, 81)
        Me.btnCuadroPartidos.TabIndex = 6
        Me.btnCuadroPartidos.Text = "Cuadro de Partidos por Edición"
        Me.btnCuadroPartidos.UseVisualStyleBackColor = True
        '
        'LstEdiciones
        '
        Me.LstEdiciones.FormattingEnabled = True
        Me.LstEdiciones.ItemHeight = 16
        Me.LstEdiciones.Location = New System.Drawing.Point(55, 206)
        Me.LstEdiciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LstEdiciones.Name = "LstEdiciones"
        Me.LstEdiciones.Size = New System.Drawing.Size(204, 212)
        Me.LstEdiciones.TabIndex = 17
        '
        'lblGanadora
        '
        Me.lblGanadora.AutoSize = True
        Me.lblGanadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!)
        Me.lblGanadora.Location = New System.Drawing.Point(51, 167)
        Me.lblGanadora.Name = "lblGanadora"
        Me.lblGanadora.Size = New System.Drawing.Size(95, 22)
        Me.lblGanadora.TabIndex = 18
        Me.lblGanadora.Text = "Ganadora:"
        '
        'txtGanadora
        '
        Me.txtGanadora.Location = New System.Drawing.Point(153, 166)
        Me.txtGanadora.Name = "txtGanadora"
        Me.txtGanadora.Size = New System.Drawing.Size(106, 22)
        Me.txtGanadora.TabIndex = 19
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(615, 224)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(106, 22)
        Me.txtId.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!)
        Me.Label1.Location = New System.Drawing.Point(500, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 22)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Id Partido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!)
        Me.Label3.Location = New System.Drawing.Point(500, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 22)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Torneo:"
        '
        'txtTorneo
        '
        Me.txtTorneo.Location = New System.Drawing.Point(615, 302)
        Me.txtTorneo.Name = "txtTorneo"
        Me.txtTorneo.Size = New System.Drawing.Size(106, 22)
        Me.txtTorneo.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!)
        Me.Label4.Location = New System.Drawing.Point(500, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 22)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Año:"
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(615, 264)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(106, 22)
        Me.txtAnio.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!)
        Me.Label5.Location = New System.Drawing.Point(500, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 22)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Ganadora:"
        '
        'txtGan
        '
        Me.txtGan.Location = New System.Drawing.Point(615, 340)
        Me.txtGan.Name = "txtGan"
        Me.txtGan.Size = New System.Drawing.Size(106, 22)
        Me.txtGan.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!)
        Me.Label6.Location = New System.Drawing.Point(500, 380)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 22)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Ronda:"
        '
        'txtRonda
        '
        Me.txtRonda.Location = New System.Drawing.Point(615, 380)
        Me.txtRonda.Name = "txtRonda"
        Me.txtRonda.Size = New System.Drawing.Size(106, 22)
        Me.txtRonda.TabIndex = 28
        '
        'frmInformes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 540)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRonda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTorneo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtGanadora)
        Me.Controls.Add(Me.lblGanadora)
        Me.Controls.Add(Me.LstEdiciones)
        Me.Controls.Add(Me.btnCuadroPartidos)
        Me.Controls.Add(Me.btnGanadoras)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmInformes"
        Me.Text = "frmInformes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnGanadoras As Button
    Friend WithEvents btnCuadroPartidos As Button
    Friend WithEvents LstEdiciones As ListBox
    Friend WithEvents lblGanadora As Label
    Friend WithEvents txtGanadora As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTorneo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRonda As TextBox
End Class

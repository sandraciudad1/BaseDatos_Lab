Public Class frmJugadoras
    Public Property j As Jugadoras

    Private Sub btnAbrirBD_Click(sender As Object, e As EventArgs) Handles btnAbrirBD.Click
        Dim jAux As Jugadoras
        Me.j = New Jugadoras

        Try
            Me.j.LeerTodasJugadoras()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each jAux In Me.j.JugDAO.jugadoras
            Me.LstJugadoras.Items.Add(jAux.idJugadora)

        Next
        btnAbrirBD.Enabled = False
        BtnAnadir.Enabled = True

    End Sub

    Private Sub LstJugadoras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstJugadoras.SelectedIndexChanged
        Me.BtnActualizar.Enabled = True
        Me.BtnEliminar.Enabled = True
        Me.txtID.Enabled = False

        If Me.LstJugadoras.SelectedItem IsNot Nothing Then
            Me.j = New Jugadoras(Me.LstJugadoras.SelectedItem.ToString)
            Try
                Me.j.LeerJugadora()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            Me.txtID.Text = CStr(Me.j.idJugadora)
            Me.txtNombre.Text = Me.j.nombreJugadora.ToString
            Me.txtPuntos.Text = Me.j.PuntosJugadora.ToString
            Me.txtPais.Text = Me.j.PaisJugadora.ToString
        End If
    End Sub

    Private Sub BtnAnadir_Click(sender As Object, e As EventArgs) Handles BtnAnadir.Click
        If Me.txtID.Text <> String.Empty And Me.txtNombre.Text <> String.Empty And Me.txtPuntos.Text <> String.Empty And Me.txtPais.Text <> String.Empty Then
            j = New Jugadoras
            j.idJugadora = CInt(txtID.Text)
            j.nombreJugadora = txtNombre.Text
            j.PuntosJugadora = 0
            j.PaisJugadora = txtPais.Text
            If txtPuntos.Text <> CStr(0) Then
                MsgBox("Los puntos iniciales de una jugadora deben ser 0")
            End If
            Try
                If j.InsertarJugadora() <> 1 Then
                    MessageBox.Show("*INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            If Me.txtPuntos.Text <> String.Empty Then
                Me.LstJugadoras.Items.Add(j.idJugadora)
            End If
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If j IsNot Nothing Then
            j.nombreJugadora = txtNombre.Text
            j.PuntosJugadora = CInt(txtPuntos.Text)
            j.PaisJugadora = txtPais.Text
            Try
                If j.ActualizarJugadora() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show(j.nombreJugadora & " actualizado correctamente!")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If Not Me.j Is Nothing Then
            If MessageBox.Show("¿borrar " & Me.j.idJugadora & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.j.BorrarJugadora() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                Me.LstJugadoras.Items.Remove(j.idJugadora)
            End If
            Me.BtnLimpiar.PerformClick()
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Me.txtID.Text = String.Empty
        Me.txtNombre.Text = String.Empty
        Me.txtPais.Text = String.Empty
        Me.txtPuntos.Text = String.Empty 
        Me.BtnActualizar.Enabled = False
        Me.BtnEliminar.Enabled = False
        Me.txtID.Enabled = True
    End Sub

End Class

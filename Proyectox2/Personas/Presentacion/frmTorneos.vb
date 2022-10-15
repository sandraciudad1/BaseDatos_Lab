Public Class frmTorneos
    Public Property t As Torneos

    Private Sub btnAbrirBD_Click(sender As Object, e As EventArgs) Handles btnAbrirBD.Click
        Dim tAux As Torneos
        Me.t = New Torneos

        Try
            Me.t.LeerTodosTorneos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each tAux In Me.t.TorDAO.torneos
            Me.LstTorneos.Items.Add(tAux.idTorneo)

        Next
        btnAbrirBD.Enabled = False
        BtnAnadir.Enabled = True

    End Sub

    Private Sub LstTorneos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstTorneos.SelectedIndexChanged
        Me.BtnActualizar.Enabled = True
        Me.BtnEliminar.Enabled = True
        Me.txtID.Enabled = False

        If Me.LstTorneos.SelectedItem IsNot Nothing Then
            Me.t = New Torneos(Me.LstTorneos.SelectedItem.ToString)
            Try
                Me.t.LeerTorneo()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            Me.txtID.Text = CStr(Me.t.idTorneo)
            Me.txtNombre.Text = Me.t.nombreTorneo.ToString
            Me.txtCiudad.Text = Me.t.CiudadTorneo.ToString
            Me.txtPais.Text = Me.t.PaisTorneo.ToString
        End If
    End Sub

    Private Sub BtnAnadir_Click(sender As Object, e As EventArgs) Handles BtnAnadir.Click
        If Me.txtID.Text <> String.Empty And Me.txtNombre.Text <> String.Empty And Me.txtCiudad.Text <> String.Empty And Me.txtPais.Text <> String.Empty Then
            t = New Torneos
            t.idTorneo = CInt(txtID.Text)
            t.nombreTorneo = txtNombre.Text
            t.CiudadTorneo = txtCiudad.Text
            t.PaisTorneo = txtPais.Text

            Try
                If t.InsertarTorneo() <> 1 Then
                    MessageBox.Show("*INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.LstTorneos.Items.Add(t.idTorneo)
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If t IsNot Nothing Then
            t.nombreTorneo = txtNombre.Text
            t.CiudadTorneo = txtCiudad.Text
            t.PaisTorneo = txtPais.Text
            Try
                If t.ActualizarTorneo() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show(t.nombreTorneo & " actualizado correctamente!")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If Not Me.t Is Nothing Then
            If MessageBox.Show("¿borrar " & Me.t.idTorneo & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.t.BorrarTorneo() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                Me.LstTorneos.Items.Remove(t.idTorneo)
            End If
            Me.BtnLimpiar.PerformClick()
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Me.txtID.Text = String.Empty
        Me.txtNombre.Text = String.Empty
        Me.txtPais.Text = String.Empty
        Me.txtCiudad.Text = String.Empty
        Me.BtnActualizar.Enabled = False
        Me.BtnEliminar.Enabled = False
        Me.txtID.Enabled = True
    End Sub
End Class
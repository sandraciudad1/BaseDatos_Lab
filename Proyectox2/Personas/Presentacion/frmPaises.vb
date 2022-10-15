Public Class frmPaises
    Public Property p As Paises

    Private Sub btnAbrirBD_Click(sender As Object, e As EventArgs) Handles btnAbrirBD.Click
        Dim pAux As Paises
        Me.p = New Paises

        Try
            Me.p.LeerTodosPaises()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.p.PaiDAO.paises
            Me.LstPaises.Items.Add(pAux.idPais)

        Next
        btnAbrirBD.Enabled = False
        BtnAnadir.Enabled = True

    End Sub

    Private Sub LstPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstPaises.SelectedIndexChanged
        Me.BtnActualizar.Enabled = True
        Me.BtnEliminar.Enabled = True
        Me.txtID.Enabled = False

        If Me.LstPaises.SelectedItem IsNot Nothing Then
            Me.p = New Paises(Me.LstPaises.SelectedItem.ToString)
            Try
                Me.p.LeerPais()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            Me.txtID.Text = Me.p.idPais.ToString
            Me.txtNombre.Text = Me.p.nombrePais.ToString
        End If
    End Sub

    Private Sub BtnAnadir_Click(sender As Object, e As EventArgs) Handles BtnAnadir.Click
        If Me.txtID.Text <> String.Empty And Me.txtNombre.Text <> String.Empty Then
            p = New Paises
            p.idPais = txtID.Text
            p.nombrePais = txtNombre.Text
            While (txtID.Text <> p.idPais.ToUpper)
                If Not Me.p Is Nothing Then
                    If MessageBox.Show("¿El ID del país " & Me.p.idPais & " debe escribirse completamente en mayúsculas", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Try
                            If Me.p.BorrarPais() <> 1 Then
                                Exit Sub
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End Try
                        Me.LstPaises.Items.Remove(p.idPais)
                    End If
                    Me.BtnLimpiar.PerformClick()
                End If
                Me.LstPaises.Items.Remove(p.idPais)
                Me.LstPaises.Items.Remove(p.nombrePais)
                Me.txtID.Text = String.Empty
                p.idPais = txtID.Text
                lblRestricción.Visible = True
                lblRestricción2.Visible = True

            End While


            Try
                If p.InsertarPais() <> 1 Then
                    MessageBox.Show("*INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.LstPaises.Items.Add(p.idPais)
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If p IsNot Nothing Then
            p.nombrePais = txtNombre.Text
            Try
                If p.ActualizarPais() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show(p.nombrePais & " actualizado correctamente!")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If Not Me.p Is Nothing Then
            If MessageBox.Show("¿Borrar " & Me.p.idPais & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.p.BorrarPais() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                Me.LstPaises.Items.Remove(p.idPais)
            End If
            Me.BtnLimpiar.PerformClick()
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Me.txtID.Text = String.Empty
        Me.txtNombre.Text = String.Empty
        Me.BtnActualizar.Enabled = False
        Me.BtnEliminar.Enabled = False
        Me.txtID.Enabled = True
    End Sub
End Class
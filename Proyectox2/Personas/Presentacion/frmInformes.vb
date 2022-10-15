Public Class frmInformes
    Public Property ed As Ediciones
    Private Sub btnGanadoras_Click(sender As Object, e As EventArgs) Handles btnGanadoras.Click
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT DISTINCT Anualidad FROM Ediciones ORDER BY Anualidad")
        For Each aux In col
            ed = New Ediciones()
            ed.Anualidad = CInt(aux(1).ToString)
            Me.LstEdiciones.Items.Add(ed.Anualidad)
        Next
    End Sub

    Private Sub LstEdiciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstEdiciones.SelectedIndexChanged
        btnGanadoras.Enabled = False
        If Me.LstEdiciones.SelectedItem IsNot Nothing Then
            Me.ed = New Ediciones(Me.LstEdiciones.SelectedItem.ToString)
            Try
                Me.ed.LeerEdicion()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Dim j As Jugadoras
            Dim col As Collection : Dim aux As Collection
            col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Jugadoras WHERE idJugadora='" & Me.ed.Ganadora & "';")
            For Each aux In col
                j = New Jugadoras()
                j.nombreJugadora = aux(2).ToString
            Next
            Me.txtGanadora.Text = j.nombreJugadora
        End If
        btnCuadroPartidos.Enabled = True
        btnGanadoras.Enabled = False
    End Sub

    Private Sub btnCuadroPartidos_Click(sender As Object, e As EventArgs) Handles btnCuadroPartidos.Click
        Dim p As Partidos
        Dim col2 As Collection : Dim aux2 As Collection
        col2 = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Partidos WHERE Ganadora='" & Me.ed.Ganadora & "';")
        For Each aux2 In col2
            p = New Partidos()
            p.idPartido = CInt(aux2(1).ToString)
            p.Anualidad = CInt(aux2(2).ToString)
            p.Torneo = CInt(aux2(3).ToString)
            p.ronda = CChar(aux2(5).ToString)
        Next
        txtId.Text = CStr(p.idPartido)
        txtAnio.Text = CStr(p.Anualidad)
        txtTorneo.Text = CStr(p.Torneo)
        txtGan.Text = txtGanadora.Text
        txtRonda.Text = p.ronda
    End Sub

End Class
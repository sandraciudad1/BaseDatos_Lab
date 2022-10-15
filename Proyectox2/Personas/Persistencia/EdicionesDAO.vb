Public Class EdicionesDAO
    Public ReadOnly Property ediciones As Collection

    Public Sub New()
        Me.ediciones = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim e As Ediciones
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Ediciones ORDER BY Anualidad")
        Dim cont As Integer = 0
        For Each aux In col
            e = New Ediciones()
            e.Anualidad = CInt(aux(1).ToString)
            e.Torneo = CInt(aux(2).ToString)
            e.Ganadora = CInt(aux(3).ToString)
            Me.ediciones.Add(e)
        Next
    End Sub

    Public Sub LeerTodasD()
        Dim e As Ediciones
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT DISTINCT Anualidad FROM Ediciones ORDER BY Anualidad")
        For Each aux In col
            e = New Ediciones()
            e.Anualidad = CInt(aux(1).ToString)
            e.Torneo = CInt(aux(2).ToString)
            e.Ganadora = CInt(aux(3).ToString)
            Me.ediciones.Add(e)
        Next
    End Sub

    Public Sub Leer(ByRef e As Ediciones)
        Dim id As Integer = CInt(frmInformes.LstEdiciones.SelectedItem)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Ediciones WHERE Anualidad='" & id & "';")
        For Each aux In col
            e.Anualidad = CInt(aux(1).ToString)
            e.Torneo = CInt(aux(2).ToString)
            e.Ganadora = CInt(aux(3).ToString)
        Next
    End Sub

    Public Function Insertar(ByVal e As Ediciones) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Ediciones VALUES ('" & e.Anualidad & "', '" & e.Torneo & "', '" & e.Ganadora & "');")
    End Function

    Public Function Actualizar(ByVal e As Ediciones) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Torneos SET Torneo='" & e.Torneo & "', Ganadora='" & e.Ganadora & "' WHERE Anualidad='" & e.Anualidad & "';")
    End Function

    Public Function Borrar(ByVal e As Ediciones) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Ediciones WHERE Anualidad='" & e.Anualidad & "';")
    End Function
End Class

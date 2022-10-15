Public Class JugadorasDAO
    Public ReadOnly Property jugadoras As Collection

    Public Sub New()
        Me.jugadoras = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim j As Jugadoras
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Jugadoras ORDER BY idJugadora")
        For Each aux In col
            j = New Jugadoras()
            j.idJugadora = CInt(aux(1).ToString)
            j.nombreJugadora = aux(2).ToString
            j.PuntosJugadora = CInt(aux(3).ToString)
            j.PaisJugadora = aux(4).ToString
            Me.jugadoras.Add(j)
        Next
    End Sub

    Public Sub Leer(ByRef j As Jugadoras)
        Dim id As Integer = CInt(frmJugadoras.LstJugadoras.SelectedItem)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Jugadoras WHERE idJugadora='" & id & "';")
        For Each aux In col
            j.idJugadora = CInt(aux(1).ToString)
            j.nombreJugadora = aux(2).ToString
            j.PuntosJugadora = CInt(aux(3).ToString)
            j.PaisJugadora = aux(4).ToString
        Next
    End Sub

    Public Function Insertar(ByVal j As Jugadoras) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Jugadoras VALUES ('" & j.idJugadora & "', '" & j.nombreJugadora & "', '" & j.PuntosJugadora & "',  '" & j.PaisJugadora & "');")
    End Function

    Public Function Actualizar(ByVal j As Jugadoras) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET NombreJugadora='" & j.nombreJugadora & "', PuntosJugadora='" & j.PuntosJugadora & "', PaisJugadora='" & j.PaisJugadora & "' WHERE idJugadora='" & j.idJugadora & "';")
    End Function

    Public Function Borrar(ByVal j As Jugadoras) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Jugadoras WHERE idJugadora='" & j.idJugadora & "';")
    End Function
End Class

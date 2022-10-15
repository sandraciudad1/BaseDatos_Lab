Public Class PartidosDAO
    Public ReadOnly Property partidos As Collection

    Public Sub New()
        Me.partidos = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Partidos
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Partidos ORDER BY idPartido")
        For Each aux In col
            p = New Partidos()
            p.idPartido = CInt(aux(1).ToString)
            p.Anualidad = CInt(aux(2).ToString)
            p.Torneo = CInt(aux(3).ToString)
            p.Ganadora = CInt(aux(4).ToString)
            p.ronda = CChar(aux(5).ToString)
            Me.partidos.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Partidos)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Partidos WHERE idPartido='" & p.idPartido & "';")
        For Each aux In col
            p.idPartido = CInt(aux(1).ToString)
            p.Anualidad = CInt(aux(2).ToString)
            p.Torneo = CInt(aux(3).ToString)
            p.Ganadora = CInt(aux(4).ToString)
            p.ronda = CChar(aux(5).ToString)
        Next
    End Sub

    Public Function Insertar(ByVal p As Partidos) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Partidos VALUES ('" & p.idPartido & "', '" & p.Anualidad & "', '" & p.Torneo & "', '" & p.Ganadora & "', '" & p.ronda & "');")
    End Function

    Public Function Actualizar(ByVal p As Partidos) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Partidos SET Anualidad='" & p.Anualidad & "', Torneo='" & p.Torneo & "', Ganadora='" & p.Ganadora & "', Ronda='" & p.ronda & "' WHERE idPartido='" & p.idPartido & "';")
    End Function

    Public Function Borrar(ByVal p As Partidos) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Partidos WHERE idPartido='" & p.idPartido & "';")
    End Function
End Class

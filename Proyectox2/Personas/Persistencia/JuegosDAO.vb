Public Class JuegosDAO
    Public ReadOnly Property juegos As Collection

    Public Sub New()
        Me.juegos = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim ju As Juegos
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Juegos ORDER BY Jugadora")
        For Each aux In col
            ju = New Juegos()
            ju.Jugadora = CInt(aux(1).ToString)
            ju.Partido = CInt(aux(2).ToString)
            ju.Set1 = CInt(aux(3).ToString)
            ju.Set2 = CInt(aux(4).ToString)
            ju.Set3 = CInt(aux(5).ToString)
            Me.juegos.Add(ju)
        Next
    End Sub

    Public Sub Leer(ByRef ju As Juegos)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Juegos WHERE Jugadora='" & ju.Jugadora & "';")
        For Each aux In col
            ju.Jugadora = CInt(aux(1).ToString)
            ju.Partido = CInt(aux(2).ToString)
            ju.Set1 = CInt(aux(3).ToString)
            ju.Set2 = CInt(aux(4).ToString)
            ju.Set3 = CInt(aux(5).ToString)
        Next
    End Sub

    Public Function Insertar(ByVal ju As Juegos) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Juegos VALUES ('" & ju.Jugadora & "', '" & ju.Partido & "', '" & ju.Set1 & "', '" & ju.Set2 & "', '" & ju.Set3 & "');")
    End Function

    Public Function Actualizar(ByVal ju As Juegos) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Juegos SET Jugadora='" & ju.Jugadora & "', Partido='" & ju.Partido & "', Set1='" & ju.Set1 & "', Set2='" & ju.Set2 & "', Set3='" & ju.Set3 & "'WHERE Jugadora='" & ju.Jugadora & "';")
    End Function

    Public Function Borrar(ByVal ju As Juegos) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Juegos WHERE Jugadora='" & ju.Jugadora & "';")
    End Function
End Class

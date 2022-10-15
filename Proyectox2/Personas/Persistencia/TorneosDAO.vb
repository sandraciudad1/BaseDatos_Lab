Public Class TorneosDAO
    Public ReadOnly Property torneos As Collection

    Public Sub New()
        Me.torneos = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim t As Torneos
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Torneos ORDER BY idTorneo")
        Dim cont As Integer = 0
        For Each aux In col
            cont += 1
            t = New Torneos()
            t.idTorneo = CInt(aux(1).ToString)
            t.nombreTorneo = aux(2).ToString
            t.CiudadTorneo = aux(3).ToString
            t.PaisTorneo = aux(4).ToString
            Me.torneos.Add(t)
        Next
        Randomize()
        Dim valor As Integer = 0
        valor = CInt((1 - cont) * Rnd() + cont)

    End Sub


    Public Sub Leer(ByRef t As Torneos)
        Dim id As Integer = CInt(frmTorneos.LstTorneos.SelectedItem)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Torneos WHERE idTorneo='" & id & "';")
        For Each aux In col
            t.idTorneo = id
            t.nombreTorneo = aux(2).ToString
            t.CiudadTorneo = aux(3).ToString
            t.PaisTorneo = aux(4).ToString
        Next
    End Sub

    Public Function Insertar(ByVal t As Torneos) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Torneos VALUES ('" & t.idTorneo & "', '" & t.nombreTorneo & "', '" & t.CiudadTorneo & "',  '" & t.PaisTorneo & "');")
    End Function

    Public Function Actualizar(ByVal t As Torneos) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Torneos SET NombreTorneo='" & t.nombreTorneo & "', CiudadTorneo='" & t.CiudadTorneo & "', PaisTorneo='" & t.PaisTorneo & "' WHERE idTorneo='" & t.idTorneo & "';")
    End Function

    Public Function Borrar(ByVal t As Torneos) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Torneos WHERE idTorneo='" & t.idTorneo & "';")
    End Function
End Class

Public Class PaisesDAO
    Public ReadOnly Property paises As Collection

    Public Sub New()
        Me.paises = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Paises
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Paises ORDER BY idPais")
        For Each aux In col
            p = New Paises()
            p.idPais = aux(1).ToString
            p.nombrePais = aux(2).ToString
            Me.paises.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Paises)
        Dim id As String = CStr(frmPaises.LstPaises.SelectedItem)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Paises WHERE idPais='" & id & "';")
        For Each aux In col
            p.idPais = id
            p.nombrePais = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Paises) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Paises VALUES ('" & p.idPais & "', '" & p.nombrePais & "');")
    End Function

    Public Function Actualizar(ByVal p As Paises) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Paises SET NombrePais='" & p.nombrePais & "' WHERE idPais='" & p.idPais & "';")
    End Function

    Public Function Borrar(ByVal p As Paises) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Paises WHERE idPais='" & p.idPais & "';")
    End Function
End Class

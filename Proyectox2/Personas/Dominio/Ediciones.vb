Public Class Ediciones
    Public Property Anualidad As Integer
    Public Property Torneo As Integer
    Public Property Ganadora As Integer
    Public ReadOnly Property EdiDAO As EdicionesDAO

    Public Sub New()
        Me.EdiDAO = New EdicionesDAO
    End Sub

    Public Sub New(id As String)
        Me.EdiDAO = New EdicionesDAO
        Me.Anualidad = Anualidad
    End Sub

    Public Sub LeerTodasEdiciones()
        Me.EdiDAO.LeerTodas()
    End Sub

    Public Sub LeerTodasEdicionesDistintas()
        Me.EdiDAO.LeerTodasD()
    End Sub


    Public Sub LeerEdicion()
        Me.EdiDAO.Leer(Me)
    End Sub

    Public Function InsertarEdicion() As Integer
        Return Me.EdiDAO.Insertar(Me)
    End Function

    Public Function ActualizarEdicion() As Integer
        Return Me.EdiDAO.Actualizar(Me)
    End Function

    Public Function BorrarTorneo() As Integer
        Return Me.EdiDAO.Borrar(Me)
    End Function
End Class

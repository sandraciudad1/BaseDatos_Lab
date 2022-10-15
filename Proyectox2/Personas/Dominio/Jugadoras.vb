Public Class Jugadoras
    Public Property idJugadora As Integer
    Public Property nombreJugadora As String
    Public Property PuntosJugadora As Integer
    Public Property PaisJugadora As String
    Public ReadOnly Property JugDAO As JugadorasDAO

    Public Sub New()

        Me.JugDAO = New JugadorasDAO
    End Sub

    Public Sub New(id As String)

        Me.JugDAO = New JugadorasDAO
        Me.idJugadora = idJugadora
    End Sub

    Public Sub LeerTodasJugadoras()
        Me.JugDAO.LeerTodas()
    End Sub

    Public Sub LeerJugadora()
        Me.JugDAO.Leer(Me)
    End Sub

    Public Function InsertarJugadora() As Integer
        Return Me.JugDAO.Insertar(Me)
    End Function

    Public Function ActualizarJugadora() As Integer
        Return Me.JugDAO.Actualizar(Me)
    End Function

    Public Function BorrarJugadora() As Integer
        Return Me.JugDAO.Borrar(Me)
    End Function


End Class

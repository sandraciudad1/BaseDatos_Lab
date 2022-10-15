Public Class Juegos
    Public Property Jugadora As Integer
    Public Property Partido As Integer
    Public Property Set1 As Integer
    Public Property Set2 As Integer
    Public Property Set3 As Integer
    Public ReadOnly Property JueDAO As JuegosDAO

    Public Sub New()
        Me.JueDAO = New JuegosDAO
    End Sub

    Public Sub LeerTodosJuegos()
        Me.JueDAO.LeerTodas()
    End Sub

    Public Sub LeerJuego()
        Me.JueDAO.Leer(Me)
    End Sub

    Public Function InsertarJuego() As Integer
        Return Me.JueDAO.Insertar(Me)
    End Function

    Public Function ActualizarJuego() As Integer
        Return Me.JueDAO.Actualizar(Me)
    End Function

    Public Function BorrarJuego() As Integer
        Return Me.JueDAO.Borrar(Me)
    End Function
End Class

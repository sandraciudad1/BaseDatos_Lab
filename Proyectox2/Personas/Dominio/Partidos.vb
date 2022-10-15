Public Class Partidos
    Public Property idPartido As Integer
    Public Property Anualidad As Integer
    Public Property Torneo As Integer
    Public Property Ganadora As Integer
    Public Property ronda As Char
    Public ReadOnly Property ParDAO As PartidosDAO

    Public Sub New()
        Me.ParDAO = New PartidosDAO
    End Sub

    Public Sub New(id As String)
        Me.ParDAO = New PartidosDAO
        Me.idPartido = idPartido
    End Sub

    Public Sub LeerTodosPartidos()
        Me.ParDAO.LeerTodas()
    End Sub

    Public Sub LeerPartido()
        Me.ParDAO.Leer(Me)
    End Sub

    Public Function InsertarPartido() As Integer
        Return Me.ParDAO.Insertar(Me)
    End Function

    Public Function ActualizarPartido() As Integer
        Return Me.ParDAO.Actualizar(Me)
    End Function

    Public Function BorrarPartido() As Integer
        Return Me.ParDAO.Borrar(Me)
    End Function
End Class

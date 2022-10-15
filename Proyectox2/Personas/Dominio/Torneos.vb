Public Class Torneos
    Public Property idTorneo As Integer
    Public Property nombreTorneo As String
    Public Property CiudadTorneo As String
    Public Property PaisTorneo As String
    Public ReadOnly Property TorDAO As TorneosDAO

    Public Sub New()
        Me.TorDAO = New TorneosDAO
    End Sub

    Public Sub New(id As String)
        Me.TorDAO = New TorneosDAO
        Me.idTorneo = idTorneo
    End Sub

    Public Sub LeerTodosTorneos()
        Me.TorDAO.LeerTodas()
    End Sub

    Public Sub LeerTorneo()
        Me.TorDAO.Leer(Me)
    End Sub

    Public Function InsertarTorneo() As Integer
        Return Me.TorDAO.Insertar(Me)
    End Function

    Public Function ActualizarTorneo() As Integer
        Return Me.TorDAO.Actualizar(Me)
    End Function

    Public Function BorrarTorneo() As Integer
        Return Me.TorDAO.Borrar(Me)
    End Function
End Class

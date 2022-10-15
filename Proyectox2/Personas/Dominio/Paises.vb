Public Class Paises
    Public Property idPais As String
    Public Property nombrePais As String
    Public ReadOnly Property PaiDAO As PaisesDAO

    Public Sub New()
        Me.PaiDAO = New PaisesDAO
    End Sub

    Public Sub New(id As String)

        Me.PaiDAO = New PaisesDAO
        Me.idPais = idPais
    End Sub

    Public Sub LeerTodosPaises()
        Me.PaiDAO.LeerTodas()
    End Sub

    Public Sub LeerPais()
        Me.PaiDAO.Leer(Me)
    End Sub

    Public Function InsertarPais() As Integer
        Return Me.PaiDAO.Insertar(Me)
    End Function

    Public Function ActualizarPais() As Integer
        Return Me.PaiDAO.Actualizar(Me)
    End Function

    Public Function BorrarPais() As Integer
        Return Me.PaiDAO.Borrar(Me)
    End Function
End Class

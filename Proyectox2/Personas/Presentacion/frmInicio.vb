Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmInicio

    Dim conexion As New MySqlConnection("server=localhost;database=tenis;uid=root;pwd=NuevaContrasena2021!")
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Try
            conexion.Open()
            LblEstado.Text = "Estado: Conexión establecida correctamente"
            btnJugadoras.Enabled = True
            btnPaises.Enabled = True
            btnTorneos.Enabled = True
            btnEdicion.Enabled = True
            btnInformes.Enabled = True
        Catch ex As Exception
            conexion.Close()
            LblEstado.Text = "Estado: Se ha producido un error de conexión"
        End Try
    End Sub

    Private Sub btnJugadoras_Click(sender As Object, e As EventArgs) Handles btnJugadoras.Click
        frmJugadoras.Show()
    End Sub

    Private Sub btnPaises_Click(sender As Object, e As EventArgs) Handles btnPaises.Click
        frmPaises.Show()
    End Sub

    Private Sub btnTorneos_Click(sender As Object, e As EventArgs) Handles btnTorneos.Click
        frmTorneos.Show()
    End Sub

    Private Sub btnEdicion_Click(sender As Object, e As EventArgs) Handles btnEdicion.Click
        frmEdicion.Show()
    End Sub

    Private Sub btnInformes_Click(sender As Object, e As EventArgs) Handles btnInformes.Click
        frmInformes.Show()
    End Sub
End Class
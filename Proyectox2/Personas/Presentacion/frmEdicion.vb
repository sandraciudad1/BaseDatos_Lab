Public Class frmEdicion
    Public Property t As Torneos

    Public anioEdicion As Integer = 0
    Public nombreTorneo As String = ""
    Public valor As Integer = 0

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtAnioEdicion.Text <> String.Empty And IsNumeric(txtAnioEdicion.Text) Then
            btnCuadroTorneoCuartos.Enabled = True
            btnOK.Enabled = False
            anioEdicion = CInt(txtAnioEdicion.Text)
            Dim t As Torneos
            Dim col, aux As Collection
            col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Torneos ORDER BY idTorneo")
            Dim cont As Integer = 0
            For Each aux In col
                cont += 1
                t = New Torneos()
                t.idTorneo = CInt(aux(1).ToString)
            Next
            Randomize()
            valor = CInt((1 - cont) * Rnd() + cont)

            Dim col2 As Collection : Dim aux2 As Collection
            col2 = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Torneos WHERE idTorneo='" & valor & "';")
            For Each aux2 In col2
                t.nombreTorneo = aux2(2).ToString
            Next
            nombreTorneo = t.nombreTorneo
            lblTorneo.Text = "Se ha seleccionado el torneo '" & nombreTorneo & "'."
            lblTorneo.Visible = True
        ElseIf txtAnioEdicion.Text = String.Empty Then
            MsgBox("No se ha introducido ningún año para la edición")
        ElseIf Not IsNumeric(txtAnioEdicion) Then
            MsgBox("Debe introducir un dato numérico")
        End If
    End Sub

    Public ganador1 As String = ""
    Public ganador2 As String = ""
    Public ganador3 As String = ""
    Public ganador4 As String = ""
    Public arrayNombres(7) As String
    Public cuartos1 As String = ""
    Public cuartos2 As String = ""
    Public cuartos3 As String = ""
    Public cuartos4 As String = ""
    Public arraynombres2(4) As String
    Public arraypuntos2(4) As Integer
    Public idPartido As Integer = dpartido() + 1

    Function dpartido() As Integer
        Dim p As Partidos
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Partidos")
        Dim cont As Integer = 0
        For Each aux In col
            cont += 1
            j = New Jugadoras()
            j.idJugadora = CInt(aux(1).ToString)
        Next
        Return cont
    End Function


    Private Sub btnCuadroTorneo_Click(sender As Object, e As EventArgs) Handles btnCuadroTorneoCuartos.Click
        Dim j As Jugadoras
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Jugadoras ORDER BY idJugadora")
        Dim cont As Integer = 0
        For Each aux In col
            cont += 1
            j = New Jugadoras()
            j.idJugadora = CInt(aux(1).ToString)
        Next

        Dim i As Integer = 0
        Dim arrayIds(7) As Integer
        Dim repetido As Boolean = False
        arrayIds(i) = New Random().Next(1, cont)
        For i = 1 To 7
            repetido = False
            arrayIds(i) = New Random().Next(1, cont)
            For ii As Integer = 0 To i - 1
                If arrayIds(i) = arrayIds(ii) Then
                    repetido = True
                End If

            Next
            If repetido = True Then
                i = i - 1
            End If
        Next

        Dim arrayPuntos(7) As Integer
        For k As Integer = 0 To 7
            Dim col2 As Collection : Dim aux2 As Collection
            col2 = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Jugadoras WHERE idJugadora='" & arrayIds(k) & "';")
            For Each aux2 In col2
                j.PuntosJugadora = CInt(aux2(3).ToString)
                arrayPuntos(k) = j.PuntosJugadora
            Next
        Next
        Array.Sort(arrayPuntos)

        For k As Integer = 0 To 7
            Dim col2 As Collection : Dim aux2 As Collection
            col2 = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Jugadoras WHERE PuntosJugadora='" & arrayPuntos(k) & "';")
            For Each aux2 In col2
                j.nombreJugadora = aux2(2).ToString
                arrayNombres(k) = j.nombreJugadora
            Next
        Next

        For k As Integer = 0 To 7
            lblJug1.Text = arrayNombres(0) & " - " & CStr(arrayPuntos(0))
            lblJug1.Visible = True
            lblJug8.Text = arrayNombres(7) & " - " & CStr(arrayPuntos(7))
            lblJug8.Visible = True
            lblJug4.Text = arrayNombres(3) & " - " & CStr(arrayPuntos(3))
            lblJug4.Visible = True
            lblJug5.Text = arrayNombres(4) & " - " & CStr(arrayPuntos(4))
            lblJug5.Visible = True
            lblJug2.Text = arrayNombres(1) & " - " & CStr(arrayPuntos(1))
            lblJug2.Visible = True
            lblJug7.Text = arrayNombres(6) & " - " & CStr(arrayPuntos(6))
            lblJug7.Visible = True
            lblJug3.Text = arrayNombres(2) & " - " & CStr(arrayPuntos(2))
            lblJug3.Visible = True
            lblJug6.Text = arrayNombres(5) & " - " & CStr(arrayPuntos(5))
            lblJug6.Visible = True
        Next

        ''Partido 1 CUARTOS FINAL
        MsgBox("PARTIDO 1")
        cuartos1 = generarPartido()
        Dim resultCuartos1(4) As String
        For k As Integer = 0 To 3
            resultCuartos1(k) = cuartos1.Split(","c)(k)
        Next
        lbls1p1.Text = resultCuartos1(0)
        lbls1p1.Visible = True
        lbls2p1.Text = resultCuartos1(1)
        lbls2p1.Visible = True
        lbls3p1.Text = resultCuartos1(2)
        lbls3p1.Visible = True
        lblganp1.Text = resultCuartos1(3)
        lblganp1.Visible = True
        If resultCuartos1(3) = "1" Then
            ganador1 = arrayNombres(0) & " - " & CStr(arrayPuntos(0) + 10)
            arraynombres2(0) = arrayNombres(0)
            arraypuntos2(0) = arrayPuntos(0) + 10

        ElseIf resultCuartos1(3) = "2" Then
            ganador1 = arrayNombres(7) & " - " & CStr(arrayPuntos(7) + 10)
            arraynombres2(0) = arrayNombres(7)
            arraypuntos2(0) = arrayPuntos(7) + 10
        End If

        ''Partido 2 CUARTOS FINAL
        MsgBox("PARTIDO 2")
        cuartos2 = generarPartido()
        Dim resultCuartos2(4) As String
        For k As Integer = 0 To 3
            resultCuartos2(k) = cuartos2.Split(","c)(k)
        Next
        lbls1p2.Text = resultCuartos2(0)
        lbls1p2.Visible = True
        lbls2p2.Text = resultCuartos2(1)
        lbls2p2.Visible = True
        lbls3p2.Text = resultCuartos2(2)
        lbls3p2.Visible = True
        lblganp2.Text = resultCuartos2(3)
        lblganp2.Visible = True
        If resultCuartos2(3) = "1" Then
            ganador2 = arrayNombres(3) & " - " & CStr(arrayPuntos(3) + 10)
            arraynombres2(1) = arrayNombres(3)
            arraypuntos2(1) = arrayPuntos(3) + 10
        ElseIf resultCuartos2(3) = "2" Then
            ganador2 = arrayNombres(4) & " - " & CStr(arrayPuntos(4) + 10)
            arraynombres2(1) = arrayNombres(4)
            arraypuntos2(1) = arrayPuntos(4) + 10
        End If

        ''Partido 3 CUARTOS FINAL
        MsgBox("PARTIDO 3")
        cuartos3 = generarPartido()
        Dim resultCuartos3(4) As String
        For k As Integer = 0 To 3
            resultCuartos3(k) = cuartos3.Split(","c)(k)
        Next
        lbls1p3.Text = resultCuartos3(0)
        lbls1p3.Visible = True
        lbls2p3.Text = resultCuartos3(1)
        lbls2p3.Visible = True
        lbls3p3.Text = resultCuartos3(2)
        lbls3p3.Visible = True
        lblganp3.Text = resultCuartos3(3)
        lblganp3.Visible = True
        If resultCuartos3(3) = "1" Then
            ganador3 = arrayNombres(1) & " - " & CStr(arrayPuntos(1) + 10)
            arraynombres2(2) = arrayNombres(1)
            arraypuntos2(2) = arrayPuntos(1) + 10
        ElseIf resultCuartos3(3) = "2" Then
            ganador3 = arrayNombres(6) & " - " & CStr(arrayPuntos(6) + 10)
            arraynombres2(2) = arrayNombres(6)
            arraypuntos2(2) = arrayPuntos(6) + 10
        End If

        ''Partido 4 CUARTOS FINAL
        MsgBox("PARTIDO 4")
        cuartos4 = generarPartido()
        Dim resultCuartos4(4) As String
        For k As Integer = 0 To 3
            resultCuartos4(k) = cuartos4.Split(","c)(k)
        Next
        lbls1p4.Text = resultCuartos4(0)
        lbls1p4.Visible = True
        lbls2p4.Text = resultCuartos4(1)
        lbls2p4.Visible = True
        lbls3p4.Text = resultCuartos4(2)
        lbls3p4.Visible = True
        lblganp4.Text = resultCuartos4(3)
        lblganp4.Visible = True
        If resultCuartos4(3) = "1" Then
            ganador4 = arrayNombres(2) & " - " & CStr(arrayPuntos(2) + 10)
            arraynombres2(3) = arrayNombres(2)
            arraypuntos2(3) = arrayPuntos(2) + 10
        ElseIf resultCuartos4(3) = "2" Then
            ganador4 = arrayNombres(5) & " - " & CStr(arrayPuntos(5) + 10)
            arraynombres2(3) = arrayNombres(5)
            arraypuntos2(3) = arrayPuntos(5) + 10
        End If

        btnCuadroTorneoSemis.Enabled = True
        btnCuadroTorneoCuartos.Enabled = False
    End Sub


    Function datosPartido(ByVal nombre1 As String, nombre2 As String, arrayResultados() As String, arrayLength As Integer) As String
        Dim jug1(3) As String
        Dim jug2(3) As String
        If arrayLength = 6 Then
            jug1(0) = arrayResultados(0)
            jug1(1) = arrayResultados(2)
            jug1(2) = CStr(0)
            jug2(0) = arrayResultados(1)
            jug2(1) = arrayResultados(3)
            jug2(2) = CStr(0)
        ElseIf arrayLength = 7 Then
            jug1(0) = arrayResultados(0)
            jug1(1) = arrayResultados(2)
            jug1(2) = arrayResultados(4)
            jug2(0) = arrayResultados(1)
            jug2(1) = arrayResultados(3)
            jug2(2) = arrayResultados(5)
        End If

        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Jugadoras WHERE NombreJugadora='" & nombre1 & "';")
        For Each aux In col
            j = New Jugadoras()
            j.idJugadora = CInt(aux(1).ToString)
        Next
        Dim id1 As Integer = j.idJugadora
        Dim col2, aux2 As Collection
        col2 = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Jugadoras WHERE NombreJugadora='" & nombre2 & "';")
        For Each aux2 In col2
            j = New Jugadoras()
            j.idJugadora = CInt(aux2(1).ToString)
        Next
        Dim id2 As Integer = j.idJugadora
        Dim cadena As String = CInt(id1) & "," & jug1(0) & "," & jug1(1) & "," & jug1(2) & "," & CInt(id2) & "," & jug2(0) & "," & jug2(1) & "," & jug2(2)
        Return cadena
    End Function

    Public ganadorsem1 As String = ""
    Public ganadorsem2 As String = ""
    Public arraynombres3(2) As String
    Public arraypuntos3(2) As Integer
    Public semis1 As String = ""
    Public semis2 As String = ""
    Public final As String = ""

    Private Sub btnCuadroTorneoSemis_Click(sender As Object, e As EventArgs) Handles btnCuadroTorneoSemis.Click
        lblJug1Semis.Text = ganador1
        lblJug1Semis.Visible = True
        lblJug2Semis.Text = ganador2
        lblJug2Semis.Visible = True
        lblJug3Semis.Text = ganador3
        lblJug3Semis.Visible = True
        lblJug4Semis.Text = ganador4
        lblJug4Semis.Visible = True

        ''Partido 1 SEMIFINALES
        MsgBox("PARTIDO 1 (semifinales)")
        semis1 = generarPartido()
        Dim resultSemis1(4) As String
        For k As Integer = 0 To 3
            resultSemis1(k) = semis1.Split(","c)(k)
        Next
        lbls1sem1.Text = resultSemis1(0)
        lbls1sem1.Visible = True
        lbls2sem1.Text = resultSemis1(1)
        lbls2sem1.Visible = True
        lbls3sem1.Text = resultSemis1(2)
        lbls3sem1.Visible = True
        lblgan1sem1.Text = resultSemis1(3)
        lblgan1sem1.Visible = True
        If resultSemis1(3) = "1" Then
            ganadorsem1 = arraynombres2(0) & " - " & CStr(arraypuntos2(0) + 25)
            arraynombres3(0) = arraynombres2(0)
            arraypuntos3(0) = arraypuntos2(0) + 25
        ElseIf resultSemis1(3) = "2" Then
            ganadorsem1 = arraynombres2(1) & " - " & CStr(arraypuntos2(1) + 25)
            arraynombres3(0) = arraynombres2(1)
            arraypuntos3(0) = arraypuntos2(1) + 25
        End If

        ''Partido 2 SEMIFINALES
        MsgBox("PARTIDO 2 (semifinales)")
        semis2 = generarPartido()
        Dim resultSemis2(4) As String
        For k As Integer = 0 To 3
            resultSemis2(k) = semis2.Split(","c)(k)
        Next
        lbls1sem2.Text = resultSemis2(0)
        lbls1sem2.Visible = True
        lbls2sem2.Text = resultSemis2(1)
        lbls2sem2.Visible = True
        lbls3sem2.Text = resultSemis2(2)
        lbls3sem2.Visible = True
        lblgan2sem2.Text = resultSemis2(3)
        lblgan2sem2.Visible = True
        If resultSemis2(3) = "1" Then
            ganadorsem2 = arraynombres2(2) & " - " & CStr(arraypuntos2(2) + 25)
            arraynombres3(1) = arraynombres2(2)
            arraypuntos3(1) = arraypuntos2(2) + 25
        ElseIf resultSemis2(3) = "2" Then
            ganadorsem2 = arraynombres2(3) & " - " & CStr(arraypuntos2(3) + 25)
            arraynombres3(1) = arraynombres2(3)
            arraypuntos3(1) = arraypuntos2(3) + 25
        End If

        btnCuadroTorneoFinal.Enabled = True
        btnCuadroTorneoSemis.Enabled = False
    End Sub

    Public ganadorFinal As String = ""
    Public arraynombres4(2) As String
    Public arraypuntos4(2) As Integer

    Private Sub btnCuadroTorneoFinal_Click(sender As Object, e As EventArgs) Handles btnCuadroTorneoFinal.Click
        btnCuadroTorneoFinal.Enabled = False
        btnFinalizar.Enabled = True
        lblJug1Final.Visible = True
        lblJug1Final.Text = ganadorsem1
        lblJug2Final.Text = ganadorsem2
        lblJug2Final.Visible = True

        ''Partido FINAL
        MsgBox("PARTIDO FINAL")
        final = generarPartido()
        Dim resultFinal(4) As String
        For k As Integer = 0 To 3
            resultFinal(k) = final.Split(","c)(k)
        Next
        lbls1fin.Text = resultFinal(0)
        lbls1fin.Visible = True
        lbls2fin.Text = resultFinal(1)
        lbls2fin.Visible = True
        lbls3fin.Text = resultFinal(2)
        lbls3fin.Visible = True
        lblganfin.Text = resultFinal(3)
        lblganfin.Visible = True
        If resultFinal(3) = "1" Then
            ganadorFinal = arraynombres3(0) & " - " & CStr(arraypuntos3(0) + 50)
            arraynombres4(0) = arraynombres3(0)
            arraypuntos4(0) = arraypuntos3(0) + 100
            arraynombres4(1) = arraynombres3(1)
            arraypuntos4(1) = arraypuntos3(1) + 50
        ElseIf resultFinal(3) = "2" Then
            ganadorFinal = arraynombres3(1) & " - " & CStr(arraypuntos3(1) + 50)
            arraynombres4(0) = arraynombres3(1)
            arraypuntos4(0) = arraypuntos3(1) + 100
            arraynombres4(1) = arraynombres3(0)
            arraypuntos4(1) = arraypuntos3(0) + 50
        End If

        MsgBox("La ganadora del torneo es... ¡" & arraynombres4(0) & " " & CStr(arraypuntos4(0)) & "!")
    End Sub


    Function generarPartido() As String
        Dim cadena As String = ""
        Dim puntosJug1 As Integer = 0
        Dim puntosJug2 As Integer = 0
        Dim arrayGanador(3) As Integer
        Dim arrayPuntos(3) As Integer
        For i As Integer = 0 To 2
            arrayGanador(i) = New Random().Next(1, 3)
            arrayPuntos(i) = New Random().Next(0, 5)
            MsgBox("Ganadora set1: Jugadora " & arrayGanador(i))
            If puntosJug1 < 2 And puntosJug2 < 2 Then
                If arrayGanador(i) = 1 Then
                    cadena = cadena + "6 - " & CStr(arrayPuntos(i)) & ","
                    puntosJug1 = puntosJug1 + 1
                ElseIf arrayGanador(i) = 2 Then
                    cadena = cadena + CStr(arrayPuntos(i)) & " - 6,"
                    puntosJug2 = puntosJug2 + 1
                End If
            ElseIf puntosJug1 = 2 Or puntosJug2 = 2 Then
                cadena = cadena + "-,"
            End If
            If i = 2 And puntosJug1 = 2 Then
                cadena = cadena + "1"
            ElseIf i = 2 And puntosJug2 = 2 Then
                cadena = cadena + "2"
            End If
        Next
        Return cadena
    End Function

    Public Property j As Jugadoras
    Public Property jue As Juegos
    Public Property ed As Ediciones
    Public Property par As Partidos
    Public arrayLength As Integer = 0
    Public cadena As String = ""

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Me.Close()
        ''ACTUALIZAR JUGADORAS
        AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET PuntosJugadora='" & arraypuntos2(0) & "' WHERE NombreJugadora='" & arraynombres2(0) & "';")
        AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET PuntosJugadora='" & arraypuntos2(1) & "' WHERE NombreJugadora='" & arraynombres2(1) & "';")
        AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET PuntosJugadora='" & arraypuntos2(2) & "' WHERE NombreJugadora='" & arraynombres2(2) & "';")
        AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET PuntosJugadora='" & arraypuntos2(3) & "' WHERE NombreJugadora='" & arraynombres2(3) & "';")
        AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET PuntosJugadora='" & arraypuntos3(0) & "' WHERE NombreJugadora='" & arraynombres3(0) & "';")
        AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET PuntosJugadora='" & arraypuntos3(1) & "' WHERE NombreJugadora='" & arraynombres3(1) & "';")
        AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET PuntosJugadora='" & arraypuntos4(0) & "' WHERE NombreJugadora='" & arraynombres4(0) & "';")
        AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET PuntosJugadora='" & arraypuntos4(1) & "' WHERE NombreJugadora='" & arraynombres4(1) & "';")

        ''AÑADIR EDICIONES
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Jugadoras WHERE NombreJugadora='" & arraynombres4(0) & "';")
        Dim id As Integer = 0
        For Each aux In col
            j = New Jugadoras()
            j.idJugadora = CInt(aux(1).ToString)
        Next
        AgenteBD.ObtenerAgente.Modificar("INSERT INTO Ediciones VALUES ('" & anioEdicion & "', '" & valor & "', '" & j.idJugadora & "');")

        ''AÑADIR PARTIDOS
        Dim letras(51) As String
        Dim n As Integer
        For item As Int32 = 65 To 90
            letras(n) = Chr(item)
            letras(n + 1) = letras(n).ToLower
            n += 2
        Next
        Dim cadenaAleatoria As String = String.Empty
        Dim rnd As New Random(DateTime.Now.Millisecond)
        For n = 0 To 1
            Dim numero As Integer = rnd.Next(0, 51)
            cadenaAleatoria &= letras(numero)
        Next
        Dim rondaChar As Char = CChar(cadenaAleatoria)
        AgenteBD.ObtenerAgente.Modificar("INSERT INTO Partidos VALUES ('" & idPartido & "', '" & anioEdicion & "', '" & valor & "', '" & j.idJugadora & "', '" & rondaChar & "');")

        ''AÑADIR JUEGOS
        Dim resultados As String
        Dim arrayresult(8) As String

        ''Partido 1 cuartos
        arrayLength = longCadena(cuartos1)
        Dim rcuartos1(arrayLength) As String
        For k As Integer = 0 To arrayLength - 1
            rcuartos1(k) = cadena.Split(","c)(k)
        Next
        resultados = datosPartido(arrayNombres(0), arrayNombres(7), rcuartos1, arrayLength)
        For k As Integer = 0 To 7
            arrayresult(k) = resultados.Split(","c)(k)
        Next
        AgenteBD.ObtenerAgente.Modificar("INSERT INTO Juegos VALUES ('" & CStr(arrayresult(0)) & "', '" & idPartido & "', '" & CStr(arrayresult(1)) & "', '" & CStr(arrayresult(2)) & "', '" & CStr(arrayresult(3)) & "');")
        AgenteBD.ObtenerAgente.Modificar("INSERT INTO Juegos VALUES ('" & CStr(arrayresult(4)) & "', '" & idPartido & "', '" & CStr(arrayresult(5)) & "', '" & CStr(arrayresult(6)) & "', '" & CStr(arrayresult(7)) & "');")


        ''Partido 2 cuartos
        arrayLength = longCadena(cuartos2)
        Dim rcuartos2(arrayLength) As String
        For k As Integer = 0 To arrayLength - 1
            rcuartos2(k) = cadena.Split(","c)(k)
        Next
        resultados = datosPartido(arrayNombres(3), arrayNombres(4), rcuartos2, arrayLength)
        For k As Integer = 0 To 7
            arrayresult(k) = resultados.Split(","c)(k)
        Next
        AgenteBD.ObtenerAgente.Modificar("INSERT INTO Juegos VALUES ('" & CStr(arrayresult(0)) & "', '" & idPartido & "', '" & CStr(arrayresult(1)) & "', '" & CStr(arrayresult(2)) & "', '" & CStr(arrayresult(3)) & "');")
        AgenteBD.ObtenerAgente.Modificar("INSERT INTO Juegos VALUES ('" & CStr(arrayresult(4)) & "', '" & idPartido & "', '" & CStr(arrayresult(5)) & "', '" & CStr(arrayresult(6)) & "', '" & CStr(arrayresult(7)) & "');")

        ''Partido 3 cuartos
        arrayLength = longCadena(cuartos3)
        Dim rcuartos3(arrayLength) As String
        For k As Integer = 0 To arrayLength - 1
            rcuartos3(k) = cadena.Split(","c)(k)
        Next
        resultados = datosPartido(arrayNombres(1), arrayNombres(6), rcuartos3, arrayLength)
        For k As Integer = 0 To 7
            arrayresult(k) = resultados.Split(","c)(k)
        Next
        AgenteBD.ObtenerAgente.Modificar("INSERT INTO Juegos VALUES ('" & CStr(arrayresult(0)) & "', '" & idPartido & "', '" & CStr(arrayresult(1)) & "', '" & CStr(arrayresult(2)) & "', '" & CStr(arrayresult(3)) & "');")
        AgenteBD.ObtenerAgente.Modificar("INSERT INTO Juegos VALUES ('" & CStr(arrayresult(4)) & "', '" & idPartido & "', '" & CStr(arrayresult(5)) & "', '" & CStr(arrayresult(6)) & "', '" & CStr(arrayresult(7)) & "');")

        ''Partido 4 cuartos
        arrayLength = longCadena(cuartos4)
        Dim rcuartos4(arrayLength) As String
        For k As Integer = 0 To arrayLength - 1
            rcuartos4(k) = cadena.Split(","c)(k)

        Next
        resultados = datosPartido(arrayNombres(2), arrayNombres(5), rcuartos4, arrayLength)
        For k As Integer = 0 To 7
            arrayresult(k) = resultados.Split(","c)(k)
        Next
        AgenteBD.ObtenerAgente.Modificar("INSERT INTO Juegos VALUES ('" & CStr(arrayresult(0)) & "', '" & idPartido & "', '" & CStr(arrayresult(1)) & "', '" & CStr(arrayresult(2)) & "', '" & CStr(arrayresult(3)) & "');")
        AgenteBD.ObtenerAgente.Modificar("INSERT INTO Juegos VALUES ('" & CStr(arrayresult(4)) & "', '" & idPartido & "', '" & CStr(arrayresult(5)) & "', '" & CStr(arrayresult(6)) & "', '" & CStr(arrayresult(7)) & "');")

        ''Partido 1 semifinales
        arrayLength = longCadena(semis1)
        Dim rsemis1(arrayLength) As String
        For k As Integer = 0 To arrayLength - 1
            rsemis1(k) = cadena.Split(","c)(k)
        Next
        resultados = datosPartido(arraynombres2(0), arraynombres2(1), rsemis1, arrayLength)
        For k As Integer = 0 To 7
            arrayresult(k) = resultados.Split(","c)(k)
        Next
        AgenteBD.ObtenerAgente.Modificar("UPDATE Juegos SET Set1='" & arrayresult(1) & "', Set2='" & arrayresult(2) & "', Set3='" & arrayresult(3) & "'WHERE Jugadora='" & arrayresult(0) & "';")
        AgenteBD.ObtenerAgente.Modificar("UPDATE Juegos SET Set1='" & arrayresult(5) & "', Set2='" & arrayresult(6) & "', Set3='" & arrayresult(7) & "'WHERE Jugadora='" & arrayresult(4) & "';")

        ''Partido 2 semifinales
        arrayLength = longCadena(semis2)
        Dim rsemis2(arrayLength) As String
        For k As Integer = 0 To arrayLength - 1
            rsemis2(k) = cadena.Split(","c)(k)
        Next
        resultados = datosPartido(arraynombres2(2), arraynombres2(3), rsemis2, arrayLength)
        For k As Integer = 0 To 7
            arrayresult(k) = resultados.Split(","c)(k)
        Next
        AgenteBD.ObtenerAgente.Modificar("UPDATE Juegos SET Set1='" & arrayresult(1) & "', Set2='" & arrayresult(2) & "', Set3='" & arrayresult(3) & "'WHERE Jugadora='" & arrayresult(0) & "';")
        AgenteBD.ObtenerAgente.Modificar("UPDATE Juegos SET Set1='" & arrayresult(5) & "', Set2='" & arrayresult(6) & "', Set3='" & arrayresult(7) & "'WHERE Jugadora='" & arrayresult(4) & "';")

        ''Partido final
        arrayLength = longCadena(final)
        Dim rfinal(arrayLength) As String
        For k As Integer = 0 To arrayLength - 1
            rfinal(k) = cadena.Split(","c)(k)
        Next
        resultados = datosPartido(arraynombres3(0), arraynombres3(1), rfinal, arrayLength)
        For k As Integer = 0 To 7
            arrayresult(k) = resultados.Split(","c)(k)
        Next
        AgenteBD.ObtenerAgente.Modificar("UPDATE Juegos SET Set1='" & arrayresult(1) & "', Set2='" & arrayresult(2) & "', Set3='" & arrayresult(3) & "'WHERE Jugadora='" & arrayresult(0) & "';")
        AgenteBD.ObtenerAgente.Modificar("UPDATE Juegos SET Set1='" & arrayresult(5) & "', Set2='" & arrayresult(6) & "', Set3='" & arrayresult(7) & "'WHERE Jugadora='" & arrayresult(4) & "';")


    End Sub

    Function longCadena(cuartos As String) As Integer
        cadena = Replace(cuartos, " - ", ",")
        If cadena.Length = 11 Then
            arrayLength = 6
        ElseIf cadena.Length = 13 Then
            arrayLength = 7
        End If
        Return arrayLength
    End Function


End Class

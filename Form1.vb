Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstCuadroPais.Items.Add("Inglaterra")
        lstCuadroPais.Items.Add("Paises Bajos")
        lstCuadroPais.Items.Add("Alemania")
        lstCuadroPais.Items.Add("México")
        lstCuadroPais.Items.Add("Italia")

        'Se aggregan los paises a la lista al cargarse el formulario
    End Sub

    Private Sub lstCuadroPais_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCuadroPais.MouseHover
        If lstCuadroPais.SelectedIndex < 0 Or
            lstCuadroPais.SelectedIndex > 5 Then
            etiPais.Text = "Por favor haga clic en el nombre de un país"
        End If
        'Si el SelectedIndex no captura un valor comprendido en la lista
        'se manda un mensaje de alerta al usuario
    End Sub

    Private Sub lstCuadroPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCuadroPais.SelectedIndexChanged
        etiPais.Text = lstCuadroPais.Text
        Select Case lstCuadroPais.SelectedIndex
            Case 0
                etiSaludos.Text = "Hello, programmer"
            Case 1
                etiSaludos.Text = "Hallo, programmeur"
            Case 2
                etiSaludos.Text = "Hallo, programmierer"
            Case 3
                etiSaludos.Text = "Hola, programador"
            Case 4
                etiSaludos.Text = "Ciao, programmatore"
        End Select

        'la etiqueta etiPais recibe el valor de la lista
        'dependiendo de la eleccion en la lista
        'la etiqueta etiSaludos muestra un saludo 
        'al programador en el idioma del pais seleccionado.
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class

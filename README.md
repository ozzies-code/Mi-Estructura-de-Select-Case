# Mi-Estructura-de-Select-Case

 Este proyecto hace uso del Select Case para hacer que un usuario 
 seleccione un pais de una lista y dependiendo del caso el programador 
 recibe un saludo en el idioma de ese pais.

# Descripcion

 Este proyecto consiste en una aplicacion que emplea
 un cuadro de lista que al cargarse el formulario
 llena con el metodo ADD la lista con los nombres
 de cinco paises. Cuando el usuario coloca el puntero
 del mouse sobre los paises de la lista pero sin 
 seleccionar alguno el evento MouseHeader alerta que
 el SelectedIndex de la lista no ha capturado o no 
 se ha llenado con algun indice proveniente de la
 seleccion de alguno de los cinco paises de la lista,
 lo que ocasiona que la etiqueta debajo de la lista
 alerte al usuario con un mensaje para que seleccione
 alguno de los cinco paises de la lista. Cuando el 
 usuario selecciona algun pais de la lista, 
 el programador recibe un saludo en el idioma del
 pais seleccionado.
 
 # Actualizacion: 04/01/2025
 # Hora: 22:07

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

# My-Select-Case-Structure

This project makes use of the Select Case to make a user
select a country from a list and depending on the case 
the programmer receives a greeting in the language 
of that country.

# Description

This project consists of an application that uses a list box 
that when the form is loaded fills the list with the names of 
five countries using the ADD method. When the user places the 
mouse pointer over the countries in the list but without 
selecting any, the MouseHeader event alerts that the 
SelectedIndex of the list has not been captured or has not been 
filled with any index from the selection of any of the five 
countries in the list, which causes the label below the list to 
alert the user with a message to select any of the five countries 
in the list. When the userselects any country from the list, 
the programmer receives a greeting in the language of the selected 
country.

# Update: 01/04/2025
# Time: 22:07

Technical details of the project:
Language: Visual Basic.NET
Framework version: 4.7.2

![imagen](https://github.com/user-attachments/assets/4dee4967-33e3-495f-a810-ce2eae3d4ec1)

Code of the Project:

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

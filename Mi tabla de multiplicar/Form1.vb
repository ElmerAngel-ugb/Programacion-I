﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, respuesta As Double 'Declaro las variables en linea separadas por comas del mismo tipo

        num1 = txtnum1.Text 'capturando el dato que ingres el usuario a la caja de texto, asigno dicho valor a la variable num1.
        num2 = txtnum2.Text

        If optSuma.Checked Then 'If -> si de condicion
            lblrespuesta.Text = num1 + num2 'realizamos la suma
        End If
        If optResta.Checked Then
            lblrespuesta.Text = num1 - num2 'realizamos la resta
        End If

        If optMultiplicar.Checked Then
            lblrespuesta.Text = num1 * num2 'realizamos la multiplicacion
        End If
        If optDividir.Checked Then
            lblrespuesta.Text = num1 / num2 'realizamos la division
        End If

        If optPorcentaje.Checked Then
            lblrespuesta.Text = num1 * num2 / 100 'realizamos el porcentaje
        End If
        If optExponenciacion.Checked Then
            lblrespuesta.Text = num1 ^ num2 'realizamos la elevacion
        End If

        If optmodulo.Checked Then
            lblrespuesta.Text = num1 Mod num2 'realizamos el sobrante
        End If

    End Sub
End Class

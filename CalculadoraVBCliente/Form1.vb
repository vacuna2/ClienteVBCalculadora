Public Class Form1
    Dim service As New ServiceReference1.CalculadoraServiceSoapClient

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim nro1 = txtn1.Text, nro2 = txtn2.Text
        Dim op = cbxOperacion.Text

        Select Case op
            Case "Suma"
                txtResultado.Text = service.suma(nro1, nro2)
            Case "Resta"
                txtResultado.Text = service.Resta(nro1, nro2)
            Case "Multiplicacion"
                txtResultado.Text = service.Multiplicacion(nro1, nro2)
            Case "Division"
                txtResultado.Text = service.div(nro1, nro2)
            Case "Coseno"
                txtResultado.Text = service.Coseno(nro1)
            Case "Seno"
                txtResultado.Text = service.Seno(nro1)
            Case "Tangente"
                txtResultado.Text = service.Tangente(nro1)
            Case "Inverso"
                txtResultado.Text = service.Inverso(nro1)
            Case "Potencia"
                txtResultado.Text = service.Potencia(nro1, nro2)
            Case "RaizCuadrada"
                txtResultado.Text = service.RaizCuadrada(nro1, nro2)
            Case "Factorial"
                txtResultado.Text = service.fac(nro1)
        End Select
    End Sub
End Class

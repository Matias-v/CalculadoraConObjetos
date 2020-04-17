Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_Valor1.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lbl_Valor2.Click

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_Calcular_Click(sender As Object, e As EventArgs) Handles btn_Calcular.Click

        Try
            Dim val1 As Integer = Integer.Parse(txt_Valor1.Text)
            Dim val2 As Integer = Integer.Parse(txt_Valor2.Text)
            Dim resultado As Double = 0
            Dim operador As String = cnb_Operador.Text
            Dim cuenta As Logica.Calcular = New Logica.Calcular()
            Select Case operador

                Case "Suma"
                    resultado = cuenta.suma(val1, val2)

                Case "Resta"
                    resultado = cuenta.resta(val1, val2)

                Case "Division"
                    If val2 <> 0 Then
                        resultado = cuenta.division(val1, val2)
                    Else
                        MsgBox("Error detectado: no se puede dividir entre 0")
                    End If

                Case "Multiplicacion"
                    resultado = cuenta.multiplicacion(val1, val2)

                Case Else
                    MsgBox("Error detectado: debe seleccionar un operador")
            End Select

            txt_Resultado.Text = resultado

        Catch ex As Exception
            MsgBox("Error detectado: " & ex.Message)
        End Try



    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Close()
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        txt_Valor1.Text = ""
        txt_Valor2.Text = ""
        txt_Resultado.Text = ""
        cnb_Operador.Text = "Suma"

    End Sub
End Class

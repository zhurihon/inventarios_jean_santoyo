Public Class Report
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        menuprincipal.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_report.Click

        Select Case cb_tipo.Text
            Case "Stock"
                reportes.fexcel2(controller.sql.consulta_productos, " Stock")
                'MsgBox(2)
        End Select


    End Sub

    Private Sub cb_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tipo.SelectedIndexChanged

    End Sub
End Class
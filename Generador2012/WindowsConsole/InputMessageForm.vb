Public Class InputMessageForm
    Private mMensaje As String = ""
    Private Sub EjecutarToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles EjecutarToolStripButton.Click
        Debug.Print("INICIO DE LINEA")
        Debug.Print(MensajeTextBox.Text)
        Debug.Print("*=====================================================================================*")
        For Each line As String In MensajeTextBox.Text
            If Not Char.IsControl(line) Then
                mMensaje &= line.Trim("'")
            End If
        Next
        ArmadoTextBox.Text = mMensaje
    End Sub
    Private Sub LimpiarToolStripButton_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripButton.Click
        ArmadoTextBox.Text = ""
        MensajeTextBox.Text = ""
        mMensaje = ""
    End Sub
End Class

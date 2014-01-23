Imports Cimagroup
Public Class UploadForm
    'Public WithEvents mArchivoEspecificacion As New BussinesObject.ArchivoEspecificacion
    Dim archivoMtx As New Cimagroup.Generador2012.GeneradorBussinesObject.ArchivoEspecificacion()
    Dim rutas As New Cimagroup.Generador2012.GeneradorBussinesObject.Directorios()
    Dim filename As String
    Private WithEvents cmp As Generador2012.GeneradorBussinesLogic.GeneradorBussinesLogic
    Private Sub UploadForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        rutas.Debug = My.Resources.GlobalAxa.PATH_DEBUG
        rutas.Input = My.Resources.GlobalAxa.PATH_INPUT
        rutas.DefaultPath = My.Resources.GlobalAxa.PATH_DEFAULT
        rutas.Doc = My.Resources.GlobalAxa.PATH_DOC
        rutas.Log = My.Resources.GlobalAxa.PATH_LOG
        rutas.Output = My.Resources.GlobalAxa.PATH_OUTPUT
    End Sub
    Private Sub OpenFileButton_Click(sender As System.Object, e As System.EventArgs) Handles OpenFileButton.Click
        tsslProgress.Value = 0
        tsslMensaje.Text = ""
        tsslActivo.Text = ""
        rtbArchivo.Text = ""
        OpenFileDialog.FileName = "GNSBEEV01.mtx"
        Debug.Print("Directorio Actual : {0}", rutas.DefaultPath)
        If OpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            filename = OpenFileDialog.FileName
            FilenameTextBox.Text = filename
            tsslMensaje.Text = String.Format("Archivo {0} Abierto", filename)
            Debug.Print(filename)
            archivoMtx.LeerArchivo(filename)
            'Threading.Thread.Sleep(1000)
            ArchivoEspecificacion_ArchivoLeido()
        End If
    End Sub
    Private Sub ArchivoEspecificacion_ArchivoLeido() 'Handles mArchivoEspecificacion.ArchivoLeido
        rtbArchivo.Text = archivoMtx.Contenido
        tsslMensaje.Text = "Archivo Cargado"
    End Sub
    Private Sub CompilarButton_Click(sender As System.Object, e As System.EventArgs) Handles CompilarButton.Click
        CompilarButton.Enabled = False
        cmp = New Generador2012.GeneradorBussinesLogic.GeneradorBussinesLogic(rutas)
        cmp.FuenteMTX = archivoMtx
        cmp.Generar()
        tsslMensaje.Text = "Generacion Completada!!!"
        tsslActivo.Text = ""
        tsslProgress.Value = 100
        CompilarButton.Enabled = True
        ' cmp = Nothing
    End Sub
    Private Sub BtnReformat_Click(sender As System.Object, e As System.EventArgs) Handles BtnReformat.Click
        Dim fileI As System.IO.StreamReader = New System.IO.StreamReader(filename)
        Dim Streamer As New System.IO.StreamWriter(String.Format("{0}.cbl", filename.Split(".")))
        Dim strFile As String = ""
        While fileI.Peek > -1
            strFile += fileI.ReadLine
        End While
        rtbArchivo.Text = strFile
        Debug.Print(strFile)
        Dim position As Integer = 0
        While position < strFile.Length
            Debug.Print(position.ToString)
            Streamer.WriteLine(strFile.Substring(position, 72))
            position += 80
        End While
        Streamer.Close()
        fileI.Close()
    End Sub
    Private Sub GeneracionModulo_Iniciado(msg As String) Handles cmp.Iniciado
        tsslActivo.Text = String.Format("Generando {0}", msg)
    End Sub
    Private Sub GeneracionModulo_Terminado() Handles cmp.Terminado
        tsslActivo.Text = ""
        If tsslProgress.Value < 90 Then
            tsslProgress.Value += 10
        Else
            If tsslProgress.Value < 100 Then
                tsslProgress.Value += 2
            Else
                tsslProgress.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        AddHandler OpenFileButton.Click, AddressOf OpenFileButton_Click
        OpenFileButton_Click(sender, e)
    End Sub
    Private Sub ConvertidorPTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConvertidorPTToolStripMenuItem.Click
        InputMessageForm.ShowDialog()
    End Sub

    Private Sub ConvertidorTPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConvertidorTPToolStripMenuItem.Click

    End Sub
End Class

Imports System.IO
Imports System.Globalization
Public Class SubsidiarioFrm
    Private dataStream As StreamReader
    Private scan As ScannerSubsidiario
    Private FecProceso As String = Date.Now.ToString("yyyyMMdd")
    Private Sub OpenFileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileButton.Click
        ArchivoOpenFileDialog.ShowDialog()
        ArchivoTextBox.Text = ArchivoOpenFileDialog.FileName
        Dim Archivo As FileStream = File.OpenRead(ArchivoTextBox.Text)
        dataStream = New StreamReader(Archivo)
        InfoLabel.Text = String.Format("Archivo abierto '{0}'", ArchivoTextBox.Text)
        ProcesarButton.Enabled = True
        OpenFileButton.Enabled = False
    End Sub
    Private Sub ProcesarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcesarButton.Click
        InfoLabel.Text = String.Format("Procesando....")
        scan = New ScannerSubsidiario(dataStream)
        InfoLabel.Text = String.Format("Procesando....")
        If scan.Subsidiarios Is Nothing Then
            InfoLabel.Text = String.Format("No se encontraron subsidiarios")
            Return
        End If
        If scan.Subsidiarios.Count < 1001 Then
            For Each s As Subsidiario In scan.Subsidiarios
                DetalleTextBox.Text += s.Nombre & " " & s.NumeroOperacion & vbCrLf
            Next
        End If
        InfoLabel.Text = String.Format("Archivo procesado")
        ExportButton.Enabled = True
        ProcesarButton.Enabled = False
    End Sub
    Private Sub ExportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportButton.Click
        ExportSaveFileDialog.FileName = FecProceso & "-Subsidiario.csv"
        ExportSaveFileDialog.ShowDialog()
        Dim archivo As FileStream = File.OpenWrite(ExportSaveFileDialog.FileName)
        Dim streamcsv As New StreamWriter(archivo)
        Try
            streamcsv.WriteLine("Fecha;Oficina;CuentaContable;Nombre;Rut;Operacion;Serial;Tasa;Debe;Haber;Algoritmo;Saldo")
            For Each s As Subsidiario In scan.Subsidiarios
                streamcsv.WriteLine(s.toString)
            Next
            streamcsv.Flush()
        Catch ex As Exception
            Debug.Print("Error : {0}", ex.Message)
        Finally
            streamcsv.Close()
        End Try
        InfoLabel.Text = String.Format("Archivo Guardado '{0}'", ExportSaveFileDialog.FileName)
        ExportButton.Enabled = False
    End Sub
    Private Sub TotalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalButton.Click
        Dim totalizo As Boolean = False
        If CuentaCtblCheckBox.Checked Or OficinaCheckBox.Checked Then
            totalizo = True
        End If
        If Not totalizo Then
            InfoLabel.Text = "Debe seleccionar criterio de totalizacion"
            Return
        End If
        TotalDataGridView.DataSource = TotalizaGrid()
        ExportarButton.Enabled = True
        TotalButton.Enabled = False
    End Sub
    Private Function TotalizaGrid() As List(Of Totalizado)
        Dim Contabilidad As New List(Of Totalizado)
        For Each s In scan.Subsidiarios
            FecProceso = s.Fecha
            Dim tot As Totalizado = New Totalizado(s.CtaCtble, s.Debe, s.Haber)
            tot = Acumulador(Contabilidad, tot, Contabilidad.Count)
        Next
        Return Contabilidad
    End Function
    Private Function Acumulador(ByRef Contabilidad As List(Of Totalizado), ByVal tot As Totalizado, ByVal index As Integer) As Totalizado
        If index <= 0 Then
            Contabilidad.Add(tot)
            Return tot
        ElseIf Contabilidad(index - 1).CtaCtbl = tot.CtaCtbl Then
            Contabilidad(index - 1).MontoDebe += tot.MontoDebe
            Contabilidad(index - 1).MontoHaber += tot.MontoHaber
            Return Contabilidad(index - 1)
        Else
            Return Acumulador(Contabilidad, tot, index - 1)
        End If
    End Function
    Private Sub ExportarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarButton.Click
        ExportSaveFileDialog.FileName = FecProceso.Replace("/", "") & "-Totales.csv"
        ExportSaveFileDialog.ShowDialog()
        Dim archivo As FileStream = File.OpenWrite(ExportSaveFileDialog.FileName)
        Dim streamcsv As New StreamWriter(archivo)
        Try
            streamcsv.WriteLine("CuentaContable;Debe;Haber;")
            For Each s As Totalizado In TotalDataGridView.DataSource
                streamcsv.WriteLine(s.ToString)
            Next
            streamcsv.Flush()
        Catch ex As Exception
            Debug.Print("Error : {0}", ex.Message)
        Finally
            streamcsv.Close()
        End Try
        InfoLabel.Text = String.Format("Archivo Totales Guardado '{0}'", ExportSaveFileDialog.FileName)
        ExportarButton.Enabled = False
    End Sub
End Class
Public Class Totalizado
    Private mCtaCtbl As String
    Private mMontoDebe As Decimal = 0
    Private mMontoHaber As Decimal = 0
    Public Property CtaCtbl() As String
        Get
            Return mCtaCtbl
        End Get
        Set(ByVal value As String)
            mCtaCtbl = value
        End Set
    End Property
    Public Property MontoDebe() As Decimal
        Get
            Return mMontoDebe
        End Get
        Set(ByVal value As Decimal)
            mMontoDebe = value
        End Set
    End Property
    Public Property MontoHaber() As Decimal
        Get
            Return mMontoHaber
        End Get
        Set(ByVal value As Decimal)
            mMontoHaber = value
        End Set
    End Property
    Public Sub New(ByVal Cuenta As String, ByVal Debe As String, ByVal haber As String)
        mCtaCtbl = Cuenta
        mMontoDebe = CDec(Debe)
        mMontoHaber = CDec(haber)
    End Sub
    Public Overrides Function ToString() As String
        Return String.Format("{0};{1};{2}", mCtaCtbl, mMontoDebe.ToString("C4", CultureInfo.CreateSpecificCulture("es-CL")), mMontoHaber.ToString("C4", CultureInfo.CreateSpecificCulture("es-CL")))
    End Function
End Class
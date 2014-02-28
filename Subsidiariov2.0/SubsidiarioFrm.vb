Imports System.IO
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Globalization
Public Class SubsidiarioFrm
    Private dataStream As StreamReader
    Private scan As ScannerSubsidiario
    Private FecProceso As String = Date.Now.ToString("yyyyMMdd")
    Private MES_PROCESO As String = "Enero"
    Dim totalScan As New List(Of Subsidiario)
    Private Sub SubsidiarioFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub MesComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles MesComboBox.SelectedValueChanged
        FolderBrowserDialog.SelectedPath = My.Resources.PATH_SUBSIDIARIO & "\" & MesComboBox.SelectedItem
        PathTextBox.Text = FolderBrowserDialog.SelectedPath
        MES_PROCESO = MesComboBox.SelectedItem
    End Sub
    Private Sub PathButton_Click(sender As Object, e As EventArgs) Handles PathButton.Click
        FolderBrowserDialog.SelectedPath = My.Resources.PATH_SUBSIDIARIO
        If FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PathTextBox.Text = FolderBrowserDialog.SelectedPath
            ActiveLabel.Text = "Ruta seleccionada...." & FolderBrowserDialog.SelectedPath
        End If
    End Sub
    Private Sub LecturaButton_Click(sender As Object, e As EventArgs) Handles LecturaButton.Click
        If Not MesComboBox.SelectedItem Is Nothing Then
            MES_PROCESO = MesComboBox.SelectedItem
        End If
        Debug.Print("Inicio Etapa I.Lectura Archivos....")
        ActiveLabel.Text = String.Format("Lectura y formateo archivos subsidiarios del mes {0}", MES_PROCESO)
        ActiveLabel.Text = "Procesando Lectura de Archivos...."
        EtapaInicialLecturaArchivos(totalScan)
        Debug.Print("Fin Etapa I.Lectura Archivos....")
    End Sub
    Private Sub DetalleButton_Click(sender As Object, e As EventArgs) Handles DetalleButton.Click
        Debug.Print("Inicio Etapa II.Exportando Archivos....")
        ActiveLabel.Text = "Exportando Archivos...."
        SegundaEtapaExportarSubsidiario(totalScan)
        Debug.Print("Fin Generacion de Detalle....")
    End Sub
    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Debug.Print("Inicio Etapa II.Carga de Datos....")
        ActiveLabel.Text = "Procesando Carga de Base de Datos...."
        EtapaIntegrationTotales(totalScan)
        Debug.Print("Fin Etapa II.Lectura Archivos....")
    End Sub
    Private Sub GeneraTotalButton_Click(sender As Object, e As EventArgs) Handles GeneraTotalButton.Click
        Debug.Print("Inicio Etapa IV.Calculando Totales Mensuales....")
        ActiveLabel.Text = "Calculando Totales Mensuales...."
        EtapaTotalesMensuales()
        Debug.Print("Final Etapa IV.")
    End Sub
    Private Sub EtapaInicialLecturaArchivos(totalScan As List(Of Subsidiario))
        CargarSubsidiarioProgressBar.Value = 0
        Dim files As FileInfo
        Dim dir As DirectoryInfo = New DirectoryInfo(PathTextBox.Text)
        Dim cont As Integer = 0
        Dim totalFile As Integer = dir.EnumerateFiles.Count()
        For Each files In dir.GetFiles
            cont += 1
            Dim Archivo As FileStream = File.OpenRead(dir.FullName & "\" & files.Name)
            Debug.Print("Procesando archivo {0}", Archivo.Name)
            ActiveLabel.Text = Archivo.Name
            dataStream = New StreamReader(Archivo)
            scan = New ScannerSubsidiario(dataStream)
            CargarSubsidiarioProgressBar.Value = (cont / totalFile) * 100
            AddScan(totalScan, scan)
        Next
        CargarSubsidiarioProgressBar.Value = 100
        ActiveLabel.Text = ""
    End Sub
    Private Sub AddScan(ByVal s1 As List(Of Subsidiario), ByRef s2 As ScannerSubsidiario)
        For Each s As Subsidiario In s2.Subsidiarios
            s1.Add(s)
        Next
    End Sub
    Private Sub SegundaEtapaExportarSubsidiario(s As List(Of Subsidiario))
        DetalleProgressBar.Value = 0
        Dim sFile As String = My.Resources.PATH_APP & "\Subsidiario\" & MES_PROCESO & ".csv" 'Date.Now.ToString("MMMM") & ".csv"
        Dim archivo As FileStream = File.OpenWrite(sFile)
        Dim streamcsv As New StreamWriter(archivo)
        ActiveLabel.Text = String.Format("Generando archivo '{0}'", sFile)
        Try
            streamcsv.WriteLine("Fecha;Oficina;CuentaContable;Nombre;Rut;Operacion;Serial;Tasa;Debe;Haber;Algoritmo;Saldo")
            Debug.Print("Para el Subsi {1} hay {0} registros", s.Count, sFile)
            Dim i As Integer = 0
            For Each scan As Subsidiario In s
                'Debug.Print(scan.toString)
                i += 1
                DetalleProgressBar.Value = (i / s.Count) * 100
                streamcsv.WriteLine(scan.toString)
            Next
            streamcsv.Flush()
        Catch ex As Exception
            Debug.Print("Error : {0}", ex.Message)
        Finally
            streamcsv.Close()
            DetalleProgressBar.Value = 100
            ActiveLabel.Text = "Archivo Generado " & sFile
        End Try
    End Sub
    Private Sub EtapaIntegrationTotales(lista As List(Of Subsidiario))
        Debug.Print("Inicio Integracion por Totales")
        LoadProgressBar.Value = 0
        Dim i As Integer = 0
        Dim scon As SqlConnection = New SqlConnection(My.Resources.CONECTDB_SUBSIDIARIO)
        Dim query As String = String.Format("Delete FROM SubsidiarioMensual WHERE MesProceso = '{0}'", MES_PROCESO)
        Dim scomd As SqlCommand = New SqlCommand(query, scon)
        scon.Open()
        scomd.ExecuteNonQuery()
        query = String.Format("InsertarSubsidiario")
        For Each s As Subsidiario In lista
            Try
                i += 1
                LoadProgressBar.Value = (i / lista.Count) * 100
                Dim scomm As SqlCommand = New SqlCommand(query, scon)
                scomm.CommandType = CommandType.StoredProcedure
                scomm.Parameters.AddWithValue("@Fecha", s.Fecha)
                scomm.Parameters.AddWithValue("@Oficina", s.Oficina)
                scomm.Parameters.AddWithValue("@CtaCtbl", s.CtaCtble)
                scomm.Parameters.AddWithValue("@Nombre", s.Nombre)
                scomm.Parameters.AddWithValue("@Rut", s.Rut)
                scomm.Parameters.AddWithValue("@Operacion", s.NumeroOperacion)
                scomm.Parameters.AddWithValue("@Serial", s.NumeroSerial)
                scomm.Parameters.AddWithValue("@Tasa", s.Tasa)
                scomm.Parameters.AddWithValue("@Debe", Regex.Replace(s.Debe, "\.", ""))
                scomm.Parameters.AddWithValue("@Haber", Regex.Replace(s.Haber, "\.", ""))
                scomm.Parameters.AddWithValue("@Algoritmo", s.Algoritmo)
                scomm.Parameters.AddWithValue("@Saldo", Regex.Replace(s.Saldo, "\.", ""))
                scomm.Parameters.AddWithValue("@MesProceso", MES_PROCESO)
                scomm.ExecuteNonQuery()
            Catch ex As Exception
                Debug.Print("error en registro {0}", s.toString)
            End Try
        Next
        scon.Close()
        LoadProgressBar.Value = 100
        Debug.Print("Termino la Integracion por Totales")
    End Sub
    Private Sub EtapaTotalesMensuales()
        Debug.Print("Inicio Calculo de Totales del Mes")
        TotalProgressBar.Value = 0
        Dim i As Integer = 0
        Dim Contabilidad As New List(Of TotalMensual)
        Dim scon As SqlConnection = New SqlConnection(My.Resources.CONECTDB_SUBSIDIARIO)
        scon.Open()
        Dim scomm As New SqlClient.SqlCommand("TotalizaMensual", scon)
        scomm.CommandType = CommandType.StoredProcedure
        scomm.Parameters.AddWithValue("@MesOperacion", MES_PROCESO)
        Dim dsTotal As DataSet = New DataSet()
        Dim daTotal As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(scomm)
        daTotal.Fill(dsTotal)
        scon.Close()
        For Each row As DataRow In dsTotal.Tables(0).Rows
            i += 1
            TotalProgressBar.Value = (i / dsTotal.Tables(0).Rows.Count) * 100
            Dim tot As TotalMensual = New TotalMensual(row("Cuenta"), row("Operacion"), row("Debe"), row("Haber"))
            Contabilidad.Add(tot)
        Next
        TotalProgressBar.Value = 100
        Debug.Print("Exporta archivo Totales del Mes")
        TotalProgressBar.Value = 0
        i = 0
        Dim sFile As String = My.Resources.PATH_APP & "\Subsidiario\SubsidiarioTotal_" & MES_PROCESO & ".csv"
        Dim archivo As FileStream = File.OpenWrite(sFile)
        Dim streamcsv As New StreamWriter(archivo)
        Try
            streamcsv.WriteLine("Operacion;CuentaContable;Debe;Haber;")
            For Each T As TotalMensual In Contabilidad
                i += 1
                TotalProgressBar.Value = (i / Contabilidad.Count) * 100
                streamcsv.WriteLine(T.ToString)
            Next
            streamcsv.Flush()
        Catch ex As Exception
            Debug.Print("Error : {0}", ex.Message)
        Finally
            ActiveLabel.Text = "Archivo Generado " & sFile
            streamcsv.Close()
        End Try
        Debug.Print("Termino Calculo de Totales del Mes")
    End Sub
End Class
Public Class TotalMensual
    Inherits Totalizado
    Private mOperacion As String
    Public Property Operacion() As String
        Get
            Return mOperacion
        End Get
        Set(value As String)
            mOperacion = value
        End Set
    End Property
    Sub New(ByVal Cuenta As String, ByVal Opera As String, ByVal debe As String, ByVal haber As String)
        MyBase.New(Cuenta, debe, haber)
        'Debug.Print(" debe " + debe + "  haber " + haber)
        mOperacion = Opera
    End Sub
    Public Overrides Function ToString() As String
        Return String.Format("{3};{0};{1};{2}", MyBase.CtaCtbl, MyBase.MontoDebe.ToString("C4", CultureInfo.CreateSpecificCulture("es-CL")).PadLeft(25), MyBase.MontoHaber.ToString("C4", CultureInfo.CreateSpecificCulture("es-CL")).PadLeft(25), mOperacion)
    End Function
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
        mMontoDebe = Val(Debe)
        mMontoHaber = Val(haber)
        'Debug.Print(mCtaCtbl & " - " & mMontoDebe & " - " & MontoHaber)
    End Sub
    Public Overrides Function ToString() As String
        Return String.Format("{0};{1};{2}", mCtaCtbl, mMontoDebe.ToString("C4", CultureInfo.CreateSpecificCulture("es-CL")).PadLeft(25), mMontoHaber.ToString("C4", CultureInfo.CreateSpecificCulture("es-CL")).PadLeft(25))
    End Function
End Class

Imports System.IO
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Globalization
Enum adiEtapas
    cCargarSubsidiario
    cGenerarDetalleFile
    cInyectarDetalle
    cCalculoTotales
    cCargaCartera
    cGenerarSaldos
    cTerminado
End Enum
Public Class SubsidiarioFrm
    Private dataStream As StreamReader
    Private scan As ScannerSubsidiario
    Private FecProceso As String = Date.Now.ToString("yyyyMMdd")
    Private MES_PROCESO As String = "Enero"
    Private EstadoEtapa As adiEtapas = adiEtapas.cCargarSubsidiario
    Dim totalScan As New List(Of Subsidiario)
#Region "Subsidiario"
    Private Sub EtapasCheckedListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EtapasCheckedListBox.SelectedIndexChanged
        For Each item In EtapasCheckedListBox.CheckedItems
            Select Case item
                Case "Cargar Archivos Subsidiario"
                    EstadoEtapa = adiEtapas.cCargarSubsidiario
                Case "Generar Archivo Detalle"
                    EstadoEtapa = adiEtapas.cGenerarDetalleFile
                Case "Inyeccion de Detalle DB"
                    EstadoEtapa = adiEtapas.cInyectarDetalle
                Case "Calculo de Totales Subsidiario"
                    EstadoEtapa = adiEtapas.cCalculoTotales
                Case "Cargar Cartera GCD"
                    EstadoEtapa = adiEtapas.cCargaCartera
                Case "Generar Saldos Promedio"
                    EstadoEtapa = adiEtapas.cGenerarSaldos
            End Select
        Next
    End Sub
    Private Sub MesComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles MesComboBox.SelectedValueChanged
        FolderBrowserDialog.SelectedPath = My.Resources.PATH_SUBSIDIARIO & "\" & MesComboBox.SelectedItem
        PathTextBox.Text = FolderBrowserDialog.SelectedPath
        MES_PROCESO = MesComboBox.SelectedItem
    End Sub
    Private Sub OpenFolderButton_Click(sender As Object, e As EventArgs) Handles OpenFolderButton.Click
        ' Prueba de valores de conversion
        'Dim iTest As String = "1500000.00"
        'Debug.Print(Val(iTest).ToString("C4", CultureInfo.CreateSpecificCulture("es-CL")).PadLeft(25))
        FolderBrowserDialog.SelectedPath = My.Resources.PATH_SUBSIDIARIO
        If FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PathTextBox.Text = FolderBrowserDialog.SelectedPath
            ActivoLabel.Text = "Ruta seleccionada...." & FolderBrowserDialog.SelectedPath
        End If
    End Sub
    Private Sub ProcesarButton_Click(sender As Object, e As EventArgs) Handles ProcesarButton.Click
        EtapaProgressBar.Maximum = 7
        ProcesarEtapas()
    End Sub
    Private Sub ProcesarEtapas()
        Try
            Select Case EstadoEtapa
                Case adiEtapas.cCargarSubsidiario
                    If Not MesComboBox.SelectedItem Is Nothing Then
                        MES_PROCESO = MesComboBox.SelectedItem
                    End If
                    Debug.Print("Inicio Etapa I.Lectura Archivos....")
                    InfoEtapaLabel.Text = String.Format("Lectura y formateo archivos subsidiarios del mes {0}", MES_PROCESO)
                    EtapaProgressBar.Value = 1
                    InfoEtapaLabel.Text = "Procesando Lectura de Archivos...."
                    EtapaInicialLecturaArchivos(totalScan)
                    EtapasCheckedListBox.SetItemCheckState(0, CheckState.Checked)
                    EstadoEtapa = adiEtapas.cGenerarDetalleFile
                    Debug.Print("Fin Etapa I.Lectura Archivos....")
                    ProcesarEtapas()
                Case adiEtapas.cGenerarDetalleFile
                    EtapaProgressBar.Value = 2
                    Debug.Print("Inicio Etapa II.Exportando Archivos....")
                    InfoEtapaLabel.Text = "Exportando Archivos...."
                    SegundaEtapaExportarSubsidiario(totalScan)
                    EtapasCheckedListBox.SetItemCheckState(1, CheckState.Checked)
                    EstadoEtapa = adiEtapas.cInyectarDetalle
                    ProcesarEtapas()
                Case adiEtapas.cInyectarDetalle
                    EtapaProgressBar.Value = 3
                    Debug.Print("Inicio Etapa III.Inyectando Totales Mensuales....")
                    InfoEtapaLabel.Text = "Inyectando Totales Mensuales...."
                    EtapaIntegrationTotales(totalScan)
                    EtapasCheckedListBox.SetItemCheckState(2, CheckState.Checked)
                    EstadoEtapa = adiEtapas.cCalculoTotales
                    ProcesarEtapas()
                Case adiEtapas.cCalculoTotales
                    EtapaProgressBar.Value = 4
                    Debug.Print("Inicio Etapa IV.Calculando Totales Mensuales....")
                    InfoEtapaLabel.Text = "Calculando Totales Mensuales...."
                    EtapaTotalesMensuales()
                    EtapasCheckedListBox.SetItemCheckState(3, CheckState.Checked)
                    EstadoEtapa = adiEtapas.cCargaCartera
                    ProcesarEtapas()
                Case adiEtapas.cCargaCartera
                    EtapaProgressBar.Value = 5
                    Debug.Print("Inicio Etapa V.Cargando Archivos de Cartera....")
                    InfoEtapaLabel.Text = "Cargando Archivos de Cartera...."
                    EtapaCargaCartera()
                    EtapasCheckedListBox.SetItemCheckState(4, CheckState.Checked)
                    EstadoEtapa = adiEtapas.cGenerarSaldos
                    ProcesarEtapas()
                Case adiEtapas.cGenerarSaldos
                    EtapaProgressBar.Value = 6
                    Debug.Print("Inicio Etapa VI.Calcula Saldos Promedio....")
                    InfoEtapaLabel.Text = "Calcula Saldos Promedio...."
                    EtapaCalculaSaldosPromedios()
                    EtapasCheckedListBox.SetItemCheckState(5, CheckState.Checked)
                    EstadoEtapa = adiEtapas.cTerminado
                    ProcesarEtapas()
                Case Else
                    EtapaProgressBar.Value = 7
                    Debug.Print("Proceso Terminado!!!")
                    InfoLabel.Text = "Proceso Terminado!!!"
            End Select
        Catch ex As Exception
            Debug.Print("Error no controlado {0}", ex.Message)
        End Try
    End Sub
    Private Sub EtapaInicialLecturaArchivos(totalScan As List(Of Subsidiario))
        FileProgressBar.Value = 0
        Dim files As FileInfo
        Dim dir As DirectoryInfo = New DirectoryInfo(PathTextBox.Text)
        Dim cont As Integer = 0
        Dim totalFile As Integer = dir.EnumerateFiles.Count()
        For Each files In dir.GetFiles
            cont += 1
            Dim Archivo As FileStream = File.OpenRead(dir.FullName & "\" & files.Name)
            Debug.Print("Procesando archivo {0}", Archivo.Name)
            ActivoLabel.Text = Archivo.Name
            dataStream = New StreamReader(Archivo)
            scan = New ScannerSubsidiario(dataStream)
            FileProgressBar.Value = (cont / totalFile) * 100
            AddScan(totalScan, scan)
        Next
        FileProgressBar.Value = 100
        ActivoLabel.Text = ""
    End Sub
    Private Sub AddScan(ByVal s1 As List(Of Subsidiario), ByRef s2 As ScannerSubsidiario)
        For Each s As Subsidiario In s2.Subsidiarios
            s1.Add(s)
        Next
    End Sub
    Private Sub SegundaEtapaExportarSubsidiario(s As List(Of Subsidiario))
        FileProgressBar.Value = 0
        Dim sFile As String = My.Resources.PATH_APP & "\Subsidiario" & MES_PROCESO & ".csv" 'Date.Now.ToString("MMMM") & ".csv"
        Dim archivo As FileStream = File.OpenWrite(sFile)
        Dim streamcsv As New StreamWriter(archivo)
        ActivoLabel.Text = String.Format("Generando archivo '{0}'", sFile)
        Try
            streamcsv.WriteLine("Fecha;Oficina;CuentaContable;Nombre;Rut;Operacion;Serial;Tasa;Debe;Haber;Algoritmo;Saldo")
            Debug.Print("Para el Subsi {1} hay {0} registros", s.Count, sFile)
            Dim i As Integer = 0
            For Each scan As Subsidiario In s
                'Debug.Print(scan.toString)
                i += 1
                FileProgressBar.Value = (i / s.Count) * 100
                streamcsv.WriteLine(scan.toString)
            Next
            streamcsv.Flush()
        Catch ex As Exception
            Debug.Print("Error : {0}", ex.Message)
        Finally
            streamcsv.Close()
            FileProgressBar.Value = 100
            ActivoLabel.Text = "Archivo Generado " & sFile
        End Try
    End Sub
    Private Sub EtapaIntegrationTotales(lista As List(Of Subsidiario))
        Debug.Print("Inicio Integracion por Totales")
        FileProgressBar.Value = 0
        Dim i As Integer = 0
        Dim scon As SqlConnection = New SqlConnection(My.Resources.CONECTDB_SUBSIDIARIO)
        Dim query As String = String.Format("Delete {0}2013", MES_PROCESO)
        Dim scomd As SqlCommand = New SqlCommand(query, scon)
        scon.Open()
        scomd.ExecuteNonQuery()
        query = String.Format("InsertarSubsidiario")
        For Each s As Subsidiario In lista
            Try
                i += 1
                FileProgressBar.Value = (i / lista.Count) * 100
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
        FileProgressBar.Value = 100
        Debug.Print("Termino la Integracion por Totales")
    End Sub
    Private Sub EtapaTotalesMensuales()
        Debug.Print("Inicio Calculo de Totales del Mes")
        FileProgressBar.Value = 0
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
            FileProgressBar.Value = (i / dsTotal.Tables(0).Rows.Count) * 100
            Dim tot As TotalMensual = New TotalMensual(row("Cuenta"), row("Operacion"), row("Debe"), row("Haber"))
            Contabilidad.Add(tot)
        Next
        FileProgressBar.Value = 100
        Debug.Print("Exporta archivo Totales del Mes")
        FileProgressBar.Value = 0
        i = 0
        Dim sFile As String = My.Resources.PATH_APP & "\SubsidiarioTotal_" & MES_PROCESO & ".csv"
        Dim archivo As FileStream = File.OpenWrite(sFile)
        Dim streamcsv As New StreamWriter(archivo)
        Try
            streamcsv.WriteLine("Operacion;CuentaContable;Debe;Haber;")
            For Each T As TotalMensual In Contabilidad
                i += 1
                FileProgressBar.Value = (i / Contabilidad.Count) * 100
                streamcsv.WriteLine(T.ToString)
            Next
            streamcsv.Flush()
        Catch ex As Exception
            Debug.Print("Error : {0}", ex.Message)
        Finally
            ActivoLabel.Text = "Archivo Generado " & sFile
            streamcsv.Close()
        End Try
        Debug.Print("Termino Calculo de Totales del Mes")
    End Sub
    Private Sub EtapaCargaCartera()
        FileProgressBar.Value = 0
        Dim files As FileInfo
        Dim dir As DirectoryInfo = New DirectoryInfo(My.Resources.PATH_CARTERA & "\" & MES_PROCESO)
        Dim cont As Integer = 0
        Dim totalFile As Integer = dir.EnumerateFiles.Count()
        Dim scon As SqlConnection = New SqlConnection(My.Resources.CONECTDB_CARTERA)
        Dim query As String = String.Format("Delete {0}", MES_PROCESO)
        Dim scomd As SqlCommand = New SqlCommand(query, scon)
        scon.Open()
        scomd.ExecuteNonQuery()
        scon.Close()
        For Each files In dir.GetFiles
            cont += 1
            Dim Archivo As FileStream = File.OpenRead(dir.FullName & "\" & files.Name)
            ActivoLabel.Text = Archivo.Name
            dataStream = New StreamReader(Archivo)
            FileProgressBar.Value = (cont / totalFile) * 100
            Debug.Print("Inicio Carga de Cartera {0}", files.Name)
            CargaCarteraFile(dataStream)
        Next
        FileProgressBar.Value = 100
        ActivoLabel.Text = ""
    End Sub
    Private Sub CargaCarteraFile(ByRef dataFile As StreamReader)
        Dim i As Integer = 0
        Dim scon As SqlConnection = New SqlConnection(My.Resources.CONECTDB_CARTERA)
        Dim query As String = String.Format("InsertarCartera")
        scon.Open()
        While Not dataFile.EndOfStream
            i += 1
            Dim linea As String = dataFile.ReadLine()
            If linea.Length = 0 Or linea.Trim().Length = 0 Then
                Debug.Print("Linea Blanca Cartera '{0}'", linea)
            Else
                Dim scomm As SqlCommand = New SqlCommand(query, scon)
                scomm.CommandType = CommandType.StoredProcedure
                scomm.Parameters.AddWithValue("@TipoRegistro", linea.Substring(0, 1))
                scomm.Parameters.AddWithValue("@TipoCaptacion", linea.Substring(2, 4))
                scomm.Parameters.AddWithValue("@RutCliente", linea.Substring(7, 10))
                scomm.Parameters.AddWithValue("@RutCliente2", linea.Substring(18, 10))
                scomm.Parameters.AddWithValue("@NumeroOperacion", linea.Substring(29, 12))
                scomm.Parameters.AddWithValue("@Serial", linea.Substring(42, 12))
                scomm.Parameters.AddWithValue("@Oficina", linea.Substring(55, 3))
                scomm.Parameters.AddWithValue("@Moneda", linea.Substring(59, 6))
                scomm.Parameters.AddWithValue("@Tasa", linea.Substring(66, 9))
                scomm.Parameters.AddWithValue("@FechaEmision", linea.Substring(76, 10))
                scomm.Parameters.AddWithValue("@FechaVencimiento", linea.Substring(87, 10))
                scomm.Parameters.AddWithValue("@PlazoReal", linea.Substring(98, 5))
                scomm.Parameters.AddWithValue("@CuentaContableCapital", linea.Substring(104, 12))
                scomm.Parameters.AddWithValue("@MontoCaptacion", linea.Substring(117, 17))
                scomm.Parameters.AddWithValue("@CuentaContableIntereses", linea.Substring(135, 12))
                scomm.Parameters.AddWithValue("@Intereses", linea.Substring(148, 17))
                scomm.Parameters.AddWithValue("@CuentaContableReajuste", linea.Substring(166, 12))
                scomm.Parameters.AddWithValue("@Reajustes", linea.Substring(179, 19))
                scomm.Parameters.AddWithValue("@MontoFinal", linea.Substring(199, 17))
                scomm.Parameters.AddWithValue("@EstadoOperacion", linea.Substring(217, 1))
                scomm.Parameters.AddWithValue("@SituacionContable", linea.Substring(219, 3))
                scomm.Parameters.AddWithValue("@CodigPlazoContable", linea.Substring(223, 2))
                scomm.Parameters.AddWithValue("@ClaseOperacion", linea.Substring(226, 6))
                scomm.Parameters.AddWithValue("@SaldoInsolutoMonedaOrigen", linea.Substring(233, 17))
                scomm.Parameters.AddWithValue("@SaldoInsolutoPesos", linea.Substring(251, 19))
                scomm.Parameters.AddWithValue("@NumeroRecompras", linea.Substring(271, 3))
                scomm.Parameters.AddWithValue("@FechaUltimaRecompra", linea.Substring(275, 10))
                scomm.Parameters.AddWithValue("@MontoPagoCapital", linea.Substring(286, 19))
                scomm.Parameters.AddWithValue("@MontoPagoIntereses", linea.Substring(306, 19))
                scomm.Parameters.AddWithValue("@MontoPagoReajustes", linea.Substring(326, 19))
                scomm.Parameters.AddWithValue("@CodigoTipoOperacion", linea.Substring(346, 8))
                scomm.Parameters.AddWithValue("@PlazoOperacional", linea.Substring(355, 4))
                scomm.Parameters.AddWithValue("@UnidadPlazoOperacional", linea.Substring(360, 1))
                scomm.Parameters.AddWithValue("@FechaCaptacionOriginal", linea.Substring(362, 10))
                scomm.Parameters.AddWithValue("@NumeroOperacionQueGeneroRenovacion", linea.Substring(373, 12))
                scomm.Parameters.AddWithValue("@NumeroOperacionOriginal", linea.Substring(386, 12))
                scomm.Parameters.AddWithValue("@FechaDevengo", linea.Substring(399, 10))
                scomm.Parameters.AddWithValue("@CodigoTipoTasa", linea.Substring(410, 12))
                scomm.Parameters.AddWithValue("@FechaVencimiento2", linea.Substring(423, 10))
                scomm.Parameters.AddWithValue("@SaldoValorFinal", linea.Substring(434, 19))
                scomm.Parameters.AddWithValue("@ValorCambioCaptacion", linea.Substring(454, 16))
                scomm.Parameters.AddWithValue("@ValorCambioVencimiento", linea.Substring(471, 16))
                scomm.Parameters.AddWithValue("@CompraPropiaUltimaEmision", linea.Substring(488, 16))
                scomm.Parameters.AddWithValue("@CompraPropiaEmisionTotal", linea.Substring(505, 16))
                scomm.Parameters.AddWithValue("@CuentaContableCapital2", linea.Substring(522, 12))
                scomm.Parameters.AddWithValue("@Disponible", i.ToString().PadLeft(50))
                scomm.Parameters.AddWithValue("@MesProceso", MES_PROCESO)
                scomm.ExecuteNonQuery()
            End If
        End While
        scon.Close()
        Debug.Print("Termino Carga de Cartera {0} registros ingresados", i)
    End Sub
    Private Sub EtapaCalculaSaldosPromedios()
        Debug.Print("Inicio Calculo de Saldos Promedio")
        Dim i As Integer = 0
        Dim sFile As String = My.Resources.PATH_APP & "\SaldosPromedio_" & MES_PROCESO & ".csv"
        Dim archivo As FileStream = File.OpenWrite(sFile)
        Dim streamcsv As New StreamWriter(archivo)
        Dim scon As SqlConnection = New SqlConnection(My.Resources.CONECTDB_CARTERA)
        scon.Open()
        Dim scomm As New SqlClient.SqlCommand("SaldosPromedio", scon)
        scomm.CommandType = CommandType.StoredProcedure
        scomm.Parameters.AddWithValue("@MesOperacion", MES_PROCESO)
        Dim dsTotal As DataSet = New DataSet()
        Dim daTotal As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(scomm)
        daTotal.Fill(dsTotal)
        scon.Close()
        For Each row As DataRow In dsTotal.Tables(0).Rows
            i += 1
            FileProgressBar.Value = (i / dsTotal.Tables(0).Rows.Count) * 100
            streamcsv.WriteLine(row("NumeroOperacion").ToString().PadLeft(12) & ";" & row("SaldoPromedio").ToString().PadLeft(20) & ";")
        Next
        FileProgressBar.Value = 100
        streamcsv.Flush()
        streamcsv.Close()
        Debug.Print("Termino Calculo de Saldos Promedio")
    End Sub
#End Region
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
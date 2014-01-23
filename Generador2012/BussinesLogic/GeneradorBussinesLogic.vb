Imports System.IO
Imports System.Drawing
Imports Cimagroup.Generador2012
Imports Cimagroup.Generador2012.AnalizadorLexico
Imports Microsoft.Office.Interop
Namespace Cimagroup.Generador2012.GeneradorBussinesLogic
    Public Class GeneradorBussinesLogic
        Private mFuenteMTX As GeneradorBussinesObject.ArchivoEspecificacion
        Private mRuta As GeneradorBussinesObject.Directorios
        Dim lexemas As Collection = New Collection()
        Dim Struct As EstructurarEspecificacionMtx
        Dim fileGen As ArrayList = New ArrayList()
        Dim msgSalida As GeneradorBussinesObject.EstructuraJSON.EstructuraSalida
        Public Event Iniciado(mensaje As String)
        Public Event Terminado()
        Public WriteOnly Property FuenteMTX As GeneradorBussinesObject.ArchivoEspecificacion
            Set(value As GeneradorBussinesObject.ArchivoEspecificacion)
                mFuenteMTX = value
            End Set
        End Property
        Public Sub New(path As GeneradorBussinesObject.Directorios)
            mRuta = path
        End Sub
        Public Sub Generar()
            '      Debug.Print(mFuenteMTX.Contenido)
            RaiseEvent Terminado()
            LeerMtx()
            RaiseEvent Terminado()
            AnalizarLexemas()
            RaiseEvent Terminado()
            Dim head As String = String.Format("{0}{1}", Struct.Estructura.cabeceramtx.sistema, Struct.Estructura.cabeceramtx.NemotecnicoFile)
            RaiseEvent Iniciado(head & "PD1")
            GenerarPD1()
            RaiseEvent Terminado()
            RaiseEvent Iniciado(head & "PD2")
            GenerarPD2()
            RaiseEvent Terminado()
            RaiseEvent Iniciado(head & "PD3")
            GenerarPD3()
            RaiseEvent Terminado()
            RaiseEvent Iniciado(head & "PD4")
            GenerarPD4()
            RaiseEvent Terminado()
            RaiseEvent Iniciado(head & "PI1")
            GenerarPI1()
            RaiseEvent Terminado()
            RaiseEvent Iniciado(head & "WS1")
            GenerarWS1()
            RaiseEvent Terminado()
            RaiseEvent Iniciado(head & "WS2")
            GenerarWS2()
            RaiseEvent Terminado()
            RaiseEvent Iniciado(head & "WS3")
            GenerarWS3()
            RaiseEvent Terminado()
            RaiseEvent Iniciado(head & "TPG")
            GenerarTPG()
            RaiseEvent Terminado()
            GenerarUnitTest()
            RaiseEvent Terminado()
            GenerarXls()
            RaiseEvent Terminado()
            GenerarSDI()
            RaiseEvent Terminado()
            Print()
            RaiseEvent Terminado()
        End Sub
        Private Sub LeerMtx()
            Debug.Print("HE GENERADO MI PRIMER MTX DECENTEMENTE")
            Dim PalabrasReservadas As New Simbolos()
            Dim c As String = ""
            Dim esComentario As Boolean = False
            Dim esComillas As Boolean = False
            For Each item As String In mFuenteMTX.Contenido
                ' Debug.Print("Item {0}", item)
                If item = "!" Then
                    esComentario = True
                End If
                If esComentario Then
                    If Not item = ";" Then
                        c += item
                    Else
                        'Debug.Print("Comentario '{0}'", c)
                        lexemas.Add(New Simbolo(c.Trim(), TipoSimbolo.mtxComentario))
                        esComentario = False
                        c = ""
                    End If
                ElseIf item = Chr(34) Then
                    'Debug.Print("Son comillas dobles")
                    c += Trim(item)
                    If esComillas Then
                        esComillas = False
                    Else
                        esComillas = True
                    End If
                ElseIf Not (item = ";" Or item = " " Or item = vbCrLf) Then
                    c += Trim(item)
                ElseIf (item = " " Or item = ";") Then
                    If item = " " And esComillas Then
                        c += item
                    ElseIf c.Trim().Length > 0 Then
                        'Debug.Print("Type {0} = '{1}'", PalabrasReservadas.Find(c.Trim()), c.Trim())
                        lexemas.Add(New Simbolo(c.Trim(), PalabrasReservadas.Find(c.Trim())))
                        c = ""
                    End If
                Else
                    Debug.Print("Porque No entro '{0}' a ningun lado???", c.Trim())
                End If
            Next
        End Sub
        Private Sub AnalizarLexemas()
            Struct = New EstructurarEspecificacionMtx(lexemas)
            Struct.AnalisisSintactico()
            Debug.Print("Fin AnalizadorDeLexemas")
        End Sub
        Private Sub Print()
            Dim WriterMX As StreamWriter
            Try
                WriterMX = New StreamWriter(String.Format("{0}ComponenteMX.cbl", mRuta.Log))
            Catch ex As DirectoryNotFoundException
                Directory.CreateDirectory(mRuta.Log)
                WriterMX = New StreamWriter(String.Format("{0}ComponenteMX.cbl", mRuta.Log))
            End Try
            WriterMX.WriteLine("*--------------------------------------------------")
            WriterMX.WriteLine("{0} Archivo Procesado : {1}", Space(3), mFuenteMTX.ArchivoFisico)
            WriterMX.WriteLine("{0} Fecha Proceso : {1}", Space(3), Date.Now)
            WriterMX.WriteLine("{0} Sistema : {1}", Space(3), Struct.Estructura.cabeceraMtx.Sistema)
            WriterMX.WriteLine("{0} Timestamp : {1}", Space(3), Struct.Estructura.cabeceraMtx.Timestamp)
            WriterMX.WriteLine("{0} Largo Header : {1}", Space(3), Struct.Estructura.cabeceraMtx.LargoHeader)
            WriterMX.WriteLine("{0} PI Move : {1}", Space(3), Struct.Estructura.cabeceraMtx.PIMove)
            WriterMX.WriteLine("{0} Byte Atributos : {1}", Space(3), Struct.Estructura.cabeceraMtx.Atributos)
            WriterMX.WriteLine("*--------------------------------------------------")
            Dim WriterLog As StreamWriter
            WriterLog = New StreamWriter(String.Format("{0}Generador2012.log", mRuta.Log))
            WriterLog.WriteLine("*--------------------------------------------------")
            WriterLog.WriteLine("{0} Archivo Procesado : {1}", Space(3), mFuenteMTX.ArchivoFisico)
            WriterLog.WriteLine("{0} Fecha Proceso : {1}", Space(3), Date.Now)
            WriterLog.WriteLine("{0} Cantidad de Lexemas : {1}", Space(3), lexemas.Count)
            WriterLog.WriteLine("*--------------------------------------------------")
            For Each item As Simbolo In lexemas
                If Not item.TipoIdentificador = TipoSimbolo.mtxComentario Then
                    WriterLog.WriteLine("{0} Lexemas - {1} - {2}", Space(3), item.Identificador.ToString, item.TipoIdentificador.ToString)
                End If
            Next
            WriterLog.WriteLine("*--------------------------------------------------")
            WriterLog.Close()
            For Each item As Cimagroup.Generador2012.GeneradorBussinesObject.Form In Struct.Estructura.PantallasFrm
                WriterMX.WriteLine("Pantalla {0} - {1}", item.Host.Nombre, item.Host.Descripcion)
            Next
            WriterMX.WriteLine("*--------------------------------------------------")
            For Each item As Cimagroup.Generador2012.GeneradorBussinesObject.ServiciosRequerimiento In Struct.Estructura.ServiciosReq
                WriterMX.WriteLine("Servicio {0} - {1}", item.Nombre, item.Descripcion)
            Next
            WriterMX.WriteLine("*--------------------------------------------------")
            WriterMX.Close()
            '
            ' Estructura
            '
            Dim WriterWX As StreamWriter
            WriterWX = New StreamWriter(String.Format("{0}EstructuraWX.cbl", mRuta.Log))
            WriterWX.WriteLine("*--------------------------------------------------")
            For Each item As Cimagroup.Generador2012.GeneradorBussinesObject.Form In Struct.Estructura.PantallasFrm
                WriterWX.WriteLine("Pantallas {0} - {1}", item.Host.Nombre, item.Host.Descripcion)
                For Each field As Cimagroup.Generador2012.GeneradorBussinesObject.Campo In item.Host.Campos
                    WriterWX.WriteLine("   Campos {0} - {1}", field.NombreCobol, field.Etiqueta)
                Next
                For Each srv As Cimagroup.Generador2012.GeneradorBussinesObject.Server In item.Server
                    WriterWX.WriteLine("   Server {0}", srv.Nombre)
                    For Each fld In srv.Campos
                        WriterWX.WriteLine("      Campo {0}", fld)
                    Next
                Next
            Next
            WriterWX.WriteLine("*--------------------------------------------------")
            For Each item As Cimagroup.Generador2012.GeneradorBussinesObject.ServiciosRequerimiento In Struct.Estructura.ServiciosReq
                WriterWX.WriteLine("Requerimiento {0} - {1}", item.Nombre, item.Descripcion)
                For Each trans As Cimagroup.Generador2012.GeneradorBussinesObject.Transaccional In item.Transaccional
                    WriterWX.WriteLine("   Comando {0}-{1};{2}", trans.Pantalla, trans.Comando, trans.Instancia)
                Next
                For Each pt As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq In item.PT
                    WriterWX.WriteLine("   PT {0}-{1}", pt.Pantalla, pt.Server)
                Next
                For Each tx As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq In item.TX
                    WriterWX.WriteLine("   TX {0}-{1}", tx.Pantalla, tx.Server)
                Next
                For Each xt As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq In item.XT
                    WriterWX.WriteLine("   XT {0}-{1}", xt.Pantalla, xt.Server)
                Next
                For Each tp As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq In item.TP
                    WriterWX.WriteLine("   TP {0}-{1}", tp.Pantalla, tp.Server)
                Next
            Next
            WriterWX.Close()
        End Sub
        Private Sub GenerarPD1()
            Dim filePD1 As New ModuloPD1()
            filePD1.Cabecera = Struct.Estructura.cabeceraMtx
            filePD1.Servicios = Struct.Estructura.ServiciosReq
            filePD1.Pantallas = Struct.Estructura.PantallasFrm
            filePD1.ArchivoFuente = mFuenteMTX.ArchivoFisico
            filePD1.Ruta = mRuta.Output
            filePD1.Generar()
            fileGen.Add(filePD1.ArchivoGenerado)
        End Sub
        Private Sub GenerarPD2()
            Dim filePD2 As New ModuloPD2()
            filePD2.Cabecera = Struct.Estructura.cabeceraMtx
            filePD2.Servicios = Struct.Estructura.ServiciosReq
            filePD2.Pantallas = Struct.Estructura.PantallasFrm
            filePD2.ArchivoFuente = mFuenteMTX.ArchivoFisico
            filePD2.Ruta = mRuta.Output
            filePD2.Generar()
            fileGen.Add(filePD2.ArchivoGenerado)
        End Sub
        Private Sub GenerarPD3()
            Dim filePD3 As New ModuloPD3()
            filePD3.Cabecera = Struct.Estructura.cabeceraMtx
            filePD3.Servicios = Struct.Estructura.ServiciosReq
            filePD3.Pantallas = Struct.Estructura.PantallasFrm
            filePD3.ArchivoFuente = mFuenteMTX.ArchivoFisico
            filePD3.Ruta = mRuta.Output
            filePD3.Generar()
            fileGen.Add(filePD3.ArchivoGenerado)
        End Sub
        Private Sub GenerarPD4()
            Dim filePD4 As New ModuloPD4()
            filePD4.Cabecera = Struct.Estructura.cabeceraMtx
            filePD4.Servicios = Struct.Estructura.ServiciosReq
            filePD4.Pantallas = Struct.Estructura.PantallasFrm
            filePD4.ArchivoFuente = mFuenteMTX.ArchivoFisico
            filePD4.Ruta = mRuta.Output
            filePD4.Generar()
            fileGen.Add(filePD4.ArchivoGenerado)
        End Sub
        Private Sub GenerarPI1()
            Dim filePI1 As New ModuloPI1()
            filePI1.Cabecera = Struct.Estructura.cabeceraMtx
            filePI1.Servicios = Struct.Estructura.ServiciosReq
            filePI1.Pantallas = Struct.Estructura.PantallasFrm
            filePI1.ArchivoFuente = mFuenteMTX.ArchivoFisico
            filePI1.Ruta = mRuta.Output
            filePI1.Generar()
            fileGen.Add(filePI1.ArchivoGenerado)
        End Sub
        Private Sub GenerarWS1()
            Dim fileWS1 As New ModuloWS1()
            fileWS1.Cabecera = Struct.Estructura.cabeceraMtx
            fileWS1.Servicios = Struct.Estructura.ServiciosReq
            fileWS1.Pantallas = Struct.Estructura.PantallasFrm
            fileWS1.ArchivoFuente = mFuenteMTX.ArchivoFisico
            fileWS1.Ruta = mRuta.Output
            fileWS1.Generar()
            fileGen.Add(fileWS1.ArchivoGenerado)
        End Sub
        Private Sub GenerarWS2()
            Dim fileWS2 As New ModuloWS2()
            fileWS2.Cabecera = Struct.Estructura.cabeceraMtx
            fileWS2.Servicios = Struct.Estructura.ServiciosReq
            fileWS2.Pantallas = Struct.Estructura.PantallasFrm
            fileWS2.ArchivoFuente = mFuenteMTX.ArchivoFisico
            fileWS2.Ruta = mRuta.Output
            fileWS2.Generar()
            fileGen.Add(fileWS2.ArchivoGenerado)
        End Sub
        Private Sub GenerarWS3()
            Dim fileWS3 As New ModuloWS3()
            fileWS3.Cabecera = Struct.Estructura.cabeceraMtx
            fileWS3.Servicios = Struct.Estructura.ServiciosReq
            fileWS3.Pantallas = Struct.Estructura.PantallasFrm
            fileWS3.ArchivoFuente = mFuenteMTX.ArchivoFisico
            fileWS3.Ruta = mRuta.Output
            fileWS3.Generar()
            fileGen.Add(fileWS3.ArchivoGenerado)
        End Sub
        Private Sub GenerarTPG()
            Dim fileTPG As New ModuloTPG()
            fileTPG.Cabecera = Struct.Estructura.cabeceraMtx
            fileTPG.Servicios = Struct.Estructura.ServiciosReq
            fileTPG.Pantallas = Struct.Estructura.PantallasFrm
            fileTPG.ArchivoFuente = mFuenteMTX.ArchivoFisico
            fileTPG.Ruta = mRuta.Output
            fileTPG.Generar()
            fileGen.Add(fileTPG.ArchivoGenerado)
        End Sub
        Private Sub GenerarXls()
            Dim existe As Boolean = False
            Try
                Dim excel As New Excel.Application
                Dim libro As Excel.Workbook
                Dim hoja As Excel.Worksheet
                If File.Exists(mRuta.Doc & "ServiciosCoreBee.xlsx") Then
                    excel.Workbooks.Open(mRuta.Doc & "ServiciosCoreBee.xlsx")
                    libro = excel.ActiveWorkbook
                    existe = True
                Else
                    libro = excel.Workbooks.Add
                End If
                hoja = excel.Worksheets.Add
                Try
                    If Not Directory.Exists(mRuta.Doc) Then
                        Directory.CreateDirectory(mRuta.Doc)
                    End If

                    Dim position As Integer = mFuenteMTX.ArchivoFisico.LastIndexOf("\") + 1
                    hoja.Name = mFuenteMTX.ArchivoFisico.Substring(position, mFuenteMTX.ArchivoFisico.LastIndexOf(".") - position)
                    hoja.Range("B2", "F2").Value = {"Transaccion", "Req", "Servicio", "Comandos", "Metodo Java"}
                    hoja.Range("B2", "F2").Font.Bold = True
                    hoja.Range("B2", "F2").Font.Color = Color.Red
                    hoja.Range("B2", "F2").Interior.Color = Color.Yellow
                    hoja.Range("B2", "F2").Borders.LineStyle = 3

                    Dim iInt As Integer = 2
                    For Each item As Cimagroup.Generador2012.GeneradorBussinesObject.ServiciosRequerimiento In Struct.Estructura.ServiciosReq
                        iInt += 1
                        Dim ma As New Generador2012.GeneradorBussinesLogic.MetodosAuxiliares
                        Dim transaka As String = "G"
                        If Struct.Estructura.cabeceraMTX.PrefijoTrans.ToString() <> transaka Then
                            transaka = Struct.Estructura.cabeceraMTX.sistema.substring(0, 1)
                        End If
                        Debug.Print(transaka & ma.TrimChr(item.Nombre))
                        hoja.Cells(iInt, 2) = transaka & ma.TrimChr(item.Nombre)
                        hoja.Cells(iInt, 3) = item.Nombre
                        hoja.Cells(iInt, 4) = ma.TrimChr(item.Descripcion)
                        hoja.Cells(iInt, 5) = ma.TrimChr(item.PantallaComando)
                        hoja.Cells(iInt, 6) = ma.TrimChr(item.MetodoJava)
                        hoja.UsedRange.BorderAround()
                    Next
                    'libro.Worksheets.Add(hoja)
                    '  excel.Workbooks.Add(libro)
                    If existe Then
                        libro.Save()
                    Else
                        libro.SaveAs(mRuta.Doc & "ServiciosCoreBee.xlsx")
                    End If
                Catch Ex As Exception
                    Debug.Print("ERROR XLS : {0}", Ex.Message)
                Finally
                    libro.Close()
                End Try
            Catch ex As Exception
                Debug.Print("ERROR : {0}", ex.Message)
            End Try
        End Sub
        Private Sub GenerarSDI()
            Dim existe As Boolean = False
            Try
                Dim word As New Word.Application
                Dim documento As Word.Document
                Dim parrafo As Word.Paragraph
                Dim position As Integer = mFuenteMTX.ArchivoFisico.LastIndexOf("\") + 1
                Dim nombre As String = mFuenteMTX.ArchivoFisico.Substring(position, mFuenteMTX.ArchivoFisico.LastIndexOf(".") - position)
                If File.Exists(mRuta.Doc & nombre & " SDIv1.docx") Then
                    word.Documents.Open(mRuta.Doc & nombre & " SDIv1.docx")
                    documento = word.ActiveDocument
                    existe = True
                Else
                    documento = word.Documents.Add
                End If
                Try
                    If Not Directory.Exists(mRuta.Doc) Then
                        Directory.CreateDirectory(mRuta.Doc)
                    End If
                    parrafo = documento.Content.Paragraphs.Add
                    parrafo.Range.Text = "Procedimiento de Implantación"
                    parrafo.Range.Font.Bold = True
                    parrafo.Range.Font.Size = 14
                    parrafo.Range.Font.Name = "Arial"
                    parrafo.Range.InsertParagraphAfter()

                    parrafo = documento.Content.Paragraphs.Add
                    parrafo.Range.Text = "6.1	Componentes Aplicativos"
                    parrafo.Range.Font.Bold = True
                    parrafo.Range.Font.Size = 12
                    parrafo.Range.Font.Name = "Arial"
                    parrafo.Range.InsertParagraphAfter()

                    Dim tabla As Word.Table
                    tabla = documento.Tables.Add(documento.Bookmarks.Item("\endofdoc").Range, 4, 4)
                    tabla.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDashSmallGap
                    tabla.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleThinThickMedGap
                    tabla.Borders.OutsideLineWidth = Microsoft.Office.Interop.Word.WdLineWidth.wdLineWidth050pt

                    tabla.Range.ParagraphFormat.SpaceAfter = 6
                    tabla.Rows.Item(1).Range.Font.Bold = True
                    tabla.Rows.Item(1).Range.Font.Name = "Arial"
                    tabla.Rows.Item(1).Range.Font.Size = 10

                    tabla.Cell(1, 1).Range.Text = "Package"
                    tabla.Cell(1, 2).Range.Text = "Plataforma / Ubicación"
                    tabla.Cell(1, 3).Range.Text = "Destino"
                    tabla.Cell(1, 4).Range.Text = "Tipo"

                    tabla.Rows.Item(2).Range.Font.Bold = False
                    tabla.Rows.Item(2).Range.Font.Name = "Arial"
                    tabla.Rows.Item(2).Range.Font.Size = 10
                    tabla.Range.ParagraphFormat.SpaceAfter = 1
                    tabla.Cell(2, 1).Range.Text = nombre
                    tabla.Cell(2, 2).Range.Text = "CCTSF.PASO"
                    tabla.Cell(2, 3).Range.Text = "Endevor Prod"
                    Dim prog As String = "GNSPPTPG"
                    For Each item As String In fileGen
                        If Not item.Contains("TPG") Then
                            tabla.Cell(2, 4).Range.Text += item & " (Copy)" & vbCrLf
                        Else
                            prog = item
                        End If
                    Next

                    tabla.Rows.Item(3).Range.Font.Bold = False
                    tabla.Rows.Item(3).Range.Font.Name = "Arial"
                    tabla.Rows.Item(3).Range.Font.Size = 10
                    tabla.Range.ParagraphFormat.SpaceAfter = 1
                    tabla.Cell(3, 1).Range.Text = nombre
                    tabla.Cell(3, 2).Range.Text = "CCTSF.PASO"
                    tabla.Cell(3, 3).Range.Text = "Endevor Prod"
                    tabla.Cell(3, 4).Range.Text = prog & " (On-Line)"
                    tabla.Range.InsertParagraphAfter()
                    parrafo.Range.InsertParagraphBefore()

                    If existe Then
                        documento.Save()
                    Else
                        documento.SaveAs(mRuta.Doc & nombre & " SDIv1.docx")
                    End If
                Finally
                    documento.Close()
                End Try
            Catch ex As Exception
                Debug.Print("ERROR : {0}", ex.Message)
            End Try
        End Sub
        Private Sub GenerarUnitTest()
            Dim cblUnitTest As New GeneradorModulosPruebas.GeneradorModulosPruebasPrex
            cblUnitTest.Cabecera = Struct.Estructura.cabeceraMtx
            cblUnitTest.Servicios = Struct.Estructura.ServiciosReq
            cblUnitTest.Pantallas = Struct.Estructura.PantallasFrm
            cblUnitTest.ArchivoFuente = mFuenteMTX.ArchivoFisico
            cblUnitTest.Ruta = mRuta.Output
            cblUnitTest.Generar()
        End Sub
    End Class
End Namespace
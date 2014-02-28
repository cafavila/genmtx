Imports System.IO
Imports System.Text
Imports System
Imports Cimagroup.Generador2012
Imports Cimagroup.Generador2012.AnalizadorLexico
Imports Cimagroup.Generador2012.GeneradorBussinesObject
Namespace Cimagroup.Generador2012.GeneradorModulosPruebas
    Public Class GeneradorSalidaTest
        Inherits Cimagroup.Generador2012.GeneradorBussinesLogic.ModulosBase
        Private texto As Collection
        Private mWriteLine As Collection = New Collection()
        Private mService As EstructuraJSON.EstructuraSalida
        Private mSist As String
        Private mNemo As String
        Public Overrides Sub Generar()
            archivo = String.Format("{0}{1}TEST_Salida", mSist, mNemo)
            'Header = New HeaderModulosTESTSalida(mCabecera.Tag, mCabecera.Timestamp, mArchivoFuente)
            Dim WriterMX As StreamWriter
            WriterMX = New StreamWriter(String.Format("{1}{0}.txt", archivo, mRuta))
            mStreamWrite = New Collection()
            mStreamWrite = Contextualizar()

            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            WriterMX.Close()
        End Sub
        Public Sub New(service As EstructuraJSON.EstructuraSalida, sistema As String, nemonico As String, ruta As String)
            mService = service
            mSist = sistema
            mNemo = nemonico
            mRuta = ruta
            texto = New Collection()
            Generar()
        End Sub
        Private Function Contextualizar() As Microsoft.VisualBasic.Collection
            SerializaJSON()
            For Each line As String In texto
                WriteLine(line)
            Next
            Return mWriteLine
        End Function
        Private Sub WriteLine(linea As String)
            mWriteLine.Add(linea)
        End Sub
        Private Sub SerializaJSON()
            For Each srvOut In mService.MensajeSalida
                texto.Add("[")
                For Each srv As EstructuraJSON.ServiceMessage In srvOut
                    texto.Add("  {")
                    texto.Add(String.Format("{1}'servicio':'{0}',", srv.Servicio, Space(4)))
                    texto.Add(String.Format("{1}'descripcion':'{0}',", srv.Descripcion, Space(4)))
                    texto.Add(String.Format("{1}'tuxedo':'{0}',", srv.ServicioTuxedo, Space(4)))
                    Dim bSND As Boolean = False
                    If Not srv.Data Is Nothing Then
                        texto.Add("    'wss-snd':{")
                        bSND = True
                    End If
                    For Each obj As Object In srv.Data
                        If TypeOf obj Is EstructuraJSON.Campos Then
                            Dim data As EstructuraJSON.Campos = obj
                            texto.Add("            {")
                            texto.Add(String.Format("{1}'campo_cobol':'{0}',", data.NombreCobol, Space(12)))
                            texto.Add(String.Format("{1}'campo_tux':'{0}',", data.nombreTux, Space(12)))
                            texto.Add(String.Format("{1}'campo_java':'{0}',", data.NombreJava, Space(12)))
                            texto.Add(String.Format("{1}'etiqueta':'{0}',", data.Etiqueta, Space(12)))
                            texto.Add(String.Format("{1}'largo':'{0}',", data.Largo.ToString("000"), Space(12)))
                            texto.Add(String.Format("{1}'valor':'{0}',", Space(data.Largo), Space(12)))
                            texto.Add("            },")
                        End If
                        If TypeOf obj Is EstructuraJSON.DataOccs Then
                            For Each occ As Object In obj
                                Dim data As EstructuraJSON.Campos = occ
                                texto.Add("            {")
                                texto.Add(String.Format("{1}'campo_cobol':'{0}',", data.NombreCobol, Space(16)))
                                texto.Add(String.Format("{1}'campo_tux':'{0}',", data.nombreTux, Space(16)))
                                texto.Add(String.Format("{1}'campo_java':'{0}',", data.NombreJava, Space(16)))
                                texto.Add(String.Format("{1}'etiqueta':'{0}',", data.Etiqueta, Space(16)))
                                texto.Add(String.Format("{1}'largo':'{0}',", data.Largo.ToString("000"), Space(16)))
                                texto.Add(String.Format("{1}'valor':'{0}',", Space(data.Largo), Space(16)))
                                texto.Add("            },")
                            Next
                        End If
                    Next
                    If bSND Then
                        texto.Add("              }")
                    End If
                Next
                texto.Add("},")
            Next
            texto.Add("]")
        End Sub
    End Class
End Namespace

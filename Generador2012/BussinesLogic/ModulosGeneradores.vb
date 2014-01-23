Imports System.IO
Imports Cimagroup.Generador2012
Imports Cimagroup.Generador2012.AnalizadorLexico
Imports Cimagroup.Generador2012.GeneradorBussinesObject
Namespace Cimagroup.Generador2012.GeneradorBussinesLogic
    Public Class ModuloPD1
        Inherits ModulosBase
        Public Overrides Sub Generar()
            archivo = String.Format("{0}{1}PD1", mCabecera.Sistema, mCabecera.NemotecnicoFile)
            Header = New HeaderModulosPD(mCabecera.Tag, mCabecera.Timestamp, mArchivoFuente)
            ModeloModulo = New ModeloModulosPD1(mServicios, mPantallas)
            Dim WriterMX As StreamWriter
            WriterMX = New StreamWriter(String.Format("{1}{0}.cbl", archivo, mRuta))
            mStreamWrite = Header.GeneradorHeader(archivo)
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            mStreamWrite = New Collection()
            mStreamWrite = ModeloModulo.Contextualizar()
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            WriterMX.Close()
        End Sub
    End Class
    Public Class ModuloPD2
        Inherits ModulosBase
        Public Overrides Sub Generar()
            archivo = String.Format("{0}{1}PD2", mCabecera.Sistema, mCabecera.NemotecnicoFile)
            Header = New HeaderModulosPD(mCabecera.Tag, mCabecera.Timestamp, mArchivoFuente)
            ModeloModulo = New ModeloModulosPD2(mServicios, mPantallas, mCabecera.Atributos)
            Dim WriterMX As StreamWriter
            WriterMX = New StreamWriter(String.Format("{1}{0}.cbl", archivo, mRuta))
            mStreamWrite = Header.GeneradorHeader(archivo)
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            mStreamWrite = New Collection()
            mStreamWrite = ModeloModulo.Contextualizar()
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            WriterMX.Close()
        End Sub
    End Class
    Public Class ModuloPD3
        Inherits ModulosBase
        Public Overrides Sub Generar()
            archivo = String.Format("{0}{1}PD3", mCabecera.Sistema, mCabecera.NemotecnicoFile)
            Header = New HeaderModulosPD(mCabecera.Tag, mCabecera.Timestamp, mArchivoFuente)
            ModeloModulo = New ModeloModulosPD3(mServicios)
            Dim WriterMX As StreamWriter
            WriterMX = New StreamWriter(String.Format("{1}{0}.cbl", archivo, mRuta))
            mStreamWrite = Header.GeneradorHeader(archivo)
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            mStreamWrite = New Collection()
            mStreamWrite = ModeloModulo.Contextualizar()
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            WriterMX.Close()
        End Sub
    End Class
    Public Class ModuloPD4
        Inherits ModulosBase
        Public Overrides Sub Generar()
            archivo = String.Format("{0}{1}PD4", mCabecera.Sistema, mCabecera.NemotecnicoFile)
            Header = New HeaderModulosPD(mCabecera.Tag, mCabecera.Timestamp, mArchivoFuente)
            ModeloModulo = New ModeloModulosPD4(mServicios, mPantallas, mCabecera.ValidacionNumerica)
            Dim WriterMX As StreamWriter
            WriterMX = New StreamWriter(String.Format("{1}{0}.cbl", archivo, mRuta))
            mStreamWrite = Header.GeneradorHeader(archivo)
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            mStreamWrite = New Collection()
            mStreamWrite = ModeloModulo.Contextualizar()
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            WriterMX.Close()
        End Sub
    End Class
    Public Class ModuloPI1
        Inherits ModulosBase
        Public Overrides Sub Generar()
            archivo = String.Format("{0}{1}PI1", mCabecera.Sistema, mCabecera.NemotecnicoFile)
            Header = New HeaderModulosPI(mCabecera.Tag, mCabecera.Sistema, mArchivoFuente)
            ModeloModulo = New ModeloModulosPI1(mServicios, mPantallas, mCabecera.Timestamp, mCabecera.Sistema)
            Dim WriterMX As StreamWriter
            WriterMX = New StreamWriter(String.Format("{1}{0}.cbl", archivo, mRuta))
            mStreamWrite = Header.GeneradorHeader(archivo)
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            mStreamWrite = New Collection()
            mStreamWrite = ModeloModulo.Contextualizar()
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            WriterMX.Close()
        End Sub
    End Class
    Public Class ModuloWS1
        Inherits ModulosBase
        Public Overrides Sub Generar()
            archivo = String.Format("{0}{1}WS1", mCabecera.Sistema, mCabecera.NemotecnicoFile)
            Dim bPrimero As String = mCabecera.IndicadorPrimerArchivo
            Header = New HeaderModulosWS(mCabecera.Tag, mCabecera.Timestamp, mArchivoFuente, bPrimero)
            ModeloModulo = New ModeloModulosWS1(mServicios, mPantallas, mCabecera)
            Dim WriterMX As StreamWriter
            WriterMX = New StreamWriter(String.Format("{1}{0}.cbl", archivo, mRuta))
            mStreamWrite = Header.GeneradorHeader(archivo)
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            mStreamWrite = New Collection()
            mStreamWrite = ModeloModulo.Contextualizar()
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            WriterMX.Close()
        End Sub
    End Class
    Public Class ModuloWS2
        Inherits ModulosBase
        Public Overrides Sub Generar()
            archivo = String.Format("{0}{1}WS2", mCabecera.Sistema, mCabecera.NemotecnicoFile)
            Dim bPrimero As String = mCabecera.IndicadorPrimerArchivo
            Header = New HeaderModulosWS(mCabecera.Tag, mCabecera.Timestamp, mArchivoFuente, bPrimero)
            ModeloModulo = New ModeloModulosWS2(mServicios, mPantallas, mCabecera)
            Dim WriterMX As StreamWriter
            WriterMX = New StreamWriter(String.Format("{1}{0}.cbl", archivo, mRuta))
            mStreamWrite = Header.GeneradorHeader(archivo)
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            mStreamWrite = New Collection()
            mStreamWrite = ModeloModulo.Contextualizar()
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            WriterMX.Close()
        End Sub
    End Class
    Public Class ModuloWS3
        Inherits ModulosBase
        Public Overrides Sub Generar()
            archivo = String.Format("{0}{1}WS3", mCabecera.Sistema, mCabecera.NemotecnicoFile)
            Header = New HeaderModulosWS(mCabecera.Tag, mCabecera.Timestamp, mArchivoFuente, "S")
            ModeloModulo = New ModeloModulosWS3(mServicios, mPantallas, mCabecera)
            Dim WriterMX As StreamWriter
            WriterMX = New StreamWriter(String.Format("{1}{0}.cbl", archivo, mRuta))
            mStreamWrite = Header.GeneradorHeader(archivo)
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            mStreamWrite = New Collection()
            mStreamWrite = ModeloModulo.Contextualizar()
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            WriterMX.Close()
        End Sub
    End Class
    Public Class ModuloTPG
        Inherits ModulosBase
        Public Overrides Sub Generar()
            archivo = String.Format("{0}PPTPG", mCabecera.Sistema)
            ModeloModulo = New ModeloModuloTPG(mServicios, mPantallas, mCabecera, archivo)
            Dim WriterMX As StreamWriter
            WriterMX = New StreamWriter(String.Format("{1}{0}.cbl", archivo, mRuta))
            mStreamWrite = ModeloModulo.Contextualizar()
            For Each linea As String In mStreamWrite
                WriterMX.WriteLine(linea)
            Next
            WriterMX.Close()
        End Sub
    End Class
#Region "Definiciones Abstractas"
    Structure RPFField
        Public pant As String
        Public prg As String
        Public sprg As String
        Public inm As String
        Public comm As String
        Public cpp As String
        Public spp As Char
        Public cnf As String
        Public comenta As String
        Public idd As String
    End Structure
    Public Interface IHeader
        Function GeneradorHeader(archivo As String) As Collection
    End Interface
    Public Interface IModulos
        Function Contextualizar() As Collection
    End Interface
    Public Class HeaderModulosPD
        Implements IHeader
        Private mLinea As String
        Private mWriteLine As Collection = New Collection()
        Private mTag As String
        Private mTimestamp As String
        Private mFilesource As String
        Public ReadOnly Property LineaWrite As Collection
            Get
                Return mWriteLine
            End Get
        End Property
        Public WriteOnly Property Tag As String
            Set(value As String)
                mTag = value
            End Set
        End Property
        Public Sub New(tag As String, timestamp As String, archivofuente As String)
            Dim metodos As New MetodosAuxiliares()
            mWriteLine = New Collection()
            mTag = metodos.TrimChr(tag)
            mTimestamp = timestamp
            mFilesource = archivofuente
        End Sub
        Private Sub WriteLine(linea As String)
            mWriteLine.Add(linea)
        End Sub
        Private Sub WriteLine()
            mWriteLine.Add("")
        End Sub
        Public Function GeneradorHeader(archivo As String) As Collection Implements IHeader.GeneradorHeader
            WriteLine(String.Format("{0}*{1}{2}, PAI=, CLI=, SOP=MVS", Space(6), Space(4), Date.Now.ToLocalTime))
            WriteLine(String.Format("{0}*{1}{2}", Space(6), Space(4), mFilesource))
            WriteLine(String.Format("{0}*{1}USUARIO = {2}", Space(6), Space(4), Environment.UserName))
            WriteLine(String.Format("{0}*", Space(6)))
            WriteLine(String.Format("{0}*{1}{2}.cbl GENMTX : Version {3}", Space(6), Space(4), archivo, Environment.Version))
            WriteLine(String.Format("{0}*", Space(6)))
            WriteLine(String.Format("{0}SET-TAG-{1} SECTION.", Space(7), archivo))
            WriteLine(String.Format("{0}INI-SET-TAG-{1}.", Space(7), archivo))
            WriteLine(String.Format("{0}MOVE", Space(11)))
            WriteLine(String.Format("{0}'<IDNMOD NOM=${1}$ VSN=${2}$ GEN=${3}", Space(11), archivo, Environment.Version, Date.Now.ToShortDateString))
            WriteLine(String.Format("{0}-{1}'TMS=${2}$ FNC=${3}$/>'", Space(6), Space(4), mTimestamp.Substring(1, mTimestamp.Length - 2), mTag))
            WriteLine(String.Format("{0}TO WSS-CVT-ITEM.", Space(11)))
            WriteLine(String.Format("{0}FIN-SET-TAG-{1}.", Space(7), archivo))
            WriteLine(String.Format("{0}EXIT.", Space(11)))
            WriteLine()
            Return mWriteLine
        End Function
    End Class
    Public Class HeaderModulosPI
        Implements IHeader
        Private mLinea As String
        Private mWriteLine As Collection = New Collection()
        Private mTag As String
        Private mSistema As String
        Private mFilesource As String
        Public ReadOnly Property LineaWrite As Collection
            Get
                Return mWriteLine
            End Get
        End Property
        Public WriteOnly Property Tag As String
            Set(value As String)
                mTag = value
            End Set
        End Property
        Public Sub New(tag As String, sistem As String, archivofuente As String)
            Dim metodos As New MetodosAuxiliares()
            mWriteLine = New Collection()
            mTag = metodos.TrimChr(tag)
            mSistema = sistem
            mFilesource = archivofuente
        End Sub
        Private Sub WriteLine(linea As String)
            mWriteLine.Add(linea)
        End Sub
        Private Sub WriteLine()
            mWriteLine.Add("")
        End Sub
        Public Function GeneradorHeader(archivo As String) As Collection Implements IHeader.GeneradorHeader
            WriteLine(String.Format("{0}*{1}{2}, PAI=, CLI=, SOP=MVS", Space(6), Space(4), Date.Now.ToLocalTime))
            WriteLine(String.Format("{0}*{1}{2}", Space(6), Space(4), mFilesource))
            WriteLine(String.Format("{0}*{1}USUARIO = {2}", Space(6), Space(4), Environment.UserName))
            WriteLine(String.Format("{0}*", Space(6)))
            WriteLine(String.Format("{0}*{1}{2}.CBL GENMTX : Version 3.0.0 Updated 18-ABR-2012", Space(6), Space(4), archivo))
            WriteLine(String.Format("{0}*", Space(6)))
            WriteLine(String.Format("{0}*{1}TAG = {2}", Space(6), Space(4), mTag))
            WriteLine(String.Format("{0}*", Space(6)))
            WriteLine(String.Format("{0}*{1}SIS = {2}", Space(6), Space(4), mSistema))
            WriteLine(String.Format("{0}*{1}OPC = C", Space(6), Space(4)))
            WriteLine(String.Format("{0}*{1}SI OPC = C ==> CARGA DE PARAMETROS", Space(6), Space(4)))
            WriteLine(String.Format("{0}*{1}SI OPC = D ==> DESCARGA DE PARAMETROS", Space(6), Space(4)))
            Return mWriteLine
        End Function
    End Class
    Public Class HeaderModulosWS
        Implements IHeader
        Private mLinea As String
        Private mWriteLine As Collection = New Collection()
        Private mTag As String
        Private mTimestamp As String
        Private mFilesource As String
        Private mIndicador As Char
        Public ReadOnly Property LineaWrite As Collection
            Get
                Return mWriteLine
            End Get
        End Property
        Public WriteOnly Property Tag As String
            Set(value As String)
                mTag = value
            End Set
        End Property
        Public Sub New(tag As String, timestamp As String, archivofuente As String, indicador As String)
            Dim metodos As New MetodosAuxiliares()
            mWriteLine = New Collection()
            mTag = metodos.TrimChr(tag)
            mTimestamp = timestamp
            mFilesource = archivofuente
            mIndicador = metodos.TrimChr(indicador)
        End Sub
        Private Sub WriteLine(linea As String)
            mWriteLine.Add(linea)
        End Sub
        Private Sub WriteLine()
            mWriteLine.Add("")
        End Sub
        Public Function GeneradorHeader(archivo As String) As Collection Implements IHeader.GeneradorHeader
            WriteLine(String.Format("{0}*{1}{2}, PAI=, CLI=, SOP=MVS", Space(6), Space(4), Date.Now.ToLocalTime))
            WriteLine(String.Format("{0}*{1}{2}", Space(6), Space(4), mFilesource))
            WriteLine(String.Format("{0}*{1}USUARIO = {2}", Space(6), Space(4), Environment.UserName))
            WriteLine(String.Format("{0}*", Space(6)))
            WriteLine(String.Format("{0}*{1}{2}.cbl GENMTX : Version {3}", Space(6), Space(4), archivo, Environment.Version))
            WriteLine(String.Format("{0}*", Space(6)))
            If mIndicador = "N" Then
                WriteLine(String.Format("{0}*77 WSS-TAG-{1}{2}PIC X(125) VALUE", Space(6), archivo, Space(23)))
                WriteLine(String.Format("{0}*'<IDNMOD NOM=${1}$ VSN=${2}$ GEN=${3}", Space(6), archivo, Environment.Version, Date.Now.ToShortDateString))
                WriteLine(String.Format("{0}*-{1}'TMS=${2}$ FNC=${3}$/>'.", Space(6), Space(4), mTimestamp.Substring(1, mTimestamp.Length - 2), mTag))
                WriteLine(String.Format("{0}*", Space(6)))
            Else
                WriteLine(String.Format("{0}77 WSS-TAG-{1}{2}PIC X(125) VALUE", Space(7), archivo, Space(23)))
                WriteLine(String.Format("{0}'<IDNMOD NOM=${1}$ VSN=${2}$ GEN=${3}", Space(11), archivo, Environment.Version, Date.Now.ToShortDateString))
                WriteLine(String.Format("{0}-{1}'TMS=${2}$ FNC=${3}$/>'.", Space(6), Space(4), mTimestamp.Substring(1, mTimestamp.Length - 2), mTag))
                WriteLine()
            End If
            Return mWriteLine
        End Function
    End Class
    Public Class ModeloModulosPD1
        Implements IModulos
        Private mLinea As String
        Private mWriteLine As Collection = New Collection()
        Private mServicios As Collection
        Private mPantallas As Collection
        Public ReadOnly Property LineaWrite As Collection
            Get
                Return mWriteLine
            End Get
        End Property
        Public Sub New(service As Collection, form As Collection)
            mWriteLine = New Collection()
            mServicios = service
            mPantallas = form
        End Sub
        Private Sub WriteLine(linea As String)
            mWriteLine.Add(linea)
        End Sub
        Private Sub WriteLine()
            mWriteLine.Add("")
        End Sub
        Public Function Contextualizar() As Microsoft.VisualBasic.Collection Implements IModulos.Contextualizar
            Dim metodos As New MetodosAuxiliares
            For Each item As ServiciosRequerimiento In mServicios
                Dim name As String = metodos.TrimChr(item.Nombre)
                Dim int As Integer = 1
                While item.PT.Count >= int
                    Dim pantPT As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq = item.PT(int)
                    Dim fieldPT As New ArrayList()
                    fieldPT = metodos.getCamposForEdition(pantPT.Pantalla, pantPT.Server, mPantallas)
                    If item.TX.Count >= int Then
                        Dim pantTX As StructureReq = item.TX(int)
                        Dim fieldTX As New ArrayList()
                        fieldTX = metodos.getCamposForEdition(pantTX.Pantalla, pantTX.Server, mPantallas)
                        Dim j As Integer = 0
                        WriteLine(String.Format("{0}MOV-PT-TX-{1}-{2} SECTION.", Space(7), name, int.ToString("00")))
                        WriteLine(String.Format("{0}INI-MOV-PT-TX-{1}-{2}.", Space(7), name, int.ToString("00")))
                        If Not (fieldPT Is Nothing Or fieldTX Is Nothing) Then
                            While j < fieldPT.Count And j < fieldTX.Count
                                If fieldPT(j).indice > 0 Or fieldTX(j).indice > 0 Or pantPT.Index > 0 Or pantTX.Index > 0 Then
                                    Dim strPt As String = fieldPT(j).NombreCobol
                                    Dim strTx As String = fieldTX(j).NombreCobol
                                    Dim mLineaFinal As String
                                    If (fieldTX(j).indice > 0 And fieldPT(j).indice > 0) Then
                                        WriteLine(String.Format("{0}MOVE 1 TO TPG-L.", Space(11)))
                                        WriteLine(String.Format("{0}LUP-PT-{1}-{2}-{3}.", Space(7), name, int.ToString("00"), strPt))
                                        WriteLine(String.Format("{0}MOVE PT-{1}-{2}-{3}(TPG-L) TO", Space(11), name, int.ToString("00"), strPt))
                                        WriteLine(String.Format("{0}TX-{1}-{2}-{3}(TPG-L).", Space(16), name, int.ToString("00"), strTx))
                                        WriteLine(String.Format("{0}ADD 1 TO TPG-L.", Space(11)))
                                        WriteLine(String.Format("{0}IF TPG-L < {1}", Space(11), fieldPT(j).indice + 1))
                                        WriteLine(String.Format("{0}GO TO LUP-PT-{1}-{2}-{3}.", Space(14), name, int.ToString("00"), strPt))
                                    Else
                                        If fieldPT(j).indice > 0 Or pantPT.Index > 0 Then
                                            strPt += "(TPG-I)"
                                        End If
                                        If (fieldTX(j).indice > 0 Or pantTX.Index > 0) Then
                                            strTx += "(TPG-I)"
                                        End If
                                        mLineaFinal = String.Format("{0}MOVE PT-{1}-{2}-{3} TO TX-{1}-{2}-{4}.", Space(11), name, int.ToString("00"), strPt, strTx)
                                        If mLineaFinal.Length > 72 Then
                                            WriteLine(String.Format("{0}MOVE PT-{1}-{2}-{3} TO", Space(11), name, int.ToString("00"), strPt))
                                            WriteLine(String.Format("{0}TX-{1}-{2}-{3}.", Space(16), name, int.ToString("00"), strTx))
                                        Else
                                            WriteLine(mLineaFinal)
                                        End If
                                    End If
                                Else
                                    WriteLine(String.Format("{0}MOVE PT-{1}-{2}-{3} TO TX-{1}-{2}-{4}.", Space(11), name, int.ToString("00"), fieldPT(j).NombreCobol, fieldTX(j).NombreCobol))
                                End If
                                j += 1
                            End While
                        End If
                        WriteLine(String.Format("{0}FIN-MOV-PT-TX-{1}-{2}.", Space(7), name, int.ToString("00")))
                        WriteLine(String.Format("{0}EXIT.", Space(11)))
                        WriteLine()
                    End If
                    int += 1
                End While
            Next
            Return mWriteLine
        End Function
    End Class
    Public Class ModeloModulosPD2
        Implements IModulos
        Private mLinea As String
        Private mAtributos As Boolean
        Private mWriteLine As Collection = New Collection()
        Private mServicios As Collection
        Private mPantallas As Collection
        Public ReadOnly Property LineaWrite As Collection
            Get
                Return mWriteLine
            End Get
        End Property
        Public Sub New(service As Collection, form As Collection, atributos As Boolean)
            mWriteLine = New Collection()
            mServicios = service
            mPantallas = form
            mAtributos = atributos
        End Sub
        Private Sub WriteLine(linea As String)
            mWriteLine.Add(linea)
        End Sub
        Private Sub WriteLine()
            mWriteLine.Add("")
        End Sub
        Public Function Contextualizar() As Microsoft.VisualBasic.Collection Implements IModulos.Contextualizar
            Dim metodos As New MetodosAuxiliares
            For Each item As ServiciosRequerimiento In mServicios
                Dim name As String = metodos.TrimChr(item.Nombre)
                Dim int As Integer = 1
                While item.XT.Count >= int
                    Dim pantXT As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq = item.XT(int)
                    Dim fieldXT As New ArrayList()
                    fieldXT = metodos.getCamposForEdition(pantXT.Pantalla, pantXT.Server, mPantallas)
                    If item.TP.Count >= int Then
                        Dim pantTP As StructureReq = item.TP(int)
                        Dim fieldTP As New ArrayList()
                        fieldTP = metodos.getCamposForEdition(pantTP.Pantalla, pantTP.Server, mPantallas)
                        Dim j As Integer = 0
                        WriteLine(String.Format("{0}MOV-XT-TP-{1}-{2} SECTION.", Space(7), name, int.ToString("00")))
                        WriteLine(String.Format("{0}INI-MOV-XT-TP-{1}-{2}.", Space(7), name, int.ToString("00")))
                        If Not (fieldTP Is Nothing Or fieldXT Is Nothing) Then
                            While j < fieldXT.Count And j < fieldTP.Count
                                If fieldXT(j).indice > 0 Or fieldTP(j).indice > 0 Or pantXT.Index > 0 Or pantTP.Index > 0 Then
                                    Dim strXt As String = fieldXT(j).NombreCobol
                                    Dim strTp As String = fieldTP(j).NombreCobol
                                    If (fieldXT(j).indice > 0 And fieldTP(j).indice > 0) And (pantXT.Index > 0 And pantTP.Index > 0) Then
                                        strTp += "(TPG-I, TPG-L)"
                                        strXt += "(TPG-I, TPG-L)"
                                        WriteLine(String.Format("{0}MOVE 1 TO TPG-L.", Space(11)))
                                        WriteLine(String.Format("{0}LUP-TP-{1}-{2}-{3}.", Space(7), name, int.ToString("00"), fieldTP(j).NombreCobol))
                                        If mAtributos Or item.Atributos Then
                                            WriteLine(String.Format("{0}MOVE XT-{1}-{2}-{3}-ATR(TPG-I, TPG-L) TO", Space(11), name, int.ToString("00"), fieldTP(j).NombreCobol))
                                            WriteLine(String.Format("{0}TP-{1}-{2}-{3}-ATR(TPG-I, TPG-L).", Space(16), name, int.ToString("00"), fieldXT(j).NombreCobol))
                                        End If
                                        WriteLine(String.Format("{0}MOVE XT-{1}-{2}-{3} TO", Space(11), name, int.ToString("00"), strTp))
                                        WriteLine(String.Format("{0}TP-{1}-{2}-{3}.", Space(16), name, int.ToString("00"), strXt))
                                        WriteLine(String.Format("{0}ADD 1 TO TPG-L.", Space(11)))
                                        WriteLine(String.Format("{0}IF TPG-L < {1}", Space(11), fieldTP(j).indice + 1))
                                        WriteLine(String.Format("{0}GO TO LUP-TP-{1}-{2}-{3}.", Space(14), name, int.ToString("00"), fieldTP(j).NombreCobol))
                                    ElseIf (fieldXT(j).indice > 0 Or fieldTP(j).indice > 0) Then
                                        WriteLine(String.Format("{0}MOVE 1 TO TPG-L.", Space(11)))
                                        WriteLine(String.Format("{0}LUP-TP-{1}-{2}-{3}.", Space(7), name, int.ToString("00"), strTp))
                                        If mAtributos Or item.Atributos Then
                                            WriteLine(String.Format("{0}MOVE XT-{1}-{2}-{3}-ATR(TPG-L) TO", Space(11), name, int.ToString("00"), fieldXT(j).NombreCobol))
                                            WriteLine(String.Format("{0}TP-{1}-{2}-{3}-ATR(TPG-L).", Space(16), name, int.ToString("00"), fieldXT(j).NombreCobol))
                                        End If
                                        WriteLine(String.Format("{0}MOVE XT-{1}-{2}-{3}(TPG-L) TO", Space(11), name, int.ToString("00"), strTp))
                                        WriteLine(String.Format("{0}TP-{1}-{2}-{3}(TPG-L).", Space(16), name, int.ToString("00"), strXt))
                                        WriteLine(String.Format("{0}ADD 1 TO TPG-L.", Space(11)))
                                        WriteLine(String.Format("{0}IF TPG-L < {1}", Space(11), fieldTP(j).indice + 1))
                                        WriteLine(String.Format("{0}GO TO LUP-TP-{1}-{2}-{3}.", Space(14), name, int.ToString("00"), strTp))
                                    Else
                                        If fieldXT(j).indice > 0 Or pantXT.Index > 0 Then
                                            strXt += "(TPG-I)"
                                        End If
                                        If fieldTP(j).indice > 0 Or pantTP.Index > 0 Then
                                            strTp += "(TPG-I)"
                                        End If
                                        If mAtributos Or item.Atributos Then
                                            Dim sIndex As String = ""
                                            If pantXT.Index > 0 Then
                                                sIndex = "(TPG-I)"
                                            End If
                                            WriteLine(String.Format("{0}MOVE XT-{1}-{2}-{3}-ATR{4} TO", Space(11), name, int.ToString("00"), fieldXT(j).NombreCobol, sIndex))
                                            If pantTP.Index > 0 Then
                                                sIndex = "(TPG-I)"
                                            Else
                                                sIndex = ""
                                            End If
                                            WriteLine(String.Format("{0}TP-{1}-{2}-{3}-ATR{4}.", Space(16), name, int.ToString("00"), fieldXT(j).NombreCobol, sIndex))
                                        End If
                                        Dim mLineaFinal As String
                                        mLineaFinal = String.Format("{0}MOVE XT-{1}-{2}-{3} TO TP-{1}-{2}-{4}.", Space(11), name, int.ToString("00"), strXt, strTp)
                                        If mLineaFinal.Length > 72 Then
                                            WriteLine(String.Format("{0}MOVE XT-{1}-{2}-{3} TO", Space(11), name, int.ToString("00"), strXt))
                                            WriteLine(String.Format("{0}TP-{1}-{2}-{3}.", Space(16), name, int.ToString("00"), strTp))
                                        Else
                                            WriteLine(mLineaFinal)
                                        End If
                                    End If
                                Else
                                    If mAtributos Or item.Atributos Then
                                        WriteLine(String.Format("{0}MOVE XT-{1}-{2}-{3}-ATR TO", Space(11), name, int.ToString("00"), fieldXT(j).NombreCobol, fieldTP(j).NombreCobol))
                                        WriteLine(String.Format("{0}TP-{1}-{2}-{4}-ATR.", Space(16), name, int.ToString("00"), fieldXT(j).NombreCobol, fieldTP(j).NombreCobol))
                                    End If
                                    Dim mLineaFinal As String
                                    mLineaFinal = String.Format("{0}MOVE XT-{1}-{2}-{3} TO TP-{1}-{2}-{4}.", Space(11), name, int.ToString("00"), fieldXT(j).NombreCobol, fieldTP(j).NombreCobol)
                                    If mLineaFinal.Length > 72 Then
                                        WriteLine(String.Format("{0}MOVE XT-{1}-{2}-{3} TO", Space(11), name, int.ToString("00"), fieldXT(j).NombreCobol))
                                        WriteLine(String.Format("{0}TP-{1}-{2}-{3}.", Space(16), name, int.ToString("00"), fieldTP(j).NombreCobol))
                                    Else
                                        WriteLine(mLineaFinal)
                                    End If
                                End If
                                j += 1
                            End While
                        End If
                        WriteLine(String.Format("{0}FIN-MOV-XT-TP-{1}-{2}.", Space(7), name, int.ToString("00")))
                        WriteLine(String.Format("{0}EXIT.", Space(11)))
                        WriteLine()
                    End If
                    int += 1
                End While
            Next
            Return mWriteLine
        End Function
    End Class
    Public Class ModeloModulosPD3
        Implements IModulos
        Private mLinea As String
        Private mWriteLine As Collection = New Collection()
        Private mServicios As Collection
        Public ReadOnly Property LineaWrite As Collection
            Get
                Return mWriteLine
            End Get
        End Property
        Public Sub New(service As Collection)
            mWriteLine = New Collection()
            mServicios = service
        End Sub
        Private Sub WriteLine(linea As String)
            mWriteLine.Add(linea)
        End Sub
        Private Sub WriteLine()
            mWriteLine.Add("")
        End Sub
        Public Function Contextualizar() As Microsoft.VisualBasic.Collection Implements IModulos.Contextualizar
            Dim metodos As New MetodosAuxiliares
            For Each item As ServiciosRequerimiento In mServicios
                Dim name As String = metodos.TrimChr(item.Nombre)
                Dim int As Integer = 1
                While item.TX.Count >= int
                    If Not item.Transaccional(int) Is Nothing Then
                        Dim instancia As String = item.Transaccional(int).instancia
                        'Debug.Print(">>> " & instancia & " " & item.Transaccional(int).inmando & " - " & item.Transaccional(int).instancia & " - " & item.Transaccional(int).pantalla)
                        WriteLine(String.Format("{0}MOV-GNS-{1}-{2} SECTION.", Space(7), name, int.ToString("00")))
                        WriteLine(String.Format("{0}INI-MOV-GNS-{1}-{2}.", Space(7), name, int.ToString("00")))
                        Dim sComp As String = ""
                        If item.TX(int).Index > 0 Then
                            sComp += "(TPG-I)"
                        End If
                        WriteLine(String.Format("{0}MOVE WSS-{1}-{2}-SIST-{3} TO TX-{1}-{2}-SIST-{3}{4}.", Space(11), name, int.ToString("00"), instancia, sComp))
                        WriteLine(String.Format("{0}MOVE WSS-{1}-{2}-NEMO-{3} TO TX-{1}-{2}-NEMO-{3}{4}.", Space(11), name, int.ToString("00"), instancia, sComp))
                        WriteLine(String.Format("{0}MOVE WSS-{1}-{2}-FINP-{3} TO TX-{1}-{2}-FINP-{3}{4}.", Space(11), name, int.ToString("00"), instancia, sComp))
                        WriteLine(String.Format("{0}MOVE WSS-{1}-{2}-FOUT-{3} TO TX-{1}-{2}-FOUT-{3}{4}.", Space(11), name, int.ToString("00"), instancia, sComp))
                        WriteLine(String.Format("{0}FIN-MOV-GNS-{1}-{2}.", Space(7), name, int.ToString("00")))
                        WriteLine(String.Format("{0}EXIT.", Space(11)))
                        WriteLine()
                        int += 1
                    End If
                End While
            Next
            Return mWriteLine
        End Function
    End Class
    Public Class ModeloModulosPD4
        Implements IModulos
        Private mLinea As String
        Private mWriteLine As Collection = New Collection()
        Private mServicios As Collection
        Private mPantallas As Collection
        Private mValNum As Boolean = True
        Public ReadOnly Property LineaWrite As Collection
            Get
                Return mWriteLine
            End Get
        End Property
        Public Sub New(service As Collection, form As Collection, vnum As String)
            mWriteLine = New Collection()
            mServicios = service
            mPantallas = form
            If vnum = "VNM" Then
                mValNum = False
            Else
                mValNum = True
            End If
        End Sub
        Private Sub WriteLine(linea As String)
            mWriteLine.Add(linea)
        End Sub
        Private Sub WriteLine()
            mWriteLine.Add("")
        End Sub
        Public Function Contextualizar() As Microsoft.VisualBasic.Collection Implements IModulos.Contextualizar
            Dim metodos As New MetodosAuxiliares
            Dim vnpt As Collection = New Collection()
            For Each item As ServiciosRequerimiento In mServicios
                Dim name As String = metodos.TrimChr(item.Nombre)
                WriteLine(String.Format("{0}VAL-NUM-TP-REQ-{1} SECTION.", Space(7), name))
                WriteLine(String.Format("{0}INI-VAL-NUM-TP-REQ-{1}.", Space(7), name))
                Dim int As Integer = 1
                While item.TP.Count >= int
                    Dim pant As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq = item.TP(int)
                    Dim fieldTP As New ArrayList()
                    fieldTP = metodos.getCamposForEdition(pant.Pantalla, pant.Server, mPantallas)
                    Dim j As Integer = 0
                    If Not fieldTP Is Nothing Then
                        While j < fieldTP.Count
                            If Not fieldTP(j).DescripcionNumerica Is Nothing Then
                                WriteLine(String.Format("{0}PERFORM VN-TP-{1}-{2}-{3}.", Space(11), name, int.ToString("00"), fieldTP(j).NombreCobol))
                                'Detalle
                                Dim strEN As String
                                Dim sNum As String
                                Dim inicio As Integer
                                Dim largo As Integer
                                Dim enter As String
                                strEN = String.Format("{0}VN-TP-{1}-{2}-{3} SECTION.", Space(7), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                vnpt.Add(strEN)
                                strEN = String.Format("{0}VNI-TP-{1}-{2}-{3}.", Space(7), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                vnpt.Add(strEN)
                                If pant.Index > 0 And fieldTP(j).Indice > 0 Then
                                    strEN = String.Format("{0}MOVE 1 TO TPG-M.", Space(11))
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}MOVE 1 TO TPG-L.", Space(11))
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}CVN-TP-{1}-{2}-{3}.", Space(7), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}MOVE TP-{1}-{2}-{3}(TPG-L, TPG-M) TO NUM-NUME.", Space(11), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}MOVE NUM-ZERO-S TO NUM-ZERO.", Space(11))
                                    vnpt.Add(strEN)
                                    inicio = fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(",")
                                    largo = (fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(")")) - (inicio + 1)
                                    sNum = fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                                    strEN = String.Format("{0}MOVE NUM-SGNO-{1} TO NUM-SGNO.", Space(11), sNum)
                                    vnpt.Add(strEN)
                                    inicio = fieldTP(j).DescripcionNumerica.ToString.IndexOf("(")
                                    largo = (fieldTP(j).DescripcionNumerica.ToString.IndexOf(",")) - (inicio + 1)
                                    sNum = fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                                    enter = sNum
                                    strEN = String.Format("{0}MOVE {1} TO NUM-NENT.", Space(11), sNum)
                                    vnpt.Add(strEN)
                                    inicio = fieldTP(j).DescripcionNumerica.ToString.IndexOf(",")
                                    largo = (fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(",")) - (inicio + 1)
                                    sNum = fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                                    strEN = String.Format("{0}MOVE {1} TO NUM-NDCM.", Space(11), sNum)
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}PERFORM VAL-NUM.", Space(11))
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}IF NUM-STAT-OKS", Space(11))
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}MOVE SPACES TO TP-{1}-{2}-{3}(TPG-L, TPG-M)", Space(14), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                    vnpt.Add(strEN)
                                    If mValNum Then
                                        strEN = String.Format("{0}MOVE NUM-NN9V TO", Space(14))
                                    Else
                                        strEN = String.Format("{0}MOVE VNM-{1}{2} TO", Space(14), CInt(enter).ToString("00"), (18 - CInt(enter)).ToString("00"))
                                    End If
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}TP-{1}-{2}-{3}-NUM(TPG-L, TPG-M).", Space(19), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}ADD 1 TO TPG-M.", Space(11))
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}IF TPG-M NOT > {1}", Space(11), fieldTP(j).Indice)
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}GO TO CVN-TP-{1}-{2}-{3}", Space(14), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}ELSE", Space(11))
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}ADD 1 TO TPG-L", Space(14))
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}MOVE 1 TO TPG-M", Space(14))
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}IF TPG-L NOT > {1}", Space(14), pant.Index)
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}GO TO CVN-TP-{1}-{2}-{3}.", Space(17), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                    vnpt.Add(strEN)
                                ElseIf pant.Index > 0 Or fieldTP(j).Indice > 0 Then
                                    strEN = String.Format("{0}MOVE 1 TO TPG-L.", Space(11))
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}CVN-TP-{1}-{2}-{3}.", Space(7), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}MOVE TP-{1}-{2}-{3}(TPG-L) TO NUM-NUME.", Space(11), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}MOVE NUM-ZERO-S TO NUM-ZERO.", Space(11))
                                    vnpt.Add(strEN)
                                    inicio = fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(",")
                                    largo = (fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(")")) - (inicio + 1)
                                    sNum = fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                                    strEN = String.Format("{0}MOVE NUM-SGNO-{1} TO NUM-SGNO.", Space(11), sNum)
                                    vnpt.Add(strEN)
                                    inicio = fieldTP(j).DescripcionNumerica.ToString.IndexOf("(")
                                    largo = (fieldTP(j).DescripcionNumerica.ToString.IndexOf(",")) - (inicio + 1)
                                    sNum = fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                                    enter = sNum
                                    strEN = String.Format("{0}MOVE {1} TO NUM-NENT.", Space(11), sNum)
                                    vnpt.Add(strEN)
                                    inicio = fieldTP(j).DescripcionNumerica.ToString.IndexOf(",")
                                    largo = (fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(",")) - (inicio + 1)
                                    sNum = fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                                    strEN = String.Format("{0}MOVE {1} TO NUM-NDCM.", Space(11), sNum)
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}PERFORM VAL-NUM.", Space(11))
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}IF NUM-STAT-OKS", Space(11))
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}MOVE SPACES TO TP-{1}-{2}-{3}(TPG-L)", Space(14), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                    vnpt.Add(strEN)
                                    If mValNum Then
                                        strEN = String.Format("{0}MOVE NUM-NN9V TO TP-{1}-{2}-{3}-NUM(TPG-L).", Space(14), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                    Else
                                        strEN = String.Format("{0}MOVE VNM-{4}{5} TO TP-{1}-{2}-{3}-NUM(TPG-L).", Space(14), name, int.ToString("00"), fieldTP(j).NombreCobol, CInt(enter).ToString("00"), (18 - CInt(enter)).ToString("00"))
                                        'strEN = String.Format("{0}MOVE VNM-{1}{2} TO", Space(14), enter, (18 - CInt(enter)).ToString("00"))
                                    End If
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}ADD 1 TO TPG-L.", Space(11))
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}IF TPG-L NOT > {1}", Space(11), IIf(fieldTP(j).Indice > 0, fieldTP(j).Indice, pant.Index))
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}GO TO CVN-TP-{1}-{2}-{3}.", Space(14), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                    vnpt.Add(strEN)
                                Else
                                    strEN = String.Format("{0}MOVE TP-{1}-{2}-{3} TO NUM-NUME.", Space(11), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}MOVE NUM-ZERO-S TO NUM-ZERO.", Space(11))
                                    vnpt.Add(strEN)
                                    inicio = fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(",")
                                    largo = (fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(")")) - (inicio + 1)
                                    sNum = fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                                    strEN = String.Format("{0}MOVE NUM-SGNO-{1} TO NUM-SGNO.", Space(11), sNum)
                                    vnpt.Add(strEN)
                                    inicio = fieldTP(j).DescripcionNumerica.ToString.IndexOf("(")
                                    largo = (fieldTP(j).DescripcionNumerica.ToString.IndexOf(",")) - (inicio + 1)
                                    sNum = fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                                    enter = sNum
                                    strEN = String.Format("{0}MOVE {1} TO NUM-NENT.", Space(11), sNum)
                                    vnpt.Add(strEN)
                                    inicio = fieldTP(j).DescripcionNumerica.ToString.IndexOf(",")
                                    largo = (fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(",")) - (inicio + 1)
                                    sNum = fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                                    strEN = String.Format("{0}MOVE {1} TO NUM-NDCM.", Space(11), sNum)
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}PERFORM VAL-NUM.", Space(11))
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}IF NUM-STAT-OKS", Space(11))
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}MOVE SPACES TO TP-{1}-{2}-{3}", Space(14), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                    vnpt.Add(strEN)
                                    If mValNum Then
                                        strEN = String.Format("{0}MOVE NUM-NN9V TO TP-{1}-{2}-{3}-NUM.", Space(14), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                    Else
                                        strEN = String.Format("{0}MOVE VNM-{4}{5} TO TP-{1}-{2}-{3}-NUM.", Space(14), name, int.ToString("00"), fieldTP(j).NombreCobol, CInt(enter).ToString("00"), (18 - CInt(enter)).ToString("00"))
                                    End If
                                    vnpt.Add(strEN)
                                    End If
                                    strEN = String.Format("{0}VNF-TP-{1}-{2}-{3}.", Space(7), name, int.ToString("00"), fieldTP(j).NombreCobol)
                                    vnpt.Add(strEN)
                                    strEN = String.Format("{0}EXIT.", Space(11))
                                    vnpt.Add(strEN)
                                    strEN = ""
                                    vnpt.Add(strEN)
                            End If
                            j += 1
                        End While
                    End If
                    int += 1
                End While
                WriteLine(String.Format("{0}FIN-VAL-NUM-TP-REQ-{1}.", Space(7), name))
                WriteLine(String.Format("{0}EXIT.", Space(11)))
                WriteLine()

                WriteLine(String.Format("{0}EDT-NUM-PT-REQ-{1} SECTION.", Space(7), name))
                WriteLine(String.Format("{0}INI-EDT-NUM-PT-REQ-{1}.", Space(7), name))
                int = 1
                Dim enpt As Collection = New Collection()
                While item.PT.Count >= int
                    Dim pant As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq = item.PT(int)
                    Dim fieldPT As New ArrayList()
                    fieldPT = metodos.getCamposForEdition(pant.Pantalla, pant.Server, mPantallas)
                    Dim j As Integer = 0
                    If Not fieldPT Is Nothing Then
                        While j < fieldPT.Count
                            If Not fieldPT(j).DescripcionNumerica Is Nothing Then
                                WriteLine(String.Format("{0}PERFORM EN-PT-{1}-{2}-{3}.", Space(11), name, int.ToString("00"), fieldPT(j).NombreCobol))
                                Dim strEN As String
                                strEN = String.Format("{0}EN-PT-{1}-{2}-{3} SECTION.", Space(7), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                enpt.Add(strEN)
                                strEN = String.Format("{0}ENI-PT-{1}-{2}-{3}.", Space(7), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                enpt.Add(strEN)
                                If pant.Index > 0 Or fieldPT(j).Indice > 0 Then
                                    strEN = String.Format("{0}MOVE 1 TO TPG-L.", Space(11), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                    enpt.Add(strEN)
                                    strEN = String.Format("{0}ENC-PT-{1}-{2}-{3}.", Space(7), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                    enpt.Add(strEN)
                                    Dim strIdx As String = "(TPG-L)"
                                    strEN = String.Format("{0}IF PT-{1}-{2}-{3}-NUM{4} NOT NUMERIC", Space(11), name, int.ToString("00"), fieldPT(j).NombreCobol, strIdx)
                                    enpt.Add(strEN)
                                    strEN = String.Format("{0}GO TO ENV-PT-{1}-{2}-{3}.", Space(14), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                    enpt.Add(strEN)
                                    strEN = String.Format("{0}MOVE PT-{1}-{2}-{3}-NUM{4} TO", Space(11), name, int.ToString("00"), fieldPT(j).NombreCobol, strIdx)
                                    enpt.Add(strEN)
                                    strEN = String.Format("{0}PT-{1}-{2}-{3}-EDT.", Space(16), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                    enpt.Add(strEN)
                                    strEN = String.Format("{0}MOVE PT-{1}-{2}-{3}-EDT TO", Space(11), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                    enpt.Add(strEN)
                                    strEN = String.Format("{0}PT-{1}-{2}-{3}{4}.", Space(16), name, int.ToString("00"), fieldPT(j).NombreCobol, strIdx)
                                    enpt.Add(strEN)
                                    strEN = String.Format("{0}ENV-PT-{1}-{2}-{3}.", Space(7), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                    enpt.Add(strEN)
                                    strEN = String.Format("{0}ADD 1 TO TPG-L.", Space(11), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                    enpt.Add(strEN)
                                    If pant.Index > 0 Then
                                        strEN = String.Format("{0}IF TPG-L NOT > {1}", Space(11), pant.Index)
                                        enpt.Add(strEN)
                                    ElseIf fieldPT(j).Indice > 0 Then
                                        strEN = String.Format("{0}IF TPG-L NOT > {1}", Space(11), fieldPT(j).Indice)
                                        enpt.Add(strEN)
                                    End If
                                    strEN = String.Format("{0}GO TO ENC-PT-{1}-{2}-{3}.", Space(14), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                    enpt.Add(strEN)
                                Else
                                    strEN = String.Format("{0}IF PT-{1}-{2}-{3}-NUM NOT NUMERIC", Space(11), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                    enpt.Add(strEN)
                                    strEN = String.Format("{0}GO TO ENV-PT-{1}-{2}-{3}.", Space(14), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                    enpt.Add(strEN)
                                    strEN = String.Format("{0}MOVE PT-{1}-{2}-{3}-NUM TO", Space(11), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                    enpt.Add(strEN)
                                    strEN = String.Format("{0}PT-{1}-{2}-{3}-EDT.", Space(16), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                    enpt.Add(strEN)
                                    strEN = String.Format("{0}MOVE PT-{1}-{2}-{3}-EDT TO", Space(11), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                    enpt.Add(strEN)
                                    strEN = String.Format("{0}PT-{1}-{2}-{3}.", Space(16), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                    enpt.Add(strEN)
                                    strEN = String.Format("{0}ENV-PT-{1}-{2}-{3}.", Space(7), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                    enpt.Add(strEN)
                                End If
                                strEN = String.Format("{0}ENF-PT-{1}-{2}-{3}.", Space(7), name, int.ToString("00"), fieldPT(j).NombreCobol)
                                enpt.Add(strEN)
                                strEN = String.Format("{0}EXIT.", Space(11))
                                enpt.Add(strEN)
                                strEN = ""
                                enpt.Add(strEN)
                            End If
                            j += 1
                        End While
                    End If
                    int += 1
                End While
                WriteLine(String.Format("{0}FIN-EDT-NUM-PT-REQ-{1}.", Space(7), name))
                WriteLine(String.Format("{0}EXIT.", Space(11)))
                WriteLine()
                For Each strWR As String In enpt
                    WriteLine(String.Format(strWR))
                Next
            Next
            For Each strWR As String In vnpt
                WriteLine(String.Format(strWR))
            Next
            Return mWriteLine
        End Function
    End Class
    Public Class ModeloModulosPI1
        Implements IModulos
        Private mLinea As String
        Private mWriteLine As Collection = New Collection()
        Private mHostTbl As Collection = New Collection()
        Private mSrvTbl As Collection = New Collection()
        Private mMsgTbl As Collection = New Collection()
        Private mMnuTbl As Collection = New Collection()
        Private mRpfTbl As Collection = New Collection()
        Private etiquet As Collection = New Collection()
        Private regrpf As New List(Of RPFField)
        Private mServicios As Collection
        Private mPantallas As Collection
        Dim fecha As String
        Dim hora As String
        Dim sistema As String
        Dim contXYZ As String = "X"
        Dim iContXYZ As Integer = 0
        Public ReadOnly Property LineaWrite As Collection
            Get
                Return mWriteLine
            End Get
        End Property
        Public Sub New(service As Collection, form As Collection, timestamp As String, sistem As String)
            mWriteLine = New Collection()
            mServicios = service
            mPantallas = form
            fecha = timestamp.ToString.Substring(1, 8)
            hora = timestamp.ToString.Substring(9, 6)
            sistema = sistem
        End Sub
        Private Sub WriteLine(linea As String)
            mWriteLine.Add(linea)
        End Sub
        Private Sub WriteLine()
            mWriteLine.Add("")
        End Sub
        Public Function Contextualizar() As Microsoft.VisualBasic.Collection Implements IModulos.Contextualizar
            Dim metodos As New MetodosAuxiliares
            ' Genera Tablas Host
            Dim param As Collection = New Collection()
            Dim registroParametro As Cimagroup.Generador2012.GeneradorBussinesObject.TablaVO
            ' Agrega Tablon HST
            registroParametro = New Cimagroup.Generador2012.GeneradorBussinesObject.TablaVO
            registroParametro.CodigoTipoTabla = "TBL"
            registroParametro.CodigoTabla = "HST"
            registroParametro.FechaModificacion = fecha
            registroParametro.HoraModificacion = hora
            registroParametro.CodigoComputacional = registroParametro.CodigoTipoTabla & "HST"
            registroParametro.AutorTransaccion = "GENESYS"
            registroParametro.CodigoExterno = "HST"
            registroParametro.DescripcionCorta = "HST"
            registroParametro.Abreviacion = "00000"
            registroParametro.Descripcion = "TABLA HST"
            param.Add(registroParametro)
            ' Agrega Host
            registroParametro = New Cimagroup.Generador2012.GeneradorBussinesObject.TablaVO
            registroParametro.CodigoTipoTabla = "HST"
            registroParametro.CodigoTabla = ""
            registroParametro.FechaModificacion = fecha
            registroParametro.HoraModificacion = hora
            registroParametro.CodigoComputacional = registroParametro.CodigoTipoTabla
            registroParametro.AutorTransaccion = "GENESYS"
            registroParametro.CodigoExterno = ""
            registroParametro.DescripcionCorta = ""
            registroParametro.Abreviacion = "00000"
            registroParametro.Descripcion = "TABLA HST"
            param.Add(registroParametro)
            ' Agrega Tablon SRV
            registroParametro = New Cimagroup.Generador2012.GeneradorBussinesObject.TablaVO
            registroParametro.CodigoTipoTabla = "TBL"
            registroParametro.CodigoTabla = "SRV"
            registroParametro.FechaModificacion = fecha
            registroParametro.HoraModificacion = hora
            registroParametro.CodigoComputacional = registroParametro.CodigoTipoTabla & "SRV"
            registroParametro.AutorTransaccion = "GENESYS"
            registroParametro.CodigoExterno = "SRV"
            registroParametro.DescripcionCorta = "SRV"
            registroParametro.Abreviacion = "00000"
            registroParametro.Descripcion = "TABLA SRV"
            param.Add(registroParametro)
            ' Agrega SRV
            registroParametro = New Cimagroup.Generador2012.GeneradorBussinesObject.TablaVO
            registroParametro.CodigoTipoTabla = "SRV"
            registroParametro.CodigoTabla = ""
            registroParametro.FechaModificacion = fecha
            registroParametro.HoraModificacion = hora
            registroParametro.CodigoComputacional = registroParametro.CodigoTipoTabla
            registroParametro.AutorTransaccion = "GENESYS"
            registroParametro.CodigoExterno = ""
            registroParametro.DescripcionCorta = ""
            registroParametro.Abreviacion = "00000"
            registroParametro.Descripcion = "TABLA SRV"
            param.Add(registroParametro)
            For Each item As Cimagroup.Generador2012.GeneradorBussinesObject.Form In mPantallas
                ' Genera tablas HST
                PIHost(item)
                ' Genera tablas SRV
                PIServer(item)
            Next
            ' Genera Parametros de Mensajes
            PIMensajes()
            For Each hst As TablaVO In mHostTbl
                param.Add(hst)
            Next
            For Each srv As TablaVO In mSrvTbl
                param.Add(srv)
            Next
            For Each msg As TablaVO In mMsgTbl
                param.Add(msg)
            Next
            ' Genera MNU y RPF
            For Each item As Cimagroup.Generador2012.GeneradorBussinesObject.ServiciosRequerimiento In mServicios
                ' Genera MNU
                PIMenu(item)
                ' Genera RPF
                PIRPF(item)
            Next
            GeneraPIRPF()
            ' Lleva todo al archivo
            ' Imprime pantalla
            For Each p As Cimagroup.Generador2012.GeneradorBussinesObject.TablaVO In param
                Dim linea As String = p.EnLinea
                WriteLine(String.Format("REGTAB{0}", sistema))
                If linea.Length > 60 Then
                    WriteLine(String.Format("{0}", linea.Substring(0, 60)))
                End If
                If linea.Length > 120 Then
                    WriteLine(String.Format("{0}", linea.Substring(60, 60)))
                End If
                If linea.Length > 180 Then
                    WriteLine(String.Format("{0}", linea.Substring(120, 60)))
                End If
                If linea.Length > 181 Then
                    WriteLine(String.Format("{0}", linea.Substring(180)))
                Else
                    WriteLine()
                End If
            Next
            For Each linea As String In mMnuTbl
                WriteLine(linea)
            Next
            For Each linea As String In mRpfTbl
                WriteLine(linea)
            Next
            WriteLine(String.Format("FINPI1"))
            Return mWriteLine
        End Function
        Private Sub PIHost(item As Form)
            Dim registroParametro As Cimagroup.Generador2012.GeneradorBussinesObject.TablaVO
            Dim metodos As New MetodosAuxiliares
            Dim iterable As Boolean = True
            Dim i As Integer = 0
            Dim code As String
            Dim iInt As Integer
            Dim desc As String = ""
            While iterable
                registroParametro = New Cimagroup.Generador2012.GeneradorBussinesObject.TablaVO
                i += 1
                Dim inter As String = String.Format("0{0}", i)
                code = String.Format("{0}F{1}{2}", metodos.TrimChr(item.Host.Sistema), item.Host.Nombre, inter)
                registroParametro.CodigoTipoTabla = "HST"
                registroParametro.CodigoTabla = code
                registroParametro.CodigoComputacional = registroParametro.CodigoTipoTabla & code
                registroParametro.FechaModificacion = fecha
                registroParametro.HoraModificacion = hora
                registroParametro.AutorTransaccion = "GENESYS"
                registroParametro.CodigoExterno = String.Format("F{0}", item.Host.Nombre)
                registroParametro.DescripcionCorta = code
                registroParametro.Abreviacion = "00000"
                iInt = 0
                If i > 1 Then
                    If desc.Length > 40 Then
                        registroParametro.DatosAdicionales = desc.Substring(40, desc.Length - 40)
                    End If
                    registroParametro.Descripcion = desc
                    iterable = False
                Else
                    Dim ocurs As String = ""
                    Dim arreglo As Boolean = False
                    Dim indice As Integer = 0
                    For Each fld As Cimagroup.Generador2012.GeneradorBussinesObject.Campo In item.Host.Campos
                        If fld.Indice > 0 Then
                            arreglo = True
                            indice = fld.Indice - 1
                            ocurs = ocurs & fld.Tamaño.ToString("00")
                        Else
                            For j As Integer = 1 To indice
                                desc = desc & ocurs
                            Next
                            indice = 0
                            arreglo = False
                        End If
                        desc = desc & fld.Tamaño.ToString("00")
                        iInt += 1
                        etiquet.Add(String.Format("{2}{0}-{1}", iInt.ToString("0000"), fld.Etiqueta, item.Host.Nombre))
                    Next
                    desc = desc & 79
                    If desc.Length > 40 Then
                        registroParametro.DatosAdicionales = desc.Substring(40, desc.Length - 40)
                    End If
                    registroParametro.Descripcion = desc
                    If desc.Length > 100 Then
                        desc = desc.Substring(100)
                    Else
                        iterable = False
                    End If
                End If
                mHostTbl.Add(registroParametro)
            End While
        End Sub
        Private Sub PIServer(item As Form)
            Dim registroParametro As Cimagroup.Generador2012.GeneradorBussinesObject.TablaVO
            Dim metodos As New MetodosAuxiliares
            Dim code As String
            Dim desc As String
            Dim iInt As Integer
            For Each srv As Cimagroup.Generador2012.GeneradorBussinesObject.Server In item.Server
                Dim iterable As Boolean = True
                Dim i As Integer = 0
                desc = ""
                While iterable
                    registroParametro = New Cimagroup.Generador2012.GeneradorBussinesObject.TablaVO
                    i += 1
                    Dim inter As String = String.Format("0{0}", i)
                    code = String.Format("{0}F{1}{2}{3}", metodos.TrimChr(item.Host.Sistema), item.Host.Nombre, srv.Nombre, inter)
                    registroParametro.CodigoTipoTabla = "SRV"
                    registroParametro.CodigoTabla = code
                    registroParametro.CodigoComputacional = registroParametro.CodigoTipoTabla & code
                    registroParametro.FechaModificacion = fecha
                    registroParametro.HoraModificacion = hora
                    registroParametro.AutorTransaccion = "GENESYS"
                    registroParametro.CodigoExterno = String.Format("F{0}", item.Host.Nombre)
                    registroParametro.DescripcionCorta = code
                    registroParametro.Abreviacion = "00000"
                    If i > 1 Then
                        If desc.Length > 40 Then
                            registroParametro.DatosAdicionales = desc.Substring(40, desc.Length - 40)
                        End If
                        registroParametro.Descripcion = desc
                        iterable = False
                    Else
                        Dim ocurs As String = ""
                        Dim indice As Integer = 0
                        For Each camp In srv.Campos
                            iInt = 0
                            For Each fld As Cimagroup.Generador2012.GeneradorBussinesObject.Campo In item.Host.Campos
                                iInt += 1
                                If fld.NombreCobol = camp Then
                                    If fld.Indice > 0 Then
                                        indice = fld.Indice - 1
                                        ocurs = ocurs & iInt.ToString("000")
                                    Else
                                        For j As Integer = 1 To indice
                                            desc = desc & ocurs
                                        Next
                                        indice = 0
                                    End If
                                    desc = desc & iInt.ToString("000")
                                    Exit For
                                End If
                            Next
                        Next
                        If desc.Length > 40 Then
                            Dim str As String = desc.Substring(40, desc.Length - 40)
                            If str.Length > 60 Then
                                registroParametro.DatosAdicionales = str.Substring(0, 59)
                            Else
                                registroParametro.DatosAdicionales = str
                            End If
                            Debug.Print("Largo de largo : {0}", registroParametro.DatosAdicionales)
                        End If
                        registroParametro.Descripcion = desc
                        If desc.Length > 100 Then
                            desc = desc.Substring(100 - 1)
                        Else
                            iterable = False
                        End If
                    End If
                    mSrvTbl.Add(registroParametro)
                End While
            Next
            ' Genera Servers automaticos
            PIServer900(item)
        End Sub
        Private Sub PIServer900(item As Form)
            PIServerAutomaticos("901", item)
            PIServerAutomaticos("903", item)
            PIServerAutomaticos("904", item)
            PIServerAutomaticos("905", item)
            PIServerAutomaticos("907", item)
        End Sub
        Private Sub PIServerAutomaticos(keysrv As String, item As Form)
            Dim registroParametro As Cimagroup.Generador2012.GeneradorBussinesObject.TablaVO
            Dim metodos As New MetodosAuxiliares
            Dim code As String
            Dim desc As String = ""
            Dim iInt As Integer
            Dim iterable As Boolean = True
            Dim i As Integer = 0
            While iterable
                i += 1
                registroParametro = New Cimagroup.Generador2012.GeneradorBussinesObject.TablaVO
                code = String.Format("{0}F{1}{2}0{3}", metodos.TrimChr(item.Host.Sistema), item.Host.Nombre, keysrv, i)
                registroParametro.CodigoTipoTabla = "SRV"
                registroParametro.CodigoTabla = code
                registroParametro.CodigoComputacional = registroParametro.CodigoTipoTabla & code
                registroParametro.FechaModificacion = fecha
                registroParametro.HoraModificacion = hora
                registroParametro.AutorTransaccion = "GENESYS"
                registroParametro.CodigoExterno = String.Format("F{0}", item.Host.Nombre)
                registroParametro.DescripcionCorta = code
                registroParametro.Abreviacion = "00000"
                Dim arrayTipo() As String = {""}
                Select Case keysrv
                    Case "901"
                        arrayTipo = {"IKY"}
                    Case "903"
                        arrayTipo = {"FLD", "MKY"}
                    Case "904"
                        arrayTipo = {"IKY", "AKY", "MKY", "FLD"}
                    Case "905"
                        arrayTipo = {"IKY", "AKY", "MKY"}
                    Case "907"
                        arrayTipo = {""}
                End Select
                If keysrv <> "907" Then
                    If i > 1 Then
                        If desc.Length > 40 Then
                            registroParametro.DatosAdicionales = desc.Substring(40, desc.Length - 40)
                        End If
                        registroParametro.Descripcion = desc
                        iterable = False
                    Else
                        iInt = 0
                        For Each fld As Cimagroup.Generador2012.GeneradorBussinesObject.Campo In item.Host.Campos
                            iInt += 1
                            If arrayTipo.Contains(fld.TipoAcceso) Then
                                desc = desc & iInt.ToString("000")
                            End If
                        Next
                        If desc.Length > 100 Then
                            If desc.Length > 40 Then
                                registroParametro.DatosAdicionales = desc.Substring(40, desc.Length - 42)
                            End If
                            registroParametro.Descripcion = desc
                            desc = desc.Substring(100 - 1)
                        Else
                            If desc.Length > 40 Then
                                registroParametro.DatosAdicionales = desc.Substring(40, desc.Length - 40)
                            End If
                            registroParametro.Descripcion = desc
                            iterable = False
                        End If
                    End If
                Else
                    iterable = False
                End If
                ' registroParametro.Descripcion = desc
                mSrvTbl.Add(registroParametro)
            End While
        End Sub
        Private Sub PIMensajes()
            Dim metodos As New MetodosAuxiliares
            Dim code As String
            For Each e As String In etiquet
                Dim registroParametro As New Cimagroup.Generador2012.GeneradorBussinesObject.TablaVO
                code = String.Format("&&{0}", e.Substring(0, 7))
                registroParametro.CodigoTipoTabla = "MSG"
                registroParametro.CodigoTabla = code
                registroParametro.CodigoComputacional = registroParametro.CodigoTipoTabla & code
                registroParametro.FechaModificacion = fecha
                registroParametro.HoraModificacion = hora
                registroParametro.AutorTransaccion = "GENESYS"
                registroParametro.CodigoExterno = String.Format("&{0}", e.Substring(3, 4))
                registroParametro.DescripcionCorta = code
                registroParametro.Abreviacion = String.Format("&{0}", e.Substring(3, 4))
                registroParametro.Descripcion = metodos.TrimChr(e.Substring(8))
                mMsgTbl.Add(registroParametro)
            Next
        End Sub
        Private Sub PIMenu(item As ServiciosRequerimiento)
            Dim metodos As New MetodosAuxiliares
            For Each tran As Cimagroup.Generador2012.GeneradorBussinesObject.Transaccional In item.Transaccional
                iContXYZ += 1
                If iContXYZ > 99 Then
                    If contXYZ = "X" Then
                        contXYZ = "Y"
                        iContXYZ = 1
                    ElseIf contXYZ = "Y" Then
                        contXYZ = "Z"
                        iContXYZ = 1
                    End If
                End If
                Dim pant As String = metodos.TrimChr(tran.Pantalla)
                Dim prg As String = metodos.TrimChr(tran.Programa)
                Dim comm As String = metodos.TrimChr(tran.Comando)
                Dim inm As String = metodos.TrimChr(tran.Inmando)
                Dim comenta As String = metodos.TrimChr(tran.Comentario)
                Dim instancia As String = tran.Instancia
                Dim mmnu As String
                If inm.Trim = "" Then
                    mmnu = instancia
                Else
                    mmnu = inm
                End If
                Dim idd As String = Space(8)
                If Not tran.IDD Is Nothing Then
                    idd = Mid(metodos.TrimChr(tran.IDD), 1)
                End If
                Dim sCont As String = "X01"
                sCont = contXYZ & iContXYZ.ToString("00")
                mMnuTbl.Add(String.Format("REGMNU{0}", sistema))
                mMnuTbl.Add(String.Format(" {0}{1}{2}{3}{4}{4}{5}PTC{6}", sistema, pant, comm, mmnu, sCont, Space(3), comenta))
                mMnuTbl.Add(String.Format("{0}{1}{2}XXXX{3}", Space(7), prg, Space(33), comm))
                Dim linea As String = String.Format("{0}{1}A{2}{1}F{2}{4}", Space(26), sistema, pant, comm, comenta)
                If linea.Length > 60 Then
                    mMnuTbl.Add(linea.Substring(0, 60))
                    Dim cmpl As String = linea.Substring(60, linea.Length - 60)
                    cmpl += Space(10 - cmpl.Length)
                    mMnuTbl.Add(String.Format("{0}0000SIS{1}{2}{3}LINK", cmpl, Space(14), mmnu, Space(7)))
                Else
                    mMnuTbl.Add(String.Format("{0}{1}A{2}{1}F{2}{4}", Space(26), sistema, pant, comm, comenta))
                    mMnuTbl.Add(String.Format("{0}0000SIS{1}{2}{3}LINK", Space(10), Space(14), instancia, Space(7)))
                End If
                mMnuTbl.Add(String.Format("{0}{1}{2}OT", Space(38), idd, Space(4)))
                mMnuTbl.Add("")
                mMnuTbl.Add("")
                mMnuTbl.Add("")
                mMnuTbl.Add("")
                mMnuTbl.Add(String.Format("REGRPF{0}", sistema))
                mMnuTbl.Add(String.Format("{0}{1}A{2}BEETEAM", prg, Space(4), Space(9)))
                mMnuTbl.Add("")
                mMnuTbl.Add(String.Format("REGRPF{0}", sistema))
                mMnuTbl.Add(String.Format("{0}{1}B{2}{3}{4}", prg, Space(4), Space(9), sistema, pant))
                mMnuTbl.Add("")
                mMnuTbl.Add(String.Format("REGRPF{0}", sistema))
                mMnuTbl.Add(String.Format("{0}{1}C{2}", prg, Space(4), Space(9)))
                mMnuTbl.Add("")
                mMnuTbl.Add(String.Format("REGRPF{0}", sistema))
                mMnuTbl.Add(String.Format("{0}{1}P0{2}{3}{4}{3}{4}", prg, Space(4), Space(8), sistema, pant))
                mMnuTbl.Add("")
            Next
        End Sub
        Private Sub PIRPF(item As ServiciosRequerimiento)
            Dim metodos As New MetodosAuxiliares
            For Each tran As Cimagroup.Generador2012.GeneradorBussinesObject.Transaccional In item.Transaccional
                Dim rpf As New RPFField
                rpf.pant = metodos.TrimChr(tran.Pantalla)
                rpf.prg = metodos.TrimChr(tran.Programa)
                rpf.sprg = metodos.TrimChr(tran.Subprograma)
                rpf.comm = metodos.TrimChr(tran.Comando)
                rpf.cpp = metodos.TrimChr(tran.CPP)
                rpf.spp = metodos.TrimChr(tran.SPP)
                rpf.cnf = metodos.TrimChr(tran.Confirmacion)
                rpf.comenta = metodos.TrimChr(tran.Comentario)
                rpf.inm = metodos.TrimChr(tran.Inmando)
                rpf.idd = Space(8)
                If Not tran.IDD Is Nothing Then
                    rpf.idd = Mid(metodos.TrimChr(tran.IDD), 1)
                End If
                If regrpf.IndexOf(rpf) < 0 Then
                    regrpf.Insert(PositionList(regrpf, rpf), rpf)
                End If
            Next
        End Sub
        Private Sub GeneraPIRPF()
            Dim jInt As Integer = 0
            Dim actual As String = ""
            For Each rpf As RPFField In regrpf
                If actual <> rpf.prg Then
                    jInt = 0
                    actual = rpf.prg
                End If
                mRpfTbl.Add(String.Format("REGRPF{0}", sistema))
                If rpf.inm = "" Then
                    mRpfTbl.Add(String.Format("{0}{1}C{6}{2}{3}{4}{5}", rpf.prg, Space(4), IIf(jInt.ToString.Length > 1, Space(7), Space(8)), rpf.comm, Space(25), rpf.cnf, jInt))
                Else
                    mRpfTbl.Add(String.Format("{0}{1}C{6}{2}{3}{4}{5}", rpf.prg, Space(4), IIf(jInt.ToString.Length > 1, Space(7), Space(8)), rpf.inm, Space(25), rpf.cnf, jInt))
                End If
                mRpfTbl.Add(String.Format("{0}{1}{2}{3}", Space(15), rpf.sprg.PadRight(12), rpf.cpp, rpf.spp))
                jInt += 1
            Next
        End Sub
        Private Function PositionList(ByRef lista As List(Of RPFField), element As RPFField) As Integer
            Dim position As Integer = 0
            For Each item As RPFField In lista
                If element.prg.CompareTo(item.prg) < 0 Then
                    Exit For
                ElseIf element.prg.CompareTo(item.prg) = 0 Then
                    If element.comm.CompareTo(item.comm) < 0 Then
                        Exit For
                    End If
                End If
                position += 1
            Next
            Return position
        End Function
    End Class
    Public Class ModeloModulosWS1
        Implements IModulos
        Private mLinea As String
        Private mWriteLine As Collection = New Collection()
        Private mPT As Collection = New Collection()
        Private mXT As Collection = New Collection()
        Private mServicios As Collection
        Private mPantallas As Collection
        Private mSistema As String
        Private mLargoRcv As Integer
        Private mAtributos As Boolean
        Private mFirst As Boolean = True
        Dim metodos As New MetodosAuxiliares
        Public ReadOnly Property LineaWrite As Collection
            Get
                Return mWriteLine
            End Get
        End Property
        Public Sub New(service As Collection, form As Collection, cabecera As CabeceraMtx)
            mWriteLine = New Collection()
            mServicios = service
            mPantallas = form
            mSistema = cabecera.Sistema
            mLargoRcv = cabecera.LargoReceive
            mAtributos = cabecera.Atributos
            If metodos.TrimChr(cabecera.IndicadorPrimerArchivo) = "S" Then
                mFirst = True
            Else
                mFirst = False
            End If
        End Sub
        Private Sub WriteLine(linea As String)
            mWriteLine.Add(linea)
        End Sub
        Private Sub WriteLine()
            mWriteLine.Add("")
        End Sub
        Public Function Contextualizar() As Microsoft.VisualBasic.Collection Implements IModulos.Contextualizar
            If mFirst Then
                Dim tamañoBuff As Integer = mLargoRcv \ 1024
                WriteLine(String.Format("{0}01  WSS-RCV.", Space(7)))
                WriteLine(String.Format("{0}03 WSS-RCV-HDR{1}PIC X(00100).", Space(11), Space(34)))
                WriteLine(String.Format("{0}03 WSS-RCV-CREQ.", Space(11)))
                WriteLine(String.Format("{0}05 WSS-RCV-CREQ-1{1}PIC X(00001).", Space(14), Space(28)))
                WriteLine(String.Format("{0}05 WSS-RCV-CREQ-2{1}PIC X(00002).", Space(14), Space(28)))
                WriteLine(String.Format("{0}03 WSS-RCV-DAT{1}PIC X({2}).", Space(11), Space(34), (mLargoRcv - 103).ToString("00000")))
                WriteLine()
                WriteLine(String.Format("{0}01  WSS-SEGR-RCV REDEFINES WSS-RCV.", Space(7)))
                WriteLine(String.Format("{0}03 WSS-TAB-SEGR{1}OCCURS {2} TIMES.", Space(11), Space(11), tamañoBuff.ToString("00000")))
                WriteLine(String.Format("{0}05 WSS-ELE-SEGR{1}PIC X(01024).", Space(14), Space(30)))
                WriteLine(String.Format("{0}03 WSS-ELE-SEGR-CPL{1}PIC X({2}).", Space(11), Space(29), (mLargoRcv - tamañoBuff * 1024).ToString("00000")))
                WriteLine(String.Format("{0}01  WSS-RCV-RED REDEFINES WSS-RCV.", Space(7)))
                WriteLine(String.Format("{0}03 WSS-RCV-RED-ELM{1}OCCURS {2} TIMES{3}PIC X(00001).", Space(11), Space(8), mLargoRcv.ToString("00000"), Space(4)))
                WriteLine(String.Format("{0}*", Space(6)))
            End If
            For Each item As Cimagroup.Generador2012.GeneradorBussinesObject.ServiciosRequerimiento In mServicios
                GeneraPT(item)
                GeneraXT(item)
            Next
            For Each line As String In mPT
                WriteLine(line)
            Next
            For Each line As String In mXT
                WriteLine(line)
            Next
            Return mWriteLine
        End Function
        Private Sub GeneraPT(item As ServiciosRequerimiento)
            Dim name As String = metodos.TrimChr(item.Nombre)
            mPT.Add(String.Format("{0}*  =========================== PT-{1} ===========================", Space(6), name))
            mPT.Add(String.Format("{0}*", Space(6)))
            mPT.Add(String.Format("{0}* DOCSER {1} : {2}", Space(6), name, metodos.TrimChr(item.Descripcion)))
            mPT.Add(String.Format("{0}* DOCXML {1} : {2}", Space(6), name, item.MetodoJava))
            mPT.Add(String.Format("{0}01 PT-{1} REDEFINES WSS-RCV.", Space(7), name))
            mPT.Add(String.Format("{0}03 PT-{1}-AHDR{2}PIC X(00100).", Space(11), name, Space(34)))
            mPT.Add(String.Format("{0}03 PT-{1}-CREQ{2}PIC X(00003).", Space(11), name, Space(34)))
            mPT.Add(String.Format("{0}03 PT-{1}-DMSG.", Space(11), name))
            Dim iLarge As Integer = mLargoRcv - 103
            Dim int As Integer = 1
            Dim countIndex As Integer = 0
            While item.PT.Count >= int
                Dim pant As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq = item.PT(int)
                Dim fieldPT As New ArrayList()
                Dim sIns As String = "+++"
                Dim sCom As String = "..."
                If int <= item.Transaccional.Count Then
                    If Not item.Transaccional(int) Is Nothing Then
                        sIns = item.Transaccional(int).Instancia
                        sCom = metodos.TrimChr(item.Transaccional(int).Comando)
                    End If
                End If
                mPT.Add(String.Format("{0}*>> {1}-{2}-{3}-{4} ({5})", Space(6), mSistema, pant.Pantalla, sCom, sIns, pant.Server))
                fieldPT = metodos.getCamposForEdition(pant.Pantalla, pant.Server, mPantallas)
                Dim j As Integer = 0
                Dim interOcc As Boolean = False
                If Not (fieldPT Is Nothing) Then
                    If pant.Index > 0 Then
                        mPT.Add(String.Format("{0}05 PT-{1}-DMSG-IDX-1-{2} OCCURS {3} TIMES.", Space(14), name, int.ToString("00"), pant.Index))
                    End If
                    While j < fieldPT.Count
                        If fieldPT(j).indice > 0 Then
                            interOcc = True
                            countIndex += 1
                        Else
                            interOcc = False
                            countIndex = 0
                        End If
                        If j < 1 And interOcc = True Then
                            mPT.Add(String.Format("{0}05 PT-{1}-{2}-FLD-HST OCCURS {3} TIMES.", Space(14), name, int.ToString("00"), fieldPT(j).indice))
                        ElseIf countIndex = 1 And pant.Index < 1 And j > 1 Then
                            mPT.Add(String.Format("{0}05 PT-{1}-{2}-FLD-HST OCCURS {3} TIMES.", Space(14), name, int.ToString("00"), fieldPT(j).indice))
                        End If
                        Dim Tamaño As Integer = fieldPT(j).Tamaño
                        If fieldPT(j).NombreFML Is Nothing Then
                            mPT.Add(String.Format("{0}* DOCFLD : {1} {2}", Space(6), metodos.TrimChr(fieldPT(j).Etiqueta), fieldPT(j).NombreJava))
                        Else
                            mPT.Add(String.Format("{0}* DOCFLD : {1} {2} {3}", Space(6), metodos.TrimChr(fieldPT(j).Etiqueta), fieldPT(j).NombreFML, fieldPT(j).NombreJava))
                        End If
                        If pant.Index > 0 And fieldPT(j).indice > 0 Then
                            mPT.Add(String.Format("{0}07 PT-{1}-{2}-{3}PIC X({4}).", Space(17), name, int.ToString("00"), fieldPT(j).NombreCobol.ToString.PadRight(29), Tamaño.ToString("00000")))
                            If Not fieldPT(j).DescripcionNumerica Is Nothing Then
                                mPT.Add(String.Format("{0}07 PT-{1}-{2}-{3}-R REDEFINES", Space(17), name, int.ToString("00"), fieldPT(j).NombreCobol))
                                mPT.Add(String.Format("{0}PT-{1}-{2}-{3}.", Space(20), name, int.ToString("00"), fieldPT(j).NombreCobol))
                                Dim inicio As Integer
                                Dim largo As Integer
                                Dim sSigno As Char
                                Dim sEntero As String
                                Dim sDecimal As String
                                inicio = fieldPT(j).DescripcionNumerica.ToString.LastIndexOf(",")
                                largo = (fieldPT(j).DescripcionNumerica.ToString.LastIndexOf(")")) - (inicio + 1)
                                sSigno = fieldPT(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                                inicio = fieldPT(j).DescripcionNumerica.ToString.IndexOf("(")
                                largo = (fieldPT(j).DescripcionNumerica.ToString.IndexOf(",")) - (inicio + 1)
                                sEntero = CType(fieldPT(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo), Integer).ToString("00")
                                inicio = fieldPT(j).DescripcionNumerica.ToString.IndexOf(",")
                                largo = (fieldPT(j).DescripcionNumerica.ToString.LastIndexOf(",")) - (inicio + 1)
                                sDecimal = CType(fieldPT(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo), Integer).ToString("00")
                                Dim compl As Integer = fieldPT(j).Tamaño - (CType(sDecimal, Integer) + CType(sEntero, Integer))
                                If compl > 0 Or CType(sDecimal, Integer) > 0 Then
                                    mPT.Add(String.Format("{0}09 PT-{1}-{2}-{3}-CPL{4}PIC X({5}).", Space(20), name, int.ToString("00"), fieldPT(j).NombreCobol, Space(2), compl.ToString("00000")))
                                End If
                                mPT.Add(String.Format("{0}09 PT-{1}-{2}-{3}-NUM", Space(20), name, int.ToString("00"), fieldPT(j).NombreCobol))
                                If sSigno = "N" Then
                                    sSigno = " "
                                End If
                                If CType(sDecimal, Integer) > 0 Then
                                    mPT.Add(String.Format("{0}PIC {2}9({1})V9({3}).", Space(20), sEntero, sSigno, sDecimal))
                                Else
                                    mPT.Add(String.Format("{0}PIC {2}9({1}).", Space(20), sEntero, sSigno))
                                End If
                            End If
                            iLarge -= (Tamaño * pant.Index * fieldPT(j).indice)
                        ElseIf pant.Index > 0 Or fieldPT(j).indice > 0 Then
                            mPT.Add(String.Format("{0}07 PT-{1}-{2}-{3}PIC X({4}).", Space(17), name, int.ToString("00"), fieldPT(j).NombreCobol.ToString.PadRight(29), Tamaño.ToString("00000")))
                            If Not fieldPT(j).DescripcionNumerica Is Nothing Then
                                mPT.Add(String.Format("{0}07 PT-{1}-{2}-{3}-R REDEFINES", Space(17), name, int.ToString("00"), fieldPT(j).NombreCobol))
                                mPT.Add(String.Format("{0}PT-{1}-{2}-{3}.", Space(20), name, int.ToString("00"), fieldPT(j).NombreCobol))
                                Dim inicio As Integer
                                Dim largo As Integer
                                Dim sSigno As Char
                                Dim sEntero As String
                                Dim sDecimal As String
                                inicio = fieldPT(j).DescripcionNumerica.ToString.LastIndexOf(",")
                                largo = (fieldPT(j).DescripcionNumerica.ToString.LastIndexOf(")")) - (inicio + 1)
                                sSigno = fieldPT(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                                inicio = fieldPT(j).DescripcionNumerica.ToString.IndexOf("(")
                                largo = (fieldPT(j).DescripcionNumerica.ToString.IndexOf(",")) - (inicio + 1)
                                sEntero = CType(fieldPT(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo), Integer).ToString("00")
                                inicio = fieldPT(j).DescripcionNumerica.ToString.IndexOf(",")
                                largo = (fieldPT(j).DescripcionNumerica.ToString.LastIndexOf(",")) - (inicio + 1)
                                sDecimal = CType(fieldPT(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo), Integer).ToString("00")
                                Dim compl As Integer = fieldPT(j).Tamaño - (CType(sDecimal, Integer) + CType(sEntero, Integer))
                                If compl > 0 Or CType(sDecimal, Integer) > 0 Then
                                    mPT.Add(String.Format("{0}09 PT-{1}-{2}-{3}-CPL{4}PIC X({5}).", Space(20), name, int.ToString("00"), fieldPT(j).NombreCobol, Space(2), compl.ToString("00000")))
                                End If
                                mPT.Add(String.Format("{0}09 PT-{1}-{2}-{3}-NUM", Space(20), name, int.ToString("00"), fieldPT(j).NombreCobol))
                                If sSigno = "N" Then
                                    sSigno = " "
                                End If
                                If CType(sDecimal, Integer) > 0 Then
                                    mPT.Add(String.Format("{0}PIC {2}9({1})V9({3}).", Space(20), sEntero, sSigno, sDecimal))
                                Else
                                    mPT.Add(String.Format("{0}PIC {2}9({1}).", Space(20), sEntero, sSigno))
                                End If
                            End If
                            If pant.Index > 0 Then
                                iLarge -= (Tamaño * pant.Index)
                            Else
                                iLarge -= (Tamaño * fieldPT(j).indice)
                            End If
                        Else
                            mPT.Add(String.Format("{0}05 PT-{1}-{2}-{3}PIC X({4}).", Space(14), name, int.ToString("00"), fieldPT(j).NombreCobol.ToString.PadRight(32), Tamaño.ToString("00000")))
                            If Not fieldPT(j).DescripcionNumerica Is Nothing Then
                                mPT.Add(String.Format("{0}05 PT-{1}-{2}-{3}-R REDEFINES", Space(14), name, int.ToString("00"), fieldPT(j).NombreCobol))
                                mPT.Add(String.Format("{0}PT-{1}-{2}-{3}.", Space(17), name, int.ToString("00"), fieldPT(j).NombreCobol))
                                Dim inicio As Integer
                                Dim largo As Integer
                                Dim sSigno As Char
                                Dim sEntero As String
                                Dim sDecimal As String
                                inicio = fieldPT(j).DescripcionNumerica.ToString.LastIndexOf(",")
                                largo = (fieldPT(j).DescripcionNumerica.ToString.LastIndexOf(")")) - (inicio + 1)
                                sSigno = fieldPT(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                                inicio = fieldPT(j).DescripcionNumerica.ToString.IndexOf("(")
                                largo = (fieldPT(j).DescripcionNumerica.ToString.IndexOf(",")) - (inicio + 1)
                                sEntero = CType(fieldPT(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo), Integer).ToString("00")
                                inicio = fieldPT(j).DescripcionNumerica.ToString.IndexOf(",")
                                largo = (fieldPT(j).DescripcionNumerica.ToString.LastIndexOf(",")) - (inicio + 1)
                                sDecimal = CType(fieldPT(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo), Integer).ToString("00")
                                Dim compl As Integer = fieldPT(j).Tamaño - (CType(sDecimal, Integer) + CType(sEntero, Integer))
                                If compl > 0 Or CType(sDecimal, Integer) > 0 Then
                                    mPT.Add(String.Format("{0}07 PT-{1}-{2}-{3}-CPL{4}PIC X({5}).", Space(17), name, int.ToString("00"), fieldPT(j).NombreCobol, Space(2), compl.ToString("00000")))
                                End If
                                mPT.Add(String.Format("{0}07 PT-{1}-{2}-{3}-NUM", Space(17), name, int.ToString("00"), fieldPT(j).NombreCobol))
                                If sSigno = "N" Then
                                    sSigno = " "
                                End If
                                If CType(sDecimal, Integer) > 0 Then
                                    mPT.Add(String.Format("{0}PIC {2}9({1})V9({3}).", Space(20), sEntero, sSigno, sDecimal))
                                Else
                                    mPT.Add(String.Format("{0}PIC {2}9({1}).", Space(20), sEntero, sSigno))
                                End If
                            End If
                            iLarge -= Tamaño
                        End If
                        j += 1
                    End While
                End If
                int += 1
            End While
            mPT.Add(String.Format("{0}03 PT-{1}-FRM-GLS-DISP{2}PIC X({3}).", Space(11), name, Space(26), iLarge.ToString("00000")))
            mPT.Add(String.Format("{0}*", Space(6)))
            mPT.Add(String.Format("{0}*", Space(6)))
        End Sub
        Private Sub GeneraXT(item As ServiciosRequerimiento)
            Dim name As String = metodos.TrimChr(item.Nombre)
            mXT.Add(String.Format("{0}*  =========================== XT-{1} ===========================", Space(6), name))
            mXT.Add(String.Format("{0}*", Space(6)))
            mXT.Add(String.Format("{0}* DOCSER {1} : {2}", Space(6), name, metodos.TrimChr(item.Descripcion)))
            mXT.Add(String.Format("{0}* DOCXML {1} : {2}", Space(6), name, item.MetodoJava))
            mXT.Add(String.Format("{0}01 XT-{1} REDEFINES WSS-RCV.", Space(7), name))
            mXT.Add(String.Format("{0}03 XT-{1}-DMSG.", Space(11), name))
            Dim iLarge As Integer = mLargoRcv
            Dim int As Integer = 1
            Dim countIndex As Integer = 0
            Dim greenBool As Boolean = False
            While item.XT.Count >= int
                Dim pant As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq = item.XT(int)
                Dim fieldXT As New ArrayList()
                Dim sIns As String = "+++"
                Dim sCom As String = "..."
                If int <= item.Transaccional.Count Then
                    If Not item.Transaccional(int) Is Nothing Then
                        sIns = item.Transaccional(int).Instancia
                        sCom = metodos.TrimChr(item.Transaccional(int).Comando)
                    End If
                End If
                mXT.Add(String.Format("{0}*>> {1}-{2}-{3}-{4} ({5})", Space(6), mSistema, pant.Pantalla, sCom, sIns, pant.Server))
                fieldXT = metodos.getCamposForEdition(pant.Pantalla, pant.Server, mPantallas)
                Dim j As Integer = 0
                Dim interOcc As Boolean = False
                If Not (fieldXT Is Nothing) Then
                    If pant.Index > 0 Then
                        mXT.Add(String.Format("{0}05 XT-{1}-DMSG-IDX-1-{2} OCCURS {3} TIMES.", Space(14), name, int.ToString("00"), pant.Index))
                    End If
                    While j < fieldXT.Count
                        greenBool = True
                        If fieldXT(j).indice > 0 Then
                            interOcc = True
                            countIndex += 1
                        Else
                            interOcc = False
                            countIndex = 0
                        End If
                        If pant.Index > 0 And fieldXT(j).indice > 0 And j < 1 Then
                            mXT.Add(String.Format("{0}07 XT-{1}-FLD-HST OCCURS {2} TIMES.", Space(17), name, fieldXT(j).indice))
                        ElseIf countIndex = 1 And pant.Index < 1 And j > 1 Then
                            mXT.Add(String.Format("{0}05 XT-{1}-FLD-HST OCCURS {2} TIMES.", Space(14), name, fieldXT(j).indice))
                        End If
                        If fieldXT(j).NombreFML Is Nothing Then
                            mXT.Add(String.Format("{0}* DOCFLD : {1} {2}", Space(6), metodos.TrimChr(fieldXT(j).Etiqueta), fieldXT(j).NombreJava))
                        Else
                            mXT.Add(String.Format("{0}* DOCFLD : {1} {2} {3}", Space(6), metodos.TrimChr(fieldXT(j).Etiqueta), fieldXT(j).NombreFML, fieldXT(j).NombreJava))
                        End If
                        Dim tamaño As Integer = fieldXT(j).Tamaño
                        If pant.Index > 0 And fieldXT(j).indice > 0 Then
                            If mAtributos Or item.Atributos Then
                                mXT.Add(String.Format("{0}09 XT-{1}-{2}-{3}-ATR{4}PIC X(0000{5}).", Space(20), name, int.ToString("00"), fieldXT(j).NombreCobol, Space(13), 1))
                                iLarge -= pant.Index * fieldXT(j).indice
                            End If
                            mXT.Add(String.Format("{0}09 XT-{1}-{2}-{3}{4}PIC X({5}).", Space(20), name, int.ToString("00"), fieldXT(j).NombreCobol, Space(14), tamaño.ToString("00000")))
                            iLarge -= fieldXT(j).Tamaño * pant.Index * fieldXT(j).indice
                        ElseIf pant.Index > 0 Or fieldXT(j).indice > 0 Then
                            If mAtributos Or item.Atributos Then
                                mXT.Add(String.Format("{0}07 XT-{1}-{2}-{3}-ATR{4}PIC X(0000{5}).", Space(17), name, int.ToString("00"), fieldXT(j).NombreCobol, Space(13), 1))
                                If pant.Index > 0 Then
                                    iLarge -= pant.Index
                                Else
                                    iLarge -= fieldXT(j).indice
                                End If
                            End If
                            mXT.Add(String.Format("{0}07 XT-{1}-{2}-{3}{4}PIC X({5}).", Space(17), name, int.ToString("00"), fieldXT(j).NombreCobol, Space(17), tamaño.ToString("00000")))
                            If pant.Index > 0 Then
                                iLarge -= tamaño * pant.Index
                            Else
                                iLarge -= tamaño * fieldXT(j).indice
                            End If
                        Else
                            If mAtributos Or item.Atributos Then
                                mXT.Add(String.Format("{0}05 XT-{1}-{2}-{3}-ATR{4}PIC X(0000{5}).", Space(14), name, int.ToString("00"), fieldXT(j).NombreCobol, Space(16), 1))
                                iLarge -= 1
                            End If
                            mXT.Add(String.Format("{0}05 XT-{1}-{2}-{3}{4}PIC X({5}).", Space(14), name, int.ToString("00"), fieldXT(j).NombreCobol, Space(20), tamaño.ToString("00000")))
                            iLarge -= tamaño
                        End If
                        j += 1
                    End While
                End If
                int += 1
            End While
            If greenBool Then
                mXT.Add(String.Format("{0}03 XT-{1}-FRM-GLS-DISP{2}PIC X({3}).", Space(11), name, Space(26), iLarge.ToString("00000")))
            Else
                mXT.Add(String.Format("{0}05 XT-{1}-FRM-GLS-DISP{2}PIC X({3}).", Space(14), name, Space(23), iLarge.ToString("00000")))
            End If
            mXT.Add(String.Format("{0}*", Space(6)))
            mXT.Add(String.Format("{0}* FORMATO MXAPT", Space(6)))
            mXT.Add(String.Format("{0}*", Space(6)))
        End Sub
    End Class
    Public Class ModeloModulosWS2
        Implements IModulos
        Private mLinea As String
        Private mWriteLine As Collection = New Collection()
        Private mTP As Collection = New Collection()
        Private mTX As Collection = New Collection()
        Private mServicios As Collection
        Private mPantallas As Collection
        Private mSistema As String
        Private mNemo As String
        Private mLargoSnd As Integer
        Private mAtributos As Boolean
        Private mFirst As Boolean = True
        Dim metodos As New MetodosAuxiliares
        ' Variables para el manejo de las estructuras de mensajes, estos seran utilizados en procesos JSON
        Private mMsgServiceSalida As New EstructuraJSON.EstructuraSalida
        Private mServicioColeccion As New Collection()
        Private mMsgService As EstructuraJSON.ServiceMessage
        Private mMsgData As EstructuraJSON.DataOccs
        Private mMsgCampos As EstructuraJSON.Campos
        Public ReadOnly Property LineaWrite As Collection
            Get
                Return mWriteLine
            End Get
        End Property
        Public ReadOnly Property MensajeSalida As EstructuraJSON.EstructuraSalida
            Get
                Return mMsgServiceSalida
            End Get
        End Property
        Public Sub New(service As Collection, form As Collection, cabecera As CabeceraMtx)
            mWriteLine = New Collection()
            mServicios = service
            mPantallas = form
            mSistema = cabecera.Sistema
            mLargoSnd = cabecera.LargoSend
            mAtributos = cabecera.Atributos
            mNemo = cabecera.NemotecnicoFile
            If metodos.TrimChr(cabecera.IndicadorPrimerArchivo) = "S" Then
                mFirst = True
            Else
                mFirst = False
            End If
        End Sub
        Private Sub WriteLine(linea As String)
            mWriteLine.Add(linea)
        End Sub
        Private Sub WriteLine()
            mWriteLine.Add("")
        End Sub
        Public Function sendMSG() As EstructuraJSON.EstructuraSalida
            Return mMsgServiceSalida
        End Function
        Public Function Contextualizar() As Microsoft.VisualBasic.Collection Implements IModulos.Contextualizar
            If mFirst Then
                Dim tamañoBuff As Integer = mLargoSnd \ 1024
                WriteLine(String.Format("{0}01  WSS-SND.", Space(7)))
                WriteLine(String.Format("{0}*{2}03 WSS-SND-HDR{1}PIC X(00100).", Space(6), Space(34), Space(4)))
                WriteLine(String.Format("{0}03 WSS-SND-DMSG.", Space(11)))
                WriteLine(String.Format("{0}05 WSS-SND-STAT{1}PIC X(00001).", Space(14), Space(30)))
                WriteLine(String.Format("{0}05 WSS-SND-MENS.", Space(14)))
                WriteLine(String.Format("{0}07 WSS-SND-MENS1{1}PIC X(00020).", Space(17), Space(26)))
                WriteLine(String.Format("{0}07 WSS-SND-MENS2{1}PIC X(00059).", Space(17), Space(26)))
                WriteLine(String.Format("{0}03 WSS-SND-DAT{1}PIC X({2}).", Space(11), Space(34), (mLargoSnd - 180).ToString("00000")))
                WriteLine()
                WriteLine(String.Format("{0}01  WSS-SEGR-SND REDEFINES WSS-SND.", Space(7)))
                WriteLine(String.Format("{0}03 WSS-TAB-SEGS{1}OCCURS {2} TIMES.", Space(11), Space(11), tamañoBuff.ToString("00000")))
                WriteLine(String.Format("{0}05 WSS-ELE-SEGS{1}PIC X(01024).", Space(14), Space(30)))
                WriteLine(String.Format("{0}03 WSS-ELE-SEGS-CPL{1}PIC X({2}).", Space(11), Space(29), (mLargoSnd - tamañoBuff * 1024).ToString("00000")))
                WriteLine(String.Format("{0}*", Space(6)))
            End If
            For Each item As Cimagroup.Generador2012.GeneradorBussinesObject.ServiciosRequerimiento In mServicios
                GeneraTP(item)
                GeneraTP_v2A(item)
                GeneraTX(item)
                mMsgServiceSalida.MensajeSalida.Add(mServicioColeccion)
            Next
            For Each line As String In mTP
                WriteLine(line)
            Next
            For Each line As String In mTX
                WriteLine(line)
            Next
            If mFirst Then
                WriteLine(String.Format("{0}* FORMATO PARA CONCATENACION DE MENSAJES", Space(6)))
                WriteLine(String.Format("{0}01 TX-TAB REDEFINES WSS-SND.", Space(7)))
                WriteLine(String.Format("{0}03 TX-TAB-ELM.", Space(11)))
                ' TODO: Ocurrencias varian de acuerdo al LargoSND
                WriteLine(String.Format("{0}05 TX-TAB-CHR OCCURS {2} TIMES{1}PIC X(00001).", Space(14), Space(13), mLargoSnd))
            End If
            WriteLine()
            printTest()
            Return mWriteLine
        End Function
        Private Sub printTest()
            Dim srvOutPrint As New GeneradorModulosPruebas.GeneradorSalidaTest(MensajeSalida, mSistema, mNemo, "C:\1_Paso\Generador2012\Output\")
            srvOutPrint.Generar()
        End Sub
        Private Sub GeneraTP(item As ServiciosRequerimiento)
            Dim name As String = metodos.TrimChr(item.Nombre)
            mTP.Add(String.Format("{0}*  =========================== TP-{1} ===========================", Space(6), name))
            mTP.Add(String.Format("{0}*", Space(6)))
            mTP.Add(String.Format("{0}* DOCSER {1} : {2}", Space(6), name, metodos.TrimChr(item.Descripcion)))
            mTP.Add(String.Format("{0}* DOCXML {1} : {2}", Space(6), name, item.MetodoJava))
            mTP.Add(String.Format("{0}01 TP-{1} REDEFINES WSS-SND.", Space(7), name))
            mTP.Add(String.Format("{0}03 TP-{1}-STAT{2}PIC X(00001).", Space(11), name, Space(34)))
            mTP.Add(String.Format("{0}03 TP-{1}-MENS{2}PIC X(00079).", Space(11), name, Space(34)))
            mTP.Add(String.Format("{0}03 TP-{1}-DMSG.", Space(11), name))
            Dim iLarge As Integer = mLargoSnd - 80
            Dim int As Integer = 1
            Dim countIndex As Integer = 0
            Dim greenBool As Boolean = False
            While item.TP.Count >= int
                Dim pant As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq = item.TP(int)
                Dim fieldTP As New ArrayList()
                Dim sIns As String = "+++"
                Dim sCom As String = "..."
                If int <= item.Transaccional.Count Then
                    If Not item.Transaccional(int) Is Nothing Then
                        sIns = item.Transaccional(int).Instancia
                        sCom = metodos.TrimChr(item.Transaccional(int).Comando)
                    End If
                End If
                mTP.Add(String.Format("{0}*>> {1}-{2}-{3}-{4} ({5})", Space(6), mSistema, pant.Pantalla, sCom, sIns, pant.Server))
                fieldTP = metodos.getCamposForEdition(pant.Pantalla, pant.Server, mPantallas)
                Dim j As Integer = 0
                Dim interOcc As Boolean = False
                If Not (fieldTP Is Nothing) Then
                    If pant.Index > 0 Then
                        mTP.Add(String.Format("{0}05 TP-{1}-DMSG-IDX-1-{2} OCCURS {3} TIMES.", Space(14), name, int.ToString("00"), pant.Index))
                    End If
                    While j < fieldTP.Count
                        greenBool = True
                        If fieldTP(j).indice > 0 Then
                            interOcc = True
                            countIndex += 1
                        Else
                            interOcc = False
                            countIndex = 0
                        End If
                        If j < 1 And fieldTP(j).indice > 0 Then
                            mTP.Add(String.Format("{0}07 TP-{1}-FLD-HST OCCURS {3} TIMES.", Space(17), name, int.ToString("00"), fieldTP(j).indice))
                        ElseIf countIndex = 1 And pant.Index < 1 And j > 1 Then
                            mTP.Add(String.Format("{0}05 TP-{1}-FLD-HST OCCURS {3} TIMES.", Space(14), name, int.ToString("00"), fieldTP(j).indice))
                        End If
                        Dim tamaño As Integer = fieldTP(j).Tamaño
                        If fieldTP(j).NombreFML Is Nothing Then
                            mTP.Add(String.Format("{0}* DOCFLD : {1} {2}", Space(6), metodos.TrimChr(fieldTP(j).Etiqueta), fieldTP(j).NombreJava))
                        Else
                            mTP.Add(String.Format("{0}* DOCFLD : {1} {2} {3}", Space(6), metodos.TrimChr(fieldTP(j).Etiqueta), fieldTP(j).NombreFML, fieldTP(j).NombreJava))
                        End If
                        If pant.Index > 0 And fieldTP(j).indice > 0 Then
                            If mAtributos Or item.Atributos Then
                                mTP.Add(String.Format("{0}09 TP-{1}-{2}-{3}-ATR{4}PIC X(00001).", Space(20), name, int.ToString("00"), fieldTP(j).NombreCobol, Space(22 - Len(fieldTP(j).NombreCobol))))
                                iLarge -= fieldTP(j).indice * pant.Index
                            End If
                            mTP.Add(String.Format("{0}09 TP-{1}-{2}-{3}PIC X({4}).", Space(20), name, int.ToString("00"), fieldTP(j).NombreCobol.ToString.PadRight(26), tamaño.ToString("00000")))
                            If Not fieldTP(j).DescripcionNumerica Is Nothing Then
                                mTP.Add(String.Format("{0}09 TP-{1}-{2}-{3}-R REDEFINES", Space(20), name, int.ToString("00"), fieldTP(j).NombreCobol))
                                mTP.Add(String.Format("{0}TP-{1}-{2}-{3}.", Space(23), name, int.ToString("00"), fieldTP(j).NombreCobol))
                                Dim inicio As Integer
                                Dim largo As Integer
                                Dim sSigno As Char
                                Dim sEntero As String
                                Dim sDecimal As String
                                inicio = fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(",")
                                largo = (fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(")")) - (inicio + 1)
                                sSigno = fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                                inicio = fieldTP(j).DescripcionNumerica.ToString.IndexOf("(")
                                largo = (fieldTP(j).DescripcionNumerica.ToString.IndexOf(",")) - (inicio + 1)
                                sEntero = CType(fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo), Integer).ToString("00")
                                inicio = fieldTP(j).DescripcionNumerica.ToString.IndexOf(",")
                                largo = (fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(",")) - (inicio + 1)
                                sDecimal = CType(fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo), Integer).ToString("00")
                                Dim compl As Integer = tamaño - (CType(sDecimal, Integer) + CType(sEntero, Integer))
                                If compl > 0 Then
                                    mTP.Add(String.Format("{0}11 TP-{1}-{2}-{3}-CPL{4}PIC X({5}).", Space(23), name, int.ToString("00"), fieldTP(j).NombreCobol, Space(2), compl.ToString("00000")))
                                End If
                                mTP.Add(String.Format("{0}11 TP-{1}-{2}-{3}-NUM", Space(23), name, int.ToString("00"), fieldTP(j).NombreCobol))
                                If sSigno = "N" Then
                                    sSigno = " "
                                End If
                                If CType(sDecimal, Integer) > 0 Then
                                    mTP.Add(String.Format("{0}PIC {2}9({1})V9({3}).", Space(26), sEntero, sSigno, sDecimal))
                                Else
                                    mTP.Add(String.Format("{0}PIC {2}9({1}).", Space(26), sEntero, sSigno))
                                End If
                            End If
                            iLarge -= (tamaño * pant.Index) * fieldTP(j).indice
                        ElseIf pant.Index > 0 Or fieldTP(j).indice > 0 Then
                            If mAtributos Or item.Atributos Then
                                mTP.Add(String.Format("{0}07 TP-{1}-{2}-{3}-ATR{4}PIC X(00001).", Space(17), name, int.ToString("00"), fieldTP(j).NombreCobol, Space(25 - Len(fieldTP(j).NombreCobol))))
                                If pant.Index > 0 Then
                                    iLarge -= pant.Index
                                Else
                                    iLarge -= fieldTP(j).indice
                                End If
                            End If
                            mTP.Add(String.Format("{0}07 TP-{1}-{2}-{3}PIC X({4}).", Space(17), name, int.ToString("00"), fieldTP(j).NombreCobol.ToString.PadRight(29), tamaño.ToString("00000")))
                            If Not fieldTP(j).DescripcionNumerica Is Nothing Then
                                mTP.Add(String.Format("{0}07 TP-{1}-{2}-{3}-R REDEFINES", Space(17), name, int.ToString("00"), fieldTP(j).NombreCobol))
                                mTP.Add(String.Format("{0}TP-{1}-{2}-{3}.", Space(20), name, int.ToString("00"), fieldTP(j).NombreCobol))
                                Dim inicio As Integer
                                Dim largo As Integer
                                Dim sSigno As Char
                                Dim sEntero As String
                                Dim sDecimal As String
                                inicio = fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(",")
                                largo = (fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(")")) - (inicio + 1)
                                sSigno = fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                                inicio = fieldTP(j).DescripcionNumerica.ToString.IndexOf("(")
                                largo = (fieldTP(j).DescripcionNumerica.ToString.IndexOf(",")) - (inicio + 1)
                                sEntero = CType(fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo), Integer).ToString("00")
                                inicio = fieldTP(j).DescripcionNumerica.ToString.IndexOf(",")
                                largo = (fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(",")) - (inicio + 1)
                                sDecimal = CType(fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo), Integer).ToString("00")
                                Dim compl As Integer = tamaño - (CType(sDecimal, Integer) + CType(sEntero, Integer))
                                If compl > 0 Then
                                    mTP.Add(String.Format("{0}09 TP-{1}-{2}-{3}-CPL{4}PIC X({5}).", Space(20), name, int.ToString("00"), fieldTP(j).NombreCobol, Space(2), compl.ToString("00000")))
                                End If
                                mTP.Add(String.Format("{0}09 TP-{1}-{2}-{3}-NUM", Space(20), name, int.ToString("00"), fieldTP(j).NombreCobol))
                                If sSigno = "N" Then
                                    sSigno = " "
                                End If
                                If CType(sDecimal, Integer) > 0 Then
                                    mTP.Add(String.Format("{0}PIC {2}9({1})V9({3}).", Space(23), sEntero, sSigno, sDecimal))
                                Else
                                    mTP.Add(String.Format("{0}PIC {2}9({1}).", Space(23), sEntero, sSigno))
                                End If
                            End If
                            If pant.Index > 0 Then
                                iLarge -= (tamaño * pant.Index)
                            Else
                                iLarge -= (tamaño * fieldTP(j).indice)
                            End If
                        Else
                            If mAtributos Or item.Atributos Then
                                mTP.Add(String.Format("{0}05 TP-{1}-{2}-{3}-ATR{4}PIC X(00001).", Space(14), name, int.ToString("00"), fieldTP(j).NombreCobol, Space(16)))
                                iLarge -= 1
                            End If
                            mTP.Add(String.Format("{0}05 TP-{1}-{2}-{3}PIC X({4}).", Space(14), name, int.ToString("00"), fieldTP(j).NombreCobol.ToString.PadRight(32), tamaño.ToString("00000")))
                            If Not fieldTP(j).DescripcionNumerica Is Nothing Then
                                mTP.Add(String.Format("{0}05 TP-{1}-{2}-{3}-R REDEFINES", Space(14), name, int.ToString("00"), fieldTP(j).NombreCobol))
                                mTP.Add(String.Format("{0}TP-{1}-{2}-{3}.", Space(17), name, int.ToString("00"), fieldTP(j).NombreCobol))
                                Dim inicio As Integer
                                Dim largo As Integer
                                Dim sSigno As Char
                                Dim sEntero As String
                                Dim sDecimal As String
                                inicio = fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(",")
                                largo = (fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(")")) - (inicio + 1)
                                sSigno = fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                                inicio = fieldTP(j).DescripcionNumerica.ToString.IndexOf("(")
                                largo = (fieldTP(j).DescripcionNumerica.ToString.IndexOf(",")) - (inicio + 1)
                                sEntero = CType(fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo), Integer).ToString("00")
                                inicio = fieldTP(j).DescripcionNumerica.ToString.IndexOf(",")
                                largo = (fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(",")) - (inicio + 1)
                                sDecimal = CType(fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo), Integer).ToString("00")
                                Dim compl As Integer = tamaño - (CType(sDecimal, Integer) + CType(sEntero, Integer))
                                If compl > 0 Then
                                    mTP.Add(String.Format("{0}07 TP-{1}-{2}-{3}-CPL{4}PIC X({5}).", Space(17), name, int.ToString("00"), fieldTP(j).NombreCobol, Space(2), compl.ToString("00000")))
                                End If
                                mTP.Add(String.Format("{0}07 TP-{1}-{2}-{3}-NUM", Space(17), name, int.ToString("00"), fieldTP(j).NombreCobol))
                                If sSigno = "N" Then
                                    sSigno = " "
                                End If
                                If CType(sDecimal, Integer) > 0 Then
                                    mTP.Add(String.Format("{0}PIC {2}9({1})V9({3}).", Space(20), sEntero, sSigno, sDecimal))
                                Else
                                    mTP.Add(String.Format("{0}PIC {2}9({1}).", Space(20), sEntero, sSigno))
                                End If
                            End If
                            iLarge -= tamaño
                        End If
                        j += 1
                    End While
                End If
                int += 1
            End While
            If greenBool Then
                mTP.Add(String.Format("{0}03 TP-{1}-FRM-GLS-DISP{2}PIC X({3}).", Space(11), name, Space(26), iLarge.ToString("00000")))
            Else
                mTP.Add(String.Format("{0}05 TP-{1}-FRM-GLS-DISP{2}PIC X({3}).", Space(14), name, Space(23), iLarge.ToString("00000")))
            End If
            mTP.Add(String.Format("{0}*", Space(6)))
            mTP.Add(String.Format("{0}*", Space(6)))
        End Sub
        Private Sub GeneraTP_v2A(item As ServiciosRequerimiento)
            Dim name As String = metodos.TrimChr(item.Nombre)
            mMsgService = New EstructuraJSON.ServiceMessage
            mMsgService.Servicio = "TP-" & name
            mMsgService.Descripcion = metodos.TrimChr(item.Descripcion)
            mMsgService.ServicioTuxedo = item.MetodoJava
            mMsgService.Data = New Collection()
            ' Agrega campo estado
            mMsgCampos = New EstructuraJSON.Campos()
            mMsgCampos.NombreCobol = String.Format("TP-{0}-STAT", name)
            mMsgCampos.Etiqueta = "Estado"
            mMsgCampos.Largo = "1"
            mMsgService.Data.Add(mMsgCampos)
            ' Agrega campo mensaje
            mMsgCampos = New EstructuraJSON.Campos()
            mMsgCampos.NombreCobol = String.Format("TP-{0}-MENS", name)
            mMsgCampos.Etiqueta = "Mensaje"
            mMsgCampos.Largo = "79"
            mMsgService.Data.Add(mMsgCampos)

            Dim iLarge As Integer = mLargoSnd - 80
            Dim int As Integer = 1
            Dim countIndex As Integer = 0
            Dim greenBool As Boolean = False
            While item.TP.Count >= int
                Dim pant As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq = item.TP(int)
                Dim fieldTP As New ArrayList()
                'Dim sIns As String = "+++"
                'Dim sCom As String = "..."
                'If int <= item.Transaccional.Count Then
                '    If Not item.Transaccional(int) Is Nothing Then
                '        sIns = item.Transaccional(int).Instancia
                '        sCom = metodos.TrimChr(item.Transaccional(int).Comando)
                '    End If
                'End If
                'mTP.Add(String.Format("{0}*>> {1}-{2}-{3}-{4} ({5})", Space(6), mSistema, pant.Pantalla, sCom, sIns, pant.Server))
                fieldTP = metodos.getCamposForEdition(pant.Pantalla, pant.Server, mPantallas)
                Dim j As Integer = 0
                Dim interOcc As Boolean = False
                If Not (fieldTP Is Nothing) Then
                    'If pant.Index > 0 Then
                    '    mTP.Add(String.Format("{0}05 TP-{1}-DMSG-IDX-1-{2} OCCURS {3} TIMES.", Space(14), name, int.ToString("00"), pant.Index))
                    'End If
                    While j < fieldTP.Count
                        greenBool = True
                        If fieldTP(j).indice > 0 Then
                            interOcc = True
                            countIndex += 1
                        Else
                            interOcc = False
                            countIndex = 0
                        End If
                        'If j < 1 And fieldTP(j).indice > 0 Then
                        '    mTP.Add(String.Format("{0}07 TP-{1}-FLD-HST OCCURS {3} TIMES.", Space(17), name, int.ToString("00"), fieldTP(j).indice))
                        'ElseIf countIndex = 1 And pant.Index < 1 And j > 1 Then
                        '    mTP.Add(String.Format("{0}05 TP-{1}-FLD-HST OCCURS {3} TIMES.", Space(14), name, int.ToString("00"), fieldTP(j).indice))
                        'End If
                        Dim tamaño As Integer = fieldTP(j).Tamaño
                        If pant.Index > 0 And fieldTP(j).indice > 0 Then
                            If mAtributos Or item.Atributos Then
                                ' Agrega Campos para estructura JSON Atributo
                                mMsgCampos = New EstructuraJSON.Campos()
                                mMsgCampos.NombreCobol = String.Format("TP-{0}-{1}-{2}-ATR", name, int.ToString("00"), fieldTP(j).NombreCobol)
                                mMsgCampos.Etiqueta = metodos.TrimChr(fieldTP(j).Etiqueta)
                                mMsgCampos.nombreTux = fieldTP(j).NombreFML
                                mMsgCampos.NombreJava = fieldTP(j).NombreJava
                                mMsgCampos.Largo = "1"
                                mMsgService.Data.Add(mMsgCampos)

                                iLarge -= fieldTP(j).indice * pant.Index
                            End If
                            ' Agrega Campos para estructura JSON Cobol
                            mMsgCampos = New EstructuraJSON.Campos()
                            mMsgCampos.NombreCobol = String.Format("TP-{0}-{1}-{2}", name, int.ToString("00"), fieldTP(j).NombreCobol)
                            mMsgCampos.Etiqueta = metodos.TrimChr(fieldTP(j).Etiqueta)
                            mMsgCampos.nombreTux = fieldTP(j).NombreFML
                            mMsgCampos.NombreJava = fieldTP(j).NombreJava
                            mMsgCampos.Largo = tamaño
                            mMsgService.Data.Add(mMsgCampos)

                            iLarge -= (tamaño * pant.Index) * fieldTP(j).indice
                        ElseIf pant.Index > 0 Or fieldTP(j).indice > 0 Then
                            If mAtributos Or item.Atributos Then
                                ' Agrega Campos para estructura JSON Atributo
                                mMsgCampos = New EstructuraJSON.Campos()
                                mMsgCampos.NombreCobol = String.Format("TP-{0}-{1}-{2}-ATR", name, int.ToString("00"), fieldTP(j).NombreCobol)
                                mMsgCampos.Etiqueta = metodos.TrimChr(fieldTP(j).Etiqueta)
                                mMsgCampos.nombreTux = fieldTP(j).NombreFML
                                mMsgCampos.NombreJava = fieldTP(j).NombreJava
                                mMsgCampos.Largo = "1"
                                mMsgService.Data.Add(mMsgCampos)

                                If pant.Index > 0 Then
                                    iLarge -= pant.Index
                                Else
                                    iLarge -= fieldTP(j).indice
                                End If
                            End If
                            ' Agrega Campos para estructura JSON Cobol
                            mMsgCampos = New EstructuraJSON.Campos()
                            mMsgCampos.NombreCobol = String.Format("TP-{0}-{1}-{2}", name, int.ToString("00"), fieldTP(j).NombreCobol)
                            mMsgCampos.Etiqueta = metodos.TrimChr(fieldTP(j).Etiqueta)
                            mMsgCampos.nombreTux = fieldTP(j).NombreFML
                            mMsgCampos.NombreJava = fieldTP(j).NombreJava
                            mMsgCampos.Largo = tamaño
                            mMsgService.Data.Add(mMsgCampos)
                        End If
                        If pant.Index > 0 Then
                            iLarge -= (tamaño * pant.Index)
                        Else
                            iLarge -= (tamaño * fieldTP(j).indice)
                        End If
                        If mAtributos Or item.Atributos Then
                            ' Agrega Campos para estructura JSON Atributo
                            mMsgCampos = New EstructuraJSON.Campos()
                            mMsgCampos.NombreCobol = String.Format("TP-{0}-{1}-{2}-ATR", name, int.ToString("00"), fieldTP(j).NombreCobol)
                            mMsgCampos.Etiqueta = metodos.TrimChr(fieldTP(j).Etiqueta)
                            mMsgCampos.nombreTux = fieldTP(j).NombreFML
                            mMsgCampos.NombreJava = fieldTP(j).NombreJava
                            mMsgCampos.Largo = "1"
                            mMsgService.Data.Add(mMsgCampos)

                            iLarge -= 1
                        End If
                        ' Agrega Campos para estructura JSON Cobol
                        mMsgCampos = New EstructuraJSON.Campos()
                        mMsgCampos.NombreCobol = String.Format("TP-{0}-{1}-{2}", name, int.ToString("00"), fieldTP(j).NombreCobol)
                        mMsgCampos.Etiqueta = metodos.TrimChr(fieldTP(j).Etiqueta)
                        mMsgCampos.nombreTux = fieldTP(j).NombreFML
                        mMsgCampos.NombreJava = fieldTP(j).NombreJava
                        mMsgCampos.Largo = tamaño
                        mMsgService.Data.Add(mMsgCampos)

                        iLarge -= tamaño
                j += 1
            End While
                End If
                int += 1
            End While
            mServicioColeccion.Add(mMsgService)
        End Sub
        Private Sub GeneraTX(item As ServiciosRequerimiento)
            Dim name As String = metodos.TrimChr(item.Nombre)
            mTX.Add(String.Format("{0}*  =========================== TX-{1} ===========================", Space(6), name))
            mTX.Add(String.Format("{0}*", Space(6)))
            mTX.Add(String.Format("{0}* DOCSER {1} : {2}", Space(6), name, metodos.TrimChr(item.Descripcion)))
            mTX.Add(String.Format("{0}* DOCXML {1} : {2}", Space(6), name, item.MetodoJava))
            mTX.Add(String.Format("{0}01 TX-{1} REDEFINES WSS-SND.", Space(7), name))
            mTX.Add(String.Format("{0}03 TX-{1}-AHDR{2}PIC X(00100).", Space(11), name, Space(34)))
            mTX.Add(String.Format("{0}03 TX-{1}-DMSG.", Space(11), name))
            Dim iLarge As Integer = mLargoSnd - 100
            Dim int As Integer = 1
            Dim countIndex As Integer = 0
            Dim greenBool As Boolean = False
            While item.TX.Count >= int
                Dim pant As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq = item.TX(int)
                Dim fieldTX As New ArrayList()
                Dim sIns As String = "+++"
                Dim sCom As String = "..."
                If int <= item.Transaccional.Count Then
                    If Not item.Transaccional(int) Is Nothing Then
                        sIns = item.Transaccional(int).Instancia
                        sCom = metodos.TrimChr(item.Transaccional(int).Comando)
                    End If
                    mTX.Add(String.Format("{0}*>> {1}-{2}-{3}-{4} ({5})", Space(6), mSistema, pant.Pantalla, sCom, sIns, pant.Server))
                    fieldTX = metodos.getCamposForEdition(pant.Pantalla, pant.Server, mPantallas)
                    Dim j As Integer = 0
                    Dim interOcc As Boolean = False
                    If pant.Index > 0 Then
                        If Not greenBool Then
                            mTX.Add(String.Format("{0}05 TX-{1}-DMSG-IDX-1-{2} OCCURS {3} TIMES.", Space(14), name, int.ToString("00"), pant.Index))
                        End If
                        mTX.Add(String.Format("{0}07 TX-{1}-{2}-SIST-{3}{4}PIC X(00003).", Space(17), name, int.ToString("00"), sIns, Space(21)))
                        mTX.Add(String.Format("{0}07 TX-{1}-{2}-NEMO-{3}{4}PIC X(00012).", Space(17), name, int.ToString("00"), sIns, Space(21)))
                        mTX.Add(String.Format("{0}07 TX-{1}-{2}-FINP-{3}{4}PIC X(00003).", Space(17), name, int.ToString("00"), sIns, Space(21)))
                        mTX.Add(String.Format("{0}07 TX-{1}-{2}-FOUT-{3}{4}PIC X(00003).", Space(17), name, int.ToString("00"), sIns, Space(21)))
                        iLarge -= 21 * pant.Index
                        If pant.Server <> "907" Then
                            mTX.Add(String.Format("{0}07 TX-{1}-{2}-DMSG-{3}.", Space(17), name, int.ToString("00"), sIns))
                        End If
                    Else
                        mTX.Add(String.Format("{0}05 TX-{1}-{2}-SIST-{3}{4}PIC X(00003).", Space(14), name, int.ToString("00"), sIns, Space(24)))
                        mTX.Add(String.Format("{0}05 TX-{1}-{2}-NEMO-{3}{4}PIC X(00012).", Space(14), name, int.ToString("00"), sIns, Space(24)))
                        mTX.Add(String.Format("{0}05 TX-{1}-{2}-FINP-{3}{4}PIC X(00003).", Space(14), name, int.ToString("00"), sIns, Space(24)))
                        mTX.Add(String.Format("{0}05 TX-{1}-{2}-FOUT-{3}{4}PIC X(00003).", Space(14), name, int.ToString("00"), sIns, Space(24)))
                        iLarge -= 21
                        If pant.Server <> "907" Then
                            mTX.Add(String.Format("{0}05 TX-{1}-{2}-DMSG-{3}.", Space(14), name, int.ToString("00"), sIns))
                            ''ElseIf j > 1 Then
                            'mTX.Add(String.Format("{0}05 TX-{1}-{2}-DMSG-{3}.", Space(14), name, int.ToString("00"), sIns))
                        End If
                    End If
                    If Not (fieldTX Is Nothing) Then
                        While j < fieldTX.Count
                            greenBool = True
                            If fieldTX(j).indice > 0 Then
                                interOcc = True
                                countIndex += 1
                            Else
                                interOcc = False
                                countIndex = 0
                            End If
                            If j < 1 AndAlso (fieldTX(j).indice > 0) Then
                                mTX.Add(String.Format("{0}07 TX-{1}-FLD-HST OCCURS {2} TIMES.", Space(14), name, fieldTX(j).indice))
                            ElseIf countIndex = 1 And pant.Index < 1 And j > 1 Then
                                mTX.Add(String.Format("{0}07 TX-{1}-{2}-FLD-HST OCCURS {3} TIMES.", Space(14), name, int.ToString("00"), fieldTX(j).indice))
                            End If
                            If fieldTX(j).NombreFML Is Nothing Then
                                mTX.Add(String.Format("{0}* DOCFLD : {1} {2}", Space(6), metodos.TrimChr(fieldTX(j).Etiqueta), fieldTX(j).NombreJava))
                            Else
                                mTX.Add(String.Format("{0}* DOCFLD : {1} {2} {3}", Space(6), metodos.TrimChr(fieldTX(j).Etiqueta), fieldTX(j).NombreFML, fieldTX(j).NombreJava))
                            End If
                            Dim tamaño As Integer = fieldTX(j).Tamaño
                            If pant.Index > 0 And fieldTX(j).indice > 0 Then
                                mTX.Add(String.Format("{0}11 TX-{1}-{2}-{3}{4}PIC X({5}).", Space(23), name, int.ToString("00"), fieldTX(j).NombreCobol, Space(11), tamaño.ToString("00000")))
                                iLarge -= (tamaño * pant.Index) * fieldTX(j).indice
                            ElseIf pant.Index > 0 Or fieldTX(j).indice > 0 Then
                                mTX.Add(String.Format("{0}09 TX-{1}-{2}-{3}{4}PIC X({5}).", Space(20), name, int.ToString("00"), fieldTX(j).NombreCobol, Space(14), tamaño.ToString("00000")))
                                If pant.Index > 0 Then
                                    iLarge -= (tamaño * pant.Index)
                                Else
                                    iLarge -= (tamaño * fieldTX(j).indice)
                                End If
                            Else
                                mTX.Add(String.Format("{0}07 TX-{1}-{2}-{3}PIC X({4}).", Space(17), name, int.ToString("00"), fieldTX(j).NombreCobol.ToString.PadRight(29), tamaño.ToString("00000")))
                                iLarge -= tamaño
                            End If
                            j += 1
                        End While
                    End If
                End If
                int += 1
            End While
            If greenBool Then
                mTX.Add(String.Format("{0}03 TX-{1}-FRM-GLS-DISP{2}PIC X({3}).", Space(11), name, Space(26), iLarge.ToString("00000")))
            Else
                mTX.Add(String.Format("{0}05 TX-{1}-FRM-GLS-DISP{2}PIC X({3}).", Space(14), name, Space(23), iLarge.ToString("00000")))
            End If
            mTX.Add(String.Format("{0}*", Space(6)))
            mTX.Add(String.Format("{0}* FORMATO PTATX", Space(6)))
            mTX.Add(String.Format("{0}*", Space(6)))
        End Sub
    End Class
    Public Class ModeloModulosWS3
        Implements IModulos
        Private mLinea As String
        Private mWriteLine As Collection = New Collection()
        Private mLrgXT As Collection = New Collection()
        Private mLrgTP As Collection = New Collection()
        Private mNumTP As Collection = New Collection()
        Private mNumPT As Collection = New Collection()
        Private mNemo As Collection = New Collection()
        Private mServicios As Collection
        Private mPantallas As Collection
        Private mSistema As String
        Private mAtributos As Boolean
        Private mFirst As Boolean = True
        Dim metodos As New MetodosAuxiliares
        Public ReadOnly Property LineaWrite As Collection
            Get
                Return mWriteLine
            End Get
        End Property
        Public Sub New(service As Collection, form As Collection, cabecera As CabeceraMtx)
            mWriteLine = New Collection()
            mServicios = service
            mPantallas = form
            mAtributos = cabecera.Atributos
            mSistema = cabecera.Sistema
            If metodos.TrimChr(cabecera.IndicadorPrimerArchivo) = "S" Then
                mFirst = True
            Else
                mFirst = False
            End If
        End Sub
        Private Sub WriteLine(linea As String)
            mWriteLine.Add(linea)
        End Sub
        Private Sub WriteLine()
            mWriteLine.Add("")
        End Sub
        Public Function Contextualizar() As Microsoft.VisualBasic.Collection Implements IModulos.Contextualizar
            WriteLine(String.Format("{0}01 TPG-LRG-XT-{1}.", Space(7), mSistema))
            For Each item As Cimagroup.Generador2012.GeneradorBussinesObject.ServiciosRequerimiento In mServicios
                GeneraLargoXT(item)
                GeneraLargoTP(item)
                GeneraNemo(item)
                GeneraNumeroPT(item)
                GeneraNumeroTP(item)
            Next
            For Each line As String In mLrgXT
                WriteLine(line)
            Next
            WriteLine()
            WriteLine(String.Format("{0}01 TPG-LRG-NVL-{1}.", Space(7), mSistema))
            For Each line As String In mLrgTP
                WriteLine(line)
            Next
            WriteLine()
            If mFirst Then
                WriteLine(String.Format("{0}01 WSS-COD-CREQ{1}VALUE SPACES{2}PIC X(03).", Space(7), Space(7), Space(4)))
                WriteLine(String.Format("{0}01 WSS-GNS-TVB.", Space(7), Space(7), Space(4)))
                WriteLine(String.Format("{0}03 TPG-I{1}VALUE ZEROES{2}PIC 9(05).", Space(10), Space(11), Space(4)))
                WriteLine(String.Format("{0}03 TPG-J{1}VALUE ZEROES{2}PIC 9(05).", Space(10), Space(11), Space(4)))
                WriteLine(String.Format("{0}03 TPG-K{1}VALUE ZEROES{2}PIC 9(05).", Space(10), Space(11), Space(4)))
                WriteLine(String.Format("{0}03 TPG-L{1}VALUE ZEROES{2}PIC 9(05).", Space(10), Space(11), Space(4)))
                WriteLine(String.Format("{0}03 TPG-M{1}VALUE ZEROES{2}PIC 9(05).", Space(10), Space(11), Space(4)))
                WriteLine(String.Format("{0}03 TPG-N{1}VALUE ZEROES{2}PIC 9(05).", Space(10), Space(11), Space(4)))
                WriteLine()
            End If
            For Each line As String In mNemo
                WriteLine(line)
            Next
            For Each line As String In mNumPT
                WriteLine(line)
            Next
            ' ********
            For Each line As String In mNumTP
                WriteLine(line)
            Next
            Return mWriteLine
        End Function
        Private Sub GeneraLargoXT(item As ServiciosRequerimiento)
            Dim name As String = metodos.TrimChr(item.Nombre)
            Dim iLarge As Integer = 0
            Dim int As Integer = 1
            While item.XT.Count >= int
                Dim pant As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq = item.XT(int)
                Dim fieldXT As New ArrayList()
                fieldXT = metodos.getCamposForEdition(pant.Pantalla, pant.Server, mPantallas)
                Dim j As Integer = 0
                If Not (fieldXT Is Nothing) Then
                    While j < fieldXT.Count
                        If pant.Index > 0 And fieldXT(j).indice > 0 Then
                            If item.Atributos Or mAtributos Then
                                iLarge += pant.Index * fieldXT(j).indice
                            End If
                            iLarge += fieldXT(j).Tamaño * pant.Index * fieldXT(j).indice
                        ElseIf pant.Index > 0 Or fieldXT(j).indice > 0 Then
                            If pant.Index > 0 Then
                                If item.Atributos Or mAtributos Then
                                    iLarge += pant.Index
                                End If
                                iLarge += fieldXT(j).Tamaño * pant.Index
                            Else
                                If item.Atributos Or mAtributos Then
                                    iLarge += fieldXT(j).indice
                                End If
                                iLarge += fieldXT(j).Tamaño * fieldXT(j).indice
                            End If
                        Else
                            If item.Atributos Or mAtributos Then
                                iLarge += 1
                            End If
                            iLarge += fieldXT(j).Tamaño
                        End If
                        j += 1
                    End While
                End If
                int += 1
            End While
            If item.XT.Count = 0 Then
                mLrgXT.Add(String.Format("{0}03 TPG-LRG-XT-{1}{2}VALUE 00000 PIC 9(05).", Space(10), name, Space(5)))
            Else
                mLrgXT.Add(String.Format("{0}03 TPG-LRG-XT-{1}{2}VALUE {3} PIC 9(05).", Space(10), name, Space(5), iLarge.ToString("00000")))
            End If
        End Sub
        Private Sub GeneraLargoTP(item As ServiciosRequerimiento)
            Dim name As String = metodos.TrimChr(item.Nombre)
            Dim iLarge As Integer = 0
            Dim int As Integer = 1
            While item.TP.Count >= int
                Dim pant As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq = item.TP(int)
                Dim fieldTP As New ArrayList()
                fieldTP = metodos.getCamposForEdition(pant.Pantalla, pant.Server, mPantallas)
                Dim j As Integer = 0
                If Not (fieldTP Is Nothing) Then
                    While j < fieldTP.Count
                        If pant.Index > 0 And fieldTP(j).Indice > 0 Then
                            If item.Atributos Or mAtributos Then
                                iLarge += fieldTP(j).indice * pant.Index
                            End If
                            iLarge += fieldTP(j).Tamaño * pant.Index * fieldTP(j).indice
                        ElseIf fieldTP(j).Indice > 0 Or pant.Index > 0 Then
                            If pant.Index > 0 Then
                                If item.Atributos Or mAtributos Then
                                    iLarge += pant.Index
                                End If
                                iLarge += fieldTP(j).Tamaño * pant.Index
                            ElseIf fieldTP(j).Indice > 0 Then
                                If item.Atributos Or mAtributos Then
                                    iLarge += fieldTP(j).indice
                                End If
                                iLarge += fieldTP(j).Tamaño * fieldTP(j).Indice
                            End If
                        Else
                            If item.Atributos Or mAtributos Then
                                iLarge += 1
                            End If
                            iLarge += fieldTP(j).Tamaño
                        End If
                        j += 1
                    End While
                End If
                int += 1
            End While
            If item.TP.Count = 0 Then
                mLrgTP.Add(String.Format("{0}03 TPG-LRG-TP-{1}{2}VALUE 00000 PIC 9(05).", Space(10), name, Space(5)))
            Else
                mLrgTP.Add(String.Format("{0}03 TPG-LRG-TP-{1}{2}VALUE {3} PIC 9(05).", Space(10), name, Space(5), iLarge.ToString("00000")))
            End If
        End Sub
        Private Sub GeneraNemo(item As ServiciosRequerimiento)
            Dim name As String = metodos.TrimChr(item.Nombre)
            Dim int As Integer = 1
            While item.TX.Count >= int
                If item.Transaccional.Count >= int Then
                    If Not item.Transaccional(int) Is Nothing Then
                        ' Dim inst As String = item.Transaccional(int).Instancia.ToString.Trim(Chr(34))
                        Dim inst As String = metodos.TrimChr(item.Transaccional(int).Instancia)
                        Dim sCom As String = metodos.TrimChr(item.Transaccional(int).Comando)
                        Dim sPan As String = metodos.TrimChr(item.Transaccional(int).Pantalla)
                        Dim Fout As String = metodos.TrimChr(item.Transaccional(int).FormOut)
                        Dim sInm As String = metodos.TrimChr(item.Transaccional(int).Inmando)
                        Dim nemo As String = ""
                        'Debug.Print(sPan & " " & sInm & " " & sCom)
                        If sInm.Trim() = "" Then
                            nemo = String.Format("{0}{1}{2}{3}", mSistema, sPan, sCom, inst)
                        Else
                            nemo = String.Format("{0}{1}{2}{3}", mSistema, sPan, sCom, sInm)
                        End If
                        'Debug.Print(nemo)
                        If Fout = "" Then
                            Fout = Space(3)
                        End If
                        mNemo.Add(String.Format("{0}03 WSS-{1}-{2}-SIST-{3} PIC X(03) VALUE '{4}'.", Space(10), name, int.ToString("00"), inst, mSistema))
                        mNemo.Add(String.Format("{0}03 WSS-{1}-{2}-NEMO-{3} PIC X(12) VALUE '{4}'.", Space(10), name, int.ToString("00"), inst, nemo))
                        mNemo.Add(String.Format("{0}03 WSS-{1}-{2}-FINP-{3} PIC X(03) VALUE '{4}'.", Space(10), name, int.ToString("00"), inst, metodos.TrimChr(item.Transaccional(int).FormIn)))
                        mNemo.Add(String.Format("{0}03 WSS-{1}-{2}-FOUT-{3} PIC X(03) VALUE '{4}'.", Space(10), name, int.ToString("00"), inst, Fout))
                        mNemo.Add("")
                    End If
                End If
                int += 1
            End While
        End Sub
        Private Sub GeneraNumeroPT(item As ServiciosRequerimiento)
            Dim name As String = metodos.TrimChr(item.Nombre)
            Dim iLarge As Integer
            Dim int As Integer = 1
            While item.PT.Count >= int
                Dim pant As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq = item.PT(int)
                Dim fieldPT As New ArrayList()
                fieldPT = metodos.getCamposForEdition(pant.Pantalla, pant.Server, mPantallas)
                Dim j As Integer = 0
                If Not (fieldPT Is Nothing) Then
                    While j < fieldPT.Count
                        If Not fieldPT(j).DescripcionNumerica Is Nothing Then
                            Dim zNumber As String = ""
                            Dim inicio As Integer
                            Dim largo As Integer
                            Dim sEntero As String
                            Dim sDecimal As String
                            inicio = fieldPT(j).DescripcionNumerica.ToString.IndexOf("(")
                            largo = (fieldPT(j).DescripcionNumerica.ToString.IndexOf(",")) - (inicio + 1)
                            sEntero = fieldPT(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                            inicio = fieldPT(j).DescripcionNumerica.ToString.IndexOf(",")
                            largo = (fieldPT(j).DescripcionNumerica.ToString.LastIndexOf(",")) - (inicio + 1)
                            sDecimal = fieldPT(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                            For i As Integer = 1 To CType(sEntero, Integer)
                                zNumber += "Z"
                            Next
                            If CType(sDecimal, Integer) > 0 Then
                                zNumber += ","
                                For i As Integer = 1 To CType(sDecimal, Integer)
                                    zNumber += "Z"
                                Next
                            End If
                            mNumPT.Add(String.Format("{0}77 PT-{1}-{2}-{3}-EDT PIC {4}.", Space(7), name, int.ToString("00"), fieldPT(j).NombreCobol, zNumber))
                        End If
                        iLarge -= fieldPT(j).Tamaño
                        j += 1
                    End While
                End If
                int += 1
            End While
        End Sub
        Private Sub GeneraNumeroTP(item As ServiciosRequerimiento)
            Dim name As String = metodos.TrimChr(item.Nombre)
            Dim iLarge As Integer
            Dim int As Integer = 1
            While item.TP.Count >= int
                Dim pant As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq = item.TP(int)
                Dim fieldTP As New ArrayList()
                fieldTP = metodos.getCamposForEdition(pant.Pantalla, pant.Server, mPantallas)
                Dim j As Integer = 0
                If Not (fieldTP Is Nothing) Then
                    While j < fieldTP.Count
                        If Not fieldTP(j).DescripcionNumerica Is Nothing Then
                            Dim zNumber As String = ""
                            Dim inicio As Integer
                            Dim largo As Integer
                            Dim sEntero As String
                            Dim sDecimal As String
                            inicio = fieldTP(j).DescripcionNumerica.ToString.IndexOf("(")
                            largo = (fieldTP(j).DescripcionNumerica.ToString.IndexOf(",")) - (inicio + 1)
                            sEntero = fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                            inicio = fieldTP(j).DescripcionNumerica.ToString.IndexOf(",")
                            largo = (fieldTP(j).DescripcionNumerica.ToString.LastIndexOf(",")) - (inicio + 1)
                            sDecimal = fieldTP(j).DescripcionNumerica.ToString.Substring(inicio + 1, largo)
                            For i As Integer = 1 To CType(sEntero, Integer)
                                zNumber += "Z"
                            Next
                            If CType(sDecimal, Integer) > 0 Then
                                zNumber += ","
                                For i As Integer = 1 To CType(sDecimal, Integer)
                                    zNumber += "Z"
                                Next
                            End If
                            mNumTP.Add(String.Format("{0}77 TP-{1}-{2}-{3}-EDT PIC {4}.", Space(7), name, int.ToString("00"), fieldTP(j).NombreCobol, zNumber))
                        End If
                        iLarge -= fieldTP(j).Tamaño
                        j += 1
                    End While
                End If
                int += 1
            End While
        End Sub
    End Class
    Public Class ModeloModuloTPG
        Implements IModulos
        Private mLinea As String
        Private mWriteLine As Collection = New Collection()
        Private mServicios As Collection
        Private mPantallas As Collection
        Private mSistema As String
        Private mArchivo As String
        Private mTag As String
        Private mTagDesc As String
        Private mTimestamp As String
        Public ReadOnly Property LineaWrite As Collection
            Get
                Return mWriteLine
            End Get
        End Property
        Private Sub WriteLine(linea As String)
            mWriteLine.Add(linea)
        End Sub
        Private Sub WriteLine()
            mWriteLine.Add("")
        End Sub
        Public Sub New(service As Collection, form As Collection, cabecera As CabeceraMtx, file As String)
            mWriteLine = New Collection()
            mServicios = service
            mPantallas = form
            mSistema = cabecera.Sistema
            mTag = cabecera.Tag
            mTagDesc = cabecera.DescripcionTag
            mTimestamp = cabecera.Timestamp
            mArchivo = file
        End Sub
        Public Function Contextualizar() As Microsoft.VisualBasic.Collection Implements IModulos.Contextualizar
            WriteLine(String.Format("{0}IDENTIFICATION DIVISION.", Space(7)))
            WriteLine(String.Format("{0}*========================", Space(6)))
            WriteLine(String.Format("{0}PROGRAM-ID. {1}.", Space(7), mArchivo))
            WriteLine(String.Format("{0}AUTHOR. BEETEAM.", Space(7)))
            WriteLine(String.Format("{0}DATE-WRITTEN. {1}.", Space(7), DateTime.Now.ToString))
            WriteLine(String.Format("{0}* PROGRAMA TRADUCTOR DEL SISTEMA {1}", Space(6), mSistema))
            WriteLine(String.Format("{0}*", Space(6)))
            WriteLine(String.Format("{0}*========================================================", Space(6)))
            WriteLine(String.Format("{0}* Fecha Mantencion : {1}", Space(6), DateTime.Now.ToString))
            WriteLine(String.Format("{0}* Tag : {1}", Space(6), mTag))
            WriteLine(String.Format("{0}* Detalle Mantencion: {1}", Space(6), mTagDesc))
            WriteLine(String.Format("{0}*========================================================", Space(6)))
            WriteLine(String.Format("{0}*", Space(6)))
            WriteLine(String.Format("{0}ENVIRONMENT DIVISION.", Space(7)))
            WriteLine(String.Format("{0}CONFIGURATION SECTION.", Space(7)))
            WriteLine(String.Format("{0}*----------------------", Space(6)))
            WriteLine(String.Format("{0}SPECIAL-NAMES.", Space(7)))
            WriteLine(String.Format("{0}DECIMAL-POINT IS COMMA.", Space(15)))
            WriteLine(String.Format("{0}DATA DIVISION.", Space(7)))
            WriteLine()
            WriteLine(String.Format("{0}WORKING-STORAGE SECTION.", Space(7)))
            WriteLine(String.Format("{0}*------------------------", Space(6)))

            WriteLine(String.Format("{0}77 WSS-TAG-{1}{2}PIC X(0125) VALUE", Space(7), mArchivo, Space(11)))
            WriteLine(String.Format("{0}'<IDNMOD NOM=${1}$ VSN=${2}$ GEN=${3}", Space(11), mArchivo, Environment.Version, Date.Now.ToShortDateString))
            WriteLine(String.Format("{0}-{1}'TMS=${2}$ FNC=${3}$/>'.", Space(6), Space(4), mTimestamp.Substring(1, mTimestamp.Length - 2), mTag.Substring(1, mTag.Length - 2)))
            WriteLine(String.Format("{0}*", Space(6)))

            Dim wrSection As Collection = New Collection()
            Dim pant As New List(Of String)
            Dim serv As New ArrayList()
            For Each item As ServiciosRequerimiento In mServicios
                Dim int As Integer = 1
                Dim bln As Boolean = True
                serv.Add(item.Nombre)
                While (item.TP.Count >= int)
                    Dim pantTP As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq = item.TP(int)
                    If pantTP.Index > 0 And Not pant.Contains(pantTP.Pantalla) Then
                        pant.Add(pantTP.Pantalla)
                        SectionOccurs(wrSection, item)
                        bln = False
                    End If
                    int += 1
                End While
                If bln And item.PT.Count > 0 Then
                    SectionNormal(wrSection, item)
                End If
            Next
            pant.Sort()
            For Each item As String In pant
                WriteLine(String.Format("{0}COPY {2}WX{1}.", Space(7), item, mSistema))
            Next
            WriteLine()
            WriteLine(String.Format("{0}LINKAGE SECTION.", Space(7)))
            WriteLine(String.Format("{0}*----------------", Space(6)))
            WriteLine(String.Format("{0}01 DFHCOMMAREA.", Space(7)))
            WriteLine(String.Format("{0}02 FILLER{1}PIC X(06).", Space(11), Space(34)))
            WriteLine(String.Format("{0}COPY GNSLGFIO.", Space(7)))
            WriteLine("")
            WriteLine(String.Format("{0}PROCEDURE DIVISION.", Space(7)))
            WriteLine(String.Format("{0}*===================", Space(6)))
            WriteLine(String.Format("{0}MAIN SECTION.", Space(7)))
            WriteLine(String.Format("{0}INI-MAIN.", Space(7)))
            WriteLine(String.Format("{0}COPY GNSBGEDB.", Space(7)))
            WriteLine(String.Format("{0}PERFORM LEE-DATA-COM.", Space(11)))
            WriteLine(String.Format("{0}* RECIBO IDENTIFICACION DEL PC QUE ENVIO EL MSG.", Space(6)))
            WriteLine(String.Format("{0}MOVE DFHCOMMAREA(1:EIBCALEN) TO SCR-NOM-TCPIP.", Space(11)))
            WriteLine(String.Format("{0}MOVE +1025   TO SEG-LEN-TSSEG.", Space(11)))
            WriteLine(String.Format("{0}MOVE +9000   TO TDI-LTDI.", Space(11)))
            WriteLine(String.Format("{0}MOVE +9000   TO TDO-LTDO.", Space(11)))
            WriteLine(String.Format("{0}PERFORM GET-TSK-TERM.", Space(11)))
            WriteLine()
            For Each item As String In pant
                WriteLine(String.Format("{0}MOVE TSK-TERM-ALF TO {1}-COD-TERM.", Space(11), item))
                WriteLine(String.Format("{0}MOVE TSK-TERM-ALF TO {1}-COD-TERM-MAS.", Space(11), item))
            Next
            WriteLine()
            WriteLine(String.Format("{0}MOVE SPACES{1}TO WSS-RCV.", Space(11), Space(7)))
            WriteLine(String.Format("{0}MOVE SPACES{1}TO WSS-SND.", Space(11), Space(7)))
            WriteLine(String.Format("{0}PERFORM GNS-ERR-QUE.", Space(11)))
            WriteLine(String.Format("{0}MOVE SCR-NOM-TCPIP TO WSS-PTR-COD-TYPE.", Space(11)))
            WriteLine()
            WriteLine(String.Format("{0}MOVE 9 TO SEG-MAX-ELEM.", Space(11)))
            WriteLine(String.Format("{0}LUP-SEG-LOG.", Space(7)))
            WriteLine(String.Format("{0}PERFORM PROCESO-LEE-TS.", Space(11)))
            WriteLine(String.Format("{0}IF NOT '1' = WSS-SND-STAT", Space(11)))
            WriteLine(String.Format("{0}PERFORM PRO-REQ", Space(14)))
            WriteLine(String.Format("{0}ELSE", Space(11)))
            WriteLine(String.Format("{0}MOVE SPACES TO WSS-SND-DAT", Space(14)))
            WriteLine(String.Format("{0}PERFORM SND-TS-MSSG", Space(14)))
            WriteLine(String.Format("{0}GO TO FIN-MAIN.", Space(14)))
            WriteLine(String.Format("{0}IF VUELVE-LEER-TS", Space(11)))
            WriteLine(String.Format("{0}GO TO LUP-SEG-LOG.", Space(14)))
            WriteLine(String.Format("{0}PERFORM SND-TS-MSSG.", Space(11)))
            WriteLine(String.Format("{0}GO TO FIN-MAIN.", Space(11)))
            WriteLine(String.Format("{0}FIN-MAIN.", Space(7)))
            WriteLine(String.Format("{0}PERFORM ELI-TS-ALL.", Space(11)))
            WriteLine(String.Format("{0}EXEC CICS RETURN END-EXEC.", Space(11)))
            WriteLine(String.Format("{0}EXT-MAIN.", Space(7)))
            WriteLine(String.Format("{0}EXIT.", Space(11)))
            WriteLine()
            WriteLine(String.Format("{0}LEE-DATA-COM SECTION.", Space(7)))
            WriteLine(String.Format("{0}INI-LEE-DATA-COM.", Space(7)))
            WriteLine(String.Format("{0}MOVE 'GNS'{1}TO SCR-SIST.", Space(11), Space(6)))
            WriteLine(String.Format("{0}MOVE '{1}' TO IDD-PROG FIO-PROG.", Space(11), mArchivo))
            WriteLine(String.Format("{0}MOVE IDD-VARI{1}TO SYS-CMMA.", Space(11), Space(3)))
            WriteLine(String.Format("{0}MOVE +507{1}TO SYS-TCMA.", Space(11), Space(7)))
            WriteLine(String.Format("{0}MOVE 'GNSPPIDD' TO SYS-PROG.", Space(11)))
            WriteLine(String.Format("{0}MOVE SYS-LINK{1}TO SYS-CMND.", Space(11), Space(3)))
            WriteLine(String.Format("{0}PERFORM GNS-PRO-SYS.", Space(11)))
            WriteLine(String.Format("{0}MOVE SYS-CMMA{1}TO IDD-VARI.", Space(11), Space(3)))
            WriteLine(String.Format("{0}FIN-LEE-DATA-COM.", Space(7)))
            WriteLine(String.Format("{0}EXIT.", Space(11)))
            WriteLine()
            WriteLine(String.Format("{0}PRO-BYA SECTION.", Space(7)))
            WriteLine(String.Format("{0}INI-PRO-BYA.", Space(7)))
            WriteLine(String.Format("{0}IF WSS-PRG-MLTY = 'N'", Space(11)))
            WriteLine(String.Format("{0}MOVE TSK-TERM-ALF  TO QUE-TERM", Space(14)))
            WriteLine(String.Format("{0}MOVE PTC-IBYA-TYPE TO QUE-TYPE", Space(14)))
            WriteLine(String.Format("{0}MOVE QUE-DEL       TO QUE-CMND", Space(14)))
            WriteLine(String.Format("{0}PERFORM GNS-PRO-QUE", Space(14)))
            WriteLine(String.Format("{0}MOVE PTC-IBYA-LENG TO QUE-LITM", Space(14)))
            WriteLine(String.Format("{0}MOVE QUE-PUT       TO QUE-CMND", Space(14)))
            WriteLine(String.Format("{0}MOVE 'S' TO QUE-ITEM", Space(14)))
            WriteLine(String.Format("{0}PERFORM GNS-PRO-QUE", Space(14)))
            WriteLine(String.Format("{0}ELSE", Space(11)))
            WriteLine(String.Format("{0}MOVE 'S' TO WSS-HDR-IBYA.", Space(14)))
            WriteLine(String.Format("{0}FIN-PRO-BYA.", Space(7)))
            WriteLine(String.Format("{0}EXIT.", Space(11)))
            WriteLine()
            WriteLine(String.Format("{0}PRO-REQ SECTION.", Space(7)))
            WriteLine(String.Format("{0}INI-PRO-REQ.", Space(7)))
            WriteLine(String.Format("{0}MOVE WSS-RCV-CREQ TO WSS-COD-CREQ.", Space(11)))
            WriteLine(String.Format("{0}MOVE WSS-RCV-HDR  TO WSS-HDR.", Space(11)))
            WriteLine(String.Format("{0}MOVE WSS-RCV-CREQ TO WSS-COD-CREQ.", Space(11)))
            WriteLine(String.Format("{0}MOVE WSS-RCV-CREQ TO WSS-SND-MENS-A.", Space(11)))

            For Each elem In serv
                Dim metodos As New MetodosAuxiliares
                WriteLine(String.Format("{0}IF WSS-COD-CREQ = '{1}'", Space(11), metodos.TrimChr(elem)))
                WriteLine(String.Format("{0}PERFORM PRO-REQ-{1}", Space(14), metodos.TrimChr(elem)))
                WriteLine(String.Format("{0}ELSE", Space(11)))
            Next
            WriteLine(String.Format("{0}* Error en Requerimiento.", Space(6)))
            WriteLine(String.Format("{0}MOVE SPACES TO WSS-SND", Space(14)))
            WriteLine(String.Format("{0}MOVE '1' TO WSS-SND-STAT", Space(14)))
            WriteLine(String.Format("{0}MOVE 'ERROR EN CODIGO DE REQUERIMIENTO' TO WSS-SND-MENS.", Space(14)))
            WriteLine(String.Format("{0}PERFORM PRO-CNAL-OUT.", Space(11)))
            WriteLine(String.Format("{0}FIN-PRO-REQ.", Space(7)))
            WriteLine(String.Format("{0}EXIT.", Space(11)))
                WriteLine()
                For Each element In wrSection
                    WriteLine(element)
                Next
                Return mWriteLine
        End Function
        Private Sub SectionNormal(wrLinea As Collection, service As ServiciosRequerimiento)
            Dim metodos As New MetodosAuxiliares
            Dim servicio As String = metodos.TrimChr(service.Nombre)
            wrLinea.Add(String.Format("{0}PRO-REQ-{1} SECTION.", Space(7), servicio))
            wrLinea.Add(String.Format("{0}INI-PRO-REQ-{1}.", Space(7), servicio))
            wrLinea.Add(String.Format("{0}* {1}", Space(6), service.Descripcion))
            wrLinea.Add(String.Format("{0}PERFORM PRO-BYA.", Space(11)))
            wrLinea.Add(String.Format("{0}PERFORM EDT-NUM-PT-REQ-{1}.", Space(11), servicio))
            Dim int As Integer = 1
            While service.PT.Count >= int - 1
                wrLinea.Add(String.Format("{0}PERFORM MOV-GNS-{1}-{2}.", Space(11), servicio, int.ToString("00")))
                wrLinea.Add(String.Format("{0}PERFORM MOV-PT-TX-{1}-{2}.", Space(11), servicio, int.ToString("00")))
                int += 1
            End While
            wrLinea.Add("")
            wrLinea.Add(String.Format("{0}PERFORM PUT-TDI.", Space(11)))
            wrLinea.Add(String.Format("{0}PERFORM LNK-MTI.", Space(11)))
            wrLinea.Add(String.Format("{0}PERFORM GET-TDO.", Space(11)))
            wrLinea.Add("")
            wrLinea.Add(String.Format("{0}IF TDO-COD-STAT NOT = '0'", Space(11)))
            wrLinea.Add(String.Format("{0}GO TO FIN-PRO-REQ-{1}.", Space(14), servicio))
            wrLinea.Add("")
            int = 1
            While service.TP.Count >= int
                wrLinea.Add(String.Format("{0}PERFORM MOV-XT-TP-{1}-{2}.", Space(11), servicio, int.ToString("00")))
                int += 1
            End While
            wrLinea.Add(String.Format("{0}PERFORM VAL-NUM-TP-REQ-{1}.", Space(11), servicio))
            wrLinea.Add(String.Format("{0}FIN-PRO-REQ-{1}.", Space(7), servicio))
            wrLinea.Add(String.Format("{0}EXIT.", Space(11)))
            wrLinea.Add("")
        End Sub
        Private Sub SectionOccurs(wrLinea As Collection, service As ServiciosRequerimiento)
            Dim metodos As New MetodosAuxiliares
            Dim servicio As String = metodos.TrimChr(service.Nombre)
            Dim pant As Cimagroup.Generador2012.GeneradorBussinesObject.StructureReq
            Dim nombrePant As String = ""
            Dim int As Integer = 0
            While service.TP.Count >= int
                If int > 0 Then
                    pant = service.TP(int)
                    If pant.Index > 0 Then
                        nombrePant = pant.Pantalla
                    End If
                End If
                int += 1
            End While
            wrLinea.Add(String.Format("{0}PRO-REQ-{1} SECTION.", Space(7), servicio))
            wrLinea.Add(String.Format("{0}INI-PRO-REQ-{1}.", Space(7), servicio))
            wrLinea.Add(String.Format("{0}* {1}", Space(6), service.Descripcion))

            wrLinea.Add(String.Format("{0}MOVE 'S' TO WSS-PRG-MLTY.", Space(11), servicio))
            wrLinea.Add(String.Format("{0}PERFORM PRO-BYA.", Space(11), servicio))
            wrLinea.Add(String.Format("{0}PERFORM DEL-QUE-{1}.", Space(11), nombrePant))
            wrLinea.Add(String.Format("{0}PERFORM EDT-NUM-PT-REQ-{1}.", Space(11), servicio))
            int = 1
            While service.PT.Count >= int
                wrLinea.Add(String.Format("{0}PERFORM MOV-GNS-{1}-{2}.", Space(11), servicio, int.ToString("00")))
                wrLinea.Add(String.Format("{0}PERFORM MOV-PT-TX-{1}-{2}.", Space(11), servicio, int.ToString("00")))
                int += 1
            End While

            wrLinea.Add("")
            wrLinea.Add(String.Format("{0}PERFORM PUT-TDI.", Space(11)))
            wrLinea.Add(String.Format("{0}PERFORM LNK-MTD.", Space(11)))
            wrLinea.Add(String.Format("{0}PERFORM GET-TDO.", Space(11)))
            wrLinea.Add("")
            wrLinea.Add(String.Format("{0}IF TDO-COD-STAT NOT = '0'", Space(11), servicio))
            wrLinea.Add(String.Format("{0}GO TO FIN-PRO-REQ-{1}.", Space(14), servicio))
            wrLinea.Add("")
            int = 1
            While service.TP.Count >= int
                wrLinea.Add(String.Format("{0}PERFORM MOV-XT-TP-{1}-{2}.", Space(11), servicio, int.ToString("00")))
                int += 1
            End While
            wrLinea.Add(String.Format("{0}MOVE 1                 TO QUE-NITM.", Space(11), servicio))
            wrLinea.Add(String.Format("{0}MOVE {1}-LEN-TS{1}-MAS TO QUE-LITM.", Space(11), nombrePant))
            wrLinea.Add(String.Format("{0}MOVE {1}-TS{1}-MAS     TO QUE-COLA.", Space(11), nombrePant))
            wrLinea.Add(String.Format("{0}MOVE QUE-GET           TO QUE-CMND.", Space(11)))
            wrLinea.Add(String.Format("{0}PERFORM GNS-PRO-QUE.", Space(11)))
            wrLinea.Add(String.Format("{0}IF QUE-STAT = QUE-STAT-OKS", Space(11), servicio))
            wrLinea.Add(String.Format("{0}MOVE QUE-ITEM TO {1}-MAS-ITEM", Space(14), nombrePant))
            wrLinea.Add(String.Format("{0}MOVE {2}-MAS-IND-HMAS TO TP-{1}-02-DAS-IND-HMAS", Space(14), servicio, nombrePant))
            wrLinea.Add(String.Format("{0}MOVE {2}-MAS-NUM-TOCC TO TP-{1}-02-DAS-NUM-TOCC.", Space(14), servicio, nombrePant))
            wrLinea.Add(String.Format("{0}MOVE ZEROES TO QUE-NITM.", Space(11)))
            wrLinea.Add(String.Format("{0}MOVE ZEROES TO TPG-J.", Space(11)))
            wrLinea.Add(String.Format("{0}MOVE ZEROES TO TPG-I.", Space(11)))
            wrLinea.Add(String.Format("{0}CIC-GET-{1}.", Space(7), nombrePant))
            wrLinea.Add(String.Format("{0}ADD 1 TO QUE-NITM.", Space(11)))
            wrLinea.Add(String.Format("{0}MOVE {1}-LEN-TS{1} TO QUE-LITM.", Space(11), nombrePant))
            wrLinea.Add(String.Format("{0}MOVE {1}-TS{1}     TO QUE-COLA.", Space(11), nombrePant))
            wrLinea.Add(String.Format("{0}MOVE QUE-GET       TO QUE-CMND.", Space(11)))
            wrLinea.Add(String.Format("{0}PERFORM GNS-PRO-QUE.", Space(11), servicio))
            wrLinea.Add(String.Format("{0}IF QUE-STAT = QUE-STAT-OKS", Space(11), servicio))
            wrLinea.Add(String.Format("{0}MOVE QUE-ITEM   TO TP-{1}-DMSG-IDX-1-03(QUE-NITM)", Space(14), servicio))
            wrLinea.Add(String.Format("{0}GO TO CIC-GET-{1}.", Space(14), nombrePant))
            wrLinea.Add("")
            wrLinea.Add(String.Format("{0}PERFORM VAL-NUM-TP-REQ-{1}.", Space(11), servicio))
            wrLinea.Add(String.Format("{0}PERFORM DEL-QUE-{1}.", Space(11), nombrePant))
            wrLinea.Add(String.Format("{0}PERFORM CLN-NUM-{1} VARYING TPG-L", Space(11), servicio))
            wrLinea.Add(String.Format("{0}FROM 1 BY 1 UNTIL TPG-L > 50.", Space(19), servicio))
            wrLinea.Add(String.Format("{0}FIN-PRO-REQ-{1}.", Space(7), servicio))
            wrLinea.Add(String.Format("{0}EXIT.", Space(11), servicio))
            wrLinea.Add("")
            wrLinea.Add(String.Format("{0}CLN-NUM-{1} SECTION.", Space(7), servicio))
            wrLinea.Add(String.Format("{0}INI-CLN-NUM-{1}.", Space(7), servicio))
            wrLinea.Add(String.Format("{0}IF TP-{1}-03-FRM-XXX-XXXX(TPG-L) NOT > ZEROES", Space(11), servicio))
            wrLinea.Add(String.Format("{0}MOVE SPACES TO TP-{1}-DMSG-IDX-1-03(TPG-L).", Space(14), servicio))
            wrLinea.Add(String.Format("{0}FIN-CLN-NUM-{1}.", Space(7), servicio))
            wrLinea.Add(String.Format("{0}EXIT.", Space(11), servicio))
            wrLinea.Add("")
            wrLinea.Add(String.Format("{0}DEL-QUE-{1} SECTION.", Space(7), nombrePant))
            wrLinea.Add(String.Format("{0}INI-DEL-QUE-{1}.", Space(7), nombrePant))
            wrLinea.Add(String.Format("{0}MOVE {1}-NOM-TS{1}     TO QUE-COLA.", Space(11), nombrePant))
            wrLinea.Add(String.Format("{0}MOVE QUE-DEL           TO QUE-CMND.", Space(11)))
            wrLinea.Add(String.Format("{0}PERFORM GNS-PRO-QUE.", Space(11)))
            wrLinea.Add("")
            wrLinea.Add(String.Format("{0}MOVE {1}-NOM-TS{1}-MAS TO QUE-COLA.", Space(11), nombrePant))
            wrLinea.Add(String.Format("{0}MOVE QUE-DEL           TO QUE-CMND.", Space(11)))
            wrLinea.Add(String.Format("{0}PERFORM GNS-PRO-QUE.", Space(11)))
            wrLinea.Add(String.Format("{0}FIN-DEL-QUE-{1}.", Space(7), nombrePant))
            wrLinea.Add(String.Format("{0}EXIT.", Space(11)))
            wrLinea.Add("")
        End Sub
    End Class
    Public MustInherit Class ModulosBase
        Protected Friend mLineaFinal As String = ""
        Protected Friend mStreamWrite As Collection
        Protected Friend mCabecera As CabeceraMtx
        Protected Friend mServicios As Collection
        Protected Friend mPantallas As Collection
        Protected Friend mArchivoFuente As String
        Protected Friend archivo As String = ""
        Private mModelo As IModulos
        Private mHeader As IHeader
        Private mMetodos As MetodosAuxiliares
        Friend mRuta As String
        Public ReadOnly Property ArchivoGenerado As String
            Get
                Return archivo
            End Get
        End Property
        Public WriteOnly Property Cabecera As CabeceraMtx
            Set(value As CabeceraMtx)
                mCabecera = value
            End Set
        End Property
        Public WriteOnly Property Servicios As Collection
            Set(value As Collection)
                mServicios = value
            End Set
        End Property
        Public WriteOnly Property Pantallas As Collection
            Set(value As Collection)
                mPantallas = value
            End Set
        End Property
        Public WriteOnly Property ArchivoFuente As String
            Set(value As String)
                mArchivoFuente = value
            End Set
        End Property
        Public Property ModeloModulo As IModulos
            Get
                Return mModelo
            End Get
            Set(value As IModulos)
                mModelo = value
            End Set
        End Property
        Public Property Header As IHeader
            Get
                Return mHeader
            End Get
            Set(value As IHeader)
                mHeader = value
            End Set
        End Property
        Public Property Ruta As String
            Get
                Return mRuta
            End Get
            Set(value As String)
                mRuta = value
            End Set
        End Property
        Public Sub New()
            mStreamWrite = New Collection()
        End Sub
        Public MustOverride Sub Generar()
        Private Sub Contextualizar()
            mModelo.Contextualizar()
        End Sub
        Private Sub GeneradorHeader(archivo As String)

        End Sub
    End Class
    Public Class MetodosAuxiliares
        Public Function getCamposForEdition(pant As String, server As String, pantallas As Collection) As ArrayList
            For Each item As Cimagroup.Generador2012.GeneradorBussinesObject.Form In pantallas
                If item.Host.Nombre = pant Then
                    Select Case server
                        Case "901"
                            Dim campos As New ArrayList()
                            For Each fld As Cimagroup.Generador2012.GeneradorBussinesObject.Campo In item.Host.Campos
                                If fld.TipoAcceso = "IKY" Then
                                    campos.Add(fld)
                                End If
                            Next
                            Return campos
                        Case "903"
                            Dim campos As New ArrayList()
                            For Each fld As Cimagroup.Generador2012.GeneradorBussinesObject.Campo In item.Host.Campos
                                If fld.TipoAcceso = "FLD" Or fld.TipoAcceso = "MKY" Then
                                    campos.Add(fld)
                                End If
                            Next
                            Return campos
                        Case "904"
                            Dim campos As New ArrayList()
                            For Each fld As Cimagroup.Generador2012.GeneradorBussinesObject.Campo In item.Host.Campos
                                If fld.TipoAcceso = "IKY" Or fld.TipoAcceso = "AKY" Or fld.TipoAcceso = "MKY" Or fld.TipoAcceso = "FLD" Then
                                    campos.Add(fld)
                                End If
                            Next
                            Return campos
                        Case "905"
                            Dim campos As New ArrayList()
                            For Each fld As Cimagroup.Generador2012.GeneradorBussinesObject.Campo In item.Host.Campos
                                If fld.TipoAcceso = "IKY" Or fld.TipoAcceso = "AKY" Or fld.TipoAcceso = "MKY" Then
                                    campos.Add(fld)
                                End If
                            Next
                            Return campos
                        Case Else
                            For Each srv As Cimagroup.Generador2012.GeneradorBussinesObject.Server In item.Server
                                If srv.Nombre = server Then
                                    Dim campos As ArrayList = New ArrayList()
                                    For Each field As String In srv.Campos
                                        For Each fld As Cimagroup.Generador2012.GeneradorBussinesObject.Campo In item.Host.Campos
                                            If field = fld.NombreCobol Then
                                                '   fld.Indice = srv.Indice
                                                campos.Add(fld)
                                            End If
                                        Next
                                    Next
                                    Return campos
                                End If
                            Next
                    End Select
                End If
            Next
            Return Nothing
        End Function
        Public Function TrimChr(strValue As String) As String
            If strValue Is Nothing Then
                strValue = ""
            End If
            Dim trimed As String = strValue
            If strValue.LastIndexOf(Chr(34)) > 0 Then
                trimed = strValue.Trim(Chr(34))
            End If
            Return trimed
        End Function
    End Class
#End Region
End Namespace
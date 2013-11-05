Imports System.IO
Imports System.Xml
Imports System.Xml.Schema
Imports System.Text
Imports Cimagroup.Generador2012
Imports Cimagroup.Generador2012.AnalizadorLexico
Imports Cimagroup.Generador2012.GeneradorBussinesObject
Namespace Cimagroup.Generador2012.GeneradorModulosPruebas
    Public Class GeneradorModulosPruebas
        Inherits Cimagroup.Generador2012.GeneradorBussinesLogic.ModulosBase
        Public Overrides Sub Generar()
            'archivo = String.Format("{0}{1}PD1", mCabecera.Sistema, mCabecera.NemotecnicoFile)
            'Header = New HeaderModulosPD(mCabecera.Tag, mCabecera.Timestamp, mArchivoFuente)
            'ModeloModulo = New ModeloModulosPD1(mServicios, mPantallas)
            'Dim WriterMX As StreamWriter
            'WriterMX = New StreamWriter(String.Format("{1}{0}.cbl", archivo, mRuta))
            'mStreamWrite = Header.GeneradorHeader(archivo)
            'For Each linea As String In mStreamWrite
            '    WriterMX.WriteLine(linea)
            'Next
            'mStreamWrite = New Collection()
            'mStreamWrite = ModeloModulo.Contextualizar()
            'For Each linea As String In mStreamWrite
            '    WriterMX.WriteLine(linea)
            'Next
            'WriterMX.Close()
        End Sub
    End Class
    Public Class xmlTestService

    End Class
    Public Class xmlTestServiceHeader
        Implements Cimagroup.Generador2012.GeneradorBussinesLogic.IModulos
        Private mLinea As String
        Private mWriteLine As Collection = New Collection()
        Private mServicios As Collection
        Private mPantallas As Collection
        Public Sub New()

        End Sub
        Public Function Contextualizar() As Microsoft.VisualBasic.Collection Implements GeneradorBussinesLogic.IModulos.Contextualizar
            Dim metodos As New Cimagroup.Generador2012.GeneradorBussinesLogic.MetodosAuxiliares
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
                        '   WriteLine()
                    End If
                    int += 1
                End While
            Next
            Return mWriteLine
        End Function
    End Class
    Public Class UnitTest
        Private mNombreCobol As String
        Private mNombreJava As String
        Private mDescripcion As String
        Private mLargo As Integer
        Private mEstado As Boolean = False
        Public Property NombreCobol As String
            Get
                Return mNombreCobol
            End Get
            Set(value As String)
                mNombreCobol = value
            End Set
        End Property
        Public Property NombreJava As String
            Get
                Return mNombreJava
            End Get
            Set(value As String)
                mNombreJava = value
            End Set
        End Property
        Public Property Descripcion As String
            Get
                Return mDescripcion
            End Get
            Set(value As String)
                mDescripcion = value
            End Set
        End Property
        Public Property Largo As Integer
            Get
                Return mLargo
            End Get
            Set(value As Integer)
                mLargo = value
            End Set
        End Property
        Public ReadOnly Property Estado As Boolean
            Get
                Return mEstado
            End Get
        End Property
        Public Sub New()
            mLargo = 0
        End Sub
        Public Sub New(cobol As String, java As String, desc As String, large As Integer)
            mNombreCobol = cobol
            mNombreJava = java
            mDescripcion = desc
            mLargo = large
        End Sub
        Public Sub Generar()
            Try
                ' Se definen los elementos
                Dim cobolElement As XmlSchemaElement = New XmlSchemaElement()
                cobolElement.Name = mNombreCobol
                ' se definen los atributos
                Dim javaAttribute As XmlSchemaAttribute = New XmlSchemaAttribute()
                javaAttribute.Name = mNombreJava
                Dim descAttribute As XmlSchemaAttribute = New XmlSchemaAttribute()
                descAttribute.Name = mDescripcion
                Dim largeAttribute As XmlSchemaAttribute = New XmlSchemaAttribute()
                largeAttribute.Name = mLargo
                ' Se definen los tipos especiales
                Dim largoType As XmlSchemaSimpleType = New XmlSchemaSimpleType()
                largoType.Name = "largoTipo"
                Dim largoRestriccion As XmlSchemaSimpleTypeRestriction = New XmlSchemaSimpleTypeRestriction()
                largoRestriccion.BaseTypeName = New XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema")
                Dim maxlenght As XmlSchemaMaxLengthFacet = New XmlSchemaMaxLengthFacet()
                maxlenght.Value = mLargo
                largoRestriccion.Facets.Add(maxlenght)
                largoType.Content = largoRestriccion
                ' Asociar tipos a los elementos
                cobolElement.SchemaTypeName = New XmlQualifiedName("largoType", "http://www.w3.org/2001/XMLSchema")
                largeAttribute.SchemaTypeName = New XmlQualifiedName("positiveInteger", "http://www.w3.org/2001/XMLSchema")
                ' Define nodo raiz
                Dim campoElement As XmlSchemaElement = New XmlSchemaElement()
                campoElement.Name = "Entrada"
                ' Creacion del tipo complejo del nodo raiz
                Dim campoElementType As XmlSchemaComplexType = New XmlSchemaComplexType()
                Dim secuencia As XmlSchemaSequence = New XmlSchemaSequence()
                secuencia.Items.Add(cobolElement)
                campoElementType.Particle = secuencia
                campoElement.SchemaType = campoElementType
                ' crear esquema
                Dim unitTestSchema As XmlSchema = New XmlSchema()
                unitTestSchema.TargetNamespace = "http//www.tempuri.org"
                unitTestSchema.Items.Add(campoElement)
                unitTestSchema.Items.Add(largoType)
                ' Compila schema
                Dim schemaSet As XmlSchemaSet = New XmlSchemaSet()
                AddHandler schemaSet.ValidationEventHandler, AddressOf ValidationCallback
                schemaSet.Add(unitTestSchema)
                schemaSet.Compile()
                mEstado = True
                For Each Schema As XmlSchema In schemaSet.Schemas()
                    unitTestSchema = Schema
                Next
                Dim file As System.IO.FileStream = New System.IO.FileStream("C:\1_Paso\Generador2012\log\schema.xsd", IO.FileMode.Create, IO.FileAccess.ReadWrite)
                Dim xstream As XmlTextWriter = New XmlTextWriter(file, New UTF8Encoding())
                xstream.Formatting = Formatting.Indented
                unitTestSchema.Write(xstream)
            Catch ex As Exception
                mEstado = False
            End Try
        End Sub
        Public Sub ValidationCallback(sender As Object, args As ValidationEventArgs)
            mEstado = False
            If args.Severity = XmlSeverityType.Warning Then
                Debug.Print("WARNING: ")
            Else
                If args.Severity = XmlSeverityType.Error Then
                    Debug.Print("ERROR :")
                End If
            End If
            Debug.Print(args.Message)
        End Sub
    End Class
#Region "Unidades de Prueba"
    Public Class GeneradorModulosPruebasPrex
        Inherits Cimagroup.Generador2012.GeneradorBussinesLogic.ModulosBase
        Public Overrides Sub Generar()
            archivo = String.Format("{0}{1}TEST", mCabecera.Sistema, mCabecera.NemotecnicoFile)
            Header = New HeaderModulosTEST(mCabecera.Tag, mCabecera.Timestamp, mArchivoFuente)
            ModeloModulo = New ModeloModulosTEST(mServicios, mPantallas, mCabecera)
            Dim WriterMX As StreamWriter
            WriterMX = New StreamWriter(String.Format("{1}{0}.txt", archivo, mRuta))
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
#End Region
#Region "Clases de Apoyo a Estructuras de Prueba"
    Public Class HeaderModulosTEST
        Implements Cimagroup.Generador2012.GeneradorBussinesLogic.IHeader
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
            Dim metodos As New Cimagroup.Generador2012.GeneradorBussinesLogic.MetodosAuxiliares()
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
        Public Function GeneradorHeader(archivo As String) As Collection Implements Cimagroup.Generador2012.GeneradorBussinesLogic.IHeader.GeneradorHeader
            WriteLine(String.Format("{0}*{1}{2}", Space(6), Space(4), Date.Now.ToLocalTime))
            WriteLine(String.Format("{0}*{1}{2}", Space(6), Space(4), mFilesource))
            WriteLine(String.Format("{0}*{1}USUARIO = {2}", Space(6), Space(4), Environment.UserName))
            WriteLine(String.Format("{0}*", Space(6)))
            WriteLine(String.Format("{0}*", Space(6)))
            WriteLine()
            Return mWriteLine
        End Function
    End Class
    Public Class ModeloModulosTEST
        Implements Cimagroup.Generador2012.GeneradorBussinesLogic.IModulos
        Private mLinea As String
        Private mWriteLine As Collection = New Collection()
        Private mPT As Collection = New Collection()
        Private mTP As Collection = New Collection()
        Private mServicios As Collection
        Private mPantallas As Collection
        Private mSistema As String
        Private mLargoRcv As Integer
        Private mAtributos As Boolean
        Private mFirst As Boolean = True
        Private mPrefijo As Char = "G"
        Dim metodos As New Cimagroup.Generador2012.GeneradorBussinesLogic.MetodosAuxiliares
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
            'If String.IsNullOrEmpty(cabecera.PrefijoTrans.ToString) Then
            '    mPrefijo = CChar(cabecera.PrefijoTrans)
            'End If
            mPrefijo = mSistema.Substring(0, 1)
        End Sub
        Private Sub WriteLine(linea As String)
            mWriteLine.Add(linea)
        End Sub
        Private Sub WriteLine()
            mWriteLine.Add("")
        End Sub
        Public Function Contextualizar() As Microsoft.VisualBasic.Collection Implements Cimagroup.Generador2012.GeneradorBussinesLogic.IModulos.Contextualizar
            For Each item As Cimagroup.Generador2012.GeneradorBussinesObject.ServiciosRequerimiento In mServicios
                GeneraPT(item)
            Next
            For Each line As String In mPT
                WriteLine(line)
            Next
            Return mWriteLine
        End Function
        Private Sub GeneraPT(item As ServiciosRequerimiento)
            Dim name As String = metodos.TrimChr(item.Nombre)
            Dim comhdr As String = "    CIMWEBBCI              000001X"
            Dim hdr As String = "HV01BCIBCIBEEESCL" & Space(30) & mSistema.ToUpper() & "PPTPGS"
            mPT.Add(String.Format("{0}*  =========================== TEST-{1} ===========================", Space(0), name))
            mPT.Add(String.Format("{0}* DOCSER {1} : {2}", Space(0), name, metodos.TrimChr(item.Descripcion)))
            mPT.Add(String.Format("{0}* DOCXML {1} : {2}", Space(0), name, item.MetodoJava))
            mPT.Add(String.Format("{0}DHCOMM-{1}{2}X(00038) = '{3}'", Space(0), name, Space(80), String.Format("{0}{1}{2}", mPrefijo, name, comhdr).ToString.PadRight(38)))
            mPT.Add(String.Format("{0}HEADER-{1}{2}X(00100) = '{3}'", Space(0), name, Space(80), hdr.ToString.PadRight(100)))
            mPT.Add(String.Format("{0}TRNREQ-{1}{2}X(00003) = '{1}'", Space(0), name, Space(80)))
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
                mPT.Add(String.Format("{0}*>> {1}-{2}-{3}-{4} ({5})", Space(0), mSistema, pant.Pantalla, sCom, sIns, pant.Server))
                fieldPT = metodos.getCamposForEdition(pant.Pantalla, pant.Server, mPantallas)
                Dim j As Integer = 0
                Dim interOcc As Boolean = False
                If Not (fieldPT Is Nothing) Then
                    If pant.Index > 0 Then
                        mPT.Add(String.Format("{0}{1}-IDX-1-{2} OCCURS {3} TIMES.", Space(0), name, int.ToString("00"), pant.Index))
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
                            mPT.Add(String.Format("{0}{1}-{2}-FLD-HST OCCURS {3} TIMES.", Space(0), name, int.ToString("00"), fieldPT(j).indice))
                        ElseIf countIndex = 1 And pant.Index < 1 And j > 1 Then
                            mPT.Add(String.Format("{0}{1}-{2}-FLD-HST OCCURS {3} TIMES.", Space(0), name, int.ToString("00"), fieldPT(j).indice))
                        End If
                        Dim Tamaño As Integer = fieldPT(j).Tamaño
                        If fieldPT(j).NombreJava Is Nothing Then
                            fieldPT(j).NombreJava = ""
                        End If
                        If fieldPT(j).NombreFML Is Nothing Then
                            fieldPT(j).NombreFML = ""
                        End If
                        If pant.Index > 0 And fieldPT(j).indice > 0 Then
                            If Not fieldPT(j).DescripcionNumerica Is Nothing Then
                                mPT.Add(String.Format("{0}{4} {1}-{2}-{3} {5} {6} X({7}) = '{8}'", Space(0), name, int.ToString("00"), fieldPT(j).NombreCobol.ToString.PadRight(19), metodos.TrimChr(fieldPT(j).Etiqueta), fieldPT(j).NombreFML.ToString.PadRight(12), fieldPT(j).NombreJava.ToString.PadRight(15), Tamaño.ToString("00000"), xToString(vCaracter.vSpace, Tamaño)))
                            Else
                                mPT.Add(String.Format("{0}{4} {1}-{2}-{3} {5} {6} X({7}) = '{8}'", Space(0), name, int.ToString("00"), fieldPT(j).NombreCobol.ToString.PadRight(19), metodos.TrimChr(fieldPT(j).Etiqueta), fieldPT(j).NombreFML.ToString.PadRight(12), fieldPT(j).NombreJava.ToString.PadRight(15), Tamaño.ToString("00000"), xToString(vCaracter.vZeroes, Tamaño)))
                            End If
                            iLarge -= (Tamaño * pant.Index * fieldPT(j).indice)
                        ElseIf pant.Index > 0 Or fieldPT(j).indice > 0 Then
                            If Not fieldPT(j).DescripcionNumerica Is Nothing Then
                                mPT.Add(String.Format("{0}{4} {1}-{2}-{3} {5} {6} X({7}) = '{8}'", Space(0), name, int.ToString("00"), fieldPT(j).NombreCobol.ToString.PadRight(19), metodos.TrimChr(fieldPT(j).Etiqueta), fieldPT(j).NombreFML.ToString.PadRight(12), fieldPT(j).NombreJava.ToString.PadRight(15), Tamaño.ToString("00000"), xToString(vCaracter.vSpace, Tamaño)))
                            Else
                                mPT.Add(String.Format("{0}{4} {1}-{2}-{3} {5} {6} X({7}) = '{8}'", Space(0), name, int.ToString("00"), fieldPT(j).NombreCobol.ToString.PadRight(19), metodos.TrimChr(fieldPT(j).Etiqueta), fieldPT(j).NombreFML.ToString.PadRight(12), fieldPT(j).NombreJava.ToString.PadRight(15), Tamaño.ToString("00000"), xToString(vCaracter.vZeroes, Tamaño)))
                            End If
                            If pant.Index > 0 Then
                                iLarge -= (Tamaño * pant.Index)
                            Else
                                iLarge -= (Tamaño * fieldPT(j).indice)
                            End If
                        Else
                            If fieldPT(j).DescripcionNumerica Is Nothing Then
                                mPT.Add(String.Format("{0}{4} {1}-{2}-{3} {5} {6} X({7}) = '{8}'", Space(0), name, int.ToString("00"), fieldPT(j).NombreCobol.ToString.PadRight(18), metodos.TrimChr(fieldPT(j).Etiqueta), fieldPT(j).NombreFML.ToString.PadRight(20), fieldPT(j).NombreJava.ToString.PadRight(22), Tamaño.ToString("00000"), xToString(vCaracter.vSpace, Tamaño)))
                            Else
                                mPT.Add(String.Format("{0}{4} {1}-{2}-{3} {5} {6} X({7}) = '{8}'", Space(0), name, int.ToString("00"), fieldPT(j).NombreCobol.ToString.PadRight(18), metodos.TrimChr(fieldPT(j).Etiqueta), fieldPT(j).NombreFML.ToString.PadRight(20), fieldPT(j).NombreJava.ToString.PadRight(22), Tamaño.ToString("00000"), xToString(vCaracter.vZeroes, Tamaño)))
                            End If
                            iLarge -= Tamaño
                        End If
                        j += 1
                    End While
                End If
                int += 1
            End While
        End Sub
        Private Enum vCaracter
            vSpace
            vZeroes
        End Enum
        Private Function xToString(ByRef tipoCampo, ByRef cantidad) As String
            Dim campo As String = ""
            For i As Integer = 0 To cantidad - 1
                If tipoCampo = vCaracter.vSpace Then
                    campo &= " "
                ElseIf tipoCampo = vCaracter.vZeroes Then
                    campo &= "0"
                End If
            Next
            Return campo
        End Function
    End Class
#End Region
End Namespace
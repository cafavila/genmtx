Namespace Cimagroup.Generador2012.GeneradorBussinesObject
    Public Class CabeceraMtx
        ''' <summary>
        ''' $_SIS_FIL
        ''' </summary>
        Private mSistema As String
        ''' <summary>
        ''' $_TIME_STP
        ''' </summary>
        Private mTimestamp As String
        ''' <summary>
        ''' $_IND_ARCH_FST
        ''' </summary>
        Private mIndicadorPrimerArchivo As String = "S"
        ''' <summary>
        ''' $_PI_MOVE
        ''' </summary>
        Private mMove As Boolean = False
        ''' <summary>
        ''' $_LRG_HDR
        ''' </summary>
        Private mLargoHeader As Integer = 100
        ''' <summary>
        ''' $_LRG_SND
        ''' </summary>
        Private mLargoSend As Integer = 10000
        ''' <summary>
        ''' $_LRG_RCV
        ''' </summary>
        Private mLargoReceive As Integer = 10000
        ''' <summary>
        ''' $_CPL_NUM_INI
        ''' </summary>
        Private mComplementoNumerico As String = "S"
        ''' <summary>
        ''' $_ATR_PRT
        ''' </summary>
        Private mAtributo As Boolean = True
        ''' <summary>
        ''' $_IDN_TFL
        ''' </summary>
        Private mNemotecnico As String = "MX"
        ''' <summary>
        ''' $_CVT_TAG
        ''' </summary>
        Private mTag As String = "SINTAG"
        ''' <summary>
        ''' $_CVT_DESC
        ''' </summary>
        Private mDescripcion As String = "No se ha definido TAG"
        ''' <summary>
        ''' $_PREF_TRAN
        ''' </summary>
        Private mPrefTrans As Char

        Public Property Atributos As Boolean
            Get
                Return mAtributo
            End Get
            Set(value As Boolean)
                mAtributo = value
            End Set
        End Property

        Public Property ComplementoNumerico As String
            Get
                Return mComplementoNumerico
            End Get
            Set(value As String)
                mComplementoNumerico = value
            End Set
        End Property

        Public Property DescripcionTag As String
            Get
                Return mDescripcion
            End Get
            Set(value As String)
                mDescripcion = value
            End Set
        End Property

        Public Property IndicadorPrimerArchivo As String
            Get
                Return mIndicadorPrimerArchivo
            End Get
            Set(value As String)
                mIndicadorPrimerArchivo = value
            End Set
        End Property

        Public Property LargoHeader As Integer
            Get
                Return mLargoHeader
            End Get
            Set(value As Integer)
                mLargoHeader = value
            End Set
        End Property

        Public Property LargoReceive As Integer
            Get
                Return mLargoReceive
            End Get
            Set(value As Integer)
                mLargoReceive = value
            End Set
        End Property

        Public Property LargoSend As Integer
            Get
                Return mLargoSend
            End Get
            Set(value As Integer)
                mLargoSend = value
            End Set
        End Property

        Public Property PIMove As Boolean
            Get
                Return mMove
            End Get
            Set(value As Boolean)
                mMove = value
            End Set
        End Property

        Public Property NemotecnicoFile As String
            Get
                Return mNemotecnico
            End Get
            Set(value As String)
                mNemotecnico = value
            End Set
        End Property

        Public Property Sistema As String
            Get
                Return mSistema
            End Get
            Set(value As String)
                mSistema = value
            End Set
        End Property

        Public Property Tag As String
            Get
                Return mTag
            End Get
            Set(value As String)
                mTag = value
            End Set
        End Property

        Public Property Timestamp As String
            Get
                Return mTimestamp
            End Get
            Set(value As String)
                mTimestamp = value
            End Set
        End Property

        Public Property PrefijoTrans As Char
            Get
                Return mPrefTrans
            End Get
            Set(value As Char)
                mPrefTrans = value
            End Set
        End Property
    End Class
    Public Class EstructuraMtx
        Private mCabeceraMtx As CabeceraMtx
        Private mPantallaFrm As Collection
        Private mRequerimiento As Collection
        Public Property CabeceraMtx As CabeceraMtx
            Get
                Return mCabeceraMtx
            End Get
            Set(value As CabeceraMtx)
                mCabeceraMtx = value
            End Set
        End Property

        Public Property PantallasFrm As Collection
            Get
                Return mPantallaFrm
            End Get
            Set(value As Collection)
                mPantallaFrm = value
            End Set
        End Property

        Public Property ServiciosReq As Collection
            Get
                Return mRequerimiento
            End Get
            Set(value As Collection)
                mRequerimiento = value
            End Set
        End Property
        Sub New()
            mCabeceraMtx = New CabeceraMtx
            mPantallaFrm = New Collection()
            mRequerimiento = New Collection()
        End Sub
    End Class
    Public Class Form
        Private mHost As Host
        Private mServer As List(Of Server)
        Sub New()
            mHost = New Host
            mServer = New List(Of Server)
        End Sub

        Public Property Host As Host
            Get
                Return mHost
            End Get
            Set(value As Host)
                mHost = value
            End Set
        End Property

        Public Property Server As List(Of Server)
            Get
                Return mServer
            End Get
            Set(value As List(Of Server))
                mServer = value
            End Set
        End Property
    End Class

    Public Class Host
        Private mNombre As String
        Private mDescripcion As String
        Private mSistema As String
        Private mCampos As List(Of Campo)
        Sub New()
            mCampos = New List(Of Campo)
        End Sub
        Public Property Campos As List(Of Campo)
            Get
                Return mCampos
            End Get
            Set(value As List(Of Campo))
                mCampos = value
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

        Public Property Nombre As String
            Get
                Return mNombre
            End Get
            Set(value As String)
                mNombre = value
            End Set
        End Property

        Public Property Sistema As String
            Get
                Return mSistema
            End Get
            Set(value As String)
                mSistema = value
            End Set
        End Property

    End Class
    Public Class Campo
        Private mNombreCobol As String
        Private mTipoAcceso As String
        Private mDescripcionNumerica As String
        Private mTamaño As Integer
        Private mEtiqueta As String
        Private mNombreFML As String
        Private mNombreJava As String
        Private mJavadoc As String
        Private mIndice As Integer
        Public Property DescripcionNumerica As String
            Get
                Return mDescripcionNumerica
            End Get
            Set(value As String)
                mDescripcionNumerica = value
            End Set
        End Property

        Public Property Etiqueta As String
            Get
                Return mEtiqueta
            End Get
            Set(value As String)
                mEtiqueta = value
            End Set
        End Property

        Public Property Javadoc As String
            Get
                Return mJavadoc
            End Get
            Set(value As String)
                mJavadoc = value
            End Set
        End Property

        Public Property NombreCobol As String
            Get
                Return mNombreCobol
            End Get
            Set(value As String)
                mNombreCobol = value
            End Set
        End Property

        Public Property NombreFML As String
            Get
                Return mNombreFML
            End Get
            Set(value As String)
                mNombreFML = value
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

        Public Property Tamaño As Integer
            Get
                Return mTamaño
            End Get
            Set(value As Integer)
                mTamaño = value
            End Set
        End Property

        Public Property TipoAcceso As String
            Get
                Return mTipoAcceso
            End Get
            Set(value As String)
                mTipoAcceso = value
            End Set
        End Property

        Public Property Indice As Integer
            Get
                Return mIndice
            End Get
            Set(value As Integer)
                mIndice = value
            End Set
        End Property
    End Class
    Public Structure StructureField
        Public Campo As String
        Public indice As String
    End Structure

    Public Class Server
        Private mNombre As String
        Private mCampos As System.Collections.Generic.List(Of String)
        Private mIndice As Integer
        Sub New()
            mCampos = New List(Of String)
        End Sub

        Public Property Nombre As String
            Get
                Return mNombre
            End Get
            Set(value As String)
                mNombre = value
            End Set
        End Property

        Public Property Campos As System.Collections.Generic.List(Of String)
            Get
                Return mCampos
            End Get
            Set(value As System.Collections.Generic.List(Of String))
                mCampos = value
            End Set
        End Property

        Public Property Indice As Integer
            Get
                Return mIndice
            End Get
            Set(value As Integer)
                mIndice = value
            End Set
        End Property
    End Class
    Public Structure StructureReq
        Public Pantalla As String
        Public Server As String
        Public Index As Integer
    End Structure
    Public Class ServiciosRequerimiento
        Private mDescripcion As String
        Private mMetodoJava As String
        Private mNombre As String
        Private mParaPantallaComando As String
        Private mJavadoc As String
        Private mPT As Collection
        Private mTX As Collection
        Private mXT As Collection
        Private mTP As Collection
        Private mTransas As Collection
        Private mAtributos As Boolean
        Sub New()
            mPT = New Collection()
            mTX = New Collection()
            mXT = New Collection()
            mTP = New Collection()
            mTransas = New Collection()
        End Sub

        Public Property Descripcion As String
            Get
                Return mDescripcion
            End Get
            Set(value As String)
                mDescripcion = value
            End Set
        End Property

        Public Property MetodoJava As String
            Get
                Return mMetodoJava
            End Get
            Set(value As String)
                mMetodoJava = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return mNombre
            End Get
            Set(value As String)
                mNombre = value
            End Set
        End Property

        Public Property PantallaComando As String
            Get
                Return mParaPantallaComando
            End Get
            Set(value As String)
                mParaPantallaComando = value
            End Set
        End Property

        Public Property PT As Collection
            Get
                Return mPT
            End Get
            Set(value As Collection)
                mPT = value
            End Set
        End Property

        Public Property TX As Collection
            Get
                Return mTX
            End Get
            Set(value As Collection)
                mTX = value
            End Set
        End Property

        Public Property XT As Collection
            Get
                Return mXT
            End Get
            Set(value As Collection)
                mXT = value
            End Set
        End Property

        Public Property TP As Collection
            Get
                Return mTP
            End Get
            Set(value As Collection)
                mTP = value
            End Set
        End Property

        Public Property Transaccional As Collection
            Get
                Return mTransas
            End Get
            Set(value As Collection)
                mTransas = value
            End Set
        End Property

        Public Property Atributos As Boolean
            Get
                Return mAtributos
            End Get
            Set(value As Boolean)
                mAtributos = value
            End Set
        End Property
    End Class
    Public Class Transaccional
        Private mPantalla As String
        Private mInmando As String
        Private mComando As String
        Private mCPP As String
        Private mSPP As String
        Private mPrograma As String
        Private mSubprograma As String
        Private mInstancia As String
        Private mFormIn As String
        Private mFormOut As String
        Private mComentario As String
        Private mIDD As String
        Private mConfirmacion As String

        Public Property Pantalla As String
            Get
                Return mPantalla
            End Get
            Set(value As String)
                mPantalla = value
            End Set
        End Property

        Public Property Inmando As String
            Get
                Return mInmando
            End Get
            Set(value As String)
                mInmando = value
            End Set
        End Property

        Public Property Comando As String
            Get
                Return mComando
            End Get
            Set(value As String)
                mComando = value
            End Set
        End Property

        Public Property Comentario As String
            Get
                Return mComentario
            End Get
            Set(value As String)
                mComentario = value
            End Set
        End Property

        Public Property CPP As String
            Get
                Return mCPP
            End Get
            Set(value As String)
                mCPP = value
            End Set
        End Property

        Public Property FormIn As String
            Get
                Return mFormIn
            End Get
            Set(value As String)
                mFormIn = value
            End Set
        End Property

        Public Property FormOut As String
            Get
                Return mFormOut
            End Get
            Set(value As String)
                mFormOut = value
            End Set
        End Property

        Public Property IDD As String
            Get
                Return mIDD
            End Get
            Set(value As String)
                mIDD = value
            End Set
        End Property

        Public Property Instancia As String
            Get
                Return mInstancia
            End Get
            Set(value As String)
                mInstancia = value
            End Set
        End Property

        Public Property Programa As String
            Get
                Return mPrograma
            End Get
            Set(value As String)
                mPrograma = value
            End Set
        End Property

        Public Property SPP As String
            Get
                Return mSPP
            End Get
            Set(value As String)
                mSPP = value
            End Set
        End Property

        Public Property Subprograma As String
            Get
                Return mSubprograma
            End Get
            Set(value As String)
                mSubprograma = value
            End Set
        End Property

        Public Property Confirmacion As String
            Get
                Return mConfirmacion
            End Get
            Set(value As String)
                mConfirmacion = value
            End Set
        End Property
    End Class
    Public Class TablaVO
        Private mCodigoTipoTabla As String = Space(3)
        Private mCodigoTabla As String = Space(12)
        Private mIndicadorVigencia As Char = "S"
        Private mFechaModificacion As String = String.Format("{0}{1}{2}", Now.Year.ToString("YYYY"), Now.Month.ToString("MM"), Now.Day.ToString("dd"))
        Private mHoraModificacion As String = String.Format("{0}{1}{2}", Now.Hour.ToString("HH"), Now.Minute.ToString("mm"), Now.Second.ToString("ss"))
        Private mIndicadorTipoAccion As Char = "I"
        Private mCodigoOrigenTransaccion As String = Space(4)
        Private mAutorTransaccion As String = Space(12)
        Private mCodigoComputacional As String = Space(15)
        Private mCodigoExterno As String = Space(5)
        Private mDescCorta As String = Space(12)
        Private mAbreviacion As String = Space(5)
        Private mDescripcion As String = Space(40)
        Private mDatosAdicionales As String = Space(60)
        ''' <summary>
        ''' 05 TAB-COD-TABL
        ''' </summary>
        ''' <value>07 TAB-COD-TTAB         PIC X(03).</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CodigoTipoTabla() As String
            Get
                Return mCodigoTipoTabla
            End Get
            Set(ByVal value As String)
                If value.Length > 3 Then
                    Mid(mCodigoTipoTabla, 1, 3) = value
                ElseIf value.Length > 0 Then
                    Mid(mCodigoTipoTabla, 1) = value
                End If
            End Set
        End Property
        ''' <summary>
        ''' 05 TAB-COD-TABL	
        ''' </summary>
        ''' <value>07 TAB-COD-CTAB         PIC X(12).</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CodigoTabla() As String
            Get
                Return mCodigoTabla
            End Get
            Set(ByVal value As String)
                If value.Length > 12 Then
                    Mid(mCodigoTabla, 1, 12) = value
                ElseIf value.Length > 0 Then
                    Mid(mCodigoTabla, 1) = value
                End If
            End Set
        End Property
        ''' <summary>
        ''' 05 TAB-STP-ITRN	
        ''' </summary>
        ''' <value>07 TAB-FEC-FTRN         PIC 9(08).</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FechaModificacion() As String
            Get
                FechaModificacion = mFechaModificacion
            End Get
            Set(ByVal value As String)
                mFechaModificacion = value
            End Set
        End Property
        ''' <summary>
        ''' 05 TAB-STP-ITRN	
        ''' </summary>
        ''' <value>07 TAB-HRA-HRTR         PIC 9(06).</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property HoraModificacion() As String
            Get
                Return mHoraModificacion
            End Get
            Set(ByVal value As String)
                If value = "000000" Or Trim(value) Is Nothing Then
                    mHoraModificacion = "090000"
                Else
                    mHoraModificacion = value
                End If
            End Set
        End Property
        ''' <summary>
        ''' IND. Tipo Acción
        ''' </summary>
        ''' <value>03 TAB-MSC-TACC         PIC X(01).</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property IndicadorTipoAccion() As Char
            Get
                Return mIndicadorTipoAccion
            End Get
            Set(ByVal value As Char)
                mIndicadorTipoAccion = value
            End Set
        End Property
        ''' <summary>
        ''' IND. Status
        ''' </summary>
        ''' <value>03 TAB-MSC-STAT         PIC X(01).</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property IndicadorVigencia() As Char
            Get
                Return mIndicadorVigencia
            End Get
            Set(ByVal value As Char)
                If value = "" Then
                    mIndicadorVigencia = " "
                Else
                    mIndicadorVigencia = value
                End If
            End Set
        End Property
        ''' <summary>
        ''' Código Origen Transacción	
        ''' </summary>
        ''' <value>03 TAB-COD-OTRN	     PIC X(04).</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CodigoOrigenTransaccion As String
            Get
                Return mCodigoOrigenTransaccion
            End Get
            Set(value As String)
                If value.Length > 4 Then
                    Mid(mCodigoOrigenTransaccion, 1, 4) = value
                ElseIf value.Length > 0 Then
                    Mid(mCodigoOrigenTransaccion, 1) = value
                End If
            End Set
        End Property
        ''' <summary>
        ''' Autor Transacción
        ''' </summary>
        ''' <value>03 TAB-COD-ATRN     PIC X(12).</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AutorTransaccion As String
            Get
                Return mAutorTransaccion
            End Get
            Set(value As String)
                If value.Length > 12 Then
                    Mid(mAutorTransaccion, 1, 12) = value
                ElseIf value.Length > 0 Then
                    Mid(mAutorTransaccion, 1) = value
                End If
            End Set
        End Property
        ''' <summary>
        ''' Código Interno Computacional
        ''' </summary>
        ''' <value>03 TAB-CIC-TABL	PIC X(15)</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CodigoComputacional() As String
            Get
                CodigoComputacional = mCodigoComputacional
            End Get
            Set(ByVal value As String)
                If value.Length > 15 Then
                    Mid(mCodigoComputacional, 1, 15) = value
                ElseIf value.Length > 0 Then
                    Mid(mCodigoComputacional, 1) = value
                End If
            End Set
        End Property
        ''' <summary>
        ''' Código Externo
        ''' </summary>
        ''' <value>03 TAB-EXT-TABL	         PIC X(05).</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CodigoExterno() As String
            Get
                Return mCodigoExterno
            End Get
            Set(ByVal value As String)
                If value.Length > 5 Then
                    Mid(mCodigoExterno, 1, 5) = value
                ElseIf value.Length > 0 Then
                    Mid(mCodigoExterno, 1) = value
                End If
            End Set
        End Property
        ''' <summary>
        ''' Desc. Corta
        ''' </summary>
        ''' <value>03 TAB-GLS-DCOR         PIC X(12).</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DescripcionCorta() As String
            Get
                Return mDescCorta
            End Get
            Set(ByVal value As String)
                If value.Length > 12 Then
                    Mid(mDescCorta, 1, 12) = value
                ElseIf value.Length > 0 Then
                    Mid(mDescCorta, 1) = value
                End If
            End Set
        End Property
        ''' <summary>
        ''' Abreviación
        ''' </summary>
        ''' <value>03 TAB-GLS-ABRV         PIC X(05).</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Abreviacion() As String
            Get
                Return mAbreviacion
            End Get
            Set(ByVal value As String)
                If value.Length > 5 Then
                    Mid(mAbreviacion, 1, 5) = value
                ElseIf value.Length > 0 Then
                    Mid(mAbreviacion, 1) = value
                End If
            End Set
        End Property
        ''' <summary>
        ''' Descripción del Código
        ''' </summary>
        ''' <value>03 TAB-GLS-DESC             PIC X(40).</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Descripcion() As String
            Get
                Return mDescripcion
            End Get
            Set(ByVal value As String)
                If value.Length > 40 Then
                    Mid(mDescripcion, 1, 40) = value
                ElseIf value.Length > 0 Then
                    Mid(mDescripcion, 1) = value
                End If
            End Set
        End Property
        ''' <summary>
        ''' Datos Anexos
        ''' </summary>
        ''' <value>03 TAB-GLS-DATA         PIC X(60).</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DatosAdicionales() As String
            Get
                Return mDatosAdicionales
            End Get
            Set(ByVal value As String)
                If value.Length > 60 Then
                    Mid(mDatosAdicionales, 1, 60) = value
                ElseIf value.Length > 0 Then
                    Mid(mDatosAdicionales, 1) = value
                End If
            End Set
        End Property
        Public Function EnLinea() As String
            Dim linea As String
            Dim nFiller As String = Space(1)
            Dim nCodigoOrigen As String = Space(4)
            Dim nAutor As String = "GENERADO    "
            Dim nSoudex As String = Space(6)
            'Debug.Print("nFiller({1}) = '{0}'", nFiller, nFiller.Length)
            'Debug.Print("mCodigoTabla({1}) = '{0}'", mCodigoTabla, mCodigoTabla.Length)
            'Debug.Print("mCodigo({1}) = '{0}'", mCodigo, mCodigo.Length)
            'Debug.Print("mFechaModificacion({1}) = '{0}'", mFechaModificacion, mFechaModificacion.Length)
            'Debug.Print("mHoraModificacion({1}) = '{0}'", mHoraModificacion, mHoraModificacion.Length)
            'Debug.Print("nIndicadorTipoAccion({1}) = '{0}'", nIndicadorTipoAccion, nIndicadorTipoAccion.Length)
            'Debug.Print("mCodigoVigente({1}) = '{0}'", mCodigoVigente, mCodigoVigente.Length)
            'Debug.Print("nCodigoOrigen({1}) = '{0}'", nCodigoOrigen, nCodigoOrigen.Length)
            'Debug.Print("nAutor({1}) = '{0}'", nAutor, nAutor.Length)
            'Debug.Print("mCodigoComputacional({1}) = '{0}'", mCodigoComputacional, mCodigoComputacional.Length)
            'Debug.Print("mCodigoExterno({1}) = '{0}'", mCodigoExterno, mCodigoExterno.Length)
            'Debug.Print("mDescCorta({1}) = '{0}'", mDescCorta, mDescCorta.Length)
            'Debug.Print("mAbreviacion({1}) = '{0}'", mAbreviacion, mAbreviacion.Length)
            'Debug.Print("mDescripcion({1}) = '{0}'", mDescripcion, mDescripcion.Length)
            'Debug.Print("mDatosAdicionales({1}) = '{0}'", mDatosAdicionales, mDatosAdicionales.Length)

            linea = nFiller & _
                    mCodigoTipoTabla & _
                    mCodigoTabla & _
                    mFechaModificacion & _
                    mHoraModificacion & _
                    mIndicadorTipoAccion & _
                    mIndicadorVigencia & _
                    Space(4) & _
                    mAutorTransaccion & _
                    mCodigoComputacional & _
                    mCodigoTipoTabla & _
                    mCodigoExterno & _
                    mDescCorta & _
                    mAbreviacion & _
                    mDescripcion & _
                    mDatosAdicionales & _
                    nSoudex
            Return linea
        End Function
    End Class
End Namespace
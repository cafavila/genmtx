Namespace Cimagroup.Generador2012.GeneradorBussinesObject.EstructuraJSON
    Public Class ServiceMessage
        Dim mServicio As String
        Dim mDescripcion As String
        Dim mSrvTuxedo As String
        Dim mDataSrv As Collection
        Public Property Servicio As String
            Get
                Return mServicio
            End Get
            Set(value As String)
                mServicio = value
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
        Public Property ServicioTuxedo As String
            Get
                Return mSrvTuxedo
            End Get
            Set(value As String)
                mSrvTuxedo = value
            End Set
        End Property
        Public Property Data As Collection
            Get
                Return mDataSrv
            End Get
            Set(value As Collection)
                mDataSrv = value
            End Set
        End Property
    End Class
    Public Class DataOccs
        Dim mIdx As Integer
        Dim mOcurrs As Collection
    End Class
    Public Class Campos
        Dim mNombreCobol As String
        Dim mNombreTux As String
        Dim mNombreJava As String
        Dim mEtiqueta As String
        Dim mLargo As Integer
        Dim mValor As String
        Public Property NombreCobol As String
            Get
                Return mNombreCobol
            End Get
            Set(value As String)
                mNombreCobol = value
            End Set
        End Property
        Public Property nombreTux As String
            Get
                Return mNombreTux
            End Get
            Set(value As String)
                mNombreTux = value
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
        Public Property Etiqueta As String
            Get
                Return mEtiqueta
            End Get
            Set(value As String)
                mEtiqueta = value
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
        Public Property valor As String
            Get
                Return mValor
            End Get
            Set(value As String)
                mValor = value
            End Set
        End Property
    End Class
    Public Class EstructuraEntrada
        Private mEntrada As Collection
        Public Property MensajeEntrada As Collection
            Get
                Return mEntrada
            End Get
            Set(value As Collection)
                mEntrada = value
            End Set
        End Property
    End Class
    Public Class EstructuraSalida
        Private mSalida As Collection
        Public Property MensajeSalida As Collection
            Get
                Return mSalida
            End Get
            Set(value As Collection)
                mSalida = value
            End Set
        End Property
        Public Sub New()
            mSalida = New Collection()
        End Sub
    End Class
End Namespace
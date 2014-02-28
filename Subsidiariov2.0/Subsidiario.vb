Public Class Subsidiario
    Private mFecha As String
    Private mOficina As String
    Private mCtaCtbl As String
    Private mMoneda As String
    Private mNombre As String
    Private mRut As String
    Private mNumeroOperacion As String
    Private mNumeroSerial As String
    Private mTasa As String
    Private mDebe As String
    Private mHaber As String
    Private mAlgoritmo As Char
    Private mSaldo As String
    Public Property Fecha() As String
        Get
            Return mFecha
        End Get
        Set(ByVal value As String)
            mFecha = value
        End Set
    End Property
    Public Property Oficina() As String
        Get
            Return mOficina
        End Get
        Set(ByVal value As String)
            mOficina = value
        End Set
    End Property
    Public Property CtaCtble() As String
        Get
            Return mCtaCtbl
        End Get
        Set(ByVal value As String)
            mCtaCtbl = value
        End Set
    End Property
    Public Property Moneda() As String
        Get
            Return mMoneda
        End Get
        Set(ByVal value As String)
            mMoneda = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return mNombre
        End Get
        Set(ByVal value As String)
            mNombre = value
        End Set
    End Property
    Public Property Rut() As String
        Get
            Return mRut
        End Get
        Set(ByVal value As String)
            mRut = value
        End Set
    End Property
    Public Property NumeroOperacion() As String
        Get
            Return mNumeroOperacion
        End Get
        Set(ByVal value As String)
            mNumeroOperacion = value
        End Set
    End Property
    Public Property NumeroSerial() As String
        Get
            Return mNumeroSerial
        End Get
        Set(ByVal value As String)
            mNumeroSerial = value
        End Set
    End Property
    Public Property Tasa() As String
        Get
            Return mTasa
        End Get
        Set(ByVal value As String)
            mTasa = value
        End Set
    End Property
    Public Property Debe() As String
        Get
            Return mDebe
        End Get
        Set(ByVal value As String)
            mDebe = value
        End Set
    End Property
    Public Property Haber() As String
        Get
            Return mHaber
        End Get
        Set(ByVal value As String)
            mHaber = value
        End Set
    End Property
    Public Property Algoritmo() As Char
        Get
            Return mAlgoritmo
        End Get
        Set(ByVal value As Char)
            mAlgoritmo = value
        End Set
    End Property
    Public Property Saldo() As String
        Get
            Return mSaldo
        End Get
        Set(ByVal value As String)
            mSaldo = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Overrides Function toString() As String
        Return String.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11}", mFecha, mOficina, mCtaCtbl, mNombre, mRut, mNumeroOperacion, mNumeroSerial, mTasa, mDebe, mHaber, mAlgoritmo, mSaldo)
    End Function
End Class

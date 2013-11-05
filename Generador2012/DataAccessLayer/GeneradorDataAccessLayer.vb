Imports System.IO
Namespace Cimagroup.Generador2012.GeneradorDataAccessLayer
    Public Class Archivo
        Private mArchivoFisico As String
        Public Property ArchivoFisico As String
            Get
                Return mArchivoFisico
            End Get
            Set(value As String)
                mArchivoFisico = value
            End Set
        End Property
    End Class
End Namespace
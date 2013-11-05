Imports System.IO
Imports Cimagroup.Generador2012
Namespace Cimagroup.Generador2012.GeneradorBussinesObject
    Public Structure Directorios
        Public Input As String
        Public Output As String
        Public Log As String
        Public Doc As String
        Public Debug As String
        Public DefaultPath As String
    End Structure
    Public Class ArchivoEspecificacion
        Inherits GeneradorDataAccessLayer.Archivo
        Private mContenido As String
        Public Property Contenido As String
            Get
                Return mContenido
            End Get
            Set(value As String)
                mContenido = value
            End Set
        End Property
        Public Sub LeerArchivo(filename As String)
            MyBase.ArchivoFisico = filename
            Dim file As StreamReader = New System.IO.StreamReader(filename)
            While Not file.Peek = -1
                mContenido += file.ReadLine + ";" + vbCrLf
            End While
        End Sub
    End Class
End Namespace
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Cimagroup.Generador2012.GeneradorModulosPruebas



'''<summary>
'''Se trata de una clase de prueba para ModeloModulosTESTTest y se pretende que
'''contenga todas las pruebas unitarias ModeloModulosTESTTest.
'''</summary>
<TestClass()> _
Public Class ModeloModulosTESTTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Obtiene o establece el contexto de la prueba que proporciona
    '''la información y funcionalidad para la ejecución de pruebas actual.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Atributos de prueba adicionales"
    '
    'Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
    '
    'Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize para ejecutar código antes de ejecutar cada prueba
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''Una prueba de xToString
    '''</summary>
    '<TestMethod(), _
    ' DeploymentItem("Cimagroup.Generador2012.GeneradorBussinesLogic.dll")> _
    'Public Sub xToStringTest()
    '    Dim param0 As PrivateObject = Nothing ' TODO: Inicializar en un valor adecuado
    '    Dim target As ModeloModulosTEST_Accessor = New ModeloModulosTEST_Accessor(param0) ' TODO: Inicializar en un valor adecuado
    '    Dim tipoCampo As Object = 0  ' 0=Espacios, 1=Zeroes
    '    Dim tipoCampoExpected As Object = Nothing ' TODO: Inicializar en un valor adecuado
    '    Dim cantidad As Object = 10 ' TODO: Inicializar en un valor adecuado
    '    Dim cantidadExpected As Object = 10 ' TODO: Inicializar en un valor adecuado
    '    Dim expected As String = String.Empty ' TODO: Inicializar en un valor adecuado
    '    Dim actual As String
    '    actual = target.xToString(tipoCampo, cantidad)
    '    Assert.AreEqual(cantidad, actual.Length, "Tamaños Inexactos")
    '    Assert.AreEqual(actual, Space(cantidad))
    '    Assert.AreEqual(tipoCampoExpected, tipoCampo)
    '    Assert.AreEqual(cantidadExpected, cantidad)
    '    Assert.AreEqual(expected, actual)
    '    Assert.Inconclusive("Compruebe la exactitud de este método de prueba.")
    'End Sub
End Class

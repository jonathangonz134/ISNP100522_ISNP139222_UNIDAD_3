Public Class Alumno

    'Declaracion de propiedades
    Private codigo As String
    Private nombre As String
    Private apellido As String
    Private sexo As String
    Private direccion As String
    Private dui As String
    Private edad As String
    Private correo As String



    'indica si los datos ingresados estan completos
    Private datosCompletos As Boolean



    'metodos de propiedad
    'metodos para nombre del alumno
    Public Property nombreAlumno() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value

        End Set
    End Property


    'metodo para apellido del alumno
    Public Property apellidoAlumno() As String

        Get
            Return apellido
        End Get
        Set(value As String)
            nombre = value

        End Set
    End Property



    'metodo para sexo del alumno
    Public Property sexoAlumno() As String
        Get
            Return sexo
        End Get
        Set(value As String)
            sexo = value

        End Set
    End Property


    '####################################################################
    'Modificaciones
    'metodo para dui
    Public Property duiAlumno() As String
        Get
            Return dui
        End Get
        Set(value As String)
            dui = value

        End Set
    End Property



    'metodo edad
    Public Property edadAlumno() As String
        Get
            Return edad
        End Get
        Set(value As String)
            edad = value

        End Set
    End Property


    'metodo para correo
    Public Property correoAlumno() As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value

        End Set
    End Property

    '##################################################################




    'metodo para direccion del alumno
    Public Property direccionAlumno() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value

        End Set
    End Property


    Public ReadOnly Property datosAceptados() As Boolean
        Get
            Return datosCompletos
        End Get
    End Property




    'metodos
    'constructor de la clase
    Public Sub New()
        datosCompletos = False
        'determina si los datos aun no han sido ingresados
    End Sub





    'determina si los datos ingresados son correctos y asigna los atributos de la clase
    Public Sub datosAlumno(ByVal codigoA As String,
                           ByVal nombreA As String,
                           ByVal apellidoA As String,
                           ByVal sexoA As String,
                           ByVal direccionA As String,
                           ByVal duiA As String,
                           ByVal edadA As String,
                           ByVal correoA As String)

        datosCompletos = False 'asume que los datos recibidos son incorrectos

        If codigoA.Length = 0 Then
            MessageBox.Show("Debe generar el codigo del alumno")
            Exit Sub
        Else
            codigo = codigoA
        End If


        If nombreA.Length = 0 Then
            MessageBox.Show("Debe escriir el nombre del alumno")
            Exit Sub
        Else
            nombre = nombreA
        End If


        If apellidoA.Length = 0 Then
            MessageBox.Show("Debe escribir el apellido del alumno")
            Exit Sub
        Else
            apellido = apellidoA
        End If


        If sexoA.Length = 0 Then
            MessageBox.Show("Debe escribir el sexo del alumno")
            Exit Sub
        Else
            sexo = sexoA
        End If


        If sexoA = "F" Or sexoA = "M" Then
        Else
            MessageBox.Show("Debe escribir F para Femenino o M para Masculino")
            Exit Sub
        End If


        If direccionA.Length = 0 Then
            MessageBox.Show("Debe ingresar la direccion del alumno")
            Exit Sub
        Else
            direccion = direccionA
            datosCompletos = True
        End If



        '############################################################################################
        'modificado
        If duiA.Length = 0 Then
            MessageBox.Show("Debe ingresar numero de DUI")
            Exit Sub
        Else
            dui = duiA
        End If



        If edadA.Length = 0 Then
            MessageBox.Show("Debe ingresar la edad ")
            Exit Sub
        Else
            edad = edadA
        End If


        If correoA.Length = 0 Then
            MessageBox.Show("debe ingresar Correo Electronico")
            Exit Sub
        Else
            correo = correoA
        End If
    End Sub

    '#################################################################################################

    Public Function generarCodigo(ByVal nombre As String)

        Dim valor1 As String
        Dim valor2 As String
        Dim numero As String


        valor1 = UCase(Left(nombre, 1))
        valor2 = Right(nombre, 2)
        numero = Int(Rnd() * 1000) + 65

        Return valor1 & numero & valor2

    End Function


End Class

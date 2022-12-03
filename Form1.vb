Public Class Form1

    Dim alumno As New Alumno
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        alumno.datosAlumno(txtCodigo.Text, txtNombre.Text, txtApellido.Text, txtSexo.Text, txtDireccion.Text)


        'Para visualizar los datos ingresados

        datosAlumnos.Rows.Add(txtCodigo.Text,
                              alumno.nombreAlumno,
                              alumno.apellidoAlumno,
                              alumno.sexoAlumno,
                              alumno.direccionAlumno)


        If alumno.datosAceptados Then
            MessageBox.Show("Alumno " & alumno.nombreAlumno & " Registrado ")
        Else

        End If

        txtCodigo.Text = ("")
        txtNombre.Text = ("")
        txtApellido.Text = ("")
        txtSexo.Text = ("")
        txtDireccion.Text = ("")

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        If txtNombre.Text = "" Then
            MessageBox.Show("Debe ingresar su nombre")
        Else
            txtCodigo.Text = alumno.generarCodigo(txtNombre.Text)
        End If

    End Sub

End Class

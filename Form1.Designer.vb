<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.datosAlumnos = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.grpCodigo = New System.Windows.Forms.GroupBox()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDui = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.datosAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'datosAlumnos
        '
        Me.datosAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datosAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.datosAlumnos.Location = New System.Drawing.Point(12, 374)
        Me.datosAlumnos.Name = "datosAlumnos"
        Me.datosAlumnos.Size = New System.Drawing.Size(847, 181)
        Me.datosAlumnos.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(275, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(284, 25)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "REGISTRO DE ALUMNOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(126, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(122, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nombre"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(461, 97)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(110, 23)
        Me.btnGenerar.TabIndex = 19
        Me.btnGenerar.Text = "Generar Codigo"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(255, 97)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(185, 20)
        Me.txtCodigo.TabIndex = 18
        '
        'grpCodigo
        '
        Me.grpCodigo.Location = New System.Drawing.Point(217, 52)
        Me.grpCodigo.Name = "grpCodigo"
        Me.grpCodigo.Size = New System.Drawing.Size(395, 82)
        Me.grpCodigo.TabIndex = 23
        Me.grpCodigo.TabStop = False
        Me.grpCodigo.Text = "Generar Codigo Alumno"
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.txtCorreo)
        Me.grpDatos.Controls.Add(Me.btnAgregar)
        Me.grpDatos.Controls.Add(Me.txtSexo)
        Me.grpDatos.Controls.Add(Me.txtDireccion)
        Me.grpDatos.Controls.Add(Me.txtApellido)
        Me.grpDatos.Controls.Add(Me.txtDui)
        Me.grpDatos.Controls.Add(Me.txtNombre)
        Me.grpDatos.Controls.Add(Me.txtEdad)
        Me.grpDatos.Controls.Add(Me.Label6)
        Me.grpDatos.Controls.Add(Me.Label7)
        Me.grpDatos.Controls.Add(Me.Label2)
        Me.grpDatos.Controls.Add(Me.Label1)
        Me.grpDatos.Location = New System.Drawing.Point(116, 145)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(614, 211)
        Me.grpDatos.TabIndex = 24
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos Alumno"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(407, 121)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(167, 20)
        Me.txtCorreo.TabIndex = 6
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(425, 167)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(122, 35)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtSexo
        '
        Me.txtSexo.Location = New System.Drawing.Point(92, 121)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(168, 20)
        Me.txtSexo.TabIndex = 10
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(93, 167)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(167, 20)
        Me.txtDireccion.TabIndex = 11
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(92, 78)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(168, 20)
        Me.txtApellido.TabIndex = 9
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(407, 81)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(167, 20)
        Me.txtDui.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(92, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtNombre.TabIndex = 8
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(407, 41)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(53, 20)
        Me.txtEdad.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Direccion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(324, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Edad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(324, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DUI"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Apellido"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Sexo"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Direccion"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Edad"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "DUI"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Correo"
        Me.Column8.Name = "Column8"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 567)
        Me.Controls.Add(Me.datosAlumnos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.grpCodigo)
        Me.Controls.Add(Me.grpDatos)
        Me.Name = "Form1"
        Me.Text = "REGISTRO DE ALUMNOS"
        CType(Me.datosAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datosAlumnos As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents grpCodigo As GroupBox
    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtDui As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class

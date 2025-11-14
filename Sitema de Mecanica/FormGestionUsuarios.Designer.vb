<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionUsuarios
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
        txtBuscarRut = New TextBox()
        btnBuscar = New Button()
        btnVisualizar = New Button()
        dgvUsuarios = New DataGridView()
        rbtnIngresarUsuario = New RadioButton()
        rbtnModificarUsuario = New RadioButton()
        rbtnEliminarUsuario = New RadioButton()
        txtRut = New TextBox()
        Label1 = New Label()
        lblRut = New Label()
        lblCorreo = New Label()
        lblContrasena = New Label()
        lblTipo = New Label()
        txtCorreo = New TextBox()
        txtContrasena = New TextBox()
        cboTipo = New ComboBox()
        btnGuardar = New Button()
        btnModificar = New Button()
        btnEliminar = New Button()
        btnVolver = New Button()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtBuscarRut
        ' 
        txtBuscarRut.Location = New Point(46, 12)
        txtBuscarRut.Name = "txtBuscarRut"
        txtBuscarRut.Size = New Size(100, 23)
        txtBuscarRut.TabIndex = 0
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = SystemColors.ActiveCaptionText
        btnBuscar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscar.ForeColor = SystemColors.ButtonHighlight
        btnBuscar.Location = New Point(173, 6)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(94, 32)
        btnBuscar.TabIndex = 2
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' btnVisualizar
        ' 
        btnVisualizar.BackColor = SystemColors.ActiveCaptionText
        btnVisualizar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVisualizar.ForeColor = SystemColors.ButtonHighlight
        btnVisualizar.Location = New Point(290, 6)
        btnVisualizar.Name = "btnVisualizar"
        btnVisualizar.Size = New Size(94, 32)
        btnVisualizar.TabIndex = 3
        btnVisualizar.Text = "Visualizar"
        btnVisualizar.UseVisualStyleBackColor = False
        ' 
        ' dgvUsuarios
        ' 
        dgvUsuarios.BackgroundColor = SystemColors.ActiveCaptionText
        dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsuarios.Location = New Point(12, 44)
        dgvUsuarios.Name = "dgvUsuarios"
        dgvUsuarios.RowHeadersWidth = 51
        dgvUsuarios.Size = New Size(776, 159)
        dgvUsuarios.TabIndex = 4
        ' 
        ' rbtnIngresarUsuario
        ' 
        rbtnIngresarUsuario.AutoSize = True
        rbtnIngresarUsuario.BackColor = SystemColors.ActiveCaptionText
        rbtnIngresarUsuario.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbtnIngresarUsuario.ForeColor = SystemColors.ButtonHighlight
        rbtnIngresarUsuario.Location = New Point(12, 209)
        rbtnIngresarUsuario.Name = "rbtnIngresarUsuario"
        rbtnIngresarUsuario.Size = New Size(114, 19)
        rbtnIngresarUsuario.TabIndex = 5
        rbtnIngresarUsuario.TabStop = True
        rbtnIngresarUsuario.Text = "Ingresar usuario"
        rbtnIngresarUsuario.UseVisualStyleBackColor = False
        ' 
        ' rbtnModificarUsuario
        ' 
        rbtnModificarUsuario.AutoSize = True
        rbtnModificarUsuario.BackColor = SystemColors.ActiveCaptionText
        rbtnModificarUsuario.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbtnModificarUsuario.ForeColor = SystemColors.ButtonHighlight
        rbtnModificarUsuario.Location = New Point(128, 209)
        rbtnModificarUsuario.Name = "rbtnModificarUsuario"
        rbtnModificarUsuario.Size = New Size(121, 19)
        rbtnModificarUsuario.TabIndex = 6
        rbtnModificarUsuario.TabStop = True
        rbtnModificarUsuario.Text = "Modificar usuario"
        rbtnModificarUsuario.UseVisualStyleBackColor = False
        ' 
        ' rbtnEliminarUsuario
        ' 
        rbtnEliminarUsuario.AutoSize = True
        rbtnEliminarUsuario.BackColor = SystemColors.ActiveCaptionText
        rbtnEliminarUsuario.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbtnEliminarUsuario.ForeColor = SystemColors.ButtonHighlight
        rbtnEliminarUsuario.Location = New Point(252, 209)
        rbtnEliminarUsuario.Name = "rbtnEliminarUsuario"
        rbtnEliminarUsuario.Size = New Size(112, 19)
        rbtnEliminarUsuario.TabIndex = 7
        rbtnEliminarUsuario.TabStop = True
        rbtnEliminarUsuario.Text = "Eliminar usuario"
        rbtnEliminarUsuario.UseVisualStyleBackColor = False
        ' 
        ' txtRut
        ' 
        txtRut.Location = New Point(128, 245)
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(168, 23)
        txtRut.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Snow
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 9
        Label1.Text = "Rut:"
        ' 
        ' lblRut
        ' 
        lblRut.AutoSize = True
        lblRut.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblRut.ForeColor = Color.Snow
        lblRut.Location = New Point(12, 248)
        lblRut.Name = "lblRut"
        lblRut.Size = New Size(30, 15)
        lblRut.TabIndex = 10
        lblRut.Text = "Rut:"
        ' 
        ' lblCorreo
        ' 
        lblCorreo.AutoSize = True
        lblCorreo.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCorreo.ForeColor = Color.Snow
        lblCorreo.Location = New Point(12, 280)
        lblCorreo.Name = "lblCorreo"
        lblCorreo.Size = New Size(48, 15)
        lblCorreo.TabIndex = 11
        lblCorreo.Text = "Correo:"
        ' 
        ' lblContrasena
        ' 
        lblContrasena.AutoSize = True
        lblContrasena.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblContrasena.ForeColor = Color.Snow
        lblContrasena.Location = New Point(12, 309)
        lblContrasena.Name = "lblContrasena"
        lblContrasena.Size = New Size(72, 15)
        lblContrasena.TabIndex = 12
        lblContrasena.Text = "Contraseña:"
        ' 
        ' lblTipo
        ' 
        lblTipo.AutoSize = True
        lblTipo.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTipo.ForeColor = Color.Snow
        lblTipo.Location = New Point(12, 344)
        lblTipo.Name = "lblTipo"
        lblTipo.Size = New Size(34, 15)
        lblTipo.TabIndex = 13
        lblTipo.Text = "Tipo:"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(128, 277)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(168, 23)
        txtCorreo.TabIndex = 14
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Location = New Point(128, 306)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.Size = New Size(168, 23)
        txtContrasena.TabIndex = 15
        ' 
        ' cboTipo
        ' 
        cboTipo.FormattingEnabled = True
        cboTipo.Location = New Point(128, 341)
        cboTipo.Name = "cboTipo"
        cboTipo.Size = New Size(168, 23)
        cboTipo.TabIndex = 16
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = SystemColors.ActiveCaptionText
        btnGuardar.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        btnGuardar.ForeColor = SystemColors.ButtonHighlight
        btnGuardar.Location = New Point(368, 231)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(94, 32)
        btnGuardar.TabIndex = 17
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnModificar
        ' 
        btnModificar.BackColor = SystemColors.ActiveCaptionText
        btnModificar.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        btnModificar.ForeColor = SystemColors.ButtonHighlight
        btnModificar.Location = New Point(368, 268)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(94, 32)
        btnModificar.TabIndex = 18
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = SystemColors.ActiveCaptionText
        btnEliminar.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        btnEliminar.ForeColor = SystemColors.ButtonHighlight
        btnEliminar.Location = New Point(368, 306)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(94, 32)
        btnEliminar.TabIndex = 19
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = SystemColors.ActiveCaptionText
        btnVolver.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVolver.ForeColor = SystemColors.ButtonHighlight
        btnVolver.Location = New Point(694, 406)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(94, 32)
        btnVolver.TabIndex = 20
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' FormGestionUsuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(800, 450)
        Controls.Add(btnVolver)
        Controls.Add(btnEliminar)
        Controls.Add(btnModificar)
        Controls.Add(btnGuardar)
        Controls.Add(cboTipo)
        Controls.Add(txtContrasena)
        Controls.Add(txtCorreo)
        Controls.Add(lblTipo)
        Controls.Add(lblContrasena)
        Controls.Add(lblCorreo)
        Controls.Add(lblRut)
        Controls.Add(Label1)
        Controls.Add(txtRut)
        Controls.Add(rbtnEliminarUsuario)
        Controls.Add(rbtnModificarUsuario)
        Controls.Add(rbtnIngresarUsuario)
        Controls.Add(dgvUsuarios)
        Controls.Add(btnVisualizar)
        Controls.Add(btnBuscar)
        Controls.Add(txtBuscarRut)
        Name = "FormGestionUsuarios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBuscarRut As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents rbtnIngresarUsuario As RadioButton
    Friend WithEvents rbtnModificarUsuario As RadioButton
    Friend WithEvents rbtnEliminarUsuario As RadioButton
    Friend WithEvents txtRut As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRut As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnVolver As Button
End Class

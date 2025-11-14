<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentasRepuestos
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
        txtBuscar = New TextBox()
        btnBuscar = New Button()
        btnVerTodo = New Button()
        dgvRepuestos = New DataGridView()
        Panel4 = New Panel()
        Label12 = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        txtNombreRepuesto = New TextBox()
        txtPrecio = New TextBox()
        txtCantidad = New TextBox()
        txtNombreCliente = New TextBox()
        dtpFecha = New DateTimePicker()
        txtTotalPagar = New TextBox()
        btnConfirmarCompra = New Button()
        Label5 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnVolver = New Button()
        btnHistorialVentas = New Button()
        CType(dgvRepuestos, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(71, 105)
        txtBuscar.Margin = New Padding(3, 2, 3, 2)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(110, 23)
        txtBuscar.TabIndex = 1
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = SystemColors.ActiveCaptionText
        btnBuscar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscar.ForeColor = SystemColors.ButtonHighlight
        btnBuscar.Location = New Point(231, 99)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(138, 32)
        btnBuscar.TabIndex = 7
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' btnVerTodo
        ' 
        btnVerTodo.BackColor = SystemColors.ActiveCaptionText
        btnVerTodo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerTodo.ForeColor = SystemColors.ButtonHighlight
        btnVerTodo.Location = New Point(396, 99)
        btnVerTodo.Name = "btnVerTodo"
        btnVerTodo.Size = New Size(138, 32)
        btnVerTodo.TabIndex = 8
        btnVerTodo.Text = "Visualizar"
        btnVerTodo.UseVisualStyleBackColor = False
        ' 
        ' dgvRepuestos
        ' 
        dgvRepuestos.BackgroundColor = SystemColors.ActiveCaptionText
        dgvRepuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRepuestos.Location = New Point(16, 146)
        dgvRepuestos.Margin = New Padding(3, 2, 3, 2)
        dgvRepuestos.Name = "dgvRepuestos"
        dgvRepuestos.RowHeadersWidth = 51
        dgvRepuestos.Size = New Size(823, 151)
        dgvRepuestos.TabIndex = 9
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel4.Controls.Add(Label12)
        Panel4.ForeColor = SystemColors.ControlText
        Panel4.Location = New Point(93, 11)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(667, 50)
        Panel4.TabIndex = 18
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ButtonFace
        Label12.Location = New Point(15, 9)
        Label12.Name = "Label12"
        Label12.Size = New Size(635, 32)
        Label12.TabIndex = 10
        Label12.Text = "Porfavor busque y seleccione el repuesto que necesite"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel1.Controls.Add(Label1)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(93, 311)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(667, 50)
        Panel1.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(175, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(339, 32)
        Label1.TabIndex = 10
        Label1.Text = "Complete los datos faltantes"
        ' 
        ' txtNombreRepuesto
        ' 
        txtNombreRepuesto.Location = New Point(349, 396)
        txtNombreRepuesto.Margin = New Padding(3, 2, 3, 2)
        txtNombreRepuesto.Name = "txtNombreRepuesto"
        txtNombreRepuesto.Size = New Size(213, 23)
        txtNombreRepuesto.TabIndex = 20
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(349, 434)
        txtPrecio.Margin = New Padding(3, 2, 3, 2)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(213, 23)
        txtPrecio.TabIndex = 21
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Location = New Point(349, 469)
        txtCantidad.Margin = New Padding(3, 2, 3, 2)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(213, 23)
        txtCantidad.TabIndex = 22
        ' 
        ' txtNombreCliente
        ' 
        txtNombreCliente.Location = New Point(349, 508)
        txtNombreCliente.Margin = New Padding(3, 2, 3, 2)
        txtNombreCliente.Name = "txtNombreCliente"
        txtNombreCliente.Size = New Size(213, 23)
        txtNombreCliente.TabIndex = 23
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Location = New Point(349, 544)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(213, 23)
        dtpFecha.TabIndex = 24
        ' 
        ' txtTotalPagar
        ' 
        txtTotalPagar.Location = New Point(349, 587)
        txtTotalPagar.Margin = New Padding(3, 2, 3, 2)
        txtTotalPagar.Name = "txtTotalPagar"
        txtTotalPagar.Size = New Size(213, 23)
        txtTotalPagar.TabIndex = 25
        ' 
        ' btnConfirmarCompra
        ' 
        btnConfirmarCompra.BackColor = SystemColors.ActiveCaptionText
        btnConfirmarCompra.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfirmarCompra.ForeColor = SystemColors.ButtonHighlight
        btnConfirmarCompra.Location = New Point(424, 629)
        btnConfirmarCompra.Name = "btnConfirmarCompra"
        btnConfirmarCompra.Size = New Size(138, 32)
        btnConfirmarCompra.TabIndex = 26
        btnConfirmarCompra.Text = "Confirmar Compra"
        btnConfirmarCompra.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Snow
        Label5.Location = New Point(211, 399)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 15)
        Label5.TabIndex = 27
        Label5.Text = "Nombre del repuesto:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Snow
        Label2.Location = New Point(211, 434)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 28
        Label2.Text = "Precio:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Snow
        Label3.Location = New Point(211, 472)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 29
        Label3.Text = "Cantidad:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Snow
        Label4.Location = New Point(211, 511)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 30
        Label4.Text = "Rut Cliente:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Snow
        Label6.Location = New Point(211, 550)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 31
        Label6.Text = "Fecha:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Snow
        Label7.Location = New Point(211, 590)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 15)
        Label7.TabIndex = 32
        Label7.Text = "Total a Pagar:"
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = SystemColors.ActiveCaptionText
        btnVolver.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVolver.ForeColor = SystemColors.ButtonHighlight
        btnVolver.Location = New Point(745, 668)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(94, 34)
        btnVolver.TabIndex = 33
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' btnHistorialVentas
        ' 
        btnHistorialVentas.BackColor = SystemColors.ActiveCaptionText
        btnHistorialVentas.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHistorialVentas.ForeColor = SystemColors.ButtonHighlight
        btnHistorialVentas.Location = New Point(555, 99)
        btnHistorialVentas.Name = "btnHistorialVentas"
        btnHistorialVentas.Size = New Size(141, 32)
        btnHistorialVentas.TabIndex = 34
        btnHistorialVentas.Text = "Ir a Historial de Ventas"
        btnHistorialVentas.UseVisualStyleBackColor = False
        ' 
        ' FormVentasRepuestos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(851, 714)
        Controls.Add(btnHistorialVentas)
        Controls.Add(btnVolver)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(btnConfirmarCompra)
        Controls.Add(txtTotalPagar)
        Controls.Add(dtpFecha)
        Controls.Add(txtNombreCliente)
        Controls.Add(txtCantidad)
        Controls.Add(txtPrecio)
        Controls.Add(txtNombreRepuesto)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Controls.Add(dgvRepuestos)
        Controls.Add(btnVerTodo)
        Controls.Add(btnBuscar)
        Controls.Add(txtBuscar)
        Name = "FormVentasRepuestos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormVentasRepuestos"
        CType(dgvRepuestos, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnVerTodo As Button
    Friend WithEvents dgvRepuestos As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreRepuesto As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtTotalPagar As TextBox
    Friend WithEvents btnConfirmarCompra As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnHistorialVentas As Button
End Class

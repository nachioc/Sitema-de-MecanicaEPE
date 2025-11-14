<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionRepuestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGestionRepuestos))
        btnBuscarPanel = New Button()
        btnAgregarPanel = New Button()
        btnModificarPanel = New Button()
        btnVolver = New Button()
        Panel1 = New Panel()
        pnlBuscar = New Panel()
        Panel4 = New Panel()
        Label12 = New Label()
        dgvBuscar = New DataGridView()
        btnVisualizar = New Button()
        btnBuscar = New Button()
        txtBuscar = New TextBox()
        pnlAgregar = New Panel()
        Panel2 = New Panel()
        Label10 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnAgregar = New Button()
        txtProveedorAgregar = New TextBox()
        txtPrecioAgregar = New TextBox()
        txtCantidadAgregar = New TextBox()
        txtNombreAgregar = New TextBox()
        pnlModificarEliminar = New Panel()
        PictureBox2 = New PictureBox()
        Panel3 = New Panel()
        Label11 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        btnEliminar = New Button()
        btnModificar = New Button()
        txtProveedorModificar = New TextBox()
        txtPrecioModificar = New TextBox()
        txtCantidadModificar = New TextBox()
        txtNombreModificar = New TextBox()
        txtIDModificar = New TextBox()
        Panel1.SuspendLayout()
        pnlBuscar.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvBuscar, ComponentModel.ISupportInitialize).BeginInit()
        pnlAgregar.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlModificarEliminar.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBuscarPanel
        ' 
        btnBuscarPanel.BackColor = SystemColors.ActiveCaptionText
        btnBuscarPanel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscarPanel.ForeColor = SystemColors.ButtonHighlight
        btnBuscarPanel.Location = New Point(3, 6)
        btnBuscarPanel.Name = "btnBuscarPanel"
        btnBuscarPanel.Size = New Size(138, 32)
        btnBuscarPanel.TabIndex = 3
        btnBuscarPanel.Text = "Buscar y Visualizar"
        btnBuscarPanel.UseVisualStyleBackColor = False
        ' 
        ' btnAgregarPanel
        ' 
        btnAgregarPanel.BackColor = SystemColors.ActiveCaptionText
        btnAgregarPanel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgregarPanel.ForeColor = SystemColors.ButtonHighlight
        btnAgregarPanel.Location = New Point(146, 5)
        btnAgregarPanel.Name = "btnAgregarPanel"
        btnAgregarPanel.Size = New Size(128, 32)
        btnAgregarPanel.TabIndex = 4
        btnAgregarPanel.Text = "Agregar Repuesto"
        btnAgregarPanel.UseVisualStyleBackColor = False
        ' 
        ' btnModificarPanel
        ' 
        btnModificarPanel.BackColor = SystemColors.ActiveCaptionText
        btnModificarPanel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnModificarPanel.ForeColor = SystemColors.ButtonHighlight
        btnModificarPanel.Location = New Point(279, 5)
        btnModificarPanel.Name = "btnModificarPanel"
        btnModificarPanel.Size = New Size(142, 32)
        btnModificarPanel.TabIndex = 5
        btnModificarPanel.Text = "Modificar o Eliminar"
        btnModificarPanel.UseVisualStyleBackColor = False
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = SystemColors.ActiveCaptionText
        btnVolver.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVolver.ForeColor = SystemColors.ButtonHighlight
        btnVolver.Location = New Point(765, 6)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(94, 34)
        btnVolver.TabIndex = 6
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnBuscarPanel)
        Panel1.Controls.Add(btnAgregarPanel)
        Panel1.Controls.Add(btnVolver)
        Panel1.Controls.Add(btnModificarPanel)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(869, 46)
        Panel1.TabIndex = 7
        ' 
        ' pnlBuscar
        ' 
        pnlBuscar.Controls.Add(Panel4)
        pnlBuscar.Controls.Add(dgvBuscar)
        pnlBuscar.Controls.Add(btnVisualizar)
        pnlBuscar.Controls.Add(btnBuscar)
        pnlBuscar.Controls.Add(txtBuscar)
        pnlBuscar.Dock = DockStyle.Fill
        pnlBuscar.Location = New Point(0, 46)
        pnlBuscar.Margin = New Padding(3, 2, 3, 2)
        pnlBuscar.Name = "pnlBuscar"
        pnlBuscar.Size = New Size(869, 438)
        pnlBuscar.TabIndex = 8
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel4.Controls.Add(Label12)
        Panel4.ForeColor = SystemColors.ControlText
        Panel4.Location = New Point(94, 10)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(667, 50)
        Panel4.TabIndex = 17
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ButtonFace
        Label12.Location = New Point(203, 10)
        Label12.Name = "Label12"
        Label12.Size = New Size(228, 32)
        Label12.TabIndex = 10
        Label12.Text = "Buscar y Visualizar"
        ' 
        ' dgvBuscar
        ' 
        dgvBuscar.BackgroundColor = SystemColors.ActiveCaptionText
        dgvBuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuscar.Location = New Point(29, 133)
        dgvBuscar.Margin = New Padding(3, 2, 3, 2)
        dgvBuscar.Name = "dgvBuscar"
        dgvBuscar.RowHeadersWidth = 51
        dgvBuscar.Size = New Size(823, 293)
        dgvBuscar.TabIndex = 8
        ' 
        ' btnVisualizar
        ' 
        btnVisualizar.BackColor = SystemColors.ActiveCaptionText
        btnVisualizar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVisualizar.ForeColor = SystemColors.ButtonHighlight
        btnVisualizar.Location = New Point(322, 80)
        btnVisualizar.Name = "btnVisualizar"
        btnVisualizar.Size = New Size(138, 32)
        btnVisualizar.TabIndex = 7
        btnVisualizar.Text = "Visualizar"
        btnVisualizar.UseVisualStyleBackColor = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = SystemColors.ActiveCaptionText
        btnBuscar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBuscar.ForeColor = SystemColors.ButtonHighlight
        btnBuscar.Location = New Point(171, 80)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(138, 32)
        btnBuscar.TabIndex = 6
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(38, 86)
        txtBuscar.Margin = New Padding(3, 2, 3, 2)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(110, 23)
        txtBuscar.TabIndex = 0
        ' 
        ' pnlAgregar
        ' 
        pnlAgregar.Controls.Add(Panel2)
        pnlAgregar.Controls.Add(PictureBox1)
        pnlAgregar.Controls.Add(Label4)
        pnlAgregar.Controls.Add(Label3)
        pnlAgregar.Controls.Add(Label2)
        pnlAgregar.Controls.Add(Label1)
        pnlAgregar.Controls.Add(btnAgregar)
        pnlAgregar.Controls.Add(txtProveedorAgregar)
        pnlAgregar.Controls.Add(txtPrecioAgregar)
        pnlAgregar.Controls.Add(txtCantidadAgregar)
        pnlAgregar.Controls.Add(txtNombreAgregar)
        pnlAgregar.Dock = DockStyle.Fill
        pnlAgregar.Location = New Point(0, 46)
        pnlAgregar.Margin = New Padding(3, 2, 3, 2)
        pnlAgregar.Name = "pnlAgregar"
        pnlAgregar.Size = New Size(869, 438)
        pnlAgregar.TabIndex = 9
        pnlAgregar.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel2.Controls.Add(Label10)
        Panel2.ForeColor = SystemColors.ControlText
        Panel2.Location = New Point(97, 13)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(667, 50)
        Panel2.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label10.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ButtonFace
        Label10.Location = New Point(225, 9)
        Label10.Name = "Label10"
        Label10.Size = New Size(220, 32)
        Label10.TabIndex = 10
        Label10.Text = "Agregar Repuesto"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(407, 75)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(445, 330)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.Snow
        Label4.Location = New Point(13, 264)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 15)
        Label4.TabIndex = 13
        Label4.Text = "Proovedor:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.Snow
        Label3.Location = New Point(13, 226)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 15)
        Label3.TabIndex = 12
        Label3.Text = "Precio Unitario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.Snow
        Label2.Location = New Point(13, 197)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 15)
        Label2.TabIndex = 11
        Label2.Text = "Cantidad de Stock:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.Snow
        Label1.Location = New Point(13, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 15)
        Label1.TabIndex = 10
        Label1.Text = "Nombre de Repuesto:"
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = SystemColors.ActiveCaptionText
        btnAgregar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgregar.ForeColor = SystemColors.ButtonHighlight
        btnAgregar.Location = New Point(153, 316)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(94, 32)
        btnAgregar.TabIndex = 4
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' txtProveedorAgregar
        ' 
        txtProveedorAgregar.Location = New Point(153, 259)
        txtProveedorAgregar.Margin = New Padding(3, 2, 3, 2)
        txtProveedorAgregar.Name = "txtProveedorAgregar"
        txtProveedorAgregar.Size = New Size(210, 23)
        txtProveedorAgregar.TabIndex = 3
        ' 
        ' txtPrecioAgregar
        ' 
        txtPrecioAgregar.Location = New Point(153, 226)
        txtPrecioAgregar.Margin = New Padding(3, 2, 3, 2)
        txtPrecioAgregar.Name = "txtPrecioAgregar"
        txtPrecioAgregar.Size = New Size(210, 23)
        txtPrecioAgregar.TabIndex = 2
        ' 
        ' txtCantidadAgregar
        ' 
        txtCantidadAgregar.Location = New Point(153, 195)
        txtCantidadAgregar.Margin = New Padding(3, 2, 3, 2)
        txtCantidadAgregar.Name = "txtCantidadAgregar"
        txtCantidadAgregar.Size = New Size(210, 23)
        txtCantidadAgregar.TabIndex = 1
        ' 
        ' txtNombreAgregar
        ' 
        txtNombreAgregar.Location = New Point(153, 161)
        txtNombreAgregar.Margin = New Padding(3, 2, 3, 2)
        txtNombreAgregar.Name = "txtNombreAgregar"
        txtNombreAgregar.Size = New Size(210, 23)
        txtNombreAgregar.TabIndex = 0
        ' 
        ' pnlModificarEliminar
        ' 
        pnlModificarEliminar.Controls.Add(PictureBox2)
        pnlModificarEliminar.Controls.Add(Panel3)
        pnlModificarEliminar.Controls.Add(Label9)
        pnlModificarEliminar.Controls.Add(Label8)
        pnlModificarEliminar.Controls.Add(Label7)
        pnlModificarEliminar.Controls.Add(Label6)
        pnlModificarEliminar.Controls.Add(Label5)
        pnlModificarEliminar.Controls.Add(btnEliminar)
        pnlModificarEliminar.Controls.Add(btnModificar)
        pnlModificarEliminar.Controls.Add(txtProveedorModificar)
        pnlModificarEliminar.Controls.Add(txtPrecioModificar)
        pnlModificarEliminar.Controls.Add(txtCantidadModificar)
        pnlModificarEliminar.Controls.Add(txtNombreModificar)
        pnlModificarEliminar.Controls.Add(txtIDModificar)
        pnlModificarEliminar.Dock = DockStyle.Fill
        pnlModificarEliminar.Location = New Point(0, 46)
        pnlModificarEliminar.Margin = New Padding(3, 2, 3, 2)
        pnlModificarEliminar.Name = "pnlModificarEliminar"
        pnlModificarEliminar.Size = New Size(869, 438)
        pnlModificarEliminar.TabIndex = 15
        pnlModificarEliminar.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(407, 86)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(445, 330)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel3.Controls.Add(Label11)
        Panel3.ForeColor = SystemColors.ControlText
        Panel3.Location = New Point(100, 22)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(667, 50)
        Panel3.TabIndex = 17
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label11.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ButtonFace
        Label11.Location = New Point(203, 10)
        Label11.Name = "Label11"
        Label11.Size = New Size(244, 32)
        Label11.TabIndex = 10
        Label11.Text = "Modificar / Eliminar"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Snow
        Label9.Location = New Point(66, 266)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 15)
        Label9.TabIndex = 14
        Label9.Text = "Proovedor:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Snow
        Label8.Location = New Point(66, 230)
        Label8.Name = "Label8"
        Label8.Size = New Size(123, 15)
        Label8.TabIndex = 13
        Label8.Text = "Precio Del Repuesto:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Snow
        Label7.Location = New Point(66, 199)
        Label7.Name = "Label7"
        Label7.Size = New Size(115, 15)
        Label7.TabIndex = 12
        Label7.Text = "Stock de Repuesto:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Snow
        Label6.Location = New Point(66, 166)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 15)
        Label6.TabIndex = 11
        Label6.Text = "Nombre de Repuesto:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Snow
        Label5.Location = New Point(66, 130)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 15)
        Label5.TabIndex = 10
        Label5.Text = "ID de Repuesto:"
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = SystemColors.ActiveCaptionText
        btnEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminar.ForeColor = SystemColors.ButtonHighlight
        btnEliminar.Location = New Point(228, 324)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(94, 32)
        btnEliminar.TabIndex = 5
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnModificar
        ' 
        btnModificar.BackColor = SystemColors.ActiveCaptionText
        btnModificar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnModificar.ForeColor = SystemColors.ButtonHighlight
        btnModificar.Location = New Point(100, 324)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(94, 32)
        btnModificar.TabIndex = 4
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' txtProveedorModificar
        ' 
        txtProveedorModificar.Location = New Point(207, 264)
        txtProveedorModificar.Margin = New Padding(3, 2, 3, 2)
        txtProveedorModificar.Name = "txtProveedorModificar"
        txtProveedorModificar.Size = New Size(135, 23)
        txtProveedorModificar.TabIndex = 3
        ' 
        ' txtPrecioModificar
        ' 
        txtPrecioModificar.Location = New Point(207, 228)
        txtPrecioModificar.Margin = New Padding(3, 2, 3, 2)
        txtPrecioModificar.Name = "txtPrecioModificar"
        txtPrecioModificar.Size = New Size(135, 23)
        txtPrecioModificar.TabIndex = 2
        ' 
        ' txtCantidadModificar
        ' 
        txtCantidadModificar.Location = New Point(207, 196)
        txtCantidadModificar.Margin = New Padding(3, 2, 3, 2)
        txtCantidadModificar.Name = "txtCantidadModificar"
        txtCantidadModificar.Size = New Size(135, 23)
        txtCantidadModificar.TabIndex = 1
        ' 
        ' txtNombreModificar
        ' 
        txtNombreModificar.Location = New Point(207, 164)
        txtNombreModificar.Margin = New Padding(3, 2, 3, 2)
        txtNombreModificar.Name = "txtNombreModificar"
        txtNombreModificar.Size = New Size(135, 23)
        txtNombreModificar.TabIndex = 0
        ' 
        ' txtIDModificar
        ' 
        txtIDModificar.Location = New Point(207, 128)
        txtIDModificar.Margin = New Padding(3, 2, 3, 2)
        txtIDModificar.Name = "txtIDModificar"
        txtIDModificar.Size = New Size(135, 23)
        txtIDModificar.TabIndex = 0
        ' 
        ' FormGestionRepuestos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(869, 484)
        Controls.Add(pnlAgregar)
        Controls.Add(pnlBuscar)
        Controls.Add(pnlModificarEliminar)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormGestionRepuestos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        pnlBuscar.ResumeLayout(False)
        pnlBuscar.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dgvBuscar, ComponentModel.ISupportInitialize).EndInit()
        pnlAgregar.ResumeLayout(False)
        pnlAgregar.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlModificarEliminar.ResumeLayout(False)
        pnlModificarEliminar.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBuscarPanel As Button
    Friend WithEvents btnAgregarPanel As Button
    Friend WithEvents btnModificarPanel As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlBuscar As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvBuscar As DataGridView
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents pnlAgregar As Panel
    Friend WithEvents txtProveedorAgregar As TextBox
    Friend WithEvents txtPrecioAgregar As TextBox
    Friend WithEvents txtCantidadAgregar As TextBox
    Friend WithEvents txtNombreAgregar As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlModificarEliminar As Panel
    Friend WithEvents txtProveedorModificar As TextBox
    Friend WithEvents txtPrecioModificar As TextBox
    Friend WithEvents txtCantidadModificar As TextBox
    Friend WithEvents txtNombreModificar As TextBox
    Friend WithEvents txtIDModificar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class

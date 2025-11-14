<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHistorialVentas
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
        dgvHistorial = New DataGridView()
        Panel4 = New Panel()
        Label12 = New Label()
        txtRut = New TextBox()
        dtpDesde = New DateTimePicker()
        btnVolver = New Button()
        dtpHasta = New DateTimePicker()
        chkFiltrarFecha = New CheckBox()
        Label4 = New Label()
        btnBuscar = New Button()
        btnVerTodo = New Button()
        CType(dgvHistorial, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvHistorial
        ' 
        dgvHistorial.BackgroundColor = SystemColors.ActiveCaptionText
        dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHistorial.Location = New Point(131, 127)
        dgvHistorial.Margin = New Padding(3, 2, 3, 2)
        dgvHistorial.Name = "dgvHistorial"
        dgvHistorial.RowHeadersWidth = 51
        dgvHistorial.Size = New Size(657, 272)
        dgvHistorial.TabIndex = 10
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel4.Controls.Add(Label12)
        Panel4.ForeColor = SystemColors.ControlText
        Panel4.Location = New Point(67, 11)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(667, 50)
        Panel4.TabIndex = 19
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ButtonFace
        Label12.Location = New Point(213, 9)
        Label12.Name = "Label12"
        Label12.Size = New Size(228, 32)
        Label12.TabIndex = 10
        Label12.Text = "Historial de Ventas"
        ' 
        ' txtRut
        ' 
        txtRut.Location = New Point(12, 144)
        txtRut.Margin = New Padding(3, 2, 3, 2)
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(113, 23)
        txtRut.TabIndex = 24
        ' 
        ' dtpDesde
        ' 
        dtpDesde.CalendarFont = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpDesde.Format = DateTimePickerFormat.Short
        dtpDesde.Location = New Point(12, 206)
        dtpDesde.Name = "dtpDesde"
        dtpDesde.Size = New Size(113, 23)
        dtpDesde.TabIndex = 25
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = SystemColors.ActiveCaptionText
        btnVolver.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVolver.ForeColor = SystemColors.ButtonHighlight
        btnVolver.Location = New Point(694, 404)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(94, 34)
        btnVolver.TabIndex = 34
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' dtpHasta
        ' 
        dtpHasta.Format = DateTimePickerFormat.Short
        dtpHasta.Location = New Point(12, 235)
        dtpHasta.Name = "dtpHasta"
        dtpHasta.Size = New Size(113, 23)
        dtpHasta.TabIndex = 35
        ' 
        ' chkFiltrarFecha
        ' 
        chkFiltrarFecha.AutoSize = True
        chkFiltrarFecha.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkFiltrarFecha.ForeColor = SystemColors.ButtonHighlight
        chkFiltrarFecha.Location = New Point(12, 181)
        chkFiltrarFecha.Name = "chkFiltrarFecha"
        chkFiltrarFecha.Size = New Size(94, 19)
        chkFiltrarFecha.TabIndex = 36
        chkFiltrarFecha.Text = "Filtrar Fecha"
        chkFiltrarFecha.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Snow
        Label4.Location = New Point(12, 127)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 37
        Label4.Text = "Rut Cliente:"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = SystemColors.ActiveCaptionText
        btnBuscar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscar.ForeColor = SystemColors.ButtonHighlight
        btnBuscar.Location = New Point(22, 277)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(72, 32)
        btnBuscar.TabIndex = 38
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' btnVerTodo
        ' 
        btnVerTodo.BackColor = SystemColors.ActiveCaptionText
        btnVerTodo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerTodo.ForeColor = SystemColors.ButtonHighlight
        btnVerTodo.Location = New Point(22, 315)
        btnVerTodo.Name = "btnVerTodo"
        btnVerTodo.Size = New Size(72, 32)
        btnVerTodo.TabIndex = 39
        btnVerTodo.Text = "Visualizar"
        btnVerTodo.UseVisualStyleBackColor = False
        ' 
        ' FormHistorialVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(800, 450)
        Controls.Add(btnVerTodo)
        Controls.Add(btnBuscar)
        Controls.Add(Label4)
        Controls.Add(chkFiltrarFecha)
        Controls.Add(dtpHasta)
        Controls.Add(btnVolver)
        Controls.Add(dtpDesde)
        Controls.Add(txtRut)
        Controls.Add(Panel4)
        Controls.Add(dgvHistorial)
        Name = "FormHistorialVentas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormHistorialVentas"
        CType(dgvHistorial, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvHistorial As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents btnVolver As Button
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents chkFiltrarFecha As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnVerTodo As Button
End Class

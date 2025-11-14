<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        btnEmpleados = New Button()
        btnUsuarios = New Button()
        btnClientes = New Button()
        btnRepuestos = New Button()
        btnSiniestros = New Button()
        btnVentas = New Button()
        btnSalir = New Button()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        lblBienvenida = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnEmpleados
        ' 
        btnEmpleados.BackColor = SystemColors.ActiveCaptionText
        btnEmpleados.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEmpleados.ForeColor = SystemColors.ButtonHighlight
        btnEmpleados.Location = New Point(10, 256)
        btnEmpleados.Name = "btnEmpleados"
        btnEmpleados.Size = New Size(94, 32)
        btnEmpleados.TabIndex = 0
        btnEmpleados.Text = "Empleados"
        btnEmpleados.UseVisualStyleBackColor = False
        ' 
        ' btnUsuarios
        ' 
        btnUsuarios.BackColor = SystemColors.ActiveCaptionText
        btnUsuarios.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUsuarios.ForeColor = SystemColors.ButtonHighlight
        btnUsuarios.Location = New Point(10, 104)
        btnUsuarios.Name = "btnUsuarios"
        btnUsuarios.Size = New Size(94, 32)
        btnUsuarios.TabIndex = 0
        btnUsuarios.Text = "Usuarios"
        btnUsuarios.UseVisualStyleBackColor = False
        ' 
        ' btnClientes
        ' 
        btnClientes.BackColor = SystemColors.ActiveCaptionText
        btnClientes.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnClientes.ForeColor = SystemColors.ButtonHighlight
        btnClientes.Location = New Point(10, 218)
        btnClientes.Name = "btnClientes"
        btnClientes.Size = New Size(94, 32)
        btnClientes.TabIndex = 2
        btnClientes.Text = "Clientes"
        btnClientes.UseVisualStyleBackColor = False
        ' 
        ' btnRepuestos
        ' 
        btnRepuestos.BackColor = SystemColors.ActiveCaptionText
        btnRepuestos.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnRepuestos.ForeColor = SystemColors.ButtonHighlight
        btnRepuestos.Location = New Point(10, 142)
        btnRepuestos.Name = "btnRepuestos"
        btnRepuestos.Size = New Size(94, 32)
        btnRepuestos.TabIndex = 3
        btnRepuestos.Text = "Repuestos"
        btnRepuestos.UseVisualStyleBackColor = False
        ' 
        ' btnSiniestros
        ' 
        btnSiniestros.BackColor = SystemColors.ActiveCaptionText
        btnSiniestros.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSiniestros.ForeColor = SystemColors.ButtonHighlight
        btnSiniestros.Location = New Point(10, 294)
        btnSiniestros.Name = "btnSiniestros"
        btnSiniestros.Size = New Size(94, 32)
        btnSiniestros.TabIndex = 0
        btnSiniestros.Text = "Siniestros"
        btnSiniestros.UseVisualStyleBackColor = False
        ' 
        ' btnVentas
        ' 
        btnVentas.BackColor = SystemColors.ActiveCaptionText
        btnVentas.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVentas.ForeColor = SystemColors.ButtonHighlight
        btnVentas.Location = New Point(10, 180)
        btnVentas.Name = "btnVentas"
        btnVentas.Size = New Size(94, 32)
        btnVentas.TabIndex = 5
        btnVentas.Text = "Ventas"
        btnVentas.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = SystemColors.ActiveCaptionText
        btnSalir.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = SystemColors.ButtonHighlight
        btnSalir.Location = New Point(584, 371)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(94, 32)
        btnSalir.TabIndex = 7
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(240, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(177, 32)
        Label4.TabIndex = 10
        Label4.Text = "Mecanica Plus"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(326, 104)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(351, 254)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel1.Controls.Add(Label4)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(10, 7)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(667, 50)
        Panel1.TabIndex = 12
        ' 
        ' lblBienvenida
        ' 
        lblBienvenida.AutoSize = True
        lblBienvenida.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblBienvenida.ForeColor = SystemColors.ButtonHighlight
        lblBienvenida.Location = New Point(10, 72)
        lblBienvenida.Name = "lblBienvenida"
        lblBienvenida.Size = New Size(32, 15)
        lblBienvenida.TabIndex = 13
        lblBienvenida.Text = "Hola"
        ' 
        ' MainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(688, 442)
        Controls.Add(lblBienvenida)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(btnSalir)
        Controls.Add(btnVentas)
        Controls.Add(btnSiniestros)
        Controls.Add(btnRepuestos)
        Controls.Add(btnClientes)
        Controls.Add(btnUsuarios)
        Controls.Add(btnEmpleados)
        Name = "MainMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainMenu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEmpleados As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnRepuestos As Button
    Friend WithEvents btnSiniestros As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblBienvenida As Label
End Class

Imports MySql.Data.MySqlClient


Public Class FormVentasRepuestos

    Public Shared Instance As FormVentasRepuestos

    Private Sub FormVentasRepuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Instance = Me
        CargarRepuestos()
    End Sub
    Private Sub CargarRepuestos()
        Using conn As MySqlConnection = ObtenerConexion()
            Dim sql As String = "SELECT RepuestoID, NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor FROM repuestos"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvRepuestos.DataSource = dt
        End Using
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Using conn As MySqlConnection = ObtenerConexion()
            Dim sql As String = "SELECT RepuestoID, NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor FROM repuestos WHERE RepuestoID LIKE @buscar OR NombreRepuesto LIKE @buscar"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@buscar", "%" & txtBuscar.Text.Trim() & "%")
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvRepuestos.DataSource = dt
        End Using
    End Sub
    Private Sub btnVerTodo_Click(sender As Object, e As EventArgs) Handles btnVerTodo.Click
        CargarRepuestos()
    End Sub
    Private Sub dgvRepuestos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRepuestos.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvRepuestos.Rows(e.RowIndex)
            txtNombreRepuesto.Text = fila.Cells("NombreRepuesto").Value.ToString()
            txtPrecio.Text = fila.Cells("PrecioUnitario").Value.ToString()
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Dim precio As Decimal
        Dim cantidad As Integer

        If Decimal.TryParse(txtPrecio.Text, precio) AndAlso Integer.TryParse(txtCantidad.Text, cantidad) Then
            txtTotalPagar.Text = (precio * cantidad).ToString("N2")
        Else
            txtTotalPagar.Clear()
        End If
    End Sub
    Private Sub btnConfirmarCompra_Click(sender As Object, e As EventArgs) Handles btnConfirmarCompra.Click
        If String.IsNullOrWhiteSpace(txtNombreRepuesto.Text) OrElse
           String.IsNullOrWhiteSpace(txtCantidad.Text) OrElse
           String.IsNullOrWhiteSpace(txtNombreCliente.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As MySqlConnection = ObtenerConexion()
            conn.Open()
            Dim trans As MySqlTransaction = conn.BeginTransaction()

            Try

                Dim insertVenta As String = "INSERT INTO ventasrepuestos (NombreRepuesto, CantidadVendida, Cliente , FechaVenta, Total) " &
                           "VALUES (@nombre, @cantidad, @cliente, @fecha, @total)"
                Dim cmdInsert As New MySqlCommand(insertVenta, conn, trans)
                cmdInsert.Parameters.AddWithValue("@nombre", txtNombreRepuesto.Text)
                cmdInsert.Parameters.AddWithValue("@cantidad", Integer.Parse(txtCantidad.Text))
                cmdInsert.Parameters.AddWithValue("@cliente", txtNombreCliente.Text)
                cmdInsert.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date)
                cmdInsert.Parameters.AddWithValue("@total", Decimal.Parse(txtTotalPagar.Text))
                cmdInsert.ExecuteNonQuery()

                Dim updateStock As String = "UPDATE repuestos SET CantidadStock = CantidadStock - @cantidad WHERE NombreRepuesto = @nombre AND CantidadStock >= @cantidad"
                Dim cmdUpdate As New MySqlCommand(updateStock, conn, trans)
                cmdUpdate.Parameters.AddWithValue("@cantidad", Integer.Parse(txtCantidad.Text))
                cmdUpdate.Parameters.AddWithValue("@nombre", txtNombreRepuesto.Text)
                Dim rowsAffected As Integer = cmdUpdate.ExecuteNonQuery()

                If rowsAffected = 0 Then
                    Throw New Exception("Stock insuficiente para completar la venta.")
                End If

                trans.Commit()
                MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarRepuestos()
                LimpiarCampos()

            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("Error al registrar venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub LimpiarCampos()
        txtNombreRepuesto.Clear()
        txtPrecio.Clear()
        txtCantidad.Clear()
        txtNombreCliente.Clear()
        txtTotalPagar.Clear()
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        If MainMenu.Instance IsNot Nothing AndAlso Not MainMenu.Instance.IsDisposed Then
            MainMenu.Instance.Show()
        Else

            Dim menu As New MainMenu()
            MainMenu.Instance = menu
            menu.Show()
        End If

        Me.Close()
    End Sub


    Private Sub btnHistorialVentas_Click(sender As Object, e As EventArgs) Handles btnHistorialVentas.Click
        Dim frm As New FormHistorialVentas()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub Boton_MouseEnter(sender As Object, e As EventArgs) Handles btnBuscar.MouseEnter, btnVerTodo.MouseEnter, btnConfirmarCompra.MouseEnter, btnVolver.MouseEnter
        CType(sender, Button).BackColor = Color.Orange
    End Sub
    Private Sub Boton_MouseLeave(sender As Object, e As EventArgs) Handles btnBuscar.MouseLeave, btnVerTodo.MouseLeave, btnConfirmarCompra.MouseLeave, btnVolver.MouseLeave
        CType(sender, Button).BackColor = Color.Black
    End Sub

End Class

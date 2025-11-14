Imports MySql.Data.MySqlClient

Module ModuloConexion
    ' 🔹 Conexión central a tu base de datos local XAMPP
    Public connectionString As String = "server=localhost; user id=root; password=; database=taller;"

    ' 🔹 Función para obtener la conexión (reutilizable)
    Public Function ObtenerConexion() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function
End Module

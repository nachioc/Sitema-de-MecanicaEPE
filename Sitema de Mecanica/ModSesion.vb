Module ModSesion
    Public UsuarioCorreoActual As String = ""
    Public UsuarioTipoActual As String = ""
    Public MainMenuInstance As MainMenu
    Public FormGestionUsuariosInstance As FormGestionUsuarios

    Public Sub CerrarSesion()
        UsuarioCorreoActual = ""
        UsuarioTipoActual = ""
        MainMenuInstance = Nothing
        FormGestionUsuariosInstance = Nothing
    End Sub
End Module

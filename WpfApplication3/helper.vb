Public Module Helper
    Public Property IsFullScreen As Boolean = False
    Private NightMode As Boolean = False
    Public Sub UpdateFullScreen(oform As Window)
        If IsFullScreen = True Then
            oform.WindowStyle = WindowStyle.None
            oform.WindowState = WindowState.Maximized
            oform.ResizeMode = ResizeMode.NoResize
        Else
            oform.WindowState = WindowState.Normal
            oform.WindowStyle = WindowStyle.SingleBorderWindow
            oform.ResizeMode = ResizeMode.CanResizeWithGrip
        End If
    End Sub

    Public Function ImageUri(name As String) As URI
        Return new URI("pack://application:,,,/translatornamespace;component/images/" + name)
    End Function
    Public Function RootUri(name As String) As URI
        Return new URI("pack://application:,,,/translatornamespace;component/" + name)
    End Function

    Public Function GetImage(name as string) As BitMapImage
        Return New BitMapImage(ImageUri(name))
    End Function
End Module


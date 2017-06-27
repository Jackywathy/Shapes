Imports System.IO
Imports System.Media
Imports System.Windows.Resources

Class MainWindow
    Public SharedVars As New Helper()

    Public current As Window = Me

    Private Sub Window_KeyDown(sender As Object, e As KeyEventArgs)
        If (e.Key = Key.D2 Or e.Key = Key.NumPad2) Then
            MessageBox.Show("play an animation!")
            switchTo(New SelectorScreen(Me))

        ElseIf (e.Key = Key.F11) Then
            SharedVars.ToggleFullScreen()
        End If

    End Sub


    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call

        SharedVars.RegisterWindow(Me)

    End Sub

    Public Sub switchTo(child As Window)
        SharedVars.AllScreen.Clear()
        SharedVars.RegisterWindow(child)
        current.Close()
        child.Show()
        current = child
    End Sub


End Class


Public Class Helper
    Private _isFullScreen As Boolean
    Private currentStyle As WindowStyle = WindowStyle.SingleBorderWindow
    Private currentState As WindowState = WindowState.Normal
    Private player As SoundPlayer

    Public Property IsFullScreen As Boolean
        Get
            Return _isFullScreen
        End Get
        Set(value As Boolean)
            If value Then
                ' go fullScreen
                currentStyle = WindowStyle.None
                currentState = WindowState.Maximized
                For Each i As Window In AllScreen
                    i.WindowStyle = currentStyle
                    i.WindowState = currentState

                Next
                _isFullScreen = value
            Else
                ' go out of fullscreen
                currentStyle = WindowStyle.SingleBorderWindow
                currentState = WindowState.Normal
                For Each i As Window In AllScreen
                    i.WindowStyle = currentStyle
                    i.WindowState = currentState
                Next
                _isFullScreen = value
            End If
        End Set
    End Property

    Public AllScreen As New List(Of Window)

    Public Sub RegisterWindow(control As Window)
        AllScreen.Add(control)
        control.WindowStyle = currentStyle
        control.WindowState = currentState
    End Sub

    Public Sub ToggleFullScreen()
        IsFullScreen = Not IsFullScreen
    End Sub

    Public Shared Function ImageUri(name As String) As Uri
        Return New Uri("pack://application:,,,/MarioShapes;component/images/" + name)
    End Function
    Public Shared Function RootUri(name As String) As Uri
        Return New Uri("pack://application:,,,/MarioShapes;component/" + name)
    End Function

    Public Shared Function GetImage(name As String) As BitmapImage
        Return New BitmapImage(ImageUri(name))
    End Function

    Public Shared Function GetSound(name As String) As Stream
        Return Application.GetResourceStream(New Uri("pack://application:,,,/MarioShapes;component/music/" + name)).Stream
    End Function

    Public Sub PlayMusic(name As String)
        If player IsNot Nothing Then
            player.Stop()
        End If
        player = New SoundPlayer(GetSound(name))
        player.PlayLooping()
    End Sub


End Class
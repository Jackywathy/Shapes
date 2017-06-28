Imports System.Windows.Threading

Public Class SelectorScreen
    Private parentWindow As MainWindow
    Private SharedVars As Helper

    Private BitMapMute As BitmapImage
    Private BitMapNoMute As BitmapImage

    Sub New(parent As MainWindow)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        parentWindow = parent
        SharedVars = parentWindow.SharedVars
        BitMapMute = SharedVars.GetImage("mute.png")
        BitMapNoMute = SharedVars.GetImage("no_mute.png")
    End Sub



    Private Sub Canvas_MouseMove(sender As Object, e As MouseEventArgs)
        Dim clock As New DispatcherTimer
        clock.Interval = TimeSpan.FromMilliseconds(10)
    End Sub

    Private Sub quiz_Click(sender As Object, e As RoutedEventArgs) Handles quizButton.Click
        parentWindow.switchTo(new Quiz(parentWindow))
    End Sub

    Private Sub TwoDimButton_Click(sender As Object, e As RoutedEventArgs) Handles TwoDimButton.Click
        parentWindow.switchTo(New TwoDimShapes(parentWindow))
    End Sub

    Private Sub Window_KeyDown(sender As Object, e As KeyEventArgs)
        If (e.Key = Key.F11) Then
            parentWindow.SharedVars.ToggleFullScreen()
        End If

    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        SharedVars.PlayMusic("intro.wav")
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As RoutedEventArgs) Handles ExitButton.Click
        If MessageBox.Show("Are you sure you want to quit?", "Exiting", MessageBoxButton.YesNo, MessageBoxImage.Information) = MessageBoxResult.Yes
            Me.Close
        End If
    End Sub

    Private Sub MuteButton_Click(sender As Object, e As RoutedEventArgs) Handles MuteButton.Click
        SharedVars.IsMuted = Not SharedVars.IsMuted
        if SharedVars.IsMuted
            MuteImage.Source = BitMapMute
            SharedVars.StopMusic()
        Else
            MuteImage.Source = BitMapNoMute
            SharedVars.PlayMusic("intro.wav")
        End If
    End Sub

    Private Sub threeDimButton_Click(sender As Object, e As RoutedEventArgs) Handles threeDimButton.Click
        Parentwindow.switchTo(New ThreeDimShapes(parentWindow))
    End Sub
End Class

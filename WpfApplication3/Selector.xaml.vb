Imports System.Windows.Threading

Public Class SelectorScreen
    Private parentWindow As MainWindow
    Private SharedVars As Helper
    Sub New(parent As MainWindow)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        parentWindow = parent
        SharedVars = parentWindow.SharedVars
    End Sub

    Private Sub OverPipe(sender As Object, e As MouseEventArgs)

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
End Class

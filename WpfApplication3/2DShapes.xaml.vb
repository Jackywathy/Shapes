Imports System.Collections.Specialized

Public Class TwoDimShapes 
    Implements INotifyCollectionChanged
    Public Event CollectionChanged As NotifyCollectionChangedEventHandler Implements INotifyCollectionChanged.CollectionChanged




    Public ParentWindow As MainWindow
    Public SharedVars As Helper

    Public Buttons As List(Of Button)
    

    Public Sub New(parent As MainWindow)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ParentWindow = parent
        Me.SharedVars = parent.SharedVars

        Me.DataContext = Me
        Buttons = New List(Of Button) From {RectangleButton, CircleButton, TrapeziumButton, TriangleButton, ParallelButton, EllipseButton}


        Rectangle_Button_Click(RectangleButton, Nothing)

    End Sub


    Private Sub Window_KeyDown(sender As Object, e As KeyEventArgs)
        If (e.Key = Key.F11) Then
            SharedVars.ToggleFullScreen()
        End If

    End Sub

    Private Sub Button_2D_Click(sender As Object, e As RoutedEventArgs) Handles Button_2D.Click
        ' this should be impossible, as this is the 2d shape frame!
        Throw New Exception("THIS IS IMPOSSIBLE!!!!!! YOUR ALREADY 2D dammmmmit")
    End Sub

    Private Sub Button_3D_Click(sender As Object, e As RoutedEventArgs) Handles Button_3D.Click
        ParentWindow.switchTo(New ThreeDimShapes(ParentWindow))
    End Sub

    Private Sub ClearButtons()
        For Each Button In Buttons
            ' set margin on all butons
            Button.IsEnabled = True
            Button.Margin = New Thickness(0, 15, 15, 15)
        Next
    End Sub


    Private Sub Rectangle_Button_Click(sender As Object, e As RoutedEventArgs) Handles RectangleButton.Click, TrapeziumButton.Click, ParallelButton.Click, CircleButton.Click, EllipseButton.Click, ParallelButton.Click, TriangleButton.Click
        ' assume sender is Button
        ClearButtons()
        Dim senderButton As Button = sender

        If senderButton.Equals(RectangleButton) Then
            MainTab.BorderBrush = RectangleButton.Background

        ElseIf senderButton.Equals(TrapeziumButton) Then
            MainTab.BorderBrush = TrapeziumButton.Background

        ElseIf senderButton.Equals(TriangleButton) Then
            MainTab.BorderBrush = TriangleButton.Background

        ElseIf senderButton.Equals(ParallelButton) Then
            MainTab.BorderBrush = ParallelButton.Background

        ElseIf senderButton.Equals(CircleButton) Then
            MainTab.BorderBrush = CircleButton.Background

        ElseIf senderButton.Equals(EllipseButton) Then
            MainTab.BorderBrush = EllipseButton.Background
        End If
        senderButton.Margin = New Thickness(0, 5, 0, 5)


    End Sub

    Private Const AspectRatio As Double = 1.6








    'Private Sub Button_2D_pressed(sender As Object, e As RoutedEventArgs) Handles Button_2D.Click
    '    Button_2D.IsEnabled = False
    '    Button_3D.IsEnabled = True
    'End Sub


    'Private Sub Button_3D_pressed(sender As Object, e As RoutedEventArgs) Handles Button_3D.Click
    '    Button_2D.IsEnabled = True
    '    Button_3D.IsEnabled = False
    '    Dim x As New MainWindow
    '    SharedVars.RegisterWindow(x)
    '    x.ShowDialog()
    'End Sub
End Class


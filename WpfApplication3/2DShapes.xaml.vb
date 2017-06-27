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
            RectangleTab.IsSelected = True
        ElseIf senderButton.Equals(TrapeziumButton) Then
            MainTab.BorderBrush = TrapeziumButton.Background
            TrapeziumTab.IsSelected = True
        ElseIf senderButton.Equals(TriangleButton) Then
            MainTab.BorderBrush = TriangleButton.Background
            TriangleTab.IsSelected = True
        ElseIf senderButton.Equals(ParallelButton) Then
            MainTab.BorderBrush = ParallelButton.Background
            ParallelTab.IsEnabled = True
        ElseIf senderButton.Equals(CircleButton) Then
            MainTab.BorderBrush = CircleButton.Background
            CircleTab.IsEnabled = True
        ElseIf senderButton.Equals(EllipseButton) Then
            MainTab.BorderBrush = EllipseButton.Background
            EclipseTab.IsSelected = True
        End If
        senderButton.Margin = New Thickness(0, 5, 0, 5)


    End Sub



    Private Sub rectangleHeight_TextInput(sender As Object, e As TextChangedEventArgs) Handles RectangleHeight.TextChanged, RectangleWidth.TextChanged
        Dim hei As Integer = 0
        Dim wid As Integer = 0
        Integer.TryParse(RectangleWidth.Text, Wid)
        Integer.TryParse(RectangleHeight.Text, Hei)
        RectangleOut.Text = String.Format("{0} x {1} = {2} units²", wid, hei, wid * hei)

    End Sub

    Private Sub triangleHeight_TextInput(sender As Object, e As TextChangedEventArgs) Handles TriangleHeight.TextChanged, TriangleWidth.TextChanged
        Dim hei As Integer = 0
        Dim wid As Integer = 0
        Integer.TryParse(TriangleWidth.Text, Wid)
        Integer.TryParse(TriangleHeight.Text, Hei)
        TriangleOut.Text = String.Format("{0} x {1} = {2} units²", wid, hei, wid * hei)

    End Sub

    Public Sub trapHeight_TextInput(sender As Object, e As TextChangedEventArgs) Handles TrapTop.TextChanged, TrapBottom.TextChanged, TrapHeight.TextChanged
        Dim top As Integer = 0
        Dim bot As Integer = 0
        Dim hei As Integer = 0
        Integer.TryParse(TrapTop.Text, top)
        Integer.TryParse(TrapBottom.Text, bot)
        Integer.TryParse(TrapHeight.Text, hei)

        TrapOutTop.Text = String.Format("{0} x {1}", top, bot)
        TrapOutHeight.Text = String.Format(" x {0} = {1} Units²", hei, Math.Round((top + bot) / 2 * hei, MidpointRounding.AwayFromZero))
    End Sub

    Private Sub RectangleWidth_PreviewKeyDown(sender As Object, e As KeyEventArgs) Handles RectangleWidth.PreviewKeyDown, RectangleHeight.PreviewKeyDown, TriangleHeight.PreviewKeyDown, TriangleWidth.PreviewKeyDown, _
            TrapTop.PreviewKeyDown, TrapBottom.PreviewKeyDown
        If Not IsDigit(e.Key) Then
            e.Handled = True
        End If
    End Sub

    Private Function IsDigit(key As Key) As Boolean
        Select Case key
            Case Key.D0
            Case Key.D1
            Case Key.D2
            Case Key.D3
            Case Key.D4
            Case Key.D5
            Case Key.D6
            Case Key.D7
            Case Key.D8
            Case Key.D9
            Case Key.D0
            Case Key.NumLock
            Case Key.NumPad0
            Case Key.NumPad1
            Case Key.NumPad2
            Case Key.NumPad3
            Case Key.NumPad4
            Case Key.NumPad5
            Case Key.NumPad6
            Case Key.NumPad7
            Case Key.NumPad8
            Case Key.NumPad9
            Case Key.Back
            Case Else
                Return False
        End Select
        Return True

    End Function









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


Imports System.Collections.Specialized
Imports System.Media
Imports System.Windows.Controls.Primitives

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
        Buttons = New List(Of Button) From {RectangleButton, CircleButton, TrapeziumButton, TriangleButton, ParallelButton, RhombusButton}


        Rectangle_Button_Click(RectangleButton, Nothing)

    End Sub



    Private Sub Window_KeyDown(sender As Object, e As KeyEventArgs)
        If (e.Key = Key.F11) Then
            SharedVars.ToggleFullScreen()
        End If

    End Sub

    'Private Sub Button_2D_Click(sender As Object, e As RoutedEventArgs) Handles Button_2D.Click
    '    ' this should be impossible, as this is the 2d shape frame!
    '    Throw New Exception("THIS IS IMPOSSIBLE!!!!!! YOUR ALREADY 2D dammmmmit")
    'End Sub

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


    Private Sub Rectangle_Button_Click(sender As Object, e As RoutedEventArgs) Handles RectangleButton.Click, TrapeziumButton.Click, ParallelButton.Click, CircleButton.Click, RhombusButton.Click, ParallelButton.Click, TriangleButton.Click
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
            ParallelTab.IsSelected = True
        ElseIf senderButton.Equals(CircleButton) Then
            MainTab.BorderBrush = CircleButton.Background
            CircleTab.IsSelected = True
        ElseIf senderButton.Equals(RhombusButton) Then
            MainTab.BorderBrush = RhombusButton.Background
            RhombusTab.IsSelected = True
        End If
        senderButton.Margin = New Thickness(0, 5, 0, 5)


    End Sub



    Private Sub rectangleHeight_TextInput(sender As Object, e As TextChangedEventArgs) Handles RectangleHeight.TextChanged, RectangleWidth.TextChanged
        Dim hei As Integer = 0
        Dim wid As Integer = 0
        Integer.TryParse(RectangleWidth.Text, wid)
        Integer.TryParse(RectangleHeight.Text, hei)
        RectangleOut.Text = String.Format("Area = {0} x {1} = {2} units²", wid, hei, wid * hei)

    End Sub

    Private Sub triangleHeight_TextInput(sender As Object, e As TextChangedEventArgs) Handles TriangleHeight.TextChanged, TriangleWidth.TextChanged
        Dim hei As Integer = 0
        Dim wid As Integer = 0
        Integer.TryParse(TriangleWidth.Text, wid)
        Integer.TryParse(TriangleHeight.Text, hei)
        TriangleTop.Text = String.Format("{0} x {1}", wid, hei)
        TriangleRight.Text = String.Format("= {0} units²", Math.Round((wid * hei / 2), MidpointRounding.AwayFromZero))

    End Sub

    Private Sub parallelHeight_TextInput(sender As Object, e As TextChangedEventArgs) Handles ParallelHeight.TextChanged, ParallelWidth.TextChanged
        Dim hei As Integer = 0
        Dim wid As Integer = 0
        Integer.TryParse(ParallelHeight.Text, wid)
        Integer.TryParse(ParallelWidth.Text, hei)
        ParallelOut.Text = String.Format("Area = {0} x {1} = {2} units²", wid, hei, wid * hei)

    End Sub


    Public Sub trapHeight_TextInput(sender As Object, e As TextChangedEventArgs) Handles TrapTop.TextChanged, TrapBottom.TextChanged, TrapHeight.TextChanged
        Dim top As Integer = 0
        Dim bot As Integer = 0
        Dim hei As Integer = 0
        Integer.TryParse(TrapTop.Text, top)
        Integer.TryParse(TrapBottom.Text, bot)
        Integer.TryParse(TrapHeight.Text, hei)

        TrapOutTop.Text = String.Format("{0} + {1}", top, bot)
        TrapOutHeight.Text = String.Format(" x {0} = {1} units²", hei, Math.Round((top + bot) / 2 * hei, MidpointRounding.AwayFromZero))
    End Sub

    Public Sub circleHeight_TextInput(sender As Object, e As TextChangedEventArgs) Handles CircleRadius.TextChanged
        Dim rad As Integer = 0
        Integer.TryParse(CircleRadius.Text, rad)

        CircleOut.Text = String.Format("Area = {0} x {1} x 3.14 = {2} units²", rad, rad, Math.Round(rad * rad * Math.PI, MidpointRounding.AwayFromZero))
    End Sub

    Public Sub rhombus_TextInput(sender As Object, e As TextChangedEventArgs) Handles RhombusD1.TextChanged, RhombusD2.TextChanged
        Dim d1 As Integer = 0
        Dim d2 As Integer = 0
        Integer.TryParse(RhombusD1.Text, d1)
        Integer.TryParse(RhombusD2.Text, d2)

        RhombusOut.Text = String.Format("Area = {0} x {1} = {2} units²", d1, d2, d1 * d2)
    End Sub

    Private Sub RectangleWidth_PreviewKeyDown(sender As Object, e As KeyEventArgs) Handles RectangleWidth.PreviewKeyDown, RectangleHeight.PreviewKeyDown, TriangleHeight.PreviewKeyDown, TriangleWidth.PreviewKeyDown,
            TrapTop.PreviewKeyDown, TrapBottom.PreviewKeyDown, ParallelHeight.PreviewKeyDown, ParallelWidth.PreviewKeyDown, CircleRadius.PreviewKeyDown, RhombusD1.PreviewKeyDown, RhombusD2.PreviewKeyDown
        If Not IsDigit(e.Key) Then
            e.Handled = True
        End If
    End Sub

    Public Shared Function IsDigit(key As Key) As Boolean
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




    Private Sub TwoDimWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles TwoDimWindow.Loaded
        SharedVars.PlayMusic("overworld.wav")
    End Sub

    Private player As SoundPlayer

    Private Sub ButtonBack_Click(sender As Object, e As RoutedEventArgs) Handles ButtonBack.Click
        ParentWindow.switchTo(New SelectorScreen(ParentWindow))
    End Sub








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


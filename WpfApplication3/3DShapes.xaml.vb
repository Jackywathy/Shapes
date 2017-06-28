Imports System.Collections.ObjectModel

Public Class ThreeDimShapes
    Public ParentWindow As MainWindow
    Public SharedVars As Helper

    Public Buttons As List(Of Button)
    Public lock as Boolean


    Public Sub New(parent As MainWindow, Optional Lock As Boolean=False)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ParentWindow = parent
        Me.SharedVars = parent.SharedVars

        Me.DataContext = Me
        Buttons = New List(Of Button) From {RectangleButton, TrianglePyButton, SquarePyButton, SphereButton, ConeButton, CylinderButton}


        Rectangle_Button_Click(RectangleButton, Nothing)
        Me.lock = lock
    End Sub


    Private Sub Window_KeyDown(sender As Object, e As KeyEventArgs)
        If (e.Key = Key.F11) Then
            SharedVars.ToggleFullScreen()
        End If

    End Sub

    Private Sub rectangleHeight_TextInput(sender As Object, e As TextChangedEventArgs) Handles RectangleHeight.TextChanged, RectangleWidth.TextChanged,
        RectangleLength.TextChanged
        Dim hei As Integer = 0
        Dim wid As Integer = 0
        Dim len As Integer = 0
        Integer.TryParse(RectangleWidth.Text, wid)
        Integer.TryParse(RectangleHeight.Text, hei)
        Integer.TryParse(RectangleLength.Text, len)
        RectangleOut.Text = String.Format("Volume = {0} x {1} x {2} = {3} units³", wid, len, hei, wid * hei * len)

    End Sub

    Private Sub triangleHeight_TextInput(sender As Object, e As TextChangedEventArgs) Handles TriangleWidth.TextChanged, TriangleThickness.TextChanged,
        TriangleHeight.TextChanged
        Dim hei As Integer = 0
        Dim wid As Integer = 0
        Dim thick As Integer = 0
        Integer.TryParse(TriangleWidth.Text, wid)
        Integer.TryParse(TriangleHeight.Text, hei)
        Integer.TryParse(TriangleThickness.Text, thick)
        TriangleTop.Text = String.Format("{0} x {1}", wid, hei)
        TriangleRight.Text = String.Format("x {0} = {1} units³", thick, Math.Round((wid * hei / 2) * thick, MidpointRounding.AwayFromZero))
    End Sub


    Private Sub squareHeight_TextInput(sender As Object, e As TextChangedEventArgs) Handles SquarePyHeight.TextChanged, SquarePyLength.TextChanged
        Dim hei As Integer = 0
        Dim len As Integer = 0

        Integer.TryParse(SquarePyHeight.Text, hei)
        Integer.TryParse(SquarePyLength.Text, len)
        SquarePyTop.Text = String.Format("{0} x {1} x {2}", len, len, hei)
        SquarePyOut.Text = String.Format("= {0} units³", Math.Round(len * len * hei / 3, MidpointRounding.AwayFromZero))

    End Sub
    Private Sub sphereTab_TextInput(sender As Object, e As TextChangedEventArgs) Handles SphereRadius.TextChanged
        Dim rad As Integer = 0

        Integer.TryParse(SphereRadius.Text, rad)
        SphereOut.Content = String.Format("x 3.14 x {0}³ = {1}", rad, Math.Round(Math.PI * 4 / 3 * rad * rad * rad, MidpointRounding.AwayFromZero))
    End Sub

    Private Sub cylinderTab_TextInput(sender As Object, e As TextChangedEventArgs) Handles CylinderHeight.TextChanged, CylinderRadius.TextChanged
        Dim rad As Integer = 0
        Dim hei as Integer =0

        Integer.TryParse(CylinderHeight.Text, hei)
        Integer.TryParse(CylinderRadius.Text, rad)

        CylinderOut.Text = String.Format("Volume = 3.14 x {0}² x {1} = {2}", rad, hei,  Math.Round(Math.PI * rad * rad * hei, MidpointRounding.AwayFromZero))
    End Sub

    Private Sub coneTab_TextInput(sender As Object, e As TextChangedEventArgs) Handles ConeRadius.TextChanged, ConeHeight.TextChanged
        Dim hei As Integer = 0
        Dim rad As Integer = 0


        Integer.TryParse(ConeRadius.Text, rad)
        Integer.TryParse(ConeHeight.Text, hei)

        ConeOut.Text = String.Format(" = {0}", Math.Round(Math.PI * rad * rad * hei / 3, MidpointRounding.AwayFromZero))
        ConeTop.Content = hei.ToString()
        ConeLeft.Text = String.Format(" x {0}² x ", rad)

    End Sub


    Private Sub Button_2D_pressed(sender As Object, e As RoutedEventArgs) Handles Button_2D.Click
        If lock
            Me.Close()
            Dim x as New TwoDimShapes(ParentWindow, True)
            x.Show()

           Else
               ParentWindow.switchTo(New TwoDimShapes(ParentWindow))
        End If
        
    End Sub

    Private Sub RectangleWidth_PreviewKeyDown(sender As Object, e As KeyEventArgs) Handles RectangleHeight.PreviewKeyDown, RectangleLength.PreviewKeyDown, RectangleWidth.PreviewKeyDown,
            TriangleHeight.PreviewKeyDown, TriangleWidth.PreviewKeyDown, TriangleThickness.PreviewKeyDown, SquarePyHeight.PreviewKeyDown, SquarePyLength.PreviewKeyDown,
            SphereRadius.PreviewKeyDown, ConeHeight.PreviewKeyDown, ConeRadius.PreviewKeyDown, CylinderHeight.PreviewKeyDown, CylinderRadius.PreviewKeyDown

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


    Private Sub Window_load(sender As Object, e As RoutedEventArgs)
        SharedVars.PlayMusic("underground.wav")
    End Sub

    Private Sub Rectangle_Button_Click(sender As Object, e As RoutedEventArgs) Handles RectangleButton.Click, TrianglePyButton.Click, SquarePyButton.Click, SphereButton.Click, ConeButton.Click, CylinderButton.Click
        ' assume sender is Button
        ClearButtons()
        Dim senderButton As Button = sender

        If senderButton.Equals(RectangleButton) Then
            MainTab.BorderBrush = RectangleButton.Background
            RectangleTab.IsSelected = True
        ElseIf senderButton.Equals(TrianglePyButton) Then
            MainTab.BorderBrush = TrianglePyButton.Background
            TriangleTab.IsSelected = True
        ElseIf senderButton.Equals(SquarePyButton) Then
            MainTab.BorderBrush = SquarePyButton.Background
            SquarePyTab.IsSelected = True
        ElseIf senderButton.Equals(SphereButton) Then
            MainTab.BorderBrush = SphereButton.Background
            SphereTab.IsSelected = True
        ElseIf senderButton.Equals(ConeButton) Then
            MainTab.BorderBrush = ConeButton.Background
            ConeTab.IsSelected = True
        ElseIf senderButton.Equals(CylinderButton) Then
            MainTab.BorderBrush = CylinderButton.Background
            CylinderTab.IsSelected = True
        End If
        senderButton.Margin = New Thickness(0, 5, 0, 5)


    End Sub

    Private Sub Button_Back_Click(sender As Object, e As RoutedEventArgs) Handles ButtonBack.Click
        If lock
            Me.close
        Else
        ParentWindow.switchTo(New SelectorScreen(ParentWindow))
        End If
    End Sub
    Private Sub ClearButtons()
        For Each Button In Buttons
            ' set margin on all butons
            Button.IsEnabled = True
            Button.Margin = New Thickness(0, 15, 15, 15)
        Next
    End Sub


    Private Sub ThreeDimWindow(sender As Object, e As EventArgs) Handles Me.Closed
        SharedVars.StopMusic()
    End Sub

    Private Sub RectangleButton_MouseEnter(sender As Object, e As MouseEventArgs) Handles RectangleButton.MouseEnter, TrianglePyButton.MouseEnter
    End Sub
End Class



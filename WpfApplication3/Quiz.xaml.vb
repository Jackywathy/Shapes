Imports System.Security.Cryptography.X509Certificates

Public Class Quiz
    Private parentWindow As MainWindow
    Private SharedVars As Helper
    Private rnd As New Random()
    Private Templates As New List(Of QuestionItem)

    Public Buttons As List (Of Button)
    Public CorrectBox = -1

    Public Brushes As New List(Of Brush) From {
           Media.Brushes.Red,
        Media.Brushes.Brown,
        Media.Brushes.Orange,
        Media.Brushes.Purple,
        Media.Brushes.MediumPurple,
        Media.Brushes.GreenYellow,
        Media.Brushes.Green,
        Media.Brushes.DarkOrchid,
        Media.Brushes.Gold
        }


    Sub New(parent As MainWindow)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parentWindow = parent
        SharedVars = parent.SharedVars

        Dim tempE As Equation
        ' power of 0, then times of 1 = cancelled out
        ' rhombus : A = width * height 
        tempE = New Equation(1, 1, 1, 1, 1, 0, 1)
        Templates.Add(New QuestionItem(SharedVars.GetImage("measure/parallel.png"), "parallogram", "area", tempE, "width", "height", isRounded:=False))
        ' rectangle : A = width * height
        tempE = New Equation(1, 1, 1, 1, 1, 0, 1)
        Templates.Add(New QuestionItem(SharedVars.GetImage("measure/rectangle.png"), "rectangle", "area", tempE, "width", "height", isRounded:=False))

        Buttons = New List(Of Button) from {Button1, Button2, Button3, Button4}


        LoadQuestion()
    End Sub

    Function LoadAnswer(Answer As Integer) As Integer
        Dim box = GetRange(0,4)
        FOr each button in Buttons
            button.Content = GetRange(answer/2+4, answer*2+1)
        Next
        Buttons(box).Content = Answer
        Return box
    End Function

    Sub LoadQuestion(Optional ChangeColor = True)
        If ChangeColor Then
            ShownText.Foreground = GetColor()
        End If

        Dim randomTemplate As QuestionItem = Templates(rnd.Next(0, Templates.Count))
        Dim Arg1 As Integer = GetRnd()
        Dim Arg2 As Integer = GetRnd()
        Dim Arg3 As Integer = GetRnd()
        Dim Answer As Integer = randomTemplate.Equ.Solve(Arg1, Arg2, Arg3)
        MessageBox.Show(String.Format(randomTemplate.Template, Arg1, Arg2, Arg3))

        ShownImage.Source = randomTemplate.Image
        ShownText.Text = String.Format(randomTemplate.Template, Arg1, Arg2, Arg3)
        correctBox = LoadAnswer(Answer)
    End Sub

    Function GetRnd() As Integer
        ' gets random from 1 - 20
        Return rnd.Next(1, 20)

    End Function

    Function GetRange(start As Integer, ee As Integer) As Integer
        Return rnd.Next(start, ee)
    End Function

    Function GetColor() As Brush
        Return Brushes(rnd.Next(0, Brushes.Count))
    End Function

    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        If CorrectBox = -1
            end
        End If
        Dim thisButton = CType(sender, Button)
        if thisButton.Equals(Buttons(CorrectBox))

        End If

    End Sub
End Class

Public Class QuestionItem
    Public Image As BitmapImage
    Public Template As String
    Public Shape As String
    Public IsRounded As String
    Public NumVars As Integer
    Public Type As String
    Public Equ As Equation

    Sub New(image As BitmapImage, shape As String, type As String, equ As Equation, arg1 As String, Optional arg2 As String = Nothing, Optional arg3 As String = Nothing, Optional isRounded As Boolean = False)
        Me.Image = image
        Me.Shape = shape
        Me.IsRounded = isRounded
        Me.Type = type
        Me.Equ = equ
        If arg3 IsNot Nothing Then
            ' assume that arg2 is also defined
            If arg2 Is Nothing Then
                Throw New Exception("If arg3 is defined, arg2 must also be!")
            End If
            Template = String.Format("A {0} has {1} {{0}}, {2} {{1}} and {3} {{2}}. ", shape, arg1, arg2, arg3)
            NumVars = 3
        ElseIf arg2 IsNot Nothing Then
            Template = String.Format("A {0} has {1} {{0}} and {2} {{1}}. ", shape, arg1, arg2)
            NumVars = 2
        Else
            Template = String.Format("A {0} has a {1} of {{0}}. ", shape, arg1)
            NumVars = 1
        End If
        Template += String.Format("Find the {0} of this shape!", type)
    End Sub


End Class

Public Class Equation
    Public Multiplier As Integer
    Public Arg1Power As Integer
    Public Arg2Power As Integer
    Public Arg3Power As Integer

    Public Arg1Times As Integer
    Public Arg2Times As Integer
    Public Arg3Times As Integer

    Sub New(Multiplier As Integer, arg1Power As Integer, arg1Times As Double, arg2Power As Integer, arg2Times As Double, arg3Power As Integer, arg3Times As Double)
        Me.Multiplier = Multiplier
        Me.Arg1Power = arg1Power
        Me.Arg2Power = arg2Power
        Me.Arg3Power = arg3Power

        Me.Arg1Times = arg1Times
        Me.Arg2Times = arg2Times
        Me.Arg3Times = arg3Times
    End Sub

    Public Function Solve(Arg1 As Integer, Arg2 As Integer, Arg3 As Integer)
        Dim res1 As Double = (Arg1 ^ Arg1Power) * Arg1Times
        Dim res2 As Double = (Arg2 ^ Arg2Power) * Arg2Times
        Dim res3 As Double = (Arg3 ^ Arg3Power) * Arg3Times
        Dim result As Integer = Math.Round(Multiplier * res1 * res2 * res3, MidpointRounding.AwayFromZero)
        Return result
    End Function
End Class

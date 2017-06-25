﻿Imports System.Collections.ObjectModel

Public Class ThreeDimShapes
    Public AllShapes As New ObservableCollection(Of ShapeItem)
    Public ParentWindow As MainWindow
    Public SharedVars As Helper

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

    End Sub


    Public Sub New(parent As MainWindow)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ParentWindow = parent
        Me.SharedVars = parent.SharedVars

        Me.DataContext = Me
    End Sub


    Private Sub Window_KeyDown(sender As Object, e As KeyEventArgs)
        If (e.Key = Key.F11) Then
            SharedVars.ToggleFullScreen()
        End If

    End Sub



    Private Sub Button_2D_pressed(sender As Object, e As RoutedEventArgs) Handles Button_2D.Click
        ParentWindow.switchTo(New TwoDimShapes(ParentWindow))
    End Sub


    Private Sub Button_3D_pressed(sender As Object, e As RoutedEventArgs) Handles Button_3D.Click
        Throw New Exception("Already in 3D, cannot do  3D ^ 2")
    End Sub
End Class


Public Class ShapeItem
    Public Property Name As String
    Public Property Icon As BitmapImage

    Public Property ShownImages As List(Of Image)

    Public Sub New(name As String, Optional Icon As Image = Nothing, Optional ShownImages As List(Of Image) = Nothing)
        Me.Name = name
        Me.Icon = If(IsNothing(Icon), Helper.GetImage("images.png"), Icon)
        Me.ShownImages = ShownImages

    End Sub

End Class
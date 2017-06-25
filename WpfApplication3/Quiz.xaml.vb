Public Class Quiz
    Private parentWindow As MainWindow
    Sub New(parent As MainWindow)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parentWindow = parent
    End Sub
End Class

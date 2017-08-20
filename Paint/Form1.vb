Public Class Form1
    Dim down As Boolean
    Dim brush As New SolidBrush(Color.White)
    Dim thickness As Integer
    Dim linestart As Point
    Dim brushpressed As Boolean
    Dim linepressed As Boolean

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    'Dim draw As System.Drawing.Graphics
    'draw = Me.CreateGraphics

    'Dim blackPen As New Pen(Color.Black, 3)

    'draw.DrawEllipse(blackPen, 175, 25, 75, 75)
    'draw.DrawLine(blackPen, 210, 100, 210, 210)
    'draw.DrawLine(blackPen, 210, 209, 140, 325)
    'draw.DrawLine(blackPen, 210, 209, 280, 325)
    'draw.DrawLine(blackPen, 210, 155, 125, 100)
    'draw.DrawLine(blackPen, 210, 155, 295, 100)

    ' draw.DrawEllipse(blackPen, 600, 25, 75, 75)
    'draw.DrawLine(blackPen, 635, 100, 635, 210)
    'draw.DrawLine(blackPen, 635, 209, 565, 325)
    'draw.DrawLine(blackPen, 635, 209, 705, 325)
    ' draw.DrawLine(blackPen, 635, 155, 550, 100)
    ' draw.DrawLine(blackPen, 635, 155, 720, 100)
    'End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim draw As System.Drawing.Graphics = Me.CreateGraphics
        Dim X As Integer = Form1.MousePosition.X - Me.Location.X - 10
        Dim Y As Integer = Form1.MousePosition.Y - Me.Location.Y - 35

        If brushpressed = True And
                down Then
            draw.FillEllipse(brush, X, Y, thickness, thickness)
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        down = True
        Dim X As Integer = Form1.MousePosition.X - Me.Location.X - 10
        Dim Y As Integer = Form1.MousePosition.Y - Me.Location.Y - 35

        linestart = New Point(X, Y)
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Dim draw As System.Drawing.Graphics = Me.CreateGraphics
        Dim X As Integer = Form1.MousePosition.X - Me.Location.X - 10
        Dim Y As Integer = Form1.MousePosition.Y - Me.Location.Y - 35
        Dim lineEnd As Point
        lineEnd = New Point(X, Y)
        If linepressed = True Then
            draw.DrawLine(New Pen(brush.Color, thickness), linestart, lineEnd)
        End If
        down = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Red_Click(sender As Object, e As EventArgs) Handles Red.Click
        brush.Color = Color.Red
    End Sub

    Private Sub Orange_Click(sender As Object, e As EventArgs) Handles Orange.Click
        brush.Color = Color.Orange
    End Sub

    Private Sub Yellow_Click(sender As Object, e As EventArgs) Handles Yellow.Click
        brush.Color = Color.Yellow
    End Sub

    Private Sub LightGreen_Click(sender As Object, e As EventArgs) Handles LightGreen.Click
        brush.Color = Color.LawnGreen
    End Sub

    Private Sub DarkGreen_Click(sender As Object, e As EventArgs) Handles DarkGreen.Click
        brush.Color = Color.Green
    End Sub

    Private Sub LightBlue_Click(sender As Object, e As EventArgs) Handles LightBlue.Click
        brush.Color = Color.Cyan
    End Sub

    Private Sub DarkBlue_Click(sender As Object, e As EventArgs) Handles DarkBlue.Click
        brush.Color = Color.Blue
    End Sub

    Private Sub Purple_Click(sender As Object, e As EventArgs) Handles Purple.Click
        brush.Color = Color.DarkViolet
    End Sub

    Private Sub Black_Click(sender As Object, e As EventArgs) Handles Black.Click
        brush.Color = Color.Black
    End Sub

    Private Sub Eraser_Click(sender As Object, e As EventArgs) Handles Eraser.Click
        brushpressed = True
        linepressed = False
        brush.Color = Color.White
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics

        draw.FillRectangle(Brushes.White, 0, 0, 1600, 850)
    End Sub

    Private Sub OpenMenu_Click(sender As Object, e As EventArgs) Handles OpenMenu.Click
        Panel1.Visible = Not Panel1.Visible
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        thickness = HScrollBar1.Value
    End Sub

    Private Sub BrushButton_Click(sender As Object, e As EventArgs) Handles BrushButton.Click
        brushpressed = True
        linepressed = False
    End Sub

    Private Sub Line_Click(sender As Object, e As EventArgs) Handles Line.Click
        linepressed = True
        brushpressed = False
    End Sub

    Private Sub Brown_Click(sender As Object, e As EventArgs) Handles Brown.Click
        brush.Color = Color.Sienna
    End Sub

    Private Sub B_Red_Click(sender As Object, e As EventArgs) Handles B_Red.Click
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics

        draw.FillRectangle(Brushes.Red, 0, 0, 1600, 850)
    End Sub
End Class
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Module TouchScroll
    Private mouseDownPoint As Point
    Private parentPanel As Panel

    Public Sub SetPanel(ByVal panel As Panel)
        parentPanel = panel
        AssignEvents(panel)
    End Sub

    Private Sub AssignEvents(ByVal control As Control)
        'control.MouseDown += AddressOf MouseDown
        'control.MouseMove += AddressOf MouseMove

        AddHandler control.MouseDown, AddressOf MouseDown
        AddHandler control.MouseMove, AddressOf MouseMove

        For Each child As Control In control.Controls
            AssignEvents(child)
        Next
    End Sub

    Private Sub MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then mouseDownPoint = Cursor.Position
    End Sub

    Private Sub MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button <> MouseButtons.Left Then Return
        Dim pointDifference As Point = New Point(Cursor.Position.X - mouseDownPoint.X, Cursor.Position.Y - mouseDownPoint.Y)
        If (mouseDownPoint.X = Cursor.Position.X) AndAlso (mouseDownPoint.Y = Cursor.Position.Y) Then Return
        Dim currAutoS As Point = parentPanel.AutoScrollPosition
        parentPanel.AutoScrollPosition = New Point(Math.Abs(currAutoS.X) - pointDifference.X, Math.Abs(currAutoS.Y) - pointDifference.Y)
        mouseDownPoint = Cursor.Position
    End Sub
End Module


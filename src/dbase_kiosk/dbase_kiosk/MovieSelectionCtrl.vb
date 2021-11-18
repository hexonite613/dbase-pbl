Imports System.Runtime.InteropServices

Public Class MovieSelectionCtrl
    Public Shared Function ShowScrollBar(ByVal hWnd As System.IntPtr, ByVal wBar As Integer, ByVal bShow As Boolean) As Boolean
    End Function

    Private Const SB_HORZ As Integer = 0

    Private Sub MovieSelectionCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowScrollBar(SchedulePanel.Handle, SB_HORZ, True)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        MsgBox(SchedulePanel.HorizontalScroll.Visible)
    End Sub
End Class

Module GUIModule
    Public Function dpicalc(targetform As Form, size As Integer) As Integer
        Dim g As Graphics = targetform.CreateGraphics
        Dim dpi = g.DpiX.ToString()

        Dim current = dpi / 96
        Dim expand = current * size

        Return expand
    End Function

End Module

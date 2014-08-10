Public Class Window
    Public Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hwnd As Integer, ByVal lpString As String, ByVal cch As Integer) As Integer
    Public Declare Function EnumWindows Lib "user32" (ByVal lpEnumFunc As vEnumWindowsProc, ByVal lParam As Integer) As Integer
    Public Delegate Function vEnumWindowsProc(ByVal hWnd As Integer, ByVal lParam As Integer) As Boolean
    Public Shared Function GetWindows() As String()

    End Function
    Private Function EnumWindowsProc(ByVal hwnd As Long, ByVal lParam As Long) As Boolean

        '窗口的标题
        Dim Title As String = ""

        '给它提供初始值
        Title = StrDup(80, Chr(0))
        Call GetWindowText(hwnd, Title, 80)
        Title = Microsoft.VisualBasic.Strings.Left(Title, InStr(Title, Chr(0)) - 1)

        If Len(Title) > 0 Then

            List1.Items.Add(Title)
        End If

        EnumWindowsProc = True

    End Function
End Class

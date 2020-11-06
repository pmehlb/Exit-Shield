Imports System
Imports System.Windows
Imports System.Runtime.InteropServices

Public Class AppForm

    ' https://www.codeproject.com/Articles/611358/How-to-Use-PInvoke-to-Disable-the-Close-Button-on
    '
    ' converted this to vb.net
    '
    ' [DllImport("user32.dll")]
    ' Static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert); 
    ' [DllImport("user32.dll")]
    ' Static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);
    ' [DllImport("user32.dll")]
    ' Static extern bool DrawMenuBar(IntPtr hWnd);
    '
    ' the original CallingConvention was "CallingConvention:=Runtime.InteropServices.CallingConvention.Cdecl"

    <DllImport("user32.dll", CallingConvention:=CallingConvention.Winapi)>
    Private Shared Function GetSystemMenu(ByVal hWnd As IntPtr, ByVal bRevert As Boolean) As IntPtr
    End Function

    <DllImport("user32.dll", CallingConvention:=CallingConvention.Winapi)>
    Private Shared Function EnableMenuItem(ByVal hMenu As IntPtr, ByVal wIDEnableItem As UInteger, ByVal wEnable As UInteger) As IntPtr
    End Function

    <DllImport("user32.dll", CallingConvention:=CallingConvention.Winapi)>
    Private Shared Function DrawMenuBar(ByVal hWnd As IntPtr) As Boolean
    End Function

    Const MF_BYCOMMAND As Integer = &H0
    Const MF_BYPOSITION As Integer = &H400
    Const MF_REMOVE As Integer = &H1000
    Const MF_ENABLED As Integer = &H0
    Const MF_GRAYED As Integer = &H1
    Const MF_DISABLED As Integer = &H2
    Const SC_CLOSE As Integer = &HF060

    Dim selectedHandle As IntPtr

    Private Sub btnAttach_Click(sender As Object, e As EventArgs) Handles btnAttach.Click
        SelectProc.Show()
    End Sub

    Dim toggle As Boolean = False

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        ' check that we actually selected a process
        If (selectedHandle = IntPtr.Zero) Then
            MessageBox.Show("Please select a process to lock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ' cool, now check the toggle value and perform operations :o
        If (toggle = False) Then
            disableX()
            btnToggle.Text = "Unlock App"
            btnToggle.BackColor = Color.DarkGray
            btnToggle.FlatAppearance.MouseOverBackColor = Color.DimGray
            toggle = True
        Else
            enableX()
            btnToggle.Text = "Lock App"
            btnToggle.BackColor = Color.Gainsboro
            btnToggle.FlatAppearance.MouseOverBackColor = Color.DarkGray
            toggle = False
        End If
    End Sub

    Public Sub updateAttachedProcess(processName As String, processHandle As Process)
        If (Not String.IsNullOrEmpty(processName)) Then
            ' something was selected!
            lblProcess.Text = " " & processName & "  (PID: " & processHandle.Id.ToString & ")"
            selectedHandle = processHandle.MainWindowHandle
        Else
            lblProcess.Text = "  none"
        End If
    End Sub

    ' disable the X button
    Public Sub disableX()
        EnableMenuItem(GetSystemMenu(selectedHandle, False), SC_CLOSE, MF_GRAYED)
    End Sub

    ' enable the X button
    Public Sub enableX()
        EnableMenuItem(GetSystemMenu(selectedHandle, False), SC_CLOSE, MF_ENABLED)
    End Sub

End Class
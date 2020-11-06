Public Class SelectProc
    ' variable of all processes
    Dim ProcessList As List(Of Process) = Process.GetProcesses().ToList
    Dim ProcessRefList As New List(Of Process)

    Private Sub SelectProc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' go through all processes
        ' for each window process, add it to the lists!
        ProcessList.ForEach(
            Sub(proc As Process)
                If (Not String.IsNullOrEmpty(proc.MainWindowTitle)) Then
                    ProcessBox.Items.Add(proc.MainWindowTitle)
                    ProcessRefList.Add(proc)
                End If
            End Sub
        )
    End Sub

    Private Sub ProcessBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProcessBox.SelectedIndexChanged
        AppForm.updateAttachedProcess(ProcessBox.SelectedItem, ProcessRefList(ProcessBox.SelectedIndex))
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Me.Close()
    End Sub
End Class
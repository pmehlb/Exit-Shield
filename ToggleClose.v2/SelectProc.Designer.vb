<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectProc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ProcessBox = New System.Windows.Forms.ListBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblProcess = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProcessBox
        '
        Me.ProcessBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ProcessBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProcessBox.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.ProcessBox.FormattingEnabled = True
        Me.ProcessBox.HorizontalScrollbar = True
        Me.ProcessBox.ItemHeight = 15
        Me.ProcessBox.Location = New System.Drawing.Point(12, 27)
        Me.ProcessBox.Name = "ProcessBox"
        Me.ProcessBox.Size = New System.Drawing.Size(320, 227)
        Me.ProcessBox.TabIndex = 0
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSelect.FlatAppearance.BorderSize = 2
        Me.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.btnSelect.Location = New System.Drawing.Point(12, 268)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(318, 41)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Select Process"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'lblProcess
        '
        Me.lblProcess.AutoSize = True
        Me.lblProcess.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.lblProcess.Location = New System.Drawing.Point(18, 8)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Size = New System.Drawing.Size(56, 14)
        Me.lblProcess.TabIndex = 3
        Me.lblProcess.Text = "Processes"
        '
        'SelectProc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(344, 321)
        Me.Controls.Add(Me.lblProcess)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.ProcessBox)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectProc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Process - Exit Shield"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProcessBox As ListBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblProcess As Label
End Class

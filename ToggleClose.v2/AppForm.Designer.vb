<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnToggle = New System.Windows.Forms.Button()
        Me.btnAttach = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblProcess = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnToggle
        '
        Me.btnToggle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToggle.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnToggle.FlatAppearance.BorderSize = 3
        Me.btnToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggle.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggle.Location = New System.Drawing.Point(173, 84)
        Me.btnToggle.Margin = New System.Windows.Forms.Padding(6)
        Me.btnToggle.Name = "btnToggle"
        Me.btnToggle.Size = New System.Drawing.Size(256, 45)
        Me.btnToggle.TabIndex = 1
        Me.btnToggle.Text = "Lock App"
        Me.btnToggle.UseVisualStyleBackColor = True
        '
        'btnAttach
        '
        Me.btnAttach.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAttach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAttach.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAttach.FlatAppearance.BorderSize = 2
        Me.btnAttach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnAttach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttach.Font = New System.Drawing.Font("Corbel", 15.0!)
        Me.btnAttach.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAttach.Location = New System.Drawing.Point(15, 84)
        Me.btnAttach.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(146, 45)
        Me.btnAttach.TabIndex = 0
        Me.btnAttach.Text = "Attach"
        Me.btnAttach.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.lblStatus.Location = New System.Drawing.Point(7, 12)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(156, 19)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "Currently attached to:"
        '
        'lblProcess
        '
        Me.lblProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProcess.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblProcess.Location = New System.Drawing.Point(15, 41)
        Me.lblProcess.MaxLength = 512
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.ReadOnly = True
        Me.lblProcess.Size = New System.Drawing.Size(414, 27)
        Me.lblProcess.TabIndex = 3
        Me.lblProcess.Text = "  none"
        Me.lblProcess.WordWrap = False
        '
        'AppForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(444, 141)
        Me.Controls.Add(Me.lblProcess)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnAttach)
        Me.Controls.Add(Me.btnToggle)
        Me.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "AppForm"
        Me.Text = "Exit Shield - Prevent pesky users from closing stuff!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnToggle As Button
    Friend WithEvents btnAttach As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblProcess As TextBox
End Class

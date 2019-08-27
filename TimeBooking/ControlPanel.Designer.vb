<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPanel
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
        Me.ViewTicket = New System.Windows.Forms.Button
        Me.PrintTicket = New System.Windows.Forms.Button
        Me.SetTicket = New System.Windows.Forms.Button
        Me.btnChangePassword = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ViewTicket
        '
        Me.ViewTicket.Location = New System.Drawing.Point(200, 105)
        Me.ViewTicket.Name = "ViewTicket"
        Me.ViewTicket.Size = New System.Drawing.Size(156, 51)
        Me.ViewTicket.TabIndex = 7
        Me.ViewTicket.Text = "View Ticket"
        Me.ViewTicket.UseVisualStyleBackColor = True
        '
        'PrintTicket
        '
        Me.PrintTicket.Location = New System.Drawing.Point(12, 105)
        Me.PrintTicket.Name = "PrintTicket"
        Me.PrintTicket.Size = New System.Drawing.Size(156, 51)
        Me.PrintTicket.TabIndex = 6
        Me.PrintTicket.Text = "Print Ticket"
        Me.PrintTicket.UseVisualStyleBackColor = True
        '
        'SetTicket
        '
        Me.SetTicket.Location = New System.Drawing.Point(12, 30)
        Me.SetTicket.Name = "SetTicket"
        Me.SetTicket.Size = New System.Drawing.Size(156, 51)
        Me.SetTicket.TabIndex = 5
        Me.SetTicket.Text = "Set Ticket Time"
        Me.SetTicket.UseVisualStyleBackColor = True
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(200, 30)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(158, 51)
        Me.btnChangePassword.TabIndex = 4
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'ControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 169)
        Me.Controls.Add(Me.ViewTicket)
        Me.Controls.Add(Me.PrintTicket)
        Me.Controls.Add(Me.SetTicket)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Name = "ControlPanel"
        Me.Text = "ControlPanel"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ViewTicket As System.Windows.Forms.Button
    Friend WithEvents PrintTicket As System.Windows.Forms.Button
    Friend WithEvents SetTicket As System.Windows.Forms.Button
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
End Class

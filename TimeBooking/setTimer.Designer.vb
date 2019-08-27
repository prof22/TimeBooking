<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setTimer
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
        Me.txtTicket = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txtsecond = New System.Windows.Forms.TextBox
        Me.txtMin = New System.Windows.Forms.TextBox
        Me.txthours = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSet = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtTicket
        '
        Me.txtTicket.Location = New System.Drawing.Point(135, 28)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.Size = New System.Drawing.Size(150, 20)
        Me.txtTicket.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Ticket"
        '
        'Txtsecond
        '
        Me.Txtsecond.Location = New System.Drawing.Point(135, 140)
        Me.Txtsecond.Name = "Txtsecond"
        Me.Txtsecond.Size = New System.Drawing.Size(150, 20)
        Me.Txtsecond.TabIndex = 16
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(135, 91)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(150, 20)
        Me.txtMin.TabIndex = 15
        '
        'txthours
        '
        Me.txthours.Location = New System.Drawing.Point(135, 59)
        Me.txthours.Name = "txthours"
        Me.txthours.Size = New System.Drawing.Size(150, 20)
        Me.txthours.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Seconds"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Min"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Hours"
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(135, 191)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(140, 34)
        Me.btnSet.TabIndex = 10
        Me.btnSet.Text = "Set Time"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'setTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 262)
        Me.Controls.Add(Me.txtTicket)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtsecond)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txthours)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSet)
        Me.Name = "setTimer"
        Me.Text = "setTimer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTicket As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtsecond As System.Windows.Forms.TextBox
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents txthours As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSet As System.Windows.Forms.Button
End Class

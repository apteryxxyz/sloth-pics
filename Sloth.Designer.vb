<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sloth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sloth))
        Me.GetSloth = New System.Windows.Forms.Button()
        Me.ShowSloth = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ActiveProcess = New System.Windows.Forms.Label()
        CType(Me.ShowSloth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GetSloth
        '
        Me.GetSloth.Location = New System.Drawing.Point(13, 13)
        Me.GetSloth.Name = "GetSloth"
        Me.GetSloth.Size = New System.Drawing.Size(102, 33)
        Me.GetSloth.TabIndex = 0
        Me.GetSloth.Text = "Get Sloth"
        Me.GetSloth.UseVisualStyleBackColor = True
        '
        'ShowSloth
        '
        Me.ShowSloth.Location = New System.Drawing.Point(13, 52)
        Me.ShowSloth.Name = "ShowSloth"
        Me.ShowSloth.Size = New System.Drawing.Size(1131, 680)
        Me.ShowSloth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ShowSloth.TabIndex = 1
        Me.ShowSloth.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "or press the space bar"
        '
        'ActiveProcess
        '
        Me.ActiveProcess.Location = New System.Drawing.Point(778, 21)
        Me.ActiveProcess.Name = "ActiveProcess"
        Me.ActiveProcess.Size = New System.Drawing.Size(366, 23)
        Me.ActiveProcess.TabIndex = 3
        Me.ActiveProcess.Text = "Waiting"
        Me.ActiveProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Sloth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 744)
        Me.Controls.Add(Me.ActiveProcess)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShowSloth)
        Me.Controls.Add(Me.GetSloth)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sloth"
        Me.Text = "Sloth Pics"
        CType(Me.ShowSloth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GetSloth As Button
    Friend WithEvents ShowSloth As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ActiveProcess As Label
End Class

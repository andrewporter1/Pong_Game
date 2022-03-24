<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Title
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
        Me.Start = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.Location = New System.Drawing.Point(212, 214)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(427, 313)
        Me.Start.TabIndex = 0
        Me.Start.Text = "START"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Title
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 711)
        Me.Controls.Add(Me.Start)
        Me.Name = "Title"
        Me.Text = "Pong - Start Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Start As Button
End Class

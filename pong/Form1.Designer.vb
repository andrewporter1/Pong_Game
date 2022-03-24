<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Pong
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
        Me.components = New System.ComponentModel.Container()
        Me.Lbl_Top = New System.Windows.Forms.Label()
        Me.Lbl_Bottom = New System.Windows.Forms.Label()
        Me.Lbl_Right = New System.Windows.Forms.Label()
        Me.Lbl_Left = New System.Windows.Forms.Label()
        Me.Lbl_Middle = New System.Windows.Forms.Label()
        Me.Lbl_AI = New System.Windows.Forms.Label()
        Me.Lbl_Ball = New System.Windows.Forms.Label()
        Me.Tmr_Ball = New System.Windows.Forms.Timer(Me.components)
        Me.Score_p1 = New System.Windows.Forms.Label()
        Me.Score_Ai = New System.Windows.Forms.Label()
        Me.Lbl_PlayerOne = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_Top
        '
        Me.Lbl_Top.BackColor = System.Drawing.Color.White
        Me.Lbl_Top.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Top.Name = "Lbl_Top"
        Me.Lbl_Top.Size = New System.Drawing.Size(960, 15)
        Me.Lbl_Top.TabIndex = 0
        '
        'Lbl_Bottom
        '
        Me.Lbl_Bottom.BackColor = System.Drawing.Color.White
        Me.Lbl_Bottom.Location = New System.Drawing.Point(12, 687)
        Me.Lbl_Bottom.Name = "Lbl_Bottom"
        Me.Lbl_Bottom.Size = New System.Drawing.Size(960, 15)
        Me.Lbl_Bottom.TabIndex = 1
        '
        'Lbl_Right
        '
        Me.Lbl_Right.BackColor = System.Drawing.Color.Red
        Me.Lbl_Right.Location = New System.Drawing.Point(957, 24)
        Me.Lbl_Right.Name = "Lbl_Right"
        Me.Lbl_Right.Size = New System.Drawing.Size(15, 663)
        Me.Lbl_Right.TabIndex = 2
        '
        'Lbl_Left
        '
        Me.Lbl_Left.BackColor = System.Drawing.Color.Red
        Me.Lbl_Left.Location = New System.Drawing.Point(12, 24)
        Me.Lbl_Left.Name = "Lbl_Left"
        Me.Lbl_Left.Size = New System.Drawing.Size(15, 663)
        Me.Lbl_Left.TabIndex = 3
        '
        'Lbl_Middle
        '
        Me.Lbl_Middle.BackColor = System.Drawing.Color.White
        Me.Lbl_Middle.Location = New System.Drawing.Point(485, 24)
        Me.Lbl_Middle.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_Middle.Name = "Lbl_Middle"
        Me.Lbl_Middle.Size = New System.Drawing.Size(15, 663)
        Me.Lbl_Middle.TabIndex = 4
        '
        'Lbl_AI
        '
        Me.Lbl_AI.BackColor = System.Drawing.Color.White
        Me.Lbl_AI.Location = New System.Drawing.Point(936, 34)
        Me.Lbl_AI.Name = "Lbl_AI"
        Me.Lbl_AI.Size = New System.Drawing.Size(15, 120)
        Me.Lbl_AI.TabIndex = 6
        '
        'Lbl_Ball
        '
        Me.Lbl_Ball.BackColor = System.Drawing.Color.Lime
        Me.Lbl_Ball.Location = New System.Drawing.Point(467, 110)
        Me.Lbl_Ball.Name = "Lbl_Ball"
        Me.Lbl_Ball.Size = New System.Drawing.Size(15, 15)
        Me.Lbl_Ball.TabIndex = 7
        '
        'Tmr_Ball
        '
        Me.Tmr_Ball.Enabled = True
        Me.Tmr_Ball.Interval = 10
        '
        'Score_p1
        '
        Me.Score_p1.AutoSize = True
        Me.Score_p1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_p1.ForeColor = System.Drawing.Color.White
        Me.Score_p1.Location = New System.Drawing.Point(29, 645)
        Me.Score_p1.Name = "Score_p1"
        Me.Score_p1.Size = New System.Drawing.Size(39, 42)
        Me.Score_p1.TabIndex = 10
        Me.Score_p1.Text = "0"
        '
        'Score_Ai
        '
        Me.Score_Ai.AutoSize = True
        Me.Score_Ai.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_Ai.ForeColor = System.Drawing.Color.White
        Me.Score_Ai.Location = New System.Drawing.Point(912, 645)
        Me.Score_Ai.Name = "Score_Ai"
        Me.Score_Ai.Size = New System.Drawing.Size(39, 42)
        Me.Score_Ai.TabIndex = 11
        Me.Score_Ai.Text = "0"
        '
        'Lbl_PlayerOne
        '
        Me.Lbl_PlayerOne.BackColor = System.Drawing.Color.Yellow
        Me.Lbl_PlayerOne.Location = New System.Drawing.Point(33, 34)
        Me.Lbl_PlayerOne.Name = "Lbl_PlayerOne"
        Me.Lbl_PlayerOne.Size = New System.Drawing.Size(15, 120)
        Me.Lbl_PlayerOne.TabIndex = 13
        '
        'Frm_Pong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(984, 711)
        Me.Controls.Add(Me.Lbl_PlayerOne)
        Me.Controls.Add(Me.Score_Ai)
        Me.Controls.Add(Me.Score_p1)
        Me.Controls.Add(Me.Lbl_Ball)
        Me.Controls.Add(Me.Lbl_AI)
        Me.Controls.Add(Me.Lbl_Middle)
        Me.Controls.Add(Me.Lbl_Left)
        Me.Controls.Add(Me.Lbl_Right)
        Me.Controls.Add(Me.Lbl_Bottom)
        Me.Controls.Add(Me.Lbl_Top)
        Me.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Name = "Frm_Pong"
        Me.Text = "Pong"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Top As Label
    Friend WithEvents Lbl_Bottom As Label
    Friend WithEvents Lbl_Right As Label
    Friend WithEvents Lbl_Left As Label
    Friend WithEvents Lbl_Middle As Label
    Friend WithEvents Lbl_AI As Label
    Friend WithEvents Lbl_Ball As Label
    Friend WithEvents Tmr_Ball As Timer
    Friend WithEvents Score_p1 As Label
    Friend WithEvents Score_Ai As Label
    Friend WithEvents Lbl_PlayerOne As Label
End Class

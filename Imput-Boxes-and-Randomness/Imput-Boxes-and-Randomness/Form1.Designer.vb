<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnApproach = New System.Windows.Forms.Button()
        Me.lblFate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnApproach
        '
        Me.btnApproach.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApproach.Location = New System.Drawing.Point(68, 40)
        Me.btnApproach.Name = "btnApproach"
        Me.btnApproach.Size = New System.Drawing.Size(135, 59)
        Me.btnApproach.TabIndex = 0
        Me.btnApproach.Text = "Approach the Bridge"
        Me.btnApproach.UseVisualStyleBackColor = True
        '
        'lblFate
        '
        Me.lblFate.AutoSize = True
        Me.lblFate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFate.Location = New System.Drawing.Point(35, 161)
        Me.lblFate.Name = "lblFate"
        Me.lblFate.Size = New System.Drawing.Size(0, 20)
        Me.lblFate.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 253)
        Me.Controls.Add(Me.lblFate)
        Me.Controls.Add(Me.btnApproach)
        Me.Name = "Form1"
        Me.Text = "InputBoxes and Randomness"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnApproach As System.Windows.Forms.Button
    Friend WithEvents lblFate As System.Windows.Forms.Label

End Class

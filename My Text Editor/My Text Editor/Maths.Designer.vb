<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaths
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
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lstNumber = New System.Windows.Forms.ListBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnSmallest = New System.Windows.Forms.Button()
        Me.btnLargest = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(187, 17)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(94, 17)
        Me.lblNumber.TabIndex = 0
        Me.lblNumber.Text = "Enter number"
        '
        'lstNumber
        '
        Me.lstNumber.FormattingEnabled = True
        Me.lstNumber.ItemHeight = 16
        Me.lstNumber.Location = New System.Drawing.Point(16, 106)
        Me.lstNumber.Name = "lstNumber"
        Me.lstNumber.Size = New System.Drawing.Size(120, 180)
        Me.lstNumber.TabIndex = 1
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(295, 12)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(141, 22)
        Me.txtNumber.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 395)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(85, 35)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(116, 395)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(85, 35)
        Me.btnSum.TabIndex = 4
        Me.btnSum.Text = "Sum"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(226, 395)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(85, 35)
        Me.btnAverage.TabIndex = 5
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'btnSmallest
        '
        Me.btnSmallest.Location = New System.Drawing.Point(351, 395)
        Me.btnSmallest.Name = "btnSmallest"
        Me.btnSmallest.Size = New System.Drawing.Size(85, 35)
        Me.btnSmallest.TabIndex = 6
        Me.btnSmallest.Text = "Smallest"
        Me.btnSmallest.UseVisualStyleBackColor = True
        '
        'btnLargest
        '
        Me.btnLargest.Location = New System.Drawing.Point(483, 395)
        Me.btnLargest.Name = "btnLargest"
        Me.btnLargest.Size = New System.Drawing.Size(85, 35)
        Me.btnLargest.TabIndex = 7
        Me.btnLargest.Text = "Largest"
        Me.btnLargest.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(604, 395)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMaths
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 505)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLargest)
        Me.Controls.Add(Me.btnSmallest)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lstNumber)
        Me.Controls.Add(Me.lblNumber)
        Me.Name = "frmMaths"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maths"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumber As Label
    Friend WithEvents lstNumber As ListBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSum As Button
    Friend WithEvents btnAverage As Button
    Friend WithEvents btnSmallest As Button
    Friend WithEvents btnLargest As Button
    Friend WithEvents btnExit As Button
End Class

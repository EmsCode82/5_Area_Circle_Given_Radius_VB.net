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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtRadiusIn = New System.Windows.Forms.TextBox()
        Me.lblAreaCircle = New System.Windows.Forms.Label()
        Me.lblACircle = New System.Windows.Forms.Label()
        Me.lblRadiusIn = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(30, 176)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(216, 176)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(123, 176)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtRadiusIn
        '
        Me.txtRadiusIn.Location = New System.Drawing.Point(161, 46)
        Me.txtRadiusIn.Name = "txtRadiusIn"
        Me.txtRadiusIn.Size = New System.Drawing.Size(121, 20)
        Me.txtRadiusIn.TabIndex = 3
        '
        'lblAreaCircle
        '
        Me.lblAreaCircle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAreaCircle.Location = New System.Drawing.Point(54, 106)
        Me.lblAreaCircle.Name = "lblAreaCircle"
        Me.lblAreaCircle.Size = New System.Drawing.Size(211, 48)
        Me.lblAreaCircle.TabIndex = 4
        Me.lblAreaCircle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblACircle
        '
        Me.lblACircle.AutoSize = True
        Me.lblACircle.Location = New System.Drawing.Point(120, 84)
        Me.lblACircle.Name = "lblACircle"
        Me.lblACircle.Size = New System.Drawing.Size(87, 13)
        Me.lblACircle.TabIndex = 5
        Me.lblACircle.Text = "Area of the circle"
        '
        'lblRadiusIn
        '
        Me.lblRadiusIn.AutoSize = True
        Me.lblRadiusIn.Location = New System.Drawing.Point(27, 50)
        Me.lblRadiusIn.Name = "lblRadiusIn"
        Me.lblRadiusIn.Size = New System.Drawing.Size(111, 13)
        Me.lblRadiusIn.TabIndex = 6
        Me.lblRadiusIn.Text = "Enter radius in inches:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 245)
        Me.Controls.Add(Me.lblRadiusIn)
        Me.Controls.Add(Me.lblACircle)
        Me.Controls.Add(Me.lblAreaCircle)
        Me.Controls.Add(Me.txtRadiusIn)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "Form1"
        Me.Text = "Circle Area"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtRadiusIn As TextBox
    Friend WithEvents lblAreaCircle As Label
    Friend WithEvents lblACircle As Label
    Friend WithEvents lblRadiusIn As Label
End Class

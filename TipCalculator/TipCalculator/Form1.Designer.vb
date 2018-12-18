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
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.billLabel = New System.Windows.Forms.Label()
        Me.billAmountTextBox = New System.Windows.Forms.TextBox()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.tipLabel = New System.Windows.Forms.Label()
        Me.totalAmountLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.tipTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.tipTotalLabel = New System.Windows.Forms.Label()
        Me.tipAmountLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.Location = New System.Drawing.Point(72, 33)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(100, 23)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Tip Calculator"
        '
        'billLabel
        '
        Me.billLabel.Location = New System.Drawing.Point(25, 70)
        Me.billLabel.Name = "billLabel"
        Me.billLabel.Size = New System.Drawing.Size(34, 23)
        Me.billLabel.TabIndex = 1
        Me.billLabel.Text = "Bill:"
        '
        'billAmountTextBox
        '
        Me.billAmountTextBox.Location = New System.Drawing.Point(75, 70)
        Me.billAmountTextBox.Name = "billAmountTextBox"
        Me.billAmountTextBox.Size = New System.Drawing.Size(67, 20)
        Me.billAmountTextBox.TabIndex = 2
        '
        'totalLabel
        '
        Me.totalLabel.Location = New System.Drawing.Point(25, 188)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(34, 23)
        Me.totalLabel.TabIndex = 7
        Me.totalLabel.Text = "Total:"
        '
        'tipLabel
        '
        Me.tipLabel.Location = New System.Drawing.Point(25, 112)
        Me.tipLabel.Name = "tipLabel"
        Me.tipLabel.Size = New System.Drawing.Size(117, 23)
        Me.tipLabel.TabIndex = 3
        Me.tipLabel.Text = "Tip %:"
        '
        'totalAmountLabel
        '
        Me.totalAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalAmountLabel.Location = New System.Drawing.Point(75, 188)
        Me.totalAmountLabel.Name = "totalAmountLabel"
        Me.totalAmountLabel.Size = New System.Drawing.Size(67, 23)
        Me.totalAmountLabel.TabIndex = 8
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(109, 237)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 10
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'tipTextBox
        '
        Me.tipTextBox.Location = New System.Drawing.Point(75, 112)
        Me.tipTextBox.Name = "tipTextBox"
        Me.tipTextBox.Size = New System.Drawing.Size(67, 20)
        Me.tipTextBox.TabIndex = 4
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(28, 237)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 23)
        Me.calcButton.TabIndex = 9
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'tipTotalLabel
        '
        Me.tipTotalLabel.Location = New System.Drawing.Point(25, 148)
        Me.tipTotalLabel.Name = "tipTotalLabel"
        Me.tipTotalLabel.Size = New System.Drawing.Size(117, 23)
        Me.tipTotalLabel.TabIndex = 5
        Me.tipTotalLabel.Text = "Tip $:"
        '
        'tipAmountLabel
        '
        Me.tipAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tipAmountLabel.Location = New System.Drawing.Point(75, 148)
        Me.tipAmountLabel.Name = "tipAmountLabel"
        Me.tipAmountLabel.Size = New System.Drawing.Size(67, 23)
        Me.tipAmountLabel.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(249, 302)
        Me.Controls.Add(Me.tipAmountLabel)
        Me.Controls.Add(Me.tipTotalLabel)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.tipTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.totalAmountLabel)
        Me.Controls.Add(Me.tipLabel)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.billAmountTextBox)
        Me.Controls.Add(Me.billLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Name = "Form1"
        Me.Text = "Tip Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents billLabel As Label
    Friend WithEvents billAmountTextBox As TextBox
    Friend WithEvents totalLabel As Label
    Friend WithEvents tipLabel As Label
    Friend WithEvents totalAmountLabel As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents tipTextBox As TextBox
    Friend WithEvents calcButton As Button
    Friend WithEvents tipTotalLabel As Label
    Friend WithEvents tipAmountLabel As Label
End Class

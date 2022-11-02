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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.gbFrom = New System.Windows.Forms.GroupBox()
        Me.gbTo = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbFromCm = New System.Windows.Forms.RadioButton()
        Me.rbFromMeters = New System.Windows.Forms.RadioButton()
        Me.rbFromKm = New System.Windows.Forms.RadioButton()
        Me.rbFromInches = New System.Windows.Forms.RadioButton()
        Me.rbFromFeet = New System.Windows.Forms.RadioButton()
        Me.rbFromYards = New System.Windows.Forms.RadioButton()
        Me.rbToYards = New System.Windows.Forms.RadioButton()
        Me.rbToFeet = New System.Windows.Forms.RadioButton()
        Me.rbToInches = New System.Windows.Forms.RadioButton()
        Me.rbToKm = New System.Windows.Forms.RadioButton()
        Me.rbToM = New System.Windows.Forms.RadioButton()
        Me.rbToCm = New System.Windows.Forms.RadioButton()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.listHistory = New System.Windows.Forms.ListBox()
        Me.gbFrom.SuspendLayout()
        Me.gbTo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(133, 27)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 0
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(133, 292)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(100, 20)
        Me.txtOutput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "input length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Result"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(133, 246)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'gbFrom
        '
        Me.gbFrom.Controls.Add(Me.rbFromYards)
        Me.gbFrom.Controls.Add(Me.rbFromFeet)
        Me.gbFrom.Controls.Add(Me.rbFromInches)
        Me.gbFrom.Controls.Add(Me.rbFromKm)
        Me.gbFrom.Controls.Add(Me.rbFromMeters)
        Me.gbFrom.Controls.Add(Me.rbFromCm)
        Me.gbFrom.Location = New System.Drawing.Point(82, 78)
        Me.gbFrom.Name = "gbFrom"
        Me.gbFrom.Size = New System.Drawing.Size(85, 162)
        Me.gbFrom.TabIndex = 7
        Me.gbFrom.TabStop = False
        Me.gbFrom.Text = "GroupBox1"
        '
        'gbTo
        '
        Me.gbTo.Controls.Add(Me.rbToYards)
        Me.gbTo.Controls.Add(Me.rbToInches)
        Me.gbTo.Controls.Add(Me.rbToFeet)
        Me.gbTo.Controls.Add(Me.rbToCm)
        Me.gbTo.Controls.Add(Me.rbToM)
        Me.gbTo.Controls.Add(Me.rbToKm)
        Me.gbTo.Location = New System.Drawing.Point(188, 78)
        Me.gbTo.Name = "gbTo"
        Me.gbTo.Size = New System.Drawing.Size(85, 162)
        Me.gbTo.TabIndex = 8
        Me.gbTo.TabStop = False
        Me.gbTo.Text = "GroupBox2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "from"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(188, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "to"
        '
        'rbFromCm
        '
        Me.rbFromCm.AutoSize = True
        Me.rbFromCm.Location = New System.Drawing.Point(3, 11)
        Me.rbFromCm.Name = "rbFromCm"
        Me.rbFromCm.Size = New System.Drawing.Size(39, 17)
        Me.rbFromCm.TabIndex = 0
        Me.rbFromCm.TabStop = True
        Me.rbFromCm.Text = "cm"
        Me.rbFromCm.UseVisualStyleBackColor = True
        '
        'rbFromMeters
        '
        Me.rbFromMeters.AutoSize = True
        Me.rbFromMeters.Location = New System.Drawing.Point(3, 34)
        Me.rbFromMeters.Name = "rbFromMeters"
        Me.rbFromMeters.Size = New System.Drawing.Size(33, 17)
        Me.rbFromMeters.TabIndex = 1
        Me.rbFromMeters.TabStop = True
        Me.rbFromMeters.Text = "m"
        Me.rbFromMeters.UseVisualStyleBackColor = True
        '
        'rbFromKm
        '
        Me.rbFromKm.AutoSize = True
        Me.rbFromKm.Location = New System.Drawing.Point(3, 57)
        Me.rbFromKm.Name = "rbFromKm"
        Me.rbFromKm.Size = New System.Drawing.Size(39, 17)
        Me.rbFromKm.TabIndex = 2
        Me.rbFromKm.TabStop = True
        Me.rbFromKm.Text = "km"
        Me.rbFromKm.UseVisualStyleBackColor = True
        '
        'rbFromInches
        '
        Me.rbFromInches.AutoSize = True
        Me.rbFromInches.Location = New System.Drawing.Point(3, 80)
        Me.rbFromInches.Name = "rbFromInches"
        Me.rbFromInches.Size = New System.Drawing.Size(56, 17)
        Me.rbFromInches.TabIndex = 3
        Me.rbFromInches.TabStop = True
        Me.rbFromInches.Text = "inches"
        Me.rbFromInches.UseVisualStyleBackColor = True
        '
        'rbFromFeet
        '
        Me.rbFromFeet.AutoSize = True
        Me.rbFromFeet.Location = New System.Drawing.Point(3, 103)
        Me.rbFromFeet.Name = "rbFromFeet"
        Me.rbFromFeet.Size = New System.Drawing.Size(43, 17)
        Me.rbFromFeet.TabIndex = 4
        Me.rbFromFeet.TabStop = True
        Me.rbFromFeet.Text = "feet"
        Me.rbFromFeet.UseVisualStyleBackColor = True
        '
        'rbFromYards
        '
        Me.rbFromYards.AutoSize = True
        Me.rbFromYards.Location = New System.Drawing.Point(3, 126)
        Me.rbFromYards.Name = "rbFromYards"
        Me.rbFromYards.Size = New System.Drawing.Size(50, 17)
        Me.rbFromYards.TabIndex = 5
        Me.rbFromYards.TabStop = True
        Me.rbFromYards.Text = "yards"
        Me.rbFromYards.UseVisualStyleBackColor = True
        '
        'rbToYards
        '
        Me.rbToYards.AutoSize = True
        Me.rbToYards.Location = New System.Drawing.Point(6, 126)
        Me.rbToYards.Name = "rbToYards"
        Me.rbToYards.Size = New System.Drawing.Size(50, 17)
        Me.rbToYards.TabIndex = 11
        Me.rbToYards.TabStop = True
        Me.rbToYards.Text = "yards"
        Me.rbToYards.UseVisualStyleBackColor = True
        '
        'rbToFeet
        '
        Me.rbToFeet.AutoSize = True
        Me.rbToFeet.Location = New System.Drawing.Point(6, 103)
        Me.rbToFeet.Name = "rbToFeet"
        Me.rbToFeet.Size = New System.Drawing.Size(43, 17)
        Me.rbToFeet.TabIndex = 10
        Me.rbToFeet.TabStop = True
        Me.rbToFeet.Text = "feet"
        Me.rbToFeet.UseVisualStyleBackColor = True
        '
        'rbToInches
        '
        Me.rbToInches.AutoSize = True
        Me.rbToInches.Location = New System.Drawing.Point(6, 80)
        Me.rbToInches.Name = "rbToInches"
        Me.rbToInches.Size = New System.Drawing.Size(56, 17)
        Me.rbToInches.TabIndex = 9
        Me.rbToInches.TabStop = True
        Me.rbToInches.Text = "inches"
        Me.rbToInches.UseVisualStyleBackColor = True
        '
        'rbToKm
        '
        Me.rbToKm.AutoSize = True
        Me.rbToKm.Location = New System.Drawing.Point(6, 57)
        Me.rbToKm.Name = "rbToKm"
        Me.rbToKm.Size = New System.Drawing.Size(39, 17)
        Me.rbToKm.TabIndex = 8
        Me.rbToKm.TabStop = True
        Me.rbToKm.Text = "km"
        Me.rbToKm.UseVisualStyleBackColor = True
        '
        'rbToM
        '
        Me.rbToM.AutoSize = True
        Me.rbToM.Location = New System.Drawing.Point(6, 34)
        Me.rbToM.Name = "rbToM"
        Me.rbToM.Size = New System.Drawing.Size(33, 17)
        Me.rbToM.TabIndex = 7
        Me.rbToM.TabStop = True
        Me.rbToM.Text = "m"
        Me.rbToM.UseVisualStyleBackColor = True
        '
        'rbToCm
        '
        Me.rbToCm.AutoSize = True
        Me.rbToCm.Location = New System.Drawing.Point(6, 11)
        Me.rbToCm.Name = "rbToCm"
        Me.rbToCm.Size = New System.Drawing.Size(39, 17)
        Me.rbToCm.TabIndex = 6
        Me.rbToCm.TabStop = True
        Me.rbToCm.Text = "cm"
        Me.rbToCm.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(133, 335)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(94, 23)
        Me.btnHistory.TabIndex = 11
        Me.btnHistory.Text = "Show History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'listHistory
        '
        Me.listHistory.FormattingEnabled = True
        Me.listHistory.Location = New System.Drawing.Point(290, 27)
        Me.listHistory.Name = "listHistory"
        Me.listHistory.Size = New System.Drawing.Size(480, 381)
        Me.listHistory.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.listHistory)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbTo)
        Me.Controls.Add(Me.gbFrom)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbFrom.ResumeLayout(False)
        Me.gbFrom.PerformLayout()
        Me.gbTo.ResumeLayout(False)
        Me.gbTo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents gbFrom As GroupBox
    Friend WithEvents rbFromYards As RadioButton
    Friend WithEvents rbFromFeet As RadioButton
    Friend WithEvents rbFromInches As RadioButton
    Friend WithEvents rbFromKm As RadioButton
    Friend WithEvents rbFromMeters As RadioButton
    Friend WithEvents rbFromCm As RadioButton
    Friend WithEvents gbTo As GroupBox
    Friend WithEvents rbToYards As RadioButton
    Friend WithEvents rbToInches As RadioButton
    Friend WithEvents rbToFeet As RadioButton
    Friend WithEvents rbToCm As RadioButton
    Friend WithEvents rbToM As RadioButton
    Friend WithEvents rbToKm As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnHistory As Button
    Friend WithEvents listHistory As ListBox
End Class

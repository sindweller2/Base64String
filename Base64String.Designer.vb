<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Base64String
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Base64String))
        Me.TextBoxPlain = New System.Windows.Forms.TextBox()
        Me.ButtonToBase64 = New System.Windows.Forms.Button()
        Me.TextBoxToBase64 = New System.Windows.Forms.TextBox()
        Me.ButtonFromBase64 = New System.Windows.Forms.Button()
        Me.TextBoxFromBase64 = New System.Windows.Forms.TextBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxPlain
        '
        Me.TextBoxPlain.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPlain.BackColor = System.Drawing.Color.White
        Me.TextBoxPlain.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxPlain.Multiline = True
        Me.TextBoxPlain.Name = "TextBoxPlain"
        Me.TextBoxPlain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxPlain.Size = New System.Drawing.Size(360, 100)
        Me.TextBoxPlain.TabIndex = 0
        '
        'ButtonToBase64
        '
        Me.ButtonToBase64.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonToBase64.Location = New System.Drawing.Point(206, 330)
        Me.ButtonToBase64.Name = "ButtonToBase64"
        Me.ButtonToBase64.Size = New System.Drawing.Size(80, 23)
        Me.ButtonToBase64.TabIndex = 1
        Me.ButtonToBase64.Text = "To Base64"
        Me.ButtonToBase64.UseVisualStyleBackColor = True
        '
        'TextBoxToBase64
        '
        Me.TextBoxToBase64.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxToBase64.BackColor = System.Drawing.Color.White
        Me.TextBoxToBase64.Location = New System.Drawing.Point(12, 118)
        Me.TextBoxToBase64.Multiline = True
        Me.TextBoxToBase64.Name = "TextBoxToBase64"
        Me.TextBoxToBase64.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxToBase64.Size = New System.Drawing.Size(360, 100)
        Me.TextBoxToBase64.TabIndex = 2
        '
        'ButtonFromBase64
        '
        Me.ButtonFromBase64.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonFromBase64.Location = New System.Drawing.Point(292, 330)
        Me.ButtonFromBase64.Name = "ButtonFromBase64"
        Me.ButtonFromBase64.Size = New System.Drawing.Size(80, 23)
        Me.ButtonFromBase64.TabIndex = 3
        Me.ButtonFromBase64.Text = "From Base64"
        Me.ButtonFromBase64.UseVisualStyleBackColor = True
        '
        'TextBoxFromBase64
        '
        Me.TextBoxFromBase64.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxFromBase64.BackColor = System.Drawing.Color.White
        Me.TextBoxFromBase64.Location = New System.Drawing.Point(12, 224)
        Me.TextBoxFromBase64.Multiline = True
        Me.TextBoxFromBase64.Name = "TextBoxFromBase64"
        Me.TextBoxFromBase64.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxFromBase64.Size = New System.Drawing.Size(360, 100)
        Me.TextBoxFromBase64.TabIndex = 4
        '
        'ButtonClear
        '
        Me.ButtonClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonClear.Location = New System.Drawing.Point(125, 330)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 5
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'Base64String
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 365)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.TextBoxFromBase64)
        Me.Controls.Add(Me.ButtonFromBase64)
        Me.Controls.Add(Me.TextBoxToBase64)
        Me.Controls.Add(Me.ButtonToBase64)
        Me.Controls.Add(Me.TextBoxPlain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Base64String"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Base64String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxPlain As System.Windows.Forms.TextBox
    Friend WithEvents ButtonToBase64 As System.Windows.Forms.Button
    Friend WithEvents TextBoxToBase64 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonFromBase64 As System.Windows.Forms.Button
    Friend WithEvents TextBoxFromBase64 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonClear As System.Windows.Forms.Button

End Class

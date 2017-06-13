<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_BLOCK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_BLOCK))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Block_Button = New System.Windows.Forms.Button()
        Me._IMSS_Cancel_Button = New System.Windows.Forms.Button()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Password_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Confrim_TextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me._IMSS_Password_TextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me._IMSS_MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Block_Button)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Cancel_Button)
        Me._IMSS_MainPanel.Controls.Add(Me.LabelX1)
        Me._IMSS_MainPanel.Controls.Add(Me.LabelX2)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Password_Label)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Confrim_TextBox)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Password_TextBox)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(296, 100)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 7
        '
        '_IMSS_Block_Button
        '
        Me._IMSS_Block_Button.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Block_Button.Location = New System.Drawing.Point(209, 74)
        Me._IMSS_Block_Button.Name = "_IMSS_Block_Button"
        Me._IMSS_Block_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Block_Button.TabIndex = 2
        Me._IMSS_Block_Button.Text = "Block"
        Me._IMSS_Block_Button.UseVisualStyleBackColor = True
        '
        '_IMSS_Cancel_Button
        '
        Me._IMSS_Cancel_Button.Location = New System.Drawing.Point(128, 74)
        Me._IMSS_Cancel_Button.Name = "_IMSS_Cancel_Button"
        Me._IMSS_Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Cancel_Button.TabIndex = 3
        Me._IMSS_Cancel_Button.Text = "Cancel"
        Me._IMSS_Cancel_Button.UseVisualStyleBackColor = True
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(253, 15)
        Me.LabelX1.TabIndex = 6
        Me.LabelX1.Text = "Please insert password to block selected application :"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(3, 55)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(46, 15)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Confrim :"
        '
        '_IMSS_Password_Label
        '
        Me._IMSS_Password_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_Password_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Password_Label.Location = New System.Drawing.Point(0, 26)
        Me._IMSS_Password_Label.Name = "_IMSS_Password_Label"
        Me._IMSS_Password_Label.Size = New System.Drawing.Size(54, 15)
        Me._IMSS_Password_Label.TabIndex = 5
        Me._IMSS_Password_Label.Text = "Password :"
        '
        '_IMSS_Confrim_TextBox
        '
        '
        '
        '
        Me._IMSS_Confrim_TextBox.Border.Class = "TextBoxBorder"
        Me._IMSS_Confrim_TextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Confrim_TextBox.Location = New System.Drawing.Point(60, 50)
        Me._IMSS_Confrim_TextBox.Name = "_IMSS_Confrim_TextBox"
        Me._IMSS_Confrim_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me._IMSS_Confrim_TextBox.Size = New System.Drawing.Size(224, 20)
        Me._IMSS_Confrim_TextBox.TabIndex = 1
        '
        '_IMSS_Password_TextBox
        '
        '
        '
        '
        Me._IMSS_Password_TextBox.Border.Class = "TextBoxBorder"
        Me._IMSS_Password_TextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Password_TextBox.Location = New System.Drawing.Point(60, 25)
        Me._IMSS_Password_TextBox.Name = "_IMSS_Password_TextBox"
        Me._IMSS_Password_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me._IMSS_Password_TextBox.Size = New System.Drawing.Size(224, 20)
        Me._IMSS_Password_TextBox.TabIndex = 0
        '
        'IMSS_BLOCK
        '
        Me.AcceptButton = Me._IMSS_Block_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 100)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(312, 138)
        Me.MinimumSize = New System.Drawing.Size(312, 138)
        Me.Name = "IMSS_BLOCK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Block Item"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Block_Button As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Password_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Confrim_TextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents _IMSS_Password_TextBox As DevComponents.DotNetBar.Controls.TextBoxX
End Class

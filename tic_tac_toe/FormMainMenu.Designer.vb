<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMainMenu
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
        Me.ButtonOnline = New System.Windows.Forms.Button()
        Me.ButtonComputer = New System.Windows.Forms.Button()
        Me.ButtonSelf = New System.Windows.Forms.Button()
        Me.ButtonSettings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonOnline
        '
        Me.ButtonOnline.BackColor = System.Drawing.Color.Black
        Me.ButtonOnline.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOnline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ButtonOnline.Location = New System.Drawing.Point(350, 75)
        Me.ButtonOnline.Name = "ButtonOnline"
        Me.ButtonOnline.Size = New System.Drawing.Size(184, 50)
        Me.ButtonOnline.TabIndex = 1
        Me.ButtonOnline.Text = "ONLINE"
        Me.ButtonOnline.UseVisualStyleBackColor = False
        '
        'ButtonComputer
        '
        Me.ButtonComputer.BackColor = System.Drawing.Color.Black
        Me.ButtonComputer.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonComputer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ButtonComputer.Location = New System.Drawing.Point(350, 187)
        Me.ButtonComputer.Name = "ButtonComputer"
        Me.ButtonComputer.Size = New System.Drawing.Size(184, 50)
        Me.ButtonComputer.TabIndex = 3
        Me.ButtonComputer.Text = "COMPUTER"
        Me.ButtonComputer.UseVisualStyleBackColor = False
        '
        'ButtonSelf
        '
        Me.ButtonSelf.BackColor = System.Drawing.Color.Black
        Me.ButtonSelf.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSelf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ButtonSelf.Location = New System.Drawing.Point(350, 299)
        Me.ButtonSelf.Name = "ButtonSelf"
        Me.ButtonSelf.Size = New System.Drawing.Size(184, 50)
        Me.ButtonSelf.TabIndex = 5
        Me.ButtonSelf.Text = "SELF"
        Me.ButtonSelf.UseVisualStyleBackColor = False
        '
        'ButtonSettings
        '
        Me.ButtonSettings.BackColor = System.Drawing.Color.Black
        Me.ButtonSettings.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ButtonSettings.Location = New System.Drawing.Point(350, 411)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.Size = New System.Drawing.Size(184, 50)
        Me.ButtonSettings.TabIndex = 7
        Me.ButtonSettings.Text = "SETTINGS"
        Me.ButtonSettings.UseVisualStyleBackColor = False
        '
        'FormMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(920, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonSettings)
        Me.Controls.Add(Me.ButtonSelf)
        Me.Controls.Add(Me.ButtonComputer)
        Me.Controls.Add(Me.ButtonOnline)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMainMenu"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonOnline As Button
    Friend WithEvents ButtonComputer As Button
    Friend WithEvents ButtonSelf As Button
    Friend WithEvents ButtonSettings As Button
End Class

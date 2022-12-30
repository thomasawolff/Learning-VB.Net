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
        Me.btnSQLServer = New System.Windows.Forms.Button()
        Me.btnFlatFile = New System.Windows.Forms.Button()
        Me.xmlButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSQLServer
        '
        Me.btnSQLServer.Location = New System.Drawing.Point(121, 71)
        Me.btnSQLServer.Name = "btnSQLServer"
        Me.btnSQLServer.Size = New System.Drawing.Size(117, 31)
        Me.btnSQLServer.TabIndex = 0
        Me.btnSQLServer.Text = "SQLServer"
        Me.btnSQLServer.UseVisualStyleBackColor = True
        '
        'btnFlatFile
        '
        Me.btnFlatFile.Location = New System.Drawing.Point(263, 71)
        Me.btnFlatFile.Name = "btnFlatFile"
        Me.btnFlatFile.Size = New System.Drawing.Size(116, 31)
        Me.btnFlatFile.TabIndex = 1
        Me.btnFlatFile.Text = "Flat Files"
        Me.btnFlatFile.UseVisualStyleBackColor = True
        '
        'xmlButton
        '
        Me.xmlButton.Location = New System.Drawing.Point(399, 71)
        Me.xmlButton.Name = "xmlButton"
        Me.xmlButton.Size = New System.Drawing.Size(117, 33)
        Me.xmlButton.TabIndex = 2
        Me.xmlButton.Text = "XML Button"
        Me.xmlButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 221)
        Me.Controls.Add(Me.xmlButton)
        Me.Controls.Add(Me.btnFlatFile)
        Me.Controls.Add(Me.btnSQLServer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSQLServer As Button
    Friend WithEvents btnFlatFile As Button
    Friend WithEvents xmlButton As Button
End Class

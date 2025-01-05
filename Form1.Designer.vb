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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstCuadroPais = New System.Windows.Forms.ListBox()
        Me.etiPais = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.etiSaludos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Programa Internacional de Bienvenida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Elige un Pais"
        '
        'lstCuadroPais
        '
        Me.lstCuadroPais.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lstCuadroPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstCuadroPais.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCuadroPais.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lstCuadroPais.FormattingEnabled = True
        Me.lstCuadroPais.ItemHeight = 23
        Me.lstCuadroPais.Location = New System.Drawing.Point(17, 85)
        Me.lstCuadroPais.Name = "lstCuadroPais"
        Me.lstCuadroPais.Size = New System.Drawing.Size(391, 140)
        Me.lstCuadroPais.TabIndex = 2
        '
        'etiPais
        '
        Me.etiPais.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.etiPais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiPais.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiPais.ForeColor = System.Drawing.SystemColors.Highlight
        Me.etiPais.Location = New System.Drawing.Point(17, 244)
        Me.etiPais.Name = "etiPais"
        Me.etiPais.Size = New System.Drawing.Size(391, 30)
        Me.etiPais.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSalir.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(172, 334)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 45)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'etiSaludos
        '
        Me.etiSaludos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.etiSaludos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiSaludos.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSaludos.ForeColor = System.Drawing.SystemColors.Highlight
        Me.etiSaludos.Location = New System.Drawing.Point(17, 290)
        Me.etiSaludos.Name = "etiSaludos"
        Me.etiSaludos.Size = New System.Drawing.Size(391, 30)
        Me.etiSaludos.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(425, 391)
        Me.Controls.Add(Me.etiSaludos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.etiPais)
        Me.Controls.Add(Me.lstCuadroPais)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = "Saludos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstCuadroPais As ListBox
    Friend WithEvents etiPais As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents etiSaludos As Label
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EXAMENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESPUESTA1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESPUESTA2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(132, 160)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EXAMENToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(633, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EXAMENToolStripMenuItem
        '
        Me.EXAMENToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RESPUESTA1ToolStripMenuItem, Me.RESPUESTA2ToolStripMenuItem})
        Me.EXAMENToolStripMenuItem.Name = "EXAMENToolStripMenuItem"
        Me.EXAMENToolStripMenuItem.Size = New System.Drawing.Size(77, 23)
        Me.EXAMENToolStripMenuItem.Text = "EXAMEN"
        '
        'RESPUESTA1ToolStripMenuItem
        '
        Me.RESPUESTA1ToolStripMenuItem.Name = "RESPUESTA1ToolStripMenuItem"
        Me.RESPUESTA1ToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.RESPUESTA1ToolStripMenuItem.Text = "RESPUESTA 1"
        '
        'RESPUESTA2ToolStripMenuItem
        '
        Me.RESPUESTA2ToolStripMenuItem.Name = "RESPUESTA2ToolStripMenuItem"
        Me.RESPUESTA2ToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.RESPUESTA2ToolStripMenuItem.Text = "RESPUESTA 2"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(270, 160)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(408, 160)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(270, 230)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(282, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "RESULTADO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "BASE DEL TRAPECIO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(267, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "TOPE DEL TRAPECIO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(427, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ALTURA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(129, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "LADO MENOR:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(267, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "LADO MAYOR:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(427, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "ALTURA:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 366)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(649, 405)
        Me.MinimumSize = New System.Drawing.Size(649, 405)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EXAMENToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RESPUESTA1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RESPUESTA2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class

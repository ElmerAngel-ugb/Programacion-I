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
        Me.TabControlPrincipal = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblunidad = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Convertidor = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblnum3 = New System.Windows.Forms.Label()
        Me.txtcodigo3 = New System.Windows.Forms.TextBox()
        Me.lblr3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxsalida3 = New System.Windows.Forms.ComboBox()
        Me.cbxentrada3 = New System.Windows.Forms.ComboBox()
        Me.btnarea = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.lblr = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TabControlPrincipal.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlPrincipal
        '
        Me.TabControlPrincipal.Controls.Add(Me.TabPage1)
        Me.TabControlPrincipal.Controls.Add(Me.TabPage2)
        Me.TabControlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TabControlPrincipal.Name = "TabControlPrincipal"
        Me.TabControlPrincipal.SelectedIndex = 0
        Me.TabControlPrincipal.Size = New System.Drawing.Size(505, 282)
        Me.TabControlPrincipal.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.lblr)
        Me.TabPage1.Controls.Add(Me.lblunidad)
        Me.TabPage1.Controls.Add(Me.lblcantidad)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Convertidor)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(497, 256)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pestaña 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblunidad
        '
        Me.lblunidad.AutoSize = True
        Me.lblunidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunidad.Location = New System.Drawing.Point(273, 97)
        Me.lblunidad.Name = "lblunidad"
        Me.lblunidad.Size = New System.Drawing.Size(61, 16)
        Me.lblunidad.TabIndex = 127
        Me.lblunidad.Text = "Unidad :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(173, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Conversor"
        '
        'Convertidor
        '
        Me.Convertidor.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Convertidor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Convertidor.Location = New System.Drawing.Point(161, 209)
        Me.Convertidor.Name = "Convertidor"
        Me.Convertidor.Size = New System.Drawing.Size(126, 37)
        Me.Convertidor.TabIndex = 121
        Me.Convertidor.Text = "Convertidor"
        Me.Convertidor.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblnum3)
        Me.TabPage2.Controls.Add(Me.txtcodigo3)
        Me.TabPage2.Controls.Add(Me.lblr3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.cbxsalida3)
        Me.TabPage2.Controls.Add(Me.cbxentrada3)
        Me.TabPage2.Controls.Add(Me.btnarea)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(497, 256)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pestaña 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblnum3
        '
        Me.lblnum3.AutoSize = True
        Me.lblnum3.Location = New System.Drawing.Point(454, 132)
        Me.lblnum3.Name = "lblnum3"
        Me.lblnum3.Size = New System.Drawing.Size(16, 13)
        Me.lblnum3.TabIndex = 121
        Me.lblnum3.Text = "..."
        '
        'txtcodigo3
        '
        Me.txtcodigo3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtcodigo3.Location = New System.Drawing.Point(38, 83)
        Me.txtcodigo3.Name = "txtcodigo3"
        Me.txtcodigo3.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo3.TabIndex = 120
        '
        'lblr3
        '
        Me.lblr3.AutoSize = True
        Me.lblr3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblr3.Location = New System.Drawing.Point(343, 129)
        Me.lblr3.Name = "lblr3"
        Me.lblr3.Size = New System.Drawing.Size(83, 16)
        Me.lblr3.TabIndex = 119
        Me.lblr3.Text = "Repuesta: ?"
        Me.lblr3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 16)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "ÁREA"
        '
        'cbxsalida3
        '
        Me.cbxsalida3.BackColor = System.Drawing.SystemColors.Desktop
        Me.cbxsalida3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxsalida3.FormattingEnabled = True
        Me.cbxsalida3.Items.AddRange(New Object() {"Pie cuadrado", "Vara cuadrada", "Yarda cuadrada", "Metro cuadrado", "Tareas", "Manzana", "Hectárea"})
        Me.cbxsalida3.Location = New System.Drawing.Point(201, 124)
        Me.cbxsalida3.Name = "cbxsalida3"
        Me.cbxsalida3.Size = New System.Drawing.Size(136, 21)
        Me.cbxsalida3.TabIndex = 116
        '
        'cbxentrada3
        '
        Me.cbxentrada3.BackColor = System.Drawing.SystemColors.Desktop
        Me.cbxentrada3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxentrada3.FormattingEnabled = True
        Me.cbxentrada3.Items.AddRange(New Object() {"Pie cuadrado", "Vara cuadrada", "Yarda cuadrada", "Metro cuadrado", "Tareas", "Manzana", "Hectárea"})
        Me.cbxentrada3.Location = New System.Drawing.Point(36, 124)
        Me.cbxentrada3.Name = "cbxentrada3"
        Me.cbxentrada3.Size = New System.Drawing.Size(136, 21)
        Me.cbxentrada3.TabIndex = 115
        '
        'btnarea
        '
        Me.btnarea.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnarea.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnarea.Location = New System.Drawing.Point(38, 166)
        Me.btnarea.Name = "btnarea"
        Me.btnarea.Size = New System.Drawing.Size(126, 37)
        Me.btnarea.TabIndex = 114
        Me.btnarea.Text = "ÁREA"
        Me.btnarea.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GreenYellow
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 59)
        Me.Panel1.TabIndex = 130
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.ImageKey = "(ninguno)"
        Me.RadioButton2.Location = New System.Drawing.Point(180, 12)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(67, 25)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Pestaña 2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.ImageKey = "(ninguno)"
        Me.RadioButton1.Location = New System.Drawing.Point(47, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(67, 25)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Pestaña 1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblr.Location = New System.Drawing.Point(32, 160)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(81, 16)
        Me.lblr.TabIndex = 128
        Me.lblr.Text = "Respuesta :"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantidad.Location = New System.Drawing.Point(40, 102)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(73, 16)
        Me.lblcantidad.TabIndex = 126
        Me.lblcantidad.Text = "Cantidad :"
        Me.lblcantidad.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(119, 98)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 129
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(340, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 130
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(119, 159)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 131
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 280)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControlPrincipal)
        Me.Name = "Form1"
        Me.Text = "Pacial-1"
        Me.TabControlPrincipal.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlPrincipal As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblnum3 As Label
    Friend WithEvents txtcodigo3 As TextBox
    Friend WithEvents lblr3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxsalida3 As ComboBox
    Friend WithEvents cbxentrada3 As ComboBox
    Friend WithEvents btnarea As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Convertidor As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents lblunidad As Label
    Friend WithEvents lblr As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class

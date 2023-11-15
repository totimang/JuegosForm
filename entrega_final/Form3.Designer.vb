<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCiudades
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnVerificar1 = New System.Windows.Forms.Button
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RbCorrecto1 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnVerificar2 = New System.Windows.Forms.Button
        Me.RbCorrecto2 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnVerificar3 = New System.Windows.Forms.Button
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RbCorrecta3 = New System.Windows.Forms.RadioButton
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblCorrecta = New System.Windows.Forms.Label
        Me.LblIncorrecta = New System.Windows.Forms.Label
        Me.BtnAnterior = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnVerificar1)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RbCorrecto1)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 191)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pregunta 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ciudad del Partido ""La Matanza"""
        '
        'BtnVerificar1
        '
        Me.BtnVerificar1.BackColor = System.Drawing.Color.Aqua
        Me.BtnVerificar1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificar1.Location = New System.Drawing.Point(134, 142)
        Me.BtnVerificar1.Name = "BtnVerificar1"
        Me.BtnVerificar1.Size = New System.Drawing.Size(75, 30)
        Me.BtnVerificar1.TabIndex = 1
        Me.BtnVerificar1.Text = "Verificar"
        Me.BtnVerificar1.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(21, 118)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(52, 19)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Tigre"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RbCorrecto1
        '
        Me.RbCorrecto1.AutoSize = True
        Me.RbCorrecto1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbCorrecto1.Location = New System.Drawing.Point(21, 95)
        Me.RbCorrecto1.Name = "RbCorrecto1"
        Me.RbCorrecto1.Size = New System.Drawing.Size(76, 19)
        Me.RbCorrecto1.TabIndex = 2
        Me.RbCorrecto1.TabStop = True
        Me.RbCorrecto1.Text = "San Justo"
        Me.RbCorrecto1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(21, 72)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(57, 19)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Lanús"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.BtnVerificar2)
        Me.GroupBox2.Controls.Add(Me.RbCorrecto2)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(280, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 191)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pregunta 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "¿Cuál es la capital de Portugal?"
        '
        'BtnVerificar2
        '
        Me.BtnVerificar2.BackColor = System.Drawing.Color.Aqua
        Me.BtnVerificar2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificar2.Location = New System.Drawing.Point(134, 142)
        Me.BtnVerificar2.Name = "BtnVerificar2"
        Me.BtnVerificar2.Size = New System.Drawing.Size(75, 30)
        Me.BtnVerificar2.TabIndex = 1
        Me.BtnVerificar2.Text = "Verificar"
        Me.BtnVerificar2.UseVisualStyleBackColor = False
        '
        'RbCorrecto2
        '
        Me.RbCorrecto2.AutoSize = True
        Me.RbCorrecto2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbCorrecto2.Location = New System.Drawing.Point(21, 118)
        Me.RbCorrecto2.Name = "RbCorrecto2"
        Me.RbCorrecto2.Size = New System.Drawing.Size(61, 19)
        Me.RbCorrecto2.TabIndex = 2
        Me.RbCorrecto2.TabStop = True
        Me.RbCorrecto2.Text = "Lisboa"
        Me.RbCorrecto2.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(21, 95)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(62, 19)
        Me.RadioButton4.TabIndex = 2
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Morón"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(21, 72)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(54, 19)
        Me.RadioButton5.TabIndex = 2
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Tokio"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.BtnVerificar3)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RbCorrecta3)
        Me.GroupBox3.Controls.Add(Me.RadioButton7)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(532, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(226, 191)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pregunta 3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Gentilicio de ""Río Negro"""
        '
        'BtnVerificar3
        '
        Me.BtnVerificar3.BackColor = System.Drawing.Color.Aqua
        Me.BtnVerificar3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificar3.Location = New System.Drawing.Point(134, 142)
        Me.BtnVerificar3.Name = "BtnVerificar3"
        Me.BtnVerificar3.Size = New System.Drawing.Size(75, 30)
        Me.BtnVerificar3.TabIndex = 1
        Me.BtnVerificar3.Text = "Verificar"
        Me.BtnVerificar3.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(21, 118)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 19)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Rionecino"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RbCorrecta3
        '
        Me.RbCorrecta3.AutoSize = True
        Me.RbCorrecta3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbCorrecta3.Location = New System.Drawing.Point(21, 95)
        Me.RbCorrecta3.Name = "RbCorrecta3"
        Me.RbCorrecta3.Size = New System.Drawing.Size(85, 19)
        Me.RbCorrecta3.TabIndex = 2
        Me.RbCorrecta3.TabStop = True
        Me.RbCorrecta3.Text = "Rionegrino"
        Me.RbCorrecta3.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7.Location = New System.Drawing.Point(21, 72)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(90, 19)
        Me.RadioButton7.TabIndex = 2
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Rionigrence"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(161, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Correctas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(160, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Incorrectas"
        '
        'LblCorrecta
        '
        Me.LblCorrecta.AutoSize = True
        Me.LblCorrecta.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorrecta.Location = New System.Drawing.Point(258, 288)
        Me.LblCorrecta.Name = "LblCorrecta"
        Me.LblCorrecta.Size = New System.Drawing.Size(20, 23)
        Me.LblCorrecta.TabIndex = 1
        Me.LblCorrecta.Text = "0"
        '
        'LblIncorrecta
        '
        Me.LblIncorrecta.AutoSize = True
        Me.LblIncorrecta.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIncorrecta.Location = New System.Drawing.Point(257, 330)
        Me.LblIncorrecta.Name = "LblIncorrecta"
        Me.LblIncorrecta.Size = New System.Drawing.Size(20, 23)
        Me.LblIncorrecta.TabIndex = 1
        Me.LblIncorrecta.Text = "0"
        '
        'BtnAnterior
        '
        Me.BtnAnterior.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnAnterior.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnterior.Location = New System.Drawing.Point(553, 303)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(100, 50)
        Me.BtnAnterior.TabIndex = 2
        Me.BtnAnterior.Text = "Menu Anterior"
        Me.BtnAnterior.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Coral
        Me.BtnSalir.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(666, 303)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(100, 50)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'FrmCiudades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 379)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnAnterior)
        Me.Controls.Add(Me.LblIncorrecta)
        Me.Controls.Add(Me.LblCorrecta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCiudades"
        Me.Text = "Ciudades"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnVerificar1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RbCorrecto1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnVerificar2 As System.Windows.Forms.Button
    Friend WithEvents RbCorrecto2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnVerificar3 As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RbCorrecta3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblCorrecta As System.Windows.Forms.Label
    Friend WithEvents LblIncorrecta As System.Windows.Forms.Label
    Friend WithEvents BtnAnterior As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
End Class

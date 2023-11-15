<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAritmetica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAritmetica))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnLimpiar1 = New System.Windows.Forms.Button
        Me.BtnDivision = New System.Windows.Forms.Button
        Me.BtnProducto = New System.Windows.Forms.Button
        Me.BtnResta = New System.Windows.Forms.Button
        Me.BtnSuma = New System.Windows.Forms.Button
        Me.TxtResultado = New System.Windows.Forms.TextBox
        Me.TxtNumero2 = New System.Windows.Forms.TextBox
        Me.TxtNumero1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnAnterior = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnLimpiar = New System.Windows.Forms.Button
        Me.BtnCalcular = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TxtPerimetro = New System.Windows.Forms.TextBox
        Me.TxtArea = New System.Windows.Forms.TextBox
        Me.TxtHipotenusa = New System.Windows.Forms.TextBox
        Me.TxtAltura = New System.Windows.Forms.TextBox
        Me.TxtBase = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnLimpiarRect = New System.Windows.Forms.Button
        Me.BtnCalcularRect = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TxtPerimRect = New System.Windows.Forms.TextBox
        Me.TxtAreaRec = New System.Windows.Forms.TextBox
        Me.TxtLado2 = New System.Windows.Forms.TextBox
        Me.TxtLado1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BtnLimpiarCirc = New System.Windows.Forms.Button
        Me.BtnCalcularCirc = New System.Windows.Forms.Button
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.TxtPerimCirc = New System.Windows.Forms.TextBox
        Me.TxtAreaCirc = New System.Windows.Forms.TextBox
        Me.TxtDiametro = New System.Windows.Forms.TextBox
        Me.TxtRadio = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnLimpiarCuad = New System.Windows.Forms.Button
        Me.BtnCalcularCuad = New System.Windows.Forms.Button
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.TxtPerimCuad = New System.Windows.Forms.TextBox
        Me.TxtAreaCuad = New System.Windows.Forms.TextBox
        Me.TxtLadoCuadrado = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar1)
        Me.GroupBox1.Controls.Add(Me.BtnDivision)
        Me.GroupBox1.Controls.Add(Me.BtnProducto)
        Me.GroupBox1.Controls.Add(Me.BtnResta)
        Me.GroupBox1.Controls.Add(Me.BtnSuma)
        Me.GroupBox1.Controls.Add(Me.TxtResultado)
        Me.GroupBox1.Controls.Add(Me.TxtNumero2)
        Me.GroupBox1.Controls.Add(Me.TxtNumero1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 170)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculadora"
        '
        'BtnLimpiar1
        '
        Me.BtnLimpiar1.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnLimpiar1.Location = New System.Drawing.Point(176, 134)
        Me.BtnLimpiar1.Name = "BtnLimpiar1"
        Me.BtnLimpiar1.Size = New System.Drawing.Size(70, 23)
        Me.BtnLimpiar1.TabIndex = 2
        Me.BtnLimpiar1.Text = "Limpiar"
        Me.BtnLimpiar1.UseVisualStyleBackColor = False
        '
        'BtnDivision
        '
        Me.BtnDivision.BackColor = System.Drawing.Color.Aqua
        Me.BtnDivision.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDivision.Location = New System.Drawing.Point(212, 72)
        Me.BtnDivision.Name = "BtnDivision"
        Me.BtnDivision.Size = New System.Drawing.Size(30, 30)
        Me.BtnDivision.TabIndex = 2
        Me.BtnDivision.Text = "/"
        Me.BtnDivision.UseVisualStyleBackColor = False
        '
        'BtnProducto
        '
        Me.BtnProducto.BackColor = System.Drawing.Color.Aqua
        Me.BtnProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProducto.Location = New System.Drawing.Point(212, 36)
        Me.BtnProducto.Name = "BtnProducto"
        Me.BtnProducto.Size = New System.Drawing.Size(30, 30)
        Me.BtnProducto.TabIndex = 2
        Me.BtnProducto.Text = "x"
        Me.BtnProducto.UseVisualStyleBackColor = False
        '
        'BtnResta
        '
        Me.BtnResta.BackColor = System.Drawing.Color.Aqua
        Me.BtnResta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResta.Location = New System.Drawing.Point(176, 72)
        Me.BtnResta.Name = "BtnResta"
        Me.BtnResta.Size = New System.Drawing.Size(30, 30)
        Me.BtnResta.TabIndex = 2
        Me.BtnResta.Text = "-"
        Me.BtnResta.UseVisualStyleBackColor = False
        '
        'BtnSuma
        '
        Me.BtnSuma.BackColor = System.Drawing.Color.Aqua
        Me.BtnSuma.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuma.Location = New System.Drawing.Point(176, 36)
        Me.BtnSuma.Name = "BtnSuma"
        Me.BtnSuma.Size = New System.Drawing.Size(30, 30)
        Me.BtnSuma.TabIndex = 2
        Me.BtnSuma.Text = "+"
        Me.BtnSuma.UseVisualStyleBackColor = False
        '
        'TxtResultado
        '
        Me.TxtResultado.Enabled = False
        Me.TxtResultado.Location = New System.Drawing.Point(102, 134)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(60, 23)
        Me.TxtResultado.TabIndex = 1
        '
        'TxtNumero2
        '
        Me.TxtNumero2.Location = New System.Drawing.Point(95, 67)
        Me.TxtNumero2.Name = "TxtNumero2"
        Me.TxtNumero2.Size = New System.Drawing.Size(50, 23)
        Me.TxtNumero2.TabIndex = 1
        '
        'TxtNumero1
        '
        Me.TxtNumero1.Location = New System.Drawing.Point(95, 36)
        Me.TxtNumero1.Name = "TxtNumero1"
        Me.TxtNumero1.Size = New System.Drawing.Size(50, 23)
        Me.TxtNumero1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Número 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Resultado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número 1:"
        '
        'BtnAnterior
        '
        Me.BtnAnterior.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnAnterior.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnterior.Location = New System.Drawing.Point(1136, 562)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(100, 50)
        Me.BtnAnterior.TabIndex = 1
        Me.BtnAnterior.Text = "Menu anterior"
        Me.BtnAnterior.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Coral
        Me.BtnSalir.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(1242, 562)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 50)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox2.Controls.Add(Me.BtnCalcular)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.TxtPerimetro)
        Me.GroupBox2.Controls.Add(Me.TxtArea)
        Me.GroupBox2.Controls.Add(Me.TxtHipotenusa)
        Me.GroupBox2.Controls.Add(Me.TxtAltura)
        Me.GroupBox2.Controls.Add(Me.TxtBase)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(338, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 253)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Triangulo"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnLimpiar.Location = New System.Drawing.Point(129, 211)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 3
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.Aqua
        Me.BtnCalcular.Location = New System.Drawing.Point(48, 211)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcular.TabIndex = 3
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(179, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'TxtPerimetro
        '
        Me.TxtPerimetro.Enabled = False
        Me.TxtPerimetro.Location = New System.Drawing.Point(106, 138)
        Me.TxtPerimetro.Name = "TxtPerimetro"
        Me.TxtPerimetro.Size = New System.Drawing.Size(50, 22)
        Me.TxtPerimetro.TabIndex = 4
        '
        'TxtArea
        '
        Me.TxtArea.Enabled = False
        Me.TxtArea.Location = New System.Drawing.Point(106, 112)
        Me.TxtArea.Name = "TxtArea"
        Me.TxtArea.Size = New System.Drawing.Size(50, 22)
        Me.TxtArea.TabIndex = 4
        '
        'TxtHipotenusa
        '
        Me.TxtHipotenusa.Enabled = False
        Me.TxtHipotenusa.Location = New System.Drawing.Point(106, 86)
        Me.TxtHipotenusa.Name = "TxtHipotenusa"
        Me.TxtHipotenusa.Size = New System.Drawing.Size(50, 22)
        Me.TxtHipotenusa.TabIndex = 4
        '
        'TxtAltura
        '
        Me.TxtAltura.Location = New System.Drawing.Point(106, 60)
        Me.TxtAltura.Name = "TxtAltura"
        Me.TxtAltura.Size = New System.Drawing.Size(50, 22)
        Me.TxtAltura.TabIndex = 4
        '
        'TxtBase
        '
        Me.TxtBase.Location = New System.Drawing.Point(106, 34)
        Me.TxtBase.Name = "TxtBase"
        Me.TxtBase.Size = New System.Drawing.Size(50, 22)
        Me.TxtBase.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 14)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Perimetro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 14)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Área"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 14)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Hipotenusa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Altura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Base"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnLimpiarRect)
        Me.GroupBox3.Controls.Add(Me.BtnCalcularRect)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.TxtPerimRect)
        Me.GroupBox3.Controls.Add(Me.TxtAreaRec)
        Me.GroupBox3.Controls.Add(Me.TxtLado2)
        Me.GroupBox3.Controls.Add(Me.TxtLado1)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(34, 318)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 253)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rectangulo"
        '
        'BtnLimpiarRect
        '
        Me.BtnLimpiarRect.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnLimpiarRect.Location = New System.Drawing.Point(129, 211)
        Me.BtnLimpiarRect.Name = "BtnLimpiarRect"
        Me.BtnLimpiarRect.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiarRect.TabIndex = 3
        Me.BtnLimpiarRect.Text = "Limpiar"
        Me.BtnLimpiarRect.UseVisualStyleBackColor = False
        '
        'BtnCalcularRect
        '
        Me.BtnCalcularRect.BackColor = System.Drawing.Color.Aqua
        Me.BtnCalcularRect.Location = New System.Drawing.Point(48, 211)
        Me.BtnCalcularRect.Name = "BtnCalcularRect"
        Me.BtnCalcularRect.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcularRect.TabIndex = 3
        Me.BtnCalcularRect.Text = "Calcular"
        Me.BtnCalcularRect.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(179, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(233, 176)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'TxtPerimRect
        '
        Me.TxtPerimRect.Enabled = False
        Me.TxtPerimRect.Location = New System.Drawing.Point(106, 112)
        Me.TxtPerimRect.Name = "TxtPerimRect"
        Me.TxtPerimRect.Size = New System.Drawing.Size(50, 22)
        Me.TxtPerimRect.TabIndex = 4
        '
        'TxtAreaRec
        '
        Me.TxtAreaRec.Enabled = False
        Me.TxtAreaRec.Location = New System.Drawing.Point(106, 86)
        Me.TxtAreaRec.Name = "TxtAreaRec"
        Me.TxtAreaRec.Size = New System.Drawing.Size(50, 22)
        Me.TxtAreaRec.TabIndex = 4
        '
        'TxtLado2
        '
        Me.TxtLado2.Location = New System.Drawing.Point(106, 60)
        Me.TxtLado2.Name = "TxtLado2"
        Me.TxtLado2.Size = New System.Drawing.Size(50, 22)
        Me.TxtLado2.TabIndex = 4
        '
        'TxtLado1
        '
        Me.TxtLado1.Location = New System.Drawing.Point(106, 34)
        Me.TxtLado1.Name = "TxtLado1"
        Me.TxtLado1.Size = New System.Drawing.Size(50, 22)
        Me.TxtLado1.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 14)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Perimetro"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 14)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Área"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 14)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Lado 2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(25, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 14)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Lado 1"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnLimpiarCirc)
        Me.GroupBox4.Controls.Add(Me.BtnCalcularCirc)
        Me.GroupBox4.Controls.Add(Me.PictureBox3)
        Me.GroupBox4.Controls.Add(Me.TxtPerimCirc)
        Me.GroupBox4.Controls.Add(Me.TxtAreaCirc)
        Me.GroupBox4.Controls.Add(Me.TxtDiametro)
        Me.GroupBox4.Controls.Add(Me.TxtRadio)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(853, 40)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(464, 253)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Circulo"
        '
        'BtnLimpiarCirc
        '
        Me.BtnLimpiarCirc.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnLimpiarCirc.Location = New System.Drawing.Point(129, 211)
        Me.BtnLimpiarCirc.Name = "BtnLimpiarCirc"
        Me.BtnLimpiarCirc.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiarCirc.TabIndex = 3
        Me.BtnLimpiarCirc.Text = "Limpiar"
        Me.BtnLimpiarCirc.UseVisualStyleBackColor = False
        '
        'BtnCalcularCirc
        '
        Me.BtnCalcularCirc.BackColor = System.Drawing.Color.Aqua
        Me.BtnCalcularCirc.Location = New System.Drawing.Point(48, 211)
        Me.BtnCalcularCirc.Name = "BtnCalcularCirc"
        Me.BtnCalcularCirc.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcularCirc.TabIndex = 3
        Me.BtnCalcularCirc.Text = "Calcular"
        Me.BtnCalcularCirc.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(179, 11)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(233, 176)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'TxtPerimCirc
        '
        Me.TxtPerimCirc.Enabled = False
        Me.TxtPerimCirc.Location = New System.Drawing.Point(106, 112)
        Me.TxtPerimCirc.Name = "TxtPerimCirc"
        Me.TxtPerimCirc.Size = New System.Drawing.Size(50, 22)
        Me.TxtPerimCirc.TabIndex = 4
        '
        'TxtAreaCirc
        '
        Me.TxtAreaCirc.Enabled = False
        Me.TxtAreaCirc.Location = New System.Drawing.Point(106, 86)
        Me.TxtAreaCirc.Name = "TxtAreaCirc"
        Me.TxtAreaCirc.Size = New System.Drawing.Size(50, 22)
        Me.TxtAreaCirc.TabIndex = 4
        '
        'TxtDiametro
        '
        Me.TxtDiametro.Enabled = False
        Me.TxtDiametro.Location = New System.Drawing.Point(106, 60)
        Me.TxtDiametro.Name = "TxtDiametro"
        Me.TxtDiametro.Size = New System.Drawing.Size(50, 22)
        Me.TxtDiametro.TabIndex = 4
        '
        'TxtRadio
        '
        Me.TxtRadio.Location = New System.Drawing.Point(106, 34)
        Me.TxtRadio.Name = "TxtRadio"
        Me.TxtRadio.Size = New System.Drawing.Size(50, 22)
        Me.TxtRadio.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 14)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Perimetro"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(25, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 14)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Área"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(25, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 14)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Diametro"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(25, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 14)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Radio"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnLimpiarCuad)
        Me.GroupBox5.Controls.Add(Me.BtnCalcularCuad)
        Me.GroupBox5.Controls.Add(Me.PictureBox4)
        Me.GroupBox5.Controls.Add(Me.TxtPerimCuad)
        Me.GroupBox5.Controls.Add(Me.TxtAreaCuad)
        Me.GroupBox5.Controls.Add(Me.TxtLadoCuadrado)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(545, 318)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(464, 253)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cuadrado"
        '
        'BtnLimpiarCuad
        '
        Me.BtnLimpiarCuad.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnLimpiarCuad.Location = New System.Drawing.Point(129, 211)
        Me.BtnLimpiarCuad.Name = "BtnLimpiarCuad"
        Me.BtnLimpiarCuad.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiarCuad.TabIndex = 3
        Me.BtnLimpiarCuad.Text = "Limpiar"
        Me.BtnLimpiarCuad.UseVisualStyleBackColor = False
        '
        'BtnCalcularCuad
        '
        Me.BtnCalcularCuad.BackColor = System.Drawing.Color.Aqua
        Me.BtnCalcularCuad.Location = New System.Drawing.Point(48, 211)
        Me.BtnCalcularCuad.Name = "BtnCalcularCuad"
        Me.BtnCalcularCuad.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcularCuad.TabIndex = 3
        Me.BtnCalcularCuad.Text = "Calcular"
        Me.BtnCalcularCuad.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(179, 11)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(233, 176)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'TxtPerimCuad
        '
        Me.TxtPerimCuad.Enabled = False
        Me.TxtPerimCuad.Location = New System.Drawing.Point(106, 86)
        Me.TxtPerimCuad.Name = "TxtPerimCuad"
        Me.TxtPerimCuad.Size = New System.Drawing.Size(50, 22)
        Me.TxtPerimCuad.TabIndex = 4
        '
        'TxtAreaCuad
        '
        Me.TxtAreaCuad.Enabled = False
        Me.TxtAreaCuad.Location = New System.Drawing.Point(106, 60)
        Me.TxtAreaCuad.Name = "TxtAreaCuad"
        Me.TxtAreaCuad.Size = New System.Drawing.Size(50, 22)
        Me.TxtAreaCuad.TabIndex = 4
        '
        'TxtLadoCuadrado
        '
        Me.TxtLadoCuadrado.Location = New System.Drawing.Point(106, 34)
        Me.TxtLadoCuadrado.Name = "TxtLadoCuadrado"
        Me.TxtLadoCuadrado.Size = New System.Drawing.Size(50, 22)
        Me.TxtLadoCuadrado.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 86)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 14)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Perimetro"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(25, 60)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 14)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Área"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(25, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 14)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Lado 1"
        '
        'FrmAritmetica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 640)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnAnterior)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAritmetica"
        Me.Text = "Aritmetica"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNumero2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumero1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSuma As System.Windows.Forms.Button
    Friend WithEvents BtnDivision As System.Windows.Forms.Button
    Friend WithEvents BtnProducto As System.Windows.Forms.Button
    Friend WithEvents BtnResta As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtResultado As System.Windows.Forms.TextBox
    Friend WithEvents BtnAnterior As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar1 As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPerimetro As System.Windows.Forms.TextBox
    Friend WithEvents TxtArea As System.Windows.Forms.TextBox
    Friend WithEvents TxtHipotenusa As System.Windows.Forms.TextBox
    Friend WithEvents TxtAltura As System.Windows.Forms.TextBox
    Friend WithEvents TxtBase As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnLimpiarRect As System.Windows.Forms.Button
    Friend WithEvents BtnCalcularRect As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtPerimRect As System.Windows.Forms.TextBox
    Friend WithEvents TxtAreaRec As System.Windows.Forms.TextBox
    Friend WithEvents TxtLado2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtLado1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnLimpiarCirc As System.Windows.Forms.Button
    Friend WithEvents BtnCalcularCirc As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtPerimCirc As System.Windows.Forms.TextBox
    Friend WithEvents TxtAreaCirc As System.Windows.Forms.TextBox
    Friend WithEvents TxtDiametro As System.Windows.Forms.TextBox
    Friend WithEvents TxtRadio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnLimpiarCuad As System.Windows.Forms.Button
    Friend WithEvents BtnCalcularCuad As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtPerimCuad As System.Windows.Forms.TextBox
    Friend WithEvents TxtAreaCuad As System.Windows.Forms.TextBox
    Friend WithEvents TxtLadoCuadrado As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btn_Calcular = New System.Windows.Forms.Button()
        Me.txt_Valor1 = New System.Windows.Forms.TextBox()
        Me.txt_Valor2 = New System.Windows.Forms.TextBox()
        Me.lbl_Valor1 = New System.Windows.Forms.Label()
        Me.lbl_Valor2 = New System.Windows.Forms.Label()
        Me.cnb_Operador = New System.Windows.Forms.ComboBox()
        Me.txt_Resultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_Calcular
        '
        Me.btn_Calcular.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Calcular.Location = New System.Drawing.Point(46, 244)
        Me.btn_Calcular.Name = "btn_Calcular"
        Me.btn_Calcular.Size = New System.Drawing.Size(136, 26)
        Me.btn_Calcular.TabIndex = 0
        Me.btn_Calcular.Text = "Calcular"
        Me.btn_Calcular.UseVisualStyleBackColor = True
        '
        'txt_Valor1
        '
        Me.txt_Valor1.Location = New System.Drawing.Point(41, 70)
        Me.txt_Valor1.Name = "txt_Valor1"
        Me.txt_Valor1.Size = New System.Drawing.Size(202, 20)
        Me.txt_Valor1.TabIndex = 1
        '
        'txt_Valor2
        '
        Me.txt_Valor2.Location = New System.Drawing.Point(288, 70)
        Me.txt_Valor2.Name = "txt_Valor2"
        Me.txt_Valor2.Size = New System.Drawing.Size(202, 20)
        Me.txt_Valor2.TabIndex = 2
        '
        'lbl_Valor1
        '
        Me.lbl_Valor1.AutoSize = True
        Me.lbl_Valor1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Valor1.Location = New System.Drawing.Point(41, 48)
        Me.lbl_Valor1.Name = "lbl_Valor1"
        Me.lbl_Valor1.Size = New System.Drawing.Size(61, 19)
        Me.lbl_Valor1.TabIndex = 3
        Me.lbl_Valor1.Text = "Valor 1"
        '
        'lbl_Valor2
        '
        Me.lbl_Valor2.AutoSize = True
        Me.lbl_Valor2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Valor2.Location = New System.Drawing.Point(285, 48)
        Me.lbl_Valor2.Name = "lbl_Valor2"
        Me.lbl_Valor2.Size = New System.Drawing.Size(61, 19)
        Me.lbl_Valor2.TabIndex = 4
        Me.lbl_Valor2.Text = "Valor 2"
        '
        'cnb_Operador
        '
        Me.cnb_Operador.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnb_Operador.FormattingEnabled = True
        Me.cnb_Operador.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicacion", "Division"})
        Me.cnb_Operador.Location = New System.Drawing.Point(45, 141)
        Me.cnb_Operador.Name = "cnb_Operador"
        Me.cnb_Operador.Size = New System.Drawing.Size(193, 26)
        Me.cnb_Operador.TabIndex = 5
        Me.cnb_Operador.Text = "Elija un operador"
        '
        'txt_Resultado
        '
        Me.txt_Resultado.Enabled = False
        Me.txt_Resultado.Location = New System.Drawing.Point(289, 147)
        Me.txt_Resultado.Name = "txt_Resultado"
        Me.txt_Resultado.Size = New System.Drawing.Size(201, 20)
        Me.txt_Resultado.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Resultado"
        '
        'btn_Salir
        '
        Me.btn_Salir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(355, 244)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(136, 26)
        Me.btn_Salir.TabIndex = 9
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.Location = New System.Drawing.Point(201, 244)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(136, 26)
        Me.btn_Limpiar.TabIndex = 10
        Me.btn_Limpiar.Text = "Limpiar"
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 339)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Resultado)
        Me.Controls.Add(Me.cnb_Operador)
        Me.Controls.Add(Me.lbl_Valor2)
        Me.Controls.Add(Me.lbl_Valor1)
        Me.Controls.Add(Me.txt_Valor2)
        Me.Controls.Add(Me.txt_Valor1)
        Me.Controls.Add(Me.btn_Calcular)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Calcular As Button
    Friend WithEvents txt_Valor1 As TextBox
    Friend WithEvents txt_Valor2 As TextBox
    Friend WithEvents lbl_Valor1 As Label
    Friend WithEvents lbl_Valor2 As Label
    Friend WithEvents cnb_Operador As ComboBox
    Friend WithEvents txt_Resultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Salir As Button
    Friend WithEvents btn_Limpiar As Button
End Class

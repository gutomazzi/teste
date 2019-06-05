<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstprodutos = New System.Windows.Forms.ListBox()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.txtproduto = New System.Windows.Forms.TextBox()
        Me.btnadicionar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstprodutos
        '
        Me.lstprodutos.FormattingEnabled = True
        Me.lstprodutos.Location = New System.Drawing.Point(12, 12)
        Me.lstprodutos.Name = "lstprodutos"
        Me.lstprodutos.Size = New System.Drawing.Size(121, 225)
        Me.lstprodutos.TabIndex = 0
        '
        'btnmostrar
        '
        Me.btnmostrar.Location = New System.Drawing.Point(139, 12)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(126, 23)
        Me.btnmostrar.TabIndex = 1
        Me.btnmostrar.Text = "Mostrar"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'btnexcluir
        '
        Me.btnexcluir.Location = New System.Drawing.Point(140, 42)
        Me.btnexcluir.Name = "btnexcluir"
        Me.btnexcluir.Size = New System.Drawing.Size(125, 23)
        Me.btnexcluir.TabIndex = 2
        Me.btnexcluir.Text = "Excluir"
        Me.btnexcluir.UseVisualStyleBackColor = True
        '
        'txtproduto
        '
        Me.txtproduto.Location = New System.Drawing.Point(12, 257)
        Me.txtproduto.Name = "txtproduto"
        Me.txtproduto.Size = New System.Drawing.Size(185, 20)
        Me.txtproduto.TabIndex = 3
        '
        'btnadicionar
        '
        Me.btnadicionar.Location = New System.Drawing.Point(203, 257)
        Me.btnadicionar.Name = "btnadicionar"
        Me.btnadicionar.Size = New System.Drawing.Size(62, 20)
        Me.btnadicionar.TabIndex = 4
        Me.btnadicionar.Text = "Adicionar"
        Me.btnadicionar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 305)
        Me.Controls.Add(Me.btnadicionar)
        Me.Controls.Add(Me.txtproduto)
        Me.Controls.Add(Me.btnexcluir)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.lstprodutos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstprodutos As ListBox
    Friend WithEvents btnmostrar As Button
    Friend WithEvents btnexcluir As Button
    Friend WithEvents txtproduto As TextBox
    Friend WithEvents btnadicionar As Button
End Class

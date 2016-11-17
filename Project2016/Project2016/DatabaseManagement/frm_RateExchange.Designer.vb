<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RateExchange
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
        Me.dgvBoat = New System.Windows.Forms.DataGridView()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btClear = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.dgvBoat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBoat
        '
        Me.dgvBoat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBoat.Location = New System.Drawing.Point(25, 204)
        Me.dgvBoat.Name = "dgvBoat"
        Me.dgvBoat.Size = New System.Drawing.Size(454, 91)
        Me.dgvBoat.TabIndex = 27
        '
        'btClose
        '
        Me.btClose.Location = New System.Drawing.Point(201, 314)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(91, 31)
        Me.btClose.TabIndex = 22
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btClear
        '
        Me.btClear.Location = New System.Drawing.Point(346, 153)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(91, 31)
        Me.btClear.TabIndex = 23
        Me.btClear.Text = "Clear"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Location = New System.Drawing.Point(249, 153)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(91, 31)
        Me.btDelete.TabIndex = 24
        Me.btDelete.Text = "Delete"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(152, 153)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(91, 31)
        Me.btEdit.TabIndex = 25
        Me.btEdit.Text = "Edit"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(55, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 31)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(181, 64)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(219, 31)
        Me.TextBox2.TabIndex = 20
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(181, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(219, 31)
        Me.TextBox1.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ເງິນຕາ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 23)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ລະຫັດອັດຕາແລະປ່ຽນ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 23)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "ອັດຕາແລກປ່ຽນ:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(181, 101)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(219, 31)
        Me.TextBox3.TabIndex = 20
        '
        'frm_RateExchange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 370)
        Me.Controls.Add(Me.dgvBoat)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btDelete)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_RateExchange"
        Me.Text = "frm_RateExchange"
        CType(Me.dgvBoat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBoat As DataGridView
    Friend WithEvents btClose As Button
    Friend WithEvents btClear As Button
    Friend WithEvents btDelete As Button
    Friend WithEvents btEdit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
End Class

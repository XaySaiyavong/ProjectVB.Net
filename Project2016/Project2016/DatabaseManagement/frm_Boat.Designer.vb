<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Boat
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
        Me.txtBoatID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoatType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoatName = New System.Windows.Forms.TextBox()
        Me.txtBoatStatus = New System.Windows.Forms.TextBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.btClear = New System.Windows.Forms.Button()
        Me.dgvBoat = New System.Windows.Forms.DataGridView()
        Me.btClose = New System.Windows.Forms.Button()
        CType(Me.dgvBoat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ລະຫັດເຮືອ:"
        '
        'txtBoatID
        '
        Me.txtBoatID.Location = New System.Drawing.Point(174, 30)
        Me.txtBoatID.Name = "txtBoatID"
        Me.txtBoatID.Size = New System.Drawing.Size(219, 31)
        Me.txtBoatID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ປະເພດ:"
        '
        'txtBoatType
        '
        Me.txtBoatType.Location = New System.Drawing.Point(174, 70)
        Me.txtBoatType.Name = "txtBoatType"
        Me.txtBoatType.Size = New System.Drawing.Size(219, 31)
        Me.txtBoatType.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ຊື່:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ສະຖານະ:"
        '
        'txtBoatName
        '
        Me.txtBoatName.Location = New System.Drawing.Point(174, 112)
        Me.txtBoatName.Name = "txtBoatName"
        Me.txtBoatName.Size = New System.Drawing.Size(219, 31)
        Me.txtBoatName.TabIndex = 1
        '
        'txtBoatStatus
        '
        Me.txtBoatStatus.Location = New System.Drawing.Point(174, 152)
        Me.txtBoatStatus.Name = "txtBoatStatus"
        Me.txtBoatStatus.Size = New System.Drawing.Size(219, 31)
        Me.txtBoatStatus.TabIndex = 1
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(77, 210)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(91, 31)
        Me.btSave.TabIndex = 2
        Me.btSave.Text = "Save"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(174, 210)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(91, 31)
        Me.btEdit.TabIndex = 2
        Me.btEdit.Text = "Edit"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Location = New System.Drawing.Point(271, 210)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(91, 31)
        Me.btDelete.TabIndex = 2
        Me.btDelete.Text = "Delete"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'btClear
        '
        Me.btClear.Location = New System.Drawing.Point(368, 210)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(91, 31)
        Me.btClear.TabIndex = 2
        Me.btClear.Text = "Clear"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'dgvBoat
        '
        Me.dgvBoat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBoat.Location = New System.Drawing.Point(13, 267)
        Me.dgvBoat.Name = "dgvBoat"
        Me.dgvBoat.Size = New System.Drawing.Size(514, 91)
        Me.dgvBoat.TabIndex = 3
        '
        'btClose
        '
        Me.btClose.Location = New System.Drawing.Point(218, 364)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(91, 31)
        Me.btClose.TabIndex = 2
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'frm_Boat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 400)
        Me.Controls.Add(Me.dgvBoat)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btDelete)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.txtBoatStatus)
        Me.Controls.Add(Me.txtBoatName)
        Me.Controls.Add(Me.txtBoatType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBoatID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_Boat"
        Me.Text = "frm_Boat"
        CType(Me.dgvBoat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoatID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoatType As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBoatName As TextBox
    Friend WithEvents txtBoatStatus As TextBox
    Friend WithEvents btSave As Button
    Friend WithEvents btEdit As Button
    Friend WithEvents btDelete As Button
    Friend WithEvents btClear As Button
    Friend WithEvents dgvBoat As DataGridView
    Friend WithEvents btClose As Button
End Class

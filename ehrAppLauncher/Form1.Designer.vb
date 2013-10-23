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
        Me.lvApps = New System.Windows.Forms.ListView()
        Me.chAppName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAlias = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch32Path = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch64Path = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtAppName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt32BitPath = New System.Windows.Forms.TextBox()
        Me.txt64BitPath = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn32BitDialog = New System.Windows.Forms.Button()
        Me.btn64BitDialog = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtConfFile = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvApps
        '
        Me.lvApps.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chAppName, Me.chAlias, Me.ch32Path, Me.ch64Path})
        Me.lvApps.GridLines = True
        Me.lvApps.HideSelection = False
        Me.lvApps.Location = New System.Drawing.Point(12, 12)
        Me.lvApps.MultiSelect = False
        Me.lvApps.Name = "lvApps"
        Me.lvApps.Size = New System.Drawing.Size(955, 173)
        Me.lvApps.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvApps.TabIndex = 0
        Me.lvApps.UseCompatibleStateImageBehavior = False
        Me.lvApps.View = System.Windows.Forms.View.Details
        '
        'chAppName
        '
        Me.chAppName.Text = "Application Name"
        Me.chAppName.Width = 125
        '
        'chAlias
        '
        Me.chAlias.Text = "Alias"
        Me.chAlias.Width = 120
        '
        'ch32Path
        '
        Me.ch32Path.Text = "32 Bit Path"
        Me.ch32Path.Width = 350
        '
        'ch64Path
        '
        Me.ch64Path.Text = "64 Bit Path"
        Me.ch64Path.Width = 350
        '
        'txtAppName
        '
        Me.txtAppName.Location = New System.Drawing.Point(109, 230)
        Me.txtAppName.Name = "txtAppName"
        Me.txtAppName.Size = New System.Drawing.Size(176, 20)
        Me.txtAppName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Application Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "32 Bit Path"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "64 Bit Path"
        '
        'txt32BitPath
        '
        Me.txt32BitPath.Location = New System.Drawing.Point(109, 256)
        Me.txt32BitPath.Name = "txt32BitPath"
        Me.txt32BitPath.Size = New System.Drawing.Size(421, 20)
        Me.txt32BitPath.TabIndex = 3
        '
        'txt64BitPath
        '
        Me.txt64BitPath.Location = New System.Drawing.Point(109, 282)
        Me.txt64BitPath.Name = "txt64BitPath"
        Me.txt64BitPath.Size = New System.Drawing.Size(421, 20)
        Me.txt64BitPath.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn32BitDialog
        '
        Me.btn32BitDialog.Location = New System.Drawing.Point(536, 256)
        Me.btn32BitDialog.Name = "btn32BitDialog"
        Me.btn32BitDialog.Size = New System.Drawing.Size(33, 20)
        Me.btn32BitDialog.TabIndex = 4
        Me.btn32BitDialog.Text = "..."
        Me.btn32BitDialog.UseVisualStyleBackColor = True
        '
        'btn64BitDialog
        '
        Me.btn64BitDialog.Location = New System.Drawing.Point(537, 282)
        Me.btn64BitDialog.Name = "btn64BitDialog"
        Me.btn64BitDialog.Size = New System.Drawing.Size(32, 20)
        Me.btn64BitDialog.TabIndex = 6
        Me.btn64BitDialog.Text = "..."
        Me.btn64BitDialog.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(13, 313)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(94, 313)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(175, 313)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(291, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Alias"
        '
        'txtAlias
        '
        Me.txtAlias.Location = New System.Drawing.Point(326, 230)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(117, 20)
        Me.txtAlias.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(862, 313)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save All"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtConfFile
        '
        Me.txtConfFile.Location = New System.Drawing.Point(15, 196)
        Me.txtConfFile.Name = "txtConfFile"
        Me.txtConfFile.Size = New System.Drawing.Size(798, 20)
        Me.txtConfFile.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(820, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Choose Config File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(367, 313)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(163, 23)
        Me.btnTest.TabIndex = 16
        Me.btnTest.Text = "Test Selected Application"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(862, 285)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(105, 23)
        Me.btnAbout.TabIndex = 17
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 348)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtConfFile)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtAlias)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btn64BitDialog)
        Me.Controls.Add(Me.btn32BitDialog)
        Me.Controls.Add(Me.txt64BitPath)
        Me.Controls.Add(Me.txt32BitPath)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAppName)
        Me.Controls.Add(Me.lvApps)
        Me.Name = "Form1"
        Me.Text = "EHR Launcher Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvApps As System.Windows.Forms.ListView
    Friend WithEvents chAppName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ch32Path As System.Windows.Forms.ColumnHeader
    Friend WithEvents ch64Path As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtAppName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt32BitPath As System.Windows.Forms.TextBox
    Friend WithEvents txt64BitPath As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn32BitDialog As System.Windows.Forms.Button
    Friend WithEvents btn64BitDialog As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents chAlias As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAlias As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtConfFile As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button

End Class

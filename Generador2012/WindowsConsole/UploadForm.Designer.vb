<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadForm
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
        Me.OpenFileButton = New System.Windows.Forms.Button()
        Me.FilenameTextBox = New System.Windows.Forms.TextBox()
        Me.CompilarButton = New System.Windows.Forms.Button()
        Me.FilenameLabel = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.rtbArchivo = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.tsslActivo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtnReformat = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConvertidorPTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvertidorTPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileButton
        '
        Me.OpenFileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenFileButton.Location = New System.Drawing.Point(728, 25)
        Me.OpenFileButton.Name = "OpenFileButton"
        Me.OpenFileButton.Size = New System.Drawing.Size(37, 23)
        Me.OpenFileButton.TabIndex = 11
        Me.OpenFileButton.Text = "..."
        Me.OpenFileButton.UseVisualStyleBackColor = True
        '
        'FilenameTextBox
        '
        Me.FilenameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilenameTextBox.Location = New System.Drawing.Point(147, 27)
        Me.FilenameTextBox.Name = "FilenameTextBox"
        Me.FilenameTextBox.Size = New System.Drawing.Size(575, 20)
        Me.FilenameTextBox.TabIndex = 10
        '
        'CompilarButton
        '
        Me.CompilarButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompilarButton.Location = New System.Drawing.Point(349, 393)
        Me.CompilarButton.Name = "CompilarButton"
        Me.CompilarButton.Size = New System.Drawing.Size(75, 23)
        Me.CompilarButton.TabIndex = 8
        Me.CompilarButton.Text = "Compilar"
        Me.CompilarButton.UseVisualStyleBackColor = True
        '
        'FilenameLabel
        '
        Me.FilenameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilenameLabel.AutoSize = True
        Me.FilenameLabel.Location = New System.Drawing.Point(17, 30)
        Me.FilenameLabel.Name = "FilenameLabel"
        Me.FilenameLabel.Size = New System.Drawing.Size(98, 13)
        Me.FilenameLabel.TabIndex = 9
        Me.FilenameLabel.Text = "Archivo de Entrada"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        Me.OpenFileDialog.InitialDirectory = "C:\1_Paso\Generador2012\Input"
        Me.OpenFileDialog.Title = "Archivo de Especificacion"
        '
        'rtbArchivo
        '
        Me.rtbArchivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbArchivo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbArchivo.Location = New System.Drawing.Point(15, 56)
        Me.rtbArchivo.Name = "rtbArchivo"
        Me.rtbArchivo.Size = New System.Drawing.Size(750, 326)
        Me.rtbArchivo.TabIndex = 12
        Me.rtbArchivo.Text = ""
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AllowMerge = False
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje, Me.tsslProgress, Me.tsslActivo})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 421)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(779, 24)
        Me.StatusStrip1.Stretch = False
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.UseWaitCursor = True
        '
        'tsslMensaje
        '
        Me.tsslMensaje.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.tsslMensaje.Name = "tsslMensaje"
        Me.tsslMensaje.Size = New System.Drawing.Size(70, 19)
        Me.tsslMensaje.Text = "Bienvenido"
        '
        'tsslProgress
        '
        Me.tsslProgress.Name = "tsslProgress"
        Me.tsslProgress.Size = New System.Drawing.Size(100, 18)
        '
        'tsslActivo
        '
        Me.tsslActivo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.tsslActivo.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.tsslActivo.Name = "tsslActivo"
        Me.tsslActivo.Size = New System.Drawing.Size(4, 19)
        Me.tsslActivo.Spring = True
        '
        'BtnReformat
        '
        Me.BtnReformat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReformat.Location = New System.Drawing.Point(633, 393)
        Me.BtnReformat.Name = "BtnReformat"
        Me.BtnReformat.Size = New System.Drawing.Size(132, 22)
        Me.BtnReformat.TabIndex = 14
        Me.BtnReformat.Text = "Reformatear"
        Me.BtnReformat.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(779, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.AbrirToolStripMenuItem.Text = "&Abrir"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.ToolStripMenuItem1, Me.ConvertidorPTToolStripMenuItem, Me.ConvertidorTPToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'ConvertidorPTToolStripMenuItem
        '
        Me.ConvertidorPTToolStripMenuItem.Name = "ConvertidorPTToolStripMenuItem"
        Me.ConvertidorPTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConvertidorPTToolStripMenuItem.Text = "ConvertidorPT"
        '
        'ConvertidorTPToolStripMenuItem
        '
        Me.ConvertidorTPToolStripMenuItem.Name = "ConvertidorTPToolStripMenuItem"
        Me.ConvertidorTPToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConvertidorTPToolStripMenuItem.Text = "ConvertidorTP"
        '
        'UploadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 445)
        Me.Controls.Add(Me.BtnReformat)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.rtbArchivo)
        Me.Controls.Add(Me.OpenFileButton)
        Me.Controls.Add(Me.FilenameTextBox)
        Me.Controls.Add(Me.CompilarButton)
        Me.Controls.Add(Me.FilenameLabel)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "UploadForm"
        Me.Text = "UploadForm"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileButton As System.Windows.Forms.Button
    Friend WithEvents FilenameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompilarButton As System.Windows.Forms.Button
    Friend WithEvents FilenameLabel As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents rtbArchivo As System.Windows.Forms.RichTextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslMensaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BtnReformat As System.Windows.Forms.Button
    Friend WithEvents tsslProgress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents tsslActivo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConvertidorPTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvertidorTPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

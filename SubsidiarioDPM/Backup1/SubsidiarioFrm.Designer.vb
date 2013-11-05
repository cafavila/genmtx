<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubsidiarioFrm
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
        Me.ArchivoOpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.ExportSaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.ControlTabControl = New System.Windows.Forms.TabControl
        Me.LoadTabPage = New System.Windows.Forms.TabPage
        Me.ExportButton = New System.Windows.Forms.Button
        Me.ProcesarButton = New System.Windows.Forms.Button
        Me.DetalleTextBox = New System.Windows.Forms.TextBox
        Me.OpenFileButton = New System.Windows.Forms.Button
        Me.ArchivoTextBox = New System.Windows.Forms.TextBox
        Me.ArchivoLabel = New System.Windows.Forms.Label
        Me.TotalizaTabPage = New System.Windows.Forms.TabPage
        Me.PaneldeControl = New System.Windows.Forms.Panel
        Me.ExportarButton = New System.Windows.Forms.Button
        Me.TotalButton = New System.Windows.Forms.Button
        Me.OficinaCheckBox = New System.Windows.Forms.CheckBox
        Me.PanelTotal = New System.Windows.Forms.Panel
        Me.TotalDataGridView = New System.Windows.Forms.DataGridView
        Me.CuentaCtblCheckBox = New System.Windows.Forms.CheckBox
        Me.MensajesStatusStrip = New System.Windows.Forms.StatusStrip
        Me.InfoLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ControlTabControl.SuspendLayout()
        Me.LoadTabPage.SuspendLayout()
        Me.TotalizaTabPage.SuspendLayout()
        Me.PaneldeControl.SuspendLayout()
        Me.PanelTotal.SuspendLayout()
        CType(Me.TotalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MensajesStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ArchivoOpenFileDialog
        '
        Me.ArchivoOpenFileDialog.FileName = "Subsidiario.txt"
        '
        'ControlTabControl
        '
        Me.ControlTabControl.Controls.Add(Me.LoadTabPage)
        Me.ControlTabControl.Controls.Add(Me.TotalizaTabPage)
        Me.ControlTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlTabControl.Location = New System.Drawing.Point(0, 0)
        Me.ControlTabControl.Name = "ControlTabControl"
        Me.ControlTabControl.SelectedIndex = 0
        Me.ControlTabControl.Size = New System.Drawing.Size(699, 338)
        Me.ControlTabControl.TabIndex = 7
        '
        'LoadTabPage
        '
        Me.LoadTabPage.Controls.Add(Me.ExportButton)
        Me.LoadTabPage.Controls.Add(Me.ProcesarButton)
        Me.LoadTabPage.Controls.Add(Me.DetalleTextBox)
        Me.LoadTabPage.Controls.Add(Me.OpenFileButton)
        Me.LoadTabPage.Controls.Add(Me.ArchivoTextBox)
        Me.LoadTabPage.Controls.Add(Me.ArchivoLabel)
        Me.LoadTabPage.Location = New System.Drawing.Point(4, 22)
        Me.LoadTabPage.Name = "LoadTabPage"
        Me.LoadTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.LoadTabPage.Size = New System.Drawing.Size(691, 312)
        Me.LoadTabPage.TabIndex = 0
        Me.LoadTabPage.Text = "Carga Subsidiario"
        Me.LoadTabPage.UseVisualStyleBackColor = True
        '
        'ExportButton
        '
        Me.ExportButton.Enabled = False
        Me.ExportButton.Location = New System.Drawing.Point(611, 71)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(75, 22)
        Me.ExportButton.TabIndex = 11
        Me.ExportButton.Text = "Exportar"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'ProcesarButton
        '
        Me.ProcesarButton.Enabled = False
        Me.ProcesarButton.Location = New System.Drawing.Point(611, 41)
        Me.ProcesarButton.Name = "ProcesarButton"
        Me.ProcesarButton.Size = New System.Drawing.Size(75, 24)
        Me.ProcesarButton.TabIndex = 10
        Me.ProcesarButton.Text = "Procesar"
        Me.ProcesarButton.UseVisualStyleBackColor = True
        '
        'DetalleTextBox
        '
        Me.DetalleTextBox.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetalleTextBox.Location = New System.Drawing.Point(5, 41)
        Me.DetalleTextBox.Multiline = True
        Me.DetalleTextBox.Name = "DetalleTextBox"
        Me.DetalleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DetalleTextBox.Size = New System.Drawing.Size(599, 268)
        Me.DetalleTextBox.TabIndex = 9
        '
        'OpenFileButton
        '
        Me.OpenFileButton.Location = New System.Drawing.Point(575, 4)
        Me.OpenFileButton.Name = "OpenFileButton"
        Me.OpenFileButton.Size = New System.Drawing.Size(29, 22)
        Me.OpenFileButton.TabIndex = 8
        Me.OpenFileButton.Text = "..."
        Me.OpenFileButton.UseVisualStyleBackColor = True
        '
        'ArchivoTextBox
        '
        Me.ArchivoTextBox.Location = New System.Drawing.Point(84, 6)
        Me.ArchivoTextBox.Name = "ArchivoTextBox"
        Me.ArchivoTextBox.Size = New System.Drawing.Size(485, 20)
        Me.ArchivoTextBox.TabIndex = 7
        '
        'ArchivoLabel
        '
        Me.ArchivoLabel.AutoSize = True
        Me.ArchivoLabel.Location = New System.Drawing.Point(35, 9)
        Me.ArchivoLabel.Name = "ArchivoLabel"
        Me.ArchivoLabel.Size = New System.Drawing.Size(43, 13)
        Me.ArchivoLabel.TabIndex = 6
        Me.ArchivoLabel.Text = "Archivo"
        '
        'TotalizaTabPage
        '
        Me.TotalizaTabPage.Controls.Add(Me.PaneldeControl)
        Me.TotalizaTabPage.Location = New System.Drawing.Point(4, 22)
        Me.TotalizaTabPage.Name = "TotalizaTabPage"
        Me.TotalizaTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TotalizaTabPage.Size = New System.Drawing.Size(691, 312)
        Me.TotalizaTabPage.TabIndex = 1
        Me.TotalizaTabPage.Text = "Totalizador"
        Me.TotalizaTabPage.UseVisualStyleBackColor = True
        '
        'PaneldeControl
        '
        Me.PaneldeControl.AutoSize = True
        Me.PaneldeControl.Controls.Add(Me.ExportarButton)
        Me.PaneldeControl.Controls.Add(Me.TotalButton)
        Me.PaneldeControl.Controls.Add(Me.OficinaCheckBox)
        Me.PaneldeControl.Controls.Add(Me.PanelTotal)
        Me.PaneldeControl.Controls.Add(Me.CuentaCtblCheckBox)
        Me.PaneldeControl.Location = New System.Drawing.Point(9, 7)
        Me.PaneldeControl.Name = "PaneldeControl"
        Me.PaneldeControl.Size = New System.Drawing.Size(677, 287)
        Me.PaneldeControl.TabIndex = 0
        '
        'ExportarButton
        '
        Me.ExportarButton.Enabled = False
        Me.ExportarButton.Location = New System.Drawing.Point(591, 14)
        Me.ExportarButton.Name = "ExportarButton"
        Me.ExportarButton.Size = New System.Drawing.Size(75, 23)
        Me.ExportarButton.TabIndex = 5
        Me.ExportarButton.Text = "Exportar"
        Me.ExportarButton.UseVisualStyleBackColor = True
        '
        'TotalButton
        '
        Me.TotalButton.Location = New System.Drawing.Point(500, 14)
        Me.TotalButton.Name = "TotalButton"
        Me.TotalButton.Size = New System.Drawing.Size(75, 23)
        Me.TotalButton.TabIndex = 4
        Me.TotalButton.Text = "Totalizar"
        Me.TotalButton.UseVisualStyleBackColor = True
        '
        'OficinaCheckBox
        '
        Me.OficinaCheckBox.AutoSize = True
        Me.OficinaCheckBox.Location = New System.Drawing.Point(147, 14)
        Me.OficinaCheckBox.Name = "OficinaCheckBox"
        Me.OficinaCheckBox.Size = New System.Drawing.Size(78, 17)
        Me.OficinaCheckBox.TabIndex = 3
        Me.OficinaCheckBox.Text = "Por Oficina"
        Me.OficinaCheckBox.UseVisualStyleBackColor = True
        '
        'PanelTotal
        '
        Me.PanelTotal.AutoSize = True
        Me.PanelTotal.Controls.Add(Me.TotalDataGridView)
        Me.PanelTotal.Location = New System.Drawing.Point(4, 46)
        Me.PanelTotal.Name = "PanelTotal"
        Me.PanelTotal.Size = New System.Drawing.Size(670, 238)
        Me.PanelTotal.TabIndex = 2
        '
        'TotalDataGridView
        '
        Me.TotalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TotalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TotalDataGridView.Name = "TotalDataGridView"
        Me.TotalDataGridView.RowHeadersVisible = False
        Me.TotalDataGridView.Size = New System.Drawing.Size(670, 238)
        Me.TotalDataGridView.TabIndex = 1
        '
        'CuentaCtblCheckBox
        '
        Me.CuentaCtblCheckBox.AutoSize = True
        Me.CuentaCtblCheckBox.Location = New System.Drawing.Point(16, 14)
        Me.CuentaCtblCheckBox.Name = "CuentaCtblCheckBox"
        Me.CuentaCtblCheckBox.Size = New System.Drawing.Size(124, 17)
        Me.CuentaCtblCheckBox.TabIndex = 0
        Me.CuentaCtblCheckBox.Text = "Por Cuenta Contable"
        Me.CuentaCtblCheckBox.UseVisualStyleBackColor = True
        '
        'MensajesStatusStrip
        '
        Me.MensajesStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoLabel})
        Me.MensajesStatusStrip.Location = New System.Drawing.Point(0, 316)
        Me.MensajesStatusStrip.Name = "MensajesStatusStrip"
        Me.MensajesStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MensajesStatusStrip.Size = New System.Drawing.Size(699, 22)
        Me.MensajesStatusStrip.TabIndex = 12
        Me.MensajesStatusStrip.Text = "Esperando..."
        '
        'InfoLabel
        '
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(74, 17)
        Me.InfoLabel.Text = "Esperando...."
        '
        'SubsidiarioFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 338)
        Me.Controls.Add(Me.MensajesStatusStrip)
        Me.Controls.Add(Me.ControlTabControl)
        Me.Name = "SubsidiarioFrm"
        Me.Text = "Subsidiario"
        Me.ControlTabControl.ResumeLayout(False)
        Me.LoadTabPage.ResumeLayout(False)
        Me.LoadTabPage.PerformLayout()
        Me.TotalizaTabPage.ResumeLayout(False)
        Me.TotalizaTabPage.PerformLayout()
        Me.PaneldeControl.ResumeLayout(False)
        Me.PaneldeControl.PerformLayout()
        Me.PanelTotal.ResumeLayout(False)
        CType(Me.TotalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MensajesStatusStrip.ResumeLayout(False)
        Me.MensajesStatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ArchivoOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ExportSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ControlTabControl As System.Windows.Forms.TabControl
    Friend WithEvents LoadTabPage As System.Windows.Forms.TabPage
    Friend WithEvents TotalizaTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ExportButton As System.Windows.Forms.Button
    Friend WithEvents ProcesarButton As System.Windows.Forms.Button
    Friend WithEvents DetalleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileButton As System.Windows.Forms.Button
    Friend WithEvents ArchivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ArchivoLabel As System.Windows.Forms.Label
    Friend WithEvents MensajesStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents InfoLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PaneldeControl As System.Windows.Forms.Panel
    Friend WithEvents TotalDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CuentaCtblCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PanelTotal As System.Windows.Forms.Panel
    Friend WithEvents TotalButton As System.Windows.Forms.Button
    Friend WithEvents OficinaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ExportarButton As System.Windows.Forms.Button

End Class

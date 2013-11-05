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
        Me.ArchivoOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ExportSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ControlTabControl = New System.Windows.Forms.TabControl()
        Me.SubsidiarioTabPage = New System.Windows.Forms.TabPage()
        Me.EtapasCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.InfoEtapaLabel = New System.Windows.Forms.Label()
        Me.EtapaLabel = New System.Windows.Forms.Label()
        Me.EtapaProgressBar = New System.Windows.Forms.ProgressBar()
        Me.MesComboBox = New System.Windows.Forms.ComboBox()
        Me.PathTextBox = New System.Windows.Forms.TextBox()
        Me.DirectorioLabel = New System.Windows.Forms.Label()
        Me.OpenFolderButton = New System.Windows.Forms.Button()
        Me.ProcesarButton = New System.Windows.Forms.Button()
        Me.ActivoLabel = New System.Windows.Forms.Label()
        Me.FileProgressBar = New System.Windows.Forms.ProgressBar()
        Me.MensajesStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.InfoLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.ControlTabControl.SuspendLayout()
        Me.SubsidiarioTabPage.SuspendLayout()
        Me.MensajesStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ArchivoOpenFileDialog
        '
        Me.ArchivoOpenFileDialog.FileName = "Subsidiario.txt"
        '
        'ControlTabControl
        '
        Me.ControlTabControl.Controls.Add(Me.SubsidiarioTabPage)
        Me.ControlTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlTabControl.Location = New System.Drawing.Point(0, 0)
        Me.ControlTabControl.Name = "ControlTabControl"
        Me.ControlTabControl.SelectedIndex = 0
        Me.ControlTabControl.Size = New System.Drawing.Size(699, 338)
        Me.ControlTabControl.TabIndex = 7
        '
        'SubsidiarioTabPage
        '
        Me.SubsidiarioTabPage.Controls.Add(Me.EtapasCheckedListBox)
        Me.SubsidiarioTabPage.Controls.Add(Me.InfoEtapaLabel)
        Me.SubsidiarioTabPage.Controls.Add(Me.EtapaLabel)
        Me.SubsidiarioTabPage.Controls.Add(Me.EtapaProgressBar)
        Me.SubsidiarioTabPage.Controls.Add(Me.MesComboBox)
        Me.SubsidiarioTabPage.Controls.Add(Me.PathTextBox)
        Me.SubsidiarioTabPage.Controls.Add(Me.DirectorioLabel)
        Me.SubsidiarioTabPage.Controls.Add(Me.OpenFolderButton)
        Me.SubsidiarioTabPage.Controls.Add(Me.ProcesarButton)
        Me.SubsidiarioTabPage.Controls.Add(Me.ActivoLabel)
        Me.SubsidiarioTabPage.Controls.Add(Me.FileProgressBar)
        Me.SubsidiarioTabPage.Location = New System.Drawing.Point(4, 22)
        Me.SubsidiarioTabPage.Name = "SubsidiarioTabPage"
        Me.SubsidiarioTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SubsidiarioTabPage.Size = New System.Drawing.Size(691, 312)
        Me.SubsidiarioTabPage.TabIndex = 2
        Me.SubsidiarioTabPage.Text = "Subsidiario"
        Me.SubsidiarioTabPage.UseVisualStyleBackColor = True
        '
        'EtapasCheckedListBox
        '
        Me.EtapasCheckedListBox.CheckOnClick = True
        Me.EtapasCheckedListBox.FormattingEnabled = True
        Me.EtapasCheckedListBox.Items.AddRange(New Object() {"Cargar Archivos Subsidiario", "Generar Archivo Detalle", "Inyeccion de Detalle DB", "Calculo de Totales Subsidiario", "Cargar Cartera GCD", "Generar Saldos Promedio"})
        Me.EtapasCheckedListBox.Location = New System.Drawing.Point(517, 89)
        Me.EtapasCheckedListBox.Name = "EtapasCheckedListBox"
        Me.EtapasCheckedListBox.Size = New System.Drawing.Size(166, 124)
        Me.EtapasCheckedListBox.TabIndex = 11
        '
        'InfoEtapaLabel
        '
        Me.InfoEtapaLabel.AutoSize = True
        Me.InfoEtapaLabel.Location = New System.Drawing.Point(187, 93)
        Me.InfoEtapaLabel.Name = "InfoEtapaLabel"
        Me.InfoEtapaLabel.Size = New System.Drawing.Size(114, 13)
        Me.InfoEtapaLabel.TabIndex = 10
        Me.InfoEtapaLabel.Text = "Seleccion de Entradas"
        '
        'EtapaLabel
        '
        Me.EtapaLabel.AutoSize = True
        Me.EtapaLabel.Location = New System.Drawing.Point(71, 93)
        Me.EtapaLabel.Name = "EtapaLabel"
        Me.EtapaLabel.Size = New System.Drawing.Size(44, 13)
        Me.EtapaLabel.TabIndex = 9
        Me.EtapaLabel.Text = "Etapa : "
        '
        'EtapaProgressBar
        '
        Me.EtapaProgressBar.Location = New System.Drawing.Point(74, 119)
        Me.EtapaProgressBar.Name = "EtapaProgressBar"
        Me.EtapaProgressBar.Size = New System.Drawing.Size(437, 23)
        Me.EtapaProgressBar.TabIndex = 8
        '
        'MesComboBox
        '
        Me.MesComboBox.FormattingEnabled = True
        Me.MesComboBox.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.MesComboBox.Location = New System.Drawing.Point(517, 34)
        Me.MesComboBox.Name = "MesComboBox"
        Me.MesComboBox.Size = New System.Drawing.Size(90, 21)
        Me.MesComboBox.TabIndex = 7
        '
        'PathTextBox
        '
        Me.PathTextBox.Location = New System.Drawing.Point(129, 63)
        Me.PathTextBox.Name = "PathTextBox"
        Me.PathTextBox.Size = New System.Drawing.Size(382, 20)
        Me.PathTextBox.TabIndex = 5
        '
        'DirectorioLabel
        '
        Me.DirectorioLabel.AutoSize = True
        Me.DirectorioLabel.Location = New System.Drawing.Point(71, 66)
        Me.DirectorioLabel.Name = "DirectorioLabel"
        Me.DirectorioLabel.Size = New System.Drawing.Size(52, 13)
        Me.DirectorioLabel.TabIndex = 4
        Me.DirectorioLabel.Text = "Directorio"
        '
        'OpenFolderButton
        '
        Me.OpenFolderButton.Location = New System.Drawing.Point(517, 61)
        Me.OpenFolderButton.Name = "OpenFolderButton"
        Me.OpenFolderButton.Size = New System.Drawing.Size(34, 23)
        Me.OpenFolderButton.TabIndex = 3
        Me.OpenFolderButton.Text = "..."
        Me.OpenFolderButton.UseVisualStyleBackColor = True
        '
        'ProcesarButton
        '
        Me.ProcesarButton.Location = New System.Drawing.Point(557, 61)
        Me.ProcesarButton.Name = "ProcesarButton"
        Me.ProcesarButton.Size = New System.Drawing.Size(75, 23)
        Me.ProcesarButton.TabIndex = 2
        Me.ProcesarButton.Text = "Procesar"
        Me.ProcesarButton.UseVisualStyleBackColor = True
        '
        'ActivoLabel
        '
        Me.ActivoLabel.AutoSize = True
        Me.ActivoLabel.Location = New System.Drawing.Point(71, 198)
        Me.ActivoLabel.Name = "ActivoLabel"
        Me.ActivoLabel.Size = New System.Drawing.Size(0, 13)
        Me.ActivoLabel.TabIndex = 1
        '
        'FileProgressBar
        '
        Me.FileProgressBar.Location = New System.Drawing.Point(74, 165)
        Me.FileProgressBar.Name = "FileProgressBar"
        Me.FileProgressBar.Size = New System.Drawing.Size(437, 23)
        Me.FileProgressBar.TabIndex = 0
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
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'SubsidiarioFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 338)
        Me.Controls.Add(Me.MensajesStatusStrip)
        Me.Controls.Add(Me.ControlTabControl)
        Me.Name = "SubsidiarioFrm"
        Me.Text = "Bancware"
        Me.ControlTabControl.ResumeLayout(False)
        Me.SubsidiarioTabPage.ResumeLayout(False)
        Me.SubsidiarioTabPage.PerformLayout()
        Me.MensajesStatusStrip.ResumeLayout(False)
        Me.MensajesStatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ArchivoOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ExportSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ControlTabControl As System.Windows.Forms.TabControl
    Friend WithEvents MensajesStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents InfoLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SubsidiarioTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ProcesarButton As System.Windows.Forms.Button
    Friend WithEvents ActivoLabel As System.Windows.Forms.Label
    Friend WithEvents FileProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents PathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DirectorioLabel As System.Windows.Forms.Label
    Friend WithEvents OpenFolderButton As System.Windows.Forms.Button
    Friend WithEvents MesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents InfoEtapaLabel As System.Windows.Forms.Label
    Friend WithEvents EtapaLabel As System.Windows.Forms.Label
    Friend WithEvents EtapaProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents EtapasCheckedListBox As System.Windows.Forms.CheckedListBox

End Class

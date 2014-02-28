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
        Me.PathLabel = New System.Windows.Forms.Label()
        Me.PathTextBox = New System.Windows.Forms.TextBox()
        Me.PathButton = New System.Windows.Forms.Button()
        Me.MesProcesoLabel = New System.Windows.Forms.Label()
        Me.MesComboBox = New System.Windows.Forms.ComboBox()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.ActiveLabel = New System.Windows.Forms.Label()
        Me.LecturaButton = New System.Windows.Forms.Button()
        Me.CargarSubsidiarioProgressBar = New System.Windows.Forms.ProgressBar()
        Me.LoadProgressBar = New System.Windows.Forms.ProgressBar()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.DetalleProgressBar = New System.Windows.Forms.ProgressBar()
        Me.DetalleButton = New System.Windows.Forms.Button()
        Me.TotalProgressBar = New System.Windows.Forms.ProgressBar()
        Me.GeneraTotalButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PathLabel
        '
        Me.PathLabel.AutoSize = True
        Me.PathLabel.Location = New System.Drawing.Point(18, 59)
        Me.PathLabel.Name = "PathLabel"
        Me.PathLabel.Size = New System.Drawing.Size(55, 13)
        Me.PathLabel.TabIndex = 0
        Me.PathLabel.Text = "Directorio "
        '
        'PathTextBox
        '
        Me.PathTextBox.Location = New System.Drawing.Point(89, 56)
        Me.PathTextBox.Name = "PathTextBox"
        Me.PathTextBox.Size = New System.Drawing.Size(586, 20)
        Me.PathTextBox.TabIndex = 1
        '
        'PathButton
        '
        Me.PathButton.Location = New System.Drawing.Point(681, 54)
        Me.PathButton.Name = "PathButton"
        Me.PathButton.Size = New System.Drawing.Size(30, 23)
        Me.PathButton.TabIndex = 2
        Me.PathButton.Text = "..."
        Me.PathButton.UseVisualStyleBackColor = True
        '
        'MesProcesoLabel
        '
        Me.MesProcesoLabel.AutoSize = True
        Me.MesProcesoLabel.Location = New System.Drawing.Point(423, 28)
        Me.MesProcesoLabel.Name = "MesProcesoLabel"
        Me.MesProcesoLabel.Size = New System.Drawing.Size(84, 13)
        Me.MesProcesoLabel.TabIndex = 3
        Me.MesProcesoLabel.Text = "Mes de Proceso"
        '
        'MesComboBox
        '
        Me.MesComboBox.FormattingEnabled = True
        Me.MesComboBox.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.MesComboBox.Location = New System.Drawing.Point(513, 25)
        Me.MesComboBox.Name = "MesComboBox"
        Me.MesComboBox.Size = New System.Drawing.Size(162, 21)
        Me.MesComboBox.TabIndex = 8
        '
        'ActiveLabel
        '
        Me.ActiveLabel.AutoSize = True
        Me.ActiveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveLabel.Location = New System.Drawing.Point(17, 243)
        Me.ActiveLabel.Name = "ActiveLabel"
        Me.ActiveLabel.Size = New System.Drawing.Size(287, 24)
        Me.ActiveLabel.TabIndex = 9
        Me.ActiveLabel.Text = "Iniciando proceso Subsidiario"
        '
        'LecturaButton
        '
        Me.LecturaButton.Location = New System.Drawing.Point(21, 94)
        Me.LecturaButton.Name = "LecturaButton"
        Me.LecturaButton.Size = New System.Drawing.Size(135, 23)
        Me.LecturaButton.TabIndex = 10
        Me.LecturaButton.Text = "Lectura de Archivos"
        Me.LecturaButton.UseVisualStyleBackColor = True
        '
        'CargarSubsidiarioProgressBar
        '
        Me.CargarSubsidiarioProgressBar.Location = New System.Drawing.Point(162, 94)
        Me.CargarSubsidiarioProgressBar.Name = "CargarSubsidiarioProgressBar"
        Me.CargarSubsidiarioProgressBar.Size = New System.Drawing.Size(513, 23)
        Me.CargarSubsidiarioProgressBar.TabIndex = 11
        '
        'LoadProgressBar
        '
        Me.LoadProgressBar.Location = New System.Drawing.Point(162, 158)
        Me.LoadProgressBar.Name = "LoadProgressBar"
        Me.LoadProgressBar.Size = New System.Drawing.Size(513, 23)
        Me.LoadProgressBar.TabIndex = 13
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(21, 158)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(135, 23)
        Me.LoadButton.TabIndex = 12
        Me.LoadButton.Text = "Carga Subsidiario"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'DetalleProgressBar
        '
        Me.DetalleProgressBar.Location = New System.Drawing.Point(162, 125)
        Me.DetalleProgressBar.Name = "DetalleProgressBar"
        Me.DetalleProgressBar.Size = New System.Drawing.Size(513, 23)
        Me.DetalleProgressBar.TabIndex = 15
        '
        'DetalleButton
        '
        Me.DetalleButton.Location = New System.Drawing.Point(21, 125)
        Me.DetalleButton.Name = "DetalleButton"
        Me.DetalleButton.Size = New System.Drawing.Size(135, 23)
        Me.DetalleButton.TabIndex = 14
        Me.DetalleButton.Text = "Detalle Subsidiario"
        Me.DetalleButton.UseVisualStyleBackColor = True
        '
        'TotalProgressBar
        '
        Me.TotalProgressBar.Location = New System.Drawing.Point(162, 191)
        Me.TotalProgressBar.Name = "TotalProgressBar"
        Me.TotalProgressBar.Size = New System.Drawing.Size(513, 23)
        Me.TotalProgressBar.TabIndex = 17
        '
        'GeneraTotalButton
        '
        Me.GeneraTotalButton.Location = New System.Drawing.Point(21, 191)
        Me.GeneraTotalButton.Name = "GeneraTotalButton"
        Me.GeneraTotalButton.Size = New System.Drawing.Size(135, 23)
        Me.GeneraTotalButton.TabIndex = 16
        Me.GeneraTotalButton.Text = "GeneraTotales"
        Me.GeneraTotalButton.UseVisualStyleBackColor = True
        '
        'SubsidiarioFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 308)
        Me.Controls.Add(Me.TotalProgressBar)
        Me.Controls.Add(Me.GeneraTotalButton)
        Me.Controls.Add(Me.DetalleProgressBar)
        Me.Controls.Add(Me.DetalleButton)
        Me.Controls.Add(Me.LoadProgressBar)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.CargarSubsidiarioProgressBar)
        Me.Controls.Add(Me.LecturaButton)
        Me.Controls.Add(Me.ActiveLabel)
        Me.Controls.Add(Me.MesComboBox)
        Me.Controls.Add(Me.MesProcesoLabel)
        Me.Controls.Add(Me.PathButton)
        Me.Controls.Add(Me.PathTextBox)
        Me.Controls.Add(Me.PathLabel)
        Me.Name = "SubsidiarioFrm"
        Me.Text = "Subsidiario v2.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PathLabel As System.Windows.Forms.Label
    Friend WithEvents PathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PathButton As System.Windows.Forms.Button
    Friend WithEvents MesProcesoLabel As System.Windows.Forms.Label
    Friend WithEvents MesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ActiveLabel As System.Windows.Forms.Label
    Friend WithEvents LecturaButton As System.Windows.Forms.Button
    Friend WithEvents CargarSubsidiarioProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents LoadProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents LoadButton As System.Windows.Forms.Button
    Friend WithEvents DetalleProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents DetalleButton As System.Windows.Forms.Button
    Friend WithEvents TotalProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents GeneraTotalButton As System.Windows.Forms.Button

End Class

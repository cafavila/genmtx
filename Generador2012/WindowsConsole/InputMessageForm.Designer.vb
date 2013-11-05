<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputMessageForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputMessageForm))
        Me.ContenedorPanel = New System.Windows.Forms.Panel()
        Me.ArmadoTextBox = New System.Windows.Forms.TextBox()
        Me.MensajeTextBox = New System.Windows.Forms.TextBox()
        Me.menuToolStrip = New System.Windows.Forms.ToolStrip()
        Me.EjecutarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.LimpiarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ContenedorPanel.SuspendLayout()
        Me.menuToolStrip.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContenedorPanel
        '
        Me.ContenedorPanel.Controls.Add(Me.ArmadoTextBox)
        Me.ContenedorPanel.Controls.Add(Me.MensajeTextBox)
        Me.ContenedorPanel.Controls.Add(Me.menuToolStrip)
        Me.ContenedorPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContenedorPanel.Location = New System.Drawing.Point(0, 0)
        Me.ContenedorPanel.Name = "ContenedorPanel"
        Me.ContenedorPanel.Size = New System.Drawing.Size(851, 345)
        Me.ContenedorPanel.TabIndex = 0
        '
        'ArmadoTextBox
        '
        Me.ArmadoTextBox.Location = New System.Drawing.Point(12, 302)
        Me.ArmadoTextBox.Name = "ArmadoTextBox"
        Me.ArmadoTextBox.Size = New System.Drawing.Size(827, 20)
        Me.ArmadoTextBox.TabIndex = 3
        '
        'MensajeTextBox
        '
        Me.MensajeTextBox.Location = New System.Drawing.Point(12, 28)
        Me.MensajeTextBox.Multiline = True
        Me.MensajeTextBox.Name = "MensajeTextBox"
        Me.MensajeTextBox.Size = New System.Drawing.Size(827, 260)
        Me.MensajeTextBox.TabIndex = 2
        '
        'menuToolStrip
        '
        Me.menuToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EjecutarToolStripButton, Me.LimpiarToolStripButton})
        Me.menuToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuToolStrip.Name = "menuToolStrip"
        Me.menuToolStrip.Size = New System.Drawing.Size(851, 25)
        Me.menuToolStrip.TabIndex = 1
        Me.menuToolStrip.Text = "ToolStrip1"
        '
        'EjecutarToolStripButton
        '
        Me.EjecutarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EjecutarToolStripButton.Image = CType(resources.GetObject("EjecutarToolStripButton.Image"), System.Drawing.Image)
        Me.EjecutarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EjecutarToolStripButton.Name = "EjecutarToolStripButton"
        Me.EjecutarToolStripButton.Size = New System.Drawing.Size(53, 22)
        Me.EjecutarToolStripButton.Text = "Ejecutar"
        Me.EjecutarToolStripButton.ToolTipText = "Ejecutar"
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(851, 320)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(851, 345)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'LimpiarToolStripButton
        '
        Me.LimpiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LimpiarToolStripButton.Image = CType(resources.GetObject("LimpiarToolStripButton.Image"), System.Drawing.Image)
        Me.LimpiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LimpiarToolStripButton.Name = "LimpiarToolStripButton"
        Me.LimpiarToolStripButton.Size = New System.Drawing.Size(51, 22)
        Me.LimpiarToolStripButton.Text = "&Limpiar"
        '
        'InputMessageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 345)
        Me.Controls.Add(Me.ContenedorPanel)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "InputMessageForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "InputMessageForm"
        Me.ContenedorPanel.ResumeLayout(False)
        Me.ContenedorPanel.PerformLayout()
        Me.menuToolStrip.ResumeLayout(False)
        Me.menuToolStrip.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContenedorPanel As System.Windows.Forms.Panel
    Friend WithEvents ArmadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MensajeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents menuToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents EjecutarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents LimpiarToolStripButton As System.Windows.Forms.ToolStripButton
End Class

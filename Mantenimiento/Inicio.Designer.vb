<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirF4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirF4ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MáquinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HojasDeVidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DatosTécnicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrdenesDeTrabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MantenimientosRealizadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrdenesDeTrabajoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.IndicadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TrabajosDeMantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisponiblesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SolicitudesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.MáquinasToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(353, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.TabStop = True
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirF4ToolStripMenuItem, Me.SalirF4ToolStripMenuItem1})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'SalirF4ToolStripMenuItem
        '
        Me.SalirF4ToolStripMenuItem.Name = "SalirF4ToolStripMenuItem"
        Me.SalirF4ToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.SalirF4ToolStripMenuItem.Text = "Iniciar sesión de nuevo"
        '
        'SalirF4ToolStripMenuItem1
        '
        Me.SalirF4ToolStripMenuItem1.Name = "SalirF4ToolStripMenuItem1"
        Me.SalirF4ToolStripMenuItem1.Size = New System.Drawing.Size(194, 22)
        Me.SalirF4ToolStripMenuItem1.Text = "Salir"
        '
        'MáquinasToolStripMenuItem
        '
        Me.MáquinasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HojasDeVidaToolStripMenuItem, Me.DatosTécnicosToolStripMenuItem})
        Me.MáquinasToolStripMenuItem.Name = "MáquinasToolStripMenuItem"
        Me.MáquinasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.MáquinasToolStripMenuItem.Text = "Máquinas"
        '
        'HojasDeVidaToolStripMenuItem
        '
        Me.HojasDeVidaToolStripMenuItem.Name = "HojasDeVidaToolStripMenuItem"
        Me.HojasDeVidaToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.HojasDeVidaToolStripMenuItem.Text = "Hojas de vida"
        '
        'DatosTécnicosToolStripMenuItem
        '
        Me.DatosTécnicosToolStripMenuItem.Name = "DatosTécnicosToolStripMenuItem"
        Me.DatosTécnicosToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.DatosTécnicosToolStripMenuItem.Text = "Datos técnicos"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenesDeTrabajoToolStripMenuItem, Me.TrabajosDeMantenimientoToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'OrdenesDeTrabajoToolStripMenuItem
        '
        Me.OrdenesDeTrabajoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientosRealizadosToolStripMenuItem, Me.OrdenesDeTrabajoToolStripMenuItem1, Me.IndicadoresToolStripMenuItem})
        Me.OrdenesDeTrabajoToolStripMenuItem.Name = "OrdenesDeTrabajoToolStripMenuItem"
        Me.OrdenesDeTrabajoToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.OrdenesDeTrabajoToolStripMenuItem.Text = "Registro de trabajos"
        '
        'MantenimientosRealizadosToolStripMenuItem
        '
        Me.MantenimientosRealizadosToolStripMenuItem.Name = "MantenimientosRealizadosToolStripMenuItem"
        Me.MantenimientosRealizadosToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.MantenimientosRealizadosToolStripMenuItem.Text = "Mantenimientos realizados"
        '
        'OrdenesDeTrabajoToolStripMenuItem1
        '
        Me.OrdenesDeTrabajoToolStripMenuItem1.Name = "OrdenesDeTrabajoToolStripMenuItem1"
        Me.OrdenesDeTrabajoToolStripMenuItem1.Size = New System.Drawing.Size(216, 22)
        Me.OrdenesDeTrabajoToolStripMenuItem1.Text = "Ordenes de trabajo"
        '
        'IndicadoresToolStripMenuItem
        '
        Me.IndicadoresToolStripMenuItem.Name = "IndicadoresToolStripMenuItem"
        Me.IndicadoresToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.IndicadoresToolStripMenuItem.Text = "Indicadores"
        '
        'TrabajosDeMantenimientoToolStripMenuItem
        '
        Me.TrabajosDeMantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisponiblesToolStripMenuItem, Me.SolicitudesToolStripMenuItem})
        Me.TrabajosDeMantenimientoToolStripMenuItem.Name = "TrabajosDeMantenimientoToolStripMenuItem"
        Me.TrabajosDeMantenimientoToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.TrabajosDeMantenimientoToolStripMenuItem.Text = "Repuestos"
        '
        'DisponiblesToolStripMenuItem
        '
        Me.DisponiblesToolStripMenuItem.Name = "DisponiblesToolStripMenuItem"
        Me.DisponiblesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.DisponiblesToolStripMenuItem.Text = "Disponibles"
        '
        'SolicitudesToolStripMenuItem
        '
        Me.SolicitudesToolStripMenuItem.Name = "SolicitudesToolStripMenuItem"
        Me.SolicitudesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SolicitudesToolStripMenuItem.Text = "Solicitudes"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(330, 239)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 279)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirF4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirF4ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MáquinasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HojasDeVidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosTécnicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenesDeTrabajoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrabajosDeMantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DisponiblesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SolicitudesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientosRealizadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenesDeTrabajoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndicadoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

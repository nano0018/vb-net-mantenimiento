<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolicitudR
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
        Me.components = New System.ComponentModel.Container
        Dim CODIGO_DE_LA_MAQUINALabel As System.Windows.Forms.Label
        Dim NOMBRE_DE_LA_MAQUINALabel As System.Windows.Forms.Label
        Dim REFERENCIA_DE_REPUESTOLabel As System.Windows.Forms.Label
        Dim NOMBRE_DEL_REPUESTOLabel As System.Windows.Forms.Label
        Dim CANTIDADLabel As System.Windows.Forms.Label
        Dim NOMBRE_DE_QUIEN_SOLICITALabel As System.Windows.Forms.Label
        Dim FECHA_DE_SOLICITUDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SolicitudR))
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.SOLICITUD_DE_REPUESTOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.SOLICITUD_DE_REPUESTOSDataGridView = New System.Windows.Forms.DataGridView
        Me.CODIGO_DE_LA_MAQUINATextBox = New System.Windows.Forms.TextBox
        Me.NOMBRE_DE_LA_MAQUINATextBox = New System.Windows.Forms.TextBox
        Me.REFERENCIA_DE_REPUESTOTextBox = New System.Windows.Forms.TextBox
        Me.NOMBRE_DEL_REPUESTOTextBox = New System.Windows.Forms.TextBox
        Me.CANTIDADTextBox = New System.Windows.Forms.TextBox
        Me.NOMBRE_DE_QUIEN_SOLICITATextBox = New System.Windows.Forms.TextBox
        Me.FECHA_DE_SOLICITUDDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SOLICITUD_DE_REPUESTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BASE_DE_DATOSDataSet = New Mantenimiento.BASE_DE_DATOSDataSet
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SOLICITUD_DE_REPUESTOSTableAdapter = New Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.SOLICITUD_DE_REPUESTOSTableAdapter
        Me.TableAdapterManager = New Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CODIGO_DE_LA_MAQUINALabel = New System.Windows.Forms.Label
        NOMBRE_DE_LA_MAQUINALabel = New System.Windows.Forms.Label
        REFERENCIA_DE_REPUESTOLabel = New System.Windows.Forms.Label
        NOMBRE_DEL_REPUESTOLabel = New System.Windows.Forms.Label
        CANTIDADLabel = New System.Windows.Forms.Label
        NOMBRE_DE_QUIEN_SOLICITALabel = New System.Windows.Forms.Label
        FECHA_DE_SOLICITUDLabel = New System.Windows.Forms.Label
        CType(Me.SOLICITUD_DE_REPUESTOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.SuspendLayout()
        CType(Me.SOLICITUD_DE_REPUESTOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SOLICITUD_DE_REPUESTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BASE_DE_DATOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CODIGO_DE_LA_MAQUINALabel
        '
        CODIGO_DE_LA_MAQUINALabel.AutoSize = True
        CODIGO_DE_LA_MAQUINALabel.Location = New System.Drawing.Point(12, 14)
        CODIGO_DE_LA_MAQUINALabel.Name = "CODIGO_DE_LA_MAQUINALabel"
        CODIGO_DE_LA_MAQUINALabel.Size = New System.Drawing.Size(139, 13)
        CODIGO_DE_LA_MAQUINALabel.TabIndex = 2
        CODIGO_DE_LA_MAQUINALabel.Text = "CODIGO DE LA MAQUINA:"
        '
        'NOMBRE_DE_LA_MAQUINALabel
        '
        NOMBRE_DE_LA_MAQUINALabel.AutoSize = True
        NOMBRE_DE_LA_MAQUINALabel.Location = New System.Drawing.Point(12, 40)
        NOMBRE_DE_LA_MAQUINALabel.Name = "NOMBRE_DE_LA_MAQUINALabel"
        NOMBRE_DE_LA_MAQUINALabel.Size = New System.Drawing.Size(144, 13)
        NOMBRE_DE_LA_MAQUINALabel.TabIndex = 4
        NOMBRE_DE_LA_MAQUINALabel.Text = "NOMBRE DE LA MAQUINA:"
        '
        'REFERENCIA_DE_REPUESTOLabel
        '
        REFERENCIA_DE_REPUESTOLabel.AutoSize = True
        REFERENCIA_DE_REPUESTOLabel.Location = New System.Drawing.Point(12, 66)
        REFERENCIA_DE_REPUESTOLabel.Name = "REFERENCIA_DE_REPUESTOLabel"
        REFERENCIA_DE_REPUESTOLabel.Size = New System.Drawing.Size(158, 13)
        REFERENCIA_DE_REPUESTOLabel.TabIndex = 6
        REFERENCIA_DE_REPUESTOLabel.Text = "REFERENCIA DE REPUESTO:"
        '
        'NOMBRE_DEL_REPUESTOLabel
        '
        NOMBRE_DEL_REPUESTOLabel.AutoSize = True
        NOMBRE_DEL_REPUESTOLabel.Location = New System.Drawing.Point(12, 92)
        NOMBRE_DEL_REPUESTOLabel.Name = "NOMBRE_DEL_REPUESTOLabel"
        NOMBRE_DEL_REPUESTOLabel.Size = New System.Drawing.Size(143, 13)
        NOMBRE_DEL_REPUESTOLabel.TabIndex = 8
        NOMBRE_DEL_REPUESTOLabel.Text = "NOMBRE DEL REPUESTO:"
        '
        'CANTIDADLabel
        '
        CANTIDADLabel.AutoSize = True
        CANTIDADLabel.Location = New System.Drawing.Point(12, 118)
        CANTIDADLabel.Name = "CANTIDADLabel"
        CANTIDADLabel.Size = New System.Drawing.Size(65, 13)
        CANTIDADLabel.TabIndex = 10
        CANTIDADLabel.Text = "CANTIDAD:"
        '
        'NOMBRE_DE_QUIEN_SOLICITALabel
        '
        NOMBRE_DE_QUIEN_SOLICITALabel.AutoSize = True
        NOMBRE_DE_QUIEN_SOLICITALabel.Location = New System.Drawing.Point(12, 144)
        NOMBRE_DE_QUIEN_SOLICITALabel.Name = "NOMBRE_DE_QUIEN_SOLICITALabel"
        NOMBRE_DE_QUIEN_SOLICITALabel.Size = New System.Drawing.Size(163, 13)
        NOMBRE_DE_QUIEN_SOLICITALabel.TabIndex = 12
        NOMBRE_DE_QUIEN_SOLICITALabel.Text = "NOMBRE DE QUIEN SOLICITA:"
        '
        'FECHA_DE_SOLICITUDLabel
        '
        FECHA_DE_SOLICITUDLabel.AutoSize = True
        FECHA_DE_SOLICITUDLabel.Location = New System.Drawing.Point(12, 171)
        FECHA_DE_SOLICITUDLabel.Name = "FECHA_DE_SOLICITUDLabel"
        FECHA_DE_SOLICITUDLabel.Size = New System.Drawing.Size(123, 13)
        FECHA_DE_SOLICITUDLabel.TabIndex = 14
        FECHA_DE_SOLICITUDLabel.Text = "FECHA DE SOLICITUD:"
        '
        'SOLICITUD_DE_REPUESTOSBindingNavigator
        '
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.BindingSource = Me.SOLICITUD_DE_REPUESTOSBindingSource
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SOLICITUD_DE_REPUESTOSBindingNavigatorSaveItem})
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.Name = "SOLICITUD_DE_REPUESTOSBindingNavigator"
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.Size = New System.Drawing.Size(672, 25)
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.TabIndex = 0
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SOLICITUD_DE_REPUESTOSBindingNavigatorSaveItem
        '
        Me.SOLICITUD_DE_REPUESTOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SOLICITUD_DE_REPUESTOSBindingNavigatorSaveItem.Image = CType(resources.GetObject("SOLICITUD_DE_REPUESTOSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SOLICITUD_DE_REPUESTOSBindingNavigatorSaveItem.Name = "SOLICITUD_DE_REPUESTOSBindingNavigatorSaveItem"
        Me.SOLICITUD_DE_REPUESTOSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SOLICITUD_DE_REPUESTOSBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'SOLICITUD_DE_REPUESTOSDataGridView
        '
        Me.SOLICITUD_DE_REPUESTOSDataGridView.AutoGenerateColumns = False
        Me.SOLICITUD_DE_REPUESTOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SOLICITUD_DE_REPUESTOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.SOLICITUD_DE_REPUESTOSDataGridView.DataSource = Me.SOLICITUD_DE_REPUESTOSBindingSource
        Me.SOLICITUD_DE_REPUESTOSDataGridView.Location = New System.Drawing.Point(12, 50)
        Me.SOLICITUD_DE_REPUESTOSDataGridView.Name = "SOLICITUD_DE_REPUESTOSDataGridView"
        Me.SOLICITUD_DE_REPUESTOSDataGridView.Size = New System.Drawing.Size(640, 220)
        Me.SOLICITUD_DE_REPUESTOSDataGridView.TabIndex = 1
        '
        'CODIGO_DE_LA_MAQUINATextBox
        '
        Me.CODIGO_DE_LA_MAQUINATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLICITUD_DE_REPUESTOSBindingSource, "CODIGO DE LA MAQUINA", True))
        Me.CODIGO_DE_LA_MAQUINATextBox.Location = New System.Drawing.Point(181, 11)
        Me.CODIGO_DE_LA_MAQUINATextBox.Name = "CODIGO_DE_LA_MAQUINATextBox"
        Me.CODIGO_DE_LA_MAQUINATextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_DE_LA_MAQUINATextBox.TabIndex = 3
        '
        'NOMBRE_DE_LA_MAQUINATextBox
        '
        Me.NOMBRE_DE_LA_MAQUINATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLICITUD_DE_REPUESTOSBindingSource, "NOMBRE DE LA MAQUINA", True))
        Me.NOMBRE_DE_LA_MAQUINATextBox.Location = New System.Drawing.Point(181, 37)
        Me.NOMBRE_DE_LA_MAQUINATextBox.Name = "NOMBRE_DE_LA_MAQUINATextBox"
        Me.NOMBRE_DE_LA_MAQUINATextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_DE_LA_MAQUINATextBox.TabIndex = 5
        '
        'REFERENCIA_DE_REPUESTOTextBox
        '
        Me.REFERENCIA_DE_REPUESTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLICITUD_DE_REPUESTOSBindingSource, "REFERENCIA DE REPUESTO", True))
        Me.REFERENCIA_DE_REPUESTOTextBox.Location = New System.Drawing.Point(181, 63)
        Me.REFERENCIA_DE_REPUESTOTextBox.Name = "REFERENCIA_DE_REPUESTOTextBox"
        Me.REFERENCIA_DE_REPUESTOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.REFERENCIA_DE_REPUESTOTextBox.TabIndex = 7
        '
        'NOMBRE_DEL_REPUESTOTextBox
        '
        Me.NOMBRE_DEL_REPUESTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLICITUD_DE_REPUESTOSBindingSource, "NOMBRE DEL REPUESTO", True))
        Me.NOMBRE_DEL_REPUESTOTextBox.Location = New System.Drawing.Point(181, 89)
        Me.NOMBRE_DEL_REPUESTOTextBox.Name = "NOMBRE_DEL_REPUESTOTextBox"
        Me.NOMBRE_DEL_REPUESTOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_DEL_REPUESTOTextBox.TabIndex = 9
        '
        'CANTIDADTextBox
        '
        Me.CANTIDADTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLICITUD_DE_REPUESTOSBindingSource, "CANTIDAD", True))
        Me.CANTIDADTextBox.Location = New System.Drawing.Point(181, 115)
        Me.CANTIDADTextBox.Name = "CANTIDADTextBox"
        Me.CANTIDADTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CANTIDADTextBox.TabIndex = 11
        '
        'NOMBRE_DE_QUIEN_SOLICITATextBox
        '
        Me.NOMBRE_DE_QUIEN_SOLICITATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLICITUD_DE_REPUESTOSBindingSource, "NOMBRE DE QUIEN SOLICITA", True))
        Me.NOMBRE_DE_QUIEN_SOLICITATextBox.Location = New System.Drawing.Point(181, 141)
        Me.NOMBRE_DE_QUIEN_SOLICITATextBox.Name = "NOMBRE_DE_QUIEN_SOLICITATextBox"
        Me.NOMBRE_DE_QUIEN_SOLICITATextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_DE_QUIEN_SOLICITATextBox.TabIndex = 13
        '
        'FECHA_DE_SOLICITUDDateTimePicker
        '
        Me.FECHA_DE_SOLICITUDDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SOLICITUD_DE_REPUESTOSBindingSource, "FECHA DE SOLICITUD", True))
        Me.FECHA_DE_SOLICITUDDateTimePicker.Location = New System.Drawing.Point(181, 167)
        Me.FECHA_DE_SOLICITUDDateTimePicker.Name = "FECHA_DE_SOLICITUDDateTimePicker"
        Me.FECHA_DE_SOLICITUDDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_DE_SOLICITUDDateTimePicker.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CODIGO_DE_LA_MAQUINALabel)
        Me.GroupBox1.Controls.Add(Me.CODIGO_DE_LA_MAQUINATextBox)
        Me.GroupBox1.Controls.Add(NOMBRE_DE_LA_MAQUINALabel)
        Me.GroupBox1.Controls.Add(Me.NOMBRE_DE_LA_MAQUINATextBox)
        Me.GroupBox1.Controls.Add(REFERENCIA_DE_REPUESTOLabel)
        Me.GroupBox1.Controls.Add(Me.REFERENCIA_DE_REPUESTOTextBox)
        Me.GroupBox1.Controls.Add(NOMBRE_DEL_REPUESTOLabel)
        Me.GroupBox1.Controls.Add(Me.NOMBRE_DEL_REPUESTOTextBox)
        Me.GroupBox1.Controls.Add(CANTIDADLabel)
        Me.GroupBox1.Controls.Add(Me.CANTIDADTextBox)
        Me.GroupBox1.Controls.Add(NOMBRE_DE_QUIEN_SOLICITALabel)
        Me.GroupBox1.Controls.Add(Me.NOMBRE_DE_QUIEN_SOLICITATextBox)
        Me.GroupBox1.Controls.Add(FECHA_DE_SOLICITUDLabel)
        Me.GroupBox1.Controls.Add(Me.FECHA_DE_SOLICITUDDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 198)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(466, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 53)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Limpiar datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SOLICITUD_DE_REPUESTOSBindingSource
        '
        Me.SOLICITUD_DE_REPUESTOSBindingSource.DataMember = "SOLICITUD DE REPUESTOS"
        Me.SOLICITUD_DE_REPUESTOSBindingSource.DataSource = Me.BASE_DE_DATOSDataSet
        '
        'BASE_DE_DATOSDataSet
        '
        Me.BASE_DE_DATOSDataSet.DataSetName = "BASE_DE_DATOSDataSet"
        Me.BASE_DE_DATOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CODIGO DE LA MAQUINA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CODIGO DE LA MAQUINA"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE DE LA MAQUINA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE DE LA MAQUINA"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "REFERENCIA DE REPUESTO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "REFERENCIA DE REPUESTO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NOMBRE DEL REPUESTO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NOMBRE DEL REPUESTO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CANTIDAD"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CANTIDAD"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NOMBRE DE QUIEN SOLICITA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NOMBRE DE QUIEN SOLICITA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FECHA DE SOLICITUD"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FECHA DE SOLICITUD"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'SOLICITUD_DE_REPUESTOSTableAdapter
        '
        Me.SOLICITUD_DE_REPUESTOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINATableAdapter = Nothing
        Me.TableAdapterManager.HOJA_DE_VIDA_DE_LA_MAQUINATableAdapter = Nothing
        Me.TableAdapterManager.ORDEN_DE_TRABAJOTableAdapter = Nothing
        Me.TableAdapterManager.REGISTRO_DE_MANTENIMIENTOTableAdapter = Nothing
        Me.TableAdapterManager.REPUESTOS_DISPONIBLESTableAdapter = Nothing
        Me.TableAdapterManager.SOLICITUD_DE_REPUESTOSTableAdapter = Me.SOLICITUD_DE_REPUESTOSTableAdapter
        Me.TableAdapterManager.UpdateOrder = Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(672, 24)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'SolicitudR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 499)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SOLICITUD_DE_REPUESTOSDataGridView)
        Me.Controls.Add(Me.SOLICITUD_DE_REPUESTOSBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SolicitudR"
        Me.Text = "SolicitudR"
        CType(Me.SOLICITUD_DE_REPUESTOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.ResumeLayout(False)
        Me.SOLICITUD_DE_REPUESTOSBindingNavigator.PerformLayout()
        CType(Me.SOLICITUD_DE_REPUESTOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SOLICITUD_DE_REPUESTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BASE_DE_DATOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BASE_DE_DATOSDataSet As Mantenimiento.BASE_DE_DATOSDataSet
    Friend WithEvents SOLICITUD_DE_REPUESTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SOLICITUD_DE_REPUESTOSTableAdapter As Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.SOLICITUD_DE_REPUESTOSTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SOLICITUD_DE_REPUESTOSBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SOLICITUD_DE_REPUESTOSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SOLICITUD_DE_REPUESTOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGO_DE_LA_MAQUINATextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_DE_LA_MAQUINATextBox As System.Windows.Forms.TextBox
    Friend WithEvents REFERENCIA_DE_REPUESTOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_DEL_REPUESTOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CANTIDADTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_DE_QUIEN_SOLICITATextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_DE_SOLICITUDDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

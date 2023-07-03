<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ordenes
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
        Dim TIPO_DE_MANTENIMIENTOLabel As System.Windows.Forms.Label
        Dim N__ORDEN_DE_TRABAJOLabel As System.Windows.Forms.Label
        Dim FECHA_DE_LA_ORDEN_DE_MANTENIMIENTOLabel As System.Windows.Forms.Label
        Dim FECHA_DEL_MANTENIMIENTOLabel As System.Windows.Forms.Label
        Dim TRABAJO_A_REALIZARLabel As System.Windows.Forms.Label
        Dim MOTIVOLabel As System.Windows.Forms.Label
        Dim ORDENALabel As System.Windows.Forms.Label
        Dim COLABORADORLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ordenes))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BASE_DE_DATOSDataSet = New Mantenimiento.BASE_DE_DATOSDataSet
        Me.REGISTRO_DE_MANTENIMIENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REGISTRO_DE_MANTENIMIENTOTableAdapter = New Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.REGISTRO_DE_MANTENIMIENTOTableAdapter
        Me.TableAdapterManager = New Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager
        Me.ORDEN_DE_TRABAJOTableAdapter = New Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.ORDEN_DE_TRABAJOTableAdapter
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ORDEN_DE_TRABAJOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDEN_DE_TRABAJODataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CODIGO_DE_LA_MAQUINATextBox = New System.Windows.Forms.TextBox
        Me.NOMBRE_DE_LA_MAQUINATextBox = New System.Windows.Forms.TextBox
        Me.TIPO_DE_MANTENIMIENTOTextBox = New System.Windows.Forms.TextBox
        Me.N__ORDEN_DE_TRABAJOTextBox = New System.Windows.Forms.TextBox
        Me.FECHA_DE_LA_ORDEN_DE_MANTENIMIENTODateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.FECHA_DEL_MANTENIMIENTODateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.TRABAJO_A_REALIZARTextBox = New System.Windows.Forms.TextBox
        Me.MOTIVOTextBox = New System.Windows.Forms.TextBox
        Me.ORDENATextBox = New System.Windows.Forms.TextBox
        Me.COLABORADORTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        CODIGO_DE_LA_MAQUINALabel = New System.Windows.Forms.Label
        NOMBRE_DE_LA_MAQUINALabel = New System.Windows.Forms.Label
        TIPO_DE_MANTENIMIENTOLabel = New System.Windows.Forms.Label
        N__ORDEN_DE_TRABAJOLabel = New System.Windows.Forms.Label
        FECHA_DE_LA_ORDEN_DE_MANTENIMIENTOLabel = New System.Windows.Forms.Label
        FECHA_DEL_MANTENIMIENTOLabel = New System.Windows.Forms.Label
        TRABAJO_A_REALIZARLabel = New System.Windows.Forms.Label
        MOTIVOLabel = New System.Windows.Forms.Label
        ORDENALabel = New System.Windows.Forms.Label
        COLABORADORLabel = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BASE_DE_DATOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGISTRO_DE_MANTENIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.SuspendLayout()
        CType(Me.ORDEN_DE_TRABAJOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDEN_DE_TRABAJODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CODIGO_DE_LA_MAQUINALabel
        '
        CODIGO_DE_LA_MAQUINALabel.AutoSize = True
        CODIGO_DE_LA_MAQUINALabel.Location = New System.Drawing.Point(12, 21)
        CODIGO_DE_LA_MAQUINALabel.Name = "CODIGO_DE_LA_MAQUINALabel"
        CODIGO_DE_LA_MAQUINALabel.Size = New System.Drawing.Size(139, 13)
        CODIGO_DE_LA_MAQUINALabel.TabIndex = 4
        CODIGO_DE_LA_MAQUINALabel.Text = "CODIGO DE LA MAQUINA:"
        '
        'NOMBRE_DE_LA_MAQUINALabel
        '
        NOMBRE_DE_LA_MAQUINALabel.AutoSize = True
        NOMBRE_DE_LA_MAQUINALabel.Location = New System.Drawing.Point(12, 47)
        NOMBRE_DE_LA_MAQUINALabel.Name = "NOMBRE_DE_LA_MAQUINALabel"
        NOMBRE_DE_LA_MAQUINALabel.Size = New System.Drawing.Size(144, 13)
        NOMBRE_DE_LA_MAQUINALabel.TabIndex = 6
        NOMBRE_DE_LA_MAQUINALabel.Text = "NOMBRE DE LA MAQUINA:"
        '
        'TIPO_DE_MANTENIMIENTOLabel
        '
        TIPO_DE_MANTENIMIENTOLabel.AutoSize = True
        TIPO_DE_MANTENIMIENTOLabel.Location = New System.Drawing.Point(12, 73)
        TIPO_DE_MANTENIMIENTOLabel.Name = "TIPO_DE_MANTENIMIENTOLabel"
        TIPO_DE_MANTENIMIENTOLabel.Size = New System.Drawing.Size(147, 13)
        TIPO_DE_MANTENIMIENTOLabel.TabIndex = 8
        TIPO_DE_MANTENIMIENTOLabel.Text = "TIPO DE MANTENIMIENTO:"
        '
        'N__ORDEN_DE_TRABAJOLabel
        '
        N__ORDEN_DE_TRABAJOLabel.AutoSize = True
        N__ORDEN_DE_TRABAJOLabel.Location = New System.Drawing.Point(12, 99)
        N__ORDEN_DE_TRABAJOLabel.Name = "N__ORDEN_DE_TRABAJOLabel"
        N__ORDEN_DE_TRABAJOLabel.Size = New System.Drawing.Size(134, 13)
        N__ORDEN_DE_TRABAJOLabel.TabIndex = 10
        N__ORDEN_DE_TRABAJOLabel.Text = "N° ORDEN DE TRABAJO:"
        '
        'FECHA_DE_LA_ORDEN_DE_MANTENIMIENTOLabel
        '
        FECHA_DE_LA_ORDEN_DE_MANTENIMIENTOLabel.AutoSize = True
        FECHA_DE_LA_ORDEN_DE_MANTENIMIENTOLabel.Location = New System.Drawing.Point(12, 126)
        FECHA_DE_LA_ORDEN_DE_MANTENIMIENTOLabel.Name = "FECHA_DE_LA_ORDEN_DE_MANTENIMIENTOLabel"
        FECHA_DE_LA_ORDEN_DE_MANTENIMIENTOLabel.Size = New System.Drawing.Size(233, 13)
        FECHA_DE_LA_ORDEN_DE_MANTENIMIENTOLabel.TabIndex = 12
        FECHA_DE_LA_ORDEN_DE_MANTENIMIENTOLabel.Text = "FECHA DE LA ORDEN DE MANTENIMIENTO:"
        '
        'FECHA_DEL_MANTENIMIENTOLabel
        '
        FECHA_DEL_MANTENIMIENTOLabel.AutoSize = True
        FECHA_DEL_MANTENIMIENTOLabel.Location = New System.Drawing.Point(12, 152)
        FECHA_DEL_MANTENIMIENTOLabel.Name = "FECHA_DEL_MANTENIMIENTOLabel"
        FECHA_DEL_MANTENIMIENTOLabel.Size = New System.Drawing.Size(163, 13)
        FECHA_DEL_MANTENIMIENTOLabel.TabIndex = 14
        FECHA_DEL_MANTENIMIENTOLabel.Text = "FECHA DEL MANTENIMIENTO:"
        '
        'TRABAJO_A_REALIZARLabel
        '
        TRABAJO_A_REALIZARLabel.AutoSize = True
        TRABAJO_A_REALIZARLabel.Location = New System.Drawing.Point(12, 177)
        TRABAJO_A_REALIZARLabel.Name = "TRABAJO_A_REALIZARLabel"
        TRABAJO_A_REALIZARLabel.Size = New System.Drawing.Size(125, 13)
        TRABAJO_A_REALIZARLabel.TabIndex = 16
        TRABAJO_A_REALIZARLabel.Text = "TRABAJO A REALIZAR:"
        '
        'MOTIVOLabel
        '
        MOTIVOLabel.AutoSize = True
        MOTIVOLabel.Location = New System.Drawing.Point(12, 203)
        MOTIVOLabel.Name = "MOTIVOLabel"
        MOTIVOLabel.Size = New System.Drawing.Size(52, 13)
        MOTIVOLabel.TabIndex = 18
        MOTIVOLabel.Text = "MOTIVO:"
        '
        'ORDENALabel
        '
        ORDENALabel.AutoSize = True
        ORDENALabel.Location = New System.Drawing.Point(12, 229)
        ORDENALabel.Name = "ORDENALabel"
        ORDENALabel.Size = New System.Drawing.Size(56, 13)
        ORDENALabel.TabIndex = 20
        ORDENALabel.Text = "ORDENA:"
        '
        'COLABORADORLabel
        '
        COLABORADORLabel.AutoSize = True
        COLABORADORLabel.Location = New System.Drawing.Point(12, 255)
        COLABORADORLabel.Name = "COLABORADORLabel"
        COLABORADORLabel.Size = New System.Drawing.Size(92, 13)
        COLABORADORLabel.TabIndex = 22
        COLABORADORLabel.Text = "COLABORADOR:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(664, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'BASE_DE_DATOSDataSet
        '
        Me.BASE_DE_DATOSDataSet.DataSetName = "BASE_DE_DATOSDataSet"
        Me.BASE_DE_DATOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'REGISTRO_DE_MANTENIMIENTOBindingSource
        '
        Me.REGISTRO_DE_MANTENIMIENTOBindingSource.DataMember = "REGISTRO DE MANTENIMIENTO"
        Me.REGISTRO_DE_MANTENIMIENTOBindingSource.DataSource = Me.BASE_DE_DATOSDataSet
        '
        'REGISTRO_DE_MANTENIMIENTOTableAdapter
        '
        Me.REGISTRO_DE_MANTENIMIENTOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINATableAdapter = Nothing
        Me.TableAdapterManager.HOJA_DE_VIDA_DE_LA_MAQUINATableAdapter = Nothing
        Me.TableAdapterManager.ORDEN_DE_TRABAJOTableAdapter = Me.ORDEN_DE_TRABAJOTableAdapter
        Me.TableAdapterManager.REGISTRO_DE_MANTENIMIENTOTableAdapter = Me.REGISTRO_DE_MANTENIMIENTOTableAdapter
        Me.TableAdapterManager.REPUESTOS_DISPONIBLESTableAdapter = Nothing
        Me.TableAdapterManager.SOLICITUD_DE_REPUESTOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ORDEN_DE_TRABAJOTableAdapter
        '
        Me.ORDEN_DE_TRABAJOTableAdapter.ClearBeforeFill = True
        '
        'REGISTRO_DE_MANTENIMIENTOBindingNavigator
        '
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.BindingSource = Me.REGISTRO_DE_MANTENIMIENTOBindingSource
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem})
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.Name = "REGISTRO_DE_MANTENIMIENTOBindingNavigator"
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.Size = New System.Drawing.Size(664, 25)
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.TabIndex = 1
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.Text = "BindingNavigator1"
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
        'REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem
        '
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem.Image = CType(resources.GetObject("REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem.Name = "REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem"
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ORDEN_DE_TRABAJOBindingSource
        '
        Me.ORDEN_DE_TRABAJOBindingSource.DataMember = "ORDEN DE TRABAJO"
        Me.ORDEN_DE_TRABAJOBindingSource.DataSource = Me.BASE_DE_DATOSDataSet
        '
        'ORDEN_DE_TRABAJODataGridView
        '
        Me.ORDEN_DE_TRABAJODataGridView.AutoGenerateColumns = False
        Me.ORDEN_DE_TRABAJODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ORDEN_DE_TRABAJODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.ORDEN_DE_TRABAJODataGridView.DataSource = Me.ORDEN_DE_TRABAJOBindingSource
        Me.ORDEN_DE_TRABAJODataGridView.Location = New System.Drawing.Point(12, 52)
        Me.ORDEN_DE_TRABAJODataGridView.Name = "ORDEN_DE_TRABAJODataGridView"
        Me.ORDEN_DE_TRABAJODataGridView.Size = New System.Drawing.Size(640, 188)
        Me.ORDEN_DE_TRABAJODataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CODIGO DE LA MAQUINA"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CODIGO DE LA MAQUINA"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NOMBRE DE LA MAQUINA"
        Me.DataGridViewTextBoxColumn10.HeaderText = "NOMBRE DE LA MAQUINA"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TIPO DE MANTENIMIENTO"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TIPO DE MANTENIMIENTO"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "N° ORDEN DE TRABAJO"
        Me.DataGridViewTextBoxColumn12.HeaderText = "N° ORDEN DE TRABAJO"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FECHA DE LA ORDEN DE MANTENIMIENTO"
        Me.DataGridViewTextBoxColumn13.HeaderText = "FECHA DE LA ORDEN DE MANTENIMIENTO"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FECHA DEL MANTENIMIENTO"
        Me.DataGridViewTextBoxColumn14.HeaderText = "FECHA DEL MANTENIMIENTO"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "TRABAJO A REALIZAR"
        Me.DataGridViewTextBoxColumn15.HeaderText = "TRABAJO A REALIZAR"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "MOTIVO"
        Me.DataGridViewTextBoxColumn16.HeaderText = "MOTIVO"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ORDENA"
        Me.DataGridViewTextBoxColumn17.HeaderText = "ORDENA"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "COLABORADOR"
        Me.DataGridViewTextBoxColumn18.HeaderText = "COLABORADOR"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'CODIGO_DE_LA_MAQUINATextBox
        '
        Me.CODIGO_DE_LA_MAQUINATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDEN_DE_TRABAJOBindingSource, "CODIGO DE LA MAQUINA", True))
        Me.CODIGO_DE_LA_MAQUINATextBox.Location = New System.Drawing.Point(251, 18)
        Me.CODIGO_DE_LA_MAQUINATextBox.Name = "CODIGO_DE_LA_MAQUINATextBox"
        Me.CODIGO_DE_LA_MAQUINATextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_DE_LA_MAQUINATextBox.TabIndex = 5
        '
        'NOMBRE_DE_LA_MAQUINATextBox
        '
        Me.NOMBRE_DE_LA_MAQUINATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDEN_DE_TRABAJOBindingSource, "NOMBRE DE LA MAQUINA", True))
        Me.NOMBRE_DE_LA_MAQUINATextBox.Location = New System.Drawing.Point(251, 44)
        Me.NOMBRE_DE_LA_MAQUINATextBox.Name = "NOMBRE_DE_LA_MAQUINATextBox"
        Me.NOMBRE_DE_LA_MAQUINATextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_DE_LA_MAQUINATextBox.TabIndex = 7
        '
        'TIPO_DE_MANTENIMIENTOTextBox
        '
        Me.TIPO_DE_MANTENIMIENTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDEN_DE_TRABAJOBindingSource, "TIPO DE MANTENIMIENTO", True))
        Me.TIPO_DE_MANTENIMIENTOTextBox.Location = New System.Drawing.Point(251, 70)
        Me.TIPO_DE_MANTENIMIENTOTextBox.Name = "TIPO_DE_MANTENIMIENTOTextBox"
        Me.TIPO_DE_MANTENIMIENTOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TIPO_DE_MANTENIMIENTOTextBox.TabIndex = 9
        '
        'N__ORDEN_DE_TRABAJOTextBox
        '
        Me.N__ORDEN_DE_TRABAJOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDEN_DE_TRABAJOBindingSource, "N° ORDEN DE TRABAJO", True))
        Me.N__ORDEN_DE_TRABAJOTextBox.Location = New System.Drawing.Point(251, 96)
        Me.N__ORDEN_DE_TRABAJOTextBox.Name = "N__ORDEN_DE_TRABAJOTextBox"
        Me.N__ORDEN_DE_TRABAJOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.N__ORDEN_DE_TRABAJOTextBox.TabIndex = 11
        '
        'FECHA_DE_LA_ORDEN_DE_MANTENIMIENTODateTimePicker
        '
        Me.FECHA_DE_LA_ORDEN_DE_MANTENIMIENTODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ORDEN_DE_TRABAJOBindingSource, "FECHA DE LA ORDEN DE MANTENIMIENTO", True))
        Me.FECHA_DE_LA_ORDEN_DE_MANTENIMIENTODateTimePicker.Location = New System.Drawing.Point(251, 122)
        Me.FECHA_DE_LA_ORDEN_DE_MANTENIMIENTODateTimePicker.Name = "FECHA_DE_LA_ORDEN_DE_MANTENIMIENTODateTimePicker"
        Me.FECHA_DE_LA_ORDEN_DE_MANTENIMIENTODateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_DE_LA_ORDEN_DE_MANTENIMIENTODateTimePicker.TabIndex = 13
        '
        'FECHA_DEL_MANTENIMIENTODateTimePicker
        '
        Me.FECHA_DEL_MANTENIMIENTODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ORDEN_DE_TRABAJOBindingSource, "FECHA DEL MANTENIMIENTO", True))
        Me.FECHA_DEL_MANTENIMIENTODateTimePicker.Location = New System.Drawing.Point(251, 148)
        Me.FECHA_DEL_MANTENIMIENTODateTimePicker.Name = "FECHA_DEL_MANTENIMIENTODateTimePicker"
        Me.FECHA_DEL_MANTENIMIENTODateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_DEL_MANTENIMIENTODateTimePicker.TabIndex = 15
        '
        'TRABAJO_A_REALIZARTextBox
        '
        Me.TRABAJO_A_REALIZARTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDEN_DE_TRABAJOBindingSource, "TRABAJO A REALIZAR", True))
        Me.TRABAJO_A_REALIZARTextBox.Location = New System.Drawing.Point(251, 174)
        Me.TRABAJO_A_REALIZARTextBox.Name = "TRABAJO_A_REALIZARTextBox"
        Me.TRABAJO_A_REALIZARTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TRABAJO_A_REALIZARTextBox.TabIndex = 17
        '
        'MOTIVOTextBox
        '
        Me.MOTIVOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDEN_DE_TRABAJOBindingSource, "MOTIVO", True))
        Me.MOTIVOTextBox.Location = New System.Drawing.Point(251, 200)
        Me.MOTIVOTextBox.Name = "MOTIVOTextBox"
        Me.MOTIVOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MOTIVOTextBox.TabIndex = 19
        '
        'ORDENATextBox
        '
        Me.ORDENATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDEN_DE_TRABAJOBindingSource, "ORDENA", True))
        Me.ORDENATextBox.Location = New System.Drawing.Point(251, 226)
        Me.ORDENATextBox.Name = "ORDENATextBox"
        Me.ORDENATextBox.Size = New System.Drawing.Size(200, 20)
        Me.ORDENATextBox.TabIndex = 21
        '
        'COLABORADORTextBox
        '
        Me.COLABORADORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDEN_DE_TRABAJOBindingSource, "COLABORADOR", True))
        Me.COLABORADORTextBox.Location = New System.Drawing.Point(251, 252)
        Me.COLABORADORTextBox.Name = "COLABORADORTextBox"
        Me.COLABORADORTextBox.Size = New System.Drawing.Size(200, 20)
        Me.COLABORADORTextBox.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CODIGO_DE_LA_MAQUINALabel)
        Me.GroupBox1.Controls.Add(Me.CODIGO_DE_LA_MAQUINATextBox)
        Me.GroupBox1.Controls.Add(NOMBRE_DE_LA_MAQUINALabel)
        Me.GroupBox1.Controls.Add(Me.NOMBRE_DE_LA_MAQUINATextBox)
        Me.GroupBox1.Controls.Add(TIPO_DE_MANTENIMIENTOLabel)
        Me.GroupBox1.Controls.Add(Me.TIPO_DE_MANTENIMIENTOTextBox)
        Me.GroupBox1.Controls.Add(N__ORDEN_DE_TRABAJOLabel)
        Me.GroupBox1.Controls.Add(Me.N__ORDEN_DE_TRABAJOTextBox)
        Me.GroupBox1.Controls.Add(FECHA_DE_LA_ORDEN_DE_MANTENIMIENTOLabel)
        Me.GroupBox1.Controls.Add(Me.FECHA_DE_LA_ORDEN_DE_MANTENIMIENTODateTimePicker)
        Me.GroupBox1.Controls.Add(FECHA_DEL_MANTENIMIENTOLabel)
        Me.GroupBox1.Controls.Add(Me.FECHA_DEL_MANTENIMIENTODateTimePicker)
        Me.GroupBox1.Controls.Add(TRABAJO_A_REALIZARLabel)
        Me.GroupBox1.Controls.Add(Me.TRABAJO_A_REALIZARTextBox)
        Me.GroupBox1.Controls.Add(MOTIVOLabel)
        Me.GroupBox1.Controls.Add(Me.MOTIVOTextBox)
        Me.GroupBox1.Controls.Add(ORDENALabel)
        Me.GroupBox1.Controls.Add(Me.ORDENATextBox)
        Me.GroupBox1.Controls.Add(COLABORADORLabel)
        Me.GroupBox1.Controls.Add(Me.COLABORADORTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 263)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 285)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(507, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 53)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Limpiar datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Ordenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 555)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ORDEN_DE_TRABAJODataGridView)
        Me.Controls.Add(Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Ordenes"
        Me.Text = "Gestión de ordenes de trabajo"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BASE_DE_DATOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGISTRO_DE_MANTENIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.ResumeLayout(False)
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.PerformLayout()
        CType(Me.ORDEN_DE_TRABAJOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDEN_DE_TRABAJODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BASE_DE_DATOSDataSet As Mantenimiento.BASE_DE_DATOSDataSet
    Friend WithEvents REGISTRO_DE_MANTENIMIENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REGISTRO_DE_MANTENIMIENTOTableAdapter As Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.REGISTRO_DE_MANTENIMIENTOTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents REGISTRO_DE_MANTENIMIENTOBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ORDEN_DE_TRABAJOTableAdapter As Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.ORDEN_DE_TRABAJOTableAdapter
    Friend WithEvents ORDEN_DE_TRABAJOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ORDEN_DE_TRABAJODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGO_DE_LA_MAQUINATextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_DE_LA_MAQUINATextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIPO_DE_MANTENIMIENTOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents N__ORDEN_DE_TRABAJOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_DE_LA_ORDEN_DE_MANTENIMIENTODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FECHA_DEL_MANTENIMIENTODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TRABAJO_A_REALIZARTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MOTIVOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ORDENATextBox As System.Windows.Forms.TextBox
    Friend WithEvents COLABORADORTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

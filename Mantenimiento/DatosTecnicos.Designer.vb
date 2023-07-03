<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosTecnicos
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
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim NOMBRE_DE_LA_MAQUINALabel As System.Windows.Forms.Label
        Dim TIPO_DE_ALIMENTACION_ELECLabel As System.Windows.Forms.Label
        Dim VOLTAJE_QUE_MANEJALabel As System.Windows.Forms.Label
        Dim FECHA_INICIO_FUNCIONAMIENTOLabel As System.Windows.Forms.Label
        Dim NOTALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosTecnicos))
        Me.BASE_DE_DATOSDataSet = New Mantenimiento.BASE_DE_DATOSDataSet
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINATableAdapter = New Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINATableAdapter
        Me.TableAdapterManager = New Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINADataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CODIGOTextBox = New System.Windows.Forms.TextBox
        Me.NOMBRE_DE_LA_MAQUINATextBox = New System.Windows.Forms.TextBox
        Me.TIPO_DE_ALIMENTACION_ELECTextBox = New System.Windows.Forms.TextBox
        Me.VOLTAJE_QUE_MANEJATextBox = New System.Windows.Forms.TextBox
        Me.FECHA_INICIO_FUNCIONAMIENTODateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.NOTATextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        CODIGOLabel = New System.Windows.Forms.Label
        NOMBRE_DE_LA_MAQUINALabel = New System.Windows.Forms.Label
        TIPO_DE_ALIMENTACION_ELECLabel = New System.Windows.Forms.Label
        VOLTAJE_QUE_MANEJALabel = New System.Windows.Forms.Label
        FECHA_INICIO_FUNCIONAMIENTOLabel = New System.Windows.Forms.Label
        NOTALabel = New System.Windows.Forms.Label
        CType(Me.BASE_DE_DATOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.SuspendLayout()
        CType(Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(14, 17)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(52, 13)
        CODIGOLabel.TabIndex = 3
        CODIGOLabel.Text = "CODIGO:"
        '
        'NOMBRE_DE_LA_MAQUINALabel
        '
        NOMBRE_DE_LA_MAQUINALabel.AutoSize = True
        NOMBRE_DE_LA_MAQUINALabel.Location = New System.Drawing.Point(14, 43)
        NOMBRE_DE_LA_MAQUINALabel.Name = "NOMBRE_DE_LA_MAQUINALabel"
        NOMBRE_DE_LA_MAQUINALabel.Size = New System.Drawing.Size(144, 13)
        NOMBRE_DE_LA_MAQUINALabel.TabIndex = 5
        NOMBRE_DE_LA_MAQUINALabel.Text = "NOMBRE DE LA MAQUINA:"
        '
        'TIPO_DE_ALIMENTACION_ELECLabel
        '
        TIPO_DE_ALIMENTACION_ELECLabel.AutoSize = True
        TIPO_DE_ALIMENTACION_ELECLabel.Location = New System.Drawing.Point(14, 69)
        TIPO_DE_ALIMENTACION_ELECLabel.Name = "TIPO_DE_ALIMENTACION_ELECLabel"
        TIPO_DE_ALIMENTACION_ELECLabel.Size = New System.Drawing.Size(166, 13)
        TIPO_DE_ALIMENTACION_ELECLabel.TabIndex = 7
        TIPO_DE_ALIMENTACION_ELECLabel.Text = "TIPO DE ALIMENTACION ELEC:"
        '
        'VOLTAJE_QUE_MANEJALabel
        '
        VOLTAJE_QUE_MANEJALabel.AutoSize = True
        VOLTAJE_QUE_MANEJALabel.Location = New System.Drawing.Point(14, 95)
        VOLTAJE_QUE_MANEJALabel.Name = "VOLTAJE_QUE_MANEJALabel"
        VOLTAJE_QUE_MANEJALabel.Size = New System.Drawing.Size(129, 13)
        VOLTAJE_QUE_MANEJALabel.TabIndex = 9
        VOLTAJE_QUE_MANEJALabel.Text = "VOLTAJE QUE MANEJA:"
        '
        'FECHA_INICIO_FUNCIONAMIENTOLabel
        '
        FECHA_INICIO_FUNCIONAMIENTOLabel.AutoSize = True
        FECHA_INICIO_FUNCIONAMIENTOLabel.Location = New System.Drawing.Point(14, 122)
        FECHA_INICIO_FUNCIONAMIENTOLabel.Name = "FECHA_INICIO_FUNCIONAMIENTOLabel"
        FECHA_INICIO_FUNCIONAMIENTOLabel.Size = New System.Drawing.Size(180, 13)
        FECHA_INICIO_FUNCIONAMIENTOLabel.TabIndex = 11
        FECHA_INICIO_FUNCIONAMIENTOLabel.Text = "FECHA INICIO FUNCIONAMIENTO:"
        '
        'NOTALabel
        '
        NOTALabel.AutoSize = True
        NOTALabel.Location = New System.Drawing.Point(14, 147)
        NOTALabel.Name = "NOTALabel"
        NOTALabel.Size = New System.Drawing.Size(40, 13)
        NOTALabel.TabIndex = 13
        NOTALabel.Text = "NOTA:"
        '
        'BASE_DE_DATOSDataSet
        '
        Me.BASE_DE_DATOSDataSet.DataSetName = "BASE_DE_DATOSDataSet"
        Me.BASE_DE_DATOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource
        '
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource.DataMember = "CARACTERISTICAS TECNICAS DE LA MAQUINA"
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource.DataSource = Me.BASE_DE_DATOSDataSet
        '
        'CARACTERISTICAS_TECNICAS_DE_LA_MAQUINATableAdapter
        '
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINATableAdapter = Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINATableAdapter
        Me.TableAdapterManager.HOJA_DE_VIDA_DE_LA_MAQUINATableAdapter = Nothing
        Me.TableAdapterManager.ORDEN_DE_TRABAJOTableAdapter = Nothing
        Me.TableAdapterManager.REGISTRO_DE_MANTENIMIENTOTableAdapter = Nothing
        Me.TableAdapterManager.REPUESTOS_DISPONIBLESTableAdapter = Nothing
        Me.TableAdapterManager.SOLICITUD_DE_REPUESTOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator
        '
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.BindingSource = Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigatorSaveItem})
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.Name = "CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator"
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.Size = New System.Drawing.Size(664, 25)
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.TabIndex = 0
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.Text = "BindingNavigator1"
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
        'CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigatorSaveItem
        '
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigatorSaveItem.Image = CType(resources.GetObject("CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigatorSaveItem.Name = "CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigatorSaveItem"
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CARACTERISTICAS_TECNICAS_DE_LA_MAQUINADataGridView
        '
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINADataGridView.AutoGenerateColumns = False
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINADataGridView.DataSource = Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINADataGridView.Location = New System.Drawing.Point(12, 52)
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINADataGridView.Name = "CARACTERISTICAS_TECNICAS_DE_LA_MAQUINADataGridView"
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINADataGridView.Size = New System.Drawing.Size(640, 188)
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINADataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CODIGO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CODIGO"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TIPO DE ALIMENTACION ELEC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TIPO DE ALIMENTACION ELEC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "VOLTAJE QUE MANEJA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "VOLTAJE QUE MANEJA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FECHA INICIO FUNCIONAMIENTO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "FECHA INICIO FUNCIONAMIENTO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NOTA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NOTA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(664, 24)
        Me.MenuStrip1.TabIndex = 2
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
        'CODIGOTextBox
        '
        Me.CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource, "CODIGO", True))
        Me.CODIGOTextBox.Location = New System.Drawing.Point(200, 14)
        Me.CODIGOTextBox.Name = "CODIGOTextBox"
        Me.CODIGOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODIGOTextBox.TabIndex = 4
        '
        'NOMBRE_DE_LA_MAQUINATextBox
        '
        Me.NOMBRE_DE_LA_MAQUINATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource, "NOMBRE DE LA MAQUINA", True))
        Me.NOMBRE_DE_LA_MAQUINATextBox.Location = New System.Drawing.Point(200, 40)
        Me.NOMBRE_DE_LA_MAQUINATextBox.Name = "NOMBRE_DE_LA_MAQUINATextBox"
        Me.NOMBRE_DE_LA_MAQUINATextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_DE_LA_MAQUINATextBox.TabIndex = 6
        '
        'TIPO_DE_ALIMENTACION_ELECTextBox
        '
        Me.TIPO_DE_ALIMENTACION_ELECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource, "TIPO DE ALIMENTACION ELEC", True))
        Me.TIPO_DE_ALIMENTACION_ELECTextBox.Location = New System.Drawing.Point(200, 66)
        Me.TIPO_DE_ALIMENTACION_ELECTextBox.Name = "TIPO_DE_ALIMENTACION_ELECTextBox"
        Me.TIPO_DE_ALIMENTACION_ELECTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TIPO_DE_ALIMENTACION_ELECTextBox.TabIndex = 8
        '
        'VOLTAJE_QUE_MANEJATextBox
        '
        Me.VOLTAJE_QUE_MANEJATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource, "VOLTAJE QUE MANEJA", True))
        Me.VOLTAJE_QUE_MANEJATextBox.Location = New System.Drawing.Point(200, 92)
        Me.VOLTAJE_QUE_MANEJATextBox.Name = "VOLTAJE_QUE_MANEJATextBox"
        Me.VOLTAJE_QUE_MANEJATextBox.Size = New System.Drawing.Size(200, 20)
        Me.VOLTAJE_QUE_MANEJATextBox.TabIndex = 10
        '
        'FECHA_INICIO_FUNCIONAMIENTODateTimePicker
        '
        Me.FECHA_INICIO_FUNCIONAMIENTODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource, "FECHA INICIO FUNCIONAMIENTO", True))
        Me.FECHA_INICIO_FUNCIONAMIENTODateTimePicker.Location = New System.Drawing.Point(200, 118)
        Me.FECHA_INICIO_FUNCIONAMIENTODateTimePicker.Name = "FECHA_INICIO_FUNCIONAMIENTODateTimePicker"
        Me.FECHA_INICIO_FUNCIONAMIENTODateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_INICIO_FUNCIONAMIENTODateTimePicker.TabIndex = 12
        '
        'NOTATextBox
        '
        Me.NOTATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource, "NOTA", True))
        Me.NOTATextBox.Location = New System.Drawing.Point(200, 144)
        Me.NOTATextBox.Name = "NOTATextBox"
        Me.NOTATextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTATextBox.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CODIGOLabel)
        Me.GroupBox1.Controls.Add(Me.CODIGOTextBox)
        Me.GroupBox1.Controls.Add(NOMBRE_DE_LA_MAQUINALabel)
        Me.GroupBox1.Controls.Add(Me.NOMBRE_DE_LA_MAQUINATextBox)
        Me.GroupBox1.Controls.Add(TIPO_DE_ALIMENTACION_ELECLabel)
        Me.GroupBox1.Controls.Add(Me.TIPO_DE_ALIMENTACION_ELECTextBox)
        Me.GroupBox1.Controls.Add(VOLTAJE_QUE_MANEJALabel)
        Me.GroupBox1.Controls.Add(Me.VOLTAJE_QUE_MANEJATextBox)
        Me.GroupBox1.Controls.Add(FECHA_INICIO_FUNCIONAMIENTOLabel)
        Me.GroupBox1.Controls.Add(Me.FECHA_INICIO_FUNCIONAMIENTODateTimePicker)
        Me.GroupBox1.Controls.Add(NOTALabel)
        Me.GroupBox1.Controls.Add(Me.NOTATextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 173)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(485, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 53)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Limpiar datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DatosTecnicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 460)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINADataGridView)
        Me.Controls.Add(Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DatosTecnicos"
        Me.Text = "Datos técnicos"
        CType(Me.BASE_DE_DATOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.ResumeLayout(False)
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator.PerformLayout()
        CType(Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BASE_DE_DATOSDataSet As Mantenimiento.BASE_DE_DATOSDataSet
    Friend WithEvents CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CARACTERISTICAS_TECNICAS_DE_LA_MAQUINATableAdapter As Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINATableAdapter
    Friend WithEvents TableAdapterManager As Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CARACTERISTICAS_TECNICAS_DE_LA_MAQUINADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CODIGOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_DE_LA_MAQUINATextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIPO_DE_ALIMENTACION_ELECTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VOLTAJE_QUE_MANEJATextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_INICIO_FUNCIONAMIENTODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NOTATextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrabajosM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrabajosM))
        Dim CODIGO_DE_LA_MAQUINALabel As System.Windows.Forms.Label
        Dim NOMBRE_DE_LA_MAQUINALabel As System.Windows.Forms.Label
        Dim N__DE_ORDENLabel As System.Windows.Forms.Label
        Dim FECHA_DE_MANTENIMIENTOLabel As System.Windows.Forms.Label
        Dim TRABAJO_REALIZADOLabel As System.Windows.Forms.Label
        Dim PERSONA_QUE_REALIZA_EL_MANTENIMIENTOLabel As System.Windows.Forms.Label
        Dim TIPO_DE_MANTENIMIENTOLabel As System.Windows.Forms.Label
        Dim TIEMPO_DE_REPARACION_EN_HORASLabel As System.Windows.Forms.Label
        Dim TIEMPOLabel As System.Windows.Forms.Label
        Dim CODAPLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.BASE_DE_DATOSDataSet = New Mantenimiento.BASE_DE_DATOSDataSet
        Me.REGISTRO_DE_MANTENIMIENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REGISTRO_DE_MANTENIMIENTOTableAdapter = New Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.REGISTRO_DE_MANTENIMIENTOTableAdapter
        Me.TableAdapterManager = New Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager
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
        Me.REGISTRO_DE_MANTENIMIENTODataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CODIGO_DE_LA_MAQUINATextBox = New System.Windows.Forms.TextBox
        Me.NOMBRE_DE_LA_MAQUINATextBox = New System.Windows.Forms.TextBox
        Me.N__DE_ORDENTextBox = New System.Windows.Forms.TextBox
        Me.FECHA_DE_MANTENIMIENTODateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.TRABAJO_REALIZADOTextBox = New System.Windows.Forms.TextBox
        Me.PERSONA_QUE_REALIZA_EL_MANTENIMIENTOTextBox = New System.Windows.Forms.TextBox
        Me.TIPO_DE_MANTENIMIENTOTextBox = New System.Windows.Forms.TextBox
        Me.TIEMPO_DE_REPARACION_EN_HORASTextBox = New System.Windows.Forms.TextBox
        Me.TIEMPOTextBox = New System.Windows.Forms.TextBox
        Me.CODAPTextBox = New System.Windows.Forms.TextBox
        CODIGO_DE_LA_MAQUINALabel = New System.Windows.Forms.Label
        NOMBRE_DE_LA_MAQUINALabel = New System.Windows.Forms.Label
        N__DE_ORDENLabel = New System.Windows.Forms.Label
        FECHA_DE_MANTENIMIENTOLabel = New System.Windows.Forms.Label
        TRABAJO_REALIZADOLabel = New System.Windows.Forms.Label
        PERSONA_QUE_REALIZA_EL_MANTENIMIENTOLabel = New System.Windows.Forms.Label
        TIPO_DE_MANTENIMIENTOLabel = New System.Windows.Forms.Label
        TIEMPO_DE_REPARACION_EN_HORASLabel = New System.Windows.Forms.Label
        TIEMPOLabel = New System.Windows.Forms.Label
        CODAPLabel = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BASE_DE_DATOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGISTRO_DE_MANTENIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.SuspendLayout()
        CType(Me.REGISTRO_DE_MANTENIMIENTODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(672, 24)
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
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CODIGO_DE_LA_MAQUINALabel)
        Me.GroupBox1.Controls.Add(Me.CODIGO_DE_LA_MAQUINATextBox)
        Me.GroupBox1.Controls.Add(NOMBRE_DE_LA_MAQUINALabel)
        Me.GroupBox1.Controls.Add(Me.NOMBRE_DE_LA_MAQUINATextBox)
        Me.GroupBox1.Controls.Add(N__DE_ORDENLabel)
        Me.GroupBox1.Controls.Add(Me.N__DE_ORDENTextBox)
        Me.GroupBox1.Controls.Add(FECHA_DE_MANTENIMIENTOLabel)
        Me.GroupBox1.Controls.Add(Me.FECHA_DE_MANTENIMIENTODateTimePicker)
        Me.GroupBox1.Controls.Add(TRABAJO_REALIZADOLabel)
        Me.GroupBox1.Controls.Add(Me.TRABAJO_REALIZADOTextBox)
        Me.GroupBox1.Controls.Add(PERSONA_QUE_REALIZA_EL_MANTENIMIENTOLabel)
        Me.GroupBox1.Controls.Add(Me.PERSONA_QUE_REALIZA_EL_MANTENIMIENTOTextBox)
        Me.GroupBox1.Controls.Add(TIPO_DE_MANTENIMIENTOLabel)
        Me.GroupBox1.Controls.Add(Me.TIPO_DE_MANTENIMIENTOTextBox)
        Me.GroupBox1.Controls.Add(TIEMPO_DE_REPARACION_EN_HORASLabel)
        Me.GroupBox1.Controls.Add(Me.TIEMPO_DE_REPARACION_EN_HORASTextBox)
        Me.GroupBox1.Controls.Add(TIEMPOLabel)
        Me.GroupBox1.Controls.Add(Me.TIEMPOTextBox)
        Me.GroupBox1.Controls.Add(CODAPLabel)
        Me.GroupBox1.Controls.Add(Me.CODAPTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 277)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(519, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 53)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Limpiar datos"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.ORDEN_DE_TRABAJOTableAdapter = Nothing
        Me.TableAdapterManager.REGISTRO_DE_MANTENIMIENTOTableAdapter = Me.REGISTRO_DE_MANTENIMIENTOTableAdapter
        Me.TableAdapterManager.REPUESTOS_DISPONIBLESTableAdapter = Nothing
        Me.TableAdapterManager.SOLICITUD_DE_REPUESTOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.Size = New System.Drawing.Size(672, 25)
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.TabIndex = 27
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
        'REGISTRO_DE_MANTENIMIENTODataGridView
        '
        Me.REGISTRO_DE_MANTENIMIENTODataGridView.AutoGenerateColumns = False
        Me.REGISTRO_DE_MANTENIMIENTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.REGISTRO_DE_MANTENIMIENTODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.REGISTRO_DE_MANTENIMIENTODataGridView.DataSource = Me.REGISTRO_DE_MANTENIMIENTOBindingSource
        Me.REGISTRO_DE_MANTENIMIENTODataGridView.Location = New System.Drawing.Point(12, 52)
        Me.REGISTRO_DE_MANTENIMIENTODataGridView.Name = "REGISTRO_DE_MANTENIMIENTODataGridView"
        Me.REGISTRO_DE_MANTENIMIENTODataGridView.Size = New System.Drawing.Size(648, 186)
        Me.REGISTRO_DE_MANTENIMIENTODataGridView.TabIndex = 27
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "N° DE ORDEN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "N° DE ORDEN"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FECHA DE MANTENIMIENTO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FECHA DE MANTENIMIENTO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TRABAJO REALIZADO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TRABAJO REALIZADO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PERSONA QUE REALIZA EL MANTENIMIENTO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PERSONA QUE REALIZA EL MANTENIMIENTO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TIPO DE MANTENIMIENTO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TIPO DE MANTENIMIENTO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TIEMPO DE REPARACION EN HORAS"
        Me.DataGridViewTextBoxColumn8.HeaderText = "TIEMPO DE REPARACION EN HORAS"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TIEMPO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "TIEMPO"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CODAP"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CODAP"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'CODIGO_DE_LA_MAQUINALabel
        '
        CODIGO_DE_LA_MAQUINALabel.AutoSize = True
        CODIGO_DE_LA_MAQUINALabel.Location = New System.Drawing.Point(6, 16)
        CODIGO_DE_LA_MAQUINALabel.Name = "CODIGO_DE_LA_MAQUINALabel"
        CODIGO_DE_LA_MAQUINALabel.Size = New System.Drawing.Size(139, 13)
        CODIGO_DE_LA_MAQUINALabel.TabIndex = 0
        CODIGO_DE_LA_MAQUINALabel.Text = "CODIGO DE LA MAQUINA:"
        '
        'CODIGO_DE_LA_MAQUINATextBox
        '
        Me.CODIGO_DE_LA_MAQUINATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REGISTRO_DE_MANTENIMIENTOBindingSource, "CODIGO DE LA MAQUINA", True))
        Me.CODIGO_DE_LA_MAQUINATextBox.Location = New System.Drawing.Point(258, 13)
        Me.CODIGO_DE_LA_MAQUINATextBox.Name = "CODIGO_DE_LA_MAQUINATextBox"
        Me.CODIGO_DE_LA_MAQUINATextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_DE_LA_MAQUINATextBox.TabIndex = 1
        '
        'NOMBRE_DE_LA_MAQUINALabel
        '
        NOMBRE_DE_LA_MAQUINALabel.AutoSize = True
        NOMBRE_DE_LA_MAQUINALabel.Location = New System.Drawing.Point(6, 42)
        NOMBRE_DE_LA_MAQUINALabel.Name = "NOMBRE_DE_LA_MAQUINALabel"
        NOMBRE_DE_LA_MAQUINALabel.Size = New System.Drawing.Size(144, 13)
        NOMBRE_DE_LA_MAQUINALabel.TabIndex = 2
        NOMBRE_DE_LA_MAQUINALabel.Text = "NOMBRE DE LA MAQUINA:"
        '
        'NOMBRE_DE_LA_MAQUINATextBox
        '
        Me.NOMBRE_DE_LA_MAQUINATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REGISTRO_DE_MANTENIMIENTOBindingSource, "NOMBRE DE LA MAQUINA", True))
        Me.NOMBRE_DE_LA_MAQUINATextBox.Location = New System.Drawing.Point(258, 39)
        Me.NOMBRE_DE_LA_MAQUINATextBox.Name = "NOMBRE_DE_LA_MAQUINATextBox"
        Me.NOMBRE_DE_LA_MAQUINATextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_DE_LA_MAQUINATextBox.TabIndex = 3
        '
        'N__DE_ORDENLabel
        '
        N__DE_ORDENLabel.AutoSize = True
        N__DE_ORDENLabel.Location = New System.Drawing.Point(6, 68)
        N__DE_ORDENLabel.Name = "N__DE_ORDENLabel"
        N__DE_ORDENLabel.Size = New System.Drawing.Size(82, 13)
        N__DE_ORDENLabel.TabIndex = 4
        N__DE_ORDENLabel.Text = "N° DE ORDEN:"
        '
        'N__DE_ORDENTextBox
        '
        Me.N__DE_ORDENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REGISTRO_DE_MANTENIMIENTOBindingSource, "N° DE ORDEN", True))
        Me.N__DE_ORDENTextBox.Location = New System.Drawing.Point(258, 65)
        Me.N__DE_ORDENTextBox.Name = "N__DE_ORDENTextBox"
        Me.N__DE_ORDENTextBox.Size = New System.Drawing.Size(200, 20)
        Me.N__DE_ORDENTextBox.TabIndex = 5
        '
        'FECHA_DE_MANTENIMIENTOLabel
        '
        FECHA_DE_MANTENIMIENTOLabel.AutoSize = True
        FECHA_DE_MANTENIMIENTOLabel.Location = New System.Drawing.Point(6, 95)
        FECHA_DE_MANTENIMIENTOLabel.Name = "FECHA_DE_MANTENIMIENTOLabel"
        FECHA_DE_MANTENIMIENTOLabel.Size = New System.Drawing.Size(157, 13)
        FECHA_DE_MANTENIMIENTOLabel.TabIndex = 6
        FECHA_DE_MANTENIMIENTOLabel.Text = "FECHA DE MANTENIMIENTO:"
        '
        'FECHA_DE_MANTENIMIENTODateTimePicker
        '
        Me.FECHA_DE_MANTENIMIENTODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.REGISTRO_DE_MANTENIMIENTOBindingSource, "FECHA DE MANTENIMIENTO", True))
        Me.FECHA_DE_MANTENIMIENTODateTimePicker.Location = New System.Drawing.Point(258, 91)
        Me.FECHA_DE_MANTENIMIENTODateTimePicker.Name = "FECHA_DE_MANTENIMIENTODateTimePicker"
        Me.FECHA_DE_MANTENIMIENTODateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_DE_MANTENIMIENTODateTimePicker.TabIndex = 7
        '
        'TRABAJO_REALIZADOLabel
        '
        TRABAJO_REALIZADOLabel.AutoSize = True
        TRABAJO_REALIZADOLabel.Location = New System.Drawing.Point(6, 120)
        TRABAJO_REALIZADOLabel.Name = "TRABAJO_REALIZADOLabel"
        TRABAJO_REALIZADOLabel.Size = New System.Drawing.Size(123, 13)
        TRABAJO_REALIZADOLabel.TabIndex = 8
        TRABAJO_REALIZADOLabel.Text = "TRABAJO REALIZADO:"
        '
        'TRABAJO_REALIZADOTextBox
        '
        Me.TRABAJO_REALIZADOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REGISTRO_DE_MANTENIMIENTOBindingSource, "TRABAJO REALIZADO", True))
        Me.TRABAJO_REALIZADOTextBox.Location = New System.Drawing.Point(258, 117)
        Me.TRABAJO_REALIZADOTextBox.Name = "TRABAJO_REALIZADOTextBox"
        Me.TRABAJO_REALIZADOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TRABAJO_REALIZADOTextBox.TabIndex = 9
        '
        'PERSONA_QUE_REALIZA_EL_MANTENIMIENTOLabel
        '
        PERSONA_QUE_REALIZA_EL_MANTENIMIENTOLabel.AutoSize = True
        PERSONA_QUE_REALIZA_EL_MANTENIMIENTOLabel.Location = New System.Drawing.Point(6, 146)
        PERSONA_QUE_REALIZA_EL_MANTENIMIENTOLabel.Name = "PERSONA_QUE_REALIZA_EL_MANTENIMIENTOLabel"
        PERSONA_QUE_REALIZA_EL_MANTENIMIENTOLabel.Size = New System.Drawing.Size(246, 13)
        PERSONA_QUE_REALIZA_EL_MANTENIMIENTOLabel.TabIndex = 10
        PERSONA_QUE_REALIZA_EL_MANTENIMIENTOLabel.Text = "PERSONA QUE REALIZA EL MANTENIMIENTO:"
        '
        'PERSONA_QUE_REALIZA_EL_MANTENIMIENTOTextBox
        '
        Me.PERSONA_QUE_REALIZA_EL_MANTENIMIENTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REGISTRO_DE_MANTENIMIENTOBindingSource, "PERSONA QUE REALIZA EL MANTENIMIENTO", True))
        Me.PERSONA_QUE_REALIZA_EL_MANTENIMIENTOTextBox.Location = New System.Drawing.Point(258, 143)
        Me.PERSONA_QUE_REALIZA_EL_MANTENIMIENTOTextBox.Name = "PERSONA_QUE_REALIZA_EL_MANTENIMIENTOTextBox"
        Me.PERSONA_QUE_REALIZA_EL_MANTENIMIENTOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PERSONA_QUE_REALIZA_EL_MANTENIMIENTOTextBox.TabIndex = 11
        '
        'TIPO_DE_MANTENIMIENTOLabel
        '
        TIPO_DE_MANTENIMIENTOLabel.AutoSize = True
        TIPO_DE_MANTENIMIENTOLabel.Location = New System.Drawing.Point(6, 172)
        TIPO_DE_MANTENIMIENTOLabel.Name = "TIPO_DE_MANTENIMIENTOLabel"
        TIPO_DE_MANTENIMIENTOLabel.Size = New System.Drawing.Size(147, 13)
        TIPO_DE_MANTENIMIENTOLabel.TabIndex = 12
        TIPO_DE_MANTENIMIENTOLabel.Text = "TIPO DE MANTENIMIENTO:"
        '
        'TIPO_DE_MANTENIMIENTOTextBox
        '
        Me.TIPO_DE_MANTENIMIENTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REGISTRO_DE_MANTENIMIENTOBindingSource, "TIPO DE MANTENIMIENTO", True))
        Me.TIPO_DE_MANTENIMIENTOTextBox.Location = New System.Drawing.Point(258, 169)
        Me.TIPO_DE_MANTENIMIENTOTextBox.Name = "TIPO_DE_MANTENIMIENTOTextBox"
        Me.TIPO_DE_MANTENIMIENTOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TIPO_DE_MANTENIMIENTOTextBox.TabIndex = 13
        '
        'TIEMPO_DE_REPARACION_EN_HORASLabel
        '
        TIEMPO_DE_REPARACION_EN_HORASLabel.AutoSize = True
        TIEMPO_DE_REPARACION_EN_HORASLabel.Location = New System.Drawing.Point(6, 198)
        TIEMPO_DE_REPARACION_EN_HORASLabel.Name = "TIEMPO_DE_REPARACION_EN_HORASLabel"
        TIEMPO_DE_REPARACION_EN_HORASLabel.Size = New System.Drawing.Size(201, 13)
        TIEMPO_DE_REPARACION_EN_HORASLabel.TabIndex = 14
        TIEMPO_DE_REPARACION_EN_HORASLabel.Text = "TIEMPO DE REPARACION EN HORAS:"
        '
        'TIEMPO_DE_REPARACION_EN_HORASTextBox
        '
        Me.TIEMPO_DE_REPARACION_EN_HORASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REGISTRO_DE_MANTENIMIENTOBindingSource, "TIEMPO DE REPARACION EN HORAS", True))
        Me.TIEMPO_DE_REPARACION_EN_HORASTextBox.Location = New System.Drawing.Point(258, 195)
        Me.TIEMPO_DE_REPARACION_EN_HORASTextBox.Name = "TIEMPO_DE_REPARACION_EN_HORASTextBox"
        Me.TIEMPO_DE_REPARACION_EN_HORASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TIEMPO_DE_REPARACION_EN_HORASTextBox.TabIndex = 15
        '
        'TIEMPOLabel
        '
        TIEMPOLabel.AutoSize = True
        TIEMPOLabel.Location = New System.Drawing.Point(6, 224)
        TIEMPOLabel.Name = "TIEMPOLabel"
        TIEMPOLabel.Size = New System.Drawing.Size(51, 13)
        TIEMPOLabel.TabIndex = 16
        TIEMPOLabel.Text = "TIEMPO:"
        '
        'TIEMPOTextBox
        '
        Me.TIEMPOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REGISTRO_DE_MANTENIMIENTOBindingSource, "TIEMPO", True))
        Me.TIEMPOTextBox.Location = New System.Drawing.Point(258, 221)
        Me.TIEMPOTextBox.Name = "TIEMPOTextBox"
        Me.TIEMPOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TIEMPOTextBox.TabIndex = 17
        '
        'CODAPLabel
        '
        CODAPLabel.AutoSize = True
        CODAPLabel.Location = New System.Drawing.Point(6, 250)
        CODAPLabel.Name = "CODAPLabel"
        CODAPLabel.Size = New System.Drawing.Size(47, 13)
        CODAPLabel.TabIndex = 18
        CODAPLabel.Text = "CODAP:"
        '
        'CODAPTextBox
        '
        Me.CODAPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REGISTRO_DE_MANTENIMIENTOBindingSource, "CODAP", True))
        Me.CODAPTextBox.Location = New System.Drawing.Point(258, 247)
        Me.CODAPTextBox.Name = "CODAPTextBox"
        Me.CODAPTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODAPTextBox.TabIndex = 19
        '
        'TrabajosM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 540)
        Me.Controls.Add(Me.REGISTRO_DE_MANTENIMIENTODataGridView)
        Me.Controls.Add(Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "TrabajosM"
        Me.Text = "Mantenimientos realizados"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BASE_DE_DATOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGISTRO_DE_MANTENIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.ResumeLayout(False)
        Me.REGISTRO_DE_MANTENIMIENTOBindingNavigator.PerformLayout()
        CType(Me.REGISTRO_DE_MANTENIMIENTODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents REGISTRO_DE_MANTENIMIENTODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGO_DE_LA_MAQUINATextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_DE_LA_MAQUINATextBox As System.Windows.Forms.TextBox
    Friend WithEvents N__DE_ORDENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_DE_MANTENIMIENTODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TRABAJO_REALIZADOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PERSONA_QUE_REALIZA_EL_MANTENIMIENTOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIPO_DE_MANTENIMIENTOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIEMPO_DE_REPARACION_EN_HORASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIEMPOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CODAPTextBox As System.Windows.Forms.TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HojasVida
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
        Dim REFERENCIALabel As System.Windows.Forms.Label
        Dim MARCALabel As System.Windows.Forms.Label
        Dim TIPO_DE_MAQUINALabel As System.Windows.Forms.Label
        Dim FECHA_DE_INGRESO_A_LA_EMPRESALabel As System.Windows.Forms.Label
        Dim INGRESO_AL_SISTEMA_FECHALabel As System.Windows.Forms.Label
        Dim COSTO_DE_LA_MAQUINALabel As System.Windows.Forms.Label
        Dim NOTALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HojasVida))
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.HOJA_DE_VIDA_DE_LA_MAQUINADataGridView = New System.Windows.Forms.DataGridView
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CODIGOTextBox = New System.Windows.Forms.TextBox
        Me.NOMBRE_DE_LA_MAQUINATextBox = New System.Windows.Forms.TextBox
        Me.REFERENCIATextBox = New System.Windows.Forms.TextBox
        Me.MARCATextBox = New System.Windows.Forms.TextBox
        Me.TIPO_DE_MAQUINATextBox = New System.Windows.Forms.TextBox
        Me.FECHA_DE_INGRESO_A_LA_EMPRESADateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.INGRESO_AL_SISTEMA_FECHADateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.COSTO_DE_LA_MAQUINATextBox = New System.Windows.Forms.TextBox
        Me.NOTATextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BASE_DE_DATOSDataSet = New Mantenimiento.BASE_DE_DATOSDataSet
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HOJA_DE_VIDA_DE_LA_MAQUINATableAdapter = New Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.HOJA_DE_VIDA_DE_LA_MAQUINATableAdapter
        Me.TableAdapterManager = New Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager
        CODIGOLabel = New System.Windows.Forms.Label
        NOMBRE_DE_LA_MAQUINALabel = New System.Windows.Forms.Label
        REFERENCIALabel = New System.Windows.Forms.Label
        MARCALabel = New System.Windows.Forms.Label
        TIPO_DE_MAQUINALabel = New System.Windows.Forms.Label
        FECHA_DE_INGRESO_A_LA_EMPRESALabel = New System.Windows.Forms.Label
        INGRESO_AL_SISTEMA_FECHALabel = New System.Windows.Forms.Label
        COSTO_DE_LA_MAQUINALabel = New System.Windows.Forms.Label
        NOTALabel = New System.Windows.Forms.Label
        CType(Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.SuspendLayout()
        CType(Me.HOJA_DE_VIDA_DE_LA_MAQUINADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BASE_DE_DATOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(18, 16)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(52, 13)
        CODIGOLabel.TabIndex = 3
        CODIGOLabel.Text = "CODIGO:"
        '
        'NOMBRE_DE_LA_MAQUINALabel
        '
        NOMBRE_DE_LA_MAQUINALabel.AutoSize = True
        NOMBRE_DE_LA_MAQUINALabel.Location = New System.Drawing.Point(18, 42)
        NOMBRE_DE_LA_MAQUINALabel.Name = "NOMBRE_DE_LA_MAQUINALabel"
        NOMBRE_DE_LA_MAQUINALabel.Size = New System.Drawing.Size(144, 13)
        NOMBRE_DE_LA_MAQUINALabel.TabIndex = 5
        NOMBRE_DE_LA_MAQUINALabel.Text = "NOMBRE DE LA MAQUINA:"
        '
        'REFERENCIALabel
        '
        REFERENCIALabel.AutoSize = True
        REFERENCIALabel.Location = New System.Drawing.Point(18, 68)
        REFERENCIALabel.Name = "REFERENCIALabel"
        REFERENCIALabel.Size = New System.Drawing.Size(78, 13)
        REFERENCIALabel.TabIndex = 7
        REFERENCIALabel.Text = "REFERENCIA:"
        '
        'MARCALabel
        '
        MARCALabel.AutoSize = True
        MARCALabel.Location = New System.Drawing.Point(18, 94)
        MARCALabel.Name = "MARCALabel"
        MARCALabel.Size = New System.Drawing.Size(48, 13)
        MARCALabel.TabIndex = 9
        MARCALabel.Text = "MARCA:"
        '
        'TIPO_DE_MAQUINALabel
        '
        TIPO_DE_MAQUINALabel.AutoSize = True
        TIPO_DE_MAQUINALabel.Location = New System.Drawing.Point(18, 120)
        TIPO_DE_MAQUINALabel.Name = "TIPO_DE_MAQUINALabel"
        TIPO_DE_MAQUINALabel.Size = New System.Drawing.Size(106, 13)
        TIPO_DE_MAQUINALabel.TabIndex = 11
        TIPO_DE_MAQUINALabel.Text = "TIPO DE MAQUINA:"
        '
        'FECHA_DE_INGRESO_A_LA_EMPRESALabel
        '
        FECHA_DE_INGRESO_A_LA_EMPRESALabel.AutoSize = True
        FECHA_DE_INGRESO_A_LA_EMPRESALabel.Location = New System.Drawing.Point(18, 147)
        FECHA_DE_INGRESO_A_LA_EMPRESALabel.Name = "FECHA_DE_INGRESO_A_LA_EMPRESALabel"
        FECHA_DE_INGRESO_A_LA_EMPRESALabel.Size = New System.Drawing.Size(196, 13)
        FECHA_DE_INGRESO_A_LA_EMPRESALabel.TabIndex = 13
        FECHA_DE_INGRESO_A_LA_EMPRESALabel.Text = "FECHA DE INGRESO A LA EMPRESA:"
        '
        'INGRESO_AL_SISTEMA_FECHALabel
        '
        INGRESO_AL_SISTEMA_FECHALabel.AutoSize = True
        INGRESO_AL_SISTEMA_FECHALabel.Location = New System.Drawing.Point(18, 173)
        INGRESO_AL_SISTEMA_FECHALabel.Name = "INGRESO_AL_SISTEMA_FECHALabel"
        INGRESO_AL_SISTEMA_FECHALabel.Size = New System.Drawing.Size(163, 13)
        INGRESO_AL_SISTEMA_FECHALabel.TabIndex = 15
        INGRESO_AL_SISTEMA_FECHALabel.Text = "INGRESO AL SISTEMA FECHA:"
        '
        'COSTO_DE_LA_MAQUINALabel
        '
        COSTO_DE_LA_MAQUINALabel.AutoSize = True
        COSTO_DE_LA_MAQUINALabel.Location = New System.Drawing.Point(18, 198)
        COSTO_DE_LA_MAQUINALabel.Name = "COSTO_DE_LA_MAQUINALabel"
        COSTO_DE_LA_MAQUINALabel.Size = New System.Drawing.Size(134, 13)
        COSTO_DE_LA_MAQUINALabel.TabIndex = 17
        COSTO_DE_LA_MAQUINALabel.Text = "COSTO DE LA MAQUINA:"
        '
        'NOTALabel
        '
        NOTALabel.AutoSize = True
        NOTALabel.Location = New System.Drawing.Point(18, 224)
        NOTALabel.Name = "NOTALabel"
        NOTALabel.Size = New System.Drawing.Size(40, 13)
        NOTALabel.TabIndex = 19
        NOTALabel.Text = "NOTA:"
        '
        'HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator
        '
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.BindingSource = Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigatorSaveItem})
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.Name = "HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator"
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.Size = New System.Drawing.Size(674, 25)
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.TabIndex = 0
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.Text = "BindingNavigator1"
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
        'HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigatorSaveItem
        '
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigatorSaveItem.Image = CType(resources.GetObject("HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigatorSaveItem.Name = "HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigatorSaveItem"
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'HOJA_DE_VIDA_DE_LA_MAQUINADataGridView
        '
        Me.HOJA_DE_VIDA_DE_LA_MAQUINADataGridView.AutoGenerateColumns = False
        Me.HOJA_DE_VIDA_DE_LA_MAQUINADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HOJA_DE_VIDA_DE_LA_MAQUINADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.HOJA_DE_VIDA_DE_LA_MAQUINADataGridView.DataSource = Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource
        Me.HOJA_DE_VIDA_DE_LA_MAQUINADataGridView.Location = New System.Drawing.Point(12, 55)
        Me.HOJA_DE_VIDA_DE_LA_MAQUINADataGridView.Name = "HOJA_DE_VIDA_DE_LA_MAQUINADataGridView"
        Me.HOJA_DE_VIDA_DE_LA_MAQUINADataGridView.Size = New System.Drawing.Size(650, 273)
        Me.HOJA_DE_VIDA_DE_LA_MAQUINADataGridView.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(674, 24)
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
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem1})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.AyudaToolStripMenuItem1.Text = "Ayuda"
        '
        'CODIGOTextBox
        '
        Me.CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource, "CODIGO", True))
        Me.CODIGOTextBox.Location = New System.Drawing.Point(220, 13)
        Me.CODIGOTextBox.Name = "CODIGOTextBox"
        Me.CODIGOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODIGOTextBox.TabIndex = 4
        '
        'NOMBRE_DE_LA_MAQUINATextBox
        '
        Me.NOMBRE_DE_LA_MAQUINATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource, "NOMBRE DE LA MAQUINA", True))
        Me.NOMBRE_DE_LA_MAQUINATextBox.Location = New System.Drawing.Point(220, 39)
        Me.NOMBRE_DE_LA_MAQUINATextBox.Name = "NOMBRE_DE_LA_MAQUINATextBox"
        Me.NOMBRE_DE_LA_MAQUINATextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_DE_LA_MAQUINATextBox.TabIndex = 6
        '
        'REFERENCIATextBox
        '
        Me.REFERENCIATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource, "REFERENCIA", True))
        Me.REFERENCIATextBox.Location = New System.Drawing.Point(220, 65)
        Me.REFERENCIATextBox.Name = "REFERENCIATextBox"
        Me.REFERENCIATextBox.Size = New System.Drawing.Size(200, 20)
        Me.REFERENCIATextBox.TabIndex = 8
        '
        'MARCATextBox
        '
        Me.MARCATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource, "MARCA", True))
        Me.MARCATextBox.Location = New System.Drawing.Point(220, 91)
        Me.MARCATextBox.Name = "MARCATextBox"
        Me.MARCATextBox.Size = New System.Drawing.Size(200, 20)
        Me.MARCATextBox.TabIndex = 10
        '
        'TIPO_DE_MAQUINATextBox
        '
        Me.TIPO_DE_MAQUINATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource, "TIPO DE MAQUINA", True))
        Me.TIPO_DE_MAQUINATextBox.Location = New System.Drawing.Point(220, 117)
        Me.TIPO_DE_MAQUINATextBox.Name = "TIPO_DE_MAQUINATextBox"
        Me.TIPO_DE_MAQUINATextBox.Size = New System.Drawing.Size(200, 20)
        Me.TIPO_DE_MAQUINATextBox.TabIndex = 12
        '
        'FECHA_DE_INGRESO_A_LA_EMPRESADateTimePicker
        '
        Me.FECHA_DE_INGRESO_A_LA_EMPRESADateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource, "FECHA DE INGRESO A LA EMPRESA", True))
        Me.FECHA_DE_INGRESO_A_LA_EMPRESADateTimePicker.Location = New System.Drawing.Point(220, 143)
        Me.FECHA_DE_INGRESO_A_LA_EMPRESADateTimePicker.Name = "FECHA_DE_INGRESO_A_LA_EMPRESADateTimePicker"
        Me.FECHA_DE_INGRESO_A_LA_EMPRESADateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_DE_INGRESO_A_LA_EMPRESADateTimePicker.TabIndex = 14
        '
        'INGRESO_AL_SISTEMA_FECHADateTimePicker
        '
        Me.INGRESO_AL_SISTEMA_FECHADateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource, "INGRESO AL SISTEMA FECHA", True))
        Me.INGRESO_AL_SISTEMA_FECHADateTimePicker.Location = New System.Drawing.Point(220, 169)
        Me.INGRESO_AL_SISTEMA_FECHADateTimePicker.Name = "INGRESO_AL_SISTEMA_FECHADateTimePicker"
        Me.INGRESO_AL_SISTEMA_FECHADateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.INGRESO_AL_SISTEMA_FECHADateTimePicker.TabIndex = 16
        '
        'COSTO_DE_LA_MAQUINATextBox
        '
        Me.COSTO_DE_LA_MAQUINATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource, "COSTO DE LA MAQUINA", True))
        Me.COSTO_DE_LA_MAQUINATextBox.Location = New System.Drawing.Point(220, 195)
        Me.COSTO_DE_LA_MAQUINATextBox.Name = "COSTO_DE_LA_MAQUINATextBox"
        Me.COSTO_DE_LA_MAQUINATextBox.Size = New System.Drawing.Size(200, 20)
        Me.COSTO_DE_LA_MAQUINATextBox.TabIndex = 18
        '
        'NOTATextBox
        '
        Me.NOTATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource, "NOTA", True))
        Me.NOTATextBox.Location = New System.Drawing.Point(220, 221)
        Me.NOTATextBox.Name = "NOTATextBox"
        Me.NOTATextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTATextBox.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CODIGOLabel)
        Me.GroupBox1.Controls.Add(Me.CODIGOTextBox)
        Me.GroupBox1.Controls.Add(NOMBRE_DE_LA_MAQUINALabel)
        Me.GroupBox1.Controls.Add(Me.NOMBRE_DE_LA_MAQUINATextBox)
        Me.GroupBox1.Controls.Add(REFERENCIALabel)
        Me.GroupBox1.Controls.Add(Me.REFERENCIATextBox)
        Me.GroupBox1.Controls.Add(MARCALabel)
        Me.GroupBox1.Controls.Add(Me.MARCATextBox)
        Me.GroupBox1.Controls.Add(TIPO_DE_MAQUINALabel)
        Me.GroupBox1.Controls.Add(Me.TIPO_DE_MAQUINATextBox)
        Me.GroupBox1.Controls.Add(FECHA_DE_INGRESO_A_LA_EMPRESALabel)
        Me.GroupBox1.Controls.Add(Me.FECHA_DE_INGRESO_A_LA_EMPRESADateTimePicker)
        Me.GroupBox1.Controls.Add(INGRESO_AL_SISTEMA_FECHALabel)
        Me.GroupBox1.Controls.Add(Me.INGRESO_AL_SISTEMA_FECHADateTimePicker)
        Me.GroupBox1.Controls.Add(COSTO_DE_LA_MAQUINALabel)
        Me.GroupBox1.Controls.Add(Me.COSTO_DE_LA_MAQUINATextBox)
        Me.GroupBox1.Controls.Add(NOTALabel)
        Me.GroupBox1.Controls.Add(Me.NOTATextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 355)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 259)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(493, 449)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 53)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Limpiar datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HOJA_DE_VIDA_DE_LA_MAQUINABindingSource
        '
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource.DataMember = "HOJA DE VIDA DE LA MAQUINA"
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource.DataSource = Me.BASE_DE_DATOSDataSet
        '
        'BASE_DE_DATOSDataSet
        '
        Me.BASE_DE_DATOSDataSet.DataSetName = "BASE_DE_DATOSDataSet"
        Me.BASE_DE_DATOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "REFERENCIA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "REFERENCIA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MARCA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MARCA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TIPO DE MAQUINA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TIPO DE MAQUINA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FECHA DE INGRESO A LA EMPRESA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "FECHA DE INGRESO A LA EMPRESA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "INGRESO AL SISTEMA FECHA"
        Me.DataGridViewTextBoxColumn7.HeaderText = "INGRESO AL SISTEMA FECHA"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "COSTO DE LA MAQUINA"
        Me.DataGridViewTextBoxColumn8.HeaderText = "COSTO DE LA MAQUINA"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NOTA"
        Me.DataGridViewTextBoxColumn9.HeaderText = "NOTA"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'HOJA_DE_VIDA_DE_LA_MAQUINATableAdapter
        '
        Me.HOJA_DE_VIDA_DE_LA_MAQUINATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINATableAdapter = Nothing
        Me.TableAdapterManager.HOJA_DE_VIDA_DE_LA_MAQUINATableAdapter = Me.HOJA_DE_VIDA_DE_LA_MAQUINATableAdapter
        Me.TableAdapterManager.ORDEN_DE_TRABAJOTableAdapter = Nothing
        Me.TableAdapterManager.REGISTRO_DE_MANTENIMIENTOTableAdapter = Nothing
        Me.TableAdapterManager.REPUESTOS_DISPONIBLESTableAdapter = Nothing
        Me.TableAdapterManager.SOLICITUD_DE_REPUESTOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HojasVida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 626)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.HOJA_DE_VIDA_DE_LA_MAQUINADataGridView)
        Me.Controls.Add(Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "HojasVida"
        Me.Text = "Hojas de vida"
        CType(Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.ResumeLayout(False)
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator.PerformLayout()
        CType(Me.HOJA_DE_VIDA_DE_LA_MAQUINADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BASE_DE_DATOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BASE_DE_DATOSDataSet As Mantenimiento.BASE_DE_DATOSDataSet
    Friend WithEvents HOJA_DE_VIDA_DE_LA_MAQUINABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HOJA_DE_VIDA_DE_LA_MAQUINATableAdapter As Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.HOJA_DE_VIDA_DE_LA_MAQUINATableAdapter
    Friend WithEvents TableAdapterManager As Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents HOJA_DE_VIDA_DE_LA_MAQUINADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CODIGOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_DE_LA_MAQUINATextBox As System.Windows.Forms.TextBox
    Friend WithEvents REFERENCIATextBox As System.Windows.Forms.TextBox
    Friend WithEvents MARCATextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIPO_DE_MAQUINATextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_DE_INGRESO_A_LA_EMPRESADateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents INGRESO_AL_SISTEMA_FECHADateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents COSTO_DE_LA_MAQUINATextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTATextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

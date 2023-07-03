<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Dim REFERENCIA_DE_REPUESTOLabel As System.Windows.Forms.Label
        Dim NOMBRE_DEL_REPUESTOLabel As System.Windows.Forms.Label
        Dim CANTIDAD_DISPONIBLELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stock))
        Me.REPUESTOS_DISPONIBLESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.REPUESTOS_DISPONIBLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BASE_DE_DATOSDataSet = New Mantenimiento.BASE_DE_DATOSDataSet
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
        Me.REPUESTOS_DISPONIBLESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.REPUESTOS_DISPONIBLESDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.REFERENCIA_DE_REPUESTOTextBox = New System.Windows.Forms.TextBox
        Me.NOMBRE_DEL_REPUESTOTextBox = New System.Windows.Forms.TextBox
        Me.CANTIDAD_DISPONIBLETextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.REPUESTOS_DISPONIBLESTableAdapter = New Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.REPUESTOS_DISPONIBLESTableAdapter
        Me.TableAdapterManager = New Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        REFERENCIA_DE_REPUESTOLabel = New System.Windows.Forms.Label
        NOMBRE_DEL_REPUESTOLabel = New System.Windows.Forms.Label
        CANTIDAD_DISPONIBLELabel = New System.Windows.Forms.Label
        CType(Me.REPUESTOS_DISPONIBLESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.REPUESTOS_DISPONIBLESBindingNavigator.SuspendLayout()
        CType(Me.REPUESTOS_DISPONIBLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BASE_DE_DATOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPUESTOS_DISPONIBLESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'REFERENCIA_DE_REPUESTOLabel
        '
        REFERENCIA_DE_REPUESTOLabel.AutoSize = True
        REFERENCIA_DE_REPUESTOLabel.Location = New System.Drawing.Point(8, 17)
        REFERENCIA_DE_REPUESTOLabel.Name = "REFERENCIA_DE_REPUESTOLabel"
        REFERENCIA_DE_REPUESTOLabel.Size = New System.Drawing.Size(158, 13)
        REFERENCIA_DE_REPUESTOLabel.TabIndex = 2
        REFERENCIA_DE_REPUESTOLabel.Text = "REFERENCIA DE REPUESTO:"
        '
        'NOMBRE_DEL_REPUESTOLabel
        '
        NOMBRE_DEL_REPUESTOLabel.AutoSize = True
        NOMBRE_DEL_REPUESTOLabel.Location = New System.Drawing.Point(8, 43)
        NOMBRE_DEL_REPUESTOLabel.Name = "NOMBRE_DEL_REPUESTOLabel"
        NOMBRE_DEL_REPUESTOLabel.Size = New System.Drawing.Size(143, 13)
        NOMBRE_DEL_REPUESTOLabel.TabIndex = 4
        NOMBRE_DEL_REPUESTOLabel.Text = "NOMBRE DEL REPUESTO:"
        '
        'CANTIDAD_DISPONIBLELabel
        '
        CANTIDAD_DISPONIBLELabel.AutoSize = True
        CANTIDAD_DISPONIBLELabel.Location = New System.Drawing.Point(8, 69)
        CANTIDAD_DISPONIBLELabel.Name = "CANTIDAD_DISPONIBLELabel"
        CANTIDAD_DISPONIBLELabel.Size = New System.Drawing.Size(132, 13)
        CANTIDAD_DISPONIBLELabel.TabIndex = 6
        CANTIDAD_DISPONIBLELabel.Text = "CANTIDAD DISPONIBLE:"
        '
        'REPUESTOS_DISPONIBLESBindingNavigator
        '
        Me.REPUESTOS_DISPONIBLESBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.REPUESTOS_DISPONIBLESBindingNavigator.BindingSource = Me.REPUESTOS_DISPONIBLESBindingSource
        Me.REPUESTOS_DISPONIBLESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.REPUESTOS_DISPONIBLESBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.REPUESTOS_DISPONIBLESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.REPUESTOS_DISPONIBLESBindingNavigatorSaveItem})
        Me.REPUESTOS_DISPONIBLESBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.REPUESTOS_DISPONIBLESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.REPUESTOS_DISPONIBLESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.REPUESTOS_DISPONIBLESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.REPUESTOS_DISPONIBLESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.REPUESTOS_DISPONIBLESBindingNavigator.Name = "REPUESTOS_DISPONIBLESBindingNavigator"
        Me.REPUESTOS_DISPONIBLESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.REPUESTOS_DISPONIBLESBindingNavigator.Size = New System.Drawing.Size(672, 25)
        Me.REPUESTOS_DISPONIBLESBindingNavigator.TabIndex = 0
        Me.REPUESTOS_DISPONIBLESBindingNavigator.Text = "BindingNavigator1"
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
        'REPUESTOS_DISPONIBLESBindingSource
        '
        Me.REPUESTOS_DISPONIBLESBindingSource.DataMember = "REPUESTOS DISPONIBLES"
        Me.REPUESTOS_DISPONIBLESBindingSource.DataSource = Me.BASE_DE_DATOSDataSet
        '
        'BASE_DE_DATOSDataSet
        '
        Me.BASE_DE_DATOSDataSet.DataSetName = "BASE_DE_DATOSDataSet"
        Me.BASE_DE_DATOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'REPUESTOS_DISPONIBLESBindingNavigatorSaveItem
        '
        Me.REPUESTOS_DISPONIBLESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.REPUESTOS_DISPONIBLESBindingNavigatorSaveItem.Image = CType(resources.GetObject("REPUESTOS_DISPONIBLESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.REPUESTOS_DISPONIBLESBindingNavigatorSaveItem.Name = "REPUESTOS_DISPONIBLESBindingNavigatorSaveItem"
        Me.REPUESTOS_DISPONIBLESBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.REPUESTOS_DISPONIBLESBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'REPUESTOS_DISPONIBLESDataGridView
        '
        Me.REPUESTOS_DISPONIBLESDataGridView.AutoGenerateColumns = False
        Me.REPUESTOS_DISPONIBLESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.REPUESTOS_DISPONIBLESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.REPUESTOS_DISPONIBLESDataGridView.DataSource = Me.REPUESTOS_DISPONIBLESBindingSource
        Me.REPUESTOS_DISPONIBLESDataGridView.Location = New System.Drawing.Point(317, 52)
        Me.REPUESTOS_DISPONIBLESDataGridView.Name = "REPUESTOS_DISPONIBLESDataGridView"
        Me.REPUESTOS_DISPONIBLESDataGridView.Size = New System.Drawing.Size(343, 322)
        Me.REPUESTOS_DISPONIBLESDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "REFERENCIA DE REPUESTO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "REFERENCIA DE REPUESTO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE DEL REPUESTO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE DEL REPUESTO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CANTIDAD DISPONIBLE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CANTIDAD DISPONIBLE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'REFERENCIA_DE_REPUESTOTextBox
        '
        Me.REFERENCIA_DE_REPUESTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REPUESTOS_DISPONIBLESBindingSource, "REFERENCIA DE REPUESTO", True))
        Me.REFERENCIA_DE_REPUESTOTextBox.Location = New System.Drawing.Point(172, 14)
        Me.REFERENCIA_DE_REPUESTOTextBox.Name = "REFERENCIA_DE_REPUESTOTextBox"
        Me.REFERENCIA_DE_REPUESTOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.REFERENCIA_DE_REPUESTOTextBox.TabIndex = 3
        '
        'NOMBRE_DEL_REPUESTOTextBox
        '
        Me.NOMBRE_DEL_REPUESTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REPUESTOS_DISPONIBLESBindingSource, "NOMBRE DEL REPUESTO", True))
        Me.NOMBRE_DEL_REPUESTOTextBox.Location = New System.Drawing.Point(172, 40)
        Me.NOMBRE_DEL_REPUESTOTextBox.Name = "NOMBRE_DEL_REPUESTOTextBox"
        Me.NOMBRE_DEL_REPUESTOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRE_DEL_REPUESTOTextBox.TabIndex = 5
        '
        'CANTIDAD_DISPONIBLETextBox
        '
        Me.CANTIDAD_DISPONIBLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REPUESTOS_DISPONIBLESBindingSource, "CANTIDAD DISPONIBLE", True))
        Me.CANTIDAD_DISPONIBLETextBox.Location = New System.Drawing.Point(172, 66)
        Me.CANTIDAD_DISPONIBLETextBox.Name = "CANTIDAD_DISPONIBLETextBox"
        Me.CANTIDAD_DISPONIBLETextBox.Size = New System.Drawing.Size(100, 20)
        Me.CANTIDAD_DISPONIBLETextBox.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(REFERENCIA_DE_REPUESTOLabel)
        Me.GroupBox1.Controls.Add(Me.REFERENCIA_DE_REPUESTOTextBox)
        Me.GroupBox1.Controls.Add(NOMBRE_DEL_REPUESTOLabel)
        Me.GroupBox1.Controls.Add(Me.NOMBRE_DEL_REPUESTOTextBox)
        Me.GroupBox1.Controls.Add(CANTIDAD_DISPONIBLELabel)
        Me.GroupBox1.Controls.Add(Me.CANTIDAD_DISPONIBLETextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 99)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 53)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Limpiar datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'REPUESTOS_DISPONIBLESTableAdapter
        '
        Me.REPUESTOS_DISPONIBLESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINATableAdapter = Nothing
        Me.TableAdapterManager.HOJA_DE_VIDA_DE_LA_MAQUINATableAdapter = Nothing
        Me.TableAdapterManager.ORDEN_DE_TRABAJOTableAdapter = Nothing
        Me.TableAdapterManager.REGISTRO_DE_MANTENIMIENTOTableAdapter = Nothing
        Me.TableAdapterManager.REPUESTOS_DISPONIBLESTableAdapter = Me.REPUESTOS_DISPONIBLESTableAdapter
        Me.TableAdapterManager.SOLICITUD_DE_REPUESTOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(672, 24)
        Me.MenuStrip1.TabIndex = 27
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
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 390)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.REPUESTOS_DISPONIBLESDataGridView)
        Me.Controls.Add(Me.REPUESTOS_DISPONIBLESBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Stock"
        Me.Text = "Repuestos disponibles"
        CType(Me.REPUESTOS_DISPONIBLESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.REPUESTOS_DISPONIBLESBindingNavigator.ResumeLayout(False)
        Me.REPUESTOS_DISPONIBLESBindingNavigator.PerformLayout()
        CType(Me.REPUESTOS_DISPONIBLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BASE_DE_DATOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPUESTOS_DISPONIBLESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BASE_DE_DATOSDataSet As Mantenimiento.BASE_DE_DATOSDataSet
    Friend WithEvents REPUESTOS_DISPONIBLESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REPUESTOS_DISPONIBLESTableAdapter As Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.REPUESTOS_DISPONIBLESTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimiento.BASE_DE_DATOSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents REPUESTOS_DISPONIBLESBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents REPUESTOS_DISPONIBLESBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents REPUESTOS_DISPONIBLESDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFERENCIA_DE_REPUESTOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_DEL_REPUESTOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CANTIDAD_DISPONIBLETextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

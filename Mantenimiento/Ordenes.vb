Public Class Ordenes

    Private Sub REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.REGISTRO_DE_MANTENIMIENTOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BASE_DE_DATOSDataSet)

    End Sub

    Private Sub RegistroM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BASE_DE_DATOSDataSet.ORDEN_DE_TRABAJO' Puede moverla o quitarla según sea necesario.
        Me.ORDEN_DE_TRABAJOTableAdapter.Fill(Me.BASE_DE_DATOSDataSet.ORDEN_DE_TRABAJO)
        'TODO: esta línea de código carga datos en la tabla 'BASE_DE_DATOSDataSet.ORDEN_DE_TRABAJO' Puede moverla o quitarla según sea necesario.
        Me.ORDEN_DE_TRABAJOTableAdapter.Fill(Me.BASE_DE_DATOSDataSet.ORDEN_DE_TRABAJO)
        'TODO: esta línea de código carga datos en la tabla 'BASE_DE_DATOSDataSet.REGISTRO_DE_MANTENIMIENTO' Puede moverla o quitarla según sea necesario.
        Me.REGISTRO_DE_MANTENIMIENTOTableAdapter.Fill(Me.BASE_DE_DATOSDataSet.REGISTRO_DE_MANTENIMIENTO)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CODIGO_DE_LA_MAQUINATextBox.Text = ""
        NOMBRE_DE_LA_MAQUINATextBox.Text = ""
        TIPO_DE_MANTENIMIENTOTextBox.Text = ""
        N__ORDEN_DE_TRABAJOTextBox.Text = ""
        MOTIVOTextBox.Text = ""
        ORDENATextBox.Text = ""
        COLABORADORTextBox.Text = ""
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        Process.Start("Ayuda.docx")
    End Sub
End Class
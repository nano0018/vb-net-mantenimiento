Public Class Stock

    Private Sub REPUESTOS_DISPONIBLESBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPUESTOS_DISPONIBLESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.REPUESTOS_DISPONIBLESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BASE_DE_DATOSDataSet)

    End Sub

    Private Sub Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BASE_DE_DATOSDataSet.REPUESTOS_DISPONIBLES' Puede moverla o quitarla según sea necesario.
        Me.REPUESTOS_DISPONIBLESTableAdapter.Fill(Me.BASE_DE_DATOSDataSet.REPUESTOS_DISPONIBLES)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        REFERENCIA_DE_REPUESTOTextBox.Text = ""
        NOMBRE_DEL_REPUESTOTextBox.Text = ""
        CANTIDAD_DISPONIBLETextBox.Text = ""
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        Process.Start("Ayuda.docx")
    End Sub
End Class
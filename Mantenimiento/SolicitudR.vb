Public Class SolicitudR

    Private Sub SOLICITUD_DE_REPUESTOSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SOLICITUD_DE_REPUESTOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SOLICITUD_DE_REPUESTOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BASE_DE_DATOSDataSet)

    End Sub

    Private Sub SolicitudR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BASE_DE_DATOSDataSet.SOLICITUD_DE_REPUESTOS' Puede moverla o quitarla según sea necesario.
        Me.SOLICITUD_DE_REPUESTOSTableAdapter.Fill(Me.BASE_DE_DATOSDataSet.SOLICITUD_DE_REPUESTOS)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CODIGO_DE_LA_MAQUINATextBox.Text = ""
        NOMBRE_DE_LA_MAQUINATextBox.Text = ""
        REFERENCIA_DE_REPUESTOTextBox.Text = ""
        CANTIDADTextBox.Text = ""
        NOMBRE_DE_QUIEN_SOLICITATextBox.Text = ""
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        Process.Start("Ayuda.docx")
    End Sub
End Class
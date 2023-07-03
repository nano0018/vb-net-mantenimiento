Public Class HojasVida

    Private Sub HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HOJA_DE_VIDA_DE_LA_MAQUINABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HOJA_DE_VIDA_DE_LA_MAQUINABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BASE_DE_DATOSDataSet)

    End Sub

    Private Sub HojasVida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BASE_DE_DATOSDataSet.HOJA_DE_VIDA_DE_LA_MAQUINA' Puede moverla o quitarla según sea necesario.
        Me.HOJA_DE_VIDA_DE_LA_MAQUINATableAdapter.Fill(Me.BASE_DE_DATOSDataSet.HOJA_DE_VIDA_DE_LA_MAQUINA)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CODIGOTextBox.Text = ""
        NOMBRE_DE_LA_MAQUINATextBox.Text = ""
        REFERENCIATextBox.Text = ""
        MARCATextBox.Text = ""
        TIPO_DE_MAQUINATextBox.Text = ""
        COSTO_DE_LA_MAQUINATextBox.Text = ""
        NOTATextBox.Text = ""
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        Process.Start("Ayuda.docx")
    End Sub
End Class
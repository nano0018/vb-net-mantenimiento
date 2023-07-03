Public Class DatosTecnicos

    Private Sub CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BASE_DE_DATOSDataSet)

    End Sub

    Private Sub DatosTecnicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BASE_DE_DATOSDataSet.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINA' Puede moverla o quitarla según sea necesario.
        Me.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINATableAdapter.Fill(Me.BASE_DE_DATOSDataSet.CARACTERISTICAS_TECNICAS_DE_LA_MAQUINA)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CODIGOTextBox.Text = ""
        NOMBRE_DE_LA_MAQUINATextBox.Text = ""
        TIPO_DE_ALIMENTACION_ELECTextBox.Text = ""
        VOLTAJE_QUE_MANEJATextBox.Text = ""
        NOTATextBox.Text = ""
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        Process.Start("Ayuda.docx")
    End Sub
End Class
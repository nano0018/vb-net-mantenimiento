Public Class TrabajosM

    Private Sub REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.REGISTRO_DE_MANTENIMIENTOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BASE_DE_DATOSDataSet)

    End Sub

    Private Sub TrabajosM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BASE_DE_DATOSDataSet.REGISTRO_DE_MANTENIMIENTO' Puede moverla o quitarla según sea necesario.
        Me.REGISTRO_DE_MANTENIMIENTOTableAdapter.Fill(Me.BASE_DE_DATOSDataSet.REGISTRO_DE_MANTENIMIENTO)
        'TODO: esta línea de código carga datos en la tabla 'BASE_DE_DATOSDataSet.REGISTRO_DE_MANTENIMIENTO' Puede moverla o quitarla según sea necesario.
        Me.REGISTRO_DE_MANTENIMIENTOTableAdapter.Fill(Me.BASE_DE_DATOSDataSet.REGISTRO_DE_MANTENIMIENTO)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CODIGO_DE_LA_MAQUINATextBox.Text = ""
        NOMBRE_DE_LA_MAQUINATextBox.Text = ""
        N__DE_ORDENTextBox.Text = ""
        TIPO_DE_MANTENIMIENTOTextBox.Text = ""
        TIEMPO_DE_REPARACION_EN_HORASTextBox.Text = ""
        TRABAJO_REALIZADOTextBox.Text = ""
        PERSONA_QUE_REALIZA_EL_MANTENIMIENTOTextBox.Text = ""
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        Process.Start("Ayuda.docx")
    End Sub

    Private Sub REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.REGISTRO_DE_MANTENIMIENTOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BASE_DE_DATOSDataSet)

    End Sub
End Class
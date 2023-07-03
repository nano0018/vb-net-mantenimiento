Public Class Inicio

    Private Sub SalirF4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirF4ToolStripMenuItem.Click
        Me.Close()
        Autenticacion.Show()
    End Sub

    Private Sub SalirF4ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirF4ToolStripMenuItem1.Click
        End
    End Sub

    Private Sub HojasDeVidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HojasDeVidaToolStripMenuItem.Click
        HojasVida.Show()
        HojasVida.Activate()
    End Sub

    Private Sub DatosTécnicosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosTécnicosToolStripMenuItem.Click
        DatosTecnicos.Show()
        DatosTecnicos.Activate()
    End Sub

    Private Sub MantenimientosRealizadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientosRealizadosToolStripMenuItem.Click
        TrabajosM.Show()
        TrabajosM.Activate()
    End Sub

    Private Sub OrdenesDeTrabajoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenesDeTrabajoToolStripMenuItem1.Click
        Ordenes.Show()
        Ordenes.Activate()
    End Sub

    Private Sub DisponiblesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisponiblesToolStripMenuItem.Click
        Stock.Show()
        Stock.Activate()
    End Sub

    Private Sub SolicitudesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitudesToolStripMenuItem.Click
        SolicitudR.Show()
        SolicitudR.Activate()
    End Sub

    Private Sub IndicadoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndicadoresToolStripMenuItem.Click
        Indicadores.Show()
        Indicadores.Activate()
    End Sub


    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        Process.Start("Ayuda.docx")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
End Class
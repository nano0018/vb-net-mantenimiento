Imports System
Imports Microsoft.VisualBasic
Public Class Indicadores

    Private Sub Indicadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BASE_DE_DATOSDataSet.HOJA_DE_VIDA_DE_LA_MAQUINA' Puede moverla o quitarla según sea necesario.
        Me.HOJA_DE_VIDA_DE_LA_MAQUINATableAdapter.Fill(Me.BASE_DE_DATOSDataSet.HOJA_DE_VIDA_DE_LA_MAQUINA)
        'TODO: esta línea de código carga datos en la tabla 'BASE_DE_DATOSDataSet.REGISTRO_DE_MANTENIMIENTO' Puede moverla o quitarla según sea necesario.
        Me.REGISTRO_DE_MANTENIMIENTOTableAdapter.Fill(Me.BASE_DE_DATOSDataSet.REGISTRO_DE_MANTENIMIENTO)
        'TODO: esta línea de código carga datos en la tabla 'BASE_DE_DATOSDataSet.REGISTRO_DE_MANTENIMIENTO' Puede moverla o quitarla según sea necesario.
        Me.REGISTRO_DE_MANTENIMIENTOTableAdapter.Fill(Me.BASE_DE_DATOSDataSet.REGISTRO_DE_MANTENIMIENTO)
        'TODO: esta línea de código carga datos en la tabla 'BASE_DE_DATOSDataSet.HOJA_DE_VIDA_DE_LA_MAQUINA' Puede moverla o quitarla según sea necesario.
        Me.HOJA_DE_VIDA_DE_LA_MAQUINATableAdapter.Fill(Me.BASE_DE_DATOSDataSet.HOJA_DE_VIDA_DE_LA_MAQUINA)
        'TODO: esta línea de código carga datos en la tabla 'BASE_DE_DATOSDataSet.REGISTRO_DE_MANTENIMIENTO' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim filt
        filt = String.Format("CODIGO = '{0}'", ListBox1.Text)
        Dim filt2
        filt2 = String.Format("CODAP = '{0}'", ListBox1.Text)
        HOJA_DE_VIDA_DE_LA_MAQUINABindingSource.Filter = filt
        REGISTRO_DE_MANTENIMIENTOBindingSource.Filter = filt2
        Dim dv As DataView = CType(HOJA_DE_VIDA_DE_LA_MAQUINABindingSource.List, DataView)
        Dim dt As DataTable = dv.ToTable()
        Dim dv1 As DataView = CType(REGISTRO_DE_MANTENIMIENTOBindingSource.List, DataView)
        Dim dt1 As DataTable = dv1.ToTable()
        Dim Suma As Object
        'convert(dt1, 'System.Double')
        Suma = dt1.Compute("SUM(TIEMPO)", Nothing)
        Dim SUMAN As Double
        SUMAN = Convert.ToDouble(Suma.ToString) / 24
        Dim Fecha1 As Date = #1/1/2013#
        Dim Fecha2 As Date = Now
        Dim M As Long = DateDiff(DateInterval.Day, Fecha1, Fecha2)
        Dim TMEF As Double = M / SUMAN
        TextBox1.Text = TMEF
        Dim TMDR As Double = SUMAN / Convert.ToDouble(dt1.Rows.Count)
        TextBox2.Text = TMDR
        TextBox3.Text = Convert.ToDouble(dt1.Rows.Count)
        Dim K As Long = M - SUMAN
        TextBox4.Text = K / M * 100
        Dim lambda As Double = Convert.ToDouble(dt1.Rows.Count) / 360
        TextBox5.Text = lambda
        Dim ft As Double = lambda * Math.Exp(lambda * 360) * 100
        TextBox6.Text = ft
    End Sub


    Private Sub REGISTRO_DE_MANTENIMIENTOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.REGISTRO_DE_MANTENIMIENTOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BASE_DE_DATOSDataSet)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Indicadores_Load(Me, New System.EventArgs)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        Process.Start("Ayuda.docx")
    End Sub
End Class
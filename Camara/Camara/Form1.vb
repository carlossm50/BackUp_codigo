Public Class Capturar

    Private Sub BtGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtGuardar.Click
        If PbTomarFoto.Image Is Nothing = False Then
            SFDilalog.ShowDialog()
        Else
            MsgBox("No Hay Foto Para Guardar", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub BtCapturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCapturar.Click
        PbTomarFoto.Image = WCCamara1.Imagen
    End Sub

    Private Sub Capturar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        WCCamara1.Start()
        WCCamara1.Start()


        ''Timer1.Interval = 1000
        ''Timer1.Start()

    End Sub

    Private Sub SFDilalog_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SFDilalog.FileOk
        PbTomarFoto.Image.Save(SFDilalog.FileName)
    End Sub



    Private Sub OFDialogVerFoto_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OFDialogVerFoto.FileOk
        PbVerFoto.ImageLocation = OFDialogVerFoto.FileName
    End Sub
    Private Sub BtAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAbrir.Click
        OFDialogVerFoto.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If WCCamara1.Imagen Is Nothing = False And TabControl1.SelectedIndex = 0 Then
            BtCapturar_Click(sender, e)
        End If

    End Sub
End Class

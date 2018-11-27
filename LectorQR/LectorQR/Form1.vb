Imports Aforge.Video.DirectShow
Imports BarcodeLib.BarcodeReader

Public Class Form1

    Private dispositivos As FilterInfoCollection
    Private fuenteVideo As VideoCaptureDevice



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dispositivos = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        For Each x As FilterInfo In dispositivos
            ComboBox1.Items.Add(x.Name)
        Next
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer1.Start()
        fuenteVideo = New VideoCaptureDevice(dispositivos(ComboBox1.SelectedIndex).MonikerString)
        VideoSourcePlayer1.VideoSource = fuenteVideo
        VideoSourcePlayer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        VideoSourcePlayer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If VideoSourcePlayer1.GetCurrentVideoFrame() IsNot Nothing Then
            Dim img As New Bitmap(VideoSourcePlayer1.GetCurrentVideoFrame)
            Dim resultados As String() = BarcodeReader.read(img, BarcodeReader.QRCODE)
            img.Dispose()
            If resultados IsNot Nothing AndAlso resultados.Count > 0 Then
                ListBox1.Items.Add(resultados(0))
            End If
        End If
    End Sub
End Class

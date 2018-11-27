<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Capturar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PbTomarFoto = New System.Windows.Forms.PictureBox()
        Me.BtCapturar = New System.Windows.Forms.Button()
        Me.BtGuardar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WCCamara1 = New WebCAM.WebCam()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtAbrir = New System.Windows.Forms.Button()
        Me.PbVerFoto = New System.Windows.Forms.PictureBox()
        Me.SFDilalog = New System.Windows.Forms.SaveFileDialog()
        Me.OFDialogVerFoto = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PbTomarFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PbVerFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PbTomarFoto
        '
        Me.PbTomarFoto.Location = New System.Drawing.Point(457, 22)
        Me.PbTomarFoto.Name = "PbTomarFoto"
        Me.PbTomarFoto.Size = New System.Drawing.Size(306, 240)
        Me.PbTomarFoto.TabIndex = 1
        Me.PbTomarFoto.TabStop = False
        '
        'BtCapturar
        '
        Me.BtCapturar.Location = New System.Drawing.Point(627, 279)
        Me.BtCapturar.Name = "BtCapturar"
        Me.BtCapturar.Size = New System.Drawing.Size(75, 23)
        Me.BtCapturar.TabIndex = 2
        Me.BtCapturar.Text = "Capturar"
        Me.BtCapturar.UseVisualStyleBackColor = True
        '
        'BtGuardar
        '
        Me.BtGuardar.Location = New System.Drawing.Point(516, 279)
        Me.BtGuardar.Name = "BtGuardar"
        Me.BtGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtGuardar.TabIndex = 3
        Me.BtGuardar.Text = "Guardar"
        Me.BtGuardar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(815, 369)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WCCamara1)
        Me.TabPage1.Controls.Add(Me.BtGuardar)
        Me.TabPage1.Controls.Add(Me.PbTomarFoto)
        Me.TabPage1.Controls.Add(Me.BtCapturar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(807, 343)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WCCamara1
        '
        Me.WCCamara1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WCCamara1.Imagen = Nothing
        Me.WCCamara1.Location = New System.Drawing.Point(42, 22)
        Me.WCCamara1.MilisegundosCaptura = 100
        Me.WCCamara1.Name = "WCCamara1"
        Me.WCCamara1.Size = New System.Drawing.Size(320, 240)
        Me.WCCamara1.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtAbrir)
        Me.TabPage2.Controls.Add(Me.PbVerFoto)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(807, 343)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtAbrir
        '
        Me.BtAbrir.Location = New System.Drawing.Point(372, 280)
        Me.BtAbrir.Name = "BtAbrir"
        Me.BtAbrir.Size = New System.Drawing.Size(75, 23)
        Me.BtAbrir.TabIndex = 3
        Me.BtAbrir.Text = "Abrir"
        Me.BtAbrir.UseVisualStyleBackColor = True
        '
        'PbVerFoto
        '
        Me.PbVerFoto.Location = New System.Drawing.Point(265, 40)
        Me.PbVerFoto.Name = "PbVerFoto"
        Me.PbVerFoto.Size = New System.Drawing.Size(276, 198)
        Me.PbVerFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbVerFoto.TabIndex = 2
        Me.PbVerFoto.TabStop = False
        '
        'SFDilalog
        '
        Me.SFDilalog.Filter = "Imagenes|*.bmp;*.jpg"
        '
        'OFDialogVerFoto
        '
        Me.OFDialogVerFoto.FileName = "OpenFileDialog1"
        Me.OFDialogVerFoto.Filter = "Imagenes|*.bmp;*.jpg"
        '
        'Timer1
        '
        '
        'Capturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 369)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Capturar"
        Me.Text = "Captuar Foto"
        CType(Me.PbTomarFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PbVerFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WCCamara As WebCAM.WebCam
    Friend WithEvents PbTomarFoto As System.Windows.Forms.PictureBox
    Friend WithEvents BtCapturar As System.Windows.Forms.Button
    Friend WithEvents BtGuardar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BtAbrir As System.Windows.Forms.Button
    Friend WithEvents PbVerFoto As System.Windows.Forms.PictureBox
    Friend WithEvents SFDilalog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OFDialogVerFoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents WCCamara1 As WebCAM.WebCam
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class

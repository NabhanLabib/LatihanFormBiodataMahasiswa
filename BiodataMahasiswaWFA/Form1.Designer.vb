<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextNama = New TextBox()
        TextProdi = New TextBox()
        TextNamaKampus = New TextBox()
        TextHobi = New TextBox()
        ButtonTampilkan = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        LabelHasil = New Label()
        SuspendLayout()
        ' 
        ' TextNama
        ' 
        TextNama.Location = New Point(395, 142)
        TextNama.Name = "TextNama"
        TextNama.Size = New Size(326, 39)
        TextNama.TabIndex = 0
        ' 
        ' TextProdi
        ' 
        TextProdi.Location = New Point(395, 201)
        TextProdi.Name = "TextProdi"
        TextProdi.Size = New Size(326, 39)
        TextProdi.TabIndex = 1
        ' 
        ' TextNamaKampus
        ' 
        TextNamaKampus.Location = New Point(395, 260)
        TextNamaKampus.Name = "TextNamaKampus"
        TextNamaKampus.Size = New Size(326, 39)
        TextNamaKampus.TabIndex = 2
        ' 
        ' TextHobi
        ' 
        TextHobi.Location = New Point(395, 321)
        TextHobi.Name = "TextHobi"
        TextHobi.Size = New Size(326, 39)
        TextHobi.TabIndex = 3
        ' 
        ' ButtonTampilkan
        ' 
        ButtonTampilkan.Location = New Point(563, 386)
        ButtonTampilkan.Name = "ButtonTampilkan"
        ButtonTampilkan.Size = New Size(158, 68)
        ButtonTampilkan.TabIndex = 4
        ButtonTampilkan.Text = "Tampilkan"
        ButtonTampilkan.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(215, 145)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 32)
        Label1.TabIndex = 5
        Label1.Text = "Nama :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(215, 201)
        Label2.Name = "Label2"
        Label2.Size = New Size(177, 32)
        Label2.TabIndex = 6
        Label2.Text = "Program Studi :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(215, 260)
        Label3.Name = "Label3"
        Label3.Size = New Size(181, 32)
        Label3.TabIndex = 7
        Label3.Text = "Nama Kampus :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(215, 321)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 32)
        Label4.TabIndex = 8
        Label4.Text = "Hobi :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(230, 26)
        Label5.Name = "Label5"
        Label5.Size = New Size(465, 50)
        Label5.TabIndex = 9
        Label5.Text = "Masukkan Data Diri Anda"
        ' 
        ' LabelHasil
        ' 
        LabelHasil.AutoSize = True
        LabelHasil.BorderStyle = BorderStyle.Fixed3D
        LabelHasil.Font = New Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelHasil.ImageAlign = ContentAlignment.BottomCenter
        LabelHasil.Location = New Point(141, 531)
        LabelHasil.Name = "LabelHasil"
        LabelHasil.Size = New Size(2, 42)
        LabelHasil.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(998, 716)
        Controls.Add(LabelHasil)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ButtonTampilkan)
        Controls.Add(TextHobi)
        Controls.Add(TextNamaKampus)
        Controls.Add(TextProdi)
        Controls.Add(TextNama)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextNama As TextBox
    Friend WithEvents TextProdi As TextBox
    Friend WithEvents TextNamaKampus As TextBox
    Friend WithEvents TextHobi As TextBox
    Friend WithEvents ButtonTampilkan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelHasil As Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YourProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YourProfile))
        lblwelcome = New Label()
        PictureBox1 = New PictureBox()
        btnYOURPROFILECLOSE = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblwelcome
        ' 
        lblwelcome.AutoSize = True
        lblwelcome.Location = New Point(155, 12)
        lblwelcome.Name = "lblwelcome"
        lblwelcome.Size = New Size(165, 15)
        lblwelcome.TabIndex = 0
        lblwelcome.Text = "you are successfully logged in"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(137, 143)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btnYOURPROFILECLOSE
        ' 
        btnYOURPROFILECLOSE.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnYOURPROFILECLOSE.ForeColor = Color.Red
        btnYOURPROFILECLOSE.Location = New Point(173, 117)
        btnYOURPROFILECLOSE.Name = "btnYOURPROFILECLOSE"
        btnYOURPROFILECLOSE.Size = New Size(125, 28)
        btnYOURPROFILECLOSE.TabIndex = 2
        btnYOURPROFILECLOSE.Text = "CLOSE"
        btnYOURPROFILECLOSE.UseVisualStyleBackColor = True
        ' 
        ' YourProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(333, 200)
        Controls.Add(btnYOURPROFILECLOSE)
        Controls.Add(PictureBox1)
        Controls.Add(lblwelcome)
        Name = "YourProfile"
        Text = "Your Profile"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblwelcome As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnYOURPROFILECLOSE As Button
End Class

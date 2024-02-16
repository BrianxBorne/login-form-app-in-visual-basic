<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLOGIN = New Button()
        btnCLOSE = New Button()
        lblNAME = New Label()
        lblPASSWORD = New Label()
        lblTITLE = New Label()
        txtUSERNAME = New TextBox()
        txtPASSWORD = New TextBox()
        SuspendLayout()
        ' 
        ' btnLOGIN
        ' 
        btnLOGIN.Font = New Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLOGIN.ForeColor = Color.ForestGreen
        btnLOGIN.Location = New Point(41, 188)
        btnLOGIN.Name = "btnLOGIN"
        btnLOGIN.Size = New Size(91, 26)
        btnLOGIN.TabIndex = 0
        btnLOGIN.Text = "LOGIN"
        btnLOGIN.UseVisualStyleBackColor = True
        ' 
        ' btnCLOSE
        ' 
        btnCLOSE.Font = New Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCLOSE.ForeColor = Color.Red
        btnCLOSE.Location = New Point(238, 188)
        btnCLOSE.Name = "btnCLOSE"
        btnCLOSE.Size = New Size(87, 26)
        btnCLOSE.TabIndex = 1
        btnCLOSE.Text = "CLOSE"
        btnCLOSE.UseVisualStyleBackColor = True
        ' 
        ' lblNAME
        ' 
        lblNAME.AutoSize = True
        lblNAME.Font = New Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNAME.Location = New Point(41, 62)
        lblNAME.Name = "lblNAME"
        lblNAME.Size = New Size(123, 22)
        lblNAME.TabIndex = 2
        lblNAME.Text = "USER NAME"
        ' 
        ' lblPASSWORD
        ' 
        lblPASSWORD.AutoSize = True
        lblPASSWORD.Font = New Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPASSWORD.Location = New Point(41, 132)
        lblPASSWORD.Name = "lblPASSWORD"
        lblPASSWORD.Size = New Size(117, 22)
        lblPASSWORD.TabIndex = 3
        lblPASSWORD.Text = "PASSWORD"
        ' 
        ' lblTITLE
        ' 
        lblTITLE.AutoSize = True
        lblTITLE.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTITLE.ForeColor = Color.LimeGreen
        lblTITLE.Location = New Point(112, 9)
        lblTITLE.Name = "lblTITLE"
        lblTITLE.Size = New Size(142, 25)
        lblTITLE.TabIndex = 4
        lblTITLE.Text = "LOGIN FORM"
        ' 
        ' txtUSERNAME
        ' 
        txtUSERNAME.Location = New Point(195, 62)
        txtUSERNAME.Name = "txtUSERNAME"
        txtUSERNAME.Size = New Size(130, 23)
        txtUSERNAME.TabIndex = 5
        txtUSERNAME.Text = "gitLO"
        ' 
        ' txtPASSWORD
        ' 
        txtPASSWORD.Location = New Point(195, 124)
        txtPASSWORD.Name = "txtPASSWORD"
        txtPASSWORD.PasswordChar = "*"c
        txtPASSWORD.Size = New Size(130, 23)
        txtPASSWORD.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(359, 244)
        Controls.Add(txtPASSWORD)
        Controls.Add(txtUSERNAME)
        Controls.Add(lblTITLE)
        Controls.Add(lblPASSWORD)
        Controls.Add(lblNAME)
        Controls.Add(btnCLOSE)
        Controls.Add(btnLOGIN)
        Name = "Form1"
        Text = "login form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLOGIN As Button
    Friend WithEvents btnCLOSE As Button
    Friend WithEvents lblNAME As Label
    Friend WithEvents lblPASSWORD As Label
    Friend WithEvents lblTITLE As Label
    Friend WithEvents txtUSERNAME As TextBox
    Friend WithEvents txtPASSWORD As TextBox

End Class

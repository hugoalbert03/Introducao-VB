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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        FontDialog1 = New FontDialog()
        txtRgm = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(213, 86)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(246, 29)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(213, 146)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(389, 29)
        TextBox2.TabIndex = 1
        ' 
        ' txtRgm
        ' 
        txtRgm.AutoSize = True
        txtRgm.Location = New Point(151, 89)
        txtRgm.Name = "txtRgm"
        txtRgm.Size = New Size(45, 21)
        txtRgm.TabIndex = 2
        txtRgm.Text = "RGM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.6F)
        Label2.Location = New Point(79, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 25)
        Label2.TabIndex = 3
        Label2.Text = "ALUNO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.6F)
        Label3.Location = New Point(79, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 25)
        Label3.TabIndex = 4
        Label3.Text = "PROFESSOR"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(151, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 21)
        Label4.TabIndex = 5
        Label4.Text = "Nome"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(213, 289)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(389, 29)
        TextBox3.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(151, 292)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 21)
        Label5.TabIndex = 7
        Label5.Text = "Nome"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(151, 353)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 21)
        Label6.TabIndex = 8
        Label6.Text = "Título"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(213, 356)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(246, 29)
        TextBox4.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(657, 101)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 10
        Button1.Text = "Exibir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(657, 318)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 11
        Button2.Text = "Exibir"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtRgm)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents txtRgm As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class

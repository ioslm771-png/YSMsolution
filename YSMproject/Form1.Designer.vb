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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Aldhabi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(206, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 44)
        Label1.TabIndex = 0
        Label1.Text = ":المستوى"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Aldhabi", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(190, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 40)
        Label2.TabIndex = 1
        Label2.Text = ":أسم الطالب "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Aldhabi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(208, 124)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 44)
        Label3.TabIndex = 2
        Label3.Text = ":التحصص"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ButtonHighlight
        Label4.Font = New Font("Aldhabi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(179, 175)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 42)
        Label4.TabIndex = 3
        Label4.Text = ":العام الدراسي "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonHighlight
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Font = New Font("Aldhabi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(11, 26)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 44)
        Label5.TabIndex = 4
        Label5.Text = "يسلم صالح أحمد عامر "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ButtonHighlight
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.Font = New Font("Aldhabi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(49, 74)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 44)
        Label6.TabIndex = 5
        Label6.Text = "الثاني-عام"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ButtonHighlight
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Font = New Font("Aldhabi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(11, 124)
        Label7.Name = "Label7"
        Label7.Size = New Size(155, 44)
        Label7.TabIndex = 6
        Label7.Text = "(IT)تقنية معلومات"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ButtonHighlight
        Label8.BorderStyle = BorderStyle.Fixed3D
        Label8.Font = New Font("Aldhabi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(31, 175)
        Label8.Name = "Label8"
        Label8.Size = New Size(107, 44)
        Label8.TabIndex = 7
        Label8.Text = "2025-2026م"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaptionText
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Aldhabi", 12.25F, FontStyle.Bold)
        GroupBox1.ForeColor = SystemColors.ButtonHighlight
        GroupBox1.Location = New Point(269, 89)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(303, 229)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "بطاقة تعريف "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SERVICES_DETAILS_FORM
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
        GroupBox1 = New GroupBox()
        ComboBox3 = New ComboBox()
        Label5 = New Label()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        NumericUpDown2 = New NumericUpDown()
        Label4 = New Label()
        NumericUpDown1 = New NumericUpDown()
        Label3 = New Label()
        GroupBox3 = New GroupBox()
        Button2 = New Button()
        Button1 = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox3)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(30, 33)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(587, 152)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "DRILLING SERVICES"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"PLASTIC PIPES", "METALLIC PIPES"})
        ComboBox3.Location = New Point(437, 29)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(121, 23)
        ComboBox3.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Blue
        Label5.Location = New Point(349, 29)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 17)
        Label5.TabIndex = 4
        Label5.Text = "TYPE OF PIPE"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"SUBMERSIBLE PUMP", "ELECTRIC PUMP", "SOLAR PUMP", "HAND PUMP"})
        ComboBox2.Location = New Point(142, 84)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(10, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 17)
        Label2.TabIndex = 2
        Label2.Text = "TYPE OF PUMP"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"SYMMETRIC DRILLING", "CORE DRILLING", "GEO-TECHNICAL"})
        ComboBox1.Location = New Point(138, 25)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label1.Location = New Point(10, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 17)
        Label1.TabIndex = 0
        Label1.Text = "TYPE OF DRILLING"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(NumericUpDown2)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(NumericUpDown1)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(30, 232)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(564, 100)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "BOREHOLE SERVICES"
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Hexadecimal = True
        NumericUpDown2.Location = New Point(148, 72)
        NumericUpDown2.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(120, 23)
        NumericUpDown2.TabIndex = 3
        NumericUpDown2.ThousandsSeparator = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(10, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 15)
        Label4.TabIndex = 2
        Label4.Text = "TANKS DETAILS"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(148, 34)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 15)
        Label3.TabIndex = 0
        Label3.Text = "DEPTH OF BOREHOLE"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Button2)
        GroupBox3.Controls.Add(Button1)
        GroupBox3.Location = New Point(30, 377)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(431, 100)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "OTHER SERVICES"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(22, 77)
        Button2.Name = "Button2"
        Button2.Size = New Size(140, 23)
        Button2.TabIndex = 3
        Button2.Text = "PUMP MAINTANANCE"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(22, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 23)
        Button1.TabIndex = 2
        Button1.Text = "PLUMBING SERVICES"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(56, 545)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(51, 19)
        RadioButton1.TabIndex = 3
        RadioButton1.TabStop = True
        RadioButton1.Text = "SAVE"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(328, 545)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(66, 19)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "SUBMIT"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' SERVICES_DETAILS_FORM
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 517)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "SERVICES_DETAILS_FORM"
        Text = "SERVICES_DETAILS_FORM"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class

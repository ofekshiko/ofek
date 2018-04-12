<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.title = New System.Windows.Forms.Label()
        Me.model = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pr1 = New System.Windows.Forms.TextBox()
        Me.cat1 = New System.Windows.Forms.ComboBox()
        Me.cou1 = New System.Windows.Forms.TextBox()
        Me.model2 = New System.Windows.Forms.TextBox()
        Me.com2 = New System.Windows.Forms.TextBox()
        Me.pr = New System.Windows.Forms.Label()
        Me.cat = New System.Windows.Forms.Label()
        Me.cou = New System.Windows.Forms.Label()
        Me.com1 = New System.Windows.Forms.Label()
        Me.model1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.title.Location = New System.Drawing.Point(434, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(225, 29)
        Me.title.TabIndex = 0
        Me.title.Text = ":טופס עדכון דגם רכב"
        '
        'model
        '
        Me.model.AutoSize = True
        Me.model.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.model.Location = New System.Drawing.Point(931, 67)
        Me.model.Name = "model"
        Me.model.Size = New System.Drawing.Size(86, 20)
        Me.model.TabIndex = 1
        Me.model.Text = ":דגם הרכב"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(769, 66)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(156, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.pr1)
        Me.GroupBox1.Controls.Add(Me.cat1)
        Me.GroupBox1.Controls.Add(Me.cou1)
        Me.GroupBox1.Controls.Add(Me.model2)
        Me.GroupBox1.Controls.Add(Me.com2)
        Me.GroupBox1.Controls.Add(Me.pr)
        Me.GroupBox1.Controls.Add(Me.cat)
        Me.GroupBox1.Controls.Add(Me.cou)
        Me.GroupBox1.Controls.Add(Me.com1)
        Me.GroupBox1.Controls.Add(Me.model1)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1003, 304)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(99, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 32)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "עדכן דגם רכב"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pr1
        '
        Me.pr1.Location = New System.Drawing.Point(35, 194)
        Me.pr1.Name = "pr1"
        Me.pr1.Size = New System.Drawing.Size(261, 20)
        Me.pr1.TabIndex = 13
        '
        'cat1
        '
        Me.cat1.FormattingEnabled = True
        Me.cat1.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G"})
        Me.cat1.Location = New System.Drawing.Point(175, 153)
        Me.cat1.Name = "cat1"
        Me.cat1.Size = New System.Drawing.Size(121, 21)
        Me.cat1.TabIndex = 12
        '
        'cou1
        '
        Me.cou1.Location = New System.Drawing.Point(35, 114)
        Me.cou1.Name = "cou1"
        Me.cou1.Size = New System.Drawing.Size(261, 20)
        Me.cou1.TabIndex = 11
        '
        'model2
        '
        Me.model2.Location = New System.Drawing.Point(35, 74)
        Me.model2.Name = "model2"
        Me.model2.Size = New System.Drawing.Size(261, 20)
        Me.model2.TabIndex = 10
        '
        'com2
        '
        Me.com2.Location = New System.Drawing.Point(35, 34)
        Me.com2.Name = "com2"
        Me.com2.Size = New System.Drawing.Size(261, 20)
        Me.com2.TabIndex = 9
        '
        'pr
        '
        Me.pr.AutoSize = True
        Me.pr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.pr.Location = New System.Drawing.Point(852, 194)
        Me.pr.Name = "pr"
        Me.pr.Size = New System.Drawing.Size(145, 20)
        Me.pr.TabIndex = 8
        Me.pr.Text = ":מחיר השכרה ליום"
        '
        'cat
        '
        Me.cat.AutoSize = True
        Me.cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cat.Location = New System.Drawing.Point(871, 154)
        Me.cat.Name = "cat"
        Me.cat.Size = New System.Drawing.Size(126, 20)
        Me.cat.TabIndex = 7
        Me.cat.Text = ":קטגוריית הרכב"
        '
        'cou
        '
        Me.cou.AutoSize = True
        Me.cou.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cou.Location = New System.Drawing.Point(909, 114)
        Me.cou.Name = "cou"
        Me.cou.Size = New System.Drawing.Size(88, 20)
        Me.cou.TabIndex = 6
        Me.cou.Text = ":ארץ ייצור"
        '
        'com1
        '
        Me.com1.AutoSize = True
        Me.com1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.com1.Location = New System.Drawing.Point(897, 34)
        Me.com1.Name = "com1"
        Me.com1.Size = New System.Drawing.Size(100, 20)
        Me.com1.TabIndex = 4
        Me.com1.Text = ":חברת הרכב"
        '
        'model1
        '
        Me.model1.AutoSize = True
        Me.model1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.model1.Location = New System.Drawing.Point(911, 74)
        Me.model1.Name = "model1"
        Me.model1.Size = New System.Drawing.Size(86, 20)
        Me.model1.TabIndex = 5
        Me.model1.Text = ":דגם הרכב"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(1035, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 27)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 463)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.model)
        Me.Controls.Add(Me.title)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents model As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cat As System.Windows.Forms.Label
    Friend WithEvents cou As System.Windows.Forms.Label
    Friend WithEvents com1 As System.Windows.Forms.Label
    Friend WithEvents model1 As System.Windows.Forms.Label
    Friend WithEvents pr As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pr1 As System.Windows.Forms.TextBox
    Friend WithEvents cat1 As System.Windows.Forms.ComboBox
    Friend WithEvents cou1 As System.Windows.Forms.TextBox
    Friend WithEvents model2 As System.Windows.Forms.TextBox
    Friend WithEvents com2 As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

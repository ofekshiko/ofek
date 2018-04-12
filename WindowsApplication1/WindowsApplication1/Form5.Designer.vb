<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.title = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gear1 = New System.Windows.Forms.Label()
        Me.gear = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cat1 = New System.Windows.Forms.Label()
        Me.com1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cat = New System.Windows.Forms.Label()
        Me.com = New System.Windows.Forms.Label()
        Me.model = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.BackColor = System.Drawing.Color.Silver
        Me.title.Font = New System.Drawing.Font("Miriam Fixed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.title.ForeColor = System.Drawing.Color.Red
        Me.title.Location = New System.Drawing.Point(361, 19)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(237, 19)
        Me.title.TabIndex = 1
        Me.title.Text = ":טופס מחיקת דגם רכב"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gear1)
        Me.GroupBox1.Controls.Add(Me.gear)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cat1)
        Me.GroupBox1.Controls.Add(Me.com1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cat)
        Me.GroupBox1.Controls.Add(Me.com)
        Me.GroupBox1.Location = New System.Drawing.Point(391, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 215)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'gear1
        '
        Me.gear1.AutoSize = True
        Me.gear1.Font = New System.Drawing.Font("Miriam Fixed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.gear1.ForeColor = System.Drawing.Color.Red
        Me.gear1.Location = New System.Drawing.Point(253, 114)
        Me.gear1.Name = "gear1"
        Me.gear1.Size = New System.Drawing.Size(0, 16)
        Me.gear1.TabIndex = 8
        '
        'gear
        '
        Me.gear.AutoSize = True
        Me.gear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.gear.Location = New System.Drawing.Point(455, 106)
        Me.gear.Name = "gear"
        Me.gear.Size = New System.Drawing.Size(141, 24)
        Me.gear.TabIndex = 7
        Me.gear.Text = ":ארץ יצור הרכב"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "מחק"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Miriam Fixed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(253, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 16)
        Me.Label6.TabIndex = 5
        '
        'cat1
        '
        Me.cat1.AutoSize = True
        Me.cat1.Font = New System.Drawing.Font("Miriam Fixed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cat1.ForeColor = System.Drawing.Color.Red
        Me.cat1.Location = New System.Drawing.Point(253, 63)
        Me.cat1.Name = "cat1"
        Me.cat1.Size = New System.Drawing.Size(0, 16)
        Me.cat1.TabIndex = 4
        '
        'com1
        '
        Me.com1.AutoSize = True
        Me.com1.Font = New System.Drawing.Font("Miriam Fixed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.com1.ForeColor = System.Drawing.Color.Red
        Me.com1.Location = New System.Drawing.Point(253, 24)
        Me.com1.Name = "com1"
        Me.com1.Size = New System.Drawing.Size(0, 16)
        Me.com1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.Location = New System.Drawing.Point(452, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = ":מחיר הרכב ליום"
        '
        'cat
        '
        Me.cat.AutoSize = True
        Me.cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cat.Location = New System.Drawing.Point(460, 55)
        Me.cat.Name = "cat"
        Me.cat.Size = New System.Drawing.Size(142, 24)
        Me.cat.TabIndex = 1
        Me.cat.Text = ":קטגוריית הרכב"
        '
        'com
        '
        Me.com.AutoSize = True
        Me.com.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.com.Location = New System.Drawing.Point(484, 16)
        Me.com.Name = "com"
        Me.com.Size = New System.Drawing.Size(112, 24)
        Me.com.TabIndex = 0
        Me.com.Text = ":חברת הרכב"
        '
        'model
        '
        Me.model.AutoSize = True
        Me.model.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.model.Location = New System.Drawing.Point(841, 66)
        Me.model.Name = "model"
        Me.model.Size = New System.Drawing.Size(98, 24)
        Me.model.TabIndex = 5
        Me.model.Text = ":דגם הרכב"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(647, 69)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(188, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(946, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 27)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1005, 405)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.model)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.title)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cat1 As System.Windows.Forms.Label
    Friend WithEvents com1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cat As System.Windows.Forms.Label
    Friend WithEvents com As System.Windows.Forms.Label
    Friend WithEvents model As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents gear1 As System.Windows.Forms.Label
    Friend WithEvents gear As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

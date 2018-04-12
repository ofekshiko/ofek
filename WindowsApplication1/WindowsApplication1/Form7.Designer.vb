<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.title = New System.Windows.Forms.Label()
        Me.order = New System.Windows.Forms.Label()
        Me.order1 = New System.Windows.Forms.Label()
        Me.rent = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.num = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cat = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.com = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.pr = New System.Windows.Forms.Label()
        Me.pr1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.days = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.Maroon
        Me.title.Location = New System.Drawing.Point(474, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(140, 26)
        Me.title.TabIndex = 0
        Me.title.Text = "השכרת רכב"
        '
        'order
        '
        Me.order.AutoSize = True
        Me.order.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.order.ForeColor = System.Drawing.Color.Black
        Me.order.Location = New System.Drawing.Point(878, 67)
        Me.order.Name = "order"
        Me.order.Size = New System.Drawing.Size(110, 20)
        Me.order.TabIndex = 1
        Me.order.Text = "- מספר הזמנה"
        '
        'order1
        '
        Me.order1.AutoSize = True
        Me.order1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.order1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.order1.Location = New System.Drawing.Point(767, 67)
        Me.order1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.order1.Name = "order1"
        Me.order1.Size = New System.Drawing.Size(0, 20)
        Me.order1.TabIndex = 2
        '
        'rent
        '
        Me.rent.AutoSize = True
        Me.rent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rent.Location = New System.Drawing.Point(878, 118)
        Me.rent.Name = "rent"
        Me.rent.Size = New System.Drawing.Size(128, 20)
        Me.rent.TabIndex = 3
        Me.rent.Text = ":תאריך ההשכרה"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(656, 117)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(187, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'num
        '
        Me.num.AutoSize = True
        Me.num.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num.Location = New System.Drawing.Point(878, 212)
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(102, 20)
        Me.num.TabIndex = 5
        Me.num.Text = ":פרטי הלקוח"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(656, 211)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox1.Size = New System.Drawing.Size(187, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.Text = "בחר.."
        '
        'cat
        '
        Me.cat.AutoSize = True
        Me.cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cat.Location = New System.Drawing.Point(878, 262)
        Me.cat.Name = "cat"
        Me.cat.Size = New System.Drawing.Size(126, 20)
        Me.cat.TabIndex = 7
        Me.cat.Text = ":קטגוריית הרכב"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G"})
        Me.ComboBox2.Location = New System.Drawing.Point(758, 261)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox2.Size = New System.Drawing.Size(85, 21)
        Me.ComboBox2.TabIndex = 8
        Me.ComboBox2.Text = "בחר.."
        '
        'com
        '
        Me.com.AutoSize = True
        Me.com.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.com.Location = New System.Drawing.Point(878, 308)
        Me.com.Name = "com"
        Me.com.Size = New System.Drawing.Size(100, 20)
        Me.com.TabIndex = 9
        Me.com.Text = ":חברת הרכב"
        Me.com.Visible = False
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(656, 307)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox3.Size = New System.Drawing.Size(187, 21)
        Me.ComboBox3.TabIndex = 10
        Me.ComboBox3.Text = "בחר.."
        Me.ComboBox3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(878, 392)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = ":גיר"
        Me.Label1.Visible = False
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"a", "m"})
        Me.ComboBox4.Location = New System.Drawing.Point(758, 391)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox4.Size = New System.Drawing.Size(85, 21)
        Me.ComboBox4.TabIndex = 12
        Me.ComboBox4.Text = "בחר.."
        Me.ComboBox4.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(733, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "?"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(878, 350)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = ":דגם הרכב"
        Me.Label3.Visible = False
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(656, 349)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox5.Size = New System.Drawing.Size(187, 21)
        Me.ComboBox5.TabIndex = 15
        Me.ComboBox5.Text = "בחר.."
        Me.ComboBox5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(878, 429)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = ":רכבים זמינים במלאי"
        Me.Label4.Visible = False
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(656, 428)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox6.Size = New System.Drawing.Size(187, 21)
        Me.ComboBox6.TabIndex = 17
        Me.ComboBox6.Text = "בחר.."
        Me.ComboBox6.Visible = False
        '
        'pr
        '
        Me.pr.AutoSize = True
        Me.pr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pr.ForeColor = System.Drawing.Color.Brown
        Me.pr.Location = New System.Drawing.Point(229, 44)
        Me.pr.Name = "pr"
        Me.pr.Size = New System.Drawing.Size(173, 18)
        Me.pr.TabIndex = 18
        Me.pr.Text = ":סה""כ מחיר - ללא מע""מ"
        Me.pr.Visible = False
        '
        'pr1
        '
        Me.pr1.AutoSize = True
        Me.pr1.Font = New System.Drawing.Font("Miriam Fixed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.pr1.Location = New System.Drawing.Point(54, 47)
        Me.pr1.Name = "pr1"
        Me.pr1.Size = New System.Drawing.Size(0, 16)
        Me.pr1.TabIndex = 19
        Me.pr1.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(656, 164)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(187, 20)
        Me.DateTimePicker2.TabIndex = 20
        '
        'days
        '
        Me.days.AutoSize = True
        Me.days.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.days.Location = New System.Drawing.Point(506, 144)
        Me.days.Name = "days"
        Me.days.Size = New System.Drawing.Size(0, 20)
        Me.days.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(694, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 41)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "חשב מחיר"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.pr)
        Me.GroupBox1.Controls.Add(Me.pr1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 159)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Miriam Fixed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label7.Location = New System.Drawing.Point(54, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Brown
        Me.Label6.Location = New System.Drawing.Point(224, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 18)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = ":סה""כ מחיר - כולל מע""מ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(571, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "- סה""כ ימים"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(136, 476)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 41)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "בצע הזמנה"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(1014, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(47, 27)
        Me.Button3.TabIndex = 26
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1073, 624)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.days)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.com)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.cat)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.num)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.rent)
        Me.Controls.Add(Me.order1)
        Me.Controls.Add(Me.order)
        Me.Controls.Add(Me.title)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form7"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents order As System.Windows.Forms.Label
    Friend WithEvents order1 As System.Windows.Forms.Label
    Friend WithEvents rent As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents num As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cat As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents com As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents pr As System.Windows.Forms.Label
    Friend WithEvents pr1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents days As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numc1 = New System.Windows.Forms.Label()
        Me.numc = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.numh = New System.Windows.Forms.Label()
        Me.numn = New System.Windows.Forms.Label()
        Me.numn3 = New System.Windows.Forms.ComboBox()
        Me.numh3 = New System.Windows.Forms.ComboBox()
        Me.numh2 = New System.Windows.Forms.TextBox()
        Me.numn2 = New System.Windows.Forms.TextBox()
        Me.email2 = New System.Windows.Forms.TextBox()
        Me.email4 = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.Label()
        Me.email3 = New System.Windows.Forms.Label()
        Me.num = New System.Windows.Forms.Label()
        Me.street = New System.Windows.Forms.Label()
        Me.city = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.bd = New System.Windows.Forms.Label()
        Me.lname = New System.Windows.Forms.Label()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.street2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.id2 = New System.Windows.Forms.TextBox()
        Me.city2 = New System.Windows.Forms.TextBox()
        Me.lname2 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(567, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ":טופס עדכון לקוח"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Miriam Fixed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(1100, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":תעודת זהות"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(887, 73)
        Me.TextBox1.MaxLength = 9
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(744, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "חפש"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numc1)
        Me.GroupBox1.Controls.Add(Me.numc)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.numh)
        Me.GroupBox1.Controls.Add(Me.numn)
        Me.GroupBox1.Controls.Add(Me.numn3)
        Me.GroupBox1.Controls.Add(Me.numh3)
        Me.GroupBox1.Controls.Add(Me.numh2)
        Me.GroupBox1.Controls.Add(Me.numn2)
        Me.GroupBox1.Controls.Add(Me.email2)
        Me.GroupBox1.Controls.Add(Me.email4)
        Me.GroupBox1.Controls.Add(Me.email)
        Me.GroupBox1.Controls.Add(Me.email3)
        Me.GroupBox1.Controls.Add(Me.num)
        Me.GroupBox1.Controls.Add(Me.street)
        Me.GroupBox1.Controls.Add(Me.city)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.bd)
        Me.GroupBox1.Controls.Add(Me.lname)
        Me.GroupBox1.Controls.Add(Me.num2)
        Me.GroupBox1.Controls.Add(Me.street2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.id2)
        Me.GroupBox1.Controls.Add(Me.city2)
        Me.GroupBox1.Controls.Add(Me.lname2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.fname)
        Me.GroupBox1.Location = New System.Drawing.Point(110, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1131, 499)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'numc1
        '
        Me.numc1.AutoSize = True
        Me.numc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.numc1.ForeColor = System.Drawing.Color.Red
        Me.numc1.Location = New System.Drawing.Point(812, 432)
        Me.numc1.Name = "numc1"
        Me.numc1.Size = New System.Drawing.Size(0, 20)
        Me.numc1.TabIndex = 35
        '
        'numc
        '
        Me.numc.AutoSize = True
        Me.numc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.numc.Location = New System.Drawing.Point(1026, 425)
        Me.numc.Name = "numc"
        Me.numc.Size = New System.Drawing.Size(96, 20)
        Me.numc.TabIndex = 5
        Me.numc.Text = ":מספר לקוח"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(177, 441)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(181, 36)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "עדכן פרטי לקוח"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'numh
        '
        Me.numh.AutoSize = True
        Me.numh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.numh.Location = New System.Drawing.Point(1022, 382)
        Me.numh.Name = "numh"
        Me.numh.Size = New System.Drawing.Size(100, 20)
        Me.numh.TabIndex = 33
        Me.numh.Text = ":טלפון בבית"
        '
        'numn
        '
        Me.numn.AutoSize = True
        Me.numn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.numn.Location = New System.Drawing.Point(1033, 344)
        Me.numn.Name = "numn"
        Me.numn.Size = New System.Drawing.Size(92, 20)
        Me.numn.TabIndex = 30
        Me.numn.Text = ":טלפון נייד"
        '
        'numn3
        '
        Me.numn3.FormattingEnabled = True
        Me.numn3.Items.AddRange(New Object() {"050", "052", "053", "054", "055", "057", "058"})
        Me.numn3.Location = New System.Drawing.Point(177, 343)
        Me.numn3.Name = "numn3"
        Me.numn3.Size = New System.Drawing.Size(58, 21)
        Me.numn3.TabIndex = 29
        '
        'numh3
        '
        Me.numh3.FormattingEnabled = True
        Me.numh3.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08"})
        Me.numh3.Location = New System.Drawing.Point(177, 381)
        Me.numh3.Name = "numh3"
        Me.numh3.Size = New System.Drawing.Size(58, 21)
        Me.numh3.TabIndex = 28
        '
        'numh2
        '
        Me.numh2.Location = New System.Drawing.Point(241, 382)
        Me.numh2.Name = "numh2"
        Me.numh2.Size = New System.Drawing.Size(157, 20)
        Me.numh2.TabIndex = 27
        '
        'numn2
        '
        Me.numn2.Location = New System.Drawing.Point(241, 343)
        Me.numn2.Name = "numn2"
        Me.numn2.Size = New System.Drawing.Size(157, 20)
        Me.numn2.TabIndex = 26
        '
        'email2
        '
        Me.email2.Location = New System.Drawing.Point(265, 298)
        Me.email2.Name = "email2"
        Me.email2.Size = New System.Drawing.Size(133, 20)
        Me.email2.TabIndex = 25
        '
        'email4
        '
        Me.email4.Location = New System.Drawing.Point(124, 298)
        Me.email4.Name = "email4"
        Me.email4.Size = New System.Drawing.Size(113, 20)
        Me.email4.TabIndex = 24
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.email.Location = New System.Drawing.Point(1061, 305)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(64, 20)
        Me.email.TabIndex = 23
        Me.email.Text = ":אימייל"
        '
        'email3
        '
        Me.email3.AutoSize = True
        Me.email3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.email3.Location = New System.Drawing.Point(237, 298)
        Me.email3.Name = "email3"
        Me.email3.Size = New System.Drawing.Size(26, 20)
        Me.email3.TabIndex = 21
        Me.email3.Text = "@"
        '
        'num
        '
        Me.num.AutoSize = True
        Me.num.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.num.Location = New System.Drawing.Point(1030, 260)
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(95, 20)
        Me.num.TabIndex = 19
        Me.num.Text = ":מספר דירה"
        '
        'street
        '
        Me.street.AutoSize = True
        Me.street.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.street.Location = New System.Drawing.Point(1074, 219)
        Me.street.Name = "street"
        Me.street.Size = New System.Drawing.Size(51, 20)
        Me.street.TabIndex = 17
        Me.street.Text = ":רחוב"
        '
        'city
        '
        Me.city.AutoSize = True
        Me.city.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.city.Location = New System.Drawing.Point(1084, 175)
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(41, 20)
        Me.city.TabIndex = 15
        Me.city.Text = ":עיר"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.id.Location = New System.Drawing.Point(1023, 129)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(102, 20)
        Me.id.TabIndex = 13
        Me.id.Text = ":תעודת זהות"
        '
        'bd
        '
        Me.bd.AutoSize = True
        Me.bd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bd.Location = New System.Drawing.Point(1022, 95)
        Me.bd.Name = "bd"
        Me.bd.Size = New System.Drawing.Size(103, 20)
        Me.bd.TabIndex = 11
        Me.bd.Text = ":תאריך לידה"
        '
        'lname
        '
        Me.lname.AutoSize = True
        Me.lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lname.Location = New System.Drawing.Point(1031, 52)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(94, 20)
        Me.lname.TabIndex = 9
        Me.lname.Text = ":שם משפחה"
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(177, 260)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(221, 20)
        Me.num2.TabIndex = 8
        Me.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'street2
        '
        Me.street2.Location = New System.Drawing.Point(177, 219)
        Me.street2.Name = "street2"
        Me.street2.Size = New System.Drawing.Size(221, 20)
        Me.street2.TabIndex = 7
        Me.street2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(177, 95)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(221, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'id2
        '
        Me.id2.Location = New System.Drawing.Point(177, 136)
        Me.id2.Name = "id2"
        Me.id2.Size = New System.Drawing.Size(221, 20)
        Me.id2.TabIndex = 5
        Me.id2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'city2
        '
        Me.city2.Location = New System.Drawing.Point(177, 175)
        Me.city2.Name = "city2"
        Me.city2.Size = New System.Drawing.Size(221, 20)
        Me.city2.TabIndex = 4
        Me.city2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lname2
        '
        Me.lname2.Location = New System.Drawing.Point(177, 52)
        Me.lname2.Name = "lname2"
        Me.lname2.Size = New System.Drawing.Size(221, 20)
        Me.lname2.TabIndex = 3
        Me.lname2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(177, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(221, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fname
        '
        Me.fname.AutoSize = True
        Me.fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.fname.Location = New System.Drawing.Point(1048, 16)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(77, 20)
        Me.fname.TabIndex = 0
        Me.fname.Text = ":שם פרטי"
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
        Me.Button3.Location = New System.Drawing.Point(1238, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(47, 27)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1297, 658)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents id2 As System.Windows.Forms.TextBox
    Friend WithEvents city2 As System.Windows.Forms.TextBox
    Friend WithEvents lname2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents fname As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents bd As System.Windows.Forms.Label
    Friend WithEvents lname As System.Windows.Forms.Label
    Friend WithEvents num2 As System.Windows.Forms.TextBox
    Friend WithEvents street2 As System.Windows.Forms.TextBox
    Friend WithEvents street As System.Windows.Forms.Label
    Friend WithEvents city As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.Label
    Friend WithEvents email As System.Windows.Forms.Label
    Friend WithEvents email3 As System.Windows.Forms.Label
    Friend WithEvents num As System.Windows.Forms.Label
    Friend WithEvents numn3 As System.Windows.Forms.ComboBox
    Friend WithEvents numh3 As System.Windows.Forms.ComboBox
    Friend WithEvents numh2 As System.Windows.Forms.TextBox
    Friend WithEvents numn2 As System.Windows.Forms.TextBox
    Friend WithEvents email2 As System.Windows.Forms.TextBox
    Friend WithEvents email4 As System.Windows.Forms.TextBox
    Friend WithEvents numh As System.Windows.Forms.Label
    Friend WithEvents numn As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents numc1 As System.Windows.Forms.Label
    Friend WithEvents numc As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class

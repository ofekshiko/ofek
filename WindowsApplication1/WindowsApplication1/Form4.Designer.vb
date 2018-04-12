<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comapny = New System.Windows.Forms.Label()
        Me.company1 = New System.Windows.Forms.TextBox()
        Me.model = New System.Windows.Forms.Label()
        Me.model1 = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.Label()
        Me.id1 = New System.Windows.Forms.Label()
        Me.cou = New System.Windows.Forms.Label()
        Me.cou1 = New System.Windows.Forms.TextBox()
        Me.cat = New System.Windows.Forms.Label()
        Me.cat1 = New System.Windows.Forms.ComboBox()
        Me.pr = New System.Windows.Forms.Label()
        Me.pr1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(540, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ":הוספת סוג רכב"
        '
        'comapny
        '
        Me.comapny.AutoSize = True
        Me.comapny.Location = New System.Drawing.Point(1024, 113)
        Me.comapny.Name = "comapny"
        Me.comapny.Size = New System.Drawing.Size(37, 13)
        Me.comapny.TabIndex = 1
        Me.comapny.Text = ":חברה"
        '
        'company1
        '
        Me.company1.Location = New System.Drawing.Point(774, 106)
        Me.company1.Name = "company1"
        Me.company1.Size = New System.Drawing.Size(207, 20)
        Me.company1.TabIndex = 2
        '
        'model
        '
        Me.model.AutoSize = True
        Me.model.Location = New System.Drawing.Point(1024, 144)
        Me.model.Name = "model"
        Me.model.Size = New System.Drawing.Size(30, 13)
        Me.model.TabIndex = 3
        Me.model.Text = ":דגם"
        '
        'model1
        '
        Me.model1.Location = New System.Drawing.Point(774, 141)
        Me.model1.Name = "model1"
        Me.model1.Size = New System.Drawing.Size(207, 20)
        Me.model1.TabIndex = 4
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(978, 62)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(83, 13)
        Me.id.TabIndex = 5
        Me.id.Text = ":מספר דגם רכב"
        '
        'id1
        '
        Me.id1.AutoSize = True
        Me.id1.Location = New System.Drawing.Point(901, 62)
        Me.id1.Name = "id1"
        Me.id1.Size = New System.Drawing.Size(0, 13)
        Me.id1.TabIndex = 6
        '
        'cou
        '
        Me.cou.AutoSize = True
        Me.cou.Location = New System.Drawing.Point(1024, 180)
        Me.cou.Name = "cou"
        Me.cou.Size = New System.Drawing.Size(63, 13)
        Me.cou.TabIndex = 7
        Me.cou.Text = ":ארץ ייצור"
        '
        'cou1
        '
        Me.cou1.Location = New System.Drawing.Point(774, 180)
        Me.cou1.Name = "cou1"
        Me.cou1.Size = New System.Drawing.Size(207, 20)
        Me.cou1.TabIndex = 8
        '
        'cat
        '
        Me.cat.AutoSize = True
        Me.cat.Location = New System.Drawing.Point(1024, 230)
        Me.cat.Name = "cat"
        Me.cat.Size = New System.Drawing.Size(53, 13)
        Me.cat.TabIndex = 9
        Me.cat.Text = ":קטגוריה"
        '
        'cat1
        '
        Me.cat1.FormattingEnabled = True
        Me.cat1.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G"})
        Me.cat1.Location = New System.Drawing.Point(885, 230)
        Me.cat1.Name = "cat1"
        Me.cat1.Size = New System.Drawing.Size(96, 21)
        Me.cat1.TabIndex = 10
        '
        'pr
        '
        Me.pr.AutoSize = True
        Me.pr.Location = New System.Drawing.Point(1024, 273)
        Me.pr.Name = "pr"
        Me.pr.Size = New System.Drawing.Size(99, 13)
        Me.pr.TabIndex = 11
        Me.pr.Text = ":מחיר השכרה יומי"
        '
        'pr1
        '
        Me.pr1.Location = New System.Drawing.Point(774, 273)
        Me.pr1.MaxLength = 10
        Me.pr1.Name = "pr1"
        Me.pr1.Size = New System.Drawing.Size(207, 20)
        Me.pr1.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(500, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 44)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "הוסף רכב למערכת"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.Button2.Location = New System.Drawing.Point(1136, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 27)
        Me.Button2.TabIndex = 14
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 454)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pr1)
        Me.Controls.Add(Me.pr)
        Me.Controls.Add(Me.cat1)
        Me.Controls.Add(Me.cat)
        Me.Controls.Add(Me.cou1)
        Me.Controls.Add(Me.cou)
        Me.Controls.Add(Me.id1)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.model1)
        Me.Controls.Add(Me.model)
        Me.Controls.Add(Me.company1)
        Me.Controls.Add(Me.comapny)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comapny As System.Windows.Forms.Label
    Friend WithEvents company1 As System.Windows.Forms.TextBox
    Friend WithEvents model As System.Windows.Forms.Label
    Friend WithEvents model1 As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.Label
    Friend WithEvents id1 As System.Windows.Forms.Label
    Friend WithEvents cou As System.Windows.Forms.Label
    Friend WithEvents cou1 As System.Windows.Forms.TextBox
    Friend WithEvents cat As System.Windows.Forms.Label
    Friend WithEvents cat1 As System.Windows.Forms.ComboBox
    Friend WithEvents pr As System.Windows.Forms.Label
    Friend WithEvents pr1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

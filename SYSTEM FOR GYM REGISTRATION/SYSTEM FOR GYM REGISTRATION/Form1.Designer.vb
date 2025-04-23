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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ListBox1 = New ListBox()
        txtbox_result = New TextBox()
        rb_male = New RadioButton()
        rb_female = New RadioButton()
        chkTrainer = New CheckBox()
        chkSauna = New CheckBox()
        chkDiet = New CheckBox()
        btn_calculate = New Button()
        lbl = New Label()
        lbl2 = New Label()
        txtbox_age = New TextBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.AccessibleDescription = ""
        ListBox1.BackColor = SystemColors.ButtonHighlight
        ListBox1.ForeColor = SystemColors.ActiveCaptionText
        ListBox1.FormattingEnabled = True
        ListBox1.Items.AddRange(New Object() {"", vbTab & "Basic (1000/month)", vbTab & "Premium (2000/month)", vbTab & "VIP (2500/month)"})
        ListBox1.Location = New Point(165, 23)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(355, 104)
        ListBox1.TabIndex = 0
        ' 
        ' txtbox_result
        ' 
        txtbox_result.Location = New Point(354, 391)
        txtbox_result.Name = "txtbox_result"
        txtbox_result.Size = New Size(166, 27)
        txtbox_result.TabIndex = 1
        ' 
        ' rb_male
        ' 
        rb_male.AutoSize = True
        rb_male.Location = New Point(170, 201)
        rb_male.Name = "rb_male"
        rb_male.Size = New Size(71, 24)
        rb_male.TabIndex = 2
        rb_male.TabStop = True
        rb_male.Text = "MALE"
        rb_male.UseVisualStyleBackColor = True
        ' 
        ' rb_female
        ' 
        rb_female.AutoSize = True
        rb_female.Location = New Point(338, 201)
        rb_female.Name = "rb_female"
        rb_female.Size = New Size(87, 24)
        rb_female.TabIndex = 2
        rb_female.TabStop = True
        rb_female.Text = "FEMALE"
        rb_female.UseVisualStyleBackColor = True
        ' 
        ' chkTrainer
        ' 
        chkTrainer.AutoSize = True
        chkTrainer.Location = New Point(170, 246)
        chkTrainer.Name = "chkTrainer"
        chkTrainer.Size = New Size(336, 24)
        chkTrainer.TabIndex = 3
        chkTrainer.Text = "PERSONAL TRAINER (750 EXTRA/MONTH)"
        chkTrainer.UseVisualStyleBackColor = True
        ' 
        ' chkSauna
        ' 
        chkSauna.AutoSize = True
        chkSauna.Location = New Point(170, 276)
        chkSauna.Name = "chkSauna"
        chkSauna.Size = New Size(300, 24)
        chkSauna.TabIndex = 3
        chkSauna.Text = "SAUNA ACCESS (500 EXTRA/MONTH)" & vbCrLf
        chkSauna.UseVisualStyleBackColor = True
        ' 
        ' chkDiet
        ' 
        chkDiet.AutoSize = True
        chkDiet.Location = New Point(170, 306)
        chkDiet.Name = "chkDiet"
        chkDiet.Size = New Size(215, 24)
        chkDiet.TabIndex = 3
        chkDiet.Text = "DIET PLAN (250/MONTH)"
        chkDiet.UseVisualStyleBackColor = True
        ' 
        ' btn_calculate
        ' 
        btn_calculate.Location = New Point(165, 348)
        btn_calculate.Name = "btn_calculate"
        btn_calculate.Size = New Size(356, 32)
        btn_calculate.TabIndex = 4
        btn_calculate.Text = "CALCULATE THE TOTAL FEE"
        btn_calculate.UseVisualStyleBackColor = True
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Location = New Point(165, 398)
        lbl.Name = "lbl"
        lbl.Size = New Size(130, 20)
        lbl.TabIndex = 5
        lbl.Text = "TOTAL AMOUNT "
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Location = New Point(299, 398)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(24, 20)
        lbl2.TabIndex = 5
        lbl2.Text = " ="
        ' 
        ' txtbox_age
        ' 
        txtbox_age.Location = New Point(170, 155)
        txtbox_age.Name = "txtbox_age"
        txtbox_age.Size = New Size(155, 27)
        txtbox_age.TabIndex = 6
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-56, 231)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(317, 280)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(491, -24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(293, 225)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(727, 450)
        Controls.Add(txtbox_age)
        Controls.Add(lbl2)
        Controls.Add(lbl)
        Controls.Add(btn_calculate)
        Controls.Add(chkDiet)
        Controls.Add(chkSauna)
        Controls.Add(chkTrainer)
        Controls.Add(rb_female)
        Controls.Add(rb_male)
        Controls.Add(txtbox_result)
        Controls.Add(ListBox1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ActiveCaptionText
        Name = "Form1"
        Text = "REGISTRATION "
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtbox_result As TextBox
    Friend WithEvents rb_male As RadioButton
    Friend WithEvents rb_female As RadioButton
    Friend WithEvents chkTrainer As CheckBox
    Friend WithEvents chkSauna As CheckBox
    Friend WithEvents chkDiet As CheckBox
    Friend WithEvents btn_calculate As Button
    Friend WithEvents lbl As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents txtbox_age As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox

End Class

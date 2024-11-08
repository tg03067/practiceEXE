namespace practiceEXE
{
    partial class 로그인창
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(로그인창));
            LogInMenu = new Label();
            IdBox = new TextBox();
            PasswordBox = new TextBox();
            LogInBotton = new Button();
            EXITBotton = new Button();
            buttonPanel = new Panel();
            SignUpButton = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            비밀번호찾기버튼 = new Button();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LogInMenu
            // 
            LogInMenu.Anchor = AnchorStyles.Top;
            LogInMenu.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            LogInMenu.Location = new Point(45, 96);
            LogInMenu.Name = "LogInMenu";
            LogInMenu.Size = new Size(233, 36);
            LogInMenu.TabIndex = 0;
            LogInMenu.Text = "로그인 창";
            LogInMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IdBox
            // 
            IdBox.Font = new Font("굴림", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            IdBox.Location = new Point(45, 156);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(233, 32);
            IdBox.TabIndex = 1;
            IdBox.Text = "ID";
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("굴림", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            PasswordBox.Location = new Point(45, 207);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(233, 32);
            PasswordBox.TabIndex = 2;
            PasswordBox.Text = "Password";
            // 
            // LogInBotton
            // 
            LogInBotton.Font = new Font("굴림", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            LogInBotton.Location = new Point(-1, 3);
            LogInBotton.Name = "LogInBotton";
            LogInBotton.Size = new Size(159, 46);
            LogInBotton.TabIndex = 3;
            LogInBotton.Text = "로그인";
            LogInBotton.UseVisualStyleBackColor = true;
            LogInBotton.Click += LogInBotton_Click;
            LogInBotton.KeyDown += LogInBotton_KeyDown;
            // 
            // EXITBotton
            // 
            EXITBotton.Font = new Font("굴림", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            EXITBotton.Location = new Point(164, 3);
            EXITBotton.Name = "EXITBotton";
            EXITBotton.Size = new Size(69, 46);
            EXITBotton.TabIndex = 4;
            EXITBotton.Text = "EXIT";
            EXITBotton.UseVisualStyleBackColor = true;
            EXITBotton.Click += EXITBotton_Click;
            EXITBotton.KeyDown += EXITBotton_KeyDown;
            // 
            // buttonPanel
            // 
            buttonPanel.AutoSize = true;
            buttonPanel.BackColor = Color.Transparent;
            buttonPanel.Controls.Add(LogInBotton);
            buttonPanel.Controls.Add(EXITBotton);
            buttonPanel.Location = new Point(45, 269);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(236, 54);
            buttonPanel.TabIndex = 5;
            // 
            // SignUpButton
            // 
            SignUpButton.Font = new Font("굴림", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            SignUpButton.Location = new Point(44, 340);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(234, 23);
            SignUpButton.TabIndex = 6;
            SignUpButton.Text = "회원가입";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // 비밀번호찾기버튼
            // 
            비밀번호찾기버튼.AutoSize = true;
            비밀번호찾기버튼.ImageAlign = ContentAlignment.BottomRight;
            비밀번호찾기버튼.Location = new Point(229, 426);
            비밀번호찾기버튼.Name = "비밀번호찾기버튼";
            비밀번호찾기버튼.Size = new Size(93, 25);
            비밀번호찾기버튼.TabIndex = 7;
            비밀번호찾기버튼.Text = "비밀번호 찾기";
            비밀번호찾기버튼.UseVisualStyleBackColor = true;
            비밀번호찾기버튼.Click += 비밀번호찾기버튼_Click;
            // 
            // 로그인창
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(334, 463);
            Controls.Add(비밀번호찾기버튼);
            Controls.Add(SignUpButton);
            Controls.Add(buttonPanel);
            Controls.Add(PasswordBox);
            Controls.Add(IdBox);
            Controls.Add(LogInMenu);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "로그인창";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LogInMenu;
        private TextBox IdBox;
        private TextBox PasswordBox;
        private Button LogInBotton;
        private Button EXITBotton;
        private Panel buttonPanel;
        private Button SignUpButton;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button 비밀번호찾기버튼;
    }
}

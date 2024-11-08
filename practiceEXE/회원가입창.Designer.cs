namespace practiceEXE
{
    partial class 회원가입창
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            IDPanel = new Panel();
            IDBox = new TextBox();
            label1 = new Label();
            SignUpLabel = new Label();
            비번패널 = new Panel();
            PwBox1 = new TextBox();
            label2 = new Label();
            중복비번패널 = new Panel();
            PwBox2 = new TextBox();
            label3 = new Label();
            버튼패널 = new Panel();
            종료버튼 = new Button();
            회원가입버튼 = new Button();
            비번중복확인 = new Label();
            IDPanel.SuspendLayout();
            비번패널.SuspendLayout();
            중복비번패널.SuspendLayout();
            버튼패널.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(422, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 1;
            button1.Text = "중복확인";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // IDPanel
            // 
            IDPanel.BackColor = Color.White;
            IDPanel.Controls.Add(IDBox);
            IDPanel.Controls.Add(label1);
            IDPanel.Controls.Add(button1);
            IDPanel.Location = new Point(127, 104);
            IDPanel.Name = "IDPanel";
            IDPanel.Size = new Size(497, 42);
            IDPanel.TabIndex = 2;
            // 
            // IDBox
            // 
            IDBox.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            IDBox.Location = new Point(58, 3);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(358, 35);
            IDBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("굴림", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(49, 36);
            label1.TabIndex = 2;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignUpLabel
            // 
            SignUpLabel.AutoSize = true;
            SignUpLabel.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            SignUpLabel.Location = new Point(299, 35);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(124, 27);
            SignUpLabel.TabIndex = 2;
            SignUpLabel.Text = "회원가입";
            // 
            // 비번패널
            // 
            비번패널.BackColor = Color.White;
            비번패널.Controls.Add(PwBox1);
            비번패널.Controls.Add(label2);
            비번패널.Location = new Point(127, 163);
            비번패널.Name = "비번패널";
            비번패널.Size = new Size(497, 42);
            비번패널.TabIndex = 4;
            // 
            // PwBox1
            // 
            PwBox1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            PwBox1.Location = new Point(58, 3);
            PwBox1.Name = "PwBox1";
            PwBox1.PasswordChar = '*';
            PwBox1.Size = new Size(436, 35);
            PwBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("굴림", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(49, 36);
            label2.TabIndex = 2;
            label2.Text = "PW";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // 중복비번패널
            // 
            중복비번패널.BackColor = Color.White;
            중복비번패널.Controls.Add(PwBox2);
            중복비번패널.Controls.Add(label3);
            중복비번패널.Location = new Point(127, 220);
            중복비번패널.Name = "중복비번패널";
            중복비번패널.Size = new Size(497, 42);
            중복비번패널.TabIndex = 5;
            // 
            // PwBox2
            // 
            PwBox2.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            PwBox2.Location = new Point(58, 3);
            PwBox2.Name = "PwBox2";
            PwBox2.PasswordChar = '*';
            PwBox2.Size = new Size(436, 35);
            PwBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("굴림", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(49, 36);
            label3.TabIndex = 2;
            label3.Text = "PW";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // 버튼패널
            // 
            버튼패널.BackColor = Color.Transparent;
            버튼패널.Controls.Add(종료버튼);
            버튼패널.Controls.Add(회원가입버튼);
            버튼패널.Location = new Point(127, 310);
            버튼패널.Name = "버튼패널";
            버튼패널.Size = new Size(497, 42);
            버튼패널.TabIndex = 6;
            // 
            // 종료버튼
            // 
            종료버튼.Font = new Font("굴림", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            종료버튼.Location = new Point(405, 0);
            종료버튼.Name = "종료버튼";
            종료버튼.Size = new Size(92, 42);
            종료버튼.TabIndex = 1;
            종료버튼.Text = "EXIT";
            종료버튼.UseVisualStyleBackColor = true;
            종료버튼.Click += 종료버튼_Click;
            종료버튼.KeyDown += 종료버튼_KeyDown;
            // 
            // 회원가입버튼
            // 
            회원가입버튼.Font = new Font("굴림", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            회원가입버튼.Location = new Point(0, 0);
            회원가입버튼.Name = "회원가입버튼";
            회원가입버튼.Size = new Size(399, 42);
            회원가입버튼.TabIndex = 0;
            회원가입버튼.Text = "회원가입";
            회원가입버튼.UseVisualStyleBackColor = true;
            회원가입버튼.Click += 회원가입버튼_Click;
            // 
            // 비번중복확인
            // 
            비번중복확인.Location = new Point(127, 275);
            비번중복확인.Name = "비번중복확인";
            비번중복확인.Size = new Size(497, 23);
            비번중복확인.TabIndex = 7;
            비번중복확인.Text = "비밀번호 중복확인";
            비번중복확인.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // 회원가입창
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.불독;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(비번중복확인);
            Controls.Add(버튼패널);
            Controls.Add(중복비번패널);
            Controls.Add(비번패널);
            Controls.Add(SignUpLabel);
            Controls.Add(IDPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "회원가입창";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            IDPanel.ResumeLayout(false);
            IDPanel.PerformLayout();
            비번패널.ResumeLayout(false);
            비번패널.PerformLayout();
            중복비번패널.ResumeLayout(false);
            중복비번패널.PerformLayout();
            버튼패널.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Panel IDPanel;
        private Label SignUpLabel;
        private Label label1;
        private TextBox IDBox;
        private Panel 비번패널;
        private TextBox PwBox1;
        private Label label2;
        private Panel 중복비번패널;
        private TextBox PwBox2;
        private Label label3;
        private Panel 버튼패널;
        private Button 종료버튼;
        private Button 회원가입버튼;
        private Label 비번중복확인;
    }
}
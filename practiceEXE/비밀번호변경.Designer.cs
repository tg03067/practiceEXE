namespace practiceEXE
{
    partial class 비밀번호변경
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
            제목 = new Label();
            비밀번호패널 = new Panel();
            비밀번호BOX = new TextBox();
            label1 = new Label();
            변경버튼 = new Button();
            뒤로가기 = new Button();
            비밀번호패널.SuspendLayout();
            SuspendLayout();
            // 
            // 제목
            // 
            제목.AutoSize = true;
            제목.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            제목.Location = new Point(164, 82);
            제목.Name = "제목";
            제목.Size = new Size(218, 27);
            제목.TabIndex = 0;
            제목.Text = "변경할 비밀번호";
            // 
            // 비밀번호패널
            // 
            비밀번호패널.Controls.Add(비밀번호BOX);
            비밀번호패널.Controls.Add(label1);
            비밀번호패널.Location = new Point(94, 179);
            비밀번호패널.Name = "비밀번호패널";
            비밀번호패널.Size = new Size(355, 57);
            비밀번호패널.TabIndex = 1;
            // 
            // 비밀번호BOX
            // 
            비밀번호BOX.Font = new Font("굴림", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            비밀번호BOX.Location = new Point(70, 3);
            비밀번호BOX.Name = "비밀번호BOX";
            비밀번호BOX.PasswordChar = '*';
            비밀번호BOX.Size = new Size(285, 48);
            비밀번호BOX.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("굴림", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(59, 29);
            label1.TabIndex = 0;
            label1.Text = "PW";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // 변경버튼
            // 
            변경버튼.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            변경버튼.Location = new Point(94, 288);
            변경버튼.Name = "변경버튼";
            변경버튼.Size = new Size(355, 38);
            변경버튼.TabIndex = 2;
            변경버튼.Text = "비밀번호 변경";
            변경버튼.UseVisualStyleBackColor = true;
            변경버튼.Click += 변경버튼_Click;
            변경버튼.KeyDown += 변경버튼_KeyDown;
            // 
            // 뒤로가기
            // 
            뒤로가기.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            뒤로가기.Location = new Point(94, 332);
            뒤로가기.Name = "뒤로가기";
            뒤로가기.Size = new Size(355, 38);
            뒤로가기.TabIndex = 3;
            뒤로가기.Text = "EXIT";
            뒤로가기.UseVisualStyleBackColor = true;
            뒤로가기.Click += 뒤로가기_Click;
            뒤로가기.KeyDown += 뒤로가기_KeyDown;
            // 
            // 비밀번호변경
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            Controls.Add(뒤로가기);
            Controls.Add(변경버튼);
            Controls.Add(비밀번호패널);
            Controls.Add(제목);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "비밀번호변경";
            Text = "비밀번호변경";
            비밀번호패널.ResumeLayout(false);
            비밀번호패널.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label 제목;
        private Panel 비밀번호패널;
        private TextBox 비밀번호BOX;
        private Label label1;
        private Button 변경버튼;
        private Button 뒤로가기;
    }
}
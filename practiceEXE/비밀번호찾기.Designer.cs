namespace practiceEXE
{
    partial class 비밀번호찾기
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
            아이디박스 = new TextBox();
            제목 = new Label();
            아이디패널 = new Panel();
            아이디라벨 = new Label();
            찾기버튼 = new Button();
            뒤로가기 = new Button();
            아이디패널.SuspendLayout();
            SuspendLayout();
            // 
            // 아이디박스
            // 
            아이디박스.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            아이디박스.Location = new Point(41, 3);
            아이디박스.Name = "아이디박스";
            아이디박스.Size = new Size(297, 35);
            아이디박스.TabIndex = 0;
            // 
            // 제목
            // 
            제목.AutoSize = true;
            제목.Font = new Font("굴림", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            제목.Location = new Point(144, 118);
            제목.Name = "제목";
            제목.Size = new Size(169, 24);
            제목.TabIndex = 1;
            제목.Text = "비밀번호 찾기";
            // 
            // 아이디패널
            // 
            아이디패널.Controls.Add(아이디라벨);
            아이디패널.Controls.Add(아이디박스);
            아이디패널.Location = new Point(68, 258);
            아이디패널.Name = "아이디패널";
            아이디패널.Size = new Size(338, 41);
            아이디패널.TabIndex = 2;
            // 
            // 아이디라벨
            // 
            아이디라벨.Anchor = AnchorStyles.Top;
            아이디라벨.Font = new Font("굴림", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            아이디라벨.Location = new Point(3, 3);
            아이디라벨.Name = "아이디라벨";
            아이디라벨.Size = new Size(32, 35);
            아이디라벨.TabIndex = 1;
            아이디라벨.Text = "ID";
            아이디라벨.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // 찾기버튼
            // 
            찾기버튼.Location = new Point(68, 345);
            찾기버튼.Name = "찾기버튼";
            찾기버튼.Size = new Size(338, 34);
            찾기버튼.TabIndex = 2;
            찾기버튼.Text = "비밀번호 변경";
            찾기버튼.UseVisualStyleBackColor = true;
            찾기버튼.Click += 찾기버튼_Click;
            찾기버튼.KeyDown += 찾기버튼_KeyDown;
            // 
            // 뒤로가기
            // 
            뒤로가기.Location = new Point(68, 385);
            뒤로가기.Name = "뒤로가기";
            뒤로가기.Size = new Size(338, 34);
            뒤로가기.TabIndex = 3;
            뒤로가기.Text = "EXIT";
            뒤로가기.UseVisualStyleBackColor = true;
            뒤로가기.Click += 뒤로가기_Click;
            뒤로가기.KeyDown += 뒤로가기_KeyDown;
            // 
            // 비밀번호찾기
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 534);
            Controls.Add(뒤로가기);
            Controls.Add(찾기버튼);
            Controls.Add(아이디패널);
            Controls.Add(제목);
            MaximizeBox = false;
            Name = "비밀번호찾기";
            Text = "비밀번호찾기";
            아이디패널.ResumeLayout(false);
            아이디패널.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox 아이디박스;
        private Label 제목;
        private Panel 아이디패널;
        private Label 아이디라벨;
        private Button 찾기버튼;
        private Button 뒤로가기;
    }
}
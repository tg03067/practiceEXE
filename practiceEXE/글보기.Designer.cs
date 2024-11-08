namespace practiceEXE
{
    partial class 글보기
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
            panel1 = new Panel();
            contentbox = new RichTextBox();
            titlebox = new RichTextBox();
            작성자 = new Label();
            삭제 = new Button();
            수정 = new Button();
            목록 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(contentbox);
            panel1.Controls.Add(titlebox);
            panel1.Controls.Add(작성자);
            panel1.Controls.Add(삭제);
            panel1.Controls.Add(수정);
            panel1.Controls.Add(목록);
            panel1.Location = new Point(117, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 666);
            panel1.TabIndex = 2;
            // 
            // contentbox
            // 
            contentbox.BackColor = Color.White;
            contentbox.BorderStyle = BorderStyle.None;
            contentbox.DetectUrls = false;
            contentbox.Location = new Point(9, 47);
            contentbox.Name = "contentbox";
            contentbox.ReadOnly = true;
            contentbox.Size = new Size(568, 561);
            contentbox.TabIndex = 6;
            contentbox.TabStop = false;
            contentbox.Text = "";
            // 
            // titlebox
            // 
            titlebox.BackColor = Color.White;
            titlebox.BorderStyle = BorderStyle.None;
            titlebox.DetectUrls = false;
            titlebox.Location = new Point(3, 3);
            titlebox.Multiline = false;
            titlebox.Name = "titlebox";
            titlebox.ReadOnly = true;
            titlebox.Size = new Size(568, 23);
            titlebox.TabIndex = 5;
            titlebox.TabStop = false;
            titlebox.Text = "";
            // 
            // 작성자
            // 
            작성자.AutoSize = true;
            작성자.Location = new Point(528, 29);
            작성자.Name = "작성자";
            작성자.Size = new Size(43, 15);
            작성자.TabIndex = 3;
            작성자.Text = "작성자";
            // 
            // 삭제
            // 
            삭제.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            삭제.Location = new Point(482, 625);
            삭제.Name = "삭제";
            삭제.Size = new Size(89, 38);
            삭제.TabIndex = 4;
            삭제.Text = "삭제";
            삭제.UseVisualStyleBackColor = true;
            삭제.Click += 삭제_Click;
            // 
            // 수정
            // 
            수정.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            수정.Location = new Point(387, 625);
            수정.Name = "수정";
            수정.Size = new Size(89, 38);
            수정.TabIndex = 3;
            수정.Text = "수정";
            수정.UseVisualStyleBackColor = true;
            수정.Click += 수정_Click;
            // 
            // 목록
            // 
            목록.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            목록.Location = new Point(292, 625);
            목록.Name = "목록";
            목록.Size = new Size(89, 38);
            목록.TabIndex = 2;
            목록.Text = "목록";
            목록.UseVisualStyleBackColor = true;
            목록.Click += 목록_Click;
            // 
            // 글보기
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(795, 750);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "글보기";
            Text = "글보기";
            FormClosing += 글보기_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button 수정;
        private Button 목록;
        private Button 삭제;
        private Label 작성자;
        private RichTextBox titlebox;
        private RichTextBox contentbox;
    }
}
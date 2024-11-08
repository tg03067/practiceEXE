namespace practiceEXE
{
    partial class 글쓰기
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
            Title = new TextBox();
            titlepanel = new Panel();
            TitleLabel = new Label();
            contentspanel = new Panel();
            pictureBox1 = new PictureBox();
            contentsbox = new TextBox();
            contentsLabel = new Label();
            endbutton = new Button();
            이미지 = new Button();
            titlepanel.SuspendLayout();
            contentspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // 제목
            // 
            제목.AutoSize = true;
            제목.Font = new Font("궁서체", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            제목.Location = new Point(216, 32);
            제목.Name = "제목";
            제목.Size = new Size(98, 24);
            제목.TabIndex = 0;
            제목.Text = "글 쓰기";
            제목.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            Title.Location = new Point(65, 9);
            Title.MaxLength = 50;
            Title.Name = "Title";
            Title.Size = new Size(330, 23);
            Title.TabIndex = 1;
            // 
            // titlepanel
            // 
            titlepanel.Controls.Add(TitleLabel);
            titlepanel.Controls.Add(Title);
            titlepanel.Location = new Point(66, 78);
            titlepanel.Name = "titlepanel";
            titlepanel.Size = new Size(398, 41);
            titlepanel.TabIndex = 2;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("궁서체", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            TitleLabel.Location = new Point(3, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(56, 21);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "제목";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contentspanel
            // 
            contentspanel.Controls.Add(pictureBox1);
            contentspanel.Controls.Add(contentsbox);
            contentspanel.Controls.Add(contentsLabel);
            contentspanel.Location = new Point(66, 125);
            contentspanel.Name = "contentspanel";
            contentspanel.Size = new Size(398, 562);
            contentspanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 246);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // contentsbox
            // 
            contentsbox.AllowDrop = true;
            contentsbox.Location = new Point(3, 285);
            contentsbox.MaxLength = 300;
            contentsbox.Multiline = true;
            contentsbox.Name = "contentsbox";
            contentsbox.Size = new Size(392, 274);
            contentsbox.TabIndex = 1;
            // 
            // contentsLabel
            // 
            contentsLabel.AutoSize = true;
            contentsLabel.Font = new Font("궁서", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            contentsLabel.Location = new Point(3, 9);
            contentsLabel.Name = "contentsLabel";
            contentsLabel.Size = new Size(54, 21);
            contentsLabel.TabIndex = 0;
            contentsLabel.Text = "내용";
            // 
            // endbutton
            // 
            endbutton.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            endbutton.Location = new Point(66, 745);
            endbutton.Name = "endbutton";
            endbutton.Size = new Size(398, 46);
            endbutton.TabIndex = 2;
            endbutton.Text = "작성";
            endbutton.UseVisualStyleBackColor = true;
            endbutton.Click += endbutton_Click;
            // 
            // 이미지
            // 
            이미지.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            이미지.Location = new Point(66, 693);
            이미지.Name = "이미지";
            이미지.Size = new Size(398, 46);
            이미지.TabIndex = 4;
            이미지.Text = "이미지 등록";
            이미지.UseVisualStyleBackColor = true;
            이미지.Click += 이미지_Click;
            // 
            // 글쓰기
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 816);
            Controls.Add(이미지);
            Controls.Add(endbutton);
            Controls.Add(contentspanel);
            Controls.Add(titlepanel);
            Controls.Add(제목);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "글쓰기";
            Text = "글쓰기";
            FormClosing += 글쓰기_FormClosing;
            titlepanel.ResumeLayout(false);
            titlepanel.PerformLayout();
            contentspanel.ResumeLayout(false);
            contentspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label 제목;
        private TextBox Title;
        private Panel titlepanel;
        private Label TitleLabel;
        private Panel contentspanel;
        private TextBox contentsbox;
        private Label contentsLabel;
        private Button endbutton;
        private PictureBox pictureBox1;
        private Button 이미지;
    }
}
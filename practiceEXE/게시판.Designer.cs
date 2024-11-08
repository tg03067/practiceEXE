namespace practiceEXE
{
    partial class 게시판
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            logout = new Button();
            checkboxhide = new CheckBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            timerSliding = new System.Windows.Forms.Timer(components);
            글쓰기 = new Button();
            dataGridView1 = new DataGridView();
            TITLE = new DataGridViewTextBoxColumn();
            Contents = new DataGridViewTextBoxColumn();
            WriterName = new DataGridViewTextBoxColumn();
            Created_at = new DataGridViewTextBoxColumn();
            Updated_at = new DataGridViewTextBoxColumn();
            조회 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(logout);
            panel1.Controls.Add(checkboxhide);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 565);
            panel1.TabIndex = 0;
            // 
            // logout
            // 
            logout.BackColor = SystemColors.AppWorkspace;
            logout.Dock = DockStyle.Bottom;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.ForeColor = Color.White;
            logout.Location = new Point(0, 457);
            logout.Name = "logout";
            logout.Size = new Size(200, 57);
            logout.TabIndex = 5;
            logout.Text = "로그아웃";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // checkboxhide
            // 
            checkboxhide.Appearance = Appearance.Button;
            checkboxhide.Dock = DockStyle.Bottom;
            checkboxhide.FlatAppearance.BorderSize = 0;
            checkboxhide.FlatStyle = FlatStyle.Flat;
            checkboxhide.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            checkboxhide.ForeColor = Color.White;
            checkboxhide.Location = new Point(0, 514);
            checkboxhide.Name = "checkboxhide";
            checkboxhide.Size = new Size(200, 51);
            checkboxhide.TabIndex = 1;
            checkboxhide.Text = "<";
            checkboxhide.TextAlign = ContentAlignment.MiddleCenter;
            checkboxhide.UseVisualStyleBackColor = true;
            checkboxhide.CheckedChanged += checkboxhide_CheckedChanged;
            checkboxhide.KeyDown += checkboxhide_KeyDown;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.AppWorkspace;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 228);
            button5.Name = "button5";
            button5.Size = new Size(200, 57);
            button5.TabIndex = 4;
            button5.Text = "버튼5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.AppWorkspace;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 171);
            button4.Name = "button4";
            button4.Size = new Size(200, 57);
            button4.TabIndex = 3;
            button4.Text = "버튼4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 114);
            button3.Name = "button3";
            button3.Size = new Size(200, 57);
            button3.TabIndex = 2;
            button3.Text = "버튼3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 57);
            button2.Name = "button2";
            button2.Size = new Size(200, 57);
            button2.TabIndex = 1;
            button2.Text = "버튼2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(200, 57);
            button1.TabIndex = 0;
            button1.Text = "버튼1";
            button1.UseVisualStyleBackColor = false;
            // 
            // timerSliding
            // 
            timerSliding.Interval = 1;
            timerSliding.Tick += timerSliding_Tick;
            // 
            // 글쓰기
            // 
            글쓰기.Font = new Font("굴림", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            글쓰기.Location = new Point(206, 0);
            글쓰기.Name = "글쓰기";
            글쓰기.Size = new Size(96, 35);
            글쓰기.TabIndex = 1;
            글쓰기.Text = "글쓰기";
            글쓰기.UseVisualStyleBackColor = true;
            글쓰기.Click += 글쓰기_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TITLE, Contents, WriterName, Created_at, Updated_at });
            dataGridView1.Location = new Point(206, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1043, 487);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // TITLE
            // 
            TITLE.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TITLE.DataPropertyName = "boardTitle";
            TITLE.HeaderText = "TITLE";
            TITLE.MaxInputLength = 10;
            TITLE.Name = "TITLE";
            TITLE.ReadOnly = true;
            TITLE.Width = 59;
            // 
            // Contents
            // 
            Contents.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Contents.DataPropertyName = "boardContents";
            Contents.HeaderText = "Contents";
            Contents.Name = "Contents";
            Contents.ReadOnly = true;
            // 
            // WriterName
            // 
            WriterName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            WriterName.DataPropertyName = "boardWriterName";
            WriterName.HeaderText = "WriterName";
            WriterName.Name = "WriterName";
            WriterName.ReadOnly = true;
            WriterName.Width = 96;
            // 
            // Created_at
            // 
            Created_at.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Created_at.DataPropertyName = "createdAt";
            Created_at.HeaderText = "작성일자";
            Created_at.Name = "Created_at";
            Created_at.ReadOnly = true;
            Created_at.Width = 80;
            // 
            // Updated_at
            // 
            Updated_at.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Updated_at.DataPropertyName = "updatedAt";
            Updated_at.HeaderText = "수정일자";
            Updated_at.Name = "Updated_at";
            Updated_at.ReadOnly = true;
            Updated_at.Width = 80;
            // 
            // 조회
            // 
            조회.Font = new Font("굴림", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            조회.Location = new Point(1129, 12);
            조회.Name = "조회";
            조회.Size = new Size(120, 23);
            조회.TabIndex = 3;
            조회.Text = "조회";
            조회.UseVisualStyleBackColor = true;
            조회.Click += 조회_Click;
            // 
            // 게시판
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 565);
            Controls.Add(조회);
            Controls.Add(dataGridView1);
            Controls.Add(글쓰기);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "게시판";
            Text = "게시판";
            FormClosing += 게시판_FormClosing;
            KeyDown += 게시판_KeyDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private CheckBox checkboxhide;
        private System.Windows.Forms.Timer timerSliding;
        private Button logout;
        private Button 글쓰기;
        private DataGridView dataGridView1;
        private Button 조회;
        private DataGridViewTextBoxColumn TITLE;
        private DataGridViewTextBoxColumn Contents;
        private DataGridViewTextBoxColumn WriterName;
        private DataGridViewTextBoxColumn Created_at;
        private DataGridViewTextBoxColumn Updated_at;
    }
}
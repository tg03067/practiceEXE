using Microsoft.Data.SqlClient;
using practiceEXE.게시판Model;
using practiceEXE.게시판Model.model;

namespace practiceEXE
{
    public partial class 로그인창 : Form
    {
        private BoardModel model;
        public 로그인창()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(LogInBotton_KeyDown);
            this.KeyDown += new KeyEventHandler(EXITBotton_KeyDown);
            model = new BoardModel();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            LogInMenu.Left = (this.ClientSize.Width - LogInMenu.Width) / 2;
            LogInMenu.Top = (this.ClientSize.Width - LogInMenu.Width) / 4;
            IdBox.Left = (this.ClientSize.Width - IdBox.Width) / 2;
            PasswordBox.Left = (this.ClientSize.Width - PasswordBox.Width) / 2;
            buttonPanel.Left = (this.ClientSize.Width - buttonPanel.Width) / 2;
            SignUpButton.Left = (this.ClientSize.Width - SignUpButton.Width) / 2;
        }

        private void EXITBotton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInBotton_Click(object? sender, EventArgs e)
        {
            BoardModelRes res = new BoardModelRes();

            string connectString = "Server=192.168.0.69,1433;Database=practicedb;Trusted_Connection=True;TrustServerCertificate=True;";

            string userId = IdBox.Text;
            string userPassword = PasswordBox.Text;

            res = model.LogIn(userId);



            if(res == null)
            {
                MessageBox.Show("존재하지 않는 사용자입니다.");
                return;
            }
            

            // 입력된 비밀번호 해시화
            string hashedPassword = 회원가입창.HashPassword(userPassword);

            // 해쉬된 비밀번호 조회
            string query = $"select user_password from [user] where user_id = '{userId}'";

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                var result = cmd.ExecuteScalar(); // 일치하는 사용자가 있으면 1, 없으면 0 반환
                //int count = result == null ? 0 : Convert.ToInt32(result);

                if (result != null)
                {
                    string storeHashPassword = result.ToString();
                    if (hashedPassword == storeHashPassword)
                    {
                        MessageBox.Show("로그인 성공");

                        게시판 newForm = new 게시판(res);
                        newForm.Show();
                        Hide();
                        return ;
                    }
                    else
                    {
                        MessageBox.Show("아이디 또는 비밀번호가 잘못되었습니다.");
                        return ;
                    }

                }
                else
                {
                    MessageBox.Show("존재하지 않는 사용자입니다.");
                }
            }
        }

        private void LogInBotton_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogInBotton_Click(sender, e);
                e.Handled = true;
            }
        }

        private void EXITBotton_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            회원가입창 newForm = new 회원가입창();
            newForm.Show();
            this.Hide();
        }

        private void 비밀번호찾기버튼_Click(object sender, EventArgs e)
        {
            비밀번호찾기 newForm = new 비밀번호찾기();
            newForm.Show();
            this.Hide();
        }
    }
}

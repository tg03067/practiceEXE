using Microsoft.Data.SqlClient;
using practiceEXE.�Խ���Model;
using practiceEXE.�Խ���Model.model;

namespace practiceEXE
{
    public partial class �α���â : Form
    {
        private BoardModel model;
        public �α���â()
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
                MessageBox.Show("�������� �ʴ� ������Դϴ�.");
                return;
            }
            

            // �Էµ� ��й�ȣ �ؽ�ȭ
            string hashedPassword = ȸ������â.HashPassword(userPassword);

            // �ؽ��� ��й�ȣ ��ȸ
            string query = $"select user_password from [user] where user_id = '{userId}'";

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                var result = cmd.ExecuteScalar(); // ��ġ�ϴ� ����ڰ� ������ 1, ������ 0 ��ȯ
                //int count = result == null ? 0 : Convert.ToInt32(result);

                if (result != null)
                {
                    string storeHashPassword = result.ToString();
                    if (hashedPassword == storeHashPassword)
                    {
                        MessageBox.Show("�α��� ����");

                        �Խ��� newForm = new �Խ���(res);
                        newForm.Show();
                        Hide();
                        return ;
                    }
                    else
                    {
                        MessageBox.Show("���̵� �Ǵ� ��й�ȣ�� �߸��Ǿ����ϴ�.");
                        return ;
                    }

                }
                else
                {
                    MessageBox.Show("�������� �ʴ� ������Դϴ�.");
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
            ȸ������â newForm = new ȸ������â();
            newForm.Show();
            this.Hide();
        }

        private void ��й�ȣã���ư_Click(object sender, EventArgs e)
        {
            ��й�ȣã�� newForm = new ��й�ȣã��();
            newForm.Show();
            this.Hide();
        }
    }
}

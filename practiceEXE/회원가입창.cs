using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceEXE
{
    public partial class 회원가입창 : Form
    {
        string connectString = "Server=192.168.0.69,1433;Database=practicedb;Trusted_Connection=True;TrustServerCertificate=True;";
        public 회원가입창()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form2_Load);
            this.Load += new EventHandler(Label_Load);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(종료버튼_KeyDown);

            PwBox1.TextChanged += Label_Load;
            PwBox2.TextChanged += Label_Load;

        }


        private void Form2_Load(object? sender, EventArgs e)
        {
            SignUpLabel.Left = (this.ClientSize.Width - SignUpLabel.Width) / 2;
            IDPanel.Left = (this.ClientSize.Width - IDPanel.Width) / 2;
            비번패널.Left = (this.ClientSize.Width - 비번패널.Width) / 2;
            중복비번패널.Left = (this.ClientSize.Width - 중복비번패널.Width) / 2;
            버튼패널.Left = (this.ClientSize.Width - 버튼패널.Width) / 2;
            PwBox2.Enabled = false;
            회원가입버튼.Enabled = false;
        }

        private void 종료버튼_Click(object? sender, EventArgs e)
        {
            로그인창 newForm = new 로그인창();
            newForm.Show();
            Hide();
        }

        private void 종료버튼_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                종료버튼_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = IDBox.Text;

            string qurey = $"select count(*) from [user] where user_id = '{userId}'";

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand(qurey, conn);
                cmd.Parameters.AddWithValue("@userId", userId);

                conn.Open();

                var result = cmd.ExecuteScalar();
                int count = result == null ? 0 : Convert.ToInt32(result);

                if (count == 1)
                {
                    MessageBox.Show("존재하는 아이디입니다.");
                    return;
                }
                else
                {
                    MessageBox.Show("사용가능한 아이디입니다.");
                    회원가입버튼.Enabled = true; 
                }

                
            }

        }

        private void Label_Load(object? sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(PwBox1.Text))
            {
                비번중복확인.Text = "비밀번호가 비어있습니다.";
                PwBox2.Enabled = false;
                return;
            }
            else
            {
                PwBox2.Enabled = true;
                if (!string.IsNullOrEmpty(PwBox2.Text) && !string.IsNullOrEmpty(PwBox1.Text))
                {
                    if (PwBox1.Text == PwBox2.Text)
                    {
                        비번중복확인.Text = "입력된 비밀번호가 같습니다.";
                    }
                    else
                    {
                        비번중복확인.Text = "입력된 비밀번호가 같지 않습니다.";
                    }
                }
                if(string.IsNullOrEmpty(PwBox2.Text))
                {
                    비번중복확인.Text = "비밀번호가 비어있습니다.";
                    return;
                }
            }
   
        }

        private void 회원가입버튼_Click(object sender, EventArgs e)
        {
            if(비번중복확인.Text == "입력된 비밀번호가 같습니다.")
            {
                string userId = IDBox.Text;
                string userPassword = null;
                int result = 0;
                string hashPassword = null;

                // 비밀번호 중복을 확인하는 라벨확인
                if(PwBox1.Text == PwBox2.Text)
                {
                    userPassword = PwBox2.Text;
                    hashPassword = HashPassword(userPassword);
                }
                else
                {
                    MessageBox.Show(비번중복확인.Text);
                    return;
                }

                string query = $"insert into [user](user_id, user_password) values ('{userId}', '{hashPassword}')";


                // 데이터 베이스 연결
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    if(userPassword == null)
                    {
                        MessageBox.Show("비밀번호가 입력되지 않았습니다.");
                        return;

                    }
                    cmd.Parameters.AddWithValue("@userPassword", hashPassword);

                    conn.Open();

                    result = cmd.ExecuteNonQuery();

                    if (result == 0)
                    {
                        MessageBox.Show("회원가입에 실패했습니다. 다시 시도해주세요.");
                        return;
                    }

                    // 암호화
                }
                
            }
            else
            {
                MessageBox.Show(비번중복확인.Text);
                return;
            }
            MessageBox.Show("회원가입이 완료되었습니다.");
            로그인창 newForm = new 로그인창();
            newForm.Show();
            Hide();
        }


        public static string HashPassword(string password)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] bytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));

                // 바이트 배열을 문자열로 변환
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // 각 바이트를 16진수로 변환하여 문자열로 추가
                }
                return builder.ToString();
            }
        }
    }
}

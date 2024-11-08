using practiceEXE.비밀번호찾기Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceEXE
{
    public partial class 비밀번호찾기 : Form
    {
        private 비밀번호찾기_controller controller;
        public 비밀번호찾기()
        {
            InitializeComponent();
            this.Load += new EventHandler(비밀번호찾기_Load);
            controller = new 비밀번호찾기_controller();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(뒤로가기_KeyDown);
            this.KeyDown += new KeyEventHandler(찾기버튼_KeyDown);
        }

        private void 비밀번호찾기_Load(object? sender, EventArgs e)
        {
            제목.Left = (this.ClientSize.Width - 제목.Width) / 2;
            아이디패널.Left = (this.ClientSize.Width - 아이디패널.Width) / 2;
            찾기버튼.Left = (this.ClientSize.Width - 찾기버튼.Width) / 2;
            뒤로가기.Left = (this.ClientSize.Width - 뒤로가기.Width) / 2;
        }

        private void 찾기버튼_Click(object? sender, EventArgs e)
        {
            string userId = 아이디박스.Text;

            if(string.IsNullOrEmpty(아이디박스.Text))
            {
                MessageBox.Show("아이디가 입력해 주세요.");
                return;
            }

            if (!controller.CheckUserIdAvailability(아이디박스.Text))
            {
                MessageBox.Show("아이디가 존재하지 않습니다.");
                return;
            }
            else
            {
                MessageBox.Show("존재하는 아이디입니다.");
                비밀번호변경 form = new 비밀번호변경(userId);
                form.Show();
                Hide();
            }
        }

        private void 뒤로가기_Click(object? sender, EventArgs e)
        {
            로그인창 newForm = new 로그인창();
            newForm.Show();
            Hide();
        }

        private void 뒤로가기_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                뒤로가기_Click(sender, e);
            }
        }

        private void 찾기버튼_KeyDown(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                찾기버튼_Click(sender, e);
            }
        }
    }

}

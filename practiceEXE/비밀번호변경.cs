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
    public partial class 비밀번호변경 : Form
    {
        private string userId;

        private 비밀번호찾기_controller controller;
        public 비밀번호변경(string userId)
        {
            InitializeComponent();
            controller = new 비밀번호찾기_controller();
            this.Load += new EventHandler(비밀번호찾기_Load);
            this.userId = userId;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(뒤로가기_KeyDown);
            this.KeyDown += new KeyEventHandler(변경버튼_KeyDown);
        }

        private void 비밀번호찾기_Load(object? sender, EventArgs e)
        {
            제목.Left = (this.ClientSize.Width - 제목.Width) / 2;
            비밀번호패널.Left = (this.ClientSize.Width - 비밀번호패널.Width) / 2;
            변경버튼.Left = (this.ClientSize.Width - 변경버튼.Width) / 2;
            뒤로가기.Left = (this.ClientSize.Width - 뒤로가기.Width) / 2;
        }

        private void 변경버튼_Click(object? sender, EventArgs e)
        {
            string newPw = 비밀번호BOX.Text;

            controller.updateUser(userId, newPw);

            MessageBox.Show("비밀번호가 변경되었습니다.");

            로그인창 newForm = new 로그인창();
            newForm.Show();
            Hide();
        }

        private void 뒤로가기_Click(object? sender, EventArgs e)
        {
            비밀번호찾기 newForm = new 비밀번호찾기();
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

        private void 변경버튼_KeyDown(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                변경버튼_Click(sender, e);
            }
        }
    }
}

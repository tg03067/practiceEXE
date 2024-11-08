using practiceEXE.게시판Model;
using practiceEXE.게시판Model.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceEXE
{
    public partial class 글보기 : Form
    {

        private BoardListSelect boardListSelect;
        private BoardModelRes BoardModelRes;
        private board_controller controller;
        private BoardModelReq BoardModelReq;
        private bool isExiting = false;
        private bool isEditing = false;
        public 글보기(BoardListSelect req, BoardModelRes res)
        {
            InitializeComponent();
            this.Load += new EventHandler(글보기_Load);
            this.boardListSelect = req;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(수정_KeyDown);
            this.KeyDown += new KeyEventHandler(목록_KeyDown);
            this.BoardModelRes = res;

            if (boardListSelect == null)
            {
                boardListSelect = new BoardListSelect();
            }
            if (BoardModelRes == null)
            {
                BoardModelRes = new BoardModelRes();
            }
            if (controller == null)
            {
                controller = new board_controller();
            }
            if (BoardModelReq == null)
            {
                BoardModelReq = new BoardModelReq();
            }

            if (boardListSelect != null)
            {
                titlebox.Text = boardListSelect.boardTitle;
                contentbox.Text = boardListSelect.boardContents;
                작성자.Text = boardListSelect.boardWriterName;
            }
        }

        public void 글보기_Load(object? sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            contentbox.Text = boardListSelect.boardContents;
            titlebox.Text = boardListSelect.boardTitle;

            this.ActiveControl = null;
        }

        private void 글보기_FormClosing(object sender, FormClosingEventArgs e)
        {


            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("정말로 종료하시겠습니까?", "확인", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    isExiting = true;
                    Application.Exit();
                }
            }

        }

        private void 목록_KeyDown(object sender, KeyEventArgs e)
        {
            DialogResult result = MessageBox.Show("목록으로 이동하시겠습니까?", "확인", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    목록_Click(sender, e);
                }
            }
            else
            {
                return;
            }
        }

        private void 목록_Click(object sender, EventArgs e)
        {
            게시판 newForm = new 게시판(BoardModelRes);
            newForm.Show();
            Hide();
        }

        private void 수정_KeyDown(object sender, KeyEventArgs e)
        {
            if (수정.Text == "저장")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    수정_Click(sender, e);
                }
            }
        }

        private void 수정_Click(object sender, EventArgs e)
        {
            if (boardListSelect == null)
            {
                boardListSelect = new BoardListSelect();
            }

            if (!isEditing)
            {
                if (boardListSelect.boardWriterName != BoardModelRes.userId)
                {
                    MessageBox.Show("수정 권한이 없습니다.");
                    return;
                }
                // 편집모드
                isEditing = true;
                titlebox.ReadOnly = false;
                contentbox.ReadOnly = false;

                titlebox.BackColor = Color.BurlyWood;
                contentbox.BackColor = Color.BurlyWood;

                boardListSelect.boardContents = contentbox.Text;
                boardListSelect.boardTitle = titlebox.Text;

                수정.Text = "저장";
            }
            else
            {
                // 편집모드에서 저장모드로 전환51


                // 편집모드 종료
                isEditing = false;
                titlebox.ReadOnly = true;
                contentbox.ReadOnly = true;

                titlebox.BackColor = Color.White;
                contentbox.BackColor = Color.White;

                boardListSelect.boardContents = contentbox.Text;
                boardListSelect.boardTitle = titlebox.Text;



                // 수정 내용을 boardListSelect 객체에 저장
                BoardModelReq req = new BoardModelReq
                {
                    boardPk = boardListSelect.boardPk,
                    boardTitle = boardListSelect.boardTitle,
                    boardContents = boardListSelect.boardContents,
                };

                if (controller.updateBoard(req) > 0)
                {
                    MessageBox.Show("수정이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("수정에 실패했습니다.");
                }

                // 실제 데이터베이스에 저장
                //controller.updateBoard(BoardModelReq);

                // 텍스트 버튼 '수정'으로 변경
                수정.Text = "수정";
            }
        }

        private void 삭제_Click(object sender, EventArgs e)
        {
            if(boardListSelect.boardWriterName != BoardModelRes.userId)
            {
                MessageBox.Show("삭제 권한이 없습니다.");
                return;
            }

            DialogResult result = MessageBox.Show("정말로 취소하시겠습니까?", "확인", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                controller.deleteBoard(boardListSelect.boardPk);
                MessageBox.Show("삭제되었습니다.");


                게시판 게시판 = new 게시판(BoardModelRes);
                게시판.Show();
                Hide();
            }
            else
            {
                return;
            }
        }
    }
}

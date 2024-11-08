using practiceEXE.게시판Model;
using practiceEXE.게시판Model.model;
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
    public partial class 게시판 : Form
    {
        private board_controller controller;
        private BoardModelRes boardModelRes;


        private bool isExiting = false;

        // 슬라이딩 메뉴의 최대, 최소 폭 크기
        const int MAX_SLIDING_WIDTH = 200;
        const int MIN_SLIDING_WIDTH = 50;

        // 슬라이딩 메뉴가 보이는/접히는 속도 조절
        const int STEP_SLIDING = 10;

        // 최초 슬라이딩 메뉴 크기
        int _posSliding = 200;

        // 원본 데이터
        BoardModelReq req = new BoardModelReq();

        // 데이터를 담을 테이블
        DataTable table = new DataTable();

        // 필터 기능을 휘한 중간 객체
        DataView dv = new DataView();

        public 게시판(BoardModelRes res)
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(게시판_KeyDown);
            this.KeyDown += new KeyEventHandler(F5_KeyDown);
            this.KeyDown += new KeyEventHandler(checkboxhide_KeyDown);
            boardModelRes = res;

            // Load 이벤트에 조회_Click 메서드 연결
            this.Load += (s, e) => 조회_Click(s, e);
        }

        private void checkboxhide_CheckedChanged(object? sender, EventArgs e)
        {
            timerSliding.Interval = 1;
            if (checkboxhide.Checked == true)
            {
                // 슬라이딩 메뉴가 접혔을 때, 메뉴 버튼의 표시
                button1.Text = "1";
                button2.Text = "2";
                button3.Text = "3";
                button4.Text = "4";
                button5.Text = "5";
                logout.Text = "EXIT";
                checkboxhide.Text = ">";
            }
            else
            {
                // 슬라이딩 메뉴가 보였을 때, 메뉴 버튼의 표시
                button1.Text = "버튼1";
                button2.Text = "버튼2";
                button3.Text = "버튼3";
                button4.Text = "버튼4";
                button5.Text = "버튼5";
                logout.Text = "로그아웃";
                checkboxhide.Text = "<";
            }

            // 타이머 시작
            timerSliding.Start();
        }

        private void timerSliding_Tick(object? sender, EventArgs e)
        {
            // 레이아웃 일시 중지
            this.SuspendLayout();

            int padding = 10;
            if (checkboxhide.Checked == true)
            {
                // 슬라이딩 메뉴를 숨기는 동작
                _posSliding -= STEP_SLIDING;
                if (_posSliding <= MIN_SLIDING_WIDTH) timerSliding.Stop();
            }
            else
            {
                // 슬라이딩 메뉴를 보이는 동작
                _posSliding += STEP_SLIDING;
                if (_posSliding >= MAX_SLIDING_WIDTH) timerSliding.Stop();
            }

            panel1.Width = _posSliding;

            // 항상 오른쪽 상단에 위치하도록 설정
            int buttonLeftPadding = 10; // 왼쪽 여백 설정
            글쓰기.Location = new Point(panel1.Right + buttonLeftPadding, 글쓰기.Location.Y);
            dataGridView1.Location = new Point(panel1.Right + buttonLeftPadding, dataGridView1.Location.Y);
            dataGridView1.Width = this.ClientSize.Width - panel1.Width - padding * 2;
            //조회.Location = new Point(dataGridView1.Right + buttonLeftPadding, 조회.Location.Y);



            // 레이아웃 갱신
            this.ResumeLayout();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            로그인창 newForm = new 로그인창();
            newForm.Show();
            Hide();
        }

        private void 게시판_FormClosing(object sender, FormClosingEventArgs e)
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

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            // 열을 수동으로 추가
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "제목", DataPropertyName = "boardTitle", Name = "boardTitle" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "작성자", DataPropertyName = "boardWriterName", Name = "boardWriterName" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "내용", DataPropertyName = "boardContents", Name = "boardContents" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "작성일", DataPropertyName = "createdAt", Name = "createdAt" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "수정일", DataPropertyName = "updatedAt", Name = "updatedAt" });
        }

        private void 조회_Click(object? sender, EventArgs e)
        {
            // DataGridView 초기회 및 열 설정
            dataGridView1.AutoGenerateColumns = false;

            // board_controller의 인스턴스 생성
            board_controller controller = new board_controller();

            // getBoards 메서드를 호출하여 전체 글 목록 조회
            List<BoardListSelect> list = controller.getBoards();

            if (list != null)
            {
                // 가져온 데이터를 DataGridView에 바인딩하여 표시
                dataGridView1.DataSource = list;
            }
            else
            {
                MessageBox.Show("데이터를 가져오는데 실패했습니다.");
            }
        }

        private void 게시판_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void F5_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                조회_Click(sender, e);
            }
        }

        private void checkboxhide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                checkboxhide.Checked = !checkboxhide.Checked;
            }
        }

        private void 글쓰기_Click(object sender, EventArgs e)
        {
            if (boardModelRes != null)
            {
                글쓰기 newForm = new 글쓰기(boardModelRes);
                newForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("사용자 정보가 없습니다.");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 더블클릭을 확인
            if(e.RowIndex >= 0)
            {
                // 더블 클릭된 행을 가져옴.
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // 행에 바인딩된 원본 객체 가져오기
                BoardListSelect board = row.DataBoundItem as BoardListSelect;

                if (board != null)
                {
                    long boardPk = board.boardPk;
                    
                    글보기 newForm = new 글보기(board, boardModelRes);
                    newForm.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("선택된 게시물을 가져올 수 없습니다.");
            }

        }
    }
}

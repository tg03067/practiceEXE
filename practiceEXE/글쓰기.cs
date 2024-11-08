using practiceEXE;
using practiceEXE.common;
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
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace practiceEXE
{
    public partial class 글쓰기 : Form
    {
        private board_controller controller;
        private BoardModelRes boardModelRes;
        private customFileUtils utils;

        // 선택한 이미지 파일 경로
        private string imagePath;
        public 글쓰기(BoardModelRes res)
        {
            InitializeComponent();
            this.Load += new EventHandler(form_load);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(EXIT_KeyDown);
            boardModelRes = res;
            controller = new board_controller();
            utils = new customFileUtils();
        }

        public void form_load(object? sender, EventArgs e)
        {
            제목.Left = (this.ClientSize.Width - 제목.Width) / 2;
            titlepanel.Left = (this.ClientSize.Width - titlepanel.Width) / 2;
            contentspanel.Left = (this.ClientSize.Width - contentspanel.Width) / 2;
            endbutton.Left = (this.ClientSize.Width - endbutton.Width) / 2;
            이미지.Left = (this.ClientSize.Width - 이미지.Width) / 2;
        }

        private void 글쓰기_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("정말로 취소하시겠습니까?", "확인", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    게시판 board = new 게시판(boardModelRes);
                    board.Show();
                    Hide();
                }
            }
        }

        private void EXIT_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void endbutton_Click(object sender, EventArgs e)
        {
            BoardModelReq req = new BoardModelReq();

            string title = Title.Text;
            string contents = contentsbox.Text;
            string image = imagePath;

            BoardModelRes res = new BoardModelRes();

            req.boardTitle = title;
            req.boardContents = contents;
            req.boardWriterName = boardModelRes.userId;



            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("제목을 입력해 주세요.");
                return;
            }
            else if (title.Length > 50)
            {
                MessageBox.Show("제목의 길이가 너무 깁니다.te");
                return;
            }
            else if (string.IsNullOrEmpty(contents))
            {
                MessageBox.Show("내용을 입력해 주세요.");
                return;
            }

            using (var scope = new TransactionScope())
            {
                try
                {
                    // 데이터베이스에 게시글을 삽입하고 생성된 pk값을 가져옴.
                    int result = controller.postBoard(req); // pk반환하게 변경

                    if (result <= 0)
                    {
                        MessageBox.Show("글 등록에 실패했습니다.");
                        return;
                    }

                    req.boardPk = result;

                    // 폴더 생성
                    string folderName = Path.Combine("pic", req.boardPk.ToString());
                    var folderPath = utils.makeFolder(folderName);

                    if (!Directory.Exists(folderPath))
                    {
                        MessageBox.Show($"{folderName} does not exist");
                        return;
                    }

                    // 이미지 파일 랜덤하게 생성 (GUID 사용)
                    string uniquFileName = utils.makeRandomFileName(image);
                    string fullImagePath = Path.Combine(folderName, uniquFileName);

                    MessageBox.Show(fullImagePath);


                    if (pictureBox1.Image != null)
                    {
                        // 모듈화된 메서드로 이미지 저장
                        utils.saveImageToPath(pictureBox1, fullImagePath);

                        // 파일명을 req 객체에 설정하여 데이터베이스에 저장할 수 있게 함
                        req.boardPic = uniquFileName;

                        // 사진 업데이트
                        int updatePic = controller.updatePic(result, req.boardPic);

                        if (updatePic <= 0)
                        {
                            MessageBox.Show("이미지 파일명 저장에 실패했습니다.");
                            return;
                        }
                    }

                    // 커밋 (트랜젝션 완료)
                    scope.Complete();
                    
                    MessageBox.Show("작성이 완료되었습니다.");

                    scope.Dispose();

                    게시판 newForm = new 게시판(boardModelRes);
                    newForm.Show();
                    Hide();
                }
                catch (Exception ex)
                {
                    throw new Exception($"오류가 발생했습니다: {ex.Message}");
                }
            }
        }

        private void 이미지_Click(object sender, EventArgs e)
        {
            imagePath = string.Empty;

            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Environment.CurrentDirectory;

            // 이미지 파일만 선택가능하게
            file.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (file.ShowDialog() == DialogResult.OK) 
            { 
                // 선택한 파일 경로를 imagePath에 저장
                imagePath = file.FileName;

                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            } 
            else if (file.ShowDialog() == DialogResult.Cancel) 
            {
                return;
            }

        }
    }
}


// private void endbutton_Click(object sender, EventArgs e)
//{
//    BoardModelReq req = new BoardModelReq();

//    string title = Title.Text;
//    string contents = contentsbox.Text;
//    string image = imagePath;

//    BoardModelRes res = new BoardModelRes();

//    req.boardTitle = title;
//    req.boardContents = contents;
//    req.boardWriterName = boardModelRes.userId;



//    if (string.IsNullOrEmpty(title))
//    {
//        MessageBox.Show("제목을 입력해 주세요.");
//        return;
//    }
//    else if (title.Length > 50)
//    {
//        MessageBox.Show("제목의 길이가 너무 깁니다.te");
//        return;
//    }
//    else if (string.IsNullOrEmpty(contents))
//    {
//        MessageBox.Show("내용을 입력해 주세요.");
//        return;
//    }

//    using (var scope = new TransactionScope())
//    {
//        try
//        {
//            // 데이터베이스에 게시글을 삽입하고 생성된 pk값을 가져옴.

//            // 이미지 파일 랜덤하게 생성 (GUID 사용)
//            string uniquFileName = utils.makeRandomFileName(image);
//            MessageBox.Show(uniquFileName);
//            string fullImagePath = Path.Combine(utils.uploadPath, uniquFileName);


//            string folderName = string.Format("{0}/{1}", "pic", req.boardPk);
//            utils.makeFolder(folderName);

//            if (pictureBox1.Image != null
//                //&& pictureBox1.ImageLocation != defaultImagePath
//                )
//            {
//                // 모듈화된 메서드로 이미지 저장
//                utils.saveImageToPath(pictureBox1, fullImagePath);

//                // 파일명을 req 객체에 설정하여 데이터베이스에 저장할 수 있게 함
//                req.boardPic = uniquFileName;
//            }


//            // Insert
//            int result = controller.postBoard(req);



//            if (result != 1)
//            {
//                MessageBox.Show("글 등록에 실패했습니다.");
//                return;
//            }



//            MessageBox.Show("작성이 완료되었습니다.");

//            게시판 newForm = new 게시판(boardModelRes);
//            newForm.Show();
//            Hide();
//        }
//        catch (Exception ex)
//        {
//            throw new Exception($"오류가 발생했습니다: {ex.Message}");
//        }
//    }
//}
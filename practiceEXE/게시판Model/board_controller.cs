using Microsoft.IdentityModel.Abstractions;
using practiceEXE.게시판Model.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceEXE.게시판Model
{
    internal class board_controller
    {
        private BoardModel model;

        public board_controller()
        {
            model = new BoardModel();
        }

        // 글 쓰기
        public int postBoard(BoardModelReq req)
        {
            return model.postBoard(req);
        }

        // 글 수정
        public int updateBoard(BoardModelReq req)
        {
            return model.updateBoard(req);
        }

        // 글 삭제
        public int deleteBoard(long boardPk)
        {
            return model.deleteBoard(boardPk);
        }

        // 전체 글 조회
        public List<BoardListSelect> getBoards()
        {
            return model.BoardSelectAll();
        }

        // 글 상세 조회
        public BoardListSelect getBoardOne(int boardPk)
        {
            return model.BoardSelectOne(boardPk);
        }

        // 사진 업데이트
        public int updatePic(int boardPk, string fileName)
        {
            return model.updateBoardPic(boardPk, fileName);
        }
    }
}

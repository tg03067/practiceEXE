using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceEXE.비밀번호찾기Model
{
    internal class 비밀번호찾기_controller
    {
        private 비밀번호찾기_Model model;
        public 비밀번호찾기_controller()
        {
            model = new 비밀번호찾기_Model();
        }

        // 아이디 찾기
        public bool CheckUserIdAvailability(string userId)
        {
            return model.IsUserIdExists(userId);
        }

        // 비밀번호 변경
        public int updateUser(string userId, string newPw)
        {
            string hashPassword = 회원가입창.HashPassword(newPw);
            return model.UpdatePassword(userId, hashPassword);
        }
    }
}

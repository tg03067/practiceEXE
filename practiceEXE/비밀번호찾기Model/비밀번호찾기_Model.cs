using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceEXE.비밀번호찾기Model
{
    internal class 비밀번호찾기_Model
    {
        private string connectionString = "Server=192.168.0.69,1433;Database=practicedb;Trusted_Connection=True;TrustServerCertificate=True;";


        public bool IsUserIdExists(string userId)
        {
            string query = $"select count(*) from [user] where user_id = '{userId}'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("userId", userId);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
                return false;
            }
        }

        public int UpdatePassword(string userId, string newPassword)
        {
            string query = $"update [user] set user_password = '{newPassword}' where user_id = '{userId}'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("userId", userId);

                conn.Open();
                int count = cmd.ExecuteNonQuery();

                return count ;
            }
        }
    }
}

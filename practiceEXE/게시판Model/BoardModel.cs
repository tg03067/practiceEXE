using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using practiceEXE.게시판Model.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceEXE.게시판Model
{
    internal class BoardModel
    {
        string connectionString = "Server=192.168.0.69,1433;Database=practicedb;Trusted_Connection=True;TrustServerCertificate=True;";
        
        // 로그인
        public BoardModelRes LogIn(string userId)
        {
            BoardModelRes res = null; // 로그인 실패 시 null 반환
            //long userPk = 0;
            string query = "select * from [user] where user_id = @user_id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // sqlcommand 설정
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    // 데이터베이스 연결 열고 DataTable 채움
                    //conn.Open();
                    adapter.Fill(dt); // adapter에 open(); 기능이 있음.

                    // DataTable에서 데이터 읽기
                    if(dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        // BoardModelRes 객체 초기화
                        res = new BoardModelRes
                        {
                            userId = row["user_id"].ToString(),
                            userPk = Convert.ToInt64(row["user_pk"]),
                            userPassword = row["user_password"].ToString()
                        };
                    }
                    

                    // 쿼리 실행 및 결과 읽기
                    //using (SqlDataReader result = cmd.ExecuteReader())
                    //{

                    //    res = new BoardModelRes
                    //    {
                    //        userPk = result.GetInt32(result.GetOrdinal("user_pk")),
                    //        userId = result.GetString(result.GetOrdinal("user_id")),
                    //        userPassword = result.GetString(result.GetOrdinal("user_password"))
                    //    };
                    //}

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return res;
        }
        // 글 등록
        public int postBoard(BoardModelReq req)
        {
            string query = "insert into [board](board_title, board_contents, board_pic, board_writer_id, created_at) values (@board_title, @board_contents, @board_pic, @board_writer_id, getdate());" +
                "select scope_identity();"; // 마지막으로 삽입된 id 가져오기

            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@board_title", req.boardTitle);
                    cmd.Parameters.AddWithValue("@board_contents", req.boardContents);
                    cmd.Parameters.AddWithValue("@board_writer_id", req.boardWriterName);
                    if(req.boardPic != null)
                    {
                        cmd.Parameters.AddWithValue("@board_pic", req.boardPic);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@board_pic", DBNull.Value);
                    }
                    
                    conn.Open();

                    // ExecuteScalar를 사용하여 scope_identity 값 가져오기
                    var affectedRows = cmd.ExecuteScalar();
                    int board_pk = Convert.ToInt32(affectedRows);

                    //if(affectedRows < 0)
                    //{
                    //    throw new Exception("데이터 삽입에 실패했습니다. 영향받은 행이 없습니다.");
                    //}

                    return board_pk;

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }
        // 글 수정
        public int updateBoard(BoardModelReq req)
        {
            string query = $"update [board] set board_title = @board_title" +
                $", board_contents = @board_contents" +
                $", board_pic = @board_pic" +
                $", updated_at = GETDATE()" +
                $" where board_pk = @board_pk";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@board_title", req.boardTitle);
                    cmd.Parameters.AddWithValue("@board_contents", req.boardContents);
                    cmd.Parameters.AddWithValue("@board_pic", req.boardPic ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@board_pk",req.boardPk);


                    conn.Open();
                    int affectedRows = cmd.ExecuteNonQuery();

                    if(affectedRows < 0)
                    {
                        throw new Exception("데이터 수정에 실패했습니다. 영향받은 행이 없습니다.");
                    }

                    return affectedRows;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show (e.Message);
                return -1;
            }
        }
        // 글 삭제
        public int deleteBoard(long boardPk)
        {
            string query = "delete from [board] where board_pk = @board_pk";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@board_pk", boardPk);

                    conn.Open();
                    int deletedRows = cmd.ExecuteNonQuery();

                    if (deletedRows < 0)
                    {
                        throw new Exception("데이터 삭제에 실패했습니다. 영향받은 행이 없습니다.");
                    }

                    return deletedRows;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }
        // 글 전체 조회
        public List<BoardListSelect> BoardSelectAll()
        {
            string query = "select top 10 * from [board] a left join [user] b on a.board_writer_id = b.user_id order by created_at desc";

            // 추후 페이징 처리를 했을 시 변경해야하는 쿼리문.
            // string quety = "select * from [board] a left join [user] b on a.board_writer_id = b.user_id order by a.created_at offset ( {페이지} - 1 ) * {갯수} rows fetch next {갯수} rows only";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand (query, conn);

                    List<BoardListSelect> list = new List<BoardListSelect>();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();


                    adapter.Fill (dt);

                    if (dt.Rows.Count > 0)
                    {

                        foreach (DataRow dr in dt.Rows)
                        {

                            BoardListSelect board = new BoardListSelect
                            {
                                boardPk = dr["board_pk"] != DBNull.Value ? Convert.ToInt64(dr["board_pk"]) : 0,
                                boardTitle = dr["board_title"]?.ToString() ?? string.Empty,
                                boardContents = dr["board_contents"]?.ToString() ?? string.Empty,
                                boardWriterName = dr["user_id"]?.ToString() ?? string.Empty,
                                createdAt = dr["created_at"] != DBNull.Value ? Convert.ToDateTime(dr["created_at"]) : DateTime.Now,
                                updatedAt = dr["updated_at"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(dr["updated_at"]) : null,
                            };

                            list.Add(board);
                        }
                    }
                    return list;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                throw new Exception(e.Message);
            }
        }
        // 글 상세 조회
        public BoardListSelect BoardSelectOne(int boardPk)
        {
            string query = "select * from [board] where board_pk = @boardpk";

            DateTime? date = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@boardpk", boardPk);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        BoardListSelect board = new BoardListSelect
                        {
                            boardPk = reader["board_pk"] != DBNull.Value ? Convert.ToInt64(reader["board_pk"]) : 0,
                            boardTitle = reader["board_title"]?.ToString() ?? string.Empty,
                            boardContents = reader["board_contents"]?.ToString() ?? string.Empty,
                            boardWriterName = reader["user_id"]?.ToString() ?? string.Empty,
                            createdAt = reader["created_at"] != DBNull.Value ? Convert.ToDateTime(reader["created_at"]) : DateTime.Now,
                            updatedAt = reader["updated_at"] != DBNull.Value ? Convert.ToDateTime(reader["updated_at"]) : DateTime.Now,
                        };

                        return board;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message) ;
                throw new Exception(ex.Message);
            }
        }
        // 사진 DB에 등록
        public int updateBoardPic(long boardPk, string fileName)
        {
            string query = "update [board] set board_pic = @boardPic where board_pk = @boardPk";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@boardPic", fileName);
                    cmd.Parameters.AddWithValue("@boardPk", boardPk);

                    conn.Open();

                    int affectRow = cmd.ExecuteNonQuery();

                    return affectRow;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

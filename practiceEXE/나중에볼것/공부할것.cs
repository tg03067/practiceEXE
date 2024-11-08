using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceEXE
{
    internal class 공부할것
    {
        public static DataTable GetDb(string connStr, string query, SqlParameter[]? parameters, int? commandTime)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (commandTime != null)
                {
                    cmd.CommandTimeout = commandTime.Value;
                }

                cmd.CommandType = CommandType.Text;

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                {
                    try
                    {
                        adp.Fill(dt);
                    }
                    catch
                    {
                        dt = null;
                    }
                }
            }
            return dt;
        }
    }
}

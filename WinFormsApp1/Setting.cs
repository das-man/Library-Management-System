using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace library
{
    class Setting
    {
        MySqlConnection con;
        public MySqlConnection connect()
        {
            string cs = @"server=localhost;database=maybebook;uid=root;password=password;";
            con = new MySqlConnection(cs);
            con.Open();
            return con;
        }

        public MySqlCommand command(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, connect());
            return cmd;
        }

        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        public MySqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }

        public void SetClose()
        {
            con.Close();
        }
    }
}

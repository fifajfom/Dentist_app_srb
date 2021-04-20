using MySql.Data.MySqlClient;
using System.Configuration;

namespace OrdinacijaMihajlovic
{

    public class Mysql_main
    {
        #region MySqlConnection Connection
        readonly MySqlConnection conn = new
        MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        #endregion

        public string rezultat;
        public void Mysql2()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select prv from tst", conn);

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                     rezultat = dr["prv"].ToString();

                }

            }
        }

    }
}
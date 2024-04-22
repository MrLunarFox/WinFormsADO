using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsADO
{
    internal class Connection
    {
        private static string connectionString = "server=btssio.dedyn.io;port=3306;Database=HISJOSU_biblioADO;Uid=HISJOSU;password=14022004";
        private static MySqlConnection maConnection = new MySqlConnection(connectionString);

        public static MySqlConnection MaConnection { get => maConnection; }
    }
}

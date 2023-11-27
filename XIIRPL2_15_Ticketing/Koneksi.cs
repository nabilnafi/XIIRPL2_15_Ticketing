using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIIRPL2_15_Ticketing
{
    internal class Koneksi
    {
        public static NpgsqlConnection conn = new NpgsqlConnection("server=127.0.0.1;Port=5432;Database=db_ticket_xii_rpl_2_15;" + "User Id=postgres;Password=admin;");
    }
}

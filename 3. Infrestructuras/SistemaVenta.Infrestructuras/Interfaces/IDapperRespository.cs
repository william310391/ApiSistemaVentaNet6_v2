using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Infrestructuras.Interfaces
{
    public interface IDapperRespository
    {
        string cnSQL { get; set; }
        SqlConnection sqlConection { get; set; }

        string cnMYSQL { get; set; }
        MySqlConnection mySqlConection { get; set; }
    }
}

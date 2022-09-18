using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using SistemaVenta.Infrestructuras.Interfaces;
using Dapper.FluentMap;
using SistemaVenta.Infrestructuras.Data.Configuration;

namespace SistemaVenta.Infrestructuras.Repositories
{
    public class DapperRespository: IDapperRespository
    {
        private readonly IConfiguration _configuration;
        private string _cnSQL;
        private string _cnMySQL;

        private SqlConnection _sqlConection;
        private MySqlConnection _mySqlConnection;


        public DapperRespository(IConfiguration configuration)
        {    
            _configuration = configuration;
            _cnSQL = _configuration.GetConnectionString("CNSQL");
            _cnMySQL = _configuration.GetConnectionString("CNMYSQL");
            _sqlConection = new SqlConnection(_cnSQL);
            _mySqlConnection = new MySqlConnection(_cnMySQL);





        }

        public string cnSQL { get => _cnSQL; set => _cnSQL = value; }
        public SqlConnection sqlConection { get => _sqlConection; set => _sqlConection = value; }


        public string cnMYSQL { get => _cnMySQL; set => _cnMySQL = value; }
        public MySqlConnection mySqlConection { get => _mySqlConnection; set => _mySqlConnection = value; }

    }
}

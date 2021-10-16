using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ProvaSalva.Banco
{
    class BancoDB
    {
        public string StringConn { get; set; }
        public SqlConnection ConnDB { get; set; }
        public BancoDB()
        {
            try
            {
                StringConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Marcos\\Desktop\\ProvaSalva\\ProvaSalva\\Banco\\Database1.mdf;Integrated Security=True";
                ConnDB = new SqlConnection(StringConn);
                ConnDB.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataTable SQLQuery(string SQL)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand(SQL, ConnDB);
                command.CommandTimeout = 0;
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string SQLCommand(string SQL)
        {
            try
            {
                var myCommand = new SqlCommand(SQL, ConnDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

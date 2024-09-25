using System.Data.SqlClient;

namespace Chamorro.Datos
{
    public class Base
    {
        public SqlConnection SQLServer { get; set; }
        public Base() 
        {
            SQLServer = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mutual de AMR\\Downloads\\Net.DB.Alumno.mdf\";Integrated Security=True;Connect Timeout=30");        
        }
    }
}
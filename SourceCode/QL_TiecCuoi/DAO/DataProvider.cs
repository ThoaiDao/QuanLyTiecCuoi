using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace QL_TiecCuoi.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }

            set
            {
                instance = value;
            }
        }
        public DataProvider() { }
        private string connectionSTR = "Data Source=DESKTOP-8T75EG0\\QUYNH;Initial Catalog=QuanLyTiecCuoi;Integrated Security=True";// chuoi xac dinh ket noi voi database nao

        public DataTable ExecuteQuery(string query)
        {

            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // ket noi layer xuong server
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);//cau truy van thuc thi
                SqlDataAdapter adapter = new SqlDataAdapter(command);//trung gian lay du lieu
                adapter.Fill(data);
                connection.Close();
               
            }
            return data;
        }

        public bool ExecuteWrite(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // ket noi layer xuong server
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);//cau truy van thuc thi
                command.ExecuteReader();
                Console.Write("test");
               
                connection.Close();

            }
            return true;
        }

    }
    
}


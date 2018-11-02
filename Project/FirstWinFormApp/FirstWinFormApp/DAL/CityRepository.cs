using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstWinFormApp.Models;

namespace FirstWinFormApp.DAL
{
    public class CityRepository
    {
        static string conString = @"Server=BITMTRAINER-301\SQLEXPRESS; Database=StudentInfo_53_13; Integrated Security = true;";
        SqlConnection con = new SqlConnection(conString);
        public DataTable GetCityBindingSource()
        {
            string query = @"SELECT * FROM Cities";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            //List<City> cities = new List<City>();
            //foreach (var a in dt)
            //{
            //    City city = new City();
            //    city.Id = Convert.ToInt32(a["Id"]);
            //    city.Name = a["Name"].ToString();
                
            //    cities.Add(city);

            //}

            //return cities;

            return dt;
        }
    }
}

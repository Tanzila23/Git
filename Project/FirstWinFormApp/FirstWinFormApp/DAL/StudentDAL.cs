using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstWinFormApp.Models;

namespace FirstWinFormApp.DAL
{
    public class StudentDaL
    {
        static string conString = @"Server=BITMTRAINER-301\SQLEXPRESS; Database=StudentInfo_53_13; Integrated Security = true;";
        SqlConnection con = new SqlConnection(conString);
        public bool Save(Student student)
        {

            string query = @"INSERT INTO Students
                (Name, Address, ContactNo, CityId, Email, RegNo, DateOfBirth, AdmissionDate)
                VALUES('" + student.Name + "', '" + student.Address + "'," +
                           "'" + student.ContactNo + "'," + student.CityId + ",'" + student.Email + "', '" + student.RegNo + "','" + student.DateOfBirth + "','" + student.AdmissionDate + "')";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int rowAffected = command.ExecuteNonQuery();
            con.Close();
            if (rowAffected > 0)
            {
                return true;
            }
            return false;
        }
    }
}

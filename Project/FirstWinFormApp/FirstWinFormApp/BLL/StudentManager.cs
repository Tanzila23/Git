using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstWinFormApp.DAL;
using FirstWinFormApp.Models;

namespace FirstWinFormApp.BLL
{
    public class StudentManager
    {
        StudentDaL _studentDaL= new StudentDaL();
        public bool Save(Student student)
        {
            //If ligical Operation
            bool isSaved = _studentDaL.Save(student);
            return isSaved;
        }
    }
}

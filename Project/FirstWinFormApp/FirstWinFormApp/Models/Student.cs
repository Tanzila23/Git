using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWinFormApp.Models
{
    public class Student
    {

        //field
        private string _name;
        private string _address;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public string Address
        {
            get { return _address; }
            set
            {
                if (value.Length > 3)
                {
                    _address = value;
                }
            }
        }


        public int Id { get; set; }
        public string ContactNo { get; set; }
        public int CityId { get; set; }
        public string Email { get; set; }
        public string RegNo { get; set; }
        public string DateOfBirth { get; set; }
        public string AdmissionDate { get; set; }



        public string GetFullName()
        {
            return _name;
        }

    }



}

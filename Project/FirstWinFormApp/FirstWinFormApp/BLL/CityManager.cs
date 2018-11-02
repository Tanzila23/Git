using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstWinFormApp.DAL;

namespace FirstWinFormApp.BLL
{
    public class CityManager
    {
        CityRepository _cityRepository = new CityRepository();
        public DataTable GetCityBindingSource()
        {
            DataTable dt = _cityRepository.GetCityBindingSource();
            return dt;
        }
    }
}

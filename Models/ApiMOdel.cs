using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPasantiaOIS.Models
{
    public class ApiMOdel
    {

        /* para api */

        public int id { get; set; }
        public string title { get; set; }
        public float price { get; set; }
        public string descripcion { get; set; }
        public string categoria { get; set; }
        public string image { get; set; }
        public float rating { get; set; }
        public int count { get; set; }

        public static implicit operator ApiMOdel(List<ApiMOdel> v)
        {
            throw new NotImplementedException();
        }
    }
}
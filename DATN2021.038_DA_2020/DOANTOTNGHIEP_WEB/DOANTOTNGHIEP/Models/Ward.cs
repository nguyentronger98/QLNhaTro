using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOANTOTNGHIEP.Models
{
    public class Ward
    {
        public int id_xa { get; set; }
        public string name { get; set; }
        public string prefix { get; set; }
        public int id_tinh { get; set; }
        public int id_huyen { get; set; }
    }
}
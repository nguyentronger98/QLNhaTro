using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOANTOTNGHIEP.Models
{
    public class District
    {
        public int id_huyen { get; set; }
        public string name { get; set; }
        public string prefix { get; set; }
        public int province_id { get; set; }
    }
}
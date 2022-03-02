using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
    public class ThietBi
    {
        public ThietBi(string matb, string tentb)
        {
            this.MATB = matb;
            this.TENTB = tentb;
        }
        public ThietBi(DataRow row)
        {
            this.MATB = row["MATB"].ToString();
            this.TENTB = row["TENTB"].ToString();
        }
        private string _MATB;

        public string MATB
        {
            get { return _MATB; }
            set { _MATB = value; }
        }
        private string _TENTB;

        public string TENTB
        {
            get { return _TENTB; }
            set { _TENTB = value; }
        }
    }
}

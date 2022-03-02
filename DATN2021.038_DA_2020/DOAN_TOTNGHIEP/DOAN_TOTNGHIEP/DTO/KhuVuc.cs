using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
    public class KhuVuc
    {
        public KhuVuc(string makv, string tenkv)
        {
            this.MAKV = makv;
            this.TENKV = tenkv;
        }
        public KhuVuc(DataRow row)
        {
            this.MAKV = row["MAKV"].ToString();
            this.TENKV = row["TENKV"].ToString();
        }
        private string _MAKV;

        public string MAKV
        {
            get { return _MAKV; }
            set { _MAKV = value; }
        }
        private string _TENKV;

        public string TENKV
        {
            get { return _TENKV; }
            set { _TENKV = value; }
        }
    }
}

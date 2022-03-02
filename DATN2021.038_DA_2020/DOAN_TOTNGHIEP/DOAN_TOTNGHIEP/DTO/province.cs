using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
    public class province
    {
        public province(int id, string _name, string _code)
        {
            this.id = id;
            this._name = _name;
            this._code = _code;
        }
        public province(DataRow row)
        {
            this.id = int.Parse(row["id"].ToString());
            this._name = row["_name"].ToString();
            this._code = row["_code"].ToString();
        }
        private int id;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _code;

        public string code
        {
            get { return _code; }
            set { _code = value; }
        }
    }
}

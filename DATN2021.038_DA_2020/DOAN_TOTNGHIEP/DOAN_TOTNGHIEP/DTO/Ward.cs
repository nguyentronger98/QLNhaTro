using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
     public class Ward
    {
         public Ward(int id, string name, string prefix, int province_id, int district_id)
         {
             this.Id = id;
             this.Name = name;
             this.Prefix = prefix;
             this.Province_id = province_id;
             this.District_id = district_id;
         }
         public Ward(DataRow row)
         {
             this.Id = int.Parse(row["id"].ToString());
             this.Name = row["_name"].ToString();
             this.Prefix = row["_prefix"].ToString();
             this.Province_id = int.Parse(row["_province_id"].ToString());
             this.District_id = int.Parse(row["_district_id"].ToString());
         }
         private int _id;

         public int Id
         {
             get { return _id; }
             set { _id = value; }
         }
         private string _name;

         public string Name
         {
             get { return _name; }
             set { _name = value; }
         }
         private string _prefix;

         public string Prefix
         {
             get { return _prefix; }
             set { _prefix = value; }
         }
         private int _province_id;

         public int Province_id
         {
             get { return _province_id; }
             set { _province_id = value; }
         }
         private int _district_id;

         public int District_id
         {
             get { return _district_id; }
             set { _district_id = value; }
         }
    }
}

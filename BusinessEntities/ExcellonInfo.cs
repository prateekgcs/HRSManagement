using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class ExcellonInfo
    {
        public int EmployeeId { get; set; }
        public string Email { get; set; }
        public string EnterpriseId { get; set; }
        public int Level { get; set; }
        public DateTime DateHired { get; set; }
        public string WorkGroup { get; set; }
        public int Speciality { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }


        public ExcellonInfo()
        {

        }


        public ExcellonInfo(int EmployeeId, string Email, string EnterpriseId, int Level, DateTime DateHired, string WorkGroup, int Specaility, string Status, int CreatedBy, int LastModifiedBy)
        {

        }
    }
}

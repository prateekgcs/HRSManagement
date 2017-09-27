using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class ProjectInfo
    {

        public int ProjId { get; set; }
        public string ProjName { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }


        public ProjectInfo()
        {

        }
        public ProjectInfo(int ProjId, string ProjName, string Description,
                           string Client, DateTime StartDate, DateTime EndDate,
                           int CreatedBy, int LastModifiedBy)
        {

        }


    }
}

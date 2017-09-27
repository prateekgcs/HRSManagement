using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class ProjectInfo
    {

        public int ProjId { get; set; }
        public string ProjName { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }


        public ProjectInfo(string ProjName, string Description,
                           string Client, string StartDate, string EndDate,
                           int CreatedBy, int LastModifiedBy)
        {
            this.ProjId = ProjId;
            this.ProjName = ProjName;
            this.Description = Description;
            this.Client = Client;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.CreatedBy = CreatedBy;
            this.LastModifiedBy = LastModifiedBy;
        }

        public ProjectInfo(int ProjId, string ProjName, string Description,
                           string Client, string StartDate, string EndDate,
                           int CreatedBy, int LastModifiedBy)
        {
            this.ProjId = ProjId;
            this.ProjName = ProjName;
            this.Description = Description;
            this.Client = Client;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.CreatedBy = CreatedBy;
            this.LastModifiedBy = LastModifiedBy;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class SkillInfo
    {

        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }
        public int CategoryId { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }


        public SkillInfo()
        {

        }
        public SkillInfo(int SkillId, string SkillName, string SkillDescription,

                        int CategoryId, int CreatedBy, int LastModifiedBy)
        {

        }
    }
}

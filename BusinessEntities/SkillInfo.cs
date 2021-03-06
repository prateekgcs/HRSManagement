﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
   public class SkillInfo
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
            this.SkillId = SkillId;
            this.SkillName = SkillName;
            this.SkillDescription = SkillDescription;
            this.CategoryId = CategoryId;
            this.CreatedBy = CreatedBy;
            this.LastModifiedBy = LastModifiedBy;
        }
    }
}

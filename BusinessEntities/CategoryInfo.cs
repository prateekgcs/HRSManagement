using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class CategoryInfo
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }

        public CategoryInfo()
        {

        }


        public CategoryInfo(int CategoryId, string CategoryName, string CategoryDescription, int CreatedBy, int LastModifiedBy)
        {

        }
    }
}

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Database
    {

        public string createEmployee = "spCreateEmployee";
        public string createProject = "spCreateProject";
        public string createSkill = "spCreateSkill";
        public string createSkillCategory = "spCreateSkillCategory";

        public string getCategoryList = "spGetCategoryList";
        public string getLevelList= "spGetLevelList";
        public string getSpecialityList = "spGetSpecialityList";
        public string getStatusList = "spGetStatusList";

        public string updateEmployee = "spUpdateEmployee";
        public string updateProject = "spUpdateProject";
        public string updateSkill = "spUpdateSkill";
        public string updateSkillCategory = "spUpdateSkillCategory";

        public string viewEmployee = "spViewEmployee";
        public string viewProject = "spViewProject";
        public string viewSkill = "spViewSkill";
        public string viewSkillCategory = "spViewSkillCategory";
        
        public string ConnectionString
        {
            get
            {
                return (System.Configuration.ConfigurationManager.ConnectionStrings["HRSManagement"].ConnectionString);
            }
        }
    }
}

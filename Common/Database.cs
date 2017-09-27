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

        string CreateEmployee = "spCreateEmployee";
        string CreateProject = "spCreateProject";
        string CreateSkill= "spCreateSkill";
        string CreateSkillCategory= "spCreateSkillCategory";

        string GetCategoryList= "spGetCategoryList";
        string GetLevelList= "spGetLevelList";
        string GetSpecialityList= "spGetSpecialityList";
        string GetStatusList= "spGetStatusList";

        string UpdateEmployee= "spUpdateEmployee";
        string UpdateProject= "spUpdateProject";
        string UpdateSkill= "spUpdateSkill";
        string UpdateSkillCategory= "spUpdateSkillCategory";

        string ViewEmployee= "spViewEmployee";
        string ViewProject= "spViewProject";
        string ViewSkill= "spViewSkill";
        string ViewSkillCategory= "spViewSkillCategory";
        
        public string ConnectionString
        {
            get
            {
                return (System.Configuration.ConfigurationManager.ConnectionStrings["HRSManagement"].ConnectionString);
            }
        }

        
    }
}

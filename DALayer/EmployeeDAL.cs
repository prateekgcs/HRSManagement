using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BusinessEntities;
using System.Data;

namespace DALayer
{
    public class EmployeeDAL
    {
        SqlConnection objCon;
        SqlCommand objSC;

        SqlParameter obj_FirstName;
        SqlParameter obj_MiddleName;
        SqlParameter obj_LastName;
        SqlParameter obj_BirthDate;
        SqlParameter obj_Age;
        SqlParameter obj_Gender;
        SqlParameter obj_CivilStatus;
        SqlParameter obj_Religion;
        SqlParameter obj_Citizenship;
        SqlParameter obj_MobileNo;
        SqlParameter obj_HousePhoneNo;
        SqlParameter obj_Street1;
        SqlParameter obj_Street2;
        SqlParameter obj_City;
        SqlParameter obj_State;
        SqlParameter obj_ZipCode;
        SqlParameter obj_Country;
        SqlParameter obj_ProjectProfile;
        SqlParameter obj_SkillProfile;
        SqlParameter obj_EducBackGround;
        SqlParameter obj_Recognitions;
        SqlParameter obj_CreatedBy;
        SqlParameter obj_LastModifiedBy;


        public bool CreateEmployee(EmployeeInfo objEmp)
        {
            objCon = new SqlConnection();
            objSC = new SqlCommand("InsertEmployee", objCon);
            objSC.CommandType = CommandType.StoredProcedure;
            return true;
        }
    }
}

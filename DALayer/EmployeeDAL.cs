using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BusinessEntities;
using System.Data;
using Common;

namespace DALayer
{
    public class EmployeeDAL
    {
        SqlConnection objCon;
        SqlCommand objSC;
        Database objDB;
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
            objDB = new Database();
            objCon = new SqlConnection(objDB.ConnectionString);
            objSC = new SqlCommand(objDB.createEmployee , objCon);
            objSC.CommandType = CommandType.StoredProcedure;

            //Create Parameters

            obj_FirstName = new SqlParameter("@FirstName", SqlDbType.VarChar, 50);
            obj_MiddleName = new SqlParameter("@MiddleName", SqlDbType.VarChar, 50);
            obj_LastName = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
            obj_BirthDate = new SqlParameter("@BirthDate", SqlDbType.DateTime);
            obj_Age = new SqlParameter("@Age", SqlDbType.Int);
            obj_Gender = new SqlParameter("@Gender", SqlDbType.VarChar, 1);
            obj_CivilStatus = new SqlParameter("@CivilStatus", SqlDbType.Int);
            obj_Religion = new SqlParameter("@Religion", SqlDbType.VarChar, 20);
            obj_Citizenship = new SqlParameter("@Citizenship", SqlDbType.VarChar, 15);
            obj_MobileNo = new SqlParameter("@MobileNo", SqlDbType.VarChar, 15);
            obj_Street1 = new SqlParameter("@Street1", SqlDbType.VarChar,100);
            obj_Street2 = new SqlParameter("@Street2", SqlDbType.VarChar, 100);
            obj_City = new SqlParameter("@City", SqlDbType.VarChar, 100);
            obj_State = new SqlParameter("@State", SqlDbType.VarChar, 100);
            obj_ZipCode = new SqlParameter("@ZipCode", SqlDbType.VarChar, 20);
            obj_Country = new SqlParameter("@Country", SqlDbType.VarChar, 100);
            obj_ProjectProfile = new SqlParameter("@ProjectProfile", SqlDbType.VarChar, 100);
            obj_SkillProfile = new SqlParameter("@SkillProfile", SqlDbType.VarChar, 100);
            obj_EducBackGround = new SqlParameter("@EduBackGround", SqlDbType.VarChar, 100);
            obj_Recognitions = new SqlParameter("@Recognitions", SqlDbType.VarChar, 500);
            obj_ProjectProfile = new SqlParameter("@ProjectProfile", SqlDbType.VarChar, 100);
            obj_SkillProfile = new SqlParameter("@SkillProfile", SqlDbType.VarChar, 100);
            obj_EducBackGround = new SqlParameter("@EduBackGround", SqlDbType.VarChar, 100);
            obj_Recognitions = new SqlParameter("@Recognitions", SqlDbType.VarChar, 500);
            obj_CreatedBy = new SqlParameter("@CreatedBy", SqlDbType.Int);
            obj_LastModifiedBy = new SqlParameter("@LastModifiedBy", SqlDbType.Int);

            //Set Directions

            obj_FirstName.Direction = ParameterDirection.Input;
            obj_MiddleName.Direction = ParameterDirection.Input;
            obj_LastName.Direction = ParameterDirection.Input;
            obj_BirthDate.Direction = ParameterDirection.Input;
            obj_Age.Direction = ParameterDirection.Input;
            obj_Gender.Direction = ParameterDirection.Input;
            obj_CivilStatus.Direction = ParameterDirection.Input;
            obj_Designation.Direction = ParameterDirection.Input;
            obj_Department.Direction = ParameterDirection.Input;
            obj_ID.Direction = ParameterDirection.Input;
            obj_Name.Direction = ParameterDirection.Input;
            obj_Designation.Direction = ParameterDirection.Input;
            obj_Department.Direction = ParameterDirection.Input;
            obj_ID.Direction = ParameterDirection.Input;
            obj_Name.Direction = ParameterDirection.Input;
            obj_Designation.Direction = ParameterDirection.Input;
            obj_Department.Direction = ParameterDirection.Input;
            obj_ID.Direction = ParameterDirection.Input;
            obj_Name.Direction = ParameterDirection.Input;
            obj_Designation.Direction = ParameterDirection.Input;

            obj_Department.Direction = ParameterDirection.Input;

            //Add Parameters

            objSC.Parameters.Add(obj_ID);
            objSC.Parameters.Add(obj_Name);
            objSC.Parameters.Add(obj_Designation);
            objSC.Parameters.Add(obj_Department);

            //Assign Values

            obj_ID.Value = id;
            obj_Name.Value = name;
            obj_Designation.Value = designation;
            obj_Department.Value = department;

            return true;
        }
    }
}

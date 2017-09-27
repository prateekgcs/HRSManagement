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
        SqlParameter obj_HomePhoneNo;
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
            obj_HomePhoneNo = new SqlParameter("@HomePhoneNo", SqlDbType.VarChar, 15);
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
            obj_Religion.Direction = ParameterDirection.Input;
            obj_Citizenship.Direction = ParameterDirection.Input;
            obj_MobileNo.Direction = ParameterDirection.Input;
            obj_HomePhoneNo.Direction = ParameterDirection.Input;
            obj_Street1.Direction = ParameterDirection.Input;
            obj_Street2.Direction = ParameterDirection.Input;
            obj_City.Direction = ParameterDirection.Input;
            obj_State.Direction = ParameterDirection.Input;
            obj_ZipCode.Direction = ParameterDirection.Input;
            obj_Country.Direction = ParameterDirection.Input;
            obj_ProjectProfile.Direction = ParameterDirection.Input;
            obj_SkillProfile.Direction = ParameterDirection.Input;
            obj_EducBackGround.Direction = ParameterDirection.Input;
            obj_Recognitions.Direction = ParameterDirection.Input;
            obj_CreatedBy.Direction = ParameterDirection.Input;
            obj_LastModifiedBy.Direction = ParameterDirection.Input;

            //Add Parameters

            objSC.Parameters.Add(obj_FirstName);
            objSC.Parameters.Add(obj_MiddleName);
            objSC.Parameters.Add(obj_LastName);
            objSC.Parameters.Add(obj_BirthDate);
            objSC.Parameters.Add(obj_Age);
            objSC.Parameters.Add(obj_Gender);
            objSC.Parameters.Add(obj_CivilStatus);
            objSC.Parameters.Add(obj_Religion);
            objSC.Parameters.Add(obj_Citizenship);
            objSC.Parameters.Add(obj_MobileNo);
            objSC.Parameters.Add(obj_HomePhoneNo);
            objSC.Parameters.Add(obj_Street1);
            objSC.Parameters.Add(obj_Street2);
            objSC.Parameters.Add(obj_City);
            objSC.Parameters.Add(obj_State);
            objSC.Parameters.Add(obj_ZipCode);
            objSC.Parameters.Add(obj_Country);
            objSC.Parameters.Add(obj_ProjectProfile);
            objSC.Parameters.Add(obj_SkillProfile);
            objSC.Parameters.Add(obj_EducBackGround);
            objSC.Parameters.Add(obj_Recognitions);
            objSC.Parameters.Add(obj_CreatedBy);
            objSC.Parameters.Add(obj_LastModifiedBy);

            //Assign Values

            obj_FirstName.Value = objEmp.FirstName;
            obj_MiddleName.Value = objEmp.MiddleName;
            obj_LastName.Value = objEmp.LastName;
            obj_BirthDate.Value = objEmp.BirthDate;
            obj_Age.Value = objEmp.Age;
            obj_Gender.Value = objEmp.Gender;
            obj_CivilStatus.Value = objEmp.CivilStatus;
            obj_Religion.Value = objEmp.Religion;
            obj_Citizenship.Value = objEmp.Citizenship;
            obj_MobileNo.Value = objEmp.MobileNo;
            obj_HomePhoneNo.Value = objEmp.HousePhoneNo;
            obj_Street1.Value = objEmp.Street1;
            obj_Street2.Value = objEmp.Street2;
            obj_City.Value = objEmp.City;
            obj_State.Value = objEmp.State;
            obj_ZipCode.Value = objEmp.ZipCode;
            obj_Country.Value = objEmp.Country;
            obj_ProjectProfile.Value = objEmp.ProjectProfile;
            obj_SkillProfile.Value = objEmp.SkillProfile;
            obj_EducBackGround.Value = objEmp.EducBackGround;
            obj_Recognitions.Value = objEmp.Recognitions;
            obj_CreatedBy.Value = objEmp.CreatedBy;
            obj_LastModifiedBy.Value = objEmp.LastModifiedBy;

            objCon.Open();

            int noOfRowsAffected = objSC.ExecuteNonQuery();

            objCon.Close();

            if (noOfRowsAffected > 0)
            {
                
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool UpdateEmployee(EmployeeInfo objEmp)
        {
            objDB = new Database();
            objCon = new SqlConnection(objDB.ConnectionString);
            objSC = new SqlCommand(objDB.updateEmployee, objCon);
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
            obj_HomePhoneNo = new SqlParameter("@HomePhoneNo", SqlDbType.VarChar, 15);
            obj_Street1 = new SqlParameter("@Street1", SqlDbType.VarChar, 100);
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
            obj_Religion.Direction = ParameterDirection.Input;
            obj_Citizenship.Direction = ParameterDirection.Input;
            obj_MobileNo.Direction = ParameterDirection.Input;
            obj_HomePhoneNo.Direction = ParameterDirection.Input;
            obj_Street1.Direction = ParameterDirection.Input;
            obj_Street2.Direction = ParameterDirection.Input;
            obj_City.Direction = ParameterDirection.Input;
            obj_State.Direction = ParameterDirection.Input;
            obj_ZipCode.Direction = ParameterDirection.Input;
            obj_Country.Direction = ParameterDirection.Input;
            obj_ProjectProfile.Direction = ParameterDirection.Input;
            obj_SkillProfile.Direction = ParameterDirection.Input;
            obj_EducBackGround.Direction = ParameterDirection.Input;
            obj_Recognitions.Direction = ParameterDirection.Input;
            obj_CreatedBy.Direction = ParameterDirection.Input;
            obj_LastModifiedBy.Direction = ParameterDirection.Input;

            //Add Parameters

            objSC.Parameters.Add(obj_FirstName);
            objSC.Parameters.Add(obj_MiddleName);
            objSC.Parameters.Add(obj_LastName);
            objSC.Parameters.Add(obj_BirthDate);
            objSC.Parameters.Add(obj_Age);
            objSC.Parameters.Add(obj_Gender);
            objSC.Parameters.Add(obj_CivilStatus);
            objSC.Parameters.Add(obj_Religion);
            objSC.Parameters.Add(obj_Citizenship);
            objSC.Parameters.Add(obj_MobileNo);
            objSC.Parameters.Add(obj_HomePhoneNo);
            objSC.Parameters.Add(obj_Street1);
            objSC.Parameters.Add(obj_Street2);
            objSC.Parameters.Add(obj_City);
            objSC.Parameters.Add(obj_State);
            objSC.Parameters.Add(obj_ZipCode);
            objSC.Parameters.Add(obj_Country);
            objSC.Parameters.Add(obj_ProjectProfile);
            objSC.Parameters.Add(obj_SkillProfile);
            objSC.Parameters.Add(obj_EducBackGround);
            objSC.Parameters.Add(obj_Recognitions);
            objSC.Parameters.Add(obj_CreatedBy);
            objSC.Parameters.Add(obj_LastModifiedBy);

            //Assign Values

            obj_FirstName.Value = objEmp.FirstName;
            obj_MiddleName.Value = objEmp.MiddleName;
            obj_LastName.Value = objEmp.LastName;
            obj_BirthDate.Value = objEmp.BirthDate;
            obj_Age.Value = objEmp.Age;
            obj_Gender.Value = objEmp.Gender;
            obj_CivilStatus.Value = objEmp.CivilStatus;
            obj_Religion.Value = objEmp.Religion;
            obj_Citizenship.Value = objEmp.Citizenship;
            obj_MobileNo.Value = objEmp.MobileNo;
            obj_HomePhoneNo.Value = objEmp.HousePhoneNo;
            obj_Street1.Value = objEmp.Street1;
            obj_Street2.Value = objEmp.Street2;
            obj_City.Value = objEmp.City;
            obj_State.Value = objEmp.State;
            obj_ZipCode.Value = objEmp.ZipCode;
            obj_Country.Value = objEmp.Country;
            obj_ProjectProfile.Value = objEmp.ProjectProfile;
            obj_SkillProfile.Value = objEmp.SkillProfile;
            obj_EducBackGround.Value = objEmp.EducBackGround;
            obj_Recognitions.Value = objEmp.Recognitions;
            obj_CreatedBy.Value = objEmp.CreatedBy;
            obj_LastModifiedBy.Value = objEmp.LastModifiedBy;

            objCon.Open();

            int noOfRowsAffected = objSC.ExecuteNonQuery();

            objCon.Close();

            if (noOfRowsAffected > 0)
            {

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

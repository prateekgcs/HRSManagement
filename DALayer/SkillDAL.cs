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
    class SkillDAL
    {
        SqlConnection objCon;
        SqlCommand objSC;
        Database objDB;
        SqlParameter obj_SkillId;
        SqlParameter obj_SkillName;
        SqlParameter obj_SkillDescription;
        SqlParameter obj_CategoryId;
        SqlParameter obj_CreatedBy;
        SqlParameter obj_LastModifiedBy;


        public bool CreateSkill(SkillInfo objSkill)
        {
            objDB = new Database();
            objCon = new SqlConnection(objDB.ConnectionString);
            objSC = new SqlCommand(objDB.createSkill, objCon);
            objSC.CommandType = CommandType.StoredProcedure;

            //Create Parameters

            obj_SkillName = new SqlParameter("@SkillName", SqlDbType.VarChar,50);
            obj_SkillDescription = new SqlParameter("@SkillDescription", SqlDbType.VarChar, 100);
            obj_CategoryId = new SqlParameter("@CtaegoryId", SqlDbType.Int);
            obj_CreatedBy = new SqlParameter("@CreatedBy", SqlDbType.Int);
            obj_LastModifiedBy = new SqlParameter("@LastModifiedBy", SqlDbType.Int);

            //directions
            obj_SkillName.Direction = ParameterDirection.Input;
            obj_SkillDescription.Direction= ParameterDirection.Input;
            obj_CategoryId.Direction= ParameterDirection.Input;
            obj_CreatedBy.Direction = ParameterDirection.Input;
            obj_LastModifiedBy.Direction = ParameterDirection.Input;


            //Add Parameters

            objSC.Parameters.Add(obj_SkillName);
            objSC.Parameters.Add(obj_SkillDescription);
            objSC.Parameters.Add(obj_CategoryId);
            objSC.Parameters.Add(obj_CreatedBy);
            objSC.Parameters.Add(obj_LastModifiedBy);

            //Assign Values

            obj_SkillName.Value = objSkill.SkillName;
            obj_SkillDescription.Value= objSkill.SkillDescription;
            obj_CategoryId.Value = objSkill.CategoryId;
            obj_CreatedBy.Value = objSkill.CreatedBy;
            obj_LastModifiedBy.Value = objSkill.LastModifiedBy;



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


        public bool UpdateSkill(SkillInfo objSkill)
        {
            objDB = new Database();
            objCon = new SqlConnection(objDB.ConnectionString);
            objSC = new SqlCommand(objDB.createSkill, objCon);
            objSC.CommandType = CommandType.StoredProcedure;

            //Create Parameters

            obj_SkillName = new SqlParameter("@SkillName", SqlDbType.VarChar, 50);
            obj_SkillDescription = new SqlParameter("@SkillDescription", SqlDbType.VarChar, 100);
            obj_CategoryId = new SqlParameter("@CtaegoryId", SqlDbType.Int);
            obj_CreatedBy = new SqlParameter("@CreatedBy", SqlDbType.Int);
            obj_LastModifiedBy = new SqlParameter("@LastModifiedBy", SqlDbType.Int);

            //directions
            obj_SkillName.Direction = ParameterDirection.Input;
            obj_SkillDescription.Direction = ParameterDirection.Input;
            obj_CategoryId.Direction = ParameterDirection.Input;
            obj_CreatedBy.Direction = ParameterDirection.Input;
            obj_LastModifiedBy.Direction = ParameterDirection.Input;


            //Add Parameters

            objSC.Parameters.Add(obj_SkillName);
            objSC.Parameters.Add(obj_SkillDescription);
            objSC.Parameters.Add(obj_CategoryId);
            objSC.Parameters.Add(obj_CreatedBy);
            objSC.Parameters.Add(obj_LastModifiedBy);

            //Assign Values



            obj_SkillName.Value = objSkill.SkillName;
            obj_SkillDescription.Value = objSkill.SkillDescription;
            obj_CategoryId.Value = objSkill.CategoryId;
            obj_CreatedBy.Value = objSkill.CreatedBy;
            obj_LastModifiedBy.Value = objSkill.LastModifiedBy;



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

        public bool ViewSkill(SkillInfo objSkill)
        {
            objDB = new Database();
            objCon = new SqlConnection(objDB.ConnectionString);
            objSC = new SqlCommand(objDB.createSkill, objCon);
            objSC.CommandType = CommandType.StoredProcedure;

            //Create Parameters
            obj_SkillId = new SqlParameter("@SkillId", SqlDbType.Int);
            obj_SkillName = new SqlParameter("@SkillName", SqlDbType.VarChar, 50);
            obj_SkillDescription = new SqlParameter("@SkillDescription", SqlDbType.VarChar, 100);
            obj_CategoryId = new SqlParameter("@CtaegoryId", SqlDbType.Int);
            obj_CreatedBy = new SqlParameter("@CreatedBy", SqlDbType.Int);
            obj_LastModifiedBy = new SqlParameter("@LastModifiedBy", SqlDbType.Int);

            //directions
            obj_SkillId.Direction = ParameterDirection.Input;
            obj_SkillName.Direction = ParameterDirection.Output;
            obj_SkillDescription.Direction = ParameterDirection.Output;
            obj_CategoryId.Direction = ParameterDirection.Output;
            obj_CreatedBy.Direction = ParameterDirection.Output;
            obj_LastModifiedBy.Direction = ParameterDirection.Output;


            //Add Parameters
            objSC.Parameters.Add(obj_SkillId);
            objSC.Parameters.Add(obj_SkillName);
            objSC.Parameters.Add(obj_SkillDescription);
            objSC.Parameters.Add(obj_CategoryId);
            objSC.Parameters.Add(obj_CreatedBy);
            objSC.Parameters.Add(obj_LastModifiedBy);

            //Assign Values

            obj_SkillId.Value = objSkill.SkillId;


            //obj_SkillName.Value = objSkill.SkillName;
            //obj_SkillDescription.Value = objSkill.SkillDescription;
            //obj_CategoryId.Value = objSkill.CategoryId;
            //obj_CreatedBy.Value = objSkill.CreatedBy;
            //obj_LastModifiedBy.Value = objSkill.LastModifiedBy;



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

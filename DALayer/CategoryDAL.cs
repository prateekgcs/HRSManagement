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
    class CategoryDAL
    {
        SqlConnection objCon;
        SqlCommand objSC;
        Database objDB;
        SqlParameter obj_CategoryId;
        SqlParameter obj_CategoryName;
        SqlParameter obj_CategoryDescription;
        SqlParameter obj_CreatedBy;
        SqlParameter obj_LastModifiedBy;


        public bool CreateCategory(CategoryInfo objCat)
        {
            objDB = new Database();
            objCon = new SqlConnection(objDB.ConnectionString);
            objSC = new SqlCommand(objDB.createSkillCategory, objCon);
            objSC.CommandType = CommandType.StoredProcedure;

            //Create Parameters

             obj_CategoryName = new SqlParameter("@CategoryName", SqlDbType.VarChar,50);
            obj_CategoryDescription = new SqlParameter("@CategoryDescription", SqlDbType.VarChar, 100);
            obj_CreatedBy = new SqlParameter("@CreatedBy", SqlDbType.Int);
            obj_LastModifiedBy = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
 
            
            //Set Directions

            obj_CategoryName.Direction = ParameterDirection.Input;
            obj_CategoryDescription.Direction = ParameterDirection.Input;
            obj_CreatedBy.Direction = ParameterDirection.Input;
           obj_LastModifiedBy .Direction = ParameterDirection.Input;



            //Add Parameters

            objSC.Parameters.Add(obj_CategoryName);
            objSC.Parameters.Add(obj_CategoryDescription);
            objSC.Parameters.Add(obj_CreatedBy);
            objSC.Parameters.Add(obj_LastModifiedBy);

            //Assign Values

            obj_CategoryName.Value = objCat.CategoryName;
            obj_CategoryDescription.Value = objCat.CategoryDescription;
            obj_CreatedBy.Value = objCat.CreatedBy;
            obj_LastModifiedBy.Value = objCat.LastModifiedBy;

            

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
        public bool UpdateCategory(CategoryInfo objCat)
        {
            objDB = new Database();
            objCon = new SqlConnection(objDB.ConnectionString);
            objSC = new SqlCommand(objDB.updateSkillCategory, objCon);
            objSC.CommandType = CommandType.StoredProcedure;

            //Create Parameters

            obj_CategoryName = new SqlParameter("@CategoryName", SqlDbType.VarChar, 50);
            obj_CategoryDescription = new SqlParameter("@CategoryDescription", SqlDbType.VarChar, 100);
            obj_CreatedBy = new SqlParameter("@CreatedBy", SqlDbType.Int);
            obj_LastModifiedBy = new SqlParameter("@LastModifiedBy", SqlDbType.Int);


            //Set Directions

            obj_CategoryName.Direction = ParameterDirection.Input;
            obj_CategoryDescription.Direction = ParameterDirection.Input;
            obj_CreatedBy.Direction = ParameterDirection.Input;
            obj_LastModifiedBy.Direction = ParameterDirection.Input;



            //Add Parameters

            objSC.Parameters.Add(obj_CategoryName);
            objSC.Parameters.Add(obj_CategoryDescription);
            objSC.Parameters.Add(obj_CreatedBy);
            objSC.Parameters.Add(obj_LastModifiedBy);

            //Assign Values

            obj_CategoryName.Value = objCat.CategoryName;
            obj_CategoryDescription.Value = objCat.CategoryDescription;
            obj_CreatedBy.Value = objCat.CreatedBy;
            obj_LastModifiedBy.Value = objCat.LastModifiedBy;



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
        public bool ViewCategory(CategoryInfo objCat)
        {
            objDB = new Database();
            objCon = new SqlConnection(objDB.ConnectionString);
            objSC = new SqlCommand(objDB.viewSkillCategory, objCon);
            objSC.CommandType = CommandType.StoredProcedure;

            //Create Parameters

            obj_CategoryName = new SqlParameter("@CategoryName", SqlDbType.VarChar, 50);
            obj_CategoryDescription = new SqlParameter("@CategoryDescription", SqlDbType.VarChar, 100);
            obj_CreatedBy = new SqlParameter("@CreatedBy", SqlDbType.Int);
            obj_LastModifiedBy = new SqlParameter("@LastModifiedBy", SqlDbType.Int);


            //Set Directions
            obj_CategoryId.Direction = ParameterDirection.Output;
            obj_CategoryName.Direction = ParameterDirection.Input;
            obj_CategoryDescription.Direction = ParameterDirection.Input;
            obj_CreatedBy.Direction = ParameterDirection.Input;
            obj_LastModifiedBy.Direction = ParameterDirection.Input;



            //Add Parameters

            objSC.Parameters.Add(obj_CategoryId);
            objSC.Parameters.Add(obj_CategoryName);
            objSC.Parameters.Add(obj_CategoryDescription);
            objSC.Parameters.Add(obj_CreatedBy);
            objSC.Parameters.Add(obj_LastModifiedBy);

            //Assign Values

            //obj_CategoryName.Value = objCat.CategoryName;
            //obj_CategoryDescription.Value = objCat.CategoryDescription;
            //obj_CreatedBy.Value = objCat.CreatedBy;
            //obj_LastModifiedBy.Value = objCat.LastModifiedBy;
            obj_CategoryId.Value = objCat.CategoryId;



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

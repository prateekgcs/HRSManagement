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
    class ProjectDAL
    {
        SqlConnection objCon;
        SqlCommand objSC;
        Database objDB;
        SqlParameter obj_ProjId;
        SqlParameter obj_ProjName;
        SqlParameter obj_Description;
        SqlParameter obj_Client;
        SqlParameter obj_StartDate;
        SqlParameter obj_EndDate;
        SqlParameter obj_CreatedBy;
        SqlParameter obj_CreatedDate;
        SqlParameter obj_LastModifiedBy;
        SqlParameter obj_LastModifiedDate;


        public bool CreateProject(ProjectInfo objProj)
        {
            objDB = new Database();
            objCon = new SqlConnection(objDB.ConnectionString);
            objSC = new SqlCommand(objDB.createProject, objCon);
            objSC.CommandType = CommandType.StoredProcedure;

            //Create Parameters

           // obj_ProjId = new SqlParameter("@ProjId", SqlDbType.Int);
            obj_ProjName = new SqlParameter("@ProjName", SqlDbType.VarChar, 50);
            obj_Description = new SqlParameter("@Description", SqlDbType.VarChar, 100);
            obj_Client = new SqlParameter("@Client", SqlDbType.VarChar, 50);
            obj_StartDate = new SqlParameter("@StartDate", SqlDbType.DateTime);
            obj_EndDate = new SqlParameter("@EndDate", SqlDbType.DateTime);
            obj_CreatedBy = new SqlParameter("@CreatedBy", SqlDbType.Int);
            //obj_CreatedDate = new SqlParameter("@CreatedDate", SqlDbType.DateTime);
            obj_LastModifiedBy = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
            //obj_LastModifiedDate = new SqlParameter("@LastModifiedDate", SqlDbType.DateTime);



            //Set Directions

           // obj_ProjId.Direction = ParameterDirection.Input;
            obj_ProjName.Direction = ParameterDirection.Input;
            obj_Description.Direction = ParameterDirection.Input;
            obj_Client.Direction = ParameterDirection.Input;
            obj_StartDate.Direction = ParameterDirection.Input;
            obj_EndDate.Direction = ParameterDirection.Input;
            obj_CreatedBy.Direction = ParameterDirection.Input;
           // obj_CreatedDate.Direction = ParameterDirection.Input;
            obj_LastModifiedBy.Direction = ParameterDirection.Input;
           // obj_LastModifiedDate.Direction = ParameterDirection.Input;


            //Add Parameters

           // objSC.Parameters.Add(obj_ProjId);
            objSC.Parameters.Add(obj_ProjName);
            objSC.Parameters.Add(obj_Description);
            objSC.Parameters.Add(obj_Client);
            objSC.Parameters.Add(obj_StartDate);
            objSC.Parameters.Add(obj_EndDate);
            objSC.Parameters.Add(obj_CreatedBy);
            //objSC.Parameters.Add(obj_CreatedDate);
            objSC.Parameters.Add(obj_LastModifiedBy);
           // objSC.Parameters.Add(obj_LastModifiedDate);


            //Assign Values

            obj_ProjName.Value = objProj.ProjName;
            obj_Description.Value = objProj.Description;
            obj_Client.Value = objProj.Client;
            obj_StartDate.Value = objProj.StartDate;
            obj_EndDate.Value = objProj.EndDate;
            obj_CreatedBy.Value = objProj.CreatedBy;
            //obj_CreatedDate.Value = objProj.CreatedDate;
            obj_LastModifiedBy.Value = objProj.LastModifiedBy;
            //obj_LastModifiedDate.Value = objProj.LastModifiedDate;




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

        public bool UpdateProject(ProjectInfo objProj)
        {
            objDB = new Database();
            objCon = new SqlConnection(objDB.ConnectionString);
            objSC = new SqlCommand(objDB.updateProject, objCon);
            objSC.CommandType = CommandType.StoredProcedure;


            //Create Parameters

            // obj_ProjId = new SqlParameter("@ProjId", SqlDbType.Int);
            obj_ProjName = new SqlParameter("@ProjName", SqlDbType.VarChar, 50);
            obj_Description = new SqlParameter("@Description", SqlDbType.VarChar, 100);
            obj_Client = new SqlParameter("@Client", SqlDbType.VarChar, 50);
            obj_StartDate = new SqlParameter("@StartDate", SqlDbType.DateTime);
            obj_EndDate = new SqlParameter("@EndDate", SqlDbType.DateTime);
            obj_CreatedBy = new SqlParameter("@CreatedBy", SqlDbType.Int);
            obj_CreatedDate = new SqlParameter("@CreatedDate", SqlDbType.DateTime);
            obj_LastModifiedBy = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
            obj_LastModifiedDate = new SqlParameter("@LastModifiedDate", SqlDbType.DateTime);



            //Set Directions

            // obj_ProjId.Direction = ParameterDirection.Input;
            obj_ProjName.Direction = ParameterDirection.Input;
            obj_Description.Direction = ParameterDirection.Input;
            obj_Client.Direction = ParameterDirection.Input;
            obj_StartDate.Direction = ParameterDirection.Input;
            obj_EndDate.Direction = ParameterDirection.Input;
            obj_CreatedBy.Direction = ParameterDirection.Input;
            // obj_CreatedDate.Direction = ParameterDirection.Input;
            obj_LastModifiedBy.Direction = ParameterDirection.Input;
            // obj_LastModifiedDate.Direction = ParameterDirection.Input;


            //Add Parameters

            // objSC.Parameters.Add(obj_ProjId);
            objSC.Parameters.Add(obj_ProjName);
            objSC.Parameters.Add(obj_Description);
            objSC.Parameters.Add(obj_Client);
            objSC.Parameters.Add(obj_StartDate);
            objSC.Parameters.Add(obj_EndDate);
            objSC.Parameters.Add(obj_CreatedBy);
            //objSC.Parameters.Add(obj_CreatedDate);
            objSC.Parameters.Add(obj_LastModifiedBy);
            // objSC.Parameters.Add(obj_LastModifiedDate);


            //Assign Values

            obj_ProjName.Value = objProj.ProjName;
            obj_Description.Value = objProj.Description;
            obj_Client.Value = objProj.Client;
            obj_StartDate.Value = objProj.StartDate;
            obj_EndDate.Value = objProj.EndDate;
            obj_CreatedBy.Value = objProj.CreatedBy;
            //obj_CreatedDate.Value = objProj.CreatedDate;
            obj_LastModifiedBy.Value = objProj.LastModifiedBy;
            //obj_LastModifiedDate.Value = objProj.LastModifiedDate;




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

        public bool ViewProject(ProjectInfo objProj)
        {
            objDB = new Database();
            objCon = new SqlConnection(objDB.ConnectionString);
            objSC = new SqlCommand(objDB.viewProject, objCon);
            objSC.CommandType = CommandType.StoredProcedure;

            obj_ProjId = new SqlParameter("@ProjId", SqlDbType.Int);
            obj_ProjName = new SqlParameter("@ProjName", SqlDbType.VarChar, 50);
            obj_Description = new SqlParameter("@Description", SqlDbType.VarChar, 100);
            obj_Client = new SqlParameter("@Client", SqlDbType.VarChar, 50);
            obj_StartDate = new SqlParameter("@StartDate", SqlDbType.DateTime);
            obj_EndDate = new SqlParameter("@EndDate", SqlDbType.DateTime);
            obj_CreatedBy = new SqlParameter("@CreatedBy", SqlDbType.Int);
            obj_CreatedDate = new SqlParameter("@CreatedDate", SqlDbType.DateTime);
            obj_LastModifiedBy = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
            obj_LastModifiedDate = new SqlParameter("@LastModifiedDate", SqlDbType.DateTime);



            //Set Directions

            obj_ProjId.Direction = ParameterDirection.Input;
            obj_ProjName.Direction = ParameterDirection.Output;
            obj_Description.Direction = ParameterDirection.Output;
            obj_Client.Direction = ParameterDirection.Output;
            obj_StartDate.Direction = ParameterDirection.Output;
            obj_EndDate.Direction = ParameterDirection.Output;
            obj_CreatedBy.Direction = ParameterDirection.Output;
            // obj_CreatedDate.Direction = ParameterDirection.Input;
            obj_LastModifiedBy.Direction = ParameterDirection.Output;
            // obj_LastModifiedDate.Direction = ParameterDirection.Input;


            //Add Parameters

            objSC.Parameters.Add(obj_ProjId);
            objSC.Parameters.Add(obj_ProjName);
            objSC.Parameters.Add(obj_Description);
            objSC.Parameters.Add(obj_Client);
            objSC.Parameters.Add(obj_StartDate);
            objSC.Parameters.Add(obj_EndDate);
            objSC.Parameters.Add(obj_CreatedBy);
            //objSC.Parameters.Add(obj_CreatedDate);
            objSC.Parameters.Add(obj_LastModifiedBy);
            // objSC.Parameters.Add(obj_LastModifiedDate);


            //Assign Values
            obj_ProjId.Value = objProj.ProjId;
            //obj_ProjName.Value = objProj.ProjName;
            //obj_Description.Value = objProj.Description;
            //obj_Client.Value = objProj.Client;
            //obj_StartDate.Value = objProj.StartDate;
            //obj_EndDate.Value = objProj.EndDate;
            //obj_CreatedBy.Value = objProj.CreatedBy;
            ////obj_CreatedDate.Value = objProj.CreatedDate;
            //obj_LastModifiedBy.Value = objProj.LastModifiedBy;
            ////obj_LastModifiedDate.Value = objProj.LastModifiedDate;




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







  

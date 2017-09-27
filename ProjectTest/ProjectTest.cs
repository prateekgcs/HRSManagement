using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessEntities;
using DALayer;



namespace Project

{
    [TestClass]
    public class ProjectTest
    {
        [TestMethod]
        public void CreateTest()
        {
            ProjectInfo objPI = new ProjectInfo("xyz", "abhj", "hdh", "2009-09-08", "2007-08-03", 4, 6);
            ProjectDAL objPDal = new ProjectDAL();

            objPDal.CreateProject(objPI);

        }
        public void UpdateTest()
        {
            ProjectInfo objPI = new ProjectInfo("abc", "abhj", "hdh", "2009-09-08", "2007-08-03", 4, 6);
            ProjectDAL objPDal = new ProjectDAL();

            objPDal.UpdateProject(objPI);

        }
        public void ViewTest()
        {
            ProjectInfo objPI = new ProjectInfo("abc", "abhj", "hdh", "2009-09-08", "2007-08-03", 4, 6);
            ProjectDAL objPDal = new ProjectDAL();

            objPDal.ViewProject(objPI);
        }
    }
}

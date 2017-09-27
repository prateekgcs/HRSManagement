using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessEntities;
using DALayer;

namespace ProjectTest
{
    [TestClass]
    public class SkillCategoryTest
    {
        [TestMethod]
        public void CreateTest()
        {
            CategoryInfo objCI = new CategoryInfo(1,"xyz", "abhj", 8,  6);
           CategoryDAL objCDal = new CategoryDAL();

            objCDal.CreateCategory(objCI);


        }
        public void UpdateTest()
        {
            CategoryInfo objCI = new CategoryInfo(1, "abc", "defg", 8, 6);
            CategoryDAL objCDal = new CategoryDAL();

            objCDal.UpdateCategory(objCI);

        }
        public void ViewTest()
        {
            CategoryInfo objCI = new CategoryInfo(1, "abc", "defg", 8, 6);
            CategoryDAL objCDal = new CategoryDAL();

            objCDal.ViewCategory(objCI);

        }
    }
}

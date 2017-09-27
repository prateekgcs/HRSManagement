using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessEntities;
using DALayer;


namespace ProjectTest
{
    [TestClass]
    public class SkillTest
    {
        [TestMethod]
        public void CreateTest()
        {
            SkillInfo objSI = new SkillInfo(1, "xyz", "abhj", 8, 6,5);
            SkillDAL objSDal = new SkillDAL();

            objSDal.CreateSkill(objSI);


        }
        public void UpdateTest()
        {
            SkillInfo objSI = new SkillInfo(1, "xyz", "abhj", 8, 6, 5);
            SkillDAL objSDal = new SkillDAL();

            objSDal.UpdateSkill(objSI);



        }
        public void ViewTest()
        {
            SkillInfo objSI = new SkillInfo(1, "xyz", "abhj", 8, 6, 5);
            SkillDAL objSDal = new SkillDAL();

            objSDal.ViewSkill(objSI);



        }
    }
}

       
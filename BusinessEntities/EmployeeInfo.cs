using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class EmployeeInfo
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int CivilStatus { get; set; }
        public string Religion { get; set; }
        public string Citizenship { get; set; }
        public string MobileNo { get; set; }
        public string HousePhoneNo { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string ProjectProfile { get; set; }
        public string SkillProfile { get; set; }
        public string EducBackGround { get; set; }
        public string Recognitions { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }

        public EmployeeInfo()
        {

        }


        public EmployeeInfo(string FirstName, string MiddleName,
            int Age, string Gender, string LastName, DateTime BirthDate,
            int CivilStatus, string Religion, string Citizenship, string MobileNo, string HousePhoneNo, string Street1,
            string Street2, string City, string State, string ZipCode, string Country, string ProjectProfile, string SkillProfile,
            string EducBackGround, string Recognitions, int CreatedBy, int LastModifiedBy)
        {

        }
    }
}

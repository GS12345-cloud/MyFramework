using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.Hooks
{
    public class Person
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
            
        public string Gender { get; set; }
        public int Mobile { get; set; }
        public string DateofBirth { get; set; }
        public string Subjects { get; set; }
        public string Hobbies { get; set; }
        public string Picture { get; set; }
        public string CurrentAddress { get; set; }

        /// <summary>
        /// Use optional parameters here as there are different forms we can reuse this code, can use empty string here and define the parameter to make it optional
        /// </summary>
        /// <param name="forename"></param>
        /// <param name="surname"></param>
        /// <param name="address"></param>
        /// <param name="emailAddress"></param>
        /// <param name="gender"></param>
        /// <param name="mobile"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="subjects"></param>
        /// <param name="hobbies"></param>
        /// <param name="picture"></param>
        /// <param name="currentAddress"></param>
        public Person(string forename, string surname, string address, string emailAddress, string gender, string mobile,
            string dateOfBirth, string subjects, string hobbies, string picture, string currentAddress) { 
        
            Forename = forename;
            Surname = surname;
            Address = address;
            EmailAddress = emailAddress;
            Gender = gender;
            Mobile = mobile;
            DateofBirth = dateOfBirth;
            Subjects = subjects;
            Hobbies = hobbies;
            Picture = picture;
            CurrentAddress = currentAddress;
        }
    }
}

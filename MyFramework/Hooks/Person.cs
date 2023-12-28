using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            
        public GenderChoice Gender { get; set; }
        public long Mobile { get; set; }
        public string DateofBirth { get; set; }
        public string Subjects { get; set; }
        public HobbiesChoice Hobbies { get; set; }
        public SKImage Picture { get; set; }
        public string CurrentAddress { get; set; }

        public enum GenderChoice
        {
            Male,
            Female,
            Other
        }

        public enum HobbiesChoice
        {
            Sports,
            Reading,
            Music
        }

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
        public Person(string forename, string surname, string address, string emailAddress, GenderChoice gender, long mobile,
            string dateOfBirth, string subjects, HobbiesChoice hobbies, SKImage picture, string currentAddress) { 
        
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

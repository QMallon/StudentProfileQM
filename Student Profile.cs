using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfileQM
{
    /*
 * Student Profile class 
 * Quinn Mallon
 * CIS3374
 * 8/31/2020
 */
    class Student_Profile
    {
        //student profile variables
        string StudentName;
        string StudentPhone;
        string Studentemail;
        string StudentMajor;
        int StudentAge;
        int StudentTUID;
        DateTime GradDate;
        bool UndergradStatus;
        //create student profile
        public Student_Profile( string name, int age, string phoneNum, DateTime graduationDate, int TUID, string email, string major, bool isUnderGrad)
        {
            StudentName = name;
            StudentPhone = phoneNum;
            Studentemail = email;
            StudentMajor = major;
            StudentAge = age;
            StudentTUID = TUID;
            GradDate = graduationDate;
            UndergradStatus = isUnderGrad; 
        }
        //To string override for the student profile class
        public override string  ToString()
        {
            string output = "";
            output += "Student Name: " + StudentName;
            output += " Student Phone: " + StudentPhone;
            output += " Student Email: " + Studentemail;
            output += " Student Major: " + StudentMajor;
            output += " Student Age: " + StudentAge;
            output += " Student TUID: " + StudentTUID;
            output += " Student Graduation Date: " + GradDate;
            if (UndergradStatus)
            {
                output += " Student is: " + "undergraduate";
            }
            else
            {
                output += " Student is: " + "not undergraduate";
            }

            return output;
        }

    }
}

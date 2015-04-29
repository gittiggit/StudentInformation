using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationPrimitiveType
{
    class Student
    {
        public string regNo;
        public string firstName;
        public string lastName;

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public string GetCode(string code)
        {
            return regNo + code;
        }
    }
}

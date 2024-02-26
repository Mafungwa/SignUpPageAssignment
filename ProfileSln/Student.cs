using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileSln
{ 
    public class Student
    {


        public string name;
        public string surname;
        public string email;
        public int studentNumber;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }

        //OnPropertyChanged();
    }
}

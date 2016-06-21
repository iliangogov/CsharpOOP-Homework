using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    public class Student 
    {
        private string firstName;
        private string lastName;
        private string eMail;
        private string phoneNumber;
        private int group;
        private int fn;
        private int age;
        private List<int> marks;

        // private List<Courses> courses;

        public Student(string firstname, string lastname,string email="not set",string phonenumber= "not set", int group=0,int age=0,int fn=0)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.eMail = email;
            this.phoneNumber = phonenumber;
            this.group = group;
            this.age = age;
            this.fn = fn;

        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Firstname must have value");
                }

                this.firstName = value;

            }
        }

             public string LastName
        {
            get { return this.lastName; }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Lastname must have value");
                }

                this.lastName = value;

            }
        }

        public string Email
        {
            get { return this.eMail; }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email must have value");
                }

                this.eMail = value;

            }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phonenumber must have value");
                }

                this.phoneNumber = value;

            }
        }

        public int Group
        {
            get { return this.group; }
            set
            {

                if (value<1||value>3)
                {
                    throw new ArgumentException("We have groups 1,2 and 3.Choose one of them");
                }

                this.group = value;

            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {

                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Unacceptable age");
                }

                this.age = value;

            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            var separator = "|";
            output.Append("\t***FirstName|LastName|Email|Phone number|Group|Age***\n\t");
            output.Append(this.FirstName);
            output.Append(separator + this.LastName);
            output.Append(separator + this.eMail);
            output.Append(separator + this.phoneNumber);
            output.Append(separator + this.group);
            output.Append(separator + this.age);
            output.Append("\n");

            return output.ToString();
        }
    }
}

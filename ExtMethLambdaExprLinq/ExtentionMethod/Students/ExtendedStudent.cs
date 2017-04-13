using ExtentionMethod.Contracts;

namespace ExtentionMethod.Students
{
    public class ExtendedStudent : Student, IExtendedStudent
    {
        public ExtendedStudent(string firstname, string lastname, string email = "not set", string phonenumber = "not set", int group = 0, int age = 0, int fn = 0)
            : base(firstname, lastname, email, phonenumber, group, age, fn)
        {

        }

        public string PhoneNumberWithPrefix(string prefix)
        {
            //removes the leading zero
            string result = base.PhoneNumber.Substring(1, base.PhoneNumber.Length - 1);

            return prefix + result;
        }
    }
}

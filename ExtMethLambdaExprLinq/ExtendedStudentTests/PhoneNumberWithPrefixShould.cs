using NUnit.Framework;
using ExtentionMethod.Students;

namespace ExtendedStudentTests
{
    [TestFixture]
    public class PhoneNumberWithPrefixShould
    {
        [Test]
        public void ReturnExpectedStringResult()
        {
            //Arrange
            ExtendedStudent student = new ExtendedStudent("John", "Doe", "", "0898777666");
            string prefix = "+359";
            string expectedPhoneNumberWithPrefix = "+359898777666";

            //Act
            string resultPhoneNumber = student.PhoneNumberWithPrefix(prefix);

            //Assert
            Assert.AreEqual(expectedPhoneNumberWithPrefix, resultPhoneNumber);
        }
    }
}
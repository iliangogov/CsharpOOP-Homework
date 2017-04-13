namespace ExtentionMethod.Contracts
{
    public interface IExtendedStudent : IStudent
    {
        string PhoneNumberWithPrefix(string prefix);
    }
}

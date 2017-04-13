using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod.Contracts
{
    public interface IStudent
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        int Group { get; set; }
        int Age { get; set; }
        List<int> Marks { get; set; }
    }
}

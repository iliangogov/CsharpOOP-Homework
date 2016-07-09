using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
   public static class Validator
    {
        public static void StringIsEmpty(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new NullReferenceException();
            }
        }

        public static void ObjeIsNull(object obj)
        {
            if(obj==null)
            {
                throw new NullReferenceException();
            }
        }
    }
}

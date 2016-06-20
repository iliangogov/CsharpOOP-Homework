using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
   public static class StringBuilderExtention
    {
        public static StringBuilder Substring (this StringBuilder stringBuilder,int index,int length)
        {
            if (index + length > stringBuilder.Length
                || index >= stringBuilder.Length
                || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            var output = new StringBuilder();

            for (int i = index; i < index + length; i++)
            {
                output.Append(stringBuilder[i]);
            }

            return output;
        }


    }
}

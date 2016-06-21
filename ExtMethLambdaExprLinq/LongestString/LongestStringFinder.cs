namespace LongestString
{
    using System.Linq;
    public class LongestStringFinder
    {
        public LongestStringFinder()
        {

        }
        public string FindLongestString(string[] target)
        {

            string output = target.OrderByDescending(x => x.Length).First();
            return output;
        }
    }
}

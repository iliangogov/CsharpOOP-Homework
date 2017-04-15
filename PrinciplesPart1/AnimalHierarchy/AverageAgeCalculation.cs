namespace AnimalHierarchy
{
    using System.Collections.Generic;
    using System.Linq;

    public class AverageAgeCalculation
    {
        public double listToCalculate(List<Animal> target)
        {
            double average = 0;
            double sum = 0;
            double length = target.Count;
            var temp = target.Select(x => x.Age).ToArray();
            foreach (var age in temp)
            {
                sum += age;
            }
            average = sum / length;
            return average;
        }
    }
}

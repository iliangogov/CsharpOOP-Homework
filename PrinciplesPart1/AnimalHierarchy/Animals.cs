namespace AnimalHierarchy
{
    using System;

    public abstract class Animals : ISound
    {
        public string Name { get; }
        public int Age { get; }
        public Sex SexType { get; }

        public Animals(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.SexType = sex;
        }

        public Animals()
        {
        }

        public void Sound()
        {
            Console.WriteLine("I can make a sound");
        }

        public enum Sex
        {
            male,
            female
        }
    }
}

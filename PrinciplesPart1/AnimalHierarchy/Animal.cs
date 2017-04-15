namespace AnimalHierarchy
{
    using System;

    public abstract class Animal : ISound
    {
        public string Name { get; }
        public int Age { get; }
        public Sex SexType { get; }

        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.SexType = sex;
        }

        public Animal()
        {
        }

        public virtual void Sound()
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

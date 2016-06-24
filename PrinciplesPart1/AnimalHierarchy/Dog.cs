namespace AnimalHierarchy
{
    using System;

    public class Dog : Animals
    {
        public new void Sound()
        {
            Console.WriteLine("I make a specifyc sound: Bau!");
        }
    }
}

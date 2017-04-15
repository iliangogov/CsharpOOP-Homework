namespace AnimalHierarchy
{
    using System;

    public class Dog : Animal
    {
        //Without polymorphism
        //public new void Sound()
        //{
        //    Console.WriteLine("I make a specifyc sound: Bau!");
        //}

        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("I make a specifyc sound: Bau!");
        }
    }
}

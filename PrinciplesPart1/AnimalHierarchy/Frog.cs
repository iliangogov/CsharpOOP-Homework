namespace AnimalHierarchy
{
    using System;

    public class Frog : Animal
    {
        //Without polymorphism
        //public new void Sound()
        //{
        //    Console.WriteLine("I make a specifyc sound: Kwaaak!");
        //}

        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("I make a specifyc sound: Kwaaak!");
        }
    }
}

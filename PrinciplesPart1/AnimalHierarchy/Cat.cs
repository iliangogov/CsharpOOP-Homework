namespace AnimalHierarchy
{
    using System;

    public class Cat : Animal
    {
        //Without polymorphism
        //public new void Sound()
        //{
        //    Console.WriteLine("I make a specifyc sound: Meaw!");
        //}

        //with polymorphism
        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("I make a specifyc sound: Meaw!");
        }
    }
}

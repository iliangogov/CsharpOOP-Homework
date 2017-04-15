namespace AnimalHierarchy
{
    using System;

    class Kitten : Cat
    {
        private Sex sexType;

        public new Sex SexType
        {
            get
            {
                return this.sexType;
            }
            private set
            {
                this.sexType = Animal.Sex.female;
            }
        }

        //Without polymorphism
        //public new void Sound()
        //{
        //    Console.WriteLine("I make a specifyc sound: Pisss!");
        //}

        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("I make a specifyc sound: Pisss!");
        }
    }
}

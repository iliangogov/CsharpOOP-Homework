namespace AnimalHierarchy
{
    using System;

    class Tomcat : Cat
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
                this.sexType = Animal.Sex.male;
            }
        }

        //Without polymorphism
        //public new void Sound()
        //{
        //    Console.WriteLine("I make a specifyc sound: Mrrr!");
        //}

        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("I make a specifyc sound: Mrrr!");
        }
    }
}

namespace AnimalHierarchy
{
    using System;

    class Kitten:Cat
    {
        private Sex sexType;

        public Sex SexType
        {
            get
            {
                return this.sexType;
            }
            private set
            {
                this.sexType = Animals.Sex.female;
            }
        }

        public void Sound()
        {
            Console.WriteLine("I make a specifyc sound: Pisss!");
        }
    }
}

namespace AnimalHierarchy
{
    using System;

    class Tomcat:Cat
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
                this.sexType = Animals.Sex.male;
            }
        }

        public void Sound()
        {
            Console.WriteLine("I make a specifyc sound: Mrrr!");
        }
    }
}

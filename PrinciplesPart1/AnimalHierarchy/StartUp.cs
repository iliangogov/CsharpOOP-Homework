namespace AnimalHierarchy
{
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            var dog = new Dog();
            var cat = new Cat();
            var frog = new Frog();
            var kitten = new Kitten();
            var tomcat = new Tomcat();

            //Polymorphism does not work if we use "new" keyword when implementing Sound()
            // In result base implementation is called
            var listOfAnimals = new List<Animal>() { dog, cat, frog, kitten, tomcat };
            listOfAnimals.ForEach(x => x.Sound());

            //Now is called specific implementation
            dog.Sound();
            cat.Sound();
            frog.Sound();
            kitten.Sound();
            tomcat.Sound();
        }

    }
}

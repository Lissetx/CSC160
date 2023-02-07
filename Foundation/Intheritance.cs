using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Intheritance
    {
        public static void Execute() 
        {
        Animal animal = new Animal();
        animal.Name = "Cat";
        Animal animal2 = new Animal() { Name = "Cat"};
        Animal animal3 = new Animal("Cat", 17);

            Mammal humanM = new Mammal("Marvin", 25, true, true, false);
            humanM.Speak();

            Animal humanA = new Mammal("Alfonso", 19, false, true, false); //creating an animal instane of a  mammal or converting Mammal to animal
            humanA.Speak();



            //Mammal humanAtoM = (Mammal)new Animal(); //cannot cast

            //Mammal humanAtoM = new Animal(); //cannot convert animal to mammal

            Console.WriteLine("Human name: " + humanA.Name);
            // Console.WriteLine("Human life" + humanA.LifeSpan); //cannot get its private, change to protected still cant get it

            Animal dog = new Mammal("Sparky", 15, true, true, false);
            //dog is an animal now , no longer has access to Mammal properties
            Console.WriteLine(((Mammal)dog).LivesOnLand); //casting dog to mammal to get access to its properties
            Console.WriteLine((dog as Mammal).LivesOnLand); //casting dog to mammal to get access to its properties same thing 
            if (dog is Mammal) //checking if dog is a mammal
            {
                Console.WriteLine("Dog is a mammal");
            }
            else
            {
                Console.WriteLine("Dog is not a mammal");
            }

            Animal[] zoo = new Animal[3] { humanA, dog, humanM };
            Console.WriteLine("My zoo");
            foreach (Animal a in zoo)
            {
                Console.WriteLine(a.Name);
            }

        }
    }
    //We derive from animal , have properties but have stuff specific to mammal
    class Mammal : Animal
    {
        public bool isCarnivore { get; set; }
        public bool LivesOnLand { get; set; }

        public Mammal(string name, int lifeSpan, bool isCarnivore, bool livesOnLand, bool isNocturnal = false) : base(name, lifeSpan, isNocturnal)
        {
            this.isCarnivore = isCarnivore;
            this.LivesOnLand = livesOnLand;
        }
        public void Speak()
        {
            Console.WriteLine(Name + "Speaks (Mammal Class)");
        }
    }
    class Animal
    {
        private int lifeSpan;
        public string Name { get; set; }
        public bool isNocturnal { get; }
        public Animal() { }
        public Animal(string name, int lifeSpan = 0, bool isNocturnal = false)
        {
            this.Name = name;
            this.lifeSpan = lifeSpan;
            this.isNocturnal = isNocturnal;
        }
     

        public void Speak()
        {
            Console.WriteLine(Name + "Speaks (Animal Class)");
        }

    }
}

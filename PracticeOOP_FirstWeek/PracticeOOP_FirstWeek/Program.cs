using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOP_FirstWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horse myHorse = new Horse("Spirit");
            Human myHuman = new Human("Íficles");
            Gorila myGorila = new Gorila("Senpai");
            Whale myWhale = new Whale("Wally");
            //Crocodile myCrocodile = new Crocodile("Quijadón");

            Mammal[] animalStorage = new Mammal[4];
            animalStorage[0] = myHorse;
            animalStorage[1] = myHuman;
            animalStorage[2] = myGorila;
            animalStorage[3] = myWhale;

            for (int i = 0; i < 3; i++)
            {
                animalStorage[i].think();
            }

            Mammal myMammal = new Mammal("");
            myMammal.think();

            myHorse.breedingCare();
            myHuman.getName();
            myGorila.climb();
        }
        abstract class Animals
        {
            public void breathe()
            {
                Console.WriteLine("Puedo Respirar");
            }
            public abstract void getName();
        }

        interface ILandAnimals
        {
            int LegsNumber();
        }

        class Reptile : Animals
        {
            public Reptile(String name)
            {
                String livingBeingName = name;
            }
            public override void getName()
            {
                Console.WriteLine("El nombre del ser vivo es: " + livingBeingName);
            }
            private String livingBeingName;
        }

        class Mammal : Animals
        {
            public Mammal(String name)
            {
                String livingBeingName = name;
            }
            public void think()
            {
                Console.WriteLine("Pensamientos básico instintivos");
            }

            public void breedingCare()
            {
                Console.WriteLine("Cuidar de las crias hasta que se valgan por si solas");
            }
            public override void getName()
            {
                Console.WriteLine("El nombre del ser vivo es: " + livingBeingName);
            }

            private String livingBeingName;
        }

        class Whale : Mammal
        {
            public Whale(String whaleName) : base(whaleName)
            {
            }
            public void swim()
            {
                Console.WriteLine("Soy capaz de nadar");
            }
        }

        class Horse : Mammal, ILandAnimals
        {
            public Horse(String horseName) : base(horseName)
            {

            }
            public void gallop()
            {
                Console.WriteLine("Soy Capaz de galopar");
            }
            public int LegsNumber()
            {
                return 4;
            }

        }
        class Human : Mammal
        {
            public Human(String humanName) : base(humanName)
            {
            }
            public void think()
            {
                Console.WriteLine("Soy capaz de pensar ¿?");
            }
        }
        class Gorila : Mammal, ILandAnimals
        {
            public Gorila(String gorilaName) : base(gorilaName)
            {
            }
            public void climb()
            {
                Console.WriteLine("Soy capaz de trepar");
            }
            public int numeroPatas()
            {
                return 2;
            }
        }
        class Cocodrilo : Reptile, IAnimalesTerrestres
        {
            public Cocodrilo(String nombreCocodrilo) : base(nombreCocodrilo)
            {
            }

            public void muerde()
            {
                Console.WriteLine("Soy Capaz de morder");
            }
            public int LegsNumber()
            {
                return 4;
            }
        }
    }
}

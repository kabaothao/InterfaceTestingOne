// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace InterfaceTestingOne // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {

            Rabbit rabbit = new Rabbit(); //create a rabbit object
            Hawk hawk = new Hawk(); //create a hawk object
            Fish fish  = new Fish();
            Bear bear = new Bear();
            Chicken chicken = new Chicken();
            Bat bat = new Bat();
            Whale whale = new Whale();

            //rabbit.Flee();
            //hawk.Hunt();
            //fish.Flee();
            //fish.Hunt();
            //fish.Sleep();
            //bear.Sleep();
            //chicken.sleep();

            //bat.Flee();
            //bat.Hunt();
            //bat.Sleep();
            whale.Swim();
            fish.Swim();
            bat.Swim(); 

            Console.ReadKey();
        }





        interface IPrey
        {
            void Flee();//if you add methods then in the class you'll always have to call those methods or else the class will break/or be mad.
            void Swim();
        }

        interface IPredator
        {
            void Hunt();
        }

        interface IHibernate
        {
            void Sleep();
        }

        




        class Rabbit
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away.");
            }
        }

        class Hawk
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is searching for food.");
            }
        }

        class Fish : IPrey, IPredator, IHibernate
        {
            public void Flee()
            {
                Console.WriteLine("The fish swim away");
            }

            public void Hunt()
            {
                Console.WriteLine("The fish is searching for smaller fish.");
            }

            public void Sleep()
            {
                Console.WriteLine("The fish is sleeping.");
            }

            public void Swim()
            {
                Console.WriteLine("The fish is swimming.");
            }
        }

        class Bear
        {
            public void Sleep()
            {
                Console.WriteLine("The bear is sleeping.");
            }
        }


        class Chicken 
        {   

            public void sleep()
            {
                Console.WriteLine("The chicken is sleeping.");
            }

        }

        class Bat : IPrey, IPredator, IHibernate
        {
            public void Flee()
            {
                Console.WriteLine("The bat fly away.");
            }

            public void Hunt()
            {
                Console.WriteLine("The bat is searching for smaller insects.");
            }

            public void Sleep()
            {
                Console.WriteLine("The bat is sleeping.");
            }

            public void Swim()
            {
                Console.WriteLine("The bat is swimming.");
            }
        }

        class Whale
        {
            public void Swim()
            {
                Console.WriteLine("The whale is swimming to prey for smaller fishes.");
            }
        }


    }
}






/*
 *interface = defines a "contract" that all classes inheriting from should follow

An interface declares" what a class should have"
An inheriting class defines "how it should do it?"

Benefit = security + mutliple inheritance +"plug-and-play"
    
 */

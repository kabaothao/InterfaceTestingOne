// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace InterfaceTestingOne // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rabbit rabbit = new Rabbit(); //create a rabbit object
            Hawk hawk = new Hawk(); //create a hawk object
            Fish fish  = new Fish();

            //rabbit.Flee();
            //hawk.Hunt();
            fish.Flee();
            fish.Hunt();

            Console.ReadKey();
        }

        interface IPrey
        {
            void Flee();
        }

        interface IPredator
        {
            void Hunt();
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

        class Fish : IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("The fish swim away");
            }

            public void Hunt()
            {
                Console.WriteLine("The fish is searching for smaller fish. ");
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

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace InterfaceTestingOne // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rabbit rabbit = new Rabbit(); //create an object
            Hawk hawk = new Hawk();

            rabbit.Flee();
            hawk.Hunt();

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

        class Fish
        {
            public void
        }


    }
}






/*
 *interface = defines a "contract" that all classes inheriting from should follow

An interface declares" what a class should have"
An inheriting class defines "how it should do it?"

Benefit = scurity + mutliple inheritance +"plug-and-play"
    
 */

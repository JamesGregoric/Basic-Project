using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic;
using Logic.Interface;

namespace AnimalShelter
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            IAnimalLogic _animalLogic = new AnimalLogic();

            String happyCat = _animalLogic.SeeHappyCat();
            Console.Write("You see a happy cat and it says " + happyCat );
            Console.ReadLine();
        }
    }
}

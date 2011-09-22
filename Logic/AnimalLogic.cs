using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Logic.Interface;

namespace Logic
{
    public class AnimalLogic : IAnimalLogic
    {
        private Cat _cat = new Cat();

        public String SeeCat(String mood)
        {
            switch (mood.Trim().ToUpper())
            {
                case "HAPPY":
                    return _cat.CatIsHappy();
                case "Angry":
                    return _cat.CatIsAngry();
                default:
                    return "Please enter a valid mood";
            }
        }

        public String SeeHappyCat()
        {
            return _cat.CatIsHappy();
        }

        public String SeeAngryCat()
        {
            return _cat.CatIsAngry();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Cat
    {
        private String _happy = "Meow";
        private String _angry = "HISS";

        public String CatIsHappy()
        {
            return _happy;
        }

        public String CatIsAngry()
        {
            return _angry;
        }
    }
}

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
        private String _lazy = "zzzz";

        public String CatIsHappy()
        {
            return _happy;
        }

        public String CatIsAngry()
        {
            return _angry;
        }

        public String CatIsLazy()
        {
            return _lazy;
        }
    }
}

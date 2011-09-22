using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.Interface
{
    public interface IAnimalLogic
    {
        #region Cat
        String SeeCat(String mood);
        String SeeHappyCat();
        String SeeAngryCat();
        #endregion
    }
}

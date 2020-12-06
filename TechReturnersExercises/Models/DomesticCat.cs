using System;
using System.Collections.Generic;
using System.Text;
using TechReturners.Exercises;

namespace TechReturnersExercises.Models
{

    public class DomesticCat : Cat, ICat
    {


        public DomesticCat()
        {
            Eat = "Purrrrrrr";
            AverageHeight = 23;
            Setting = "domestic";

        }
    }

}

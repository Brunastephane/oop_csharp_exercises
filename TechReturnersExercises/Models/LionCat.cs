using System;
using System.Collections.Generic;
using System.Text;
using TechReturners.Exercises;

namespace TechReturnersExercises.Models
{
    public class LionCat : Cat, ICat
    {

        public LionCat()
        {
            Eat = "Roar!!!!";
            AverageHeight = 1100;
            Setting = "wild";

        }
    }
}

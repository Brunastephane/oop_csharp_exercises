using System;
using System.Collections.Generic;
using System.Text;
using TechReturners.Exercises;

namespace TechReturnersExercises.Models
{


    public class CheetahCat : Cat, ICat
    {

        public CheetahCat()
        {
            Eat = "Zzzzzzz";
            AverageHeight = 300; //qualquer coisa n'ao precisa esse
            Setting = "wild";
        }

    }
}

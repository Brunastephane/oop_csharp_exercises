using System;
using System.Collections.Generic;
using System.Text;

namespace TechReturnersExercises.Models
{
    public abstract class Cat
    {

        public bool IsAsleep { get; set; }
        public string Setting { get; set; }
        public string Eat { get; set; }
        public float AverageHeight { get; set; }

        public void GoToSleep()
        {
            IsAsleep = true;
        }
        public void WakeUp()
        {
            IsAsleep = false;
        }

    }
}

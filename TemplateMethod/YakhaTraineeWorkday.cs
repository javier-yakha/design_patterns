using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class YakhaTraineeWorkday : WorkdayPlanner
    {
        public override void GoToWork()
        {
            Console.WriteLine("The Yakha Trainee logs in to Teams.");
        }

        public override void Work()
        {
            Console.WriteLine("The Yakha Trainee learns interesting programming concepts.");
        }
    }
}

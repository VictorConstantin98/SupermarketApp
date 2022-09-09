using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class CarneAlba : Carne
    {
        //setter pt a restrictiona tipAnimal pentru pui si peste.

        public override void setTipAnimal(TipAnimal tipAnimal)
        {
            if(tipAnimal == TipAnimal.Pui || tipAnimal == TipAnimal.Peste)
            {
                base.setTipAnimal(tipAnimal);
            }
            else
            {
                Console.Error.WriteLine("Nu corespunde.")
            }
        }
    }
}

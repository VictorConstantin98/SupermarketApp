using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class CarneRosie : Carne
    {
        //setter pentru a restrictiona tipAnimal pentru vita si porc.

        public override void setTipAnimal(TipAnimal tipAnimal)
        {
            if(tipAnimal == TipAnimal.Vita || tipAnimal == TipAnimal.Porc)
            {
                base.setTipAnimal(tipAnimal);
            }
            else
            {
                Console.Error.WriteLine("Nu corespunde.");
            }
        }
    }
}

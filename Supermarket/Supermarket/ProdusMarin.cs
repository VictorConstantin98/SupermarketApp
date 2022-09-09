using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    enum TipApa {Dulce, Sarata};
    internal class ProdusMarin : Carne
    {
        private TipApa tipApa;

        //setter pt a restrictiona tipAnimal la peste.
        //constructor implicit care sa fie cu tipAnimal peste.

        public ProdusMarin()
        {
            base.setTipAnimal(TipAnimal.Peste);
        }

        public override void setTipAnimal(TipAnimal tipAnimal)
        {
            if(tipAnimal == TipAnimal.Peste)
            {
                base.setTipAnimal(TipAnimal.Peste);
            }
            else
            {
                Console.Error.WriteLine("Nu corespunde.")
            }
        }
    }
}

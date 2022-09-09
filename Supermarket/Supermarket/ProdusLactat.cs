using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class ProdusLactat : ProdusAnimal
    {
        private double continutDeLapte;
        private string ingrediente;

        //setter care sa restrictioneze tipAnimal la vita sau pui.

        public override void setTipAnimal(TipAnimal tipAnimal)
        {
            if(tipAnimal == TipAnimal.Vita || tipAnimal == TipAnimal.Pui)
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

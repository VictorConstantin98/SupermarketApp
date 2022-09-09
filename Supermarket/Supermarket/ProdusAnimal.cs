using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    enum TipAnimal {Vita, Porc, Pui, Peste};
    internal class ProdusAnimal : ProdusDeConsum
    {
        private TipAnimal tipAnimal;

        public virtual void setTipAnimal(TipAnimal tipAnimal)
        {
            this.tipAnimal = tipAnimal;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal abstract class ProdusDeConsum : Produs
    {
        protected DateTime termenDeExpirare;
        protected bool proaspat;
        protected DateTime dataDeProductie;

        public abstract void stabilireTermenExpirare(int nrDeZile);
    }
}

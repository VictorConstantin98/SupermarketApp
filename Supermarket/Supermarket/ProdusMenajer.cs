using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    enum TipMenajer {Curatare, Intretinere};
    internal class ProdusMenajer : Produs
    {
        private string modDeUtilizare;
        private TipMenajer tipMenajer;
    }
}

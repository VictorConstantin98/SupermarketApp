﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    enum RecomandareServire {Proaspat, Gatit};
    internal class Carne : ProdusAnimal
    {
        private RecomandareServire recomandareServire;
    }
}

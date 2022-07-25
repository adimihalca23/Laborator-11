using Laborator_11.Product.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_11.Product
{
    class CombustibleProduct : Product
    {
        public CombustibleProduct(string name, double grossPrice, ITaxesCalculator taxesCalculator) : base(name, grossPrice, taxesCalculator)
        {
        }
    }
}

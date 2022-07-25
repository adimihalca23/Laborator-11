using Laborator_11.Product.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_11.Product
{
    class HouseHoldProduct : Product
    {
        public HouseHoldProduct(string name, double grossPrice, ITaxesCalculator taxesCalculator) : base(name, grossPrice, taxesCalculator)
        {
        }
    }
}

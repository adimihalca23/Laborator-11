using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_11.Product.Services
{
    class TaxesCalculator : ITaxesCalculator
    {
        public double ApplyTaxes(double grossPrice, CombustibleProduct combustibileProduct)
        {
            return grossPrice + 0.19 * grossPrice + 1.8 + 1.3;
        }
        public double ApplyTaxes(double grossPrice, GroceryProduct groceryProduct)
        {
            return grossPrice + grossPrice * 0.09;
        }
        public double ApplyTaxes(double grossPrice, HouseHoldProduct houseHoldProduct)
        {
            return grossPrice + grossPrice * 0.19;
        }
    }
}

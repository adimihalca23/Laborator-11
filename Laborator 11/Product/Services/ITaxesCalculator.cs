using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_11.Product.Services
{
    interface ITaxesCalculator
    {
        double ApplyTaxes(double grossPrice, CombustibleProduct combustibleProduct);
        double ApplyTaxes(double grossPrice, GroceryProduct groceryProduct);
        double ApplyTaxes(double grossPrice, HouseHoldProduct houseHoldProduct);
    }
}

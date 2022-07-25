using Laborator_11.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_11.Produs
{
    interface IProduct
    {
        Guid Id { get;}
        string Name { get; }
        double GrossPrice { get; }
        Tag Tag { get; }

    }
}

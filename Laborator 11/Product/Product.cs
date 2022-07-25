using Laborator_11.Product.Services;
using Laborator_11.Produs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_11.Product
{
    abstract class Product : IProduct
    {
        private readonly Guid id;
        public Guid Id { get { return id; } }

        public string Name {get; private set;}

        public double GrossPrice {get; private set; }

        public Tag Tag { get; private set;}

        //Eu as fi pus parametrul taxesCalculator in Tag unde avem netPrice si as fi calculat in constructor pretul net.
        public Product(string name, double grossPrice, ITaxesCalculator taxesCalculator)
        {
            this.id = Guid.NewGuid();
            this.Name = name;
            this.GrossPrice = grossPrice;
            this.Tag = new Tag();

        }
    }
}

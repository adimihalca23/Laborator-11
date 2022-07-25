using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_11.Product
{
    internal class Tag
    {
        private readonly string Currency = "RON";
        public Guid Id { get; internal set; }
        public string Name { get; internal set; }
        public double NetPrice { get; internal set; }

        public override string ToString()
        {
            return $"{Id},{Environment.NewLine}{Name},{Environment.NewLine}{NetPrice}{Currency}";
        }

        public void Tipareste()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Net Price: {NetPrice}");
        }
    }

}

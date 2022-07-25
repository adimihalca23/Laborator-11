// See https://aka.ms/new-console-template for more information


using Laborator_11.Product;
using Laborator_11.Product.Services;

TaxesCalculator taxesCalculator = new TaxesCalculator();
GroceryProduct paine = new GroceryProduct("Paine", 2.5 , taxesCalculator);
paine.Tag.Id = paine.Id;
paine.Tag.Name = paine.Name;
paine.Tag.NetPrice = taxesCalculator.ApplyTaxes(paine.GrossPrice, paine);
Console.WriteLine(paine.Tag);

GroceryProduct ulei = new GroceryProduct("Ulei", 4, taxesCalculator);
ulei.Tag.Id = ulei.Id;
ulei.Tag.Name = ulei.Name;
ulei.Tag.NetPrice = taxesCalculator.ApplyTaxes(ulei.GrossPrice, ulei);
Console.WriteLine(ulei.Tag);

HouseHoldProduct mop = new HouseHoldProduct("Mop", 5, taxesCalculator);
mop.Tag.Id = mop.Id;
mop.Tag.Name = mop.Name;
mop.Tag.NetPrice = taxesCalculator.ApplyTaxes(mop.GrossPrice, mop);
Console.WriteLine(mop.Tag);

HouseHoldProduct detergent = new HouseHoldProduct("Detergent de vase", 15, taxesCalculator);
detergent.Tag.Id = detergent.Id;
detergent.Tag.Name = detergent.Name;
detergent.Tag.NetPrice = taxesCalculator.ApplyTaxes(detergent.GrossPrice, detergent);
Console.WriteLine(detergent.Tag);

CombustibleProduct bezina = new CombustibleProduct("Benzina", 5.2, taxesCalculator);
bezina.Tag.Id = bezina.Id;
bezina.Tag.Name = bezina.Name;
bezina.Tag.NetPrice = taxesCalculator.ApplyTaxes(bezina.GrossPrice, bezina);
Console.WriteLine(bezina.Tag);

CombustibleProduct motorina = new CombustibleProduct("Motorina", 6.2, taxesCalculator);
motorina.Tag.Id = motorina.Id;
motorina.Tag.Name = motorina.Name;
motorina.Tag.NetPrice = taxesCalculator.ApplyTaxes(motorina.GrossPrice, motorina);
Console.WriteLine(motorina.Tag);

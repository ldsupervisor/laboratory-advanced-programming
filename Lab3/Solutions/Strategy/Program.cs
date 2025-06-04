using Strategy;
using TaxStrategy;

decimal amount = 3000m;

var polishCalculator = new TaxCalculator(new PolandTax());
var germanCalculator = new TaxCalculator(new GermanyTax());

Console.WriteLine($"Amount: {amount:C}");

Console.WriteLine($"Polish tax (23%): {polishCalculator.Calculate(amount):C}");
Console.WriteLine($"German tax (19%): {germanCalculator.Calculate(amount):C}");
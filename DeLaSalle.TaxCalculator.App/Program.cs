// See https://aka.ms/new-console-template for more information

using DeLaSalle.TaxCalculator.App.Taxes;
using DeLaSalle.TaxCalculator.Core.Entities;

double amount = 0;
Console.WriteLine("Please type your salary: ");
double.TryParse(Console.ReadLine(), out amount);

var salary = new Salary { Amount = amount };
var isrCalculatorService = new ISRCalculatorService();
var isr = isrCalculatorService.GetISR(salary);

Console.WriteLine($" ISR : {isr} ");
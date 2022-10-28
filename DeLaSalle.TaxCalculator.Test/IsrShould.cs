using DeLaSalle.TaxCalculator.App.Taxes;
using DeLaSalle.TaxCalculator.Core.Entities;
using DeLaSalle.TaxCalculator.Core.Enums;

namespace DeLaSalle.TaxCalculator.Test
{
    public class IsrShould
    {
        [Fact]
        public void Isr_WhenSalaryAmount_Equal_13_500_Returns_517_47()
        {
            /*arrange*/
            var sal = new Salary()
            {
                Amount = 13500.00
            };
            double expected = 517.46936;
            /*****sut=Systen Under Test*****/
            var sut = new ISRCalculatorService();

            /*act*/
            var result = sut.GetISR(sal);

            /*assert*/
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Isr_WhenSalaryAmount_BetweenRange_1_ReturnsRange_1()
        {
            /*arrange*/
            var sal = new Salary()
            {
                Amount = 7000.00
            };
            var expected = Porcentaje.Rango_01;
            /*****sut=Systen Under Test*****/
            var sut = new ISRCalculatorService();

            /*act*/
            Tuple<double, Porcentaje> result = sut.GetIsrRango(sal);

            /*assert*/
            Console.WriteLine($"ISR {result.Item1}, Porcentaje aplicado {result.Item2}");
            Assert.Equal(expected, result.Item2);
        }
        [Fact]
        public void Isr_WhenSalaryAmount_BetweenRange_2_ReturnsRange_2()
        {
            /*arrange*/
            var sal = new Salary()
            {
                Amount = 13500.00
            };
            var expected = Porcentaje.Rango_02;
            /*****sut=Systen Under Test*****/
            var sut = new ISRCalculatorService();

            /*act*/
            Tuple<double, Porcentaje> result = sut.GetIsrRango(sal);

            /*assert*/
            Console.WriteLine($"ISR {result.Item1}, Porcentaje aplicado {result.Item2}");
            Assert.Equal(expected, result.Item2);
        }
        [Fact]
        public void Isr_WhenSalaryAmount_BetweenRange_3_ReturnsRange_3()
        {
            /*arrange*/
            var sal = new Salary()
            {
                Amount = 115000.00
            };
            var expected = Porcentaje.Rango_03;
            /*****sut=Systen Under Test*****/
            var sut = new ISRCalculatorService();

            /*act*/
            Tuple<double, Porcentaje> result = sut.GetIsrRango(sal);

            /*assert*/
            Console.WriteLine($"ISR {result.Item1}, Porcentaje aplicado {result.Item2}");
            Assert.Equal(expected, result.Item2);
        }
        [Fact]
        public void Isr_WhenSalaryAmount_BetweenRange_4_ReturnsRange_4()
        {
            /*arrange*/
            var sal = new Salary()
            {
                Amount = 120000.00
            };
            var expected = Porcentaje.Rango_04;
            /*****sut=Systen Under Test*****/
            var sut = new ISRCalculatorService();

            /*act*/
            Tuple<double, Porcentaje> result = sut.GetIsrRango(sal);

            /*assert*/
            Console.WriteLine($"ISR {result.Item1}, Porcentaje aplicado {result.Item2}");
            Assert.Equal(expected, result.Item2);
        }
        [Fact]
        public void Isr_WhenSalaryAmount_BetweenRange_5_ReturnsRange_5()
        {
            /*arrange*/
            var sal = new Salary()
            {
                Amount = 160500.00
            };
            var expected = Porcentaje.Rango_05;
            /*****sut=Systen Under Test*****/
            var sut = new ISRCalculatorService();

            /*act*/
            Tuple<double, Porcentaje> result = sut.GetIsrRango(sal);

            /*assert*/
            Console.WriteLine($"ISR {result.Item1}, Porcentaje aplicado {result.Item2}");
            Assert.Equal(expected, result.Item2);
        }
        [Fact]
        public void Isr_WhenSalaryAmount_BetweenRange_6_ReturnsRange_6()
        {
            /*arrange*/
            var sal = new Salary()
            {
                Amount = 320800.00
            };
            var expected = Porcentaje.Rango_06;
            /*****sut=Systen Under Test*****/
            var sut = new ISRCalculatorService();

            /*act*/
            Tuple<double, Porcentaje> result = sut.GetIsrRango(sal);

            /*assert*/
            Console.WriteLine($"ISR {result.Item1}, Porcentaje aplicado {result.Item2}");
            Assert.Equal(expected, result.Item2);
        }
        [Fact]
        public void Isr_WhenSalaryAmount_BetweenRange_7_ReturnsRange_7()
        {
            /*arrange*/
            var sal = new Salary()
            {
                Amount = 510400.00
            };
            var expected = Porcentaje.Rango_07;
            /*****sut=Systen Under Test*****/
            var sut = new ISRCalculatorService();

            /*act*/
            Tuple<double, Porcentaje> result = sut.GetIsrRango(sal);

            /*assert*/
            Console.WriteLine($"ISR {result.Item1}, Porcentaje aplicado {result.Item2}");
            Assert.Equal(expected, result.Item2);
        }
        [Fact]
        public void Isr_WhenSalaryAmount_BetweenRange_8_ReturnsRange_8()
        {
            /*arrange*/
            var sal = new Salary()
            {
                Amount = 970500.00
            };
            var expected = Porcentaje.Rango_08;
            /*****sut=Systen Under Test*****/
            var sut = new ISRCalculatorService();

            /*act*/
            Tuple<double, Porcentaje> result = sut.GetIsrRango(sal);

            /*assert*/
            Console.WriteLine($"ISR {result.Item1}, Porcentaje aplicado {result.Item2}");
            Assert.Equal(expected, result.Item2);
        }
        [Fact]
        public void Isr_WhenSalaryAmount_BetweenRange_9_ReturnsRange_9()
        {
            /*arrange*/
            var sal = new Salary()
            {
                Amount = 1299380.00
            };
            var expected = Porcentaje.Rango_09;
            /*****sut=Systen Under Test*****/
            var sut = new ISRCalculatorService();

            /*act*/
            Tuple<double, Porcentaje> result = sut.GetIsrRango(sal);

            /*assert*/
            Console.WriteLine($"ISR {result.Item1}, Porcentaje aplicado {result.Item2}");
            Assert.Equal(expected, result.Item2);
        }
        [Fact]
        public void Isr_WhenSalaryAmount_BetweenRange_10_ReturnsRange_10()
        {
            /*arrange*/
            var sal = new Salary()
            {
                Amount = 1299380.06
            };
            var expected = Porcentaje.Rango_10;
            /*****sut=Systen Under Test*****/
            var sut = new ISRCalculatorService();

            /*act*/
            Tuple<double, Porcentaje> result = sut.GetIsrRango(sal);

            /*assert*/
            Console.WriteLine($"ISR {result.Item1}, Porcentaje aplicado {result.Item2}");
            Assert.Equal(expected, result.Item2);
        }
        [Fact]
        public void Isr_WhenSalaryAmount_BetweenRange_11_ReturnsRange_11()
        {
            /*arrange*/
            var sal = new Salary()
            {
                Amount = 3898140.13
            };
            var expected = Porcentaje.Rango_11;
            /*****sut=Systen Under Test*****/
            var sut = new ISRCalculatorService();

            /*act*/
            Tuple<double, Porcentaje> result = sut.GetIsrRango(sal);

            /*assert*/
            Console.WriteLine($"ISR {result.Item1}, Porcentaje aplicado {result.Item2}");
            Assert.Equal(expected, result.Item2);
        }
    }
}
using DeLaSalle.TaxCalculator.Core.Entities;
using DeLaSalle.TaxCalculator.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DeLaSalle.TaxCalculator.App.Taxes
{
    public class ISRCalculatorService
    {
        private readonly List<Limit> _limits;

        public ISRCalculatorService()
        {
            // Annual ISR Table 2022 
            _limits = new();
            _limits.Add(new Limit { RangoPorcentaje = Porcentaje.Rango_01, LowerLimit = 0.01, UpperLimit = 7735.00, FixedFee = 0.00, SurplusPercentage = 1.92 });
            _limits.Add(new Limit { RangoPorcentaje = Porcentaje.Rango_02, LowerLimit = 7735.01, UpperLimit = 65651.07, FixedFee = 148.51, SurplusPercentage = 6.40 });
            _limits.Add(new Limit { RangoPorcentaje = Porcentaje.Rango_03, LowerLimit = 65651.08, UpperLimit = 115375.90, FixedFee = 3855.14, SurplusPercentage = 10.88 });
            _limits.Add(new Limit { RangoPorcentaje = Porcentaje.Rango_04, LowerLimit = 115375.91, UpperLimit = 134119.41, FixedFee = 9265.20, SurplusPercentage = 16.00 });
            _limits.Add(new Limit { RangoPorcentaje = Porcentaje.Rango_05, LowerLimit = 134119.42, UpperLimit = 160577.65, FixedFee = 12264.16, SurplusPercentage = 17.92 });
            _limits.Add(new Limit { RangoPorcentaje = Porcentaje.Rango_06, LowerLimit = 160577.66, UpperLimit = 323862.00, FixedFee = 17005.47, SurplusPercentage = 21.36 });
            _limits.Add(new Limit { RangoPorcentaje = Porcentaje.Rango_07, LowerLimit = 323862.01, UpperLimit = 510451.00, FixedFee = 51883.01, SurplusPercentage = 23.52 });
            _limits.Add(new Limit { RangoPorcentaje = Porcentaje.Rango_08, LowerLimit = 510451.01, UpperLimit = 974535.03, FixedFee = 95768.74, SurplusPercentage = 30.00 });
            _limits.Add(new Limit { RangoPorcentaje = Porcentaje.Rango_09, LowerLimit = 974535.04, UpperLimit = 1299380.04, FixedFee = 234993.95, SurplusPercentage = 32.00 });
            _limits.Add(new Limit { RangoPorcentaje = Porcentaje.Rango_10, LowerLimit = 1299380.05, UpperLimit = 3898140.12, FixedFee = 338944.34, SurplusPercentage = 34.00 });
            _limits.Add(new Limit { RangoPorcentaje = Porcentaje.Rango_11, LowerLimit = 3898140.13, UpperLimit = 1.7976931348623157E+308, FixedFee = 1222522.76, SurplusPercentage = 35.00 });
        }

        public double GetISR(Salary salary)
        {

            /*
            Limit limit = null;
            foreach (var l in _limits)
            {
                if (l.LowerLimit <= salary.Amount && l.UpperLimit >= salary.Amount)
                {
                    limit = l;
                    break;
                }
            }*/

            // This and the above code has the same result 
            var limit = _limits.FirstOrDefault(x => x.LowerLimit <= salary.Amount && x.UpperLimit >= salary.Amount);

            if (limit == null)
                throw new Exception("There is an error in the process to get the ISR Tax");

            // Example with a salary of 13,500 pesos 
            // baseAmount = salary.Amount (13,500) - limit.LowerLimit (7735.0) = 5764.99
            // limit.SurplusPercentage 6.40 
            // result = baseAmount (5764.99) * (limit.SurplusPercentage / 100) 0.0640 = 368.95936
            // isr = result (368.95936) + (limit.FixedFee) 148.51

            var baseAmount = salary.Amount - limit.LowerLimit;
            var result = baseAmount * (limit.SurplusPercentage / 100);
            var isr = result + limit.FixedFee;

            return isr;
        }
        public Tuple<double, Porcentaje> GetIsrRango(Salary salary)
        {

            /*
            Limit limit = null;
            foreach (var l in _limits)
            {
                if (l.LowerLimit <= salary.Amount && l.UpperLimit >= salary.Amount)
                {
                    limit = l;
                    break;
                }
            }*/

            // This and the above code has the same result 
            var limit = _limits.FirstOrDefault(x => x.LowerLimit <= salary.Amount && x.UpperLimit >= salary.Amount);

            if (limit == null)
                throw new Exception("There is an error in the process to get the ISR Tax");

            // Example with a salary of 13,500 pesos 
            // baseAmount = salary.Amount (13,500) - limit.LowerLimit (7735.0) = 5764.99
            // limit.SurplusPercentage 6.40 
            // result = baseAmount (5764.99) * (limit.SurplusPercentage / 100) 0.0640 = 368.95936
            // isr = result (368.95936) + (limit.FixedFee) 148.51

            var baseAmount = salary.Amount - limit.LowerLimit;
            var result = baseAmount * (limit.SurplusPercentage / 100);
            var isr = result + limit.FixedFee;

            return new Tuple<double, Porcentaje>(isr, limit.RangoPorcentaje);
        }
    }
}
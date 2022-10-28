using DeLaSalle.TaxCalculator.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeLaSalle.TaxCalculator.Core.Entities
{
    public class Limit
    {
        public double LowerLimit { get; set; }
        public double UpperLimit { get; set; }
        public double FixedFee { get; set; }
        public double SurplusPercentage { get; set; }
        public Porcentaje RangoPorcentaje { get; set; }
    }
}
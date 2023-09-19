using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Clases
{
    public class HourlyEmployee:Employee
    {
        #region Properties
        public decimal Hours { get; set; }
        public decimal HourValue { get; set; }

        #endregion

        #region Methods

        public HourlyEmployee()
        {

        }

        public override decimal GetValueToPay()
        {
            return Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Horas trabajadas: {Hours}\n\t" +
                $"Valor por hora: {HourValue:C2}";
        }
        #endregion
    }
}

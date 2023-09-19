namespace EmployeeOOP.Clases
{
    public class CommissionEmployee : Employee
    {
        #region Properties
        public decimal CommissionPercentage { get; set; }
        public decimal Sales { get; set; }
        #endregion

        #region Methods

        public CommissionEmployee()
        {
        }

        public override decimal GetValueToPay()
        {
            // Convertir porcentaje de comision a decimal
            return (CommissionPercentage / 100) * Sales;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Porcentaje de Comisión: {CommissionPercentage}%\n\t" +
                $"Ventas realizadas: {Sales:C2}";
        }

        #endregion
    }
}

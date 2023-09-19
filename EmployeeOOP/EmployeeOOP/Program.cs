
using EmployeeOOP.Clases;
try
{
    Console.WriteLine("Selecciones la opcion que le corresponde:\n1. Empleado salariado:\n2. Empleado por horas:\n3. Empleado por comisioón:\n ");
    int opcion = Convert.ToInt32(Console.ReadLine());

    int day, month, year, id;
    string firstname, lastname;
    decimal salary, hours, hourValue, salaryHours, commissionPercentage, sales, commission;

    switch (opcion)
    {
        case 1:
            Console.WriteLine("\nOPP APPLICATION");
            Console.WriteLine("----------------");

            Console.Write("Ingresar el dia: ");
            day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar el mes: ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar el año: ");
            year = Convert.ToInt32(Console.ReadLine());

            //Ininicializacion de la clase Date
            Date dateObject1 = new Date(day, month, year);
            Console.WriteLine("\n");
            Console.WriteLine(dateObject1.ToString());

            Console.Write("Ingresar Id: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar Nombre: ");
            firstname = (Console.ReadLine());

            Console.Write("Ingresar Apellido: ");
            lastname = (Console.ReadLine());

            Console.Write("Ingresar Salario: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            SalaryEmployee salaryEmployee = new SalaryEmployee()
            {
                Id = id,
                FirstName = firstname,
                LastName = lastname,
                BirthDate = dateObject1,
                HiringDate = dateObject1,
                IsActive = true,
                Salary = salary,
            };

            Console.WriteLine(salaryEmployee);
        break;

        case 2:
            Console.WriteLine("\nOPP APPLICATION");
            Console.WriteLine("----------------");

            Console.Write("Ingresar el dia: ");
            day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar el mes: ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar el año: ");
            year = Convert.ToInt32(Console.ReadLine());

            //Ininicializacion de la clase Date
            Date dateObject2 = new Date(day, month, year);
            Console.WriteLine("\n");
            Console.WriteLine(dateObject2.ToString());

            Console.Write("Ingresar Id: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar Nombre: ");
            firstname = (Console.ReadLine());

            Console.Write("Ingresar Apellido: ");
            lastname = (Console.ReadLine());

            Console.Write("Ingresar horas trabajadas: ");
            hours = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresar valor por hora: ");
            hourValue = Convert.ToDecimal(Console.ReadLine());

            HourlyEmployee hourlyEmployee = new HourlyEmployee()
            {
                Id = id,
                FirstName = firstname,
                LastName = lastname,
                BirthDate = dateObject2,
                HiringDate = dateObject2,
                IsActive = true,
                Hours = hours,
                HourValue = hourValue,

            };
            salaryHours = hourlyEmployee.GetValueToPay();
            Console.WriteLine(hourlyEmployee);
            Console.WriteLine($"\tSalario: {salaryHours:C2}");
            break;

        case 3:
            Console.WriteLine("\nOPP APPLICATION");
            Console.WriteLine("----------------");

            Console.Write("Ingresar el dia: ");
            day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar el mes: ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar el año: ");
            year = Convert.ToInt32(Console.ReadLine());

            //Ininicializacion de la clase Date
            Date dateObject3 = new Date(day, month, year);
            Console.WriteLine("\n");
            Console.WriteLine(dateObject3.ToString());

            Console.Write("Ingresar Id: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar Nombre: ");
            firstname = (Console.ReadLine());

            Console.Write("Ingresar Apellido: ");
            lastname = (Console.ReadLine());

            Console.Write("Ingresar porcentaje de comisión sin el %: ");
            commissionPercentage = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresar ventas: ");
            sales = Convert.ToDecimal(Console.ReadLine());

            CommissionEmployee commissionEmployee = new CommissionEmployee()
            {
                Id = id,
                FirstName = firstname,
                LastName = lastname,
                BirthDate = dateObject3,
                HiringDate = dateObject3,
                IsActive = true,
                CommissionPercentage = commissionPercentage,
                Sales = sales,
            };

            commission = commissionEmployee.GetValueToPay();
            Console.WriteLine(commissionEmployee);
            Console.WriteLine($"\tComisión: {commission}");


            break;

        default:

        break;


    }
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}



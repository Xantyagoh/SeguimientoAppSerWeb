
using EmployeeOOP.Clases;
try
{
    //Declaracion de variables
    int day, month, year;

    Console.WriteLine("OPP APPLICATION");
    Console.WriteLine("----------------");

    Console.Write("Ingresar el dia: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Ininicializacion de la clase Date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

}

catch (Exception ex)
{

	Console.WriteLine(ex.Message);
}



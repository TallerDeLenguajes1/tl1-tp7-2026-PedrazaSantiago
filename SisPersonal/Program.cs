using EspacioEmpleado;

Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado("Juan", "Pérez", new DateTime(1965, 8, 12), 'C', new DateTime(2010, 5, 10), 650000, Cargos.Ingeniero);
empleados[1] = new Empleado("Ana", "Gómez", new DateTime(1988, 3, 25), 'S', new DateTime(2020, 2, 15), 500000, Cargos.Administrativo);
empleados[2] = new Empleado("Carlos", "Rodríguez", new DateTime(1970, 11, 2), 'C', new DateTime(1995, 1, 20), 700000, Cargos.Especialista);

double montoTotal = 0;
foreach (Empleado empleado in empleados)
{
    montoTotal += empleado.Salario();
}

Console.WriteLine($"Monto total: {montoTotal:C}");

Empleado empleadoCercanoJub = empleados[0];
for (int i = 0; i < empleados.Length;i++)
{
    if (empleados[i].Jubilacion() < empleadoCercanoJub.Jubilacion())
    {
        empleadoCercanoJub = empleados[i];
    } 
}

Console.WriteLine("Empleado mas proximo a jubilarse:");
Console.WriteLine($"Nombre y apellido: {empleadoCercanoJub.Nombre} {empleadoCercanoJub.Apellido}");
Console.WriteLine($"Edad: {empleadoCercanoJub.Edad()} años");
Console.WriteLine($"Años que le faltan para jubilarse: {empleadoCercanoJub.Jubilacion()} años");
Console.WriteLine($"Salario total:{empleadoCercanoJub.Salario():C}");

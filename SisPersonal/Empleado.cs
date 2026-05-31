namespace EspacioEmpleado;

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fecNac;
    private char estadoCivil;
    private DateTime fecIng;
    private double sueldo;
    private Cargos cargo;

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public string Apellido
    {
        get => apellido;
        set => apellido = value;
    }

    public DateTime FechaNacimiento
    {
        get => fecNac;
        set => fecNac = value;
    }

    public char EstadoCivil
    {
        get => estadoCivil;
        set => estadoCivil = value;
    }

    public DateTime FechaIngreso
    {
        get => fecIng;
        set => fecIng = value;
    }

    public double Sueldo
    {
        get => sueldo;
        set => sueldo = value;
    }

    public Cargos Cargo
    {
        get => cargo;
        set => cargo = value;
    }
    public Empleado(string nombre, string apellido, DateTime fecNac, char estadoCivil, DateTime fecIng, double sueldo, Cargos cargo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fecNac = fecNac;
        this.estadoCivil = estadoCivil;
        this.fecIng = fecIng;
        this.sueldo = sueldo;
        this.cargo = cargo;
    }
    public int Antiguedad()
    {
        DateTime actual = DateTime.Today;
        int antiguedad = actual.Year - this.fecIng.Year;
        return antiguedad;
    }

    public int Edad()
    {
        DateTime actual = DateTime.Today;
        int edad = actual.Year - this.fecNac.Year;
        return edad;
    }

    public int Jubilacion()
    {
        int edad = Edad();
        int AniosJub = 65 - edad;
        if(AniosJub < 0)
        {
            return 0;
        } 
        return AniosJub;
    }

    public double Salario()
    {
        int antiguedad = Antiguedad();
        double porcAnt;
        if(antiguedad <= 20)
        {
            porcAnt = antiguedad * 0.01;
        }
        else
        {
            porcAnt = 0.25;
        }

        double adicional = sueldo*porcAnt;
        if (this.cargo == Cargos.Ingeniero || this.cargo == Cargos.Especialista)
        {
            adicional *= 1.50;
        }
        if (char.ToLower(this.estadoCivil) == 'c')
        {
            adicional += 150000;
        }
        return sueldo+adicional;
    }
}
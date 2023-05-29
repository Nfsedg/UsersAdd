using System;
namespace POO2.Clases
{
	public class Persona
	{

			public string Name { get; set; }
			public string Lastname { get; set; }
			public string Carrera { get; set; }
			public int Edad { get; set; }

			public void printData()
		{
            Console.WriteLine("Los datos registrados son");
            Console.WriteLine("Nombre: " + this.Name);
            Console.WriteLine("Apellido: " + this.Lastname);
            Console.WriteLine("Edad: " + this.Edad);
            Console.WriteLine("Carrera: " + this.Carrera);
        }
			
    }
}


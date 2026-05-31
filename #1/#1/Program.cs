using System;

class Program
{
    static void Main()
    {
        string nombre;
        string apellido;
        int edad;
        double altura;

        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su apellido: ");
        apellido = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su altura: ");
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Apellido: " + apellido);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Altura: " + altura);

        Console.WriteLine("Hola, mi nombre es " + nombre + " " + apellido + " y tengo " + edad + " años. Mi altura es " + altura + " metros.");
    }
}
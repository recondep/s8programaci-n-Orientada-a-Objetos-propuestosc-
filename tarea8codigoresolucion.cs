using System;
using System.Collections.Generic;

public class Persona
{
    public string Nombre { get; set; }
    public int NumeroAsiento { get; set; }

    public Persona(string nombre, int numeroAsiento)
    {
        Nombre = nombre;
        NumeroAsiento = numeroAsiento;
    }
}

public class Cola
{
    private Queue<Persona> personas = new Queue<Persona>();

    public void Enqueue(Persona persona)
    {
        personas.Enqueue(persona);
    }

    public Persona Dequeue()
    {
        return personas.Dequeue();
    }

    public int Count()
    {
        return personas.Count;
    }
}

public class Programa
{
    public static void Main(string[] args)
    {
        Cola cola = new Cola();
        for (int i = 1; i <= 30; i++)
        {
            Console.WriteLine("Ingrese el nombre de la persona " + i + ": ");
            string nombre = Console.ReadLine();
            cola.Enqueue(new Persona(nombre, i));
        }

        Console.WriteLine("Asientos asignados:");
        while (cola.Count() > 0)
        {
            Persona persona = cola.Dequeue();
            Console.WriteLine($"{persona.Nombre} tiene el asiento número {persona.NumeroAsiento}");
        }
    }
}

/******************************************************************************

Welcome to GDB Online.
  GDB online is an online compiler and debugger tool for C, C++, Python, PHP, Ruby, 
  C#, OCaml, VB, Perl, Swift, Prolog, Javascript, Pascal, COBOL, HTML, CSS, JS
  Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Personaje
{
    // Atributos
    private string nombre;
    private int vida;
    private int nivel;
    private int ataque;

    // Constructor sin parámetros
    public Personaje()
    {
        nombre = "Personaje";
        vida = 100;
        nivel = 1;
        ataque = 10;
    }

    // Constructor con nombre
    public Personaje(string nombre)
    {
        this.nombre = nombre;
        vida = 100;
        nivel = 1;
        ataque = 10;
    }

    // Constructor con todos los datos
    public Personaje(string nombre, int vida, int nivel, int ataque)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.nivel = nivel;
        this.ataque = ataque;
    }

    // Mostrar información
    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Vida: " + vida);
        Console.WriteLine("Nivel: " + nivel);
        Console.WriteLine("Ataque: " + ataque);
    }

    // Recibir daño
    public void RecibirDanio(int cantidad)
    {
        vida = vida - cantidad;

        if (vida < 0)
        {
            vida = 0;
        }

        Console.WriteLine(nombre + " recibió " + cantidad + " puntos de daño.");
    }

    // Curar
    public void Curar(int cantidad)
    {
        vida = vida + cantidad;

        Console.WriteLine(nombre + " recuperó " + cantidad + " puntos de vida.");
    }

    // Subir nivel
    public void SubirNivel()
    {
        nivel = nivel + 1;
        ataque = ataque + 5;

        Console.WriteLine(nombre + " subió de nivel.");
    }

    // Atacar
    public void Atacar(Personaje enemigo)
    {
        Console.WriteLine(nombre + " atacó a " + enemigo.nombre + ".");
        enemigo.RecibirDanio(ataque);
    }

    // Obtener vida
    public int ObtenerVida()
    {
        return vida;
    }

    // Verificar si está vivo
    public bool EstaVivo()
    {
        return vida > 0;
    }
}


class Program
{
    static void Main()
    {
        // Crear personajes usando los diferentes constructores

        Personaje kratos = new Personaje();

        Personaje mario = new Personaje("Mario");

        Personaje link = new Personaje("Link", 110, 2, 18);


        // ESTADO INICIAL

        Console.WriteLine("================================");
        Console.WriteLine("        ESTADO INICIAL");
        Console.WriteLine("================================");

        Console.WriteLine("\nKRATOS");
        kratos.MostrarInformacion();

        Console.WriteLine("\nMARIO");
        mario.MostrarInformacion();

        Console.WriteLine("\nLINK");
        link.MostrarInformacion();


        // COMBATE

        Console.WriteLine("\n================================");
        Console.WriteLine("           COMBATE");
        Console.WriteLine("================================");

        Console.WriteLine();

        kratos.Atacar(mario);

        Console.WriteLine();

        mario.Atacar(kratos);

        Console.WriteLine();

        link.Atacar(kratos);

        Console.WriteLine();

        kratos.Curar(10);

        Console.WriteLine();

        link.SubirNivel();


        // ESTADO FINAL

        Console.WriteLine("\n================================");
        Console.WriteLine("         ESTADO FINAL");
        Console.WriteLine("================================");

        Console.WriteLine("\nKRATOS");
        kratos.MostrarInformacion();

        Console.WriteLine("\nMARIO");
        mario.MostrarInformacion();

        Console.WriteLine("\nLINK");
        link.MostrarInformacion();


        // VERIFICAR SI ESTÁN VIVOS

        Console.WriteLine("\n================================");
        Console.WriteLine("      ESTADO DE LOS PERSONAJES");
        Console.WriteLine("================================");

        if (kratos.EstaVivo())
        {
            Console.WriteLine("Kratos está vivo.");
        }
        else
        {
            Console.WriteLine("Kratos está derrotado.");
        }

        if (mario.EstaVivo())
        {
            Console.WriteLine("Mario está vivo.");
        }
        else
        {
            Console.WriteLine("Mario está derrotado.");
        }

        if (link.EstaVivo())
        {
            Console.WriteLine("Link está vivo.");
        }
        else
        {
            Console.WriteLine("Link está derrotado.");
        }

        Console.WriteLine("\nPresiona una tecla para terminar...");
        Console.ReadKey();
    }
}
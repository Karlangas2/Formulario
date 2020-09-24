using System;

namespace FormularioA
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre, numerotel, correo, ocupacion;
            int edad;
            Console.WriteLine("Escribe Tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduce Tu edad");
            edad = int.Parse(Console.ReadLine());
            //edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tu nombre es : {0}", nombre);
            Console.WriteLine("Tu edad es : {0}", edad);

            if (edad < 17)
            {
                Console.WriteLine("Menor De edad, Registro No existoso. ");
            }
            else
            {
                Console.WriteLine("Registro Exitoso.");

            }
        }
    }
}

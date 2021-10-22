using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] b = new string[5];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = "Buen dia" + (i + 1);
            }

            for(int i=0; i< b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

            Persona[] A = new Persona[5];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = new Persona();
                Console.WriteLine("Nombre: ");
                A[i].Nombre = Console.ReadLine();
                Console.WriteLine("Apellidos:");
                A[i].Apellidos = Console.ReadLine();
                A[i].FechaNac = DateTime.Now;             
            }
            for(int i=0; i<A.Length; i++)
            {
                Console.WriteLine(A[i].ToString());
            }
            Console.ReadKey();

        }
    }
}

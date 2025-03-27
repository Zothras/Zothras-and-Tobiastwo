using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zothras_and_Tobiastwo
{
    internal class Program
    {
        public class Participante
        {
            public int NroParticipante { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public double Tiempo { get; set; }
            public double Altura { get; set; }
            public string Categoria { get; set; }
            public void CargarParticipante()

            {
                while (NroParticipante != 0)
                {
                    Console.WriteLine("Ingrese el numero del participante participante");
                    NroParticipante = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del participante");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido del participante");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido");
                    apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese el tiempo que duro dentro de la carrera");
                    Tiempo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del participante");
                    Altura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la categoria del participante");
                    Categoria = Console.ReadLine();

                }



            }

        }

        

        static void Main(string[] args)
        {



            List<Participante> participantes = new List<Participante>();
            Participante participante = new Participante();
            participante.CargarParticipante();
            participantes.Add(participante);

            Console.ReadKey();
        }
    }
}

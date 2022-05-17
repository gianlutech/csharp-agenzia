using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    class Program
    {
        static void Main(string[] args)
        {
            Villa v = new Villa(213, 3, 2, "Va92", "frutteto 23", 51100, "Pistoia", 180);
            Appartamento a = new Appartamento(2, 1, "Vb92", "garibaldi 1", 51100, "Pistoia", 120);
            Agenzia agenzia = new Agenzia("Casetti");

            agenzia.AddImmobile(v);
            List<Immobile> listaImmobili = agenzia.CercaImmobili("Pistoia");
            foreach (Immobile immobile in listaImmobili)
            {
                Console.WriteLine(immobile);
            }



        }
    }
}
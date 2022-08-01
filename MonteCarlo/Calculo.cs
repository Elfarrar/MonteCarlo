using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    public class Calculo
    {
        public IEnumerable<Pontos> GerarPontos(int quantidade)
        {
            Pontos[] pontos = new Pontos[quantidade];
            Random random = new Random();
            for (int i = 0; i < quantidade; i++)
            {
                pontos[i] = new Pontos()
                {
                    X = random.NextDouble(),
                    Y = random.NextDouble(),
                };
            }

            return pontos;

        }


        public double Aproximacao(IEnumerable<Pontos> pontos)
        {
            int insideCount = 0;
            int outsideCount = 0;

            foreach (var p in pontos)
            {
                var resultado = (p.Y * p.Y) + (p.X * p.X);
                if (resultado <= 1)
                    insideCount++;
                else
                    outsideCount++;
            }

            return 4 * (double)insideCount / (double)pontos.Count();
        }
    }
}

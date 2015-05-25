using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2_Testiranje
{
    public class Pravokutnik
    {
        private float stranicaA;
        private float stranicaB;

        public Pravokutnik(float stranicaA, float stranicaB)
        {
            this.stranicaA = stranicaA;
            this.stranicaB = stranicaB;
        }

        /// <summary>
        /// Izračunava dijagonalu pravokutnika.
        /// </summary>
        /// <returns>Dijagonala pravokutnika.</returns>
        public float IzracunajDijagonalu()
        {
            float dijagonala = 0;

            dijagonala = (float) Math.Sqrt(stranicaA * stranicaA + stranicaB * stranicaB);

            return dijagonala;
        }

        /// <summary>
        /// Izračunava površinu pravokutnika.
        /// </summary>
        /// <returns>Površina pravokutnika.</returns>
        public float IzracunajPovrsinu()
        {
            float povrsina = 0;

            povrsina = stranicaA * stranicaB;

            if (povrsina >= 0)
                return povrsina;
            else return 0;
        }

        /// <summary>
        /// Izračunava opseg pravokutnika.
        /// </summary>
        /// <returns>Opseg pravkutnika.</returns>
        public float IzracunajOpseg()
        {
            float opseg = 0;

            opseg = 2 * stranicaA + 2 * stranicaB;

            return opseg;
        }
    }
}

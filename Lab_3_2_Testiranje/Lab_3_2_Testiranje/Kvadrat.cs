using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2_Testiranje
{
    public class Kvadrat
    {
        private float stranicaA;

        public Kvadrat(float stranicaA) {
            this.stranicaA = stranicaA;
        }
        /// <summary>
        /// Izračunava dijagonalu kvadrata.
        /// </summary>
        /// <returns>Dijagonala kvadrata.</returns>
        public float IzracunajDijagonalu() {
            float dijagonala = 0;

            dijagonala = stranicaA * (float)Math.Sqrt(2);
            if (dijagonala >= 0) return dijagonala;
            else return 0;
        }

        public float IzracunajPovrsinu() {
            float povrsina = 0;

            povrsina = stranicaA * stranicaA;

            return povrsina;
        }

        public float IzracunajOpseg() {
            float opseg = 0;
            if(stranicaA>=0) opseg = 4 * stranicaA;

            return opseg;
        }
    }
}

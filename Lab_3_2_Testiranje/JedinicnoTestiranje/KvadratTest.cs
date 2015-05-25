using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3_2_Testiranje;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class KvadratTest
    {
        [TestMethod]
        public void IzracunajDijagonaluTest()
        {
            Kvadrat k1 = new Kvadrat(0);
            float d1 = k1.IzracunajDijagonalu();
            Assert.AreEqual(0, d1, "Izračun dijagonale nije točan!");

            Kvadrat k2 = new Kvadrat(-5);
            float d2 = k2.IzracunajDijagonalu();
            Assert.IsTrue(d2 >= 0, "Dijagonala mora biti veća od nule!");

            Kvadrat k3 = new Kvadrat(1);
            float d3 = k3.IzracunajDijagonalu();
            Assert.AreEqual((float)Math.Sqrt(2), d3, "Izračun dijagonale nije točan!");
        }

        [TestMethod]
        public void IzracunajPovrsinuTest() {
            Kvadrat k1 = new Kvadrat(0);
            float povrsina1 = k1.IzracunajPovrsinu();
            Assert.AreEqual(0, povrsina1, "Izračun površine nije točan!");

            Kvadrat k2 = new Kvadrat(-1);
            float povrsina2 = k2.IzracunajPovrsinu();
            Assert.IsTrue(povrsina1 >= 0, "Površina mora biti veća od nule!");

            Kvadrat k3 = new Kvadrat(5);
            float povrsina3 = k3.IzracunajPovrsinu();
            Assert.AreEqual(25, povrsina3, "Izračun površine nije točan!");
        }

        [TestMethod]
        public void IzračunajOpsegTest() {
            Kvadrat k1 = new Kvadrat(0);
            float opseg1 = k1.IzracunajOpseg();
            Assert.AreEqual(0, opseg1, "Izračun opsega nije točan!");

            Kvadrat k2 = new Kvadrat(-1);
            float opseg2 = k2.IzracunajOpseg();
            Assert.IsTrue(opseg2 >= 0, "Opseg mora biti veći od nule!");

            Kvadrat k3 = new Kvadrat(5);
            float opseg3 = k3.IzracunajOpseg();
            Assert.AreEqual(20, opseg3, "Izračun opsega nije točan!");
        }
    }
}

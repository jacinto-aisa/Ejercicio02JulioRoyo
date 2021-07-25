using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Proyecto04.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPesable()
        {
            decimal pesoA = 50;
            Acero acero = new Acero(pesoA);
            Assert.AreEqual(50, acero.DevolverPeso());

            decimal pesoB = 30;
            Bronce bronce = new Bronce(pesoB);
            Assert.AreEqual(30, bronce.DevolverPeso());

            decimal pesoC = 1;
            Chip chip = new Chip(pesoC);
            Assert.AreEqual(1, chip.DevolverPeso());

            decimal pesoE = 5;
            Escoba escoba = new Escoba(pesoE);
            Assert.AreEqual(5, escoba.DevolverPeso());

            decimal pesoG = 2;
            Gominola gominola = new Gominola(pesoG);
            Assert.AreEqual(2, gominola.DevolverPeso());

            decimal pesoH = 4;
            Higo higo = new Higo(pesoH);
            Assert.AreEqual(4, higo.DevolverPeso());

            decimal pesoP = 3;
            Papel papel = new Papel(pesoP);
            Assert.AreEqual(3, papel.DevolverPeso());


        }

        [TestMethod]
        public void TestFuncionalidades()
        {


            List<IPesable> ElementosPesables = new List<IPesable>(1000);
            List<String> NombreElementos = new List<string>(1000);
            NombreElementos.Add("Acero");
            NombreElementos.Add("Bronce");
            NombreElementos.Add("Higo");
            NombreElementos.Add("Papel");
            NombreElementos.Add("Escoba");
            NombreElementos.Add("Chip");
            NombreElementos.Add("Gominola");

            foreach (var item in NombreElementos)
            {

                switch (item.ToString())
                {
                    case "Acero": ElementosPesables.Add(new Acero(50)); break;
                    case "Bronce": ElementosPesables.Add(new Bronce(35)); break;
                    case "Chip": ElementosPesables.Add(new Chip((decimal)0.01)); break;
                    case "Escoba": ElementosPesables.Add(new Escoba((decimal)0.2)); break;
                    case "Higo": ElementosPesables.Add(new Higo((decimal)0.005)); break;
                    case "Papel": ElementosPesables.Add(new Papel((decimal)0.001)); break;
                    case "Gominola": ElementosPesables.Add(new Gominola((decimal)0.002)); break;
                    default: break;
                }
            }


            decimal PesoPnoI = 0;
            decimal MediaNoP = 0;
            decimal MediaNoP100 = 0;
            int n = 0;
            foreach (var item in ElementosPesables)
            {
                if (item is IPerecedero && !(item is IInflamable))
                {
                    PesoPnoI += (item as IPesable).DevolverPeso();
                }
                if (!(item is IPerecedero))
                {
                    MediaNoP += (item as IPesable).DevolverPeso() / Int32.Parse(ElementosPesables.Count.ToString());
                    n++;
                    MediaNoP100 = ((decimal)n / (decimal)int.Parse(ElementosPesables.Count.ToString()) * 100);
                }



            }
            Assert.AreEqual((decimal)0.005, PesoPnoI);
            Assert.AreEqual(Math.Truncate((50 + 35 + (decimal)0.001 + (decimal)0.01 + (decimal)0.02) / Int32.Parse(ElementosPesables.Count.ToString())), Math.Truncate(MediaNoP));
            decimal numeroa = (5*100/7*100);
            Assert.AreEqual(Math.Truncate(numeroa/100) , Math.Truncate(MediaNoP100));
            


        }



    }

    }


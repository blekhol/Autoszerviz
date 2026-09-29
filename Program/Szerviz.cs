using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Szerviz
    {
        private List<Jarmu> jarmuvek;

        public Szerviz()
        {
            this.jarmuvek = [];
        }

        public void JarmuFelvetele(Jarmu jarmu)
        {
            jarmuvek.Add(jarmu);
            Console.WriteLine("A jármű megérkezett a szervizbe");
        }

        public void InformaciokListazasa()
        {
            foreach (var j in jarmuvek)
            {
                j.InformaciotAd();
            }
        }

        public void CsoportosSzerviz(int dij)
        {
            foreach (var j in jarmuvek)
            {
                if (j.SzervizSzukseges)
                {
                    j.Szervizel(dij);
                }
                else
                {
                    Console.WriteLine($"A {j.Rendszam} szervizelése jelenleg nem szükséges.");
                }
            }
        }
    }
}

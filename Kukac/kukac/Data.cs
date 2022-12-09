using Kukac.interfaces;
using System.Windows;
using System;
using Kukac.types;
using System.Collections.Generic;
using Kukac.enums;

namespace Kukac.kukac
{


    public class Data : Adat
    {
        private List<RajzolKovetkezo> Rajzolkov { get; set; } = new List<RajzolKovetkezo>();
        private List<Rajzolhato> Rajzolhatok { get; set; }  = new List<Rajzolhato>();

        private List<Leptetheto> Leptethetok { get; set; } = new List<Leptetheto>();

        private List<Kukac.types.Kukac> Kukacok { get; set; } = new List<types.Kukac>();
        private List<Object> Elemek { get; set; } = new List<object>();

        private List<Ai> Aik { get; set; } = new List<Ai>();

        private Dictionary<Ai, Kukac.types.Kukac> Aikukacok { get; set; } = new Dictionary<Ai, types.Kukac>();

        public Palya palya { get; set; } = new Palya();
        public Kaja kaja { get; set; } = new Kaja();

        public PalyaElemek getPalyaElem(int x, int y)
        {
            return palya.getElem(x, y);
        }

        public Test getKukac(int i)
        {
            return (Test)Kukacok[i];
        }

        public void add(Object o)
        {
            if (o is Kaja)
            {
                kaja = (Kaja)o;
            }
            if (o is Palya)
            {
                palya = (Palya)o;
            }
            if (o is Kukac.types.Kukac)
            {
                Kukacok.Add((Kukac.types.Kukac)o);
            }
            if (o is RajzolKovetkezo)
            {
                Rajzolkov.Add((RajzolKovetkezo)o);
            }
            if (o is Rajzolhato)
            {
                Rajzolhatok.Add((Rajzolhato)o);
            }
            if (o is Leptetheto)
            {
                Leptethetok.Add((Leptetheto)o);
            }

            Elemek.Add(o);
        }

        public Kaja getKaja()
        {
            return kaja;
        }

        public Point getEtel()
        {
            return kaja.getEtel();
        }

        public List<Leptetheto> getLeptethetok()
        {
            return Leptethetok;
        }


        public List<Object> getElemek()
        {
            return Elemek;
        }

        public List<Rajzolhato> getRajzolhatok()
        {
            return Rajzolhatok;
        }


        public List<RajzolKovetkezo> getRajzolkov()
        {
            return Rajzolkov;
        }

        public List<Kukac.types.Kukac> getKukacok()
        {
            return Kukacok;
        }

        public Palya getPalya()
        {
            return palya;
        }

        public void addAi(Ai ai, Kukac.types.Kukac k)
        {
            Aik.Add(ai);
            Aikukacok.Add(ai, k);
        }

        public List<Ai> getAik()
        {
            return Aik;
        }

        public Dictionary<Ai, Kukac.types.Kukac> getAikukacok()
        {
            return Aikukacok;
        }

        public Size getPalyaMeret()
        {
            return new Size(palya.meretx, palya.merety);
        }

        public int getKukacDarab()
        {
            return Kukacok.Count;
        }


    }
}
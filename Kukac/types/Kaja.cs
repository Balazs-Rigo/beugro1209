using Kukac.interfaces;
using System.Windows;
using System.Windows.Media;
using Kukac.kukac;
namespace Kukac.types
{


    public class Kaja : RajzolKovetkezo, Rajzolhato, Etel
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Kaja()
        {
            X = 0;
            Y = 0;
        }    

        public void rajzolKov(Graphics g)
        {
            g.setColor(Colors.Cyan);
            g.fillRect(X * Logic.meret, Y * Logic.meret, Logic.meret, Logic.meret);
        }


        public void rajzol(Graphics g)
        {
            g.setColor(Colors.Cyan);
            g.fillRect(X * Logic.meret, Y * Logic.meret, Logic.meret, Logic.meret);
        }


        public Point getEtel()
        {
            return new Point(X, Y);
        }

        public void setXY(int ujx, int ujy)
        {
            X = ujx;
            Y = ujy;
        }

    }
}
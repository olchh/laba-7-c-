using System.Data.Common;
using static System.Console;

namespace laba_7
{
    abstract class Transport
    {
        public abstract int skorost { get; set; }
        public abstract int gruzopodem { get; set; }
        public abstract int dalnostrasstouania { get; set; }

        public abstract int skor();
        public abstract int gruz();
        public abstract int dalnost();
    }

    abstract class Car : Transport
    {
        public override int skor() { return skorost; }
        public override int gruz() { return skorost; }
        public override int dalnost() { return skorost; }
    }
    abstract class Samolot : Transport
    {
        public override int skor() { return skorost; }
        public override int gruz() { return skorost; }
        public override int dalnost() { return skorost; }
    }
    abstract class Korabl : Transport
    {
        public override int skor() { return skorost; }
        public override int gruz() { return skorost; }
        public override int dalnost() { return skorost; }
    }

    class Car2 : Car
    {
        public override int skorost { get; set; }
        public override int gruzopodem { get; set; }
        public override int dalnostrasstouania { get; set; }

        public override int skor()
        {
            Write("автомобиль движется со скоростью ");
            return skorost;
        }
        public override int gruz()
        {
            Write("грузоподьемность автомобиля ");
            return gruzopodem;
        }
        public override int dalnost()
        {
            Write("дальность расстояния автомобиля ");
            return dalnostrasstouania;

        }
    }
    class Samolot2 : Samolot
    {
        public override int skorost { get; set; }
        public override int gruzopodem { get; set; }
        public override int dalnostrasstouania { get; set; }

        public override int skor()
        {
            Write("самолет движется со скоростью " );
            return skorost;
        }
        public override int gruz()
        {
            Write("грузоподьемность самолета ");
            return gruzopodem;
        }
        public override int dalnost()
        {
            Write("дальность расстояния самолета ");
            return dalnostrasstouania;
            
        }
    }

    class Korabl2 : Korabl
    {
        public override int skorost { get; set; }
        public override int gruzopodem { get; set; }
        public override int dalnostrasstouania { get; set; }

        public override int skor()
        {
            Write("корабль движется со скоростью ");
            return skorost;
        }
        public override int gruz()
        {
            Write("грузоподьемность корабля ");
            return gruzopodem;
        }
        public override int dalnost()
        {
            Write("дальность расстояния корабля ");
            return dalnostrasstouania;

        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Car2 pup = new Car2();
            pup.skorost = 100;
            Write(pup.skor());
            WriteLine(" км/час");
            pup.gruzopodem = 200;
            Write(pup.gruz());
            WriteLine(" кг");
            pup.dalnostrasstouania = 1000;
            Write(pup.dalnost());
            WriteLine(" км");
            WriteLine();

            Samolot2 pup2 = new Samolot2();
            pup2.skorost = 10000000;
            Write(pup2.skor());
            WriteLine(" км/час");
            pup2.gruzopodem = 200000000;
            Write(pup2.gruz());
            WriteLine(" кг");
            pup2.dalnostrasstouania = 100000000;
            Write(pup2.dalnost());
            WriteLine(" км");
            WriteLine();

            Korabl2 pup3 = new Korabl2();
            pup3.skorost = 10000000;
            Write(pup3.skor());
            WriteLine(" км/час");
            pup3.gruzopodem = 2000;
            Write(pup3.gruz());
            WriteLine(" кг");
            pup3.dalnostrasstouania = 100000000;
            Write(pup3.dalnost());
            WriteLine(" км");
            WriteLine();

        }
    }
}
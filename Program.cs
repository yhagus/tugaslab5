using System;

namespace TugasLab_5
{
    class PrinterWindows
    {
        public virtual void Show()
        {
        }

        public virtual void Print()
        {
        }
    }

    class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }

        public override void Print()
        {
            Console.WriteLine("Epson printer printing. . .");
        }
    }

    class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing. . .");
        }
    }

    class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing. . .");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Pilih printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.Write("\nNomor printer [1 ... 3] : ");
            int NomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (NomorPrinter == 1)
            {
                printer = new Epson();
                printer.Show();
                printer.Print();
            } else if (NomorPrinter == 2)
            {
                printer = new Canon();
                printer.Show();
                printer.Print();
            } else if (NomorPrinter == 3)
            { 
                printer = new LaserJet();
                printer.Show();
                printer.Print();
            }

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface{
    class Program{
        static void Main(string[] args){
            prints printer = new prints();
            printer.nama = "Printer";
            printer.ukuran = "0*0";


            IPrinterWindows convert;

            Console.WriteLine("Pilih Printer: ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomer Printer [1..3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                convert = new ConvertToEpson();
            else if (nomorPrinter == 2)
                convert = new ConvertToCanon();
            else
                convert = new ConvertToLaserjet();

            convert.show(printer);
            convert.print(printer);

            Console.ReadKey();
        }
    }
}

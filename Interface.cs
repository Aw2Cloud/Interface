using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface{
    public class prints{
        public string nama { get; set; }
        public string ukuran { get; set; }
    }
    public interface IPrinterWindows{
        void show(prints printer);
        void print(prints printer);
        
    }
    public class ConvertToEpson : IPrinterWindows{
        public void show(prints printer){
            printer.nama = "Epson";
            printer.ukuran = "10*11";
            Console.WriteLine("{0} display dimension : {1}", printer.nama,printer.ukuran);
        }
        public void print(prints printer){
            printer.nama = "Epson";
            printer.ukuran = "10*11";
            Console.WriteLine("{0} printer printing...", printer.nama);
        }
}
    public class ConvertToCanon : IPrinterWindows{
        public void show(prints printer){
            printer.nama = "Canon";
            printer.ukuran = "9.5*12";
            Console.WriteLine("{0} display dimension : {1}", printer.nama, printer.ukuran);
        }
        public void print(prints printer){
            printer.nama = "Canon";
            printer.ukuran = "9.5*12";
            Console.WriteLine("{0} printer printing...", printer.nama);
        }
    }
    public class ConvertToLaserjet : IPrinterWindows{
        public void show(prints printer){
            printer.nama = "LeserJet";
            printer.ukuran = "12*12";
            Console.WriteLine("{0} display dimension : {1}", printer.nama, printer.ukuran);
        }
        public void print(prints printer){
            printer.nama = "LeserJet";
            printer.ukuran = "12*12";
            Console.WriteLine("{0} printer printing...", printer.nama);
        }
    }
}

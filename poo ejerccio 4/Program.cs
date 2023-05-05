using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ejerccio_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro si = new Carro(123, "ksgd", "agwsdu", 100, 2000, 2007, 's');
            Console.WriteLine("el presio aumento por el sidecar {0}", si.Global());
            Moto op = new Moto(124,"gardy","ssDIF",1000,20000,2019,'s');
            Console.WriteLine("El presio aunmentado por la airbag {0}", op.Global());
            
            Console.ReadKey();
        }
    }
}

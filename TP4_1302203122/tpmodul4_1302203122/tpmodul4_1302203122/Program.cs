using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302203122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string namaKu;
            Console.Write("Massukan Nama : ");
            namaKu = Console.ReadLine();
        }
    }
    class HaloGeneric
    {
      public static void sapauser<t>(t nama)
        {
            console.writeline("halo userr" + nama);
        }
    }
}

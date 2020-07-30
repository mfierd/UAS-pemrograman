using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fp.AbstractionClass //Abstraction dengan interface, class turunan
{
    public class costumer : abstrac
    {
        public void pembeli()
        {
            Console.WriteLine("\n 1. Costumer memilih barang");
        }
        public void transaksi()
        {
            Console.WriteLine("\n 2. Melakukan transaksi penjualan");
        }
        public void bayar()
        {
            Console.WriteLine("\n 3. Pembayaran costumer dicatat di nota");
        }
    }
}

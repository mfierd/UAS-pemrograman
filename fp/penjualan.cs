using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    public class Penjualan
    {
        //private int Nota; //contoh field enkapsulasi
        public int Nota { get; set; }
        public string Tanggal { get; set; }
        public string Customer { get; set; }
        public string Jenis { get; set; }
        public int TotalNota { get; set; }
        //public int Nota1 { get => this.Nota; set => this.Nota = value; } //property dari field enkapsulasi
    }
}

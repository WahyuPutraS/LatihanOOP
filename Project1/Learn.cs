using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Learn
    {
        private string Nama;
        private string Jenis;

        public string _Nama_
        {
            get { return Nama; }
            set { Nama = value; }

        }
        public string _Jenis_
        {
            get { return Jenis; }
            set { Jenis = value; }

        }


        public Learn(string nmNama, string nmJenis)
        {
            Nama = nmNama;
            Jenis = nmJenis;

        }

    }
}



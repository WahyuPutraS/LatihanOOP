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
        private int Umur;
        

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

        public int _Umur_
        {
            get { return Umur; }
            set { Umur = value;  }
        }


        public string Alamat;
        public int NoHp;


        public Learn(string nmNama, string nmJenis, string nmAlamat, int NOOhp, int Age )
        {
            Nama = nmNama;
            Jenis = nmJenis;
            Alamat = nmAlamat;
            NoHp = NOOhp;
            Umur = Age;

        }

    }
}



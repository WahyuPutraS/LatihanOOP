using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Belajar
    {
        static void Main(string[] args)
        {
            var Employee = new Learn("Kurniawan", "Programer","Jln GN Agung", 0867483748,29);
            Console.WriteLine(Employee._Nama_);
            Console.WriteLine(Employee._Jenis_);
            Console.WriteLine(Employee.Alamat);
            Console.WriteLine(Employee.NoHp);
            Console.WriteLine(Employee._Umur_);

        }
    }
}

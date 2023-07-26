// See https://aka.ms/new-console-template for more information
namespace Program
{

    class Mahasiswa
    {

        public string Nama;



        public void Named()
        {
            Nama = "Putu Wahyu Putra Suartama";

           

        }




    }

    class Identity
    {
        static void Main(string[] args)
        {
            var Maha = new Mahasiswa();
            Maha.Named();
            Console.WriteLine(Maha.Nama);

        }

    }







}
    

  

    
    


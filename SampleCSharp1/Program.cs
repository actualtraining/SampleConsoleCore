using System;

namespace SampleCSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bil1 = 12;
            double bil2 = 13.4;

            bool check = true;

            //narrowing conversion
            //int bil3 = Convert.ToInt32(bil2);
            int bil3 = (int)bil2;

            double bil4 = bil1;

            //reference type
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "99887701";
            mhs1.Nama = "Erick Kurniawan";
            mhs1.IPK = 3.4;

            /*Console.WriteLine("Nilai : "+bil3.ToString());
            Console.WriteLine("Nilai Bil4 : " + bil4.ToString());
            Console.WriteLine("Nilai check : " + check.ToString());*/

            //menampilkan reference type
            Console.WriteLine(mhs1.Nim + " - " + mhs1.Nama + " - " 
                + mhs1.IPK.ToString());
        }
    }
}
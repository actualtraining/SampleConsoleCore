using System;
using System.Collections.Generic;

namespace SampleCSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bil1 = 12;
            int bil2 = bil1;

            bil2 = bil2 + 5;
           

            //reference type
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "99887701";
            mhs1.Nama = "Erick Kurniawan";
            mhs1.IPK = 3.4;

            Mahasiswa mhs2 = mhs1;
            mhs2.IPK = 3.6;

            Console.WriteLine("Bil 2 : " + bil2.ToString());
            Console.WriteLine("Bil 1 : " + bil1.ToString());
            
            //menampilkan reference type
            Console.WriteLine(mhs1.Nim + " - " + mhs1.Nama + " - " 
                + mhs1.IPK.ToString());

            List<string> arrName = new List<string>();
            arrName.Add("Erick");
            arrName.Add("Budi");
            arrName.Add("Lazuwardi");
            arrName.Add("Andi");
            arrName.Add("Joni");

            foreach(string name in arrName)
            {
                Console.WriteLine(name.ToString());
            }

            string[] arrMatkul = new string[3];
            arrMatkul[0] = "Algoritma dan Pemrograman";
            arrMatkul[1] = "Web Development";
            arrMatkul[2] = "Mobile Development";
            
            for(int i=0;i<3;i++)
            {
                Console.WriteLine(arrMatkul[i]);
            }

        }
    }
}
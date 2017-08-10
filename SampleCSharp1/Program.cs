using System;
using System.Collections.Generic;

namespace SampleCSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int bil1 = 12;
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
            }*/

            /*int bil1 = 12;
            int bil2 = 12;
            bool cek = bil1 == bil2;
            Console.WriteLine(cek);

            Mahasiswa mhs1 = new Mahasiswa
            {
                Nim = "22998877",
                Nama = "Budi",
                IPK = 3.4
            };

            Mahasiswa mhs2 = new Mahasiswa
            {
                Nim = "22998877",
                Nama = "Budi",
                IPK = 3.4
            };

            object mhs3 = new object();

            bool cekobjek = mhs1 is Mahasiswa;
            Mahasiswa konversi = mhs3 as Mahasiswa;
            Console.WriteLine(cekobjek);*/

            /*int nilai = 0;

            Console.Write("Masukan Nilai :");

            try
            {
                nilai = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (nilai >= 80)
            {
                Console.WriteLine("A");
            }
            else if (nilai >= 70)
            {
                Console.WriteLine("B");
            }
            else if (nilai >= 60)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("D");
            }

            string jurusan = "01";
            switch (jurusan)
            {
                case "01":
                    Console.WriteLine("TI");
                    break;
                case "02":
                    Console.WriteLine("SI");
                    break;
                default:
                    Console.WriteLine("Biology");
                    break;
            }

            int bil = 0;
            while (bil < 10)
            {
                bil++;
                if (bil == 5)
                    continue;

                Console.WriteLine(bil);
            }

            do
            {
                bil++;
                Console.WriteLine(bil);
            } while (bil < 10);*/

            /*HelperMethod myHelper = new HelperMethod();
            Console.Write("Masukan Alas :");
            double alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Tinggi :");
            double tinggi = Convert.ToDouble(Console.ReadLine());

            int tg2 = 12;

            double hasil = myHelper.HitungLuasSegitiga(alas, tg2);
            Console.WriteLine("Hasilnya : " + hasil);

            Console.WriteLine("Alas : " + alas.ToString());

            Console.WriteLine(HelperMethod.HitungPersegi(10, 10));*/


            Queue<string> queueName = new Queue<string>();
            queueName.Enqueue("Erick");
            queueName.Enqueue("Budi");
            queueName.Enqueue("Bambang");
            queueName.Enqueue("Joni");

            int jumlah = queueName.Count;

            for(int i=0;i<jumlah;i++)
            {
                Console.WriteLine(queueName.Dequeue());
            }

            Stack<string> stackName = new Stack<string>();
            stackName.Push("Erick");
            stackName.Push("Budi");
            stackName.Push("Bambang");
            stackName.Push("Joni");

            int jmlStack = stackName.Count;
            for(int i = 0; i < jmlStack; i++)
            {
                Console.WriteLine(stackName.Pop());
            }

            List<Mahasiswa> lstMhs = new List<Mahasiswa>();
            Mahasiswa mhs1 = new Mahasiswa
            {
                Nim = "88992255",
                Nama = "Erick Kurniawan",
                IPK = 3.6
            };
            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "88992256";
            mhs2.Nama = "Budi Sutedjo";
            mhs2.IPK = 3.4;

            lstMhs.Add(mhs1);
            lstMhs.Add(mhs2);

            foreach(Mahasiswa mhs in lstMhs)
            {
                Console.WriteLine(mhs.Nim + " " + mhs.Nama + " " + mhs.IPK);
            }

            Dictionary<string, string> myDict = new Dictionary<string, string>();
            myDict.Add("YY", "Yogyakarta");
            myDict.Add("JJ", "Jakarta");
            myDict.Add("BB", "Bandung");

            Console.WriteLine(myDict["YY"]);

            foreach(KeyValuePair<string,string> dict in myDict)
            {
                Console.WriteLine("Key :" + dict.Key + " - Value:" + dict.Value);
            }

            Dosen dsn = new Dosen();
            Console.WriteLine(dsn.Nama + " " + dsn.Alamat + " " + dsn.Email);
        }
    }
}
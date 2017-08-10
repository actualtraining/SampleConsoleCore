using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCSharp1
{
    public class HelperMethod
    {
        public static double HitungPersegi(double panjang,double lebar)
        {
            double luas = panjang * lebar;
            return luas;
        }

        public double HitungLuasSegitiga(double alas,double tinggi)
        {
            alas = alas + 5;
            double hasil = 0.5 * alas * tinggi;
            return hasil;
        }

        public double HitungLuasSegitiga(double alas,int tinggi)
        {
            double hasil = 0.5 * alas * 30;
            return hasil; 
        }

        public void HitungLuasLingkaran(double jari)
        {
            double hasil = Math.PI * jari * jari;
            Console.WriteLine("Luas : " + hasil);
        }
    }
}

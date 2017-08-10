using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCSharp1
{
    public class HelperMethod
    {
        public double HitungLuasSegitiga(double alas,double tinggi)
        {
            double hasil = 0.5 * alas * tinggi;
            return hasil;
        }

        public void HitungLuasLingkaran(double jari)
        {
            double hasil = Math.PI * jari * jari;
            Console.WriteLine("Luas : " + hasil);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCSharp1
{
    public class Mahasiswa
    {
        private string nim;
        public string Nim
        {
            get { return nim; }
            set {
                if (value.Length == 8)
                    nim = value;
                else
                    nim = "88888888";
            }
        }

        private string nama;
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        private double ipk;
        public double IPK
        {
            get { return ipk; }
            set { ipk = value; }
        }

    }
}

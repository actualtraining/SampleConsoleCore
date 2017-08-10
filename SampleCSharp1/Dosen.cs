using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCSharp1
{
    public class Dosen 
    {

        public Dosen()
        {
            Nama = "Erick";
            Alamat = "Jd DR Wahidin 5";
            Email = "erick@actual-training.com";
        }

        public string Nama { get; set; }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Alamat { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XongAgile
{
    internal class accountSV
    {
        private string name;
        private string email;
        private string phonee;
        private string tentaikhoan;
        private string matkau;
        private string xacmk;

        public accountSV()
        {
        }

        public accountSV(string name, string email, string phonee, string tentaikhoan, string matkau, string xacmk)
        {
            this.name = name;
            this.email = email;
            this.phonee = phonee;
            this.tentaikhoan = tentaikhoan;
            this.matkau = matkau;
            this.xacmk = xacmk;
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phonee { get => phonee; set => phonee = value; }
        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Matkau { get => matkau; set => matkau = value; }
        public string Xacmk { get => xacmk; set => xacmk = value; }
        public string CreateAccount()
        {
            return $"{name}|{email}|{phonee}|{tentaikhoan}|{matkau}|{xacmk}\n";
        }
    }
}

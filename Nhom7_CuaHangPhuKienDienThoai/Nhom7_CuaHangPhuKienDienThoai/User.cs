using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMain
{
    internal class User
    {
        public string TENNV { get; set; }
        public string MATKHAU { get; set; }
        public string PHANQUYEN { get;set; }
        public User() { }
        public User (string ten, string mk, string pq)
        {
            TENNV = ten;
            MATKHAU = mk;
            PHANQUYEN = pq;
        }
    }
}

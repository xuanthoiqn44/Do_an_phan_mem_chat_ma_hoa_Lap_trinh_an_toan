using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Server
{
    class diffie_hellman
    {
        private BigInteger p, g, private_key, public_key, key_chung;
        public BigInteger Publickey
        {
            get { return public_key; }
            set { public_key = value; }
        }
        public BigInteger Key_Chung
        {
            get { return key_chung; }
            set { key_chung = value; }
        }

        //public BigInteger Private_key { get => private_key; set => private_key = value; }
        public BigInteger P { get => p; set => p = value; }
        public BigInteger G { get => g; set => g = value; }

        public diffie_hellman(BigInteger p, BigInteger g)
        {
            this.p = p;
            this.g = g;
            Tao_private_key();
            Tinh_public_key();
        }

        public void Tinh_public_key()
        {
            public_key = BigInteger.ModPow(g, private_key, p);
        }
        public void Tinh_key_chung(int public_key)
        {
            key_chung = BigInteger.ModPow(public_key, private_key, p);
        }

        public void Tao_private_key()
        {
            Random rd = new Random();
            private_key = rd.Next(1, (int)p);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace laba1
{
    class Izdelie
    {
        private string name;
        private string cipher;
        private int amount;

        public Izdelie()
        {
            name = "";
            cipher = "";
            amount = 0;
        }

        public Izdelie(string n,string a,int c)
        {
            name = n;
            cipher = a;
            amount = c;
        }

        public void ShowName()
        {
            Console.WriteLine("The current product name = " + name);
        }

        public void ShowCipher()
        {
            Console.WriteLine("The current product cipher = " + cipher);
        }

        public void ShowAmount()
        {
            Console.WriteLine("The current product amount = " + amount);
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Cipher
        {
            get
            {
                return cipher;
            }
            set
            {
                cipher = value;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
    }
}

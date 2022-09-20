using System;
using System.Reflection.Metadata;

namespace Polimorfism
{
     class Buyer
    {
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public double Balance { get; private set; }
        public double Spent { get; private set; }

        public Buyer(string Name,string Adress,int Balance,int Spent)
        {
            this.Name = Name;
            this.Adress = Adress;
            this.Balance = Balance;
            this.Spent = Spent;
        }

        public void ReduceBalance(double Price)
        {
            Balance -= Price;
            Spent += Price;
        }

    }
}

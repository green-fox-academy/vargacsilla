using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { set; get; }
        public int Balance { set; get; }
        public AnimalType AnimalType { set; get; }

        public BankAccount(string name, int balance, AnimalType animalType)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
        }
    }
}

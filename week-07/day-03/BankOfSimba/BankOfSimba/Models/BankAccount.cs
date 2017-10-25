using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { set; get; }
        public decimal Balance { set; get; }
        public AnimalType AnimalType { set; get; }
        public string Currency { get; set; } = "Zebra";
        public bool IsKing { get; set; } = false;
        public GoodOrBad GoodOrBad { get; set; } = GoodOrBad.GoodOne;

        public BankAccount(string name, decimal balance, AnimalType animalType)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
        }

        public BankAccount(string name, decimal balance, AnimalType animalType, bool isKing, GoodOrBad goodOrBad)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            IsKing = isKing;
            GoodOrBad = goodOrBad;
        }
    }
}

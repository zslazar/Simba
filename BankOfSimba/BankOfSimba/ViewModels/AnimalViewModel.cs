using BankOfSimba.Models;
using System.Collections.Generic;

namespace BankOfSimba.ViewModels
{
    public class AnimalViewModel
    {
        public List<BankAccount> AnimalList { get; set; } = new List<BankAccount>();

        public AnimalViewModel()
        {
            InitAnimalList();
        }

        private void InitAnimalList()
        {
            //part One
            //AnimalList.Add(new BankAccount("Simbaaaa", 2000.00, "lion"));
            //AnimalList.Add(new BankAccount("Nala", 2200, "lion"));
            //AnimalList.Add(new BankAccount("Rafiki", 5000, "monkey"));

            AnimalList.Add(new BankAccount()
            {
                Name = "Simba",
                Balance = 2000.00,
                Currency = "Zebra",
                AnimalType = "Lion",
                Owner = true,
                SoulType = true,
            });

            AnimalList.Add(new BankAccount()
            {
                Name = "Nala",
                Balance = 2200.00,
                Currency = "Zebra",
                AnimalType = "Lion",
                Owner = false,
                SoulType = true,
            });

            AnimalList.Add(new BankAccount()
            {
                Name = "Zordon",
                Balance = 200.00,
                Currency = "Zebra",
                AnimalType = "Lion",
                Owner = false,
                SoulType = false,
            });
        }
    }
}
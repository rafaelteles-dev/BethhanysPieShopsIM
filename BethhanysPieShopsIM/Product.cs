using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethhanysPieShopsIM
{
    internal class Product
    {
        private int id;
        private string name = string.Empty;
        private string? description;

        private int maxItemInStock = 0;

        //private UnitType unitType;
        //private double amountInStock = 0;
        //private bool isBelowStockTreshold = false; "Não precisa de variavel quando se tem property sem logica, pois ela cria uma variavel 'oculta'


        public Product(int id) : this(id, string.Empty)
        {
        }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Product(int id, string name, string? description, UnitType unitType, int maxAmountInStock)
        {
            Id = id;
            Name = name;
            Description = description;
            UnitType = unitType;
            maxItemInStock = maxAmountInStock;

            UpdateLowStock();
        }


        public int Id { get => id; set => id = value; }
        public string Name
        {
            get => name;
            set
            {
                name = value.Length >= 50 ? value[..50] : value;//caso seja maior que 50 ? vai fazer isso [..50] significa
                                                                //que só vai pegar todos os caracteres até chegar em 50
            }
        }
        public string Description
        {
            get => description;
            set
            {
                if (value == null)
                    description = string.Empty;
                else
                {
                    description = value.Length >= 250 ? value[..250] : value;
                }
            }
        }
        public UnitType UnitType { get; set; }
        public int AmountInStock { get; private set; }
        public bool IsBelowStockTreshold { get; private set; }

        public void UseProduct()
        {
            //Use, take from stock then update and check if low in stock
        }

        private void UpdateLowStock()
        {
            throw new NotImplementedException();
        }
        public void IncreaseStock()
        {
            AmountInStock++;
        }

        public void IncreaseStock(int amount)
        {
            int newStock = AmountInStock + amount;
            if(newStock < maxItemInStock)
                AmountInStock = newStock;
            else
            {
                AmountInStock = maxItemInStock;
                Log($"{CreateSimpleProductRepresentation} stock overflow. {newStock - AmountInStock} item(s) ordered that couldn't be stored.");
            }
            if (AmountInStock > 10)
                IsBelowStockTreshold = false;
        }

        private void Log(string text)
        {
            Console.WriteLine(text); ;
        }

        public void CreateSimpleProductRepresentation() { }

        public void AddNewProductToInventory() { }

        public void AlertIfLowOnStock() { }

        public string DisplayDetailsShort() 
        {
            return $"{Id} {Name} \n{Description} \n{AmountInStock} item(s) in stock";
        }

        public string DisplayDetailsFull()
        {
            return DisplayDetailsFull(""); //pois o codigo era igual apenas sem o 'extraDetails', então caso não tenha é só passar um valor 'branco'
        }
        public string DisplayDetailsFull(string extraDetails)
        {
            StringBuilder sb = new();
            sb.Append($"{Id} {Name} \n{Description} \n{AmountInStock} item(s) in stock\n");

            sb.Append(extraDetails);

            if (IsBelowStockTreshold)
                sb.Append("\nSTOCK LOW!!");

            return sb.ToString();
        }



    }
}

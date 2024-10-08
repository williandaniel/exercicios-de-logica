using System;
using ExtraQuestion.Entities.Exceptions;
using System.Globalization;

namespace ExtraQuestion.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {

            if (string.IsNullOrWhiteSpace(name)) throw new ProductException("O nome do produto não pode ser vazio.");

            if (price < 0.0) throw new ProductException("O preço do produto não pode ser negativo.");
            
            if (quantity < 1) throw new ProductException("A quantidade do produto deve ser pelo menos 1."); 

            Name = name;
            Price = price;
            Quantity = quantity;
        }

        private double TotalAmount()
        {
            if (Quantity <= 10)
            {
                return Price * Quantity;
            }
            else if (Quantity <= 20)
            {
                return Price * Quantity * 0.90;
            }
            else if (Quantity <= 50)
            {
                return Price * Quantity * 0.80;
            }
            else
            {
                return Price * Quantity * 0.75;
            }
        }

        public override string ToString()
        {
            return Name
                + " - Valor Total: $ "
                + TotalAmount().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
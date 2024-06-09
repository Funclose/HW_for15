using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Polimorphism
{
    internal class Money
    {
        public int Dollar { get; set; }

        private int _coin;
        public int Coin
        {
            get { return _coin; }
            set
            {
                if (value >= 0 && value < 100)
                {
                    _coin = value;
                }
                else
                {
                    throw new ArgumentException("Coins should be between 0 and 99");
                }
            }
        }

        public Money(int dollar, int coin)
        {
            Dollar = dollar;
            Coin = coin;
        }

        public void Show()
        {
            Console.WriteLine($"Your money: {Dollar} dollars, {Coin} coins");
        }
    }

    internal class Product : Money
    {
        public string Name { get; set; }

        public Product(string name, int dollar, int coin) : base(dollar, coin)
        {
            Name = name;
        }

        public void MyDiscount(int dollar, int coin)
        {
            int totalCents = (Dollar * 100 + Coin) - (dollar * 100 + coin);
            if (totalCents < 0)
            {
                Console.WriteLine("Error: price can't be negative");
                return;
            }

            Dollar = totalCents / 100;
            Coin = totalCents % 100;
        }

        public void ShowProduct()
        {
            Console.WriteLine($"{Name}:");
            Show();
        }
    }
}

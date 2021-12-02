using System;

namespace Ucu.Poo.Defense
{
    public class PromoCode : IOfferItem
    {
        public string code { get; set; }
        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                if (value > 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.amount = value;
                }
            }
        }

        public PromoCode(string code, int amount)
        {
            if (amount > 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.code = code;
                this.SubTotal = amount;
            }
        }
    }
}
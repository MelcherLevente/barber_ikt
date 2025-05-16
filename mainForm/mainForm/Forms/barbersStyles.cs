using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainForm.Forms
{
    public class barbersStyles
    {
        private string name;
        private bool hairstyleLong;
        private bool hairstyleShort;
        private int priceLong;
        private int priceShort;

        public string Name { get => name; set => name = value; }
        public bool HairstyleLong { get => hairstyleLong; set => hairstyleLong = value; }
        public bool HairstyleShort { get => hairstyleShort; set => hairstyleShort = value; }
        public int PriceLong { get => priceLong; set => priceLong = value; }
        public int PriceShort { get => priceShort; set => priceShort = value; }

        public barbersStyles(string name, bool hairstyleLong, int priceLong, bool hairstyleShort, int priceShort)
        {
            this.Name = name;
            this.HairstyleLong = hairstyleLong;
            this.PriceLong = priceLong;
            this.HairstyleShort = hairstyleShort;
            this.PriceShort = priceShort;
        }

        public barbersStyles(string name, bool hairstyleShort, int priceShort)
        {
            this.Name = name;
            this.HairstyleLong = false;
            this.PriceLong = 0;
            this.HairstyleShort = hairstyleShort;
            this.PriceShort = priceShort;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainForm.Forms
{
    internal class barbersStyles
    {
        public string name;
        public bool hairstyleLong;
        public bool hairstyleShort;
        public int priceLong;
        public int priceShort;

        public barbersStyles(string name, bool hairstyleLong, int priceLong, bool hairstyleShort, int priceShort)
        {
            this.name = name;
            this.hairstyleLong = hairstyleLong;
            this.priceLong = priceLong;
            this.hairstyleShort = hairstyleShort;
            this.priceShort = priceShort;
        }

        public barbersStyles(string name, bool hairstyleShort, int priceShort)
        {
            this.name = name;
            this.hairstyleLong = false;
            this.priceLong = 0;
            this.hairstyleShort = hairstyleShort;
            this.priceShort = priceShort;
        }
    }
}

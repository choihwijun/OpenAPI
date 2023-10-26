using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 쇼핑_검색
{
    internal class Item
    {
        public string Name { get; }
        public string Link { get; }
        public string Maker { get; }
        public string Brand { get; }
        public string Image { get; }
        public int Lprice { get; }
        public int Hprice { get; }
        public Item (string name, string link, string maker, string brand, string image, int lprice, int hprice)
        {
            Name = name;
            Link = link;
            Maker = maker;
            Brand = brand;
            Image = image;
            Lprice = lprice;
            Hprice = hprice;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Item
    {
        private static List<Item> items = new List<Item>();
        public string itemName { get; set; }
        public int number { get; set; }
        public int inventoryNumber { get; set; }
        public double price { get; set; }
        public int count { get; set; }
        public string date { get; set; }

        public void save()
        {
            
            Console.WriteLine("Saved");
        }
        
    }
}

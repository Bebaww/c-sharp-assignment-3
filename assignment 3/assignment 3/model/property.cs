using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3
{
    internal class property
    {
       public int number { get; set; }  
        public string inventory_number{ get; set; }    
        public string item_name{ get; set; }   
        public int count { get; set; }
        public int price { get; set; }
 
        public void save()
        {
            Console.WriteLine($"number ={number}");
            Console.WriteLine($" inventory number ={inventory_number}");
            Console.WriteLine($"item name ={item_name}");
            Console.WriteLine($"count ={count}");
            Console.WriteLine($"price ={price}");
            int total_price = count * price;
            Console.WriteLine($"total price = {total_price}");

            Console.WriteLine("succesfully added");
        }

    }
}

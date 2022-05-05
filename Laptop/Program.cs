using System;

namespace Laptop
{
    internal class Laptop
    {
        string name;
        string produser;
        float price;

        public Laptop() : this("", "", 0)
        {
        }

        public Laptop(string name, string produser, float price)
        {
            this.name = name;
            this.produser = produser;
            this.price = price;
        }
        public string Name
        {
            get; set;            
        }
        public string Produser
        {
           get; set;
        }

        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                if(value > 0)   
                    price = value;
                else
                    price = 0;  
            }
        }
    }
    class Shop
    {
        string name_shop = "NeoLogic";
        Laptop[] ar;

        public int ArrSize
            { 
            get
            { 
                return ar.Length;
            } 
        }   

        public Shop(params Laptop[] name)
        {    
            ar = new Laptop[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
                ar[i] = name[i];
            }
        }

        public Shop(int size)
        {
            ar = new Laptop[size];   
        }

        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 || index < ar.Length)
                {
                    return ar[index];
                }
                else
                {
                    return ar[0];
                }
            }
            set
            {
                ar[index] = value;
            }

        }
        static void Main(string[] args)
        { 
            Laptop obj = new Laptop("Aspire 5", "Acer", 32600);
            Laptop obj1 = new Laptop("Inspiron 17", "Dell", 32600);
            Laptop obj2 = new Laptop("Pavilion", "HP", 25999);
            obj.Name = "Aspire 5";
            obj.Produser = "Acer";
            obj.Price = 32600;
            obj1.Name = "Inspiron 17";
            obj1.Produser = "Dell";
            obj1.Price = 31700;
            obj2.Name = "Pavilion";
            obj2.Produser = "HP";
            obj2.Price = 25999;

            Shop s = new Shop(obj, obj1, obj2);
            Console.WriteLine(s.name_shop + "\n");
            
            for (int i = 0; i < s.ArrSize; i++) 
            Console.Write("Name: " + s[i].Name + "  Produser: " + s[i].Produser + "  Price: " + s[i].Price + "\n");  
            Console.WriteLine();   
        }
    }
}

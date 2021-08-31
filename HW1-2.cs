using System;
using System.Collections.Generic;
namespace HW1by003
{
    class Program
    {
        static void Main(string[] args)
        {
            Address jameaddress = new Address("131/75 พุทธมณฑล", "นครปฐม", "10180");
            ShoppingCart allshoppingJame = new ShoppingCart(jameaddress);
            User jame = new User("jame watson", "jame@gmail.com", allshoppingJame);
            Tshirt tshirt1 = new Tshirt("L", "Red", 500f, "Image1");
            Tshirt tshirt2 = new Tshirt("M", "Black", 750f, "Image2");
            Tshirt tshirt3 = new Tshirt("S", "Blue", 625f, "Image3");
            jame.ShoppingCart.addTshirt(tshirt1);
            jame.ShoppingCart.addTshirt(tshirt2);
            jame.ShoppingCart.addTshirt(tshirt3);
            jame.ShoppingCart.TotalCost();
        }
    }
    class Tshirt
    {
        public string size;
        public string color;
        public float price;
        public string image;
        public Tshirt(string valueSize, string valueColor, float valueprice, string valueImage)
        {
            size = valueSize;
            color = valueColor;
            price = valueprice;
            image = valueImage;
        }
    }
    class User
    {
        public string name;
        public string email;
        public ShoppingCart ShoppingCart;
        public User(string valueName, string valueEmail, ShoppingCart valueShoppingCart)
        {
            name = valueName;
            email = valueEmail;
            ShoppingCart = valueShoppingCart;
        }
    }
    class ShoppingCart
    {
        public float Totalcost = 0;
        public Address address;
        private List<Tshirt> orderTShirt;
        public ShoppingCart(Address valueAddress)
        {
            orderTShirt = new List<Tshirt>();
            address = valueAddress;
        }
        public void addTshirt(Tshirt tShirt)
        {
            orderTShirt.Add(tShirt);
        }
        public void TotalCost()
        {
            foreach (Tshirt tshirt in orderTShirt)
            {
                Totalcost += tshirt.price;
            }
            Console.WriteLine(Totalcost);
        }
    }
    class Address
    {
        public string street;
        public string city;
        public string zipCode;

        public Address(string valuestreet, string valuecity, string valuezipCode)
        {
            street = valuestreet;
            city = valuecity;
            zipCode = valuezipCode;
        }
    }
}

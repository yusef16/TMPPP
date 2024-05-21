using System;
using System.Net;

namespace Tmpp
{
    //Strategy
    public interface IDiscountStrategy
    {
        public int ApplyDiscount(int price);
    }

    public class WomenDiscountStrategy : IDiscountStrategy
    {
        public int ApplyDiscount(int price)
        {
            return (int)Math.Round(price * 0.85); // Aplică o reducere de 15%
        }
    }


    public class NoDiscountStrategy : IDiscountStrategy
    {
        public int ApplyDiscount(int price)
        {
            return price; // Nicio reducere
        }
    }


    /*public class Programl
    {
        public static void Main(string[] args)
        {
            double basePrice = 100.0;

            // Crearea unui abonament pentru o femeie cu reducere
            Membership womenMembership = new Membership(new WomenDiscountStrategy());
            double womenPrice = womenMembership.GetPrice(basePrice);
            Console.WriteLine($"Price for women: {womenPrice}");

            // Crearea unui abonament fără reducere
            Membership noDiscountMembership = new Membership(new NoDiscountStrategy());
            double noDiscountPrice = noDiscountMembership.GetPrice(basePrice);
            Console.WriteLine($"Price without discount: {noDiscountPrice}");
        }
    }*/



}
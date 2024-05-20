using System;
using System.Net;

namespace Tmpp
{

    public interface IDiscountStrategy
    {
        double ApplyDiscount(double price);
    }

    public class WomenDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(double price)
        {
            return price * 0.85; // Aplică o reducere de 15%
        }
    }


    public class NoDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(double price)
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
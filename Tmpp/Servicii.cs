using System;

namespace Tmpp
{
   /* public interface IServiciu
    {
        decimal GetPrice(decimal price);
    }

    class Abonament : IServiciu
    {
        public decimal GetPrice(decimal price)
        {
            return price;
        }
    }

    abstract class AbonamentDecorator : IServiciu
    {
        protected IServiciu _serviciu;

        public AbonamentDecorator(IServiciu serviciu)
        {
            _serviciu = serviciu;
        }

        public abstract decimal GetPrice(decimal price);
    }

    class Antrenor : AbonamentDecorator
    {
        private decimal _antrenorFee = 500; // example fee for the trainer

        public Antrenor(IServiciu serviciu) : base(serviciu)
        {
        }

        public override decimal GetPrice(decimal price)
        {
            var basePrice = _serviciu.GetPrice(price);
            return basePrice + _antrenorFee;
        }
    }




    class ProgramNutritie : AbonamentDecorator
    {
        private decimal _nutritie = 500; // example fee for the trainer

        public ProgramNutritie(IServiciu serviciu) : base(serviciu)
        {
        }

        public override decimal GetPrice(decimal price)
        {
            var basePrice = _serviciu.GetPrice(price);
            return basePrice + _nutritie;
        }
    }


    // Example of usage
    class Program
    {
        static void Main()
        {
            IServiciu serviciu = new Abonament();
            IServiciu serviciuCuAntrenor = new Antrenor(serviciu);
            IServiciu nutritie = new ProgramNutritie(serviciu);

            decimal price = serviciuCuAntrenor.GetPrice(2000);
            decimal pricen = nutritie.GetPrice(2000);
            Console.WriteLine($"Total price with trainer: {price}");
        }
    }*/
}

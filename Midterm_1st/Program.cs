//Part 1

namespace Midterm_1st
{
    class Program
    {
        public class Car
        {
            public string Brand { get; set; }
            public int Price { get; set; }

            public Car(string sBrand, int sPrice)
            {
                Brand = sBrand;
                Price = sPrice;
            }
        }
        static void Main(string[] args)
        {
            Car[] std = new Car[10];

            std[0] = new Car("Toyota Vios", 686000);
            std[1] = new Car("Toyota Hilux", 843000);
            std[2] = new Car("Toyota Wigo", 573000);
            std[3] = new Car("Toyota Innova", 1191000);
            std[4] = new Car("Toyota Fortuner", 1671000);
            std[5] = new Car("Toyota Rush", 1012000);
            std[6] = new Car("Mitsubishi Expander", 1050000);
            std[7] = new Car("Toyota Hiace", 1166000);
            std[8] = new Car("Mitsubishi L300", 813000);
            std[9] = new Car("Ford Ranger", 1155000);

            var res = from c in std
                      where c.Price >= 1000000
                      select c;

            foreach (var c in res)
            {
                if (c.Price > 1200000)
                {
                    Console.WriteLine(c.Brand + " this belongs to class A car.");
                }
                else
                {
                    Console.WriteLine(c.Brand + " this belongs to class B car.");
                }
            }

        }
    }
}
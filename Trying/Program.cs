using System;

namespace Trying
{
    class Program
    {
        static void Main(string[] args)
        {
            Product SiyahMont = new Product()
            {
                Id = 1,
                Name = "Siyah Mont",
                Info = "Slim Fit",
                Cost = 255
            };

            Product KirmiziMont = new Product()
            {
                Id = 2,
                Name = "Kirmizi Mont",
                Info = "Bold",
                Cost = 310
            };
            Product YesilMont = new Product()
            {
                Id = 2,
                Name = "Yesil Mont",
                Info = "Polyester",
                Cost = 410
            };

            ProductManager productManager = new ProductManager();
            productManager.AddBasket(YesilMont, KirmiziMont);
            Console.WriteLine("----------------------------");
            productManager.Buy(KirmiziMont);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Trying
{
    class ProductManager
    {
        int x = 0;
        public void AddBasket(Product product, Product product2)
        {
            Console.WriteLine(product.Name + " Sepete Eklendi");
            Console.WriteLine(product2.Name + " Sepete Eklendi");
            product.inBasket = true;
            product2.inBasket = true;

            x += product.Cost + product2.Cost;
            Console.WriteLine("Sepetinizdeki ürünlerin toplam tutarı: " + x);
        }

        public void AddBasket(Product product)
        {
            Console.WriteLine(product.Name + " Sepete Eklendi");
            product.inBasket = true;

            x += product.Cost;
            Console.WriteLine("Sepetinizdeki ürünlerin toplam tutarı: " + x);
        }

        public void Buy(Product product)
        {
            if (product.inBasket)
            {
                Console.WriteLine(product.Name + " ürününü satın alma işleminiz onaylandı.");
            }
            else
            {
                Console.WriteLine(product.Name +" ürünü satın alabilmek için lütfen sepete ekleyiniz");
            }
        }   
    }
}

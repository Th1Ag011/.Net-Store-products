using System;
using System.Collections.Generic;
using System.Linq;

namespace Store
{
    internal class Program
    {
        static void Start()
        {
            
            Cart cart = new Cart();
            Console.WriteLine("Olá");
            int Put = 0;


            while (Put != 3)
            {
                Console.WriteLine("Gostaria de Adicionar ou deletar algum produto? Sendo 1 para adicionar, 2 para deletar e 3 para sair ");

                Put = int.Parse(Console.ReadLine());

                switch (Put)
                {
                    case 1:                      
                        Features(cart);
                        break;

                    case 2:
                        Delete(cart);
                        break;


                }

            }

            Console.WriteLine("Tchau até mais");
            Console.ReadKey();

        }




    static void Main(string[] args)
        {
            Start();

        }

        public static void Features(Cart cart2)
        {


            Console.WriteLine("Você esta adicionando um produto");
            Console.WriteLine("Qual será a categoria do seu produto?");
            string type = Console.ReadLine();

            Console.WriteLine("Qualo nome do seu produto?");
            string name = Console.ReadLine();

            Console.WriteLine("Qual o valor do seu produto?");
            int price = int.Parse(Console.ReadLine());

            var products = new Products(type, price, name);

            cart2.Add(products);

            Console.WriteLine("Produto adicionado!");


            if (cart2.Products.Any())
            {

                Console.WriteLine("Gostaria de vizualizar seus produtos ? S, N");
                string Choice = Console.ReadLine();
                string upperChoice = Choice.ToUpper();


                if (upperChoice == "S")
                {
                    Console.WriteLine($"Você possui {cart2.Products.Count} produto no seu carrinho");
                    ProductFeatures(cart2.Products);
                    Console.WriteLine("Voltando ao inicio..\n");
                }
                else
                {
                    Console.WriteLine("Voltando ao inicio..\n");
                   
                }



            }
            else
            {
                Console.WriteLine("Você não possui produtos adicionados");
            }


        }

        public static void ProductFeatures(List<Products> products)
        {
            foreach (var productus in products)
            {
                Console.WriteLine($"O produto {productus.Name} da categoria {productus.Type} do preço de {productus.Price.ToString("C")};");
            }


        }

        public static void Delete(Cart cart2)
        {
            if (cart2.Products.Any())
            {
                Console.WriteLine("Você está Deletando um produto");

                Console.WriteLine("Você tem no seu carrinho");
                ProductFeatures(cart2.Products);


                Console.WriteLine("Qual o nome do produto que deseja deletar?");
                string name = Console.ReadLine();

                var removeproduct = cart2.Products.FirstOrDefault(productname => productname.Name == name);

                cart2.Delete(removeproduct);

                Console.WriteLine("Produto deletado !!!");

                Console.WriteLine("Voltando ao inicio..\n");

            }
            else
            {
                Console.WriteLine("Você não tem produtos adicionados.");
                Console.WriteLine("Voltando ao inicio..\n");

            }



        }


    }


}


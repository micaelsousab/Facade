using ProjetoFacade.Facade;
using System;

namespace ProjetoFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            var restauranteFacade = new RestauranteFacade();

            Console.WriteLine("-------------------------- Pedidos de Pizza --------------------------");
            restauranteFacade.BuscarPizzaNormal();
            restauranteFacade.BuscarPizzaVegana();

            Console.WriteLine("-------------------------- Pedidos de Pão --------------------------");
            restauranteFacade.BuscarPaoDeAlho();
            restauranteFacade.BuscarPaoDeAlhoComQueijo();

            Console.ReadKey();
        }
    }
}

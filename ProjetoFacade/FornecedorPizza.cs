using System;
using ProjetoFacade.Interface;

namespace ProjetoFacade
{
    class FornecedorPizza : IPizza
    {
        public void BuscarPizzaNormal()
        {
            ObterCoberturaNaoVegana();
            Console.WriteLine("Buscando Pizza Normal");
        }

        public void BuscarPizzaVegana()
        {
            Console.WriteLine("Buscando Pizza Vegana");
        }

        private void ObterCoberturaNaoVegana()
        {
            Console.WriteLine("Obter Todas Coberturas de Pizza Não Vegetais");
        }
    }
}

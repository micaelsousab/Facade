using ProjetoFacade.Interface;
using System;

namespace ProjetoFacade
{
    public class FornecedorPao : IPao
    {
        public void BuscarPaoDeAlho()
        {
            Console.WriteLine("Buscar Pão de Alho");
        }

        public void BuscarPaoDeAlhoComQueijo()
        {
            ObterQueijo();
            Console.WriteLine("Buscar Pão De Alho Com Queijo");
        }

        private void ObterQueijo()
        {
            Console.WriteLine("Buscando Queijo");
        }
    }
}

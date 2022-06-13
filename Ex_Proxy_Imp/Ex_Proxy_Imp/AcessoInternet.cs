using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Proxy_Imp
{
    public class AcessoInternet : IAcessoInternet
    {
        public void AcessarPagina(string url)
        {
            Console.WriteLine($"Acessando página: {url}");
        }
    }
}

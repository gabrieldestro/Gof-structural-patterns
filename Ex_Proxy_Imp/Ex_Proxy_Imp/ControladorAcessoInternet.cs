using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Proxy_Imp
{
    internal class ControladorAcessoInternet : IAcessoInternet
    {
        private IAcessoInternet acessoInternet;
        private List<string> paginasPermitidas = new List<string>();

        public ControladorAcessoInternet()
        {
            paginasPermitidas.Add("https://portaldoaluno.com");
            paginasPermitidas.Add("https://minhasnotas.com");
            paginasPermitidas.Add("https://materiadaprova.com");

            acessoInternet = new AcessoInternet();
        }

        public void AcessarPagina(string url)
        {
            if (paginasPermitidas.Contains(url))
            {
                acessoInternet.AcessarPagina(url);
            }
            else
            {
                Console.WriteLine($"O aluno não tem permissão para acessar essa página!");
            }
        }
    }
}

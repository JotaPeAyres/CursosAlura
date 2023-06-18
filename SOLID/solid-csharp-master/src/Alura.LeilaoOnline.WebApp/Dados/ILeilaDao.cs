using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaDao
    {
        IEnumerable<Categoria> BuscarCategorias();

        IEnumerable<Leilao> BuscarLeiloes();

        Leilao BuscarPorId(int id);

        void Incluir(Leilao leilao);

        void Alterar(Leilao leilao);

        public void Excluir(Leilao leilao);
    }
}

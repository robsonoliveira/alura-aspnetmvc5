using alura_aspnetmvc5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace alura_aspnetmvc5.DAO
{
    public class CategoriasDAO
    {
        public void Adiciona(CategoriaDoProduto categoria)
        {
            // excluido para nao ter que acessar o BD
        }

        public IList<CategoriaDoProduto> Lista()
        {
            return new List<CategoriaDoProduto>() {
            new CategoriaDoProduto() {Id=1,Nome="Categoria 1",Descricao="Descricao Categoria 1"},
            new CategoriaDoProduto() {Id=2,Nome="Categoria 2",Descricao="Descricao Categoria 2"},
            new CategoriaDoProduto() {Id=3,Nome="Categoria 3",Descricao="Descricao Categoria 3"},
            new CategoriaDoProduto() {Id=4,Nome="Categoria 4",Descricao="Descricao Categoria 4"}
            };
        }

        public CategoriaDoProduto BuscaPorId(int id)
        {
            return
              new CategoriaDoProduto() { Id = 4, Nome = "Produto 4", Descricao = "Descricao Produto 4" };
        }

        public void Atualiza(CategoriaDoProduto categoria)
        {
        }
    }
}
using alura_aspnetmvc5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace alura_aspnetmvc5.DAO
{
    public class ProdutosDAO
    {
        public void Adiciona(Produto produto)
        {
           
        }

        public IList<Produto> Lista()
        {
            return new List<Produto>() {
            new Produto() {Id=1,Nome="Produto 1",Descricao="Descricao Produto 1"},
            new Produto() {Id=2,Nome="Produto 2",Descricao="Descricao Produto 2"},
            new Produto() {Id=3,Nome="Produto 3",Descricao="Descricao Produto 3"},
            new Produto() {Id=4,Nome="Produto 4",Descricao="Descricao Produto 4"}
            };
        }

        public Produto BuscaPorId(int id)
        {

            return
              new Produto() { Id = 4, Nome = "Produto 4", Descricao = "Descricao Produto 4" };
        }

        public void Atualiza(Produto produto)
        {
           
        }
    }
}
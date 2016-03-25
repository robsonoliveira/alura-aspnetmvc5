using alura_aspnetmvc5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace alura_aspnetmvc5.DAO
{
    public class UsuariosDAO
    {
        public void Adiciona(Usuario usuario)
        {
           // retirando acesso ao BD para o código de exemplo
        }

        public IList<Usuario> Lista()
        {
            return new List<Usuario>() {
            new Usuario() { Id=1,Nome="Robson",Senha="1234"},
                new Usuario(){ Id=2,Nome="Mãe",Senha="abcd"},
                new Usuario(){ Id=3,Nome="Jéssica",Senha="11223344"}};
        }

        public Usuario BuscaPorId(int id)
        {
            return new Usuario()
            {
                Id = 1,
                Nome = "Robson",
                Senha = "1234"
            };
            }

        public void Atualiza(Usuario usuario)
        {
            
        }

        public Usuario Busca(string login, string senha)
        {
            return new Usuario()
            {
                Id = 1,
                Nome = "Robson",
                Senha = "1234"
            };
        }
    }
}
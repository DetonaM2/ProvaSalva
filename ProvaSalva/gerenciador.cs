using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProvaSalva.Banco;

namespace ProvaSalva
{
    public class Gerenciar
    {

        private static List<Name> Names = new List<Name>();

        public static List<Name> Inicializar()
        {
            Dao dao = new Dao("func");

            if (dao.Status)
            {
                Names = dao.GetNames(); // carregar a lista com dados oriundos da tabela
                if (dao.Status)
                {
                    return Names; // se o comando foi executado com sucesso, retornar a lista carregada
                }
            }

            return null; // retorna nulo
        }



        public static List<Name> GetNames()
        {
            return Names;
        }




        public static string Cadastrar(Name n)
        {
            Dao dao = new Dao("func");

            // verificar se conexão com BD foi estabelecida
            if (dao.Status)
            {
                // tentar inserir livro da tabela 'livros'
                dao.Inserir(n);

            }

            return dao.MSG;
        }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProvaSalva.Banco
{
    class Dao
    {
        public bool Status { get; set; }
        public string Tabela { get; set; }
        public BancoDB Db { get; set; }
        public string MSG { get; set; }

        public Dao(string tabela)
        {
            try
            {
                Tabela = tabela;
                Db = new BancoDB();
                Status = true;
                MSG = "Conexão Estabelecida";
            }
            catch (Exception e)
            {
                Status = false;
                MSG = e.Message;
            }
        }

        public void Inserir(Name C)
        {
            try
            {
                string SQL = "INSERT INTO " + Tabela + "(Nome, Salário) VALUES ('" + C.Nome + "', '" + float.Parse(C.Salario) + "')";
                Db.SQLCommand(SQL);
                Status = true;
                MSG = "Cadastro feito com Sucesso!!";
            }
            catch (Exception e)
            {
                Status = false;
                MSG = e.Message;
            }
        }
        public void Remover(Name C)
        {
            try
            {
                string SQL = "DELETE FROM " + Tabela + " WHERE Código=" + C.Id;
                Db.SQLCommand(SQL);
                Status = true;
                MSG = "Cadastro feito com Sucesso!!";
            }
            catch (Exception e)
            {
                Status = false;
                MSG = e.Message;
            }
        }

        public List<Name> GetNames()
        {
            List<Name> Names = new List<Name>();

            try
            {

                string SQL = "SELECT * FROM " + Tabela;
                DataTable dt = Db.SQLQuery(SQL);
                Status = true;
                int linhas = dt.Rows.Count;

                if (linhas > 0)
                {

                    for (int i = 0; i < linhas; i++)
                    {

                        Name n = new Name();

                        n.Id = int.Parse(dt.Rows[i]["Código"].ToString());
                        n.Nome = dt.Rows[i]["Nome"].ToString();
                        n.Salario = dt.Rows[i]["Salário"].ToString();

                        Names.Add(n);

                    }

                    MSG = "Nomes carregados com sucesso";
                }

            }
            catch (Exception ex)
            {
                Status = false;
                MSG = "Erro ao executar busca:\n" + ex.Message;
            }


            return Names;
        }
    }
}

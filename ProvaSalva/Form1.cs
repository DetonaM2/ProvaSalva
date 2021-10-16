using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProvaSalva.Banco;

namespace ProvaSalva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarGrid();
        }

        public void InicializarGrid()
        {
            dataGridView1.Rows.Clear();

            if (Gerenciar.Inicializar() != null)
            {
                foreach (Name n in Gerenciar.GetNames())
                {
                    dataGridView1.Rows.Add(n.Id, n.Nome, String.Format("{0:0.00}",decimal.Parse(n.Salario)));
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        

        private void Adicionar_Click(object sender, EventArgs e)
        {
            if (nom.Text.Equals("") || sal.Text.Equals(""))
            {
                MessageBox.Show("Não deixe em Branco!!!","Tenha mais atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Name c = new Name();
                c.Nome = nom.Text;
                c.Salario = sal.Text;
                
                Dao dao = new Dao("func");


                if (dao.Status)
                {
                    dao.Inserir(c);
                    if(dao.Status)
                    {
                        nom.Clear();
                        sal.Text="0,00";
                        InicializarGrid();

                    }
                    else
                    {
                        MessageBox.Show(dao.MSG, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    throw new Exception(dao.MSG);
                }

            }
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                Name c = new Name();
                
                for (int i = 0; i < selectedRowCount; i++)
                {
                    Dao dao = new Dao("func");
                    c.Id = int.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                    dao.Remover(c);
                }
                InicializarGrid();

            }
        }
    }
}

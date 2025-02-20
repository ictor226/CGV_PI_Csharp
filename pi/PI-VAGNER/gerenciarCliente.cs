using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_VAGNER
{
    public partial class gerenciarCliente : Form
    {
        public gerenciarCliente()
        {
            InitializeComponent();
        }

        private void buttonPesquisarcliente_Click(object sender, EventArgs e)
        {
            //Defina sua string de conexão com o banco
            string conectionString = "Server=localhost; Port=3306; Database=bd_cgv; Uid=root; Pwd=;";

            try
            {

                using (MySqlConnection consulta = new MySqlConnection(conectionString))
                {

                    consulta.Open();
                    string listagem = "SELECT id_user , id_user, email, senha FROM login";

                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        dgvCliente.DataSource = dadosClientes;
                    }



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os clientes " + ex.Message);
            }
        }
    }
}

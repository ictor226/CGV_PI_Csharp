using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            // Defina sua string de conexão com o banco
            string conectionString = "Server=localhost; Port=3306; Database=bd_cgv; Uid=root; Pwd=;";

            try
            {
                using (MySqlConnection consulta = new MySqlConnection(conectionString))
                {
                    consulta.Open();
                    // Corrigimos a consulta para usar os nomes corretos das colunas
                    string listagem = "SELECT id, email, senha, id_pessoa FROM login";

                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        // Criando um DataTable para armazenar os dados e vinculá-los ao DataGridView
                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        // Atribuindo o DataTable à propriedade DataSource do DataGridView
                        dgvCliente.DataSource = dadosClientes;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os clientes: " + ex.Message);
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aqui você pode adicionar a lógica para interagir com o DataGridView, se necessário
        }

        private void buttonRemoverClientes_Click(object sender, EventArgs e)
        {
            // A lógica para remover clientes deve ser implementada aqui
        }
    }
}

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
            //Defina sua string de conexão com o banco
            string conectionString = "Server=srv816.hstgr.io; Port=3306; Database=u149946689_bd_cgv; Uid=u149946689_victor; Pwd=CGV_competition@123";
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
            if (dgvCliente.SelectedRows.Count > 0)
            {
                // Pega o ID do cliente da linha selecionada
                int produtoID = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells["id"].Value);
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //Defina sua string de conexão com o banco
                    string connectionString = "Server=srv816.hstgr.io; Port=3306; Database=u149946689_bd_cgv; Uid=u149946689_victor; Pwd=CGV_competition@123";

                    try
                    {
                        // Cria uma conexão com o banco de dados Mysql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            // Abre a conexão 
                            consulta.Open();

                            // Consulta SQL para excluir o cliente na tabela 'login'
                            string deleteQuery = "DELETE FROM login WHERE id = @id";  // Certifique-se de que a tabela é 'login' e não 'tb_user'

                            using (MySqlCommand cmd = new MySqlCommand(deleteQuery, consulta))
                            {
                                // Adiciona o parâmetro com o ID do cliente
                                cmd.Parameters.AddWithValue("@id", produtoID);

                                // Executa a consulta e verifica se a exclusão foi bem-sucedida
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cliente excluído com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o cliente.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o cliente: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente para excluir.");
            }
        }

    }
}
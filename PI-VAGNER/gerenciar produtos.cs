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
    public partial class gerenciar_produtos : Form
    {
        public gerenciar_produtos()
        {
            InitializeComponent();
        }

        private void buttonPesquisarClientes_Click(object sender, EventArgs e)
        {
            //Defina sua string de conexão com o banco
            string conectionString = "Server=localhost; Port=3306; Database=bd_cgv; Uid=root; Pwd=;";

            try
            {

                using (MySqlConnection consulta = new MySqlConnection(conectionString))
                {

                    consulta.Open();
                    string listagem = "SELECT id_produto , nome_item, preco_item, parcelamento, versao, descricao, ano_lancamento, quantidade, img FROM cadastro_produto";

                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        dgvProduto.DataSource = dadosClientes;
                    }



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os clientes " + ex.Message);
            }
        }

        private void buttonRemoverClientes_Click(object sender, EventArgs e)
        {
            if (dgvProduto.SelectedRows.Count > 0)
            {

                int produtoID = Convert.ToInt32(dgvProduto.SelectedRows[0].Cells["id_produto"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este produto? ", "confirmar excluxão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {


                    string conectionString = "Server=localhost; Port=3306; Database=bd_cgv; Uid=root; Pwd=;";

                    try
                    {

                        using (MySqlConnection consulta = new MySqlConnection(conectionString))
                        {

                            consulta.Open();
                            string listagem = "DELETE FROM cadastro_produto WHERE id_produto = @id_produto";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {

                                cmd.Parameters.AddWithValue("id_produto", produtoID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("produto excluido");
                                }
                                else
                                {
                                    MessageBox.Show("falha ao excluir o produto");
                                }

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao listar os produtos " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("por favor selecione um produto para excluir");
                }

            }

        }
    }
}

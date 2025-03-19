using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.Compiler;
using MySql.Data.MySqlClient;
namespace PI_VAGNER
{
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img_produto.Image =Image.FromFile(openFileDialog.FileName);

                img_produto.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string conexaoString = "Server=localhost; Port=3306; Database=bd_cgv; Uid=root; Pwd=;";

            string query = "INSERT INTO cadastro_produto (nome_item, preco_item, parcelamento, versao, descricao, ano_lancamento, quantidade, img_produto)  VALUES " +
                "(@nome_item, @preco_item, @parcelamento, @versao, @descricao, @ano_lancamento, @quantidade, @img_produto)";


            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    img_produto.Image.Save(ms, img_produto.Image.RawFormat);
                    byte[] imageBytes = ms.ToArray();
                    conexao.Close();



                    //Abre a conexão
                    conexao.Open();
                    //Crie o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        //Adicionar os parâmentros com os valores dos TextBox
                        comando.Parameters.AddWithValue("@nome_item", nome_item.Text);
                        comando.Parameters.AddWithValue("@preco_item", preco_item.Text);
                        comando.Parameters.AddWithValue("@parcelamento", parcelamento.Text);
                        comando.Parameters.AddWithValue("@versao", versao.Text);
                        comando.Parameters.AddWithValue("@descricao", descricao.Text);
                        comando.Parameters.AddWithValue("@ano_lancamento", ano_lancamento.Text);
                        comando.Parameters.AddWithValue("@quantidade", quantidade.Text);
                        comando.Parameters.AddWithValue("@img_produto", imageBytes);


                        // Executa o comando de inserção
                        comando.ExecuteNonQuery();

                        nome_item.Text = "";
                        preco_item.Text = "";
                        parcelamento.Text = "";
                        versao.Text = "";
                        descricao.Text = "";
                        ano_lancamento.Text = "";
                        quantidade.Text = "";
                        

                    }
                }
                catch (Exception ex)
                {
                    // em caso de erro, exiba menssagem do erro
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void img_produto_Click(object sender, EventArgs e)
        {

        }

        private void descricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

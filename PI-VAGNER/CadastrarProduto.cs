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
                img_produto1.Image = Image.FromFile(openFileDialog.FileName);

                img_produto1.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string conexaoString = "Server=localhost; Port=3306; Database=bd_cgv; Uid=root; Pwd=;";

            // Comando SQL com os parâmetros para as imagens
            string query = "INSERT INTO cadastro_produto (nome_item, preco_item, parcelamento, versao, descricao, ano_lancamento, quantidade, img_produto1, img_produto2, img_produto3) VALUES " +
                   "(@nome_item, @preco_item, @parcelamento, @versao, @descricao, @ano_lancamento, @quantidade, @img_produto1, @img_produto2, @img_produto3)";

            // Abrindo a conexão
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    // Convertendo as imagens para byte[] antes de abrir a conexão
                    MemoryStream ms1 = new MemoryStream();
                    img_produto1.Image.Save(ms1, img_produto1.Image.RawFormat);
                    byte[] imageBytes1 = ms1.ToArray();

                    MemoryStream ms2 = new MemoryStream();
                    img_produto2.Image.Save(ms2, img_produto2.Image.RawFormat);
                    byte[] imageBytes2 = ms2.ToArray();

                    MemoryStream ms3 = new MemoryStream();
                    img_produto3.Image.Save(ms3, img_produto3.Image.RawFormat);
                    byte[] imageBytes3 = ms3.ToArray();





                    byte[] descricaoBytes = Encoding.UTF8.GetBytes(descricao.Text);



                    // Abrindo a conexão
                    conexao.Open();

                    // Criando o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        // Adicionando os parâmetros com os valores dos campos de texto e imagens
                        comando.Parameters.AddWithValue("@nome_item", nome_item.Text);
                        comando.Parameters.AddWithValue("@preco_item", preco_item1.Text);
                        comando.Parameters.AddWithValue("@parcelamento", parcelamento.Text);
                        comando.Parameters.AddWithValue("@versao", versao.Text);
                        comando.Parameters.AddWithValue("@descricao", descricaoBytes);
                        comando.Parameters.AddWithValue("@ano_lancamento", ano_lancamento.Text);
                        comando.Parameters.AddWithValue("@quantidade", quantidade.Text);
                        comando.Parameters.AddWithValue("@img_produto1", imageBytes1);
                        comando.Parameters.AddWithValue("@img_produto2", imageBytes2);
                        comando.Parameters.AddWithValue("@img_produto3", imageBytes3);

                        // Executando o comando de inserção
                        comando.ExecuteNonQuery();

                        // Limpar os campos após salvar
                        nome_item.Text = "";
                        preco_item1.Text = "";
                        parcelamento.Text = "";
                        versao.Text = "";
                        descricao.Text = "";
                        ano_lancamento.Text = "";
                        quantidade.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    // Exibindo erro em caso de falha
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

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img_produto2.Image = Image.FromFile(openFileDialog.FileName);

                img_produto2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img_produto3.Image = Image.FromFile(openFileDialog.FileName);

                img_produto3.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void preco_item_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

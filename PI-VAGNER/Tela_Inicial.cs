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
    public partial class Tela_Inicial : Form
    {
        bool VerSenhatx = false;
        private string usuarioCorreto = "admin";
        private string senhaCorreta = "123456";
         
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            textBox_usuario.Text = "";
            textBox_senha.Text = "";
            textBox_senha.Focus();
        }

       private bool VerSenhatxt = true;  // Inicializa como true para a senha começar oculta.

private void ButtonSenha_Click(object sender, EventArgs e)
{
    if (VerSenhatxt) // Se a senha estiver oculta, queremos mostrar.
    {
        textBox_senha.UseSystemPasswordChar = false; // Mostra a senha
        VerSenhatxt = false;  // Agora a senha está visível.
        button_exibirSenha.Text = "Ocultar Senha"; // Altera o texto do botão
    }
    else // Se a senha estiver visível, queremos ocultá-la.
    {
        textBox_senha.UseSystemPasswordChar = true; // Oculta a senha
        VerSenhatxt = true; // Agora a senha está oculta.
        button_exibirSenha.Text = "Mostrar Senha"; // Altera o texto do botão
    }
}


        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBox_usuario.Text;
            string senha = textBox_senha.Text;

            if (usuario == usuarioCorreto && senha == senhaCorreta)
            {
                label_mensagem.Text = "Bem-vindo, administrador!";
                label_mensagem.ForeColor = Color.Green;
                menu form = new menu();
                form.ShowDialog();
            }
            else
            {
                label_mensagem.Text = "Usuário ou senha ínvalida";
                label_mensagem.ForeColor = Color.Red;
                textBox_usuario.Text = "";
                textBox_senha.Text = "";
                textBox_usuario.Focus();
            }
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

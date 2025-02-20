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
    public partial class Form1 : Form
    {
        bool VerSenhatxt = false;
        private string usuarioCorreto = "admin";
        private string senhaCorreta = "123456";
         
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "";
            textBoxSenha.Text = "";
            textBoxSenha.Focus();
        }

        private void ButtonSenha_Click(object sender, EventArgs e)
        {
            if (VerSenhatxt == false) 
            {
                textBoxSenha.PasswordChar = '\0';
                VerSenhatxt = false;
                ButtonSenha.Text = " Ocultar Senha";
            }
            else 
            {
                textBoxSenha.PasswordChar = '*';
                VerSenhatxt = true;
                ButtonSenha.Text = "Mostrar senha";
            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if(usuario == usuarioCorreto && senha == senhaCorreta)
            {
                labelM.Text = "Login bem-sucedido";
                labelM.ForeColor = Color.Green;
                menu form = new menu();
                form.ShowDialog();
            }
            else
            {
                labelM.Text = "Usuario ou Senha Invalida";
                labelM.ForeColor = Color.Red;
                textBoxUsuario.Text = "";
                textBoxSenha.Text = "";
                textBoxUsuario.Focus();
            }
        }
    }
}

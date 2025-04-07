using System;
using System.Windows.Forms;

namespace PI_VAGNER
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            gerenciar_produtos form = new gerenciar_produtos();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gerenciarCliente form = new gerenciarCliente(); 
            form.ShowDialog();
        }
    }
}

namespace PI_VAGNER
{
    partial class gerenciarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.buttonRemoverClientes = new System.Windows.Forms.Button();
            this.buttonPesquisarcliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(12, 12);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(500, 410);
            this.dgvCliente.TabIndex = 1;
            // 
            // buttonRemoverClientes
            // 
            this.buttonRemoverClientes.Location = new System.Drawing.Point(582, 180);
            this.buttonRemoverClientes.Name = "buttonRemoverClientes";
            this.buttonRemoverClientes.Size = new System.Drawing.Size(153, 46);
            this.buttonRemoverClientes.TabIndex = 4;
            this.buttonRemoverClientes.Text = "Remover cliente";
            this.buttonRemoverClientes.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisarcliente
            // 
            this.buttonPesquisarcliente.Location = new System.Drawing.Point(582, 88);
            this.buttonPesquisarcliente.Name = "buttonPesquisarcliente";
            this.buttonPesquisarcliente.Size = new System.Drawing.Size(153, 46);
            this.buttonPesquisarcliente.TabIndex = 3;
            this.buttonPesquisarcliente.Text = "pesquisar cliente";
            this.buttonPesquisarcliente.UseVisualStyleBackColor = true;
            this.buttonPesquisarcliente.Click += new System.EventHandler(this.buttonPesquisarcliente_Click);
            // 
            // gerenciarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemoverClientes);
            this.Controls.Add(this.buttonPesquisarcliente);
            this.Controls.Add(this.dgvCliente);
            this.Name = "gerenciarCliente";
            this.Text = "gerenciarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button buttonRemoverClientes;
        private System.Windows.Forms.Button buttonPesquisarcliente;
    }
}
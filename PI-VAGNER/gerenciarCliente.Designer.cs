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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(2, 59);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(795, 327);
            this.dgvCliente.TabIndex = 1;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // buttonRemoverClientes
            // 
            this.buttonRemoverClientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRemoverClientes.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoverClientes.Location = new System.Drawing.Point(426, 392);
            this.buttonRemoverClientes.Name = "buttonRemoverClientes";
            this.buttonRemoverClientes.Size = new System.Drawing.Size(153, 46);
            this.buttonRemoverClientes.TabIndex = 4;
            this.buttonRemoverClientes.Text = "Remover cliente";
            this.buttonRemoverClientes.UseVisualStyleBackColor = false;
            this.buttonRemoverClientes.Click += new System.EventHandler(this.buttonRemoverClientes_Click);
            // 
            // buttonPesquisarcliente
            // 
            this.buttonPesquisarcliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPesquisarcliente.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisarcliente.Location = new System.Drawing.Point(160, 392);
            this.buttonPesquisarcliente.Name = "buttonPesquisarcliente";
            this.buttonPesquisarcliente.Size = new System.Drawing.Size(153, 46);
            this.buttonPesquisarcliente.TabIndex = 3;
            this.buttonPesquisarcliente.Text = "pesquisar cliente";
            this.buttonPesquisarcliente.UseVisualStyleBackColor = false;
            this.buttonPesquisarcliente.Click += new System.EventHandler(this.buttonPesquisarcliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "área de gerenciamento de login de usuários";
            // 
            // gerenciarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoverClientes);
            this.Controls.Add(this.buttonPesquisarcliente);
            this.Controls.Add(this.dgvCliente);
            this.Name = "gerenciarCliente";
            this.Text = "gerenciarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button buttonRemoverClientes;
        private System.Windows.Forms.Button buttonPesquisarcliente;
        private System.Windows.Forms.Label label1;
    }
}
﻿namespace PI_VAGNER
{
    partial class gerenciar_produtos
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
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.buttonPesquisarClientes = new System.Windows.Forms.Button();
            this.buttonRemoverClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToOrderColumns = true;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(12, 42);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(776, 334);
            this.dgvProduto.TabIndex = 0;
            // 
            // buttonPesquisarClientes
            // 
            this.buttonPesquisarClientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPesquisarClientes.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonPesquisarClientes.Location = new System.Drawing.Point(168, 392);
            this.buttonPesquisarClientes.Name = "buttonPesquisarClientes";
            this.buttonPesquisarClientes.Size = new System.Drawing.Size(153, 46);
            this.buttonPesquisarClientes.TabIndex = 1;
            this.buttonPesquisarClientes.Text = "pesquisar produtos";
            this.buttonPesquisarClientes.UseVisualStyleBackColor = false;
            this.buttonPesquisarClientes.Click += new System.EventHandler(this.buttonPesquisarClientes_Click);
            // 
            // buttonRemoverClientes
            // 
            this.buttonRemoverClientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRemoverClientes.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.buttonRemoverClientes.Location = new System.Drawing.Point(395, 392);
            this.buttonRemoverClientes.Name = "buttonRemoverClientes";
            this.buttonRemoverClientes.Size = new System.Drawing.Size(153, 46);
            this.buttonRemoverClientes.TabIndex = 2;
            this.buttonRemoverClientes.Text = "Remover produtos";
            this.buttonRemoverClientes.UseVisualStyleBackColor = false;
            this.buttonRemoverClientes.Click += new System.EventHandler(this.buttonRemoverClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "área de gerenciamento de cadastro de produto";
            // 
            // gerenciar_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoverClientes);
            this.Controls.Add(this.buttonPesquisarClientes);
            this.Controls.Add(this.dgvProduto);
            this.Name = "gerenciar_produtos";
            this.Text = "gerenciar_produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Button buttonPesquisarClientes;
        private System.Windows.Forms.Button buttonRemoverClientes;
        private System.Windows.Forms.Label label1;
    }
}
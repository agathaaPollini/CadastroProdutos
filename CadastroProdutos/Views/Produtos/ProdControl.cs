using CadastroProdutos.Models;
using CadastroProdutos.Views.Categoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroProdutos.Views.Produtos
{
    public partial class ProdControl : UserControl
    {
        Produto prod;
        FrmEditar form;
        public ProdControl(FrmEditar form, Produto prod)
        {
            InitializeComponent();
            this.form = form;
            this.prod = prod;

            lblId.Text = $"#{(prod.ID == null ? "--" : prod.ID)}";
            txtNome.Text = prod.Nome;
            numPreco.Value = (decimal)prod.Preco;

            if (prod.ID == null)
            {
                txtNome.Enabled = numPreco.Enabled = true;
                btnEditar.Text = "Confirmar";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Enabled == false)
            {
                txtNome.Enabled = numPreco.Enabled = true;
                btnEditar.Text = "Confirmar";
            }
            else
            {
                prod.Nome = txtNome.Text;
                prod.Preco = (double)numPreco.Value;
                txtNome.Enabled = numPreco.Enabled = false;
                btnEditar.Text = "Editar";
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Deseja realmente excluir o produto {prod.Nome}?", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                form.ExcluirProd(this, prod);
            }
        }
    }
}

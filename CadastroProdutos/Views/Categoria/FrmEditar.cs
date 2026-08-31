using CadastroProdutos.Models;
using CadastroProdutos.Presenters;
using CadastroProdutos.Views.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroProdutos.Views.Categoria
{
    public partial class FrmEditar : Form
    {
        CategoriaPresenter presenter;
        Models.Categoria categoria;
        public FrmEditar(CategoriaPresenter presenter, Models.Categoria categoria)
        {
            InitializeComponent();
            this.presenter = presenter;
            this.categoria = categoria;

            lblID.Text = $"#{categoria.ID}";
            txtNome.Text = categoria.Nome;

            foreach (Produto p in categoria.Produtos)
            {
                ProdControl ctr = new ProdControl(this, p);
                flpProds.Controls.Add(ctr);
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            categoria.Produtos.Add(new Produto(){
                Nome = "",
                Preco = 0
            });
            flpProds.Controls.Add(new ProdControl(this, categoria.Produtos.Last()));
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            categoria.Nome = txtNome.Text;
            if (presenter.Editar(categoria))
            {
                MessageBox.Show("Categoria salva!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao editar");
            }
        }

        public void ExcluirProd(ProdControl ctr, Produto prod)
        {
            categoria.Produtos.Remove(prod);
            flpProds.Controls.Remove(ctr);
        }
    }
}

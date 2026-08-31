using CadastroProdutos.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroProdutos.Views.Categoria
{
    public partial class FrmCadastrar : Form
    {
        CategoriaPresenter presenter;
        public FrmCadastrar(CategoriaPresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
        }

        private void FrmCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Models.Categoria cat = new Models.Categoria()
            {
                Nome = txtNome.Text.Trim()
            };
            if (presenter.Cadastrar(cat))
            {
                MessageBox.Show("Sucesso");
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }
    }
}

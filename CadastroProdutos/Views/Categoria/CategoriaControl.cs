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
    public partial class CategoriaControl : UserControl
    {
        Models.Categoria cat;
        CategoriaPresenter presenter;
        FrmListar grid;
        public CategoriaControl(FrmListar grid, CategoriaPresenter presenter, Models.Categoria cat)
        {
            InitializeComponent();
            this.cat = cat;
            this.presenter = presenter;
            this.grid = grid;

            lblId.Text = $"#{cat.ID} - {cat.Produtos.Count} produtos";
            lblNome.Text = cat.Nome;

            if(cat.Produtos.Count > 0)
            {
                btRemover.Enabled = false;
            }
        }

        private void CategoriaControl_Load(object sender, EventArgs e)
        {

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            FrmEditar f = new FrmEditar(presenter, cat);
            f.ShowDialog();
            grid.Atualizar();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Deseja mesmo remover a categoria {cat.Nome}?", "", MessageBoxButtons.YesNo);
            if(r== DialogResult.Yes)
            {
                if (presenter.Remover(cat))
                {
                    MessageBox.Show("Categoria excluída!");
                    grid.Atualizar();
                }
                else
                {
                    MessageBox.Show("Erro na exclusão");
                }
            }
        }
    }
}

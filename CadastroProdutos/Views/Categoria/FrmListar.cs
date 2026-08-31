using CadastroProdutos.Data;
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
    public partial class FrmListar : Form
    {
        Contexto db;
        CategoriaPresenter presenter;
        public FrmListar()
        {
            InitializeComponent();
            db = new Contexto();
            presenter = new CategoriaPresenter(db);
            Atualizar();
        }

        private void FrmListar_Load(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        public void Atualizar()
        {
            List<Models.Categoria> filtrados = presenter.Buscar(txtBusca.Text);

            flpItens.Controls.Clear();
            foreach (Models.Categoria cat in filtrados)
            {
                CategoriaControl ctr = new CategoriaControl(this, presenter, cat);
                flpItens.Controls.Add(ctr);
            }
        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrar f = new FrmCadastrar(presenter);
            f.ShowDialog();
            Atualizar();
        }
    }
}

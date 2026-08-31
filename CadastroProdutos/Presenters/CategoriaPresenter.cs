using CadastroProdutos.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProdutos.Presenters
{
    public class CategoriaPresenter
    {
        Contexto db;
        public CategoriaPresenter(Contexto db)
        {
            this.db = db;
        }

        public List<Models.Categoria> Buscar(string nome)
        {
            return db.Categorias.Where(c => c.Nome.ToUpper().Contains(nome.ToUpper()))
                .Include(c => c.Produtos)
                .ToList();
          
        }
        public bool Cadastrar(Models.Categoria categoria)
        {
            db.Categorias.Add(categoria);
            int linhas = db.SaveChanges();
            return linhas == 1;
        }

        public bool Remover(Models.Categoria categoria)
        {
            db.Categorias.Remove(categoria);
            int linhas = db.SaveChanges();
            return linhas > 0;
        }

        public bool Editar(Models.Categoria categoria)
        {
            db.Categorias.Update(categoria);
            int linhas = db.SaveChanges();
            return linhas > 0;
        }
    }
}

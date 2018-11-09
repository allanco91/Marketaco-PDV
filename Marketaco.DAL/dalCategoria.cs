using System;
using System.Collections.Generic;
using System.Linq;
using Marketaco.DOM.Entities;

namespace Marketaco.DAL
{
    public class dalCategoria
    {
        public void insereCategoria(Categoria obj_categoria)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    db.Categorias.Add(obj_categoria);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void atualizaCategoria(Categoria obj_categoria)
        {
            DataContext db = new DataContext();
            var achaIdCat = db.Categorias.Where(c => c.CategoriaID == obj_categoria.CategoriaID).SingleOrDefault();
            try
            {
                if (achaIdCat != null)
                {
                    achaIdCat.Nome = obj_categoria.Nome;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool deletaCategoria(int codigo)
        {
            using (DataContext db = new DataContext())
            {
                int i = (from p in db.Produtos
                         where p.CategoriaID == codigo
                         select p).Count();

                if (i > 0)
                    return false;
                else
                {
                    try
                    {
                        var achaIdCat = db.Categorias.Where(c => c.CategoriaID == codigo).SingleOrDefault();

                        db.Categorias.Remove(achaIdCat);
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public List<Categoria> listaCategorias()
        {
            DataContext db = new DataContext();
            return db.Categorias.OrderBy(c => c.Nome).ToList();
        }

        public List<Categoria> listaCategorias_nome(string nome)
        {
            DataContext db = new DataContext();
            return db.Categorias.Where(c => c.Nome.ToUpper().Contains(nome.ToUpper())).ToList();
        }
    }
}
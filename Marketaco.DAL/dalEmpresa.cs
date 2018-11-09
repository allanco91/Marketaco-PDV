using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketaco.DOM.Entities;

namespace Marketaco.DAL
{
    public class dalEmpresa
    {
        public void atualizaEmpresa(Empresa empresa)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    db.Empresas.Attach(empresa);
                    db.Entry(empresa).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public Empresa retornaEmpresa()
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    return db.Empresas.Single(e => e.EmpresaID == 1);
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }
    }
}

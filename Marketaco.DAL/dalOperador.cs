using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketaco.DOM.Entities;

namespace Marketaco.DAL
{
    public class dalOperador
    {
        public void addOperador(Operador operador)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    db.Operadores.Add(operador);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void updOperador(Operador operador)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    db.Operadores.Attach(operador);
                    db.Entry(operador).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void remOperador(int OperadorID)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    Operador operador = db.Operadores.SingleOrDefault(o => o.OperadorID == OperadorID);
                    db.Operadores.Remove(operador);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static Operador retornaOperador(int OperadorID)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    return db.Operadores.SingleOrDefault(o => o.OperadorID == OperadorID);
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }

        public Operador retornaOperador(string Login)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    return db.Operadores.SingleOrDefault(o => o.Login == Login);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool logar(string Login, string Senha)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    int verif = db.Operadores.Where(o => o.Login == Login && o.Senha == Senha).Count();
                    if (verif > 0)
                        return true;
                    else
                        return false;
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }

        public class OperadorV
        {
            public int OperadorID { get; set; }
            public string Nome { get; set; }
            public string Login { get; set; }
            public string Senha { get; set; }
            public string Adm { get; set; }
        }

        public List<OperadorV> listaOperador(string Nome)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    return db.Operadores.Where(o => o.Nome.ToUpper().Contains(Nome.ToUpper()))
                        .OrderBy(o => o.Nome)
                        .Select(o => new OperadorV
                        {
                            OperadorID = o.OperadorID,
                            Nome = o.Nome,
                            Login = o.Login,
                            Senha = "****",
                            Adm = o.Adm ? "Sim" : "Não"
                        }).ToList();
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }
    }
}

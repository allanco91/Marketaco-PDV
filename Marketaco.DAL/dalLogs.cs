using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketaco.DOM.Entities;

namespace Marketaco.DAL
{
    public class dalLogs
    {
        public static void addLog(string Operador, string Acao)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    //dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "");
                    Logs log = new Logs
                    {
                        Data = DateTime.Now,
                        Operador = Operador,
                        Acao = Acao
                    };
                    db.Log.Add(log);

                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<Logs> listaLog(DateTime Data1, DateTime Data2, string NOperador)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    string[] Ope = NOperador.ToUpper().Split(',');
                    List<Logs> ListaL = new List<Logs>();
                    DateTime DataFinal = new DateTime(Data2.Year, Data2.Month, Data2.Day, 23, 59, 59);

                    var L1 = db.Log.Where(l => l.Data >= Data1.Date && l.Data <= DataFinal)
                        .OrderBy(l => l.Data).ThenBy(l => l.Operador).ToList();

                    if (Ope != null && Ope.Length > 0)
                    {
                        foreach (string Operador in Ope)
                        {
                            ListaL.AddRange(L1.Where(l => l.Operador.StartsWith(Operador)));
                            L1.RemoveAll(l => l.Operador.StartsWith(Operador));
                        }
                    }

                    return ListaL;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}

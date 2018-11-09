using System.Collections.Generic;
using System.Linq;
using Marketaco.DOM.Entities;

namespace Marketaco.DAL
{
    public class dalUnidadeCom
    {
        public List<UnidadeCom> listaUnidadeCom()
        {
            DataContext db = new DataContext();

            return db.UnidadeComs.ToList();
        }
    }
}

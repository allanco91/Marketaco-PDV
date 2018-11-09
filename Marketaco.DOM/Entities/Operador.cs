using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketaco.DOM.Entities
{
    public class Operador
    {
        public int OperadorID { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Adm { get; set; }
    }
}

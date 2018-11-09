using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketaco.DOM.Entities
{
    public class Empresa
    {
        public int EmpresaID { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
    }
}

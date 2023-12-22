using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericoApp.Domain.Base.ValueObjects
{
    public class Endereco
    {
        public string Rua { get; private set; }
        public string CEP { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
    }
}

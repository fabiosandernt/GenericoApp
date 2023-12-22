using GenericoApp.Domain.Base;
using GenericoApp.Domain.FolhaPagamento.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericoApp.Domain.FolhaPagamento
{
    internal class FolhaPgto : Entity<Guid>
    {
        public Funcionario Funcionario { get; set; }
        public DateTime DataDePagamento { get; set; }
        public DetalhesPagamento DetalhesPagamento {get;set;}
    }
}

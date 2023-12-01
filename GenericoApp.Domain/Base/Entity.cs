using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace GenericoApp.Domain.Base
{
    public class Entity<T>
    {
        public virtual T Id { get; set; }
    }           
    
}

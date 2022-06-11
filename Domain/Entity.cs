using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    abstract class Entity
    {

        public long Id { get; set; }
        public bool IsDeleted { get; set; }


    }
}

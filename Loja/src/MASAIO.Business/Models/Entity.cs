using System;
using System.Collections.Generic;
using System.Text;

namespace MASAIO.Business.Models
{
    public class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}

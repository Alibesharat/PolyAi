using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Primal_e.Data
{
    public class User
    {
        [Key]
        public Guid Ic { get; set; }

        public string Name { get; set; }

        public string emailAddress { get; set; }

        public string Password { get; set; }
    }
}
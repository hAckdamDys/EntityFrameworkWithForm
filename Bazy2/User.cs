using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazy2
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Description { get; set; }
    }
}

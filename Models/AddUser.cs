using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Screens.Models
{
    public class AddUser
    {
        [Key]
        public int Id { get; set; }

        public string EmpId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}

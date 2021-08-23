using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Screens.Models
{
    public enum Priority
    {
        Low =1,
        Medium = 2,
        High = 3
    }
    public class AddProject
    {
        [Key]
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public Priority priority { get; set; }

        public virtual string FirstName { get; set; }
       
        [NotMapped]
        [ForeignKey("FirstName")]
        public virtual FirstName FirstNames { get; set; }
    }
}

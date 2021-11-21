using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Animals : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string AnimalKindName { get; set; }
    }
}

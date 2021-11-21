using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class VaccinationCard : IEntity
    {
        [Key]
        public int VaccinationCardId { get; set; }
        public string VaccinationName { get; set; }
        public int AnimalId { get; set; }
        public bool Vaccinated { get; set; }
        
    }
}

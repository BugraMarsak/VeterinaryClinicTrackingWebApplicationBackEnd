using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SurgDone : IEntity
    {
        public int SurgDoneId { get; set; }
        public DateTime SurgTime { get; set; }
        public string SurgName { get; set; }
        public string DocName { get; set; }
        public int AnimalId { get; set; }
    }
}

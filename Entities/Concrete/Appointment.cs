using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Appointment : IEntity
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentTime { get; set; }
        public int UserId { get; set; }
        public int AnimalId { get; set; }
        public string AppointmentType { get; set; }
    }
}

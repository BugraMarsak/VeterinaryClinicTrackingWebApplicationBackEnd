using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Personnel : IEntity
    {
        public int PersonnelId { get; set; }
        public string PersonnelPhoto { get; set; }
        public string PersonnelFullName { get; set; }
        public string PersonnelMail { get; set; }
        public string PersonnelPhoneNumber { get; set; }
    }
}

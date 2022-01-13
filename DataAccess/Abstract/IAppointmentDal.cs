using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAppointmentDal : IEntityRepository<Appointment>
    {
        public List<Appointment> getOrdered(DateTime time);
        public List<Appointment> gettimeOrdered(DateTime time);
    }
}

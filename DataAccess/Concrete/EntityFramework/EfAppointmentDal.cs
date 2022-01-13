using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAppointmentDal : EfEntityRepositoryBase<Appointment, VetContext>, IAppointmentDal
    {

        public List<Appointment> getOrdered(DateTime time)
        {
            using (VetContext context = new VetContext())
            {
                DateTime test1 = new DateTime(time.Year, time.Month, time.Day, 9, 0, 0);
                DateTime test2 = new DateTime(time.Year, time.Month, time.Day, 19, 59, 59);
                var result = from a in context.Appointment
                             orderby a.AppointmentTime
                             where a.AppointmentTime >= test1 && a.AppointmentTime<test2
                             select new Appointment
                             {
                                 AnimalId = a.AnimalId,
                                 AppointmentId = a.AppointmentId,
                                 AppointmentType = a.AppointmentType,
                                 UserId = a.UserId,
                                 AppointmentTime = a.AppointmentTime,
                             };


                return result.ToList(); 
            }

        }
        public List<Appointment> gettimeOrdered(DateTime time)
        {
            using (VetContext context = new VetContext())
            {
                DateTime test1 = new DateTime(time.Year, time.Month, time.Day, time.Hour, 0, 0);
                DateTime test2 = new DateTime(time.Year, time.Month, time.Day, time.Hour, 59, 59);
                var result = from a in context.Appointment
                             orderby a.AppointmentTime
                             where a.AppointmentTime >= test1 && a.AppointmentTime < test2
                             select new Appointment
                             {
                                 AnimalId = a.AnimalId,
                                 AppointmentId = a.AppointmentId,
                                 AppointmentType = a.AppointmentType,
                                 UserId = a.UserId,
                                 AppointmentTime = a.AppointmentTime,
                             };


                return result.ToList();
            }

        }

    }
}

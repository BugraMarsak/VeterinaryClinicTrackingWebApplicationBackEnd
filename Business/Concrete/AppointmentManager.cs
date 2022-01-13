using Business.Abstract;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        IAppointmentDal _appointmentDal;

        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        public IResult Add(Appointment appointment)
        {
            DateTime date =  DateTime.Now;
            if (appointment.AppointmentTime>date && Getcount(appointment.AppointmentTime).Data<5) {
                _appointmentDal.Add(appointment);
                return new SuccessResult(Messages.added);
            }
            return new ErrorResult(Messages.Wrong);
        }

        public IResult Delete(Appointment appointment)
        {
            _appointmentDal.Delete(appointment);
            return new SuccessResult(Messages.deleted);
        }

        public IDataResult<List<Appointment>> GetAll()
        {
            return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<Appointment>> GetById(int Id)
        {
            DateTime date = DateTime.Now;
            return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetAll(p => p.AnimalId == Id && p.AppointmentTime>date), Messages.Listed);
        }

        public IDataResult<List<Appointment>> GetByTime(DateTime time)
        {
            
            
            return new SuccessDataResult<List<Appointment>>(_appointmentDal.getOrdered(time), Messages.Listed);
        }

        public IDataResult<List<Appointment>> GetByTimeApp(DateTime time)
        {
            return new SuccessDataResult<List<Appointment>>(_appointmentDal.getOrdered(time), Messages.Listed);
        }

        public IDataResult<int> Getcount(DateTime time)
        {
            return new SuccessDataResult<int>(_appointmentDal.gettimeOrdered(time).Count(), Messages.Listed);
        }

        public IResult Update(Appointment appointment)
        {
            _appointmentDal.Update(appointment);
            return new SuccessResult(Messages.changed);
        }



        
    }
}

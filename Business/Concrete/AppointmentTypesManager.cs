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
    public class AppointmentTypesManager : IAppointmentTypesService
    {
        IAppointmentTypesDal _appointmentTypesDal;

        public AppointmentTypesManager(IAppointmentTypesDal appointmentTypesDal)
        {
            _appointmentTypesDal = appointmentTypesDal;
        }

        public IDataResult<List<AppointmentTypes>> GetAll()
        {
            return new SuccessDataResult<List<AppointmentTypes>>(_appointmentTypesDal.GetAll(), Messages.Listed);
        }

        public IDataResult<AppointmentTypes> GetById(int id)
        {
            return new SuccessDataResult<AppointmentTypes>(_appointmentTypesDal.Get(p => p.Id == id));

        }
    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAppointmentService
    {
        IDataResult<List<Appointment>> GetAll();
        IDataResult<List<Appointment>> GetById(int Id);
        IDataResult<List<Appointment>> GetByTime(DateTime time);
        IDataResult<List<Appointment>> GetByTimeApp(DateTime time);
        IDataResult<int> Getcount(DateTime time);
        IResult Add(Appointment appointment);
        IResult Delete(Appointment appointment);
        IResult Update(Appointment appointment);
    }
}

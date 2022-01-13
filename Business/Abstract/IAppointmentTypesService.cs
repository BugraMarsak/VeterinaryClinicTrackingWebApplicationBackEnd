using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAppointmentTypesService
    {
        IDataResult<List<AppointmentTypes>> GetAll();
        IDataResult<AppointmentTypes> GetById(int id);
    }
}

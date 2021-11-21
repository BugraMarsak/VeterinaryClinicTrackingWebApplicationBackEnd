using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVaccinationCardService
    {
        IDataResult<List<VaccinationCard>> GetAll();
        IDataResult<List<VaccinationCard>> GetById(int Id);
    }
}

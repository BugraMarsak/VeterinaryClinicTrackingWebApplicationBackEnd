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
        IDataResult<VaccinationCard> GetByVacId(int Id);
        IResult Add(VaccinationCard vaccinationCard);
        IResult Delete(VaccinationCard vaccinationCard);
        IResult Update(VaccinationCard vaccinationCard);
    }
}

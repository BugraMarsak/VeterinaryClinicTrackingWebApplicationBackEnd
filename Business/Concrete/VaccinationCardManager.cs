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
    class VaccinationCardManager : IVaccinationCardService
    {
        IVaccinationCardDal _vaccinationCardDal;

        public VaccinationCardManager(IVaccinationCardDal vaccinationCardDal)
        {
            _vaccinationCardDal = vaccinationCardDal;
        }

        public IResult Add(VaccinationCard vaccinationCard)
        {
            _vaccinationCardDal.Add(vaccinationCard);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(VaccinationCard vaccinationCard)
        {
            _vaccinationCardDal.Delete(vaccinationCard);
            return new SuccessResult(Messages.deleted);
        }

        public IDataResult<List<VaccinationCard>> GetAll()
        {
            return new SuccessDataResult<List<VaccinationCard>>(_vaccinationCardDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<VaccinationCard>> GetById(int Id)
        {   
            return new SuccessDataResult<List<VaccinationCard>>(_vaccinationCardDal.GetAll(p => p.AnimalId == Id ), Messages.Listed);
        }

        public IDataResult<VaccinationCard> GetByVacId(int Id)
        {
            return new SuccessDataResult<VaccinationCard>(_vaccinationCardDal.Get(p => p.VaccinationCardId == Id), Messages.Listed);

        }

        public IResult Update(VaccinationCard vaccinationCard)
        {
            _vaccinationCardDal.Update(vaccinationCard);
            return new SuccessResult(Messages.changed);
        }
    }
}

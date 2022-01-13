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
    public class AnimalInformationManager : IAnimalInformationService
    {
        IAnimalInformationDal _animalInformatinDal;

        public AnimalInformationManager(IAnimalInformationDal animalInformatinDal)
        {
            _animalInformatinDal = animalInformatinDal;
        }

        public IResult Add(AnimalInformation animalInformation)
        {
            _animalInformatinDal.Add(animalInformation);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(AnimalInformation animalInformation)
        {
            _animalInformatinDal.Delete(animalInformation);
            return new SuccessResult(Messages.deleted);
        }

        public IDataResult<List<AnimalInformation>> GetAll()
        {
            return new SuccessDataResult<List<AnimalInformation>>(_animalInformatinDal.GetAll(), Messages.Listed);
        }

        public IDataResult<AnimalInformation> GetByAnimalId(int AnimalId)
        {
            return new SuccessDataResult<AnimalInformation>(_animalInformatinDal.Get(p => p.AnimalId == AnimalId));
        }

        public AnimalInformation GetById(int AnimalId,string kind)
        {
            return (_animalInformatinDal.Get(p => p.AnimalId == AnimalId && p.AnimalKind == kind));
        }


        public IDataResult<List<AnimalInformation>> GetByUserId(int UserId)
        {
            return new SuccessDataResult<List<AnimalInformation>>(_animalInformatinDal.GetAll(p => p.userId == UserId));
        }

        public IResult Update(AnimalInformation animalInformation)
        {
            _animalInformatinDal.Update(animalInformation);
            return new SuccessResult(Messages.changed);
        }

        public IResult UserExist(int id,string kind)
        {
            if (GetById(id,kind) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}

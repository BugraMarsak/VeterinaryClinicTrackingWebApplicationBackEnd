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
            throw new NotImplementedException();
        }

        public IDataResult<List<AnimalInformation>> GetAll()
        {
            return new SuccessDataResult<List<AnimalInformation>>(_animalInformatinDal.GetAll(), Messages.Listed);
        }

        public IDataResult<AnimalInformation> GetById(int AnimalId)
        {
            return new SuccessDataResult<AnimalInformation>(_animalInformatinDal.Get(p => p.AnimalId == AnimalId));
        }

        //public IDataResult<AnimalInformation> GetById(int animalId)
        //{
        //    
        //}
    }
}

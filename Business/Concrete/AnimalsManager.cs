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
    public class AnimalsManager : IAnimalsService
    {
        IAnimalsDal _animalsDal;

        public AnimalsManager(IAnimalsDal animalsDal)
        {
            _animalsDal = animalsDal;
        }

        public IDataResult<List<Animals>> GetAll()
        {
            return new SuccessDataResult<List<Animals>>(_animalsDal.GetAll(), Messages.Listed);
        }
    }
}

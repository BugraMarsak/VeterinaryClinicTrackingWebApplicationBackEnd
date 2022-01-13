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
    public class AnimalRaceManager : IAnimalRaceService
    {
        IAnimalRaceDal _animalRaceDal;

        public AnimalRaceManager(IAnimalRaceDal animalRaceDal)
        {
            _animalRaceDal = animalRaceDal;
        }

        public IDataResult<List<AnimalRace>> GetById(int Id)
        {
            return new SuccessDataResult<List<AnimalRace>>(_animalRaceDal.GetAll(p => p.AnimalKind == Id), Messages.Listed);

        }
    }
}

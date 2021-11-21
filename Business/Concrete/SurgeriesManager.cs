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
    public class SurgeriesManager : ISurgeriesService
    {
        ISurgeriesDal _surgeriesDal;

        public SurgeriesManager(ISurgeriesDal surgeriesDal)
        {
            _surgeriesDal = surgeriesDal;
        }

        public IResult Add(Surgeries Surgeries)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Surgeries>> GetAll()
        {
            return new SuccessDataResult<List<Surgeries>>(_surgeriesDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Surgeries> GetById(int surgeryId)
        {
            throw new NotImplementedException();
        }
    }
}

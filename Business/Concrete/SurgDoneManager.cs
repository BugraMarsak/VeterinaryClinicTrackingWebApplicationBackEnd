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
    public class SurgDoneManager : ISurgDoneService
    {
        ISurgDoneDal _surgDoneDal;

        public SurgDoneManager(ISurgDoneDal surgDoneDal)
        {
            _surgDoneDal = surgDoneDal;
        }

        public IResult Add(SurgDone surgDone)
        {
            _surgDoneDal.Add(surgDone);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(SurgDone surgDone)
        {
            _surgDoneDal.Delete(surgDone);
            return new SuccessResult(Messages.deleted);
        }

        public IDataResult<List<SurgDone>> GetAll()
        {
            return new SuccessDataResult<List<SurgDone>>(_surgDoneDal.GetAll(), Messages.Listed);

        }

        public IDataResult<List<SurgDone>> GetById(int Id)
        {
            return new SuccessDataResult<List<SurgDone>>(_surgDoneDal.GetAll(p => p.AnimalId == Id), Messages.Listed);
        }

        public IResult Update(SurgDone surgDone)
        {
            _surgDoneDal.Update(surgDone);
            return new SuccessResult(Messages.changed);
        }
    }
}

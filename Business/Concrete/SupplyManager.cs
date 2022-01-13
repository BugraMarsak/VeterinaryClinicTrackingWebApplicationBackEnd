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
    public class SupplyManager : ISupplyService
    {
        ISupplyDal _supplyDal;

        public SupplyManager(ISupplyDal supplyDal)
        {
            _supplyDal = supplyDal;
        }

        public IResult Add(Supply supply)
        {
            _supplyDal.Add(supply);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(Supply supply)
        {
            _supplyDal.Delete(supply);
            return new SuccessResult(Messages.deleted);
        }

        public IDataResult<List<Supply>> GetAll()
        {
            return new SuccessDataResult<List<Supply>>(_supplyDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Supply> GetById(int Id)
        {
            return new SuccessDataResult<Supply>(_supplyDal.Get(p => p.SupplyId == Id), Messages.Listed);
        }

        public IResult Update(Supply supply)
        {
            _supplyDal.Update(supply);
            return new SuccessResult(Messages.changed);
        }
    }
}

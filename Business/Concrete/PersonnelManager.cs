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
    class PersonnelManager : IPersonnelService
    {
        IPersonnelDal _personnelDal;

        public PersonnelManager(IPersonnelDal personnelDal)
        {
            _personnelDal = personnelDal;
        }

        public IDataResult<List<Personnel>> GetAll()
        {
            return new SuccessDataResult<List<Personnel>>(_personnelDal.GetAll(), Messages.Listed);

        }
    }
}

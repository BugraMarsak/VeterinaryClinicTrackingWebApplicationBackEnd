using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISupplyService
    {
        IDataResult<List<Supply>> GetAll();
        IResult Add(Supply supply);
        IResult Delete(Supply supply);
        IResult Update(Supply supply);
        IDataResult<Supply> GetById(int Id);
    }
}

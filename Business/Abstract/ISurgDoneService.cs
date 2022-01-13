using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISurgDoneService
    {
        IDataResult<List<SurgDone>> GetAll();
        IResult Add(SurgDone surgDone);
        IResult Delete(SurgDone surgDone);
        IResult Update(SurgDone surgDone);
        IDataResult<List<SurgDone>> GetById(int Id);
    }
}

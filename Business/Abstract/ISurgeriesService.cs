using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISurgeriesService
    {
        IDataResult<List<Surgeries>> GetAll();
        IDataResult<Surgeries> GetById(int surgeryId);
        IResult Add(Surgeries Surgeries);
    }
}

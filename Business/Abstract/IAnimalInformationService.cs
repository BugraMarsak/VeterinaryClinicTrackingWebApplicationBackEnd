using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAnimalInformationService
    {
        IDataResult<List<AnimalInformation>> GetAll();
        IDataResult<AnimalInformation> GetByAnimalId(int AnimalId);
        AnimalInformation GetById(int AnimalId,string kind);
        IDataResult<List<AnimalInformation>> GetByUserId(int UserId);
        IResult Add(AnimalInformation animalInformation);
        IResult Update(AnimalInformation animalInformation);
        IResult Delete(AnimalInformation animalInformation);
        IResult UserExist(int id, string kind);
    }
}

using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfVaccinationCardDal : EfEntityRepositoryBase<VaccinationCard, VetContext>, IVaccinationCardDal
    {
        //public IDataResult<List<VaccinationCard>> GetById(int Id)
        //{

        //    using (var context = new VetContext())
        //    {
        //        var result = from v in context.VaccinationCard
        //                     join a in context.AnimalInformation
        //                     on v.AnimalId equals a.AnimalId
        //                     where v.AnimalId ==Id && a.AnimalKind
        //                     select new VaccinationCard{ Id = operationClaim.Id, Name = operationClaim.Name };
        //        return result.ToList();

        //    }
        //    return new SuccessDataResult<List<VaccinationCard>>(_vaccinationCardDal.GetAll(p => p.AnimalId == Id), Messages.Listed);
            
        //}
    }
}

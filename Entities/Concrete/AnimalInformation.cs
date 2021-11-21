using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AnimalInformation : IEntity
    {
        public int Id { get; set; }//
        public int AnimalId { get; set; } //küpe numarası
        public string AnimalName { get; set; }
        public string AnimalKind { get; set; }// köpek,kedi
        public string AnimalRace { get; set; }// husky,golden
        public bool Neutered { get; set; }//kısırlaştırılmış mı?
        public string AnimalColor { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public string OwnerName { get; set; }
    }
}

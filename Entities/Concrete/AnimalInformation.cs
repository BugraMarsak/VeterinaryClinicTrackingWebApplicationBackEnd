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
        public int userId { get; set; }
        public int AnimalId { get; set; } //küpe numarası
        public string AnimalName { get; set; }
        public string AnimalKind { get; set; }// köpek,kedi
        public string AnimalRace { get; set; }// husky,golden
        public bool Neutered { get; set; }//kısırlaştırılmış mı?
        public string Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public string AnimalColor { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public string OwnerName { get; set; }
        public string AnimalPhoto { get; set; }

    }
}
